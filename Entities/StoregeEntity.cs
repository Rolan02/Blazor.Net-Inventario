using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities
{
    public class StoregeEntity
    {
        [Key]
        [StringLength(50)]
        public string StorageId { get; set; }
        [Required]
        public DateTime LastUpdate { get; set; }
        [Required]
        public int PartialQuantity { get; set; }
        //relacion con productos(ProductEntity)
        public string ProductId { get; set; }
        public ProductEntity Product { get; set; }
        //relacion con Bodegas(WhereHouseEntity)
        public string WhereHouseId { get; set; }
        public WarehouseEntity WareHouse { get; set; }
        //relacion con movimientos(InputOutputEntity)
        public ICollection<InputOuputEntity> InputOuputs { get; set; }


    }
}
