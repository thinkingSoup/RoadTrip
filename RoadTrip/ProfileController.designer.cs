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
    [Register ("ProfileController")]
    partial class ProfileController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel bioText { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel currentTripLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel favrtNum { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel fbLink { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel hometownLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lastrtNum { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextView nameText { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel totaldistLabel { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (bioText != null) {
                bioText.Dispose ();
                bioText = null;
            }

            if (currentTripLabel != null) {
                currentTripLabel.Dispose ();
                currentTripLabel = null;
            }

            if (favrtNum != null) {
                favrtNum.Dispose ();
                favrtNum = null;
            }

            if (fbLink != null) {
                fbLink.Dispose ();
                fbLink = null;
            }

            if (hometownLabel != null) {
                hometownLabel.Dispose ();
                hometownLabel = null;
            }

            if (lastrtNum != null) {
                lastrtNum.Dispose ();
                lastrtNum = null;
            }

            if (nameText != null) {
                nameText.Dispose ();
                nameText = null;
            }

            if (totaldistLabel != null) {
                totaldistLabel.Dispose ();
                totaldistLabel = null;
            }
        }
    }
}