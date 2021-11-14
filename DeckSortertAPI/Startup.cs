using DeckSortertAPI.Middlewares;
using DeckSortertAPI.Models;
using DeckSortertAPI.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;

namespace DeckSortertAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<ICardSortService, SortService>();
            services.AddScoped<ICardHandler, CardHandler>();
            services.AddScoped<IComparer<Card>, CardComparer>();
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }
            app.UseDeckSorterExceptionHandler();
            app.UseCors(builder =>
            {
                builder.WithOrigins(new string[] { "http://localhost:4200" , "http://decksorterapi.southeastasia.azurecontainer.io" });
                builder.AllowAnyMethod();
                builder.AllowCredentials();
                builder.AllowAnyHeader();
            });
            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
