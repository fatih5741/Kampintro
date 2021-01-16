using System;

namespace DegerVeReferansTipler //Bu konuyu anlarsak yazılım hayatı çok kolay olur !!!!!
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            //sayi1 ??? = Artık 30 olur 


            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            //sayilr1[0] ??? = Artık 999 olur


            // int,decimal,float,double,bool = değer tip olarak karşımıza çıkar
            //array,class,interface = referans tip olarak karşımıza çıkar

            //Bellekte Stack ve heap adında iki alan var. Stack değer tipleri tutat, Heap Referans tipleri tutar.

        }
    }
}
