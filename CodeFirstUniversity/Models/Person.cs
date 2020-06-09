using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CodeFirstUniversity.Models
{
    public class Person
    {
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name ="Last Name")]
        public string LastName { get; set; }

        [Required]
        [StringLength(50, ErrorMessage ="Primer Nombre no puede ser mas largo que 50 letras")]
        [Column("FirstName")]
        [Display(Name ="Fist Name")]
        public string FirstMidName { get; set; }

        [Display(Name ="FullName")]
        public string Fullname
        {
            get
            {
                return LastName + ", " + FirstMidName;
            }
        }
    }
}