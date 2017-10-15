using Foundation;
using System;
using UIKit;
using MapKit;
using MKDirections;

namespace RoadTrip
{
    public partial class NewTripController : UIViewController
    {
        public NewTripController (IntPtr handle) : base (handle)
        {
        }
        public Model.User user { get; set; }

        public MKRoute newRoute(MKMapItem start, MKMapItem finish)
        {
            MKDirectionsRequest drivingRouteRequest = new MKDirectionsRequest();
            drivingRouteRequest.TransportType = MKDirectionsTransportType.Automobile;
            drivingRouteRequest.Source = start;
            drivingRouteRequest.Destination = finish;

            MKDirections drivingRouteDirections = new MKDirections( drivingRouteRequest);
            drivingRouteDirections.calculateDirections(delegate (MKDirectionsHandler drivingRouteResponse, NSError drivingRouteError)
            {
                if (drivingRouteError)
                {
                    self.handleDirectionsError(drivingRouteError);
                }
                else
                {
                    // The code doesn't request alternate routes, so add the single calculated route to
                    // a previously declared MKRoute property called walkingRoute.
                    self.drivingRoute = drivingRouteResponse.routes[0];
                }
            });
        }
    }
}