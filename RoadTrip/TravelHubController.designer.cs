// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace RoadTrip
{
    [Register ("TravelHubController")]
    partial class TravelHubController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton checkInButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel distanceLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel priceLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel timelabel { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (checkInButton != null) {
                checkInButton.Dispose ();
                checkInButton = null;
            }

            if (distanceLabel != null) {
                distanceLabel.Dispose ();
                distanceLabel = null;
            }

            if (priceLabel != null) {
                priceLabel.Dispose ();
                priceLabel = null;
            }

            if (timelabel != null) {
                timelabel.Dispose ();
                timelabel = null;
            }
        }
    }
}