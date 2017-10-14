using Foundation;
using System;
using UIKit;

using CoreGraphics;

using Facebook.LoginKit;
using Facebook.CoreKit;

using System.Collections.Generic;

namespace RoadTrip
{
    public partial class LoginScreen : UIViewController
    {
        public LoginScreen (IntPtr handle) : base (handle)
        {
        }
        List<string> readPermissions = new List<string> { "public_profile" };

        LoginButton loginView;

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            // Set the Read and Publish permissions you want to get
            loginView = new LoginButton(new CGRect(61, 288, 218, 46))
            {
                LoginBehavior = LoginBehavior.Native,
                ReadPermissions = readPermissions.ToArray()
            };

            // Handle actions once the user is logged in
            loginView.Completed += (sender, e) =>
            {
                if (e.Error != null)
                {
                    // Handle if there was an error
                }

                if (e.Result.IsCancelled)
                {
                    // Handle if the user cancelled the login request
                }

                // Handle your successful login
            };

            // Handle actions once the user is logged out
            loginView.LoggedOut += (sender, e) =>
            {
                // Handle your logout
            };

            // Add views to main view
            View.AddSubview(loginView);
        }
    }
}