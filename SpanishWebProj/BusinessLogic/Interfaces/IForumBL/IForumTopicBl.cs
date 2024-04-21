using Domain.Entity;
using Domain.Entity.Forum;
using Domain.Entity.Worksheet;
using Domain.Models.Course;
using Domain.Models.Forum;
using Domain.Response;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Interfaces.IForumBL
{
    public interface IForumTopicBl
    {
        IBaseResponse<List<ForumTopic>> GetAllTopics();
        Task<IBaseResponse<TopicViewModel>> GetTopicById(int id);
        Task<IBaseResponse<TopicViewModel>> Create(TopicViewModel model);
        Task<IBaseResponse<ForumTopic>> Edit(int id, TopicViewModel model);
        Task<IBaseResponse<bool>> Delete(int id);
    }
}
