using System;

class Program
{
    static void Main()
    {
        #region 71. Klavyeden girilen bir sayı için pozitif mi negatif mi olduğunu ekrana mesaj olarak yazan programı yapınız.

        //Console.Write("Bir sayı girin: ");
        //int number = Convert.ToInt32(Console.ReadLine());

        //if (number == 0)
        //    Console.WriteLine("Girilen sayı sıfırdır.");
        //else if (number < 0)
        //    Console.WriteLine("Girilen sayı negatiftir.");
        //else
        //    Console.WriteLine("Girilen sayı pozitiftir.");

        #endregion
        #region 72. Kullanıcın yaşı klavyeden girilerek reşit olup olmadığını mesaj olarak ekrana yazan programı yapınız.

        //Console.Write("Yaşınızı girin: ");
        //int age = Convert.ToInt32(Console.ReadLine());

        //if (age < 18)
        //    Console.WriteLine("Yasal ergin değilsiniz!");
        //else
        //    Console.WriteLine("Yasal erginsiniz.");

        #endregion
        #region 73. Klavyeden kullanıcının sevdiği sanatçının adı ve kullanıcının yaşı girilerek, ekrana “En iyisi” şeklinde mesaj vererek, kullanıcının 2020 yılında kaç yaşında olduğunu bulup, ekrana yazan programı yapınız.

        //Console.Write("Sevdiğiniz sanatçının adını giriniz: "); 
        //string sanatci = Console.ReadLine();
        //Console.Write("Yaşınızı giriniz: ");
        //int yas = int.Parse(Console.ReadLine());
        //Console.WriteLine("En iyisi");
        //int simdikiYil = DateTime.Now.Year;
        //int fark = simdikiYil - 2020; int yas2020 = yas - fark;
        //Console.WriteLine($"{sanatci} hayranı olarak 2020 yılında yaşınız: {yas2020}");

        #endregion
        #region 74. Klavyeden kullanıcının adı ve yaşı girilerek, ekrana “İyi ki doğdun” şeklinde mesaj vererek, kaç yıl sonra 30 yaşında olacağını ya da “30 yaşını geçmişsiniz” şeklinde mesaj olarak ekrana yazan programı yapınız.

        //Console.Write("Adınızı girin: ");
        //string name = Console.ReadLine();
        //Console.Write("Yaşınızı girin: ");
        //int age = Convert.ToInt32(Console.ReadLine());

        //Console.WriteLine($"İyi ki doğdun {name}");
        //if (age < 30)
        //    Console.WriteLine($"{30 - age} yıl sonra 30 yaşında olacaksınız!");
        //else
        //    Console.WriteLine("30 yaşını geçmişssiniz!");

        #endregion
        #region 75. Klavyeden girilen bir sayının mutlak değerini ekrana yazan programı yapınız.

        //Console.Write("Bir sayı girin: ");
        //int number = Convert.ToInt32(Console.ReadLine());

        //number = Math.Abs(number);

        //Console.WriteLine($"|{number}| = {number}");

        #endregion
        #region 76. 1-1-2-3-5-8-13-21-34-55 serisi matematikte fibonacci sayıları dediğimiz sayılardır. Bu sayılar arasındaki ilişkiyi anlayarak, bu serinin ilk 10 terimini ekrana yazan programı yapınız.

        //int firstNumber = 1;
        //int secondNumber = 1;

        //Console.WriteLine("Fibonacci Serisinin İlk 100 Terimi:");

        //Console.Write(firstNumber + " ");
        //Console.Write(secondNumber + " ");

        //for (int i = 0; i <= 10; i++)
        //{
        //    int nextNumber = firstNumber + secondNumber;
        //    Console.Write(nextNumber + " ");
        //    firstNumber = secondNumber;
        //    secondNumber = nextNumber;
        //}

        #endregion
        #region 77. Klavyeden girilen bir sayının tek ya da çift sayı olduğunu ekrana yazan programı yapınız.

        //Console.Write("Bir sayı girin: ");
        //int number = Convert.ToInt32(Console.ReadLine());

        //if (number % 2 == 0)
        //    Console.WriteLine($"{number} sayıyı çifttir.");
        //else
        //    Console.WriteLine($"{number} sayıyı tektir.");

        #endregion
        #region 78. Klavyeden girilen bir sayının asal olup olmadıgını bulup, ekrana mesaj olarak yazan programı yapınız.

        //Console.Write("Asal sayı kontrolü yapmak istediğiniz sayıyı girin: ");
        //int number = Convert.ToInt32(Console.ReadLine());

        //bool isPrime = true;

        //if (number < 2)
        //    isPrime = false;
        //else
        //{
        //    for (int i = 2; i * i < number; i++)
        //    {
        //        if (number % i == 0)
        //            isPrime = false;
        //        break;
        //    }
        //}

        //if (isPrime)
        //    Console.WriteLine($"{number} sayıyı asal sayıdır");
        //else
        //    Console.WriteLine($"{number} sayıyı asal sayı değildir.");

        #endregion
        #region 79. Klavyeden 0 girilene kadar girilmiş olan sayıların toplamını ekrana yazan programı yapınız.

        //int total = 0;

        //while (true)
        //{
        //    Console.Write("Bir sayı girin: ");
        //    int number = Convert.ToInt32(Console.ReadLine());

        //    if (number != 0)
        //        total += number;
        //    else
        //    {
        //        break;
        //    }
        //}

        //Console.WriteLine($"Girilen sayıların toplamı: {total}");

        #endregion
        #region 80. Klavyeden şifre olarak 123 girilene kadar kaç adet tahmin yapıldığını ekrana yazan programı yapınız.

        //int attempt = 1;

        //while (true)
        //{
        //    Console.Write("Şifrenizi girin: ");
        //    string password = Console.ReadLine();

        //    if (password == "123")
        //        break;
        //    else
        //        attempt++;
        //}

        //Console.WriteLine($"Tebrikler! {attempt}. tahminde doğru bildiniz.");

        #endregion
    }
}
