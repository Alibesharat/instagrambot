using Microsoft.AspNetCore.Http;
using System;

namespace Spigram.Extensions
{
    public static class UserCookie
    {
        public static string getuserId(this HttpContext context)
        {
            var s = context.Request.Cookies[CookieName.spigram_dfs.ToString()];
            if (s != null)
            {
                s = s.Base64Decode();
                return s;
            }
            return null;

        }

        public static void AddCoookie(this HttpContext context, string userId)
        {
            var cookie = new CookieOptions()
            {
                Expires = DateTime.Now.AddDays(15)
            };
            context.Response.Cookies.Delete(CookieName.spigram_dfs.ToString());
            context.Response.Cookies.Append(CookieName.spigram_dfs.ToString(), userId.Base64Encode(), cookie);

        }



        
    }

    public enum CookieName
    {
        spigram_dfs
    }
}

