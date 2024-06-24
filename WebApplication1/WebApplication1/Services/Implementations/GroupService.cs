using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using WebApplication1.Dal.Interfaces;
using WebApplication1.Dal.Repositories;
using WebApplication1.Models;
using WebApplication1.Models.Enum;
using WebApplication1.Models.Response;
using WebApplication1.Services.Interfaces;

namespace WebApplication1.Services.Implementations
{
    public class GroupService : IGroupService
    {
        IGroupRepository<Group> groupRepository;
        
        public GroupService(IGroupRepository<Group> groupRepository)
        {
            this.groupRepository = groupRepository;
        }
        public async Task<IBaseResponse<Group>> Create(string name)
        {
            try
            {
                if(name == null && name == "" && name == " ")
                {
                    return new BaseResponse<Group>()
                    {
                        Description = "Название пустое"
                    };
                }
                var group = new Group()
                {
                    group_name = name
                };
                await groupRepository.Create(group);
                return new BaseResponse<Group>()
                {
                    Description="Группа создана",
                    Data = group,
                    StatusCode= Models.Enum.StatusCode.OK
                };
            }
            catch(Exception ex)
            {
                return new BaseResponse<Group>()
                {
                    Description = ex.Message,
                    StatusCode = StatusCode.InternalServerError
                };
            }
        }

        public async Task<IBaseResponse<IEnumerable<Group>>> GetAll()
        {
            try
            {
                var groups = groupRepository.GetAll().AsEnumerable();
                if (groups == null)
                {
                    return new BaseResponse<IEnumerable<Group>>()
                    {
                        Description = "Групп нет"
                    };
                }

                return new BaseResponse<IEnumerable<Group>>()
                {
                    Data = groups,
                    Description = "Группы выведены",
                    StatusCode = StatusCode.OK
                };
            }
            catch (Exception ex)
            {
                return new BaseResponse<IEnumerable<Group>>()
                {
                    Description = ex.Message,
                    StatusCode = StatusCode.InternalServerError
                };
            }
        }
    }
}
