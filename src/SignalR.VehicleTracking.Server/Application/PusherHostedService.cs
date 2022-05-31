using Microsoft.AspNetCore.SignalR;
using Newtonsoft.Json;
using SignalR.Example.Service.Infrastructure.Interfaces;
using SignalR.Example.Service.Models;

namespace SignalR.Example.Service.Application
{
    public class PusherHostedService : BackgroundService
    {
        private Timer _timer;
        private readonly IVehicleEventsRepository _vehicleEventsRepository;
        private readonly ILogger<PusherHostedService> _logger;
        private readonly INotifierHub _notifierHub;
        private readonly IHubContext<NotifierHub> _not;

        public PusherHostedService(ILogger<PusherHostedService> logger, IHubContext<NotifierHub> not, IVehicleEventsRepository vehicleEventsRepository, INotifierHub notifierHub)
        {
            _logger = logger;
            _vehicleEventsRepository = vehicleEventsRepository;
            _notifierHub = notifierHub;
            _not = not;
        }
        protected override Task ExecuteAsync(CancellationToken stoppingToken)
        {
            _timer = new Timer(DoWork, null, TimeSpan.Zero, TimeSpan.FromSeconds(140));
            return Task.CompletedTask;
        }

        private void DoWork(object state)
        {
            IEnumerable<VehicleEvent> vehicleEvents = _vehicleEventsRepository.Get();

            _logger.LogInformation($"Init process.");
            foreach (var item in vehicleEvents)
            {
                _notifierHub.SendMessage(item);
                _logger.LogInformation($"Event notified: {JsonConvert.SerializeObject(item)}");
                Thread.Sleep(3000);
            }
            _logger.LogInformation($"End process.");

        }
    }
}
