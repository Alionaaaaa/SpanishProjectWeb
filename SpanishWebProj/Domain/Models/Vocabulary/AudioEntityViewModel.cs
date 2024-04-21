using System.ComponentModel.DataAnnotations;

namespace Domain.Models.Vocabulary
{
    public class AudioEntityViewModel
    {
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Display(Name = "TextSpanish")]
        public string TextSpanish { get; set; }
        [Display(Name = "TextRomanian")]
        public string TextRomanian { get; set; }

        [Display(Name = "SoundSpanishPath")]
        public string? SoundSpanishPath { get; set; }

        [Display(Name = "SoundRomanianPath")]
        public string? SoundRomanianPath { get; set; }
        [Display(Name = "ImagePath")]
        public string? ImagePath { get; set; }

        [Display(Name = "Subject")]
        public string Subject { get; set; }

    }
}
