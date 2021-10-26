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

        //Sobre escribir el metodo 
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            if (!options.IsConfigured)
            {
                options.UseSqlServer("Server = DESKTOP-JV6441Q; Database = InventoryDb; User Id =sa; Password =4750619Aa ");            
            }
        }
    }
}
