using Foundation;
using System;
using UIKit;

namespace RoadTrip
{
    public partial class NewTripController : UIViewController
    {
        public NewTripController (IntPtr handle) : base (handle)
        {
        }
        public Model.User user { get; set; }
    }
}