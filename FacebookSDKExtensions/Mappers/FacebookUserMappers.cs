using Facebook;
using FacebookSDKExtensions.Models;
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
            user.Id = (string)userResultDict["id"];
            user.Name = (string)userResultDict["name"];
            user.Email = (string)userResultDict["email"];

            return user;
        }
    }
}
