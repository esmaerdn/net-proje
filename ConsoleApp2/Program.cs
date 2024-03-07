// See https://aka.ms/new-console-template for more information

// Kullanıcıdan kaç ürün almak istediğini soran,her ürünün fiyatını alarak toplam alışveriş tutarını hesaplayan bir algoritma yazınız.

Console.Write("Almak istediğiniz ürün miktarını yazınız:");
    int totalProduct = Convert.ToInt32(Console.ReadLine());
    double totalPrice = 0;

    for (int i = 1; i <= totalProduct; i++)
    {
        Console.Write("Ürün fiyatını giriniz:");
        double productPrice = Convert.ToDouble(Console.ReadLine());
        totalPrice += productPrice;
    }

    Console.WriteLine("Toplam alışveriş tutarınız:" + totalPrice + " " + "TL");
