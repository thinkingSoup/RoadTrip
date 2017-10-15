using System;
using UIKit;
using CoreLocation;
using MapKit;
using Newtonsoft.Json;
namespace RoadTrip.Model
{
    public class Checkin
    {
        public DateTime timeStamp { get; set; }
        public string pictureUrl { get; set; }
        public string description { get; set; }
        public MKMapPoint location { get; set; }
        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
