using System;
using System.Collections.Generic; //Koleksiyonların Sınıfı !!!!

namespace Koleksiyonlar  //KOLEKSİYONLAR ARRAY LER YERİNE KULLANILIR.KOLEKSİYONLAR ARRAY LERE GÖRE DAHA AVANTAJLIDIR.SEBEBİ İSE
    //ARRAYLER TANIMLANIRKEN ARRAY DEĞERLERİ BELLİDİR. SONRADAN İÇİNE DEĞER EKLEMEYE KALKARSANIZ YENİ BİR ARRAY TANIMLAMANIZ GEREKİR VE 
    // ESKİ DEĞERLER KAYBOLUR. FAKAT LİST(KOLEKSİYONLARDA) İSTEDİĞİNİZ KADAR DEĞER TANIMLAYABİLİRSİNİZ KOLEKSİYONUN İÇİNE VE DAHA SONRADAN
    //DA İÇİNE DEĞER EKLEYEBİLİRSİNİZ.
{
    class Program
    {
        static void Main(string[] args)
        {
             
//////////////////////////////////////////////////// ARRAY (DİZİ) ///////////////////////////////////////////////////////////////////////////            
            //string[] isimler = new string[] {"Fatih", "Muhammet", "Ahmet", "Oğuzhan" };
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);
            //isimler = new string[5];
            //isimler[4] = "İlker";
            //Console.WriteLine(isimler[4]);
            //Console.WriteLine(isimler[0]);
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////








//////////////////////////////////////////////// LİST (KOLEKSİYON) ///////////////////////////////////////////////////////////////////
            List<string> isimler2 = new List<string> {"Fatih", "Muhammet", "Ahmet", "Oğuzhan" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("İlker");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        

        }
    }
}
