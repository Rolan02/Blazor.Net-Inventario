﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities
{
    public class WherehouseEntity
    {   
        [Key]
        public string WherehouseId { get; set; }
        [Required]
        [StringLength(100)]
        public string WherehouseName { get; set; }
        [Required]
        [StringLength(200)]
        public string WherehouseAddres { get; set; }
    }
}
