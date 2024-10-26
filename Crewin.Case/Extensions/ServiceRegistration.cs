﻿using Crewin.Case.Context;
using Crewin.Case.Repositories;
using Crewin.Case.Repositories.Interface;
using Crewin.Case.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Crewin.Case.Extensions
{
    public static class ServiceRegistration
    {
        public static void AddDatabase(this IServiceCollection services, IConfiguration _configuration)
        {
            var q = _configuration.GetConnectionString("DefaultConnection");
            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(_configuration.GetConnectionString("DefaultConnection")), ServiceLifetime.Scoped);

            services.AddScoped(typeof(IEntityRepository<>), typeof(EntityRepository<>));
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<IProductService, ProductService>();
        }
    }
}
