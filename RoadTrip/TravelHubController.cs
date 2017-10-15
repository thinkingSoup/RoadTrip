using Foundation;
using System;
using UIKit;
using MapKit;
using CoreLocation;

namespace RoadTrip
{
    public partial class TravelHubController : UIViewController
    {
        public TravelHubController (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad() {
            base.ViewDidLoad();
            map.ShowUserLocation = true;
            CLLocationManager locationManager = new CLLocationManager();
            locationManager.RequestWhenInUseAuthorization();
        }
    }
}