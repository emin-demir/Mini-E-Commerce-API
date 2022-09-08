using ETicaretAPI.Application.Abstractions.Storage;
using ETicaretAPI.Infrastructure.Enums;
using ETicaretAPI.Infrastructure.Services;
using ETicaretAPI.Infrastructure.Services.Storage;
using ETicaretAPI.Infrastructure.Services.Storage.Azure;
using ETicaretAPI.Infrastructure.Storage;
using ETicaretAPI.Infrastructure.Storage.Local;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Infrastructure
{
    public static class ServiceRegistration
    {

        public static void AddInfrastructureServices(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<IStorageService, StorageService>();
        }
    

        public static void AddStorage<T>(this IServiceCollection serviceCollection) where T : Services.Storage.Storage, IStorage
        {
            serviceCollection.AddScoped<IStorage, T>();
        }

        //Böyle bir kullanım tercih edilmiyor  ve kirli bir kod fakat böyle kullanımları da göstermek için eklenmiştir.
        public static void AddStorage(this IServiceCollection serviceCollection, StorageType storageType) 
        {
            switch (storageType)
            {
                case StorageType.Local:
                    serviceCollection.AddScoped<IStorage, LocalStorage>();
                    break;
                case StorageType.Azure:
                    serviceCollection.AddScoped<IStorage, AzureStorage>();
                    break;
                case StorageType.AWS:
                    break;
                default:
                    serviceCollection.AddScoped<IStorage, LocalStorage>();
                    break;
            }
        }
    }
}
