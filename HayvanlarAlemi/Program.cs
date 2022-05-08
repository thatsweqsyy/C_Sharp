using System;

namespace csharp
{
    class HayvanlarAlemi
    {
        public string cins = "Belirtilmedi";
        public string familya = "Belirtilmedi";
        public string yiyecekler = "Belirtilmedi";
        public string cografya = "Belirtilmedi";
        public string yasamsuresi = "Belirtilmedi";
        public string uremesekli = "Belirtilmedi";
        public string derinlik = "Belirtilmedi";

        public void setCins(string ci)
        {
            cins = ci;
        }
        public void setFamilya(string f)
        {
            familya = f;
        }
        public void setYiyecekler(string y)
        {
            yiyecekler = y;
        }
        public void setCografya(string co)
        {
            cografya = co;
        }
        public void setYasamSuresi(string ys)
        {
            yasamsuresi = ys;
        }
        public void setUremeSekli(string u)
        {
            uremesekli = u;
        }
        public void tehditaltındamı(bool tehditaltındamı)
        {
            if(tehditaltındamı == true)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Tehlike Durumu: Tehlike Altında");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Tehlike Durumu: Tehlikede Değil");
                Console.ResetColor();
            }
        }
        public void get()
        {
            Console.WriteLine("Cins: {0}\nFamilya: {1}\nYaşadığı Coğrafya: {2}\nÜreme Şekli: {3}\nYediği Yiyecekler: {4}\nOrtalama Yaşam Süresi: {5}\nYaşadığı Derinlik: {6}", cins, familya, cografya, uremesekli, yiyecekler, yasamsuresi, derinlik);
        }
    }
    class Omurgalılar : HayvanlarAlemi
    {

    }
    class Omurgasızlar : HayvanlarAlemi
    {

    }
    class Balıklar : Omurgalılar
    {
        public void setDerinlik(string d)
        {
            derinlik = d;
        }
        public Balıklar()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Yeni bir balık oluşturuluyor...");
            Console.ResetColor();        
        }
        ~Balıklar()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Oluşturulan balıklar siliniyor...");
            Console.ResetColor();
        }
    }
    class ÇenesizBalıklar : Balıklar
    {

    }
    class KıkırdaklıBalıklar : Balıklar
    {

    }
    class KemikliBalıklar : Balıklar
    {

    }
    class Amfibiler : Omurgalılar
    {
        public Amfibiler()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Yeni bir amfibik canlı oluşturuluyor...");
            Console.ResetColor();
        }
        ~Amfibiler()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Oluşturulan amfibik canlılar siliniyor...");
            Console.ResetColor();
        }
    }
    class Sürüngenler : Omurgalılar
    {
        public Sürüngenler()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Yeni bir sürüngen hayvan oluşturuluyor...");
            Console.ResetColor();
        }
        ~Sürüngenler()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Oluşturulan sürüngen hayvanlar siliniyor...");
            Console.ResetColor();
        }
    }
    class Kuşlar : Omurgalılar
    {
        public Kuşlar()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Yeni bir kuş oluşturuluyor...");
            Console.ResetColor();
        }
        ~Kuşlar()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Oluşturulan kuşlar siliniyor...");
            Console.ResetColor();
        }
    }
    class Memeliler : Omurgalılar
    {
        public Memeliler()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Yeni bir memeli oluşturuluyor...");
            Console.ResetColor();
        }
        ~Memeliler()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Oluşturulan memeliler siliniyor...");
            Console.ResetColor();
        }
    }
    class Süngerler : Omurgasızlar
    {
        public Süngerler()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Yeni bir sünger oluşturuluyor...");
            Console.ResetColor();
        }
        ~Süngerler()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Oluşturulan süngerler siliniyor...");
            Console.ResetColor();
        }
    }
    class Sölenterler : Omurgasızlar
    {
        public Sölenterler()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Yeni bir sölenterler oluşturuluyor...");
            Console.ResetColor();
        }
        ~Sölenterler()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Oluşturulan sölenterler siliniyor...");
            Console.ResetColor();
        }
    }
    class Solucanlar : Omurgasızlar
    {
        public Solucanlar()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Yeni bir solucan oluşturuluyor...");
            Console.ResetColor();
        }
        ~Solucanlar()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Oluşturulan solucanlar siliniyor...");
            Console.ResetColor();
        }
    }
    class HalkalıSolucanlar: Solucanlar
    {

    }
    class YassıSolucanlar : Solucanlar
    {

    }
    class YuvarlakSolucanlar : Solucanlar
    {

    }
    class Yumuşakçalar: Omurgasızlar
    {
        public Yumuşakçalar()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Yeni bir yumuşakça oluşturuluyor...");
            Console.ResetColor();
        }
        ~Yumuşakçalar()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Oluşturulan yumuşakçalar siliniyor...");
            Console.ResetColor();
        }
    }
    class Eklembacaklılar: Omurgasızlar
    {
        public Eklembacaklılar()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Yeni bir eklembacaklı oluşturuluyor...");
            Console.ResetColor();
        }
        ~Eklembacaklılar()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Oluşturulan eklembacaklılar siliniyor...");
            Console.ResetColor();
        }
    }
    class Kabuklular: Eklembacaklılar
    {

    }
    class Örümceğimsiler: Eklembacaklılar
    {

    }
    class ÇokBacaklılar: Eklembacaklılar
    {

    }
    class Böcekler: Eklembacaklılar
    {

    }
    class DerisiDikenliler: Omurgasızlar
    {
        public DerisiDikenliler()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Yeni bir derisidikenli oluşturuluyor...");
            Console.ResetColor();
        }
        ~DerisiDikenliler()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Oluşturulan derisidikenli siliniyor...");
            Console.ResetColor();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Balıklar balık1 = new Balıklar();
            balık1.setFamilya("İzmaritgiller");
            balık1.setCins("Sparus aurata, Çipura");
            balık1.setCografya("Akdeniz");
            balık1.setUremeSekli("Eşeyli Üreme");
            balık1.setDerinlik("0-30 m");
            balık1.setYasamSuresi("10 Yıl");
            balık1.setYiyecekler("Sülünes, karides, midye, sardalye, yengeç, boru kurdu, mamun, madya, minare, ayaklı, kalamar");
            balık1.get();
            balık1.tehditaltındamı(false);

            Amfibiler amfibi1 = new Amfibiler();
            amfibi1.setCins("Ambystoma mexicanum, Aksolotl");
            amfibi1.setCografya("Meksika Chalco Gölü ve Meksika'nın dağ gölleri");
            amfibi1.setFamilya("Ambystomatidae");
            amfibi1.setYasamSuresi("15 Yıl");
            amfibi1.setYiyecekler("Solucan, böcek, kabuklu, yumuşakça ve küçük balık");
            amfibi1.setUremeSekli("Eşeyli Üreme");
            amfibi1.get();
            amfibi1.tehditaltındamı(true);

            Kuşlar kuş1 = new Kuşlar();
            kuş1.setCins("Sialia, Mavi Ardıç");
            kuş1.setFamilya("Ardıçgiller");
            kuş1.setUremeSekli("Eşeyli Üreme");
            kuş1.setCografya("Kuzey Amerika, Kanada, Meksika");
            kuş1.setYiyecekler("Böcekler, Bitkiler");
            kuş1.setYasamSuresi("10 Yıl");
            kuş1.get();
            kuş1.tehditaltındamı(false);

            Console.ReadKey();
        }
    }
}