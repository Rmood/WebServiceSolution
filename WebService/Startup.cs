﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccessLayer;
using FinurligvisDatabase;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using DomainModel;
using WebService.Models;
using AutoMapper;

namespace WebService
{
    public class Startup
    {
        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
                .AddEnvironmentVariables();
            Configuration = builder.Build();
        }

        public IConfigurationRoot Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            // Add framework services.
            services.AddMvc();
            services.AddSingleton<IDataService, FinurligvisDataService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole(Configuration.GetSection("Logging"));
            loggerFactory.AddDebug();

            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<Product, ProductListModel>();
                cfg.CreateMap<Product, ProductModel>();
                cfg.CreateMap<ProductCreateModel, Product>();

                cfg.CreateMap<Client, ClientModel>();
                cfg.CreateMap<Client, ClientListModel>();
                cfg.CreateMap<ClientCreateModel, Client>();

                cfg.CreateMap<Order, OrderModel>();
                cfg.CreateMap<Order, OrderListModel>();
                cfg.CreateMap<OrderCreateModel, Order>();

                cfg.CreateMap<Category, CategoryModel>();
                cfg.CreateMap<Category, CategoryListModel>();
                cfg.CreateMap<CategoryCreateModel, Category>();
            });
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
            
        }
    }
}
