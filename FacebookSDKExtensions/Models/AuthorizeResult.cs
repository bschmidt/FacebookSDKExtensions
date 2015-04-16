using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookSDKExtensions.Models
{
    public class AuthorizeResult
    {
        public string AccessToken { get; set; }
        public int ExpiresInSecs { get; set; }
    }
}
