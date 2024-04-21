﻿using Domain.Enum;
using System;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entity
{
    public class Course
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
        public TypeCourse TypeCourse { get; set; }
        public byte[]? Avatar { get; set; }

    }
}
