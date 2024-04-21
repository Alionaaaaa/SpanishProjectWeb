using BusinessLogic.Interfaces.IForumBL;
using DAL.Interfaces;
using DAL.Repositories;
using Domain.Entity;
using Domain.Entity.Forum;
using Domain.Entity.Worksheet;
using Domain.Enum;
using Domain.Models.Forum;
using Domain.Response;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Implementations.ForumBl
{
    public class ForumTopicBl : IForumTopicBl
    {
        private readonly IBaseRepository<ForumTopic> _forumTopicRepository;
        private readonly IBaseRepository<ForumCategory> _forumCategoryRepository; 
        public ForumTopicBl(IBaseRepository<ForumTopic> forumTopicRepository, IBaseRepository<ForumCategory> forumCategoryRepository)
        {
            _forumTopicRepository = forumTopicRepository;
            _forumCategoryRepository = forumCategoryRepository; 
        }


        public IBaseResponse<List<ForumTopic>> GetAllTopics()
        {
            try
            {
                var forumTopic = _forumTopicRepository.GetAll().Include(x => x.ForumCategory).Include(x => x.User).ToList();
                if (!forumTopic.Any())
                {
                    return new BaseResponse<List<ForumTopic>>()
                    {
                        Description = "Nu sunt găsite referințe",
                        StatusCode = StatusCode.OK
                    };
                }

                return new BaseResponse<List<ForumTopic>>()
                {
                    Data = forumTopic,
                    StatusCode = StatusCode.OK
                };
            }
            catch (Exception ex)
            {
                return new BaseResponse<List<ForumTopic>>()
                {
                    Description = $"[GetWorksheets] : {ex.Message}",
                    StatusCode = StatusCode.InternalServerError
                };
            }
        }
        public Task<IBaseResponse<TopicViewModel>> Create(TopicViewModel model)
        {
            throw new NotImplementedException();
        }

        public Task<IBaseResponse<bool>> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IBaseResponse<ForumTopic>> Edit(int id, TopicViewModel model)
        {
            throw new NotImplementedException();
        }

        public Task<IBaseResponse<TopicViewModel>> GetTopicById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
