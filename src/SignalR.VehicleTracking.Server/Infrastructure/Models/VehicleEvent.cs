using Newtonsoft.Json;

namespace SignalR.Example.Service.Models
{
    public class VehicleEvent
    {
        public VehicleEvent(string licensePlate, double latitude, double longitude, int speed)
        {
            LicensePlate = licensePlate;
            Latitude = latitude;
            Longitude = longitude;
            Speed = speed;
        }

        [JsonProperty("licensePlate")]
        public string LicensePlate { get; set; }
        [JsonProperty("latitude")]
        public double Latitude { get; set; }
        [JsonProperty("longitude")]
        public double Longitude { get; set; }
        [JsonProperty("speed")]
        public int Speed { get; set; }
    }
}
