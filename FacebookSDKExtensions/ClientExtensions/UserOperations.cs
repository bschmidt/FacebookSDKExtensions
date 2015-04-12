using Facebook;
using FacebookSDKExtensions.Mappers;
using FacebookSDKExtensions.Models;
using Microsoft.AspNet.Facebook;
using Microsoft.AspNet.Facebook.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookSDKExtensions.ClientExtensions
{
    public static class UserOperations
    {
        public static FacebookUser GetUser(this FacebookClient client)
        {
            var userResult = client.GetCurrentUserAsync().Result as JsonObject;

            return FacebookUserMappers.MapToUser(userResult);
        }

        public async static Task<FacebookUser> GetUserAsync(this FacebookClient client)
        {
            var userResult = await client.GetCurrentUserAsync() as JsonObject;

            return FacebookUserMappers.MapToUser(userResult);
        }
    }
}
