using System;

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

    public double incrementMiles(double dist)
    {
        miles = miles + dist;
    }

}
