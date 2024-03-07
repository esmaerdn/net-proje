// See https://aka.ms/new-console-template for more information

//Bir sayının mükemmel sayı olup olmadığı kontrol eden algoritma yazınız.
    

    Console.Write(" Lütfen bir sayı giriniz: ");
    int sayi = Convert.ToInt32(Console.ReadLine());
    int toplam = 0;

    for (int i= 1; i < sayi; i++) 
    {
        if (sayi % i == 0)
        {
            toplam += i;
        }

    }
   
    if (toplam == sayi)
    {
        Console.WriteLine("'" + sayi + "'" + "sayısı Mükemmel Sayıdır.");
    }
    
    else
    {
        Console.WriteLine("'" + sayi + "'" + "sayısı Mükemmel Sayı değildir.");
    }
        Console.ReadLine();
