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
    public class FacebookUserMappers
    {
        public static FacebookUser MapToUser(JsonObject userData)
        {
            var userResultDict = (IDictionary<string, object>)userData;

            var user = new FacebookUser();
            user.Id = userResultDict.ToString("id");
            user.Name = userResultDict.ToString("name");
            user.Email = userResultDict.ToString("email");

            return user;
        }
    }
}
