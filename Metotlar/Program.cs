using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması";
            urun1.stokAdedi = 5;

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır karpuzu";
            urun2.stokAdedi = 20;


            Urun[] urunler = new Urun[] {urun1, urun2 };
            // type-safe -- tip güvenli  (c# ve java gibi diller tip güvenli yani tipleri bilmek ister ve öyle çalışır)
            foreach (Urun urun in urunler)
            {
                Console.WriteLine("ÜRün Adı: " + urun.Adi + "\nÜrün Fiyatı: " + urun.Fiyati + "\nÜrün Açıklaması: "  + urun.Aciklama + "\nStok Adedi: " + urun.stokAdedi + "\n----------");
              
            }

            Console.WriteLine("\n\n\n-----------Metotlar----------");



            //instance - örnek -- aşağıda sepetAmanager sııfının örneğini oluşturdum.
            //encapsulation
            Console.WriteLine("\n-------Ekle MEtodu---------");
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            Console.WriteLine("\n---------Ekle2 Metodu----------");  // Bu şekilde bir Classtan çekilmeyerek metoda manuel olarak verilen ürün özelliklerinde yeni bir değişiklik olduğunda
                                                                   //bütün sayfalardaki Ekle2 metodunu bularak içine değer vermek gerekicektir. Ama Classtan çekildiğinde sadece Urun classına
                                                                   //gidip oraya istenen özelliği eklemek yeterli olacaktır.

            sepetManager.Ekle2("Armut", "Yeşil armut", 12, 10);
            sepetManager.Ekle2("Elma", "Yeşil elma", 12, 9);
            sepetManager.Ekle2("Karpuz", "Diyarbakır karpuzu", 12, 8);

        }
    }
}


// Dont repeat yourself - DRY(dünyadaki kısaltması) - Clean Code - Best Practice(En iyi uygulama teknikleri)