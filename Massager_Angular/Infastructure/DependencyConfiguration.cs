using Microsoft.Extensions.DependencyInjection;
using Messager_Angular.BLL.Interfaces;
using Messager_Angular.BLL.Models;
using Messager_Angular.BLL.Services;
using Messager_Angular.DAL;
using Messager_Angular.DAL.Interfaces;
using Messager_Angular.DAL.Models;
using Messager_Angular.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Messager_Angular.Infastructure
{
    public static class DependencyConfiguration
    {
        public static void AddDependencies(this IServiceCollection service)
        {
            //DAL configuration
            service.AddScoped<IUnitOfWork, UnitOfWork>();
            service.AddTransient<IGenericRepository<ChatsEntity>, GenericRepository<ChatsEntity>>();
            service.AddTransient<IGenericRepository<MassageEntity>, GenericRepository<MassageEntity>>();

            //BL configuration
            service.AddTransient<IChatServise, ChatServise>();
            service.AddTransient<IMassageService, MassageService>();
        }

    }
}
