using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity.Forum
{
    public class ForumTopic
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string? Description { get; set; }
        public int ForumCategoryId { get; set; }

        public int UserId { get; set; }

        public User User { get; set; }

        public ForumCategory ForumCategory { get; set; }

        public List<ForumMessage>? ForumMessages { get; set; }
        
    }
}
