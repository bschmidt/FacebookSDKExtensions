using Facebook;
using FacebookSDKExtensions.Models;
using FacebookSDKExtensions.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookSDKExtensions.Mappers
{
    public class FacebookAuthMappers
    {
        public static AuthorizeResult MapToAuthorizeResult(JsonObject authorizeData)
        {
            var authorizeResultDict = (IDictionary<string, object>)authorizeData;

            var authResult = new AuthorizeResult();
            authResult.AccessToken = authorizeResultDict.ToString("access_token");
            authResult.ExpiresInSecs = authorizeResultDict.ToInt("expires");

            return authResult;
        }
    }
}
