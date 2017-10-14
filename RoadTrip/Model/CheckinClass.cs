using System;
using System.Drawing;
using UIKit;
using CoreLocation;
//TODO: make serializable for storing in database!
namespace RoadTrip.Model
{
    public class Checkin
    {
        public DateTime timeStamp { get; set; }
        public UIImage picture { get; set; }
        public string description { get; set; }
        public CLLocation location { get; set; }
        public Checkin(DateTime _timeStamp, UIImage _image, string _desc, CLLocation _loc)
        {
            timeStamp = _timeStamp;
            picture = _image;
            description = _desc;
            location = _loc;
        }
    }
}
