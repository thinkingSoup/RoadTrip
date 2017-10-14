// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace RoadTrip
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton aboardButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel bioText { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField cityInput { get; set; }

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
        UIKit.UIButton okayButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel questionText { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITableView tableLike2C { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel totaldistLabel { get; set; }

        [Action ("AboardButton_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void AboardButton_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (aboardButton != null) {
                aboardButton.Dispose ();
                aboardButton = null;
            }

            if (bioText != null) {
                bioText.Dispose ();
                bioText = null;
            }

            if (cityInput != null) {
                cityInput.Dispose ();
                cityInput = null;
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

            if (okayButton != null) {
                okayButton.Dispose ();
                okayButton = null;
            }

            if (questionText != null) {
                questionText.Dispose ();
                questionText = null;
            }

            if (tableLike2C != null) {
                tableLike2C.Dispose ();
                tableLike2C = null;
            }

            if (totaldistLabel != null) {
                totaldistLabel.Dispose ();
                totaldistLabel = null;
            }
        }
    }
}