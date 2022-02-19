using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplicationExam.Models
{
    public class Product
    {   [Key]
        public int ProductId { set; get; }
        public String ProductName { set; get; }
        public decimal Rate { set; get; }

        public string Description { set; get; }

        public string CategoryName { set; get; }

    }
}