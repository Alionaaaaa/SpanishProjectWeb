using Domain.Entity.Vocabulary;
using Domain.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.Vocabulary
{
    public class AudioLessonViewModel
    {
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Display(Name = "Temă")]
        public string Subject { get; set; }

        [Display(Name = "Imagine")]
        public string? ImagePath { get; set; }

        [Display(Name = "Nivelul")]
        public TypeCourse Level { get; set; }

        public List<AudioEntity> AudioEntity { get; set; }
    }
}
