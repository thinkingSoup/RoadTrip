using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using MapKit;
namespace RoadTrip.Model
{
    public class Trip
    {
        public Trip(Model.User user)
        {
            stops = new List<MKMapPoint>();
            checkIns = new List<Checkin>();
            userID = user.id;
        }
        public string id {
            get {
                return tripName;
            }
        }
        public string userID { get; set; }
        public string tripName { get; set; }
        public double distance { get; set; }
        public double days { get; set; }
        public List<MKMapPoint> stops { get; set; }
        public MKRoute route { get; set; }
        public List<Checkin> checkIns { get; set; }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }

    }
}