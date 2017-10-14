using System;

public class User
{
    private string name;
    private string userName;
    private string password;
    private double miles;
    private List<string> sightsPrefs;
    private List<User> friends;
    private Trip currentTrip;
    private List<Trip> trips;


    public string getName()
    {
        return name;
    }

    public string setName(string val)
    {
        name = val;
    }

    public string getUserName()
    {
        return userName;
    }

    public string setUserName(string val)
    {
        userName = val;
    }

    public string getPassword()
    {
        return password;
    }

    public string setPassword(string val)
    {
        password = val;
    }

    public double getMiles()
    {
        return miles;
    }

    public double setMiles(double val) //make a function that increments miles as well?
    {
        miles = val;
    }

    public List<string> getSightPrefs()
    {
        return sightsPrefs;
    }

    public List<string> setSightPrefs(List<string> vals)
    {
        sightsPrefs = vals;
    }

    public List<User> getFriends()
    {
        return friends;
    }

    public List<User> setFriends(List<User> vals)
    {
        friends = vals;
    }

    public Trip getCurrentTrip()
    {
        return currentTrip;
    }

    public Trip setCurrentTrip(Trip val)
    {
        currentTrip = val;
    }

    public List<Trip> getTrips()
    {
        return trips;
    }

    public List<Trip> setTrips(List<Trip> vals)
    {
        trips = vals;
    }
}
