using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;

using Microsoft.Azure.Documents;
using Microsoft.Azure.Documents.Client;
using System.Net;
using Newtonsoft.Json;
using Facebook.CoreKit;
using Facebook.LoginKit;
namespace RoadTrip
{
    public class DataStorage
    {
        private static readonly DataStorage instance = new DataStorage();
        private DocumentClient client;
        private const string EndpointUrl = "https://roadtrip-thinkingsoup.documents.azure.com:443/";
        private const string PrimaryKey = "Ea8Zh9Uo2q160KStQfPy1xtpCsyQrvhh1V9fEmbRhbR54n3FYblbfcItMVAmtYkvnZjtAxGyfPqLzRcKr9kdQQ==";

        private const string userTable = "Users";
        private const string tripTable = "Trips";
        private const string database = "RoadTrip";
        private DataStorage()
        {
        }

        public async System.Threading.Tasks.Task GetClient() {
            client = new DocumentClient(new Uri(EndpointUrl), PrimaryKey);
            return;
        }
        public RoadTrip.Model.User GetUser(string userId)
        {
            FeedOptions queryOptions = new FeedOptions { MaxItemCount = 1 };
            IQueryable<RoadTrip.Model.User> userQuery = client.CreateDocumentQuery<RoadTrip.Model.User>(
                UriFactory.CreateDocumentCollectionUri(database, userTable), queryOptions)
                                               .Where(user => user.id == userId);
            Model.User userData = null;
            foreach (Model.User userDB in userQuery) {
                userData = userDB;
            }
            return userData;
        }

        public void AddNewUser() {
            if (AccessToken.CurrentAccessToken == null) {
                return;
            }
            var user = new RoadTrip.Model.User
            {
                id = AccessToken.CurrentAccessToken.UserID,
                name = "",
                miles = 0,
                currentTrip = -1
            };
            client.CreateDocumentAsync(UriFactory.CreateDocumentCollectionUri(database,
                                                                              userTable),
                                      user).Wait();
            return;
        }

        public void UpdateUser(Model.User user) {
            UpdateUserAsync(user);
        }

        private async System.Threading.Tasks.Task UpdateUserAsync(Model.User user)
        {
            await client.ReplaceDocumentAsync(UriFactory.CreateDocumentUri(database, userTable, user.id), user);
        }

        public static DataStorage Instance {
            get {
                return instance;
            }
        }
    }
}
