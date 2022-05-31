using SignalR.Example.Service.Infrastructure.Interfaces;
using SignalR.Example.Service.Models;

namespace SignalR.Example.Service.Infrastructure.Repositories
{
    public class VehicleEventsRepository : IVehicleEventsRepository
    {
        public IEnumerable<VehicleEvent> Get()
        {
            List<VehicleEvent> vehicleEvents = new List<VehicleEvent>();
            vehicleEvents.Add(new VehicleEvent("ABC123", 6.212492724251743, -75.57465002279845, 50));
            vehicleEvents.Add(new VehicleEvent("ABC123", 6.211982578264478, -75.57389251125292, 50));
            vehicleEvents.Add(new VehicleEvent("ABC123", 6.211715941278804, -75.57323803901227, 50));
            vehicleEvents.Add(new VehicleEvent("ABC123", 6.2114812887492254, -75.57272305213976, 50));
            vehicleEvents.Add(new VehicleEvent("ABC123", 6.2111613057701724, -75.5719720271354, 50));
            vehicleEvents.Add(new VehicleEvent("ABC123", 6.210905316105923, -75.57125318525438, 50));
            vehicleEvents.Add(new VehicleEvent("ABC123", 6.210606659056449, -75.57045923584687, 50));
            vehicleEvents.Add(new VehicleEvent("ABC123", 6.210521328730537, -75.57028757048779, 50));
            vehicleEvents.Add(new VehicleEvent("ABC123", 6.210489327362398, -75.57007298793413, 50));
            vehicleEvents.Add(new VehicleEvent("ABC123", 6.210361330064613, -75.56975111370289, 50));
            vehicleEvents.Add(new VehicleEvent("ABC123", 6.210137368499775, -75.56917178225274, 50));
            vehicleEvents.Add(new VehicleEvent("ABC123", 6.209924043324702, -75.56874261988156, 50));
            vehicleEvents.Add(new VehicleEvent("ABC123", 6.209710738234067, -75.56808817114539, 50));
            vehicleEvents.Add(new VehicleEvent("ABC123", 6.20938075849314, -75.56722521042234, 50));
            vehicleEvents.Add(new VehicleEvent("ABC123", 6.209116976614678, -75.56657660567012, 50));
            vehicleEvents.Add(new VehicleEvent("ABC123", 6.20889716085018, -75.56606067284754, 50));
            vehicleEvents.Add(new VehicleEvent("ABC123", 6.2087726014003675, -75.56565530081185, 50));
            vehicleEvents.Add(new VehicleEvent("ABC123", 6.208926473333983, -75.56544892501876, 50));
            vehicleEvents.Add(new VehicleEvent("ABC123", 6.209212236499843, -75.56536047597876, 50));
            vehicleEvents.Add(new VehicleEvent("ABC123", 6.209410072614639, -75.56527202733506, 50));
            vehicleEvents.Add(new VehicleEvent("ABC123", 6.209527309569166, -75.5654341789739, 50));
            vehicleEvents.Add(new VehicleEvent("ABC123", 6.2096005827787835, -75.56559633086185, 50));
            vehicleEvents.Add(new VehicleEvent("ABC123", 6.209644544784012, -75.56570688745207, 50));
            vehicleEvents.Add(new VehicleEvent("ABC123", 6.209849709720208, -75.56625967749824, 50));
            vehicleEvents.Add(new VehicleEvent("ABC123", 6.210025561903238, -75.56659134487656, 50));
            vehicleEvents.Add(new VehicleEvent("ABC123", 6.21012814434173, -75.56692301887337, 50));
            vehicleEvents.Add(new VehicleEvent("ABC123", 6.210362614016305, -75.56762321270061, 50));
            vehicleEvents.Add(new VehicleEvent("ABC123", 6.210509159897356, -75.56800647965744, 50));
            vehicleEvents.Add(new VehicleEvent("ABC123", 6.210714319516503, -75.56851504069323, 50));
            vehicleEvents.Add(new VehicleEvent("ABC123", 6.210860862561467, -75.56890567389058, 50));
            vehicleEvents.Add(new VehicleEvent("ABC123", 6.211131970200372, -75.56967957448698, 50));
            vehicleEvents.Add(new VehicleEvent("ABC123", 6.2115496216353545, -75.57050506983957, 50));
            vehicleEvents.Add(new VehicleEvent("ABC123", 6.211747453087595, -75.57081463041312, 50));
            vehicleEvents.Add(new VehicleEvent("ABC123", 6.212025888312359, -75.57130108256517, 50));
            vehicleEvents.Add(new VehicleEvent("ABC123", 6.212165105846674, -75.5716180134861, 50));
            vehicleEvents.Add(new VehicleEvent("ABC123", 6.21237026639873, -75.57233295024099, 50));
            vehicleEvents.Add(new VehicleEvent("ABC123", 6.212568101189906, -75.57267936261965, 50));
            vehicleEvents.Add(new VehicleEvent("ABC123", 6.212824553619853, -75.57326163075047, 50));
            vehicleEvents.Add(new VehicleEvent("ABC123", 6.2128465352259425, -75.57354170929615, 50));
            vehicleEvents.Add(new VehicleEvent("ABC123", 6.212890498398237, -75.57389549289056, 50));
            vehicleEvents.Add(new VehicleEvent("ABC123", 6.212797761101075, -75.57394312402492, 50));
            vehicleEvents.Add(new VehicleEvent("ABC123", 6.21254179781319, -75.57409958965984, 50));
            vehicleEvents.Add(new VehicleEvent("ABC123", 6.212423660916604, -75.57416098753568, 50));
            vehicleEvents.Add(new VehicleEvent("ABC123", 6.21230946189494, -75.5742184242595, 50));
            vehicleEvents.Add(new VehicleEvent("ABC123", 6.212234641811268, -75.57426793870256, 50));

            return vehicleEvents;
        }
    }
}
