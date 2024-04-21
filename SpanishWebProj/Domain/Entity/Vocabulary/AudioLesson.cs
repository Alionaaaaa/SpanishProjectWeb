using Domain.Enum;


namespace Domain.Entity.Vocabulary
{
    public class AudioLesson
    {
        public int Id { get; set; }
        public string Subject { get; set; }
        public string? ImagePath { get; set; }
        public TypeCourse Level { get; set; }
        public List<AudioEntity> AudioEntity { get; set; }

    }

}
