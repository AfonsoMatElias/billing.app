using System;
using System.Collections.Generic;
using System.Text;
using Billing.Service.Data;
using Billing.Service.Models;
using Billing.Shared.Helpers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Billing.Service.Authentication;
using Microsoft.IdentityModel.Tokens;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Billing.Service.Extensions;
using Newtonsoft.Json;
using Billing.App.Handlers;
using Billing.App.Middleware;

namespace Billing.App
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            IoC.Configuration = Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            services.AddMvc(options =>
            {
                options.EnableEndpointRouting = false;
            }).AddNewtonsoftJson(options =>
            {
                // Ignoring the self references
                options.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
            });

            // Adding cors in the api
            services.AddCors(options =>
            {
                options.AddDefaultPolicy(builder =>
                {
                    builder.AllowAnyOrigin()
                            .AllowAnyMethod()
                            .AllowAnyHeader();
                });
            });

            services.AddDbContext<DataContext>(options =>
            {
                options.UseSqlServer(Configuration.GetConnectionString("Connection"), sqlServerOptions =>
                {
                    sqlServerOptions.MigrationsAssembly("Billing.App");
                });
            });

            services.AddIdentity<Usuario, IdentityRole<long>>()
                    .AddEntityFrameworkStores<DataContext>();

            services.AddScoped<CacheContext>();

            services.AddHttpContextAccessor();

            // Adding mapper
            services.AddAutoMapper(options =>
            {
                options.ForAllMaps((type, expression) =>
                {
                    expression.AfterMap((src, dst) =>
                    {
                        var _dstType = dst.GetType();
                        var _uid = _dstType.GetProperty("uid");

                        // If the property does not exists, do nothing
                        if (_uid == null)
                            return;

                        // Getting the main properties
                        var _id = _dstType.GetProperty(nameof(Service.Models.Base.Properties.Id));
                        var _createdAt = _dstType.GetProperty(nameof(Service.Models.Base.Properties.CreatedAt));

                        // Checking if it was found
                        if (_id == null || _createdAt == null)
                            return;

                        // Getting the actual value
                        var id = (long)_id.GetValue(dst);
                        var createdAt = (DateTime)_createdAt.GetValue(dst);

                        // Setting the uid value
                        _uid.SetValue(dst, $"{ id }:{ createdAt.Ticks }");
                    });
                });
            }, typeof(Startup));

            // Add JWT Authentication
            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(options =>
            {
                // options.SaveToken = true;
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,
                    ValidIssuer = IoC.Configuration["Jwt:Issuer"],
                    ValidAudience = IoC.Configuration["Jwt:Audience"],
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(IoC.Configuration["Jwt:SecretKey"]))
                };
            });

            services.AddAuthorization();

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            // Adding the application services
            services.AddAppServices();
            services.AddScoped<PreferenceHandler>();

            services.AddScoped<IAuth, Auth>();

            services.AddSwaggerGen(x =>
                x.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo
                {
                    Title = "Billing Application",
                    Version = "v1"
                }));

            services.AddScoped<FileHandler>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
                app.UseDeveloperExceptionPage();

            app.UseHsts();
            app.UseCors();
            app.UseAuthentication();

            app.Use(async (context, next) =>
            {
                await next(); // Pointing to the Swagger
                if (context.Response.StatusCode == 404 &&
                    !System.IO.Path.HasExtension(context.Request.Path.Value) &&
                    !context.Request.Path.Value.StartsWith("/api/") &&
                    !context.Request.Path.Value.StartsWith("/signalr"))
                {
                    context.Request.Path = "/index.html";
                    await next(); // Pointing to the next middlewae after swagger 
                }
            });

            app.UseSwagger(option =>
            {
                option.RouteTemplate = IoC.Configuration["SwaggerOptions:JsonRoute"];
            });

            app.UseSwaggerUI(option =>
            {
                option.SwaggerEndpoint(IoC.Configuration["SwaggerOptions:UIEndpoint"],
                        IoC.Configuration["SwaggerOptions:Description"]);
            });

            //app.UseHttpsRedirection();
            app.UseDefaultFiles(new DefaultFilesOptions { DefaultFileNames = new List<string> { "index.html" } });
            app.UseStaticFiles();
            app.UseRouting();

            app.UseAuthorization();

            app.UseMiddleware<ExceptionMiddleware>();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                //endpoints.MapHub<AppHub>("/signalr");
            });

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=App}/{action=Index}");
            });
        }
    }
}
