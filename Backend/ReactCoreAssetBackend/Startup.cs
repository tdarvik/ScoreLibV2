using AutoMapper;
using BusinessLogic.Helpers;
using BusinessLogic.Services;
using Contracts;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using NLog;
using ReactCoreAssetBackend.Extensions;
using Repository;
using System.IO;

namespace ReactCoreAssetBackend
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            LogManager.LoadConfiguration(string.Concat(Directory.GetCurrentDirectory(), "/nlog.config"));
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddAutoMapper(typeof(Startup));
            services.ConfigureSqlContext(Configuration);
            services.AddControllers();
            services.ConfigureCors();
            services.ConfigureLoggerService();


            services.AddScoped<IRepositoryWrapper, RepositoryWrapper>();
            services.AddTransient<IScoreService, ScoreService>();

            // This is for adding the value of DatabaseType setting to a model so it can be used for switching between SQL and COSMOS, 
            // without loading the whole appSettings every time 
            services.Configure<DatabaseTypeModel>(Configuration.GetSection("DatabaseType"));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ILoggerManager logger)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.ConfigureExceptionHandler(logger);

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseCors("CorsPolicy");

            app.UseForwardedHeaders(new ForwardedHeadersOptions
            {
                ForwardedHeaders = ForwardedHeaders.All
            });


            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
