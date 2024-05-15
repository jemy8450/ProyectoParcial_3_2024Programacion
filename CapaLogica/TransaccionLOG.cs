using CapaDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class TransaccionLOG
    {
        TransaccionDAL _transaccionDAL;

        public List<DetallesDeVenta> ObtenerProductos()
        {
            _transaccionDAL = new TransaccionDAL();

            return _transaccionDAL.Leer();
        }
    }
}
