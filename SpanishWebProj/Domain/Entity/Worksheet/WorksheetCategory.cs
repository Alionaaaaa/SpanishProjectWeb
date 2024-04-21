using Domain.Entity.Vocabulary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity.Worksheet
{
    public class WorksheetCategory
    {
        public int Id { get; set; }
        public string NameCategory { get; set; }
        public List<Worksheet> Worksheets { get; set; }
    }
}
