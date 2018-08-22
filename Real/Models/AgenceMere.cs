using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Real.Models
{
    public class AgenceMere
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }


        [Display(Name ="Name Agence Mere")]
        public string Name { get; set; }

        [ScaffoldColumn(false)]
        public int VilleRefId { get; set; }


        [ForeignKey(nameof(VilleRefId))]
        public Ville Ville { get; protected set; }

    }
}
