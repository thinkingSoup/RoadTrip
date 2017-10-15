using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using MapKit;
using MKDirections;
namespace RoadTrip.Model
{
    public class Trip
    {
        public Trip()
        {
            stops = new List<MKMapPoint>();
            checkIns = new List<Checkin>();
        }
        public int id
        {
            get
            {
                return tripName.GetHashCode();
            }
        }
        public string tripName { get; set; }
        public double distance { get; set; }
        public double days { get; set; }
        public List<MKMapPoint> stops { get; set; }
        public MKRoute route { get; set; }
        public List<Checkin> checkIns { get; set; }

        public MKRoute newRoute (MKMapItem start, MKMapItem finish)
        {
            MKDirectionsRequest *drivingRouteRequest = [[MKDirectionsRequest alloc] init];
            drivingRouteRequest.transportType = MKDirectionsTransportTypeAutomobile;
            [drivingRouteRequest setSource:[start]];
            [drivingRouteRequest setDestination:[finish]];

            MKDirections *drivingRouteDirections = [[MKDirections alloc] initWithRequest:drivingRouteRequest];
            [drivingRouteDirections calculateDirectionsWithCompletionHandler:^(MKDirectionsResponse * drivingRouteResponse, NSError *drivingRouteError) {
            if (drivingRouteError) {
                [self handleDirectionsError:drivingRouteError];
            } else {
                // The code doesn't request alternate routes, so add the single calculated route to
                // a previously declared MKRoute property called walkingRoute.
                self.drivingRoute = drivingRouteResponse.routes[0];
            }
        }];
        }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }

    }
}