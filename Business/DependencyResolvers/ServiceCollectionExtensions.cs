using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Microsoft.Extensions.DependencyInjection;

namespace Business.DependencyResolvers
{
    public static class ServiceCollectionExtensions
    {
        public static void AddApplicationBusinessDependencies(this IServiceCollection services)
        { 
            services.AddSingleton<IBuyService, BuyManager>();
            services.AddSingleton<IBuyDal, EfBuyDal>();
            services.AddSingleton<IMyTransactionDal, EfMyTransactionDal>();
        }
    }
}
