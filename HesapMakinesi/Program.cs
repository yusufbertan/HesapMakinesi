namespace HesapMakinesi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sayi1, sayi2, sonuc;
            string islem;

            Console.WriteLine("Hesap Makinesi");
            Console.WriteLine("Birinci sayıyı girin:");
            sayi1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("İkinci sayıyı girin:");
            sayi2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Yapmak istediğiniz işlemi girin (+, -, *, /):");
            islem = Console.ReadLine();

            switch (islem)
            {
                case "+":
                    sonuc = sayi1 + sayi2;
                    Console.WriteLine($"Sonuç: {sonuc}");
                    break;
                case "-":
                    sonuc = sayi1 - sayi2;
                    Console.WriteLine($"Sonuç: {sonuc}");
                    break;
                case "*":
                    sonuc = sayi1 * sayi2;
                    Console.WriteLine($"Sonuç: {sonuc}");
                    break;
                case "/":
                    if (sayi2 != 0)
                    {
                        sonuc = sayi1 / sayi2;
                        Console.WriteLine($"Sonuç: {sonuc}");
                    }
                    else
                    {
                        Console.WriteLine("Bir sayıyı sıfıra bölemezsiniz!");
                    }
                    break;
                default:
                    Console.WriteLine("Geçersiz işlem!");
                    break;
            }
        }
    }
}
            
    

