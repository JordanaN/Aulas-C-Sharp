using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Aula_03_05_16.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Categoria { get; set; }
        public decimal Price { get; set; }
    }
}