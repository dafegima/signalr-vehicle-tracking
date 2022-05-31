using SignalR.Example.Service.Models;

namespace SignalR.Example.Service.Infrastructure.Interfaces
{
    public interface IVehicleEventsRepository
    {
        IEnumerable<VehicleEvent> Get();
    }
}
