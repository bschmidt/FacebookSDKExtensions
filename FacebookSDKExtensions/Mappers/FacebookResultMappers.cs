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
    public class FacebookResultMappers
    {
        public static PostResult MapToPostResult(JsonObject resultData)
        {
            var resultDict = (IDictionary<string, object>)resultData;
            var postResult = new PostResult();
            postResult.Id = resultDict.ToString("id");

            return postResult;
        }
    }
}
