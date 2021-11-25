using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoItemsLibrary;

namespace ToDoItemList
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddControllers();

            //Dependency Container
            /*
             1. Singleton - Only one instance will be created independent of number of calls or users
             2. Scoped - Each User will get a different instance but will remain the same with in the scope
             3. Transient - Each User and Each Controller will get a different instance of the service
             */

            //services.AddSingleton<ITodoItemService, ToDoItemFileService>();
            services.AddScoped<ITodoItemService,ToDoItemFileService>();
            //services.AddTransient<ITodoItemService, ToDoItemFileService>();
           
            //services.AddScoped<ITodoItemService, ToDoItemDataBaseService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
