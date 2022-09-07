﻿using Messager_Angular.BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messager_Angular.BLL.Interfaces
{
    public interface IMassageService
    {
        Task CreateAsync(Massages request);
        Task<int> GetCountAsync();
        Task<IEnumerable<Massages>> GetPagedAsync(Guid ChatId,string userId, int page = 1, int pageSize = 20);
        Task DeleteAsync(Guid id);
        void SoftDeleteAsync(Guid id);
        Task<Massages> GetAsync(Guid id);
        void UpdateAsync(Massages request);

    }
}
