using Foundation;
using System;
using UIKit;

namespace RoadTrip
{
    public partial class ProfileController : UIViewController
    {
        public ProfileController (IntPtr handle) : base (handle)
        {
            totaldistLabel = User.miles;
            nameText = User.name;
        }
    }
}