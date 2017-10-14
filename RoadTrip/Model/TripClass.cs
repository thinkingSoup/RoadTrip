using System;
namespace RoadTrip.Model
{
    public class Trip
    {
        private string tripName { get; set; }
        private double distance { get; set; }
        private double days { get; set; }
        private float price { get; set; }

        public Trip(string _tripName, double _distance, double _days, float _price)
        {
            tripName = _tripName;
            distance = _distance;
            days = _days;
            price = _price;
        }
    }
}