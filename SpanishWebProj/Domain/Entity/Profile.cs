
using Domain.Entity.Forum;
using Domain.Enum;

namespace Domain.Entity
{
    public class Profile
    {
        public int Id { get; set; }
        public string? Image { get; set; }
        public int? Age { get; set; }
        public TypeCourse? Level { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}