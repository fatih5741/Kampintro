using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {

        //naming convention
        //syntax -- yazım şekli demektir
        public void Ekle(Urun urun) //Bir Metot(Fonksiyon) oluşturduk. Metoda Urun cinsinde urun aliası ekledik
        {
            Console.WriteLine("Tebrikler. Sepete Eklendi : " + urun.Adi);
        }

        public void Ekle2(string urunAdi, string aciklama, double fiyat, int stokAdedi)
        {
            Console.WriteLine("Tebrikler. Sepete Eklendi : " + urunAdi );
        }
    }
}
