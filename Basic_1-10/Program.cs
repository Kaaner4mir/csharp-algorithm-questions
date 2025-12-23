class Program
{
    static void Main()
    {
        #region 1. Klavyeden girilen 5 adet not bilgisinin ortalamasını alan programı yapınız.

        //double average = 0;

        //for (int i = 0; i < 5; i++)
        //{
        //    Console.Write($"i + 1}. sayıyı girin: ");
        //    double number = Convert.ToDouble(Console.ReadLine());

        //    average += number;
        //}

        //Console.WriteLine($"\nSayıların ortalaması: {average/5}");

        #endregion
        #region 2. Klavyeden girilen 5 adet notun en büyük ve en küçüğünü bulan programı yapınız.

        //int[] grades = new int[5];

        //Console.Write("1. notu girin: ");
        //grades[0] = Convert.ToInt32(Console.ReadLine());

        //int maxGrade = grades[0];
        //int minGrade = grades[0];

        //for (int i = 1; i < 5; i++)
        //{
        //    Console.Write($"{i + 1}. notu girin: ");
        //    grades[i] = Convert.ToInt32(Console.ReadLine());

        //    if (grades[i] > maxGrade)
        //        maxGrade = grades[i];

        //    if (grades[i] < minGrade)
        //        minGrade = grades[i];
        //}

        //Console.WriteLine($"Girilen 5 not arasında en büyük: {maxGrade}");
        //Console.WriteLine($"Girilen 5 not arasında en küçük: {minGrade}");

        #endregion
        #region 3. Klavyeden girilen 5 adet sayının 10’dan büyük olanlarını sayan programı yapınız.

        //List<int> numbers = new List<int>();

        //for (int i = 0; i < 5; i++)
        //{
        //    Console.Write($"{i + 1}. sayıyı girin: ");
        //    int number = Convert.ToInt32(Console.ReadLine());

        //    if (number > 10)
        //        numbers.Add(number);
        //}
        //foreach (var item in numbers)
        //{
        //    Console.WriteLine($"\n{item}");
        //}

        #endregion
        #region 4. Klavyeden 0 sayısı girilene kadar sayılar okutunuz. Girilen sayıların 2 katını alarak ekrana sonucu yazdırınız.

        //while (true)
        //{
        //    Console.Write("Bir sayı girin: ");
        //    int number = Convert.ToInt32(Console.ReadLine());

        //    if (number == 0)
        //        break;

        //    Console.WriteLine(number*2);
        //}

        //Console.WriteLine("Girilen sayı 0!");

        #endregion
        #region 5. 30 kişilik sınıfta, yaşı 13 ile 15 arasında olanların sayısını bulan programı yapınız.

        //int[] agesOfStudents = new int[30];
        //int count = 0;

        //for (int i = 0; i < agesOfStudents.Length; i++)
        //{
        //    Random random = new Random();
        //    agesOfStudents[i] = random.Next(9,20);
        //}

        //foreach (var item in agesOfStudents)
        //{
        //    if (item >= 13 && item <= 15)
        //        count++;
        //}

        //Console.WriteLine($"Yaşları 13 ile 15 arasında olan öğrencilerin sayısı: {count}");

        #endregion
        #region 6. 30 kişilik sınıfta yaşı 13, 14, 15 ve 16 olanların sayısını ayrı ayrı bulan programı yapınız.

        //int[] ageOfStudents = new int[30];
        //int count13 = 0;
        //int count14 = 0;
        //int count15 = 0;
        //int count16 = 0;

        //for (int i = 0; i < ageOfStudents.Length; i++)
        //{
        //    Random random = new Random();
        //    ageOfStudents[i] = random.Next(10, 20);
        //}

        //foreach (var item in ageOfStudents)
        //{
        //    if (item == 13)
        //        count13++;
        //    else if (item == 14)
        //        count14++;
        //    else if (item == 15)
        //        count15++;
        //    else if (item == 16)
        //        count16++;
        //}

        //Console.WriteLine($"Yaşı 13 olanların sayısı: {count13}\n" +
        //                  $"Yaşı 14 olanların sayısı: {count14}\n" +
        //                  $"Yaşı 15 olanların sayısı: {count15}\n" +
        //                  $"Yaşı 16 olanların sayısı: {count16}");

        #endregion
        #region 7. Klavyeden girilen 5 adet sayının tek tek karelerini alan programı yapınız.

        //List<int> squareOfNumbers = new List<int>();

        //for (int i = 0; i < 5; i++)
        //{
        //    Console.Write($"{i+1}. sayıyı girin: ");
        //    int number = Convert.ToInt32(Console.ReadLine());

        //    squareOfNumbers.Add(number * number);
        //}

        //for (int i = 0; i < squareOfNumbers.Count; i++)
        //{
        //    Console.WriteLine($"{i + 1}. sayının karesi: {squareOfNumbers[i]}");
        //}
        #endregion
    }
}