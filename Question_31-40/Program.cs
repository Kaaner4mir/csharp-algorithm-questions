class Program
{
    static void Main()
    {
        #region 31. Haftanın günü (Pazartesi, Salı, …) girilince, o günün haftanın kaçıncı günü olduğunu bulan programı yapınız.

        //Console.Write("Haftanın gününü numerik olarak girin: ");
        //short number = Convert.ToInt16(Console.ReadLine());

        //string dayName= dayName = Enum.GetName(typeof(Days), number);

        //if (number < 1 || number > 7)
        //    Console.WriteLine("Lütfen geçerli bir değer giriniz!");
        //else
        //    Console.WriteLine($"Seçilen gün: {dayName}");

        #endregion
        #region 32. Fiyat ve KDV oranı ayrı ayrı girilen 5 malın toplam fiyatını hesaplayınız.

        //List<double> feesOfItems = new List<double>();

        //double tax = 0.18;
        //double sum = 0;

        //for (int i = 0; i < 5; i++)
        //{
        //    Console.Write($"{i + 1}. malın fiyatını giriniz:");
        //    double fee = Convert.ToDouble(Console.ReadLine());
        //    sum += fee * tax;
        //}

        //Console.WriteLine($"5 malın KDV dahil toplam fiyatı: {sum}");

        #endregion
        #region 33. Klavyeden dakika olarak girilen 5 şarkının toplam süresini saat olarak hesaplayan programı yapınız.

        //double totalTime = 0;

        //for (int i = 0; i < 5; i++)
        //{
        //    Console.Write($"{i+1}. şarkının süresini dakika cinsinden girin: ");
        //    double time = Convert.ToDouble(Console.ReadLine());

        //    totalTime += time / 60;
        //}

        //Console.WriteLine($"\nŞarkıların saat cinsinden toplam süresi: {totalTime:F2}");

        #endregion
        #region 34. Girilen işlem türüne (* / – +) göre iki sayıyı işleme alıp sonucunu ekrana yazan programı yapınız.

        //Console.Write("Birinci sayıyı girin: ");
        //double number1 = Convert.ToDouble(Console.ReadLine());

        //Console.Write("İkinci sayıyı girin: ");
        //double number2 = Convert.ToDouble(Console.ReadLine());

        //Console.Write("Yapmak istediğiniz işlemi seçiniz (+ - * /): ");
        //char operation = Console.ReadKey().KeyChar;
        //Console.WriteLine();

        //switch (operation)
        //{
        //    case '+': Console.WriteLine($"{number1} + {number2} = {number1 + number2}"); break;
        //    case '-': Console.WriteLine($"{number1} - {number2} = {number1 - number2}"); break;
        //    case '*': Console.WriteLine($"{number1} * {number2} = {number1 * number2}"); break;
        //    case '/': Console.WriteLine($"{number1} / {number2} = {number1 / number2}"); break;
        //    default: Console.WriteLine("Geçersiz bir değer girdiniz!"); break;
        //}

        #endregion
        #region 35. Klavyeden bir sayı girilen sayıyı 10 farklı sayıya çarparak sonuçları ekrana yazan programı yapınız.

        //Random random = new Random();

        //Console.Write("Bir sayı girin: ");
        //double number = Convert.ToDouble(Console.ReadLine());

        //for (int i = 0; i < 10; i++)
        //{
        //    double randomNumber = random.Next(1, 100);
        //    Console.WriteLine($"{number} X {randomNumber} = {number*randomNumber}");
        //}

        #endregion
        #region 36. Sayısal olarak girilen ay bilgisi ocak şubat mart diye ekrana yazan programı yapınız.

        //Console.Write("Yılın bir ayının numerik olarak giriniz: ");
        //short number = Convert.ToInt16(Console.ReadLine());

        //string monthOfYear = Enum.GetName(typeof(Months), number);

        //Console.WriteLine($"Seçilen ay: {monthOfYear}");

        #endregion
        #region 37. Haftanın günü kelime olarak girilecek sayı olarak çıkaracak programı yapınız.

        //Dictionary<string, short> days = new Dictionary<string, short>()
        //{
        //    {"pazartesi",1},
        //    {"salı",2},
        //    {"çarşamba",3},
        //    {"perşembe",4},
        //    {"cuma",5},
        //    {"cumartesi",6},
        //    {"pazar",7},
        //};

        //Console.Write("Haftanın bir gününü girin: ");
        //string day = Console.ReadLine().Trim().ToLower();

        //Console.WriteLine($"Seçilen gün: {days[day]}");


        #endregion
        #region 38. Klavyede isim girilecektir. Girilen isim ne olursa olsun kaldı yazacak fakat kendi ismimiz yazıldığında geçti yazacak programı yapınız.

        //while (true)
        //{
        //    Console.Write("İsim girin: ");
        //    string name = Console.ReadLine().Trim().ToLower();

        //    if (name != "kaaner4mir")
        //        Console.WriteLine("Yanlış isim girdiniz. Tekrar deneyiniz!");
        //    else
        //    {
        //        Console.WriteLine("Tebrikler"); break;
        //    }
        //}

        #endregion
        #region 39. 1′den 20′ye kadar olan sayıların karesini ekrana yazdıran programı yapınız.

        //for (int i = 1; i <= 20; i++)
        //{
        //    Console.WriteLine($"{i} sayısının karesi: {Math.Pow(i, 2)}");
        //}

        #endregion
        #region 40. Klavyeden girilen sayının 2′ye bölümünü bulan programı yapınız. (Not: Bölme / operatörünü kullanmadan yapılacak- Acaba nasıl?)

        //Console.Write("Bölünen sayıyı girin: ");
        //int dividend = Convert.ToInt32(Console.ReadLine());
        //Console.Write("Bölen sayıyı girin: ");
        //int divisor = Convert.ToInt32(Console.ReadLine());

        //if (divisor == 0)
        //{
        //    Console.WriteLine("Sıfıra bölme hatası!");
        //    return;
        //}

        //int quotient = 0;
        //int remainder = dividend;
        //while (remainder >= divisor)
        //{
        //    remainder -= divisor; quotient++;
        //}

        //Console.WriteLine($"{dividend} ÷ {divisor} = {quotient}, kalan = {remainder}");

        #endregion



    }
}

enum Days
{
    Pazartesi = 1,
    Salı,
    Çarşamba,
    Perşembe,
    Cuma,
    Cumartesi,
    Pazar
}

enum Months
{
    Ocak = 1,
    Şubat,
    Mart,
    Nisan,
    Mayıs,
    Haziran,
    Temmuz,
    Ağustos,
    Eylül,
    Ekim,
    Kasım,
    Aralık
}