using System;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int dogruSayi = random.Next(1, 101);
        int kullaniciTahmini = 0;
        int denemeSayisi = 0;

        Console.WriteLine("Sayı Tahmin Oyununa Hoş Geldiniz!");
        Console.WriteLine("1 ile 100 arasında bir sayı tahmin edin:");

        while (kullaniciTahmini != dogruSayi)
        {
            string girdi = Console.ReadLine();

            if (int.TryParse(girdi, out kullaniciTahmini))
            {
                denemeSayisi++;

                if (kullaniciTahmini > dogruSayi)
                {
                    Console.WriteLine("Daha küçük bir sayı tahmin edin.");
                }
                else if (kullaniciTahmini < dogruSayi)
                {
                    Console.WriteLine("Daha büyük bir sayı tahmin edin.");
                }
                else
                {
                    Console.WriteLine($"Tebrikler! Doğru tahmin ettiniz. Toplam deneme sayısı: {denemeSayisi}");
                }
            }
            else
            {
                Console.WriteLine("Lütfen geçerli bir sayı girin.");
            }
        }
    }
}

