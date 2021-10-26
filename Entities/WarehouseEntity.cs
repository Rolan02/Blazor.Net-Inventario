using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities
{
    public class WarehouseEntity
    {   
        [Key]
        public string WarehouseId { get; set; }
        [Required]
        [StringLength(100)]
        public string WarehouseName { get; set; }
        [Required]
        [StringLength(200)]
        public string WarehouseAddres { get; set; }
        //relacion con almacenamiento (StoregeEntity)
        public ICollection<StoregeEntity> Storages { get; set; }

    }
}
