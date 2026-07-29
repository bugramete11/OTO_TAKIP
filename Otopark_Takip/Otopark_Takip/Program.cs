namespace Otopark_Takip
{
    internal class Program
    {
        static int toplamYer = 40;
        static int bosYer = 40;
        static int toplamAracSayisi = 0;

        static int[] iceridekiAraclar = new int[7];
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("===Otopark Takip Sistemi===");
                Console.WriteLine($"Toplam Yer : {toplamYer} br");
                Console.WriteLine($"Kalan Boş Yer : {bosYer} br");
                Console.WriteLine($"İçerideki Araç : {toplamAracSayisi} adet\n");

                Console.WriteLine("--- İçerideki Araçların Detayı ---");

                if  (toplamAracSayisi == 0)
                { 
                        Console.WriteLine("- Otopark şu an tamamen boş.");
                }
                else
                {
                    if (iceridekiAraclar[1] > 0) Console.WriteLine($"- Motosiklet : {iceridekiAraclar[1]} adet");
                    if (iceridekiAraclar[2] > 0) Console.WriteLine($"- Sedan      : {iceridekiAraclar[2]} adet");
                    if (iceridekiAraclar[3] > 0) Console.WriteLine($"- SUV        : {iceridekiAraclar[3]} adet");
                    if (iceridekiAraclar[4] > 0) Console.WriteLine($"- Kamyonet   : {iceridekiAraclar[4]} adet");
                    if (iceridekiAraclar[5] > 0) Console.WriteLine($"- Kamyon     : {iceridekiAraclar[5]} adet");
                    if (iceridekiAraclar[6] > 0) Console.WriteLine($"- Tır        : {iceridekiAraclar[6]} adet");
                }    
                
                    

                Console.WriteLine("1 - Araç Girişi Yap");
                Console.WriteLine("2 - Araç Çıkışı  Yap");
                Console.WriteLine("3 - Sistemi Kapat");
                Console.Write("\nİşlem Seçiniz:  ");

                string secim = Console.ReadLine();

                switch (secim)
                {
                    case "1":
                        AracIslemi(true);
                        break;

                    case "2":
                        AracIslemi(false);
                        break;

                    case "3":
                        Console.WriteLine("Sistem Kapatılıyor...");
                        return;

                    default:
                        Console.WriteLine("Geçersiz seçim! Devam etmek için bir tuşa basın...");
                        Console.ReadKey();
                        break;

                }
            }
        }

        static void AracIslemi(bool girisMi)
        {
            Console.Clear();
            Console.WriteLine(girisMi ? "___ Araç Girişi ___ " : "___ Araç Çıkışı ___");
            Console.WriteLine("1 - Motosiklet (1 br) ");
            Console.WriteLine("2 - Araba - Sedan (2 br) ");
            Console.WriteLine("3 - Araba - SUV (3 br) ");
            Console.WriteLine("4 - Kamyonet (4 br) ");
            Console.WriteLine("5 - Kamyon (5 br) ");
            Console.WriteLine("6 - Tır (6 br)  ");
            Console.WriteLine("0 - İptal ve Ana Menüye Dön");
            Console.Write("\nAraç Tipini Seçiniz: ");

            string tipSecimi = Console.ReadLine();
            int aracBirim = 0;
            int tipIndeks = 0;

            switch (tipSecimi)
            {
                case "1": aracBirim = 1; tipIndeks = 1; break;
                case "2": aracBirim = 2; tipIndeks = 2; break;
                case "3": aracBirim = 3; tipIndeks = 3; break;
                case "4": aracBirim = 4; tipIndeks = 4; break;
                case "5": aracBirim = 5; tipIndeks = 5; break;
                case "6": aracBirim = 6; tipIndeks = 6; break;
                case "0": return;
                default:
                    Console.WriteLine("Hatalı araç tipi seçtiniz.Devam etmek için herhangi bir tuşa basınız...");
                    Console.ReadKey();
                    return;
            }
            if (girisMi)
            {
                if (bosYer >= aracBirim)
                {
                    bosYer -= aracBirim;
                    toplamAracSayisi++;
                    iceridekiAraclar[tipIndeks]++;
                    Console.WriteLine($"\nGiriş başarılı! Bu araç {aracBirim} br yer kapladı.");
                    Console.WriteLine($"Otoparkta kalan yer: {bosYer} br");
                }
                else
                {
                    Console.WriteLine("\nUyarı: Otoparkta yeterli alan yok!");
                }
            }
            else {

                    if (iceridekiAraclar[tipIndeks] > 0)
                    {
                        bosYer += aracBirim;
                        toplamAracSayisi--;
                        iceridekiAraclar[tipIndeks]--;
                        Console.WriteLine($"\nÇıkış başarılı! {aracBirim} br alan boşaldı. ");
                        Console.WriteLine($"Otoparkta güncel yer: {bosYer} br");
                    }
                    else
                    {
                        Console.WriteLine("\nHata: Otoparkta bu tipten bir araç bulunmuyor !");
                    }
                }
                Console.WriteLine("\nAna Menüye dönmek için bir tuşa basınız...");
                Console.ReadKey();


            }
        }
    }







            
    

