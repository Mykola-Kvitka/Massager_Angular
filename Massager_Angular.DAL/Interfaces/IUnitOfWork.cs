using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Massager_Angular.DAL.Models;

namespace Massager_Angular.DAL.Interfaces
{
    public interface IUnitOfWork
    {
        IGenericRepository<MassageEntity> Massages { get; }
        IGenericRepository<ChatsEntity> Chats { get; }
    }
}
