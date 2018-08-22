using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Real.Models
{
    public class Ville
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [ScaffoldColumn(false)]
        public int id { get; set; }

        [Required(ErrorMessage ="This field is required")]
        [Display(Name="Ville Name")]
        [MaxLength(32, ErrorMessage ="No more than 32 characters")]
        public string Name { get; set; }

        ICollection<AgenceMere> AgenceMeres { get; set; }
    }
}
