using Domain.Entity.Vocabulary;
using Domain.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity.Worksheet
{
     public class Worksheet
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
        public TypeCourse Level { get; set; }
        public WorksheetCategory WorksheetCategory { get; set; }
        [ForeignKey("WorksheetCategoryId")]
        public int WorksheetCategoryId { get; set; }

    }
}
