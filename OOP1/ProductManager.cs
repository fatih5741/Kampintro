using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {
         
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName + " eklendi.");

        }

        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " güncellendi.");
        }

        ///////// VOID ///////////////////
       // void siz tanımlanan metotlarda sonucu programın farklı alanlarında da çağırabiliriz.
        //public int Topla(int sayi1, int sayi2)
        //{
        //    return sayi1 + sayi2;
        //}
        
        //// void = ile belirtilen metotlar emir kipi ifade eder git yap bitir.
        //public void Topla2(int sayi1, int sayi2)
        //{
        //    Console.WriteLine(sayi1 + sayi2);
        }


    }
}
