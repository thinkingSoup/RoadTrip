using System;
using System.Collections.Generic;
using Newtonsoft.Json;
namespace RoadTrip.Model
{
    public class User
    {
        public string id { get; set; }
        public string name { get; set; }
        public double miles { get; set; }
        //private List<User> friends { get; set; }
        public int currentTrip { get; set; }
        //private List<Trip> trips { get; set; }

        public void incrementMiles(double dist)
        {
            miles = miles + dist;
        }

        /*public void addFriend(User person)
        {
            friends.Add(person);
        }*/

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }

    }
}
