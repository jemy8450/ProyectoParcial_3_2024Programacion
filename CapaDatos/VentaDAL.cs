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

        public int Eliminar(int id)
        {
            _db = new ContextoBD();
            int resultado = 0;

            var producto = _db.Productos.Find(id);

            if (producto != null)
            {
                producto.Estado = false;
                _db.SaveChanges();

                resultado = producto.ProductoId;
            }

            return resultado;
        }

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

        //public List<Producto> Leer()
        //{
        //    _db = new ContextoBD(); //


        //    if ()
        //    {
        //        return _db.Productos.Where(p => p.Estado == false).ToList();
        //    }
        //    else
        //    {
        //        return _db.Productos.Where(p => p.Estado == true).ToList();
        //    }
        //}
    }
}
