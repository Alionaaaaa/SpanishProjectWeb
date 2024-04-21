using Domain.Entity.Forum;
using Domain.Enum;


namespace Domain.Entity
{
    public class User
    {
        public int Id { get; set; }

        public string Password { get; set; }

        public string Name { get; set; }

        public Role Role { get; set; }

        public Profile Profile { get; set; }
        public List<ForumMessage>? ForumMessages { get; set; }
        public List<ForumTopic>? ForumTopics{ get; set; }
        public List<ForumCategory>? ForumCategories{ get; set; }

    }
}