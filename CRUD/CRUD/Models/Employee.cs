using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CRUD.Models
{
    [Table("Employee")]
    public class Employee
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public int age { get; set; }
        public string gender { get; set; }
        public string position { get; set; }
    
    }
 
}