using Foundation;
using System;
using UIKit;

namespace RoadTrip
{
    public partial class PrefsController : UIViewController
    {
        public PrefsController (IntPtr handle) : base (handle)
        {
        }
        public Model.User user { get; set; }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            table = new UITableView(View.Bounds); // defaults to Plain style
            string[] tableItems = new string[] { "Monuments", "Parks", "Museums", "Architecture", "Sports", "Beaches" };
            table.Source = new TableSource(tableItems);
            Add(table);
        }
    }
}