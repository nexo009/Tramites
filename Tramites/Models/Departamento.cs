using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Tramites.Models
{
    public class Departamento
    {
        [Key]
        public int CodigoDepartamento { get; set; }

        [Required(ErrorMessage = "El Campo es Obligatorio")]
        [Display(Name ="Nombre Departamento")]
        public string DescripcionDepartamento { get; set; }

        [Required(ErrorMessage = "El Campo es Obligatorio")]

        public int CodigoPais { get; set; }

        public virtual Pais Pais { get; set; }
    }
}