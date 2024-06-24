using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using WebApplication1.Dal.Interfaces;
using WebApplication1.Dal.Repositories;
using WebApplication1.Models;
using WebApplication1.Models.Enum;
using WebApplication1.Models.Helper;
using WebApplication1.Models.Response;
using WebApplication1.Services.Interfaces;

namespace WebApplication1.Services.Implementations
{
    public class MessageService : IMessageService
    {
        private readonly IMessageRepository<Message> _messageRepository;
        private readonly IBaseRepository<User> _userRepository;
        public MessageService(IMessageRepository<Message> messageRepository, IBaseRepository<User> userRepository)
        {
            _messageRepository = messageRepository;
            _userRepository = userRepository;
        }
        public async Task<IBaseResponse<Message>> Create(string message,string login,int id_group)
        {
            try
            {
                if (message.Length == 0 || message == null)
                {
                    return new BaseResponse<Message>()
                    {
                        Description = "Сообщение пустое"
                    };
                }
                var user = _userRepository.GetAll().FirstOrDefault(x => x.Email == login);
                Message msg = new Message()
                {
                    text_message = message,
                    id_user = user.Id,
                    id_group = id_group
                };
                await _messageRepository.Create(msg);
                return new BaseResponse<Message>()
                {
                    Data = msg,
                    Description = "Сообщение создано",
                    StatusCode = StatusCode.OK
                };
            }
            catch (Exception ex)
            {
                return new BaseResponse<Message>()
                {
                    Description = ex.Message,
                    StatusCode = StatusCode.InternalServerError
                };
            }
        }

        public async Task<IBaseResponse<IEnumerable<MessageModelView>>> GetAll()
        {
            try
            {
                var messages = _messageRepository.GetAll();
                var users = _userRepository.GetAll();
                if (messages == null)
                {
                    return new BaseResponse<IEnumerable<MessageModelView>>()
                    {
                        Description = "Сообщений нет"
                    };
                }
                var usersList = new List<User>();
                usersList = users.ToList();

                var messageView = new List<MessageModelView>();

                foreach(var msg in messages)
                {
                    messageView.Add(new MessageModelView()
                    {
                        Message = msg.text_message,
                        UserName = usersList.FirstOrDefault(x=>x.Id == msg.id_user).Login
                    });
                }
                return new BaseResponse<IEnumerable<MessageModelView>>()
                {
                    Data = messageView,
                    Description = "Сообщения выведены",
                    StatusCode = StatusCode.OK
                };
            }
            catch (Exception ex)
            {
                return new BaseResponse<IEnumerable<MessageModelView>>()
                {
                    Description = ex.Message,
                    StatusCode = StatusCode.InternalServerError
                };
            }
        }
    }
}
