using Microsoft.Extensions.DependencyInjection;
using Massager_Angular.BLL.Interfaces;
using Massager_Angular.BLL.Models;
using Massager_Angular.BLL.Services;
using Massager_Angular.DAL;
using Massager_Angular.DAL.Interfaces;
using Massager_Angular.DAL.Models;
using Massager_Angular.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Massager_Angular.Infastructure
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
