using Foundation;
using System;
using UIKit;
using MapKit;

namespace RoadTrip
{
    public partial class NewTripController : UIViewController
    {
        public NewTripController (IntPtr handle) : base (handle)
        {
        }
        public Model.User user { get; set; }

        public MKRoute NewRoute(MKMapItem start, MKMapItem finish)
        {
            MKDirectionsRequest drivingRouteRequest = new MKDirectionsRequest();
            drivingRouteRequest.TransportType = MKDirectionsTransportType.Automobile;
            drivingRouteRequest.Source = start;
            drivingRouteRequest.Destination = finish;

            MKRoute drivingRoute = null;

            MKDirections drivingRouteDirections = new MKDirections( drivingRouteRequest);
            drivingRouteDirections.CalculateDirections((drivingRouteResponse, drivingRouteError) =>
            {
                if (drivingRouteError != null)
                {
                    drivingRoute = null;
                }
                else
                {
                    // The code doesn't request alternate routes, so add the single calculated route to
                    // a previously declared MKRoute property called walkingRoute.
                    drivingRoute = drivingRouteResponse.Routes[0];
                }
            });
            return drivingRoute;
            var rteLine = new MKPolylineRenderer(drivingRoute.Polyline)
            {
                LineWidth = 5.0f,
                StrokeColor = UIColor.Purple
            };

            mapView.GetRendererForOverlay = (mv, ol) => rteLine;
            mapView.AddOverlay(route.Polyline, MKOverlayLevel.AboveRoads);
        }
}
    }
