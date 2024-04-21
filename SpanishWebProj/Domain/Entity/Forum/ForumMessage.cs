using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity.Forum
{
    public class ForumMessage
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public DateTime PostDateTime { get; set; }
        public int ForumTopicId { get; set; }
        public int UserId { get; set; }
        
        public User User { get; set; }
        public ForumTopic ForumTopic { get; set; }

    }
}
