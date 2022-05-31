import { Injectable } from '@angular/core';
import * as signalR from '@microsoft/signalr';
import { Observable, Observer } from 'rxjs';
import { VehicleModel } from '../models/VehicleModel';

@Injectable({
  providedIn: 'root',
})
export class SignalrService {
  public data: VehicleModel;

  private hubConnection: signalR.HubConnection;

  constructor() {
    this.hubConnection = new signalR.HubConnectionBuilder()
      .withUrl('http://localhost:5059/notifierHub', {
        skipNegotiation: true,
        transport: signalR.HttpTransportType.WebSockets,
      })
      .withAutomaticReconnect()
      .configureLogging(signalR.LogLevel.None)
      .build();

    this.hubConnection.serverTimeoutInMilliseconds = 1000 * 60 * 2;
    this.hubConnection.keepAliveIntervalInMilliseconds = 1000 * 60;

    this.StartConnection();
  }

  StartConnection() {
    if (
      this.hubConnection &&
      this.hubConnection.state != signalR.HubConnectionState.Disconnected
    ) {
      return;
    }

    this.hubConnection
      .start()
      .then(() => {
        console.log('connection started');
        console.log('SignalR Connected!');
        this.hubConnection.invoke('Register', 'ABC123');
        console.log('License plate register on Hub');
      })
      .catch(function (err) {
        return console.error(err.toString());
      });

    this.hubConnection.onreconnected((connectionId) => {
      console.log('SignalR Re-Connected!');
      this.hubConnection.invoke('Register', 'ABC123');
    });
  }

  public addVehicleEventsDataListener = (observer: Observer<VehicleModel>) => {
    debugger
    this.hubConnection.on('vehicleEvent', (data) => {
      console.log("Message received: " + data);
      observer.next(JSON.parse(data));
    });

    // unsubscribe function doesn't need to do anything in this
    // because values are delivered synchronously
    return {unsubscribe() {}};
  }
}
