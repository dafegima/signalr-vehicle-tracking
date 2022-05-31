using SignalR.Example.Service.Models;

namespace SignalR.Example.Service.Infrastructure.Interfaces
{
    public interface INotifierHub
    {
        Task SendMessage(VehicleEvent vehicleEvent);
    }
}
