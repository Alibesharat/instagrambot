using System;
using System.Collections.Generic;
using System.Text;

namespace InstagarmBot
{
    public class Address
    {
        public static string url { get { return "http://instagram.com"; } }

        public static string LoginUrl { get { return $"{url}/accounts/login/?hl=en"; } }

        public static string RegisterUrl { get { return $"{url}/accounts/emailsignup/?hl=en"; } }

        public static string Explore(string Hashtag)
        {
            return $"{url}/explore/tags/{Hashtag.Trim()}";
        }

        public static string TopPosts()
        {
            return $"{url}/Explore";
        }

        public static string UserAddress(string Username)
        {
            return $"{url}/{Username.Trim()}";
        }

        public static string LocationUrl(string LocationID)
        {

            return $"{url}/explore/locations/{LocationID.Trim()}";
        }
    }
}
