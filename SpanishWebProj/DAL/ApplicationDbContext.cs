using Domain.Entity;
using Domain.Entity.Forum;
using Domain.Entity.Quiz;
using Domain.Entity.Vocabulary;
using Domain.Entity.Worksheet;
using Domain.Enum;
using Domain.Helpers;
using Microsoft.EntityFrameworkCore;

namespace DAL
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

                Database.EnsureCreated();
        }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Profile> Profiles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Quiz> Quizes { get; set; }
        public DbSet<QuizQuestion> QuizQuestions { get; set; }
        public DbSet<AudioLesson> AudioLessons { get; set; }
        public DbSet<AudioEntity> AudioEntities { get; set; }
        public DbSet<Worksheet> Worksheets { get; set; }
        public DbSet<WorksheetCategory> WorksheetCategory { get; set; }
        public DbSet<ForumCategory> ForumCategories { get; set; }
        public DbSet<ForumTopic> ForumTopics { get; set; }
        public DbSet<ForumMessage> ForumMessages { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(builder =>
            {
                builder.ToTable("Users").HasKey(x => x.Id);

                builder.HasData(new User[]
                {
                    new User()
                    {
                        Id = 1,
                        Name = "Ana",
                        Password = HashPasswordHelper.HashPassowrd("123456"),
                        Role = Role.Admin
                    },
                    new User()
                    {
                        Id = 2,
                        Name = "Aliona",
                        Password = HashPasswordHelper.HashPassowrd("654321"),
                        Role = Role.Moderator
                    }
                });

                // Ensure Id is generated on add
                builder.Property(x => x.Id).ValueGeneratedOnAdd();

                builder.Property(x => x.Password).IsRequired();
                builder.Property(x => x.Name).HasMaxLength(100).IsRequired();

                builder.HasOne(x => x.Profile)
                    .WithOne(x => x.User)
                    .HasPrincipalKey<User>(x => x.Id)
                    .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<Profile>(builder =>
            {
                builder.ToTable("Profiles").HasKey(x => x.Id);

                // Ensure Id is generated on add
                builder.Property(x => x.Id).ValueGeneratedOnAdd();

                // Add configuration for other properties if necessary
            });

            //modelBuilder.Entity<Course>(builder =>
            //{
            //    builder.ToTable("Courses").HasKey(x => x.Id);

            //    builder.HasData(new Course
            //    {
            //        Id = 1,
            //        Name = "curs",
            //        Description = new string('A', 50),
            //        Avatar = null,
            //        TypeCourse = TypeCourse.Level0
            //    });
            //});





            modelBuilder.Entity<Quiz>()
                .ToTable("Quizes")
                .HasKey(x => x.Id);

            modelBuilder.Entity<QuizQuestion>()
                .ToTable("QuizQuestions")
                .HasKey(x => x.Id);

            modelBuilder.Entity<QuizQuestion>()
                .HasOne(q => q.Quiz)
                .WithMany(qz => qz.QuizQuestions)
                .HasForeignKey(q => q.QuizId)
                 .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Quiz>()
                .HasData(new Quiz
                {
                    Id = 1,
                    Name = "Capitale"
                });

            modelBuilder.Entity<QuizQuestion>()
                .HasData(new QuizQuestion
                {
                    Id = 1,
                    QuestionText = "What is the capital of France?",
                    A = "Moscow",
                    B = "Moscow",
                    C = "Moscow",
                    D = "Paris",
                    RightAnswer = "Paris",
                    QuizId = 1
                });

            modelBuilder.Entity<Quiz>().Property(x => x.Id).ValueGeneratedOnAdd();
                
            modelBuilder.Entity<Quiz>().Property(x => x.Name).IsRequired();
                
                

            // Add other configurations as needed for quiz questions

            base.OnModelCreating(modelBuilder);



            modelBuilder.Entity<AudioLesson>(builder =>
            {
                builder.ToTable("AudioLessons").HasKey(x => x.Id);

                builder.HasData(new AudioLesson[]
                {
                    new AudioLesson()
                    {
                        Id = 1,
                        Subject = "Animale",
                        ImagePath = "/images/audioLesson/animale.jpg",
                        Level = TypeCourse.Level0
                    },
                    new AudioLesson()
                    {
                        Id = 2,
                        Subject = "Emoții",
                        ImagePath = "/images/audioLesson/0.jpg",
                        Level = TypeCourse.Level0
                    }
                });

                builder.Property(x => x.Id).ValueGeneratedOnAdd();
               
                builder.Property(x => x.Subject).HasMaxLength(100).IsRequired();
                builder.Property(x => x.Level).IsRequired();

            });
            modelBuilder.Entity<AudioEntity>()
                            .HasOne(x => x.AudioLesson)
                            .WithMany(x => x.AudioEntity)
                            .HasForeignKey(x => x.IdAudioLesson)
                             .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<AudioEntity>(builder =>
            {
                builder.ToTable("AudioEntities").HasKey(x => x.Id);

                builder.Property(x => x.Id).ValueGeneratedOnAdd();
                
                builder.HasData(new AudioEntity()
                {
                    Id = 1,
                    TextSpanish = "Tortuga",
                    TextRomanian = "Brosacă țestoasă",
                    SoundSpanishPath = null, 
                    SoundRomanianPath = null,
                    ImagePath = null,
                    IdAudioLesson = 1

                });
            });






        }
    }
}
