namespace proje1
{
    internal class Program
    {
        public interface IMenu
        {
            void Calistir(); // Her menü sınıfı bu metodu uygulayacak
        }
        public class Sohbet : IMenu
        {
            public void Calistir()
            {
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.BackgroundColor = ConsoleColor.White;
                Console.Clear();
                Console.WriteLine("Sohbet başlatılıyor...");

                Console.WriteLine("╔═══════════════════════════╗");
                Console.WriteLine("║ Çıkmak için çıkış yazın.  ║");
                Console.WriteLine("╚═══════════════════════════╝");
               
                
                Console.Write("Kullanıcı adınızı girin: ");
                string kullaniciAdi = Console.ReadLine();

                Console.Clear();
                Console.WriteLine("Merhaba " + kullaniciAdi + "! Sohbet başlatılıyor...");
                Console.WriteLine("╔═══════════════════════════╗");
                Console.WriteLine("║ Çıkmak için çıkış yazın.  ║");
                Console.WriteLine("╚═══════════════════════════╝");

                Console.WriteLine("╔═══════════════════════════╗");
                Console.WriteLine("║      Örnek Mesajlar       ║");
                Console.WriteLine("╠═══════════════════════════╣");
                Console.WriteLine("║      MERHABA              ║");
                Console.WriteLine("║      Görüşmek üzere       ║");
                Console.WriteLine("║      Sast                 ║");
                Console.WriteLine("║      Tarih                ║");
                Console.WriteLine("║      Nasılsın             ║");
                Console.WriteLine("║      iyiyiym              ║");
                Console.WriteLine("║      Espri yap            ║");
                Console.WriteLine("╚═══════════════════════════╝");

                while (true)
                {
                    Console.Write($"{kullaniciAdi}: ");
                    string kullaniciGirdisi = Console.ReadLine().ToLower();

                    if (kullaniciGirdisi == "çıkış")
                    {
                        Console.WriteLine("NOVA: Sohbeti sonlandırıyoruz...");
                        break;
                    }
                    if (kullaniciGirdisi == "görüşmek üzere")
                    {
                        Console.WriteLine("NOVA: Görüşürüz " + kullaniciAdi + ". Yine beklerim.");
                        break;
                    }
                    // Sohbet cevapları
                    if (kullaniciGirdisi.Contains("merhaba"))
                    {
                        Console.WriteLine("NOVA: Merhaba! " + kullaniciAdi + " Size nasıl yardımcı olabilirim?");
                    }
                    else if (kullaniciGirdisi.Contains("saat"))
                    {
                        DateTime simdikiZaman = DateTime.Now;
                        Console.WriteLine("NOVA: Şu anki saat: " + simdikiZaman.ToString("HH:mm"));
                    }
                    else if (kullaniciGirdisi.Contains("tarih"))
                    {
                        DateTime simdikiTarih = DateTime.Now;
                        Console.WriteLine("NOVA: Bugünün tarihi: " + simdikiTarih.ToString("dd.MM.yyyy"));
                    }
                    else if (kullaniciGirdisi.Contains("nasılsın"))
                    {
                        Console.WriteLine("İyiyim. Sen nasılsın?");
                    }
                    else if (kullaniciGirdisi.Contains("iyiyiym"))
                    {
                        Console.WriteLine("Bunu duymak güzel. Sana nasıl yardım edebilirim?");
                    }
                    else if (kullaniciGirdisi.Contains("espri yap"))
                    {
                        string[] sakalar =
                        {
                        "Neden bilgisayar denize düştü? Çünkü dalgaya geldi!",
                        "Bilgisayar virüs kaptı, antivirüs ne dedi? 'Geçmiş olsun!'",
                        "Kod yazanlar neden mutlu? Çünkü 'hata'larını çözebiliyorlar!",
                        "Bir programcı neden çok kitap okur? Çünkü 'kitaplık'ları çoğaltmak ister!",
                        "Yazılımcı niye yazmayı seviyor? Çünkü her 'satır' bir yenilik!",
                        "Antivirüs yazılımı neden depresyona girdi? Çünkü sürekli 'taramak' zorundaydı!",
                        "Programcılar neden yapay zeka ile evlenmez? Çünkü çok 'dönemsel'ler!"
                        };
                        Random rastgele = new Random();
                        int index = rastgele.Next(sakalar.Length);
                        Console.WriteLine("NOVA: " + sakalar[index]);
                    }

                    else
                    {
                        Console.WriteLine("NOVA: Üzgünüm " + kullaniciAdi + ", anlamadım. Lütfen başka bir şey söyleyin.");
                    }
                }
            }
        }
        public class Saat : IMenu
        {
            public void Calistir()
            {
                Console.ResetColor();
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Clear();
                Console.WriteLine("╔═══════════════════════════╗");
                DateTime simdikiZaman = DateTime.Now; // Şu anki tarih ve saati al
                Console.WriteLine("║Saat: " + simdikiZaman.ToString("HH:mm:ss             ║")); // Saat, dakika, saniye
                Console.WriteLine("╚═══════════════════════════╝");
            }
        }
        public class Tarih : IMenu
        {
            public void Calistir()
            {
                Console.ResetColor();
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Clear();
                Console.WriteLine("╔═══════════════════════════╗");
                DateTime bugununTarihi = DateTime.Now; // Şu anki tarih ve saat
                Console.WriteLine("║Bugünün tarihi: " + bugununTarihi.ToShortDateString() + "  ║"); // Kısa tarih formatı
                Console.WriteLine("╚═══════════════════════════╝");
            }
        }
        public class Eglence : IMenu
        {
            public void Calistir()
            {
                while (true)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("╔═══════════════════════════╗");
                    Console.WriteLine("║          Eğlence          ║");
                    Console.WriteLine("╠═══════════════════════════╣");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("║1. Sayı tahmin oyunu       ║");
                    Console.WriteLine("║2. Taş Kağıt Makas         ║");
                    Console.WriteLine("║3. Kelime bulmaca          ║");
                    Console.WriteLine("║4. Çıkış                   ║");
                    Console.WriteLine("╚═══════════════════════════╝");
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write("Bir seçim yapın: ");
                    string secim = Console.ReadLine();

                    switch (secim)
                    {
                        case "1":
                            SayiTahminOyunu();
                            break;
                        case "2":
                            TasKagitMakas();
                            break;
                        case "3":
                            KelimeBulmaca();
                            break;
                        case "4":
                            return;
                        default:
                            Console.WriteLine("Hatalı seçim yaptınız. Lütfen tekrar deneyin.");
                            break;
                    }
                }
            }

            private void SayiTahminOyunu()
            {
                Console.Clear();
                Console.WriteLine("=== Sayı Tahmin Oyunu ===");
                Console.WriteLine("1 ile 100 arasında bir sayı tuttum. Tahmin etmeye çalış!");

                Random random = new Random();
                int hedefSayi = random.Next(1, 101);//1 ile 100 arasında rastgele bir sayı tutar
                int tahmin = 0;
                int denemeSayisi = 0;
                Console.WriteLine("╔═══════════════════════════╗");
                Console.WriteLine("║     önceki menüye         ║");
                Console.WriteLine("║     dönmek için           ║");
                Console.WriteLine("║     'çıkış' yazın         ║");
                Console.WriteLine("╚═══════════════════════════╝");
                while (true)
                {
                    Console.Write("Tahmininizi girin: ");
                    string kullaniciGirdisi = Console.ReadLine();

                    //Tahmin devam ederken çıkmak isteniese "çıkış" yazmalı
                    if (kullaniciGirdisi.ToLower() == "çıkış")
                    {
                        Console.WriteLine("Oyundan çıkılıyor. Görüşmek üzere!");
                        break;
                    }

                    // Girdi doğrulama
                    if (!int.TryParse(kullaniciGirdisi, out tahmin))
                    {
                        Console.WriteLine("Lütfen geçerli bir sayı girin.");
                        continue;
                    }
                    if (tahmin < 1 || tahmin > 100)
                    {
                        Console.WriteLine("Lütfen 1 ile 100 arasında bir sayı girin.");
                        continue;
                    }

                    denemeSayisi++;

                    if (tahmin < hedefSayi)
                    {
                        Console.WriteLine("Daha büyük bir sayı deneyin.");
                    }
                    else if (tahmin > hedefSayi)
                    {
                        Console.WriteLine("Daha küçük bir sayı deneyin.");
                    }
                    else
                    {
                        Console.WriteLine($"Tebrikler! Doğru tahmin ettiniz: {hedefSayi}");
                        Console.WriteLine($"Deneme sayısı: {denemeSayisi}");

                        // Yeni bir sayı tutmak için kullanıcıya sor
                        Console.Write("\nYeni bir sayı tutmamı ister misiniz?\n" +
                        "╔══════════╗\n" +
                        "║   Evet   ║\n" +
                        "║   Hayır  ║\n" +
                        "╚══════════╝\n");
                        Console.Write("Cevap: ");
                        string cevap = Console.ReadLine().ToLower();

                        if (cevap == "evet")
                        {
                            hedefSayi = random.Next(1, 101); // Yeni bir sayı tut
                            denemeSayisi = 0; // Deneme sayısını sıfırla
                            Console.WriteLine("\nYeni bir sayı tuttum! Tahmin etmeye devam edin.");
                        }
                        else
                        {
                            Console.WriteLine("Oyun sonlandırılıyor. Görüşmek üzere!");
                            break;
                        }
                    }
                }
            }
            private void TasKagitMakas()
            {
                Console.Clear();
                Console.WriteLine("=== Taş Kağıt Makas Oyunu ===");
                Console.WriteLine("Seçenekler: Taş, Kağıt, Makas");
                Console.WriteLine("╔═══════════════════════════╗");
                Console.WriteLine("║     önceki menüye         ║");
                Console.WriteLine("║     dönmek için           ║");
                Console.WriteLine("║     'çıkış' yazın         ║");
                Console.WriteLine("╚═══════════════════════════╝");


                while (true)
                {

                    //kullanıcının seçimi
                    Console.Write("Seçiminizi yapın: ");
                    string kullanicisecimi = Console.ReadLine().ToLower();

                    //bilgisayar seçimi
                    string[] taskagitmakas = { "taş", "kağıt", "makas" };
                    Random random = new Random();
                    int rastgeleIndeks = random.Next(0, taskagitmakas.Length);
                    string Novasecimi = taskagitmakas[rastgeleIndeks];

                    if (kullanicisecimi == "çıkış")
                    {
                        Console.WriteLine("çıkılıyor");
                        break;
                    }
                    if (kullanicisecimi != "taş" && kullanicisecimi != "kağıt" && kullanicisecimi != "makas")
                    {
                        Console.WriteLine("Geçersiz seçim! Lütfen geçerli bir seçim yapın!");
                        continue;
                    };
                    if (kullanicisecimi == Novasecimi)
                    {
                        Console.WriteLine("Sonuç: Berabere. Tekrar deneyelim.");
                    }
                    else if (
                        (kullanicisecimi == "taş" && Novasecimi == "kağıt") ||
                        (kullanicisecimi == "kağıt" && Novasecimi == "makas") ||
                        (kullanicisecimi == "makas" && Novasecimi == "taş"))
                    {

                        Console.WriteLine($"Benim seçimim '{Novasecimi}' seninkisi ise '{kullanicisecimi}' bu yüzden ben kazandım");
                    }
                    else if (
                        (kullanicisecimi == "makas" && Novasecimi == "kağıt") ||
                        (kullanicisecimi == "taş" && Novasecimi == "makas") ||
                        (kullanicisecimi == "kağıt" && Novasecimi == "taş"))
                    {
                        Console.WriteLine($"Benim seçimim '{Novasecimi}' seninkisi ise '{kullanicisecimi}' bu yüzden sen kazandım");

                    }
                }
            }
            private void KelimeBulmaca()
            {
                Console.Clear();
                KelimeBulmacaOyunu oyun = new KelimeBulmacaOyunu();
                oyun.OyunuBaslat();
            }

            class Kelime
            {
                public string Orijinal { get; private set; }
                public string Karisik { get; private set; }

                public Kelime(string orijinal)
                {
                    Orijinal = orijinal;
                    Karisik = KelimeyiKaristir(orijinal);
                }

                private string KelimeyiKaristir(string kelime)
                {
                    Random rastgele = new Random();
                    return new string(kelime.ToCharArray().OrderBy(c => rastgele.Next()).ToArray());
                }
            }

            class KelimeBulmacaOyunu
            {
                private List<Kelime> kelimeler = new List<Kelime>();
                private int puan = 0;

                public KelimeBulmacaOyunu()
                {
                    // Kelimeler
                    kelimeler.Add(new Kelime("programlama"));
                    kelimeler.Add(new Kelime("yazılımcı"));
                    kelimeler.Add(new Kelime("teknoloji"));
                    kelimeler.Add(new Kelime("bilgisayar"));
                    kelimeler.Add(new Kelime("klavye"));
                    kelimeler.Add(new Kelime("internet"));
                    kelimeler.Add(new Kelime("veritabanı"));
                    kelimeler.Add(new Kelime("yapayzeka"));
                    kelimeler.Add(new Kelime("algoritma"));
                    kelimeler.Add(new Kelime("donanım"));
                }

                public void OyunuBaslat()
                {
                    Console.WriteLine("Kelime Bulmaca Oyununa Hoş Geldiniz!");
                    Console.WriteLine("Karışık kelimeleri düzeltin ve cevaplarınızı yazın.");
                    Console.WriteLine("Toplam 5 kelime tahmin etmeniz gerekiyor.");
                    Console.WriteLine("╔════════════════════════════╗");
                    Console.WriteLine("║ Çıkmak için 'Çıkış' yazın. ║");
                    Console.WriteLine("╚════════════════════════════╝");

                    int tahminSayisi = 0; // Kullanıcının yaptığını tahmin sayısı
                    foreach (var kelime in kelimeler.Take(5))
                    {
                        Console.WriteLine($"\nKarışık kelime: {kelime.Karisik}");
                        Console.Write("Tahmininiz: ");
                        string tahmin = Console.ReadLine();

                        //çıkmak için
                        if (tahmin.ToLower() == "çıkış")
                        {
                            Console.WriteLine("Oyundan çıkılıyor...");
                            break;
                        }
                        tahminSayisi++; //her tahminde tahmin sayısı arttırılır

                        if (tahmin.Equals(kelime.Orijinal, StringComparison.OrdinalIgnoreCase))
                        {
                            Console.WriteLine("Doğru!");
                            puan++;
                        }
                        else
                        {
                            Console.WriteLine($"Yanlış! Doğru kelime: {kelime.Orijinal}");
                        }
                        Console.WriteLine($"Şu anki puanınız: {puan}/{tahminSayisi}");

                        // Eğer 5 tahmin yapıldıysa oyunu sonlandır
                        if(tahminSayisi == 5)
{
                            Console.WriteLine("\nToplam 5 tahmin yaptınız. Oyun sona eriyor.");
                            break;
                        }

                    }
                    Console.WriteLine($"\nOyun bitti! Toplam Puanınız: {puan}/5");
                    Console.ReadKey();
                }
            }



        }
        public class HesapMakinesi : IMenu
        {
            public void Calistir()
            {
                Console.ResetColor();
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Magenta;
                while (true)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("╔═══════════════════════════╗");
                    Console.WriteLine("║      HESAP MAKİNESİ       ║");
                    Console.WriteLine("╠═══════════════════════════╣");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("║1. Toplama                 ║");
                    Console.WriteLine("║2. Çıkarma                 ║");
                    Console.WriteLine("║3. Çarpma                  ║");
                    Console.WriteLine("║4. Bölme                   ║");
                    Console.WriteLine("║5. Çıkış                   ║");
                    Console.WriteLine("╚═══════════════════════════╝");

                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write("Bir seçim yapın: ");

                    string islem = Console.ReadLine().ToLower();

                    switch (islem)
                    {
                        case "1":
                            Toplama();
                            break;
                        case "2":
                            Cıkarma();
                            break;
                        case "3":
                            Carpma();
                            break;
                        case "4":
                            Bolme();
                            break;
                        case "5":
                            Console.WriteLine("Önceki menüye dönülüyor!");
                            return;
                        default:
                            Console.WriteLine("Hatalı seçim yaptınız. Lütfen tekrar deneyin.");
                            break;
                    }
                }

            }
            private void Toplama()
            {
                while (true)
                {
                    Console.Write("NOVA: Birinci sayıyı girin:");
                    string s1 = Console.ReadLine();
                    if (s1.ToLower() == "çıkış")
                    {
                        Console.WriteLine("Hesap makinesi sonlandırılıyor. Görüşmek üzere!");
                        break;
                    }
                    if (!double.TryParse(s1, out double s3))
                    {
                        Console.WriteLine("Hatalı giriş! Lütfen geçerli bir sayı yazın.");
                        continue;
                    }

                    Console.Write("NOVA: İkinci sayıyı girin:");
                    string s2 = Console.ReadLine();
                    if (s2.ToLower() == "çıkış")
                    {
                        Console.WriteLine("Hesap makinesi sonlandırılıyor. Görüşmek üzere!");
                        break;
                    }
                    Console.Write("NOVA: İkinci sayıyı girin:");                    
                    if (!double.TryParse(s2, out double s4))
                    {
                        Console.WriteLine("Hatalı giriş! Lütfen geçerli bir sayı yazın.");
                        continue;
                    }

                    //toplama işlemi
                    double sonuc = s3 + s4;
                    Console.WriteLine($"Sonuç: {s3} + {s4} = {sonuc}");
                    Console.WriteLine("Çıkmak için 'Çıkış' yazın: ");
                }
            }
            private void Cıkarma()
            {
                while (true)
                {
                    Console.Write("NOVA: Birinci sayıyı girin:");
                    string s1 = Console.ReadLine();
                    if (s1.ToLower() == "çıkış")
                    {
                        Console.WriteLine("Hesap makinesi sonlandırılıyor. Görüşmek üzere!");
                        break;
                    }
                    if (!double.TryParse(s1, out double s3))
                    {
                        Console.WriteLine("Hatalı giriş! Lütfen geçerli bir sayı yazın.");
                        continue;
                    }

                    Console.Write("NOVA: İkinci sayıyı girin:");
                    string s2 = Console.ReadLine();
                    if (s2.ToLower() == "çıkış")
                    {
                        Console.WriteLine("Hesap makinesi sonlandırılıyor. Görüşmek üzere!");
                        break;
                    }
                    Console.Write("NOVA: İkinci sayıyı girin:");
                    if (!double.TryParse(s2, out double s4))
                    {
                        Console.WriteLine("Hatalı giriş! Lütfen geçerli bir sayı yazın.");
                        continue;
                    }

                    //çıkarma işlemi
                    double sonuc = s3 - s4;
                    Console.WriteLine($"Sonuç: {s3} - {s4} = {sonuc}");
                    Console.WriteLine("Çıkmak için 'Çıkış' yazın: ");
                }
            }
            private void Carpma()
            {
                while (true)
                {
                    Console.Write("NOVA: Birinci sayıyı girin:");
                    string s1 = Console.ReadLine();
                    if (s1.ToLower() == "çıkış")
                    {
                        Console.WriteLine("Hesap makinesi sonlandırılıyor. Görüşmek üzere!");
                        break;
                    }
                    if (!double.TryParse(s1, out double s3))
                    {
                        Console.WriteLine("Hatalı giriş! Lütfen geçerli bir sayı yazın.");
                        continue;
                    }

                    Console.Write("NOVA: İkinci sayıyı girin:");
                    string s2 = Console.ReadLine();
                    if (s2.ToLower() == "çıkış")
                    {
                        Console.WriteLine("Hesap makinesi sonlandırılıyor. Görüşmek üzere!");
                        break;
                    }
                    Console.Write("NOVA: İkinci sayıyı girin:");
                    if (!double.TryParse(s2, out double s4))
                    {
                        Console.WriteLine("Hatalı giriş! Lütfen geçerli bir sayı yazın.");
                        continue;
                    }

                    //çarpma işlemi
                    double sonuc = s3 * s4;
                    Console.WriteLine($"Sonuç: {s3} * {s4} = {sonuc}");
                    Console.WriteLine("Çıkmak için 'Çıkış' yazın: ");
                }
            }
            private void Bolme()
            {
                while (true)
                {
                    Console.Write("NOVA: Birinci sayıyı girin:");
                    string s1 = Console.ReadLine();
                    if (s1.ToLower() == "çıkış")
                    {
                        Console.WriteLine("Hesap makinesi sonlandırılıyor. Görüşmek üzere!");
                        break;
                    }
                    if (!double.TryParse(s1, out double s3))
                    {
                        Console.WriteLine("Hatalı giriş! Lütfen geçerli bir sayı yazın.");
                        continue;
                    }

                    double s4;
                    while (true)
                    {
                        Console.Write("NOVA: İkinci sayıyı girin: ");
                        string s2 = Console.ReadLine();
                        if (s2.ToLower() == "çıkış")
                        {
                            Console.WriteLine("Hesap makinesi sonlandırılıyor. Görüşmek üzere!");
                            return;
                        }
                        if (!double.TryParse(s2, out s4))
                        {
                            Console.WriteLine("Hatalı giriş! Lütfen geçerli bir sayı yazın.");
                            continue;
                        }
                        if (s4 == 0)
                        {
                            Console.WriteLine("İkinci sayıyı '0' giremezsiniz!");
                            continue;
                        }
                        break; //geçerli bir sayı girildiğinde döngüden çıkar
                    }

                    //bölma işlemi
                    double sonuc = s3 / s4;
                    Console.WriteLine($"Sonuç: {s3} / {s4} = {sonuc}");
                    Console.WriteLine("Çıkmak için 'Çıkış' yazın: ");
                }
            }

        }

        static void Main(string[] args)
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            IMenu[] menu =
            {
                new Sohbet(),
                new Saat(),
                new Tarih(),
                new Eglence(),
                new HesapMakinesi(),               
            };

            while (true)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("╔═══════════════════════════╗");
                Console.WriteLine("║       NOVA MENÜ           ║");
                Console.WriteLine("╠═══════════════════════════╣");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("║ 1. Sohbet Başlat          ║");
                Console.WriteLine("║ 2. Saat Göster            ║");
                Console.WriteLine("║ 3. Tarih Göster           ║");
                Console.WriteLine("║ 4. Eğlence                ║");
                Console.WriteLine("║ 5. Hesap Makinesi         ║");
                Console.WriteLine("║ 6. Çıkış                  ║");
                Console.WriteLine("╚═══════════════════════════╝");

                Console.Write("Bir seçenek seçin (1-6): ");
                string secim = Console.ReadLine();

                if (int.TryParse(secim, out int index) && index >= 1 && index <= 7)
                {
                    if (index == 6)
                    {
                        Console.WriteLine("NOVA: Programdan çıkılıyor. Hoşça kalın!");
                        Thread.Sleep(1000);
                        Environment.Exit(0);
                        break;
                    }
                    menu[index - 1].Calistir(); // Seçilen sınıfın Calistir metodu çağrılır
                }
                else
                {
                    Console.WriteLine("Hatalı seçim yaptınız. Lütfen tekrar deneyin.");
                }

                Console.WriteLine("\nDevam etmek için bir tuşa basın...");
                Console.ReadKey();
            }
        }

    }

}
