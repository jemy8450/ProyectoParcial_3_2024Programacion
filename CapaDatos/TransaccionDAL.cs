using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class TransaccionDAL
    {
        ContextoBD _db;

        public List<DetallesDeVenta> Leer()
        {
            _db = new ContextoBD(); //

            return _db.DetallesVentas.Where(p => p.VentaId > 0).ToList();
            
        }
    }
}
