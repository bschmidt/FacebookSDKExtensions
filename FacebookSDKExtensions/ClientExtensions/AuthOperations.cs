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
    public static class AuthOperations
    {
        public static AuthorizeResult GetAccessToken(this FacebookClient client, string code, string callbackUrl)
        {
            Dictionary<string, object> accessParameters = new Dictionary<string, object>();
            accessParameters["client_id"] = client.AppId;
            accessParameters["client_secret"] = client.AppSecret;
            accessParameters["redirect_uri"] = callbackUrl;
            accessParameters["code"] = code;

            var result = client.Post("oauth/access_token", accessParameters) as JsonObject;

            return FacebookAuthMappers.MapToAuthorizeResult(result);
        }
    }
}
