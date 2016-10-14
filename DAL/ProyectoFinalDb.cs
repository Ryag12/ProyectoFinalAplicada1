using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using Entidades;
namespace DAL
{
    public class ProyectoFinalDb : DbContext
    {
        public ProyectoFinalDb(): base("name=Constr")
        {

        }
    }

    public virtual DbSet<Vendedores> Vendedor { get; set; }

}
