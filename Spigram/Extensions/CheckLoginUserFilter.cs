using Microsoft.AspNetCore.Mvc;

using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Threading.Tasks;

namespace Spigram.Extensions
{
    public class CheckLoginUserFilter : Attribute, IAsyncActionFilter
    {

       
        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            var cookie = context.HttpContext.Request.Cookies[CookieName.spigram_dfs.ToString()];
            if (string.IsNullOrWhiteSpace(cookie))
            {
                var route = context.HttpContext.Request.Scheme;
                var host = context.HttpContext.Request.Host;
                context.HttpContext.Response.Redirect($"{route}://{host}/Account/login");
                

            }
            else
            {
               
                await next();

            }


        }



    }
}




