using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Real.Configuration;
using Real.Models;

namespace Real.Configuration
{
    public class ContentMiddlewareAfterHour
    {

        // We define property NextDeleguete to bloc any atemps of accessing the website after 6PM
        public RequestDelegate nextDelegate;

        //public TimeChecker timechecker ;

        //public ContentMiddlewareAfterHourController( RequestDelegate next, TimeChecker checker)
       public ContentMiddlewareAfterHour(RequestDelegate next)
        { 
            //this.timechecker = checker;
            nextDelegate = next;
        }

        public async Task Invoke(HttpContext httpContext)
        {
            //if (timechecker.isRegularTime() == false)
            if(DateTime.Now.Hour == 20)
            {
                await httpContext.Response.WriteAsync("The Website Is not Accessible now \n Please try during regular hours");
            }
            else
            {
                await nextDelegate.Invoke(httpContext);
            }
        }
    }
}