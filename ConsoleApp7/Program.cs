// See https://aka.ms/new-console-template for more information

//Kullanıcıdan öğrenci sayısını isteyen her öğrenci için öğrenci adı,öğrenci soyadı,1.sınav notu,2.sınav notu,3.sınav notu isteyen
//ve daha sonra not ortalamasını hesaplayıp ekrana yazdıran algoritma yapınız.


    Console.Write("Sınıftaki öğrenci sayısını yazınız: ");
    int totalStudent = Convert.ToInt32(Console.ReadLine());

    for (int i = 1; i <= totalStudent; i++)
    {
        Console.Write("Öğrencinin adını giriniz:");
        string firstName = Console.ReadLine();

        Console.Write("Öğrencinin soyadını giriniz:");
        string lasttName = Console.ReadLine();

        Console.Write("Öğrencinin 1.sınav notunu giriniz:");
        double note1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Öğrencinin 2.sınav notunu giriniz:");
        double note2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Öğrencinin 3.sınav notunu giriniz:");
        double note3 = Convert.ToInt32(Console.ReadLine());

        double totalNote = (note1 + note2 + note3) / 3;


        Console.WriteLine(firstName + " " + lasttName + " " + " not ortalaması:" + totalNote);
        Console.WriteLine("-----------------------------------------");

    }

