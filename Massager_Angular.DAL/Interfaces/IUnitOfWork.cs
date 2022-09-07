using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Messager_Angular.DAL.Models;

namespace Messager_Angular.DAL.Interfaces
{
    public interface IUnitOfWork
    {
        IGenericRepository<MassageEntity> Massages { get; }
        IGenericRepository<ChatsEntity> Chats { get; }
    }
}
