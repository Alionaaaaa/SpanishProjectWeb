using Domain.Entity.Vocabulary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity.Forum
{
    public class ForumCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int UserId { get; set; }

        public User User { get; set; }
        public List<ForumTopic>? ForumTopics { get; set; }

    }
}
