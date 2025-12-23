class Program
{
    static void Main()
    {
        #region 21. Bir sayının kendisi dışında bütün pozitif bölenlerinin toplamı kendisine eşit olan sayılara mükemmel sayı denir. Kullanıcıdan alınan sayının mükemmel sayı olup olmadığını kontrol eden kodu yazınız.

        //List<int> divisor = new List<int>();

        //Console.Write("Bir sayı girin: ");
        //int number = Convert.ToInt32(Console.ReadLine());

        //for (int i = 1; i < number; i++)
        //{
        //    if (number % i == 0)
        //        divisor.Add(i);
        //}

        //int total = 0;

        //foreach (var item in divisor)
        //{
        //    total += item;
        //}

        //if (total == number)
        //    Console.WriteLine($"{number} mükkemmel sayıdır.");
        //else
        //    Console.WriteLine($"{number} mükkemmel sayı değildir.");

        #endregion
        #region 22. Kullanıcının girdiği sayının pozitif tam bölenlerini bulan kodu yazınız.

        //Console.Write("Bir sayı girin: ");
        //int number = Convert.ToInt32(Console.ReadLine());

        //for (int i = 1; i <= number; i++)
        //{
        //    if (number % i == 0)
        //        Console.WriteLine(i);
        //}

        #endregion
        #region 23. Aracın gittiği toplam km’deki yakıt masrafını hesaplayan kodu yazınız.

        //Console.Write("Km başı yakılan yakıt miktarını litre cinsinden giriniz: ");
        //double liter = Convert.ToDouble(Console.ReadLine());
        //Console.Write("Gidilen yolu km cinsinden giriniz: ");
        //double range = Convert.ToDouble(Console.ReadLine());

        //double expense = liter * range;

        //Console.WriteLine($"{range}km yol için yakılan toplam yakıt miktarı: {expense}");

        #endregion
        #region 24. Dik üçgende dik açının karşısındaki kenara hipotenüs denir. Hipotenüs formülü : a^2 + b^2 = c^2 olduğuna göre kullanıcıdan alınan A ve B kenarına göre hipotenüsü hesaplayan kodu yazınız.

        //Console.Write("İlk kenarın uzunluğunu giriniz: ");
        //double sideLength1 = Convert.ToDouble(Console.ReadLine());
        //Console.Write("İkinci kenarın uzunluğunu giriniz: ");
        //double sideLength2 = Convert.ToDouble(Console.ReadLine());

        //double hypotenuse = Math.Pow(sideLength1, 2) + Math.Pow(sideLength2, 2);
        //hypotenuse = Math.Sqrt(hypotenuse);

        //Console.WriteLine($"\nHipotenüsün uzunluğu: {hypotenuse}");

        #endregion
        #region 25. Beden kütle endeksi kilo/boy^2 formülü ile hesaplanarak bireyin kilolu normal zayıf veya obez sınıfına girdiği ile ilgili sonuç verir. Kütle Endeksi (KE) < 18.5 ise Zayıf , 18.5 < (KE) <=25 ise Normal , 25 < (KE) <= 30 ise Kilolu , (KE) > 25 ise birey obez sınıfına girmektedir. Kütle endeksi kodunu yazınız.

        //Console.Write("Kilonuzu giriniz (kg): ");
        //double weight = Convert.ToDouble(Console.ReadLine());

        //Console.Write("Boyunuzu giriniz (m): ");
        //double height = Convert.ToDouble(Console.ReadLine());

        //double bmi = weight / Math.Pow(height, 2);
        //Console.WriteLine($"BMI: {bmi}\n");
        //if (bmi < 18.5)
        //    Console.WriteLine("Zayıf");
        //else if (bmi <= 25)
        //    Console.WriteLine("Normal");
        //else if (bmi > 25)
        //    Console.WriteLine("Kilolu");

        #endregion
        #region 26. Çarpım tablosunu ekrana yazan kodu yazınız.

        //for (int i = 1; i <= 10; i++)
        //{
        //    for (int j = 1; j <= 10; j++)
        //    {
        //        Console.WriteLine($"{i} X {j} = {i*j}");
        //    }
        //    Console.WriteLine(new string('-',20));
        //}
        #endregion
        #region 27. Kullanıcıdan giriş alarak öğrenci numarası oluşturan bir algoritma yazınız.

        //Console.Write("Giriş yılını girin: ");
        //string year = Console.ReadLine();
        //Console.Write("Fakülte numarasını girin: ");
        //string facultyNumber = Console.ReadLine();
        //Console.Write("Bölüm numarasını girin: ");
        //string programNumber = Console.ReadLine();
        //Console.Write("Üniversiteye giriş sırasını girin: ");
        //string entry = Console.ReadLine();

        //Console.WriteLine($"Öğrenci numarası: {year + facultyNumber + programNumber + entry}");

        #endregion
        #region 28. Kullanıcının girdiği üç kenar bilgisine göre üçgenin tipini belirleyen eğer girilen kenarları uzunlukları bir üçgen oluşturmuyorsa bunu bildiren kodu yazınız.

        //Console.Write("Birinci kenar uzunluğunu girin: ");
        //int firstSide = Convert.ToInt32(Console.ReadLine());
        //Console.Write("İkinci kenar uzunluğunu girin: ");
        //int secondSide = Convert.ToInt32(Console.ReadLine());
        //Console.Write("Üçüncü kenar uzunluğunu girin: ");
        //int thirdSide = Convert.ToInt32(Console.ReadLine());

        //if (firstSide + secondSide > thirdSide && firstSide + thirdSide > secondSide && secondSide + thirdSide > firstSide)
        //{
        //    if (firstSide==secondSide && firstSide==thirdSide)
        //    {
        //        Console.WriteLine("Bu bir eşkenar üçgen.");
        //    }
        //    else if (firstSide == secondSide || firstSide == thirdSide || secondSide == thirdSide)
        //    {
        //        Console.WriteLine("Bu bir ikizkenar üçgendir.");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Bu bir çeşitkenar üçgendir.");
        //    }
        //}
        //else
        //{
        //    Console.WriteLine("\nÜçgen oluşturulamaz!");
        //}

        #endregion
        #region 29. İsim ve Soy isimleri atadığınız listeden rastgele isim ve soy isimler seçerek isim oluşturan kodu yazınız.

        //List<string> firstNames = new List<string>
        //    {
        //        "John", "Emma", "Michael", "Sophia", "Daniel",
        //        "Olivia", "Lucas", "Isabella", "Ethan", "Charlotte"
        //    };

        //List<string> lastNames = new List<string>
        //        {
        //            "Smith", "Johnson", "Brown", "Williams", "Miller",
        //            "Davis", "Garcia", "Martinez", "Anderson", "Taylor"
        //        };

        //Random random = new Random();

        //string randomFirstName = firstNames[random.Next(firstNames.Count)];
        //string randomLastName = lastNames[random.Next(lastNames.Count)];

        //Person person = new Person()
        //{
        //    FirstName = randomFirstName,
        //    LastName = randomLastName
        //};

        //Console.WriteLine($"{person.FirstName} {person.LastName}");

        #endregion
        #region 30. Kullanıcıdan alınan iki sayı arasındaki asal sayıları bulan kodu yazınız.

        //Console.Write("Küçük sayıyı girin: ");
        //int smallNumber = Convert.ToInt32(Console.ReadLine());

        //Console.Write("Büyük sayıyı girin: ");
        //int largeNumber = Convert.ToInt32(Console.ReadLine());

        //for (int i = smallNumber; i <= largeNumber; i++)
        //{
        //    if (i < 2) continue;

        //    bool isPrime = true;
        //    for (int j = 2; j <= Math.Sqrt(i); j++)
        //    {
        //        if (i % j == 0)
        //        {
        //            isPrime = false;
        //            break;
        //        }
        //    }

        //    if (isPrime)
        //        Console.WriteLine($"{i} asal sayıdır.");
        //}

        #endregion


    }
}