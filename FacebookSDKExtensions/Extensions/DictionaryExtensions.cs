using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookSDKExtensions.Extensions
{
    public static class DictionaryExtensions
    {
        public static string ToString(this IDictionary<string, object> dictionary, string key)
        {
            string value = "";

            if (dictionary.Keys.Contains(key))
                value = dictionary[key].ToString();

            return value;
        }

        public static int ToInt(this IDictionary<string, object> dictionary, string key)
        {
            int value = 0;

            if (dictionary.Keys.Contains(key))
            {
                value = Int32.Parse(dictionary[key].ToString());
            }

            return value;
        }

        public static bool ToBool(this IDictionary<string, object> dictionary, string key)
        {
            bool value = false;

            if (dictionary.Keys.Contains(key))
                value = (bool)dictionary[key];

            return value;
        }

        public static DateTime ToDateTime(this IDictionary<string, object> dictionary, string key)
        {
            DateTime value = new DateTime();

            if (dictionary.Keys.Contains(key))
                value = DateTime.Parse(dictionary[key].ToString());

            return value;
        }
    }
}
