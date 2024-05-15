using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class VentaDAL
    {
        ContextoBD _db;

        public int Guardar(Venta venta, int id = 0, bool esAcualizacion = false)
        {
            _db = new ContextoBD();
            int resultado;

            if (esAcualizacion)
            {
                venta.VentaId = id;

                _db.Entry(venta).State = System.Data.Entity.EntityState.Modified;
                _db.SaveChanges();
            }
            else
            {
                _db.Ventas.Add(venta);
                _db.SaveChanges();
            }

            resultado = venta.VentaId;

            return resultado;
        }
    }
}
