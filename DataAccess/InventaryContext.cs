using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
    public class InventaryContext : DbContext
    {
        //Creando las tablas con sus respectivos nombres
        public DbSet<ProductEntity> Products { get; set; }
        public DbSet<CategoryEntity> Categories { get; set; }
        public DbSet<InputOuputEntity> InOuts { get; set; }
        public DbSet<WarehouseEntity> WareHouses { get; set; }
        public DbSet<StoregeEntity> Storages { get; set; }

        //Sobre escribir el metodo de configuracion hacia la BD
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            if (!options.IsConfigured)
            {
                options.UseSqlServer("Server = DESKTOP-JV6441Q; Database = InventoryDb; User Id =sa; Password =4750619Aa ");            
            }
        }
        //Sobre escribir metodo para cargar datos 
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<CategoryEntity>().HasData(
                new CategoryEntity { CategotyId = "ASH", CategoryName= "Aseo Hogar"},
                new CategoryEntity { CategotyId = "ASP", CategoryName= "Aseo Personal"},
                new CategoryEntity { CategotyId = "HGR", CategoryName= "Hogar"},
                new CategoryEntity { CategotyId = "PRF", CategoryName= "Perfumeria"},
                new CategoryEntity { CategotyId = "SLD", CategoryName= "Salud"},
                new CategoryEntity { CategotyId = "VDJ", CategoryName= "Video Juegos"}
                );

            modelBuilder.Entity<WarehouseEntity>().HasData(
                new WarehouseEntity { WarehouseId = Guid.NewGuid().ToString(), WarehouseName = "Bodega Central",WarehouseAddres = "Calle Antezana" },
                new WarehouseEntity { WarehouseId = Guid.NewGuid().ToString(), WarehouseName = "Bodega Norte",WarehouseAddres = "Calle Atahuallapa" },
                new WarehouseEntity { WarehouseId = Guid.NewGuid().ToString(), WarehouseName = "Bodega Sud",WarehouseAddres = "Calle Villa Pagador" }
                );
        }
      
    }
}
