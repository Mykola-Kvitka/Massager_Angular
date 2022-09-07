using AutoMapper;
using Messager_Angular.BLL.Models;
using Messager_Angular.DAL.Models;
using System.Linq.Expressions;
using System;
using Messager_Angular.ViewModels;

namespace Messager_Angular.Mapping
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
