namespace CapaDatos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Prueba1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DetallesDeVentas",
                c => new
                    {
                        DetallesDeVentaId = c.Int(nullable: false, identity: true),
                        Cantidad = c.Int(nullable: false),
                        Precio = c.Int(nullable: false),
                        ProductoId = c.Int(nullable: false),
                        VentaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.DetallesDeVentaId)
                .ForeignKey("dbo.Productoes", t => t.ProductoId, cascadeDelete: true)
                .ForeignKey("dbo.Ventas", t => t.VentaId, cascadeDelete: true)
                .Index(t => t.ProductoId)
                .Index(t => t.VentaId);
            
            CreateTable(
                "dbo.Productoes",
                c => new
                    {
                        ProductoId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 150),
                        Descripcion = c.String(maxLength: 250),
                        Precio = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Existencias = c.Int(nullable: false),
                        Estado = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ProductoId);
            
            CreateTable(
                "dbo.Ventas",
                c => new
                    {
                        VentaId = c.Int(nullable: false, identity: true),
                        FechaVenta = c.DateTime(nullable: false),
                        Total = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.VentaId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.DetallesDeVentas", "VentaId", "dbo.Ventas");
            DropForeignKey("dbo.DetallesDeVentas", "ProductoId", "dbo.Productoes");
            DropIndex("dbo.DetallesDeVentas", new[] { "VentaId" });
            DropIndex("dbo.DetallesDeVentas", new[] { "ProductoId" });
            DropTable("dbo.Ventas");
            DropTable("dbo.Productoes");
            DropTable("dbo.DetallesDeVentas");
        }
    }
}
