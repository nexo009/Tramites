using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Tramites.Models
{
    public class TramitesContext : DbContext
    {
        public TramitesContext() :base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<Tramites.Models.Pais> Pais { get; set; }
    }
}