using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Tramites.Models
{
    public class Pais
    {
        [Key]
        public int CodigoPais { get; set; }

        [Required(ErrorMessage = "El Campo es Obligatorio") ]
        [Display(Name ="Nombre Pais")]
        public string DescripcionPais { get; set; }

        public virtual ICollection<Departamento> Departamentos { get; set; }
    }
}