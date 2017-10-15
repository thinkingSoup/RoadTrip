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
    [Register ("LoginScreen")]
    partial class LoginScreen
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton continueButton { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (continueButton != null) {
                continueButton.Dispose ();
                continueButton = null;
            }
        }
    }
}