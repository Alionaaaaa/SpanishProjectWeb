﻿// <auto-generated />
using System;
using DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace SpanishWebProj.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240326233205_changedata")]
    partial class changedata
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.26")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Domain.Entity.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<byte[]>("Avatar")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TypeCourse")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("Domain.Entity.Forum.ForumCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("ForumTopicId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ForumCategories");
                });

            modelBuilder.Entity("Domain.Entity.Forum.ForumMessage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ForumTopicId")
                        .HasColumnType("int");

                    b.Property<DateTime>("PostDateTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("ProfileId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ForumTopicId");

                    b.HasIndex("ProfileId");

                    b.HasIndex("UserId");

                    b.ToTable("ForumMessages");
                });

            modelBuilder.Entity("Domain.Entity.Forum.ForumTopic", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ForumCategoryId")
                        .HasColumnType("int");

                    b.Property<int>("ForumMessageId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ForumCategoryId");

                    b.ToTable("ForumTopics");
                });

            modelBuilder.Entity("Domain.Entity.Profile", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Profiles", (string)null);
                });

            modelBuilder.Entity("Domain.Entity.Quiz.Quiz", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Quizes", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Capitale"
                        });
                });

            modelBuilder.Entity("Domain.Entity.Quiz.QuizQuestion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("A")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("B")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("C")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("D")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("QuestionText")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("QuizId")
                        .HasColumnType("int");

                    b.Property<string>("RightAnswer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("QuizId");

                    b.ToTable("QuizQuestions", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            A = "Moscow",
                            B = "Moscow",
                            C = "Moscow",
                            D = "Paris",
                            QuestionText = "What is the capital of France?",
                            QuizId = 1,
                            RightAnswer = "Paris"
                        });
                });

            modelBuilder.Entity("Domain.Entity.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Users", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Ana",
                            Password = "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92",
                            Role = 2
                        },
                        new
                        {
                            Id = 2,
                            Name = "Aliona",
                            Password = "481f6cc0511143ccdd7e2d1b1b94faf0a700a8b49cd13922a70b5ae28acaa8c5",
                            Role = 1
                        });
                });

            modelBuilder.Entity("Domain.Entity.Vocabulary.AudioEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("IdAudioLesson")
                        .HasColumnType("int");

                    b.Property<string>("ImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SoundRomanianPath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SoundSpanishPath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TextRomanian")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TextSpanish")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("IdAudioLesson");

                    b.ToTable("AudioEntities", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IdAudioLesson = 1,
                            TextRomanian = "Brosacă țestoasă",
                            TextSpanish = "Tortuga"
                        });
                });

            modelBuilder.Entity("Domain.Entity.Vocabulary.AudioLesson", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Level")
                        .HasColumnType("int");

                    b.Property<string>("Subject")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("AudioLessons", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ImagePath = "/images/audioLesson/animale.jpg",
                            Level = 0,
                            Subject = "Animale"
                        },
                        new
                        {
                            Id = 2,
                            ImagePath = "/images/audioLesson/0.jpg",
                            Level = 0,
                            Subject = "Emoții"
                        });
                });

            modelBuilder.Entity("Domain.Entity.Worksheet.Worksheet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Level")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Path")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("WorksheetCategoryId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("WorksheetCategoryId");

                    b.ToTable("Worksheets");
                });

            modelBuilder.Entity("Domain.Entity.Worksheet.WorksheetCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("NameCategory")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("WorksheetCategory");
                });

            modelBuilder.Entity("Domain.Entity.Forum.ForumMessage", b =>
                {
                    b.HasOne("Domain.Entity.Forum.ForumTopic", "ForumTopic")
                        .WithMany("ForumMessages")
                        .HasForeignKey("ForumTopicId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entity.Profile", "Profile")
                        .WithMany()
                        .HasForeignKey("ProfileId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entity.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ForumTopic");

                    b.Navigation("Profile");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Domain.Entity.Forum.ForumTopic", b =>
                {
                    b.HasOne("Domain.Entity.Forum.ForumCategory", "ForumCategory")
                        .WithMany("ForumTopics")
                        .HasForeignKey("ForumCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ForumCategory");
                });

            modelBuilder.Entity("Domain.Entity.Profile", b =>
                {
                    b.HasOne("Domain.Entity.User", "User")
                        .WithOne("Profile")
                        .HasForeignKey("Domain.Entity.Profile", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Domain.Entity.Quiz.QuizQuestion", b =>
                {
                    b.HasOne("Domain.Entity.Quiz.Quiz", "Quiz")
                        .WithMany("QuizQuestions")
                        .HasForeignKey("QuizId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Quiz");
                });

            modelBuilder.Entity("Domain.Entity.Vocabulary.AudioEntity", b =>
                {
                    b.HasOne("Domain.Entity.Vocabulary.AudioLesson", "AudioLesson")
                        .WithMany("AudioEntity")
                        .HasForeignKey("IdAudioLesson")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AudioLesson");
                });

            modelBuilder.Entity("Domain.Entity.Worksheet.Worksheet", b =>
                {
                    b.HasOne("Domain.Entity.Worksheet.WorksheetCategory", "WorksheetCategory")
                        .WithMany("Worksheets")
                        .HasForeignKey("WorksheetCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("WorksheetCategory");
                });

            modelBuilder.Entity("Domain.Entity.Forum.ForumCategory", b =>
                {
                    b.Navigation("ForumTopics");
                });

            modelBuilder.Entity("Domain.Entity.Forum.ForumTopic", b =>
                {
                    b.Navigation("ForumMessages");
                });

            modelBuilder.Entity("Domain.Entity.Quiz.Quiz", b =>
                {
                    b.Navigation("QuizQuestions");
                });

            modelBuilder.Entity("Domain.Entity.User", b =>
                {
                    b.Navigation("Profile")
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.Entity.Vocabulary.AudioLesson", b =>
                {
                    b.Navigation("AudioEntity");
                });

            modelBuilder.Entity("Domain.Entity.Worksheet.WorksheetCategory", b =>
                {
                    b.Navigation("Worksheets");
                });
#pragma warning restore 612, 618
        }
    }
}
