using AutoMapper;
using Massager_Angular.BLL.Interfaces;
using Massager_Angular.BLL.Models;
using Massager_Angular.DAL.Interfaces;
using Massager_Angular.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Massager_Angular.BLL.Services
{
    public class ChatServise : IChatServise
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ChatServise(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public void CreateAsync(IEnumerable<string> request)
        {
            var chatId = Guid.NewGuid();

            foreach (var chat in request)
            {
                var requestEntity = new ChatsEntity() { Id = Guid.NewGuid(), ChatId = chatId, UserId = chat };

                _unitOfWork.Chats.CreateAsync(requestEntity);
            }
        }


        public async Task<IEnumerable<Chat>> GetAllAsync(string id)
        {
            var replay = await FindAsync(a => a.UserId == id);

            return replay;
        }

        private async Task<IEnumerable<Chat>> FindAsync(Expression<Func<ChatsEntity, bool>> predicate)
        {

            var replay = await _unitOfWork.Chats.FindAsync(predicate);

            return _mapper.Map<List<ChatsEntity>, List<Chat>>(replay);
        }

    }
}
