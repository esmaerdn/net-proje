// See https://aka.ms/new-console-template for more information


// While döngüsünde parantez içindeki şart sağlanıyorsa döngü devam eder, sağlanmaz ise döngüden çıkar.

        int sayi = 0;
        int toplam = 0;

            while (sayi <= 50)
            {
                if (sayi % 2 == 0)
                    toplam += sayi;
                sayi++;
            }

            Console.WriteLine("50'ye kadar olan çift sayılar toplamı:" + toplam);
            Console.ReadKey();
            Console.WriteLine("--------------------------------------------------");


// do-while döngüsü de tıpkı while döngüsü gibidir, while döngüsünden farklı olarak döngü içindeki kısım en az bir defa işletilir.

        char i = 'A';
            do
            {
                Console.WriteLine(i);
                i++;
            }

            while (i <= 'Z');
            Console.ReadLine();
