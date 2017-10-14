using System;
using System.Drawing;
using UIKit;
using CoreGraphics;

using Facebook.LoginKit;
using Facebook.CoreKit;

using Microsoft.WindowsAzure.MobileServices;

using System.Threading.Tasks;
using System.Collections.Generic;

namespace RoadTrip
{
    public partial class ViewController : UIViewController
    {
        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}
