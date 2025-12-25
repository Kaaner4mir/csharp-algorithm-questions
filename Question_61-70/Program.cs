class Program
{
    static void Main()
    {
        #region 61. Klavyeden girilen 10 sayıdan sadece pozitif olanların ortalamasını ekrana yazan programı yapınız.

        //int total = 0;

        //for (int i = 0; i < 10; i++)
        //{
        //    Console.Write($"{i+1}. sayıyı girin: ");
        //    int number = Convert.ToInt32(Console.ReadLine());

        //    if (number > 0)
        //        total += number;
        //}

        //double average = total / 10;

        //Console.WriteLine($"Girilen pozitif sayıların ortalaması: {average}");


        #endregion
        #region 62.Kullanıcı adı “admin”, şifresi “1234″ olan bir program için kullanıcıdan 3 kez giriş yapması istenecektir.(kullanıcı adı ve şifresi girilecek yani) Eğer her iki girişi de doğru yaparsa “Giriş izni var”, 3 kez yanlış giriş yapması sonucunda ise “Giriş izni yok” şeklinde mesaj veren programı yapınız.

        //string username = "admin";
        //string password = "1234";
        //short attempt = 0;

        //while (attempt < 4)
        //{
        //    Console.WriteLine($"Kalan deneme hakkınız: {4 - attempt}");
        //    Console.Write("Kullanıcı adını girin: ");
        //    string inputUsername = Console.ReadLine();

        //    if (inputUsername.ToLower() == "admin")
        //    {
        //        Console.Write("Şifrenizi giriniz: ");
        //        string inputPassword = Console.ReadLine();

        //        if (inputPassword.ToLower() == "1234")
        //        {
        //            break;
        //        }
        //        else
        //        {
        //            Console.WriteLine("Giriş izni yok!");
        //            attempt++;
        //        }
        //    }
        //    else
        //    {
        //        Console.WriteLine("Giriş izni yok!");
        //        attempt++;
        //    }
        //}

        //Console.WriteLine("Giriş izni var");


        #endregion
        #region 63. Klavyeden girilen bir sayının faktöryelini ekrana yazan programı yapınız.

        //Console.Write("Faktöriyelini öğrenmek istediğiniz sayıyı girin: ");
        //int number = Convert.ToInt32(Console.ReadLine());

        //int result = 1;

        //if (number < 0)
        //    Console.WriteLine("Lütfen pozitif bir değer girin!");
        //else
        //{
        //    for (int i = number; i > 0; i--)
        //    {
        //        result *= i;
        //    }

        //    Console.WriteLine($"{number}! = {result}");
        //}

        #endregion
        #region 64. Klavyeden girilen 10 sayıdan negatif ve pozitif olan sayıların toplamını ekrana ayrı ayrı yazan programı yapınız.

        //int positiveTotal = 0;
        //int negativeTotal= 0;

        //for (int i = 0; i < 10; i++)
        //{
        //    Console.Write("Bir sayı girin: ");
        //    int number = Convert.ToInt32(Console.ReadLine());

        //    if (number < 0)
        //        negativeTotal += number;
        //    else
        //        positiveTotal += number;
        //}

        //Console.WriteLine($"Girilen pozitif sayıların toplamı: {positiveTotal}\n" +
        //                  $"Girilen negatif sayıların toplamı: {negativeTotal}");

        #endregion
        #region 65.Klavyeden girilen iki sayının karelerini ekrana yazan programı yapınız.

        //Console.Write("Birinci sayıyı girin: ");
        //int number1 = Convert.ToInt32(Console.ReadLine());

        //Console.Write("İkinci sayıyı girin: ");
        //int number2 = Convert.ToInt32(Console.ReadLine());

        //Console.WriteLine($"{number1}^2 = {Math.Pow(number1,2)}\n" +
        //                  $"{number2}^2 = {Math.Pow(number2,2)}");

        #endregion
        #region 66. Kullanıcın adı klavyeden girilerek “Hoşgeldin<kullancıcı adı>”, altına ise “Programlama öğreniyorum” şeklinde mesaj veren programı yapınız.

        //Console.Write("Kullanıcı adınızı girin: ");
        //string username = Console.ReadLine();

        //Console.WriteLine($"Hoşgeldin {username}\n" +
        //                  $"Programlama öğreniyorum");

        #endregion
        #region 67. Kullanıcının yıl olarak doğum tarihi girilerek, bugünkü yaşını hesaplayıp, ekrana yazan programı yapınız.

        //Console.Write("Doğum yılınızı girin: ");
        //int birthYear = Convert.ToInt32(Console.ReadLine());

        //int age = DateTime.Now.Year - birthYear;

        //Console.WriteLine($"Yaşınız: {age}");

        #endregion
        #region 68. Kullanıcının tuttuğu takım klavyeden okunarak, ekrana “En büyük <tutulan takım>” yazan programı yapınız.

        //Console.Write("Tuttuğunuz takımı girin: ");
        //string teamName = Console.ReadLine();

        //Console.WriteLine($"En büyük {teamName}");

        #endregion
        #region 69. Dikdörtgenin kısa ve uzun kenar uzunluğu klavyeden girilerek, ekrana dikdörtgenin alanını ve çevresini yazan programı yapınız.

        //Console.Write("Dikdörtgenin kısa kenar uzunluğunu girin: ");
        //int shortSide = Convert.ToInt32(Console.ReadLine());

        //Console.Write("Dikdörtgenin uzun kenar uzunluğunu girin: ");
        //int longSide = Convert.ToInt32(Console.ReadLine());

        //int perimeter = 2 * (shortSide + longSide);
        //int area = shortSide * longSide;

        //Console.WriteLine($"Dikdörtgenin çevre uzunluğu: {perimeter}\n" +
        //                  $"Dikdörtgenin alanı: {area}");

        #endregion
        #region 70. Klavyeden girilen 3 sayının ortalamasını hesaplayıp, ekrana yazan programı yapınız.

        //double average = 0;

        //for (int i = 0; i < 3; i++)
        //{
        //    Console.Write($"{i + 1}. sayıyı girin: ");
        //    average += Convert.ToInt32(Console.ReadLine());
        //}

        //average = average / 3;

        //Console.WriteLine($"Girilen üç sayının ortalaması: {average}");

        #endregion



    }
}