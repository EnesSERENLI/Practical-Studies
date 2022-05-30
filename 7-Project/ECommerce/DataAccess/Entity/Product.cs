﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Core;

namespace DataAccess.Entity
{
    public class Product:EntityRepository
    {
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public short UnitInStock { get; set; }
        public string ProductImagePath { get; set; }
        public string Description { get; set; }

        public Guid SubCategoryId { get; set; }
        public Guid SupplierId { get; set; }
        public virtual SubCategory SubCategory { get; set; }
        public virtual Supplier Supplier { get; set; }

    }
}
