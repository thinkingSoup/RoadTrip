using System;

using Microsoft.WindowsAzure.MobileServices;
namespace RoadTrip
{
    public class DataStorage
    {
        private static readonly DataStorage instance = new DataStorage();
        public MobileServiceClient client { get; }
        private DataStorage()
        {
            client = new MobileServiceClient("https://thinkingsoup-roadtrip.azurewebsites.net");
        }

        public static DataStorage Instance {
            get {
                return instance;
            }
        }
    }
}
