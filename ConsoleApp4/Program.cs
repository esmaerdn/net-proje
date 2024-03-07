// See https://aka.ms/new-console-template for more information


//Kullanıcının 1 ile 10 arasında rastgele bir sayıyı tahmin etmesini isteyen ve doğru tahmin edene kadar devam eden bir program yazınız.

Random rastgele = new Random();
int hedef = rastgele.Next(1, 11);


while (true)
{
    Console.Write("1 ile 10 arasında bir sayı yazınız: ");
    int tahminSayi;
    if (int.TryParse(Console.ReadLine(), out tahminSayi))
    {

        if (hedef == tahminSayi)
        {
            Console.WriteLine("Doğru tahmin ettiniz.");
            break;
        }
        else
        {
            Console.WriteLine("Maalesef yanlış tahmin ettiniz.Tekrar bir sayı giriniz:");
        }
    }
    else
    {
        Console.WriteLine("Geçersiz işlem. Lütfen bir sayı giriniz:");

    }
}
