﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messager_Angular.BLL.Models
{
    public class Chat
    {
        public Guid Id { get; set; }
        public Guid ChatId { get; set; }
        [MaxLength(64)]
        public string UserId { get; set; }
        public string UserName { get; set; }

    }
}
