using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Massager_Angular.DAL.DataAccses;
using Massager_Angular.DAL.Interfaces;
using Massager_Angular.DAL.Models;
using Massager_Angular.DAL.Repositories;

namespace Massager_Angular.DAL
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DataAccsess _appData;

        private GenericRepository<MassageEntity> _massages;
        private GenericRepository<ChatsEntity> _chats;

        public UnitOfWork(DataAccsess appData)
        {
            _appData = appData;
        }

        public IGenericRepository<MassageEntity> Massages => _massages ??= new GenericRepository<MassageEntity>(_appData);
        public IGenericRepository<ChatsEntity> Chats => _chats ??= new GenericRepository<ChatsEntity>(_appData);

    }
}
