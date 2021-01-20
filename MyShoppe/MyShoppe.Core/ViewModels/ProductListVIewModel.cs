using MyShoppe.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShoppe.Core.ViewModels
{
    public class ProductListVIewModel
    {
        public IEnumerable<Product> Products{ get; set; }
        public IEnumerable<ProductCategory> ProductCategories { get; set; }
    }
}
