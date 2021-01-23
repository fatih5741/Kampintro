using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    interface IKrediManager // Bir Metot Kredi işlemlerinde kredi oranı vs farklılıklarından dolayı arklı hesaplanır. Yani Hesapla imzası aynıdır ama içeriği farklıdır
                            // Bu durumda kredimanager vir class değil bir interface olmalıdır. Onuruluğu artırmak için interface isimleri "I" harfi ile başlatılır.
                            // IKrediManager interface ini kullanan tüm sınıflar aşağıda yazılan her metodu kullanmak(içermek) zorundadır.İnterface ler Sınıflara Implemant edilir.
    {
        void Hesapla();
        void BiseyYap();
        

        // İnterfaceleri birbirinin alternatifi olan ama kod içerikleri farklı olan durumlar için kullanırız. Bu yaptığımız örnekte kredi türlerinin "Hesapla" Metodu gibi.
    }
}
