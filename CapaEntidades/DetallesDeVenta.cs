using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class DetallesDeVenta
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DetalleVentaId { get; set; }
        [Required]
        public int Cantidad { get; set; }
        [Required]
        public int Precio { get; set; }

        [Required]  // Para el ProductoId todo esto
        public int ProductoId { get; set; }
        [ForeignKey("ProductoId")]
        public Producto Producto { get; set; } //.


        [Required]  // Para VentaId todo esto
        public int VentaId { get; set; }
        [ForeignKey("VentaId")]
        public Venta Venta { get; set; } //.

    }
}

