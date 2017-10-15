using Foundation;
using System;
using UIKit;

namespace RoadTrip
{
    public partial class PrefsController : UIViewController
    {
        public PrefsController (IntPtr handle) : base (handle)
        {
        }
        public Model.User user { get; set; }
    }
}