using System;
using System.Collections.Generic;
namespace RoadTrip.Model
{
    public class User
    {
        private string name { get; set; }
        private string userName { get; set; }
        private string password { get; set; }
        private double miles { get; set; }
        private List<string> sightsPrefs { get; set; }
        private List<User> friends { get; set; }
        private Trip currentTrip { get; set; }
        private List<Trip> trips { get; set; }

        public User(string _name, string _userName, string _password, double _miles, List<string> _sightsPrefs, List<User> _friends, Trip _currentTrip, List<Trip> _trips)
        {
            name = _name;
            userName = _userName;
            password = _password;
            miles = _miles;
            sightsPrefs = _sightsPrefs;
            friends = _friends;
            currentTrip = _currentTrip;
            trips = _trips;
        }

        public void incrementMiles(double dist)
        {
            miles = miles + dist;
        }

    }
}
