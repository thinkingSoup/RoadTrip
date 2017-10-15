using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using MapKit;
using MKDirections;
namespace RoadTrip.Model
{
    public class Trip
    {
        public Trip()
        {
            stops = new List<MKMapPoint>();
            checkIns = new List<Checkin>();
        }
        public int id
        {
            get
            {
                return tripName.GetHashCode();
            }
        }
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