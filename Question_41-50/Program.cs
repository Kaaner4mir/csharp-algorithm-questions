class Program
{
    static void Main()
    {
        #region 41. Klavyeden girilen isim Ahmet olana kadar ekrana “yanlış isim” mesajı veren, Ahmet girilince “tebrikler,doğru isim” mesajı veren programı yapınız.

        //while (true)
        //{
        //    Console.Write("Doğru ismi girin: ");
        //    string name = Console.ReadLine().Trim().ToLower();

        //    if (name != "ahmet")
        //    {
        //        Console.WriteLine("Yanlış isim girdiniz! Lütfen tekrar deneyin.");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Tebrikler :)");
        //        break;
        //    }
        //}

        #endregion
        #region 42. Klavyeden girilen 5 adet sayının ortalamasını döngü mantığı ile bulup ekrana yazan programı yapınız.

        //double total = 0;

        //for (int i = 0; i < 5; i++)
        //{
        //    Console.Write($"{i + 1}. sayıyı girin: ");
        //    total += Convert.ToDouble(Console.ReadLine());

        //}

        //Console.WriteLine($"Sayıların ortalaması: {total/5}");

        #endregion
        #region 43. Klavyeden girilen 10 sayıdan pozitif ve negatif olanların toplamını ekrana yazan programı yapınız.

        //int positiveNumbers = 0;
        //int negativeNumbers = 0;

        //for (int i = 0; i < 10; i++)
        //{
        //    Console.Write($"{i + 1}. sayıyı giriniz: ");
        //    int number = Convert.ToInt32(Console.ReadLine());

        //    if (number < 0)
        //        negativeNumbers += number;
        //    else
        //        positiveNumbers += number;
        //}

        //Console.WriteLine($"Pozitif sayıların toplamı: {positiveNumbers}\n" +
        //                  $"Negatif sayıların toplamı: {negativeNumbers}");


        #endregion
        #region 44. 1 den 20 ‘ye kadar olan sayıları ekrana alt alta yazan programı yapınız.

        //for (int i = 1; i <=20; i++)
        //{
        //    Console.WriteLine(i);
        //}

        #endregion
        #region 45. 1 ile 30 arasında bulunan çift sayıları ekrana yazan programı yapınız.

        //for (int i = 1; i <=30; i++)
        //{
        //    if (i % 2 == 0)
        //        Console.WriteLine(i);
        //}

        #endregion
        #region 46. 1 ile 40 arasında bulunan 5 in katı olan sayıları ekrana yazan programı yapınız.

        //for (int i = 1; i <= 40; i++)
        //{
        //    if (i % 5 == 0)
        //        Console.WriteLine(i);
        //}

        #endregion
        #region 47. Klavyeden girilen 5 sayıdan kaç tanesinin pozitif kaç tanesinin negatif olduğunu bulan programı yapınız. Not: Sayaç mantığı ve döngü kullanarak yapınız.)

        //int positiveCounter = 0;
        //int negativeCounter = 0;

        //for (int i = 0; i <5; i++)
        //{
        //    Console.Write($"{i+1}. sayıyı girin: ");
        //    int number = Convert.ToInt32(Console.ReadLine());

        //    if (number < 0)
        //        negativeCounter++;
        //    else
        //        positiveCounter++;
        //}

        //Console.WriteLine($"Pozitif sayıların toplam sayısı: {positiveCounter}\n" +
        //                  $"Negatif sayıların toplam sayısı: {negativeCounter}");

        #endregion
        #region 48. Klavyeden girilen bir sayının faktöriyelini hesaplayan programı yapınız.

        //Console.Write("Faktöriyelini öğrenmek istediğiniz sayıyı girin: ");
        //int number = Convert.ToInt32(Console.ReadLine());

        //int total = 1;

        //if (number < 0)
        //    Console.WriteLine("Lütfen geçerli bir sayı giriniz!");
        //else
        //{
        //    for (int i = 2; i <=number; i++)
        //    {
        //        total *= i;
        //    }
        //}

        //Console.WriteLine($"{number}! = {total}");

        #endregion
        #region 49. Klavyeden girilen 5 sayının çarpımını sayaç mantığı ile yani döngü kullanarak hesaplayıp, ekrana programı yapınız.

        //int total = 1;

        //for (int i = 0; i < 5; i++)
        //{
        //    Console.Write($"{i+1}. sayıyı giriniz: ");
        //    int number = Convert.ToInt32(Console.ReadLine());

        //    total *= number;
        //}

        //Console.WriteLine($"Klavyeden girilen 5 sayının çarpımı: {total}");

        #endregion
        #region 50. 1 den 50′ye kadar olan sayıları ekrana alt alta yazan programı yapınız.

        //for (int i = 1; i <=50; i++)
        //{
        //    Console.WriteLine(i);
        //}

        #endregion
    }
}