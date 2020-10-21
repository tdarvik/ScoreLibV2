﻿using Contracts;
using Entities;
using LoggerService;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Repository;
using System.Threading.Tasks;

namespace ReactCoreAssetBackend.Extensions
{
    public static class ServiceExtensions
    {
        // COMMENT: the MigrationAssembly function is used because the migration assembly is in the Entities project, 
        // so we change the project for migration assembly.
        // The UseSqlServer method requires Microsoft.EntityFrameworkCore.SqlServer to be installed in the project.
        public static void ConfigureSqlContext(this IServiceCollection services,
            IConfiguration configuration) =>
                services.AddDbContext<RepositoryContext>(opts =>
                    opts.UseSqlServer(configuration.GetConnectionString("sqlConnection"), b =>
                    b.MigrationsAssembly("ReactCoreAssetBackend")));

        public static void ConfigureCors(this IServiceCollection services) =>
             services.AddCors(options =>
             {
                 options.AddPolicy("CorsPolicy", builder =>
                 builder.AllowAnyOrigin()
                 .AllowAnyMethod()
                 .AllowAnyHeader());
             });

        public static void ConfigureLoggerService(this IServiceCollection services) =>
            services.AddScoped<ILoggerManager, LoggerManager>();
    }
}
