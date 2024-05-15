using CapaDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class VentaLOG
    {
        VentaDAL _ventaDAL;

        public int GuardarVenta(Venta venta, int id = 0, bool esActualizacion = false)
        {
            _ventaDAL = new VentaDAL(); 
            return _ventaDAL.Guardar(venta, id, esActualizacion);
        }
    }
}
