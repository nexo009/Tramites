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
        public string DescripcionPais { get; set; }
    }
}