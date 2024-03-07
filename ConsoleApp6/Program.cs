// See https://aka.ms/new-console-template for more information


//String metotlarını araştırınız. Her bir metot için örnek yapınız.

        string str = "  '8 Mart Dünya Kadınlar Günü Kutlu Olsun.'   ";

        Console.WriteLine(str);
        Console.WriteLine("--------------------");



        Console.WriteLine("Trim Metodu");
        str = str.Trim();
        Console.WriteLine(str);


        Console.WriteLine("ToLower Metodu");
        str = str.ToLower();
        Console.WriteLine(str);


        Console.WriteLine("ToUpper Metodu");
        str = str.ToUpper();
        Console.WriteLine(str);


        Console.WriteLine("SubString Metodu");
        string sonuc = str.Substring(2, 30);
        Console.WriteLine(sonuc);


        Console.WriteLine("IndexOf Metodu");
        int sonuc1 = str.IndexOf('K');
        int sonuc2 = str.IndexOf('K', sonuc1 + 1);
        Console.WriteLine("K harfi index'i:" + sonuc1 + "','" + sonuc2);


        Console.WriteLine("Remove Metodu");
        string sonuc3 = str.Remove(4);
        Console.WriteLine(sonuc3);


        Console.WriteLine("Contains Metodu");
        bool sonuc4 = str.Contains("GÜNÜ");
        Console.WriteLine("'GÜNÜ' kelimesi arandı:" + sonuc4);


        Console.WriteLine("Reverse Metodu");
        char[] chars = str.ToCharArray();
        Array.Reverse(chars);
        string sonuc5 = new string(chars);
        Console.WriteLine(sonuc5);


        Console.WriteLine("Split Metodu");
        string[] sonuc6 = str.Split(' ');
        Console.WriteLine(string.Join(',', sonuc6));

