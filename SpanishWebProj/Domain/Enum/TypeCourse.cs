using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Domain.Enum
{
    public enum TypeCourse
    {
        [Display(Name = "Începător")]
        Level0 = 0,

        [Display(Name = "Elementar")]
        Level1 = 1,

        [Display(Name = "Intermediar")]
        Level2 = 2,

        [Display(Name = "Post intermediar")]
        Level3 = 3,

        [Display(Name = "Autonom")]
        Level4 = 4, 

        [Display(Name = "Nativ")]
        Level5 = 5


    }
}
