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
    [Register ("PrefsController")]
    partial class PrefsController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton okayButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel questionText { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITableView tableLike2C { get; set; }

        void ReleaseDesignerOutlets ()
        {
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