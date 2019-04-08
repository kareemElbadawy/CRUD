using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CRUD.Models
{
    [Table("products")]
    public class Products
    {

        [Key]
        public int id { get; set; }
        public int items { get; set; }
        public double price { get; set; }
        public string ProductName { get; set; }
    }
}