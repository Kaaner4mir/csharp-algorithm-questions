using System.Linq.Expressions;

class Program
{
    static void Main()
    {
        #region 11. 1 ile 40 arasında bulunan 5 in katı olan sayıları ekrana yazan programın algoritmasını yazınız.

        //for (int i = 1; i <= 40; i++)
        //{
        //    if (i % 5 == 0)
        //        Console.WriteLine($"Sayı {i} 5 ile kalansız bölünür.");
        //}

        #endregion
        #region 12. Klavyeden girilen 10 sayıdan sadece negatif olanların çarpımını ekrana programı yapınız.

        //int result = 1;

        //for (int i = 0; i < 10; i++)
        //{
        //    Console.Write($"{i + 1}. sayıyı giriniz: ");
        //    int number = Convert.ToInt32(Console.ReadLine());

        //    if (number < 0)
        //        result *= number;
        //}


        //Console.WriteLine($"Negatif sayıların çarpımı: {result}");

        #endregion
        #region 13. Klavyeden girilen 10 sayıdan 5’ten büyük olanların yarısını, 5’e eşit ve küçük olan sayıların 2 katını bulan programı yapınız.

        //for (int i = 0; i < 10; i++)
        //{
        //    Console.Write($"{i + 1}. sayıyı giriniz: ");
        //    double number = Convert.ToDouble(Console.ReadLine());

        //    if (number > 5)
        //        Console.WriteLine($"{number / 2}");
        //    else
        //        Console.WriteLine($"{number*2}");
        //}

        #endregion
        #region 14. Bir komisyoncu sattığı mallardan fiyatı 50 YTL kadar olanlardan %3, daha fazla olanlardan ise %2 komisyon almaktadır. Klavyeden girilen 5 malın komisyon dahil fiyatlarını bulunuz.

        //double total = 0;

        //for (int i = 0; i < 5; i++)
        //{
        //    Console.Write($"{i + 1}. malın fiyatını giriniz: ");
        //    double price = Convert.ToInt32(Console.ReadLine());

        //    if (price < 50)
        //    {
        //        double commission = price * 0.03;
        //        total += price + commission;
        //    }
        //    else
        //    {
        //        double commission = price * 0.02;
        //        total += price + commission;
        //    }
        //}

        //Console.WriteLine($"Komisyon" +
        //    $"Malların komisyonlar dahil fiyatı: {total:F2}");

        #endregion
        #region 15. Klavyeden yarıçapı girilen çemberin alanını ve çevresini hesaplayan programı yapınız

        //Console.Write($"Çemberin yarıçapını giriniz: ");
        //int radius = Convert.ToInt32(Console.ReadLine());

        //double perimeter = 2 * Math.PI * radius;
        //double area = Math.PI * Math.Pow(radius, 2);

        //Console.WriteLine($"Çemberin çevre uzunluğu: {perimeter}\n" +
        //                  $"Çemberin alanı: {area}");

        #endregion
        #region 16. Klavyeden girilecek N sayısı kadar nottan en büyük ve en küçük olanı bulan programı yapınız.

        //List<double> grades = new List<double>();

        //Console.Write("Not sayısını giriniz: ");
        //short number = Convert.ToInt16(Console.ReadLine());

        //for (int i = 0; i < number; i++)
        //{
        //    Console.Write($"{i + 1}. notu giriniz: ");
        //    double grade = Convert.ToDouble(Console.ReadLine());

        //    grades.Add(grade);
        //}

        //double minGrade = grades.Min();
        //double maxGrade = grades.Max();

        //Console.WriteLine($"En yüksek not: {maxGrade}\n" +
        //                  $"En düşük not: {minGrade}");


        #endregion
        #region 17. İç içe döngüler ile saat: dakika: saniye olarak saat yapınız. Saat 0 ile 23, dakika 0 ile 59 ve saniye de 0 ile 59 arasında ilerleyecektir.

        // saat:dakika:saniye
        //for (int i = 0; i < 24; i++)
        //{
        //    for (int j = 0; j < 60; j++)
        //    {
        //        for (int k = 0; k < 60; k++)
        //        {
        //            Console.WriteLine($"Saat: {i}:{j}:{k}");
        //        }
        //    }
        //}

        #endregion
        #region 18. Klavyeden girilen 100’lük sistemdeki 5 notu; 0, 1, 2, 3, 4 ve 5 olacak şekilde ekrana yazan programı yapınız.

        //Console.Write("Notunuzu giriniz: ");
        //double grade = Convert.ToDouble(Console.ReadLine());

        //if (grade < 0 && grade > 100)
        //    Console.WriteLine("Geçerli bir not giriniz: ");
        //else
        //{
        //    grade = Math.Round(grade / 20);

        //    Console.WriteLine($"Notunuz: {grade}");
        //}

        #endregion
        #region 19. Sayısal olarak girilen bir ay bilgisini ekrana “Ocak, Şubat, Mart veya diğer aylardan biri…” şeklinde yazan programı yapınız.

        //Console.Write("Ay değerini sayısal olarak giriniz: ");
        //short number = Convert.ToInt16(Console.ReadLine());

        //string monthName = Enum.GetName(typeof(Months), number);

        //Console.WriteLine($"Seçilen ay: {monthName}");

        #endregion
        #region 20. İki vize ve bir final sınavına girilen üniversitede harf notuna vizeler %30 final ise %40 etkilidir. Bu üniversitenin harf ortalamasını hesaplayan kodu yazınız.

        //Console.Write("1. vize sınav sonucunu giriniz: ");
        //double midterm = Convert.ToDouble(Console.ReadLine());

        //Console.Write("2. vize sınav sonucunun giriniz: ");
        //double secondMidterm = Convert.ToDouble(Console.ReadLine());

        //Console.Write("Final sınav sonucunu giriniz: ");
        //double final = Convert.ToDouble(Console.ReadLine());

        //double result = (midterm * 0.3) + (secondMidterm * 0.3) + (final * 0.4);

        //if (result > 100 || result < 0)
        //    Console.WriteLine("Geçersiz bir sınav sonucu girdiniz: ");
        //else
        //{
        //    if (result < 50)
        //        Console.WriteLine("FF");
        //    else if(result<60)
        //        Console.WriteLine("EE");
        //    else if (result<70)
        //        Console.WriteLine("DD");
        //    else if(result<80)
        //        Console.WriteLine("CC");
        //    else if(result<90)
        //        Console.WriteLine("BB");
        //    else
        //        Console.WriteLine("AA");
        //}

        //Console.WriteLine($"Sınav sonucunuz: {result}");

        #endregion
    }
}
public enum Months
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