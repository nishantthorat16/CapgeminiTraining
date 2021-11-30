using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace CustomMiddleWare
{
    public class LogRequestMiddleWare
    {
        public  RequestDelegate _next;

        public LogRequestMiddleWare(RequestDelegate next)
        {
            _next = next;
            
        }

        public async Task Invoke(HttpContext context)
        {
            //if (context.Request.Path.Value.Contains("Action2"))
            //    context.Response.Redirect("/action3");
            

            File.AppendAllText(@"D:\Capgemini Training\LogRequest.txt"
                            , $"Recieved request for {context.Request.Path} @ {DateTime.Now}\n");
            await _next(context);
        }

    }
}
