using Facebook;
using FacebookSDKExtensions.Mappers;
using FacebookSDKExtensions.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookSDKExtensions.ClientExtensions
{
    public static class FeedOperations
    {
        public static PostResult PostToFeed(this FacebookClient client, string message)
        {
            Dictionary<string, object> messageParameters = new Dictionary<string, object>();
            messageParameters["message"] = message;

            var result = client.Post("/me/feed", messageParameters) as JsonObject;

            return FacebookResultMappers.MapToPostResult(result);
        }

        public static async Task<PostResult> PostToFeedAsync(this FacebookClient client, string message)
        {
            Dictionary<string, object> messageParameters = new Dictionary<string, object>();
            messageParameters["message"] = message;

            var result = await client.PostTaskAsync("/me/feed", messageParameters) as JsonObject;

            return FacebookResultMappers.MapToPostResult(result);
        }
    }
}
