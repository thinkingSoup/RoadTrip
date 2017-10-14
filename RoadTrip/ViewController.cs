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
        List<string> readPermissions = new List<string> { "public_profile" };

        LoginButton loginView;
        ProfilePictureView pictureView;
        UILabel nameLabel;

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // If was send true to Profile.EnableUpdatesOnAccessTokenChange method
            // this notification will be called after the user is logged in and
            // after the AccessToken is gotten
            Profile.Notifications.ObserveDidChange((sender, e) => {

                if (e.NewProfile == null)
                    return;

                nameLabel.Text = e.NewProfile.Name;
            });

            if (AccessToken.CurrentAccessToken == null)
            {



                // Set the Read and Publish permissions you want to get
                loginView = new LoginButton(new CGRect(51, 0, 218, 46))
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

                // The user image profile is set automatically once is logged in
                pictureView = new ProfilePictureView(new CGRect(50, 50, 220, 220));

                // Create the label that will hold user's facebook name
                nameLabel = new UILabel(new RectangleF(20, 319, 280, 21))
                {
                    TextAlignment = UITextAlignment.Center,
                    BackgroundColor = UIColor.Clear
                };

                // Add views to main view
                View.AddSubview(loginView);
                View.AddSubview(pictureView);
                View.AddSubview(nameLabel);
            }
        }
        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}
