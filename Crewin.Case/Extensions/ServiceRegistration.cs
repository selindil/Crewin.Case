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
            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(_configuration.GetConnectionString("DefaultConnection")), ServiceLifetime.Scoped);

            services.AddScoped(typeof(IEntityRepository<>), typeof(EntityRepository<>));
            services.AddHttpClient<IProductService, ProductService>();
            services.AddHttpClient<ICategoryService, CategoryService>();
            // Dependency injection 
        }
    }
}
//Bu kodlar, uygulamanın veritabanı bağlantısını, repository yapısını ve belirli servisleri bağımlılık enjeksiyonu aracılığıyla yapılandırıyor. Veritabanı bağlantısı SQL Server ile sağlanıyor, HTTP istemciler tanımlanıyor, ve her istek için gerekli bağımlılıklar hizmet olarak sağlanıyor.






