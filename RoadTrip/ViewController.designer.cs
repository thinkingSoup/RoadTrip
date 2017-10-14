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
        UIKit.UIButton goButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextView goText { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton okayButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel questionText { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITableView tableLike2C { get; set; }

        [Action ("GoButton_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void GoButton_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (goButton != null) {
                goButton.Dispose ();
                goButton = null;
            }

            if (goText != null) {
                goText.Dispose ();
                goText = null;
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
        }
    }
}