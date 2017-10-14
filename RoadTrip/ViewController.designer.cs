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
        UIKit.UIButton startButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView startImage { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextView startLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView startView { get; set; }

        [Action ("StartButton_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void StartButton_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (startButton != null) {
                startButton.Dispose ();
                startButton = null;
            }

            if (startImage != null) {
                startImage.Dispose ();
                startImage = null;
            }

            if (startLabel != null) {
                startLabel.Dispose ();
                startLabel = null;
            }

            if (startView != null) {
                startView.Dispose ();
                startView = null;
            }
        }
    }
}