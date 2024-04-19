using CapaEntidades;
using System;
using System.Configuration;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;

namespace CapaDatos
{
    public class ContextoBD : DbContext
    {
        public ContextoBD()
            : base("name=ContextoBD")
        {
        }

        public virtual DbSet<Venta> Ventas { get; set; }
        public virtual DbSet<Producto> Productos { get; set; }
        public virtual DbSet<DetallesDeVenta> DetallesVentas { get; set; }
    }
}