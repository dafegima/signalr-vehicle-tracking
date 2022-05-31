using Microsoft.AspNetCore.SignalR;
using Newtonsoft.Json;
using SignalR.Example.Service.Infrastructure.Interfaces;
using SignalR.Example.Service.Models;

namespace SignalR.Example.Service.Application
{
    public class NotifierHub : Hub, INotifierHub
    {
        private readonly Dictionary<string, List<string>> registeredConnections;
        private readonly ILogger<NotifierHub> _logger;
        private readonly IHubContext<NotifierHub> _hubContext;

        public NotifierHub(ILogger<NotifierHub> logger, IHubContext<NotifierHub> hubContext)
        {
            registeredConnections = new Dictionary<string, List<string>>();
            _logger = logger;
            _hubContext = hubContext;
        }

        public async Task SendMessage(VehicleEvent vehicleEvent)
        {
            await _hubContext.Clients.Group(vehicleEvent.LicensePlate.ToUpper()).SendAsync("vehicleEvent", JsonConvert.SerializeObject(vehicleEvent));
        }

        public override async Task OnDisconnectedAsync(Exception exception)
        {
            await DeleteAssigments(Context.ConnectionId);
            await base.OnDisconnectedAsync(exception);
        }

        public async Task Register(string licensePlate)
        {
            try
            {
                _logger.LogInformation($"License plate register on HUB {licensePlate}");
                await RegisterLicensePlates(Context.ConnectionId, new List<string>() { licensePlate.ToUpper() });
                await Groups.AddToGroupAsync(Context.ConnectionId, licensePlate.ToUpper());
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error on register license plate on hub.");
            }
        }

        private async Task RegisterLicensePlates(string connectionId, List<string> plates)
        {
            lock (registeredConnections)
            {
                if (registeredConnections.ContainsKey(connectionId))
                {
                    var value = registeredConnections[connectionId];
                    var newPlates = plates.Where(x => !value.Any(y => x == y));
                    value.AddRange(newPlates);

                    registeredConnections[connectionId] = value;
                }
                else
                {
                    registeredConnections.Add(connectionId, plates);
                }
            }
        }

        private async Task DeleteAssigments(string connId)
        {
            try
            {
                lock (registeredConnections)
                {
                    registeredConnections[connId] = null;
                    registeredConnections.Remove(connId);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error on delete connection");
            }
        }

    }
}
