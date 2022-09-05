using AutoMapper;
using Massager_Angular.BLL.Models;
using Massager_Angular.ViewModels;
using Massager_Angular.DAL.Models;
using System.Linq.Expressions;
using System;

namespace Massager_Angular.Mapping
{
    public class CommonProfile : Profile
    {
        public CommonProfile()
        {
            AddBusinessMapping();
            AddWebMapping();
        }

        public void AddWebMapping()
        {
            CreateMap<MassageEntity, Massages>().ReverseMap();
            CreateMap<ChatsEntity, Chat>().ReverseMap();
        }

        public void AddBusinessMapping()
        {
            CreateMap<Massages, MassageViewModel>().ReverseMap();
            CreateMap<Chat, ChatViewModel>().ReverseMap();
        }
    }
}
