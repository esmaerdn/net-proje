// See https://aka.ms/new-console-template for more information


//Switch case ile müşteriden alınan sipariş numarasına göre hangi ürünün sipariş edildiğini belirleyen algoritma yazınız.

        Console.Write("Lütfen sipariş numarasını giriniz:");
        int orderNumber = Convert.ToInt32(Console.ReadLine());

        switch (orderNumber)
        {
            case 1:
                Console.WriteLine("Sipariş edilen ürün: Elbise");
                break;
            case 2:
                Console.WriteLine("Sipariş edilen ürün: Etek ");
                break;
            case 3:
                Console.WriteLine("Sipariş edilen ürün: Ayakkabı");
                break;
            case 4:
                Console.WriteLine("Sipariş edilen ürün: Saat");
                break;
            case 5:
                Console.WriteLine("Sipariş edilen ürün: Pantolon");
                break;
            default:
                Console.WriteLine("Geçersiz bir sayı girdiniz.");
                break;

        }
