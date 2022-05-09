using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class Product//Ürün
    {
        public int  Id { get; set; }//Ürün idsi.

        public int CategoryId { get; set; }//Kategori idsi.

        public string ProductName { get; set; }//Ürünün ismi.

        public double UnitPrice { get; set; }//Ürünün birim fiyatı.

        public int UnitInStock { get; set; }//Ürün stoğu.

    }
}
