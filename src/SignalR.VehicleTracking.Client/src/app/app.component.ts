import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';
import { VehicleModel } from './models/VehicleModel';
import { SignalrService } from './services/signalr.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css'],
})
export class AppComponent implements OnInit {
  // google maps zoom level
  zoom: number = 16;

  // initial center position for the map
  lat: number = 6.212492724251743;
  lng: number = -75.57465002279845;

  vehicle: VehicleModel;

  title = 'vehicle-tracking-signalr';
  constructor(public signalRService: SignalrService) {}
  ngOnInit() {
    this.signalRService.StartConnection();
    const sequence = new Observable(
      this.signalRService.addVehicleEventsDataListener
    );

    sequence.subscribe({
      next: (data) => this.vehicle = data,
      error: (e) => console.error(e),
      complete: () => console.info('complete'),
    });
  }
}
