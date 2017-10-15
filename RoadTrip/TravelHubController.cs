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
            map = new MKMapView(UIScreen.MainScreen.Bounds);
            View = map;
            map.ZoomEnabled = true;
            map.ScrollEnabled = true;
            CLLocationManager locationManager = new CLLocationManager();
            locationManager.RequestWhenInUseAuthorization();
            map.ShowsUserLocation = true;
        }
    }
}