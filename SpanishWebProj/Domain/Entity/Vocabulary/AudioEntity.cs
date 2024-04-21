using System;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entity.Vocabulary
{
    public class AudioEntity
    {
        public int Id { get; set; }
        public string TextSpanish { get; set; }
        public string TextRomanian { get; set; }
        public string? SoundSpanishPath { get; set; }
        public string? SoundRomanianPath { get; set; }
        public string? ImagePath { get; set; }
        public AudioLesson AudioLesson { get; set; }
        public int IdAudioLesson { get; set; }
        
        
    }
}