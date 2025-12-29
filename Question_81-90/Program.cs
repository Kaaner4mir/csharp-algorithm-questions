class Program
{
    static void Main()
    {
        #region 81. Klavyeden girilen 5 sayıdan sadece pozitif olanların ortalamasını hesaplayıp ekrana yazan programı yapınız.

        //double positiveTotal = 0;
        //int count = 0;

        //for (int i = 0; i < 5; i++)
        //{
        //    Console.Write($"{i + 1}. sayıyı girin: ");
        //    int number = Convert.ToInt32(Console.ReadLine());

        //    if (number >= 0)
        //    {
        //        positiveTotal += number;
        //        count++;
        //    }
        //}

        //double average = positiveTotal / count;

        //Console.WriteLine($"Girilen pozitif sayıların ortalaması: {average}");

        #endregion
        #region 82.Klavyeden girilen 5 adet sayıdan pozitif ve negatif olanların ortalamasını hesaplayıp, ekrana yazan programı yapınız.

        //double total = 0;

        //for (int i = 0; i < 5; i++)
        //{
        //    Console.Write($"{i + 1}. sayıyı girin: ");
        //    int number = Convert.ToInt32(Console.ReadLine());

        //    total += number;
        //}

        //double average = total / 5;

        //Console.WriteLine($"Girilen sayıların ortalaması: {average}");

        #endregion

        #region 83. Bir metinde istediğimiz harfin kaç kez geçtiğini hesaplayan programı yapınız.

        //int count =0;
        //char ch = 'e';

        //Console.Write("Bir metin girin: ");
        //string text = Console.ReadLine();

        //for (int i = 0; i < text.Length; i++)
        //{
        //    if (text[i] == 'e')
        //        count++;
        //}

        //Console.WriteLine($"Girilen metinde istenmeyen karakter sayısı: {count}");

        #endregion

        #region 84. Bilgisayarın rastgele belirlediği bir sayıyı tahmin etmeye çalıştığımız sayı tahmin oyunu programını yazınız.


        //Random rnd = new Random();
        //int trueNumber = rnd.Next(1, 101);
        //short attempt = 0;

        //while (attempt < 10)
        //{
        //    Console.Write("Tuttuğum sayıyı tahmin et: ");
        //    int number = Convert.ToInt32(Console.ReadLine());

        //    if (number == trueNumber)
        //    {
        //        Console.WriteLine($"Tebrikler! Doğru sayı: {trueNumber}");
        //        break;
        //    }
        //    else
        //    {
        //        if (number < trueNumber)
        //        {
        //            Console.WriteLine($"Tuttuğum sayı daha büyük! Kalan deneme hakkı: {9 - attempt}");
        //            attempt++;
        //        }
        //        else
        //        {
        //            Console.WriteLine($"Tuttuğum sayı daha küçük! Kalan deneme hakkı: {9 - attempt}");
        //            attempt++;
        //        }
        //    }
        //}

        //if (attempt == 10)
        //{
        //    Console.WriteLine($"Kaybettiniz! Tuttuğum sayı: {trueNumber}");
        //}


        #endregion

        #region 85. Hesap makinesi olarak çalışabilecek bir program yapınız.

        //Console.Write("Birinci sayıyı girin: ");
        //int number1 = Convert.ToInt32(Console.ReadLine());
        //Console.Write("İkinci sayıyı girin: ");
        //int number2 = Convert.ToInt32(Console.ReadLine());
        //Console.Write("Yapmak istediğiniz işlemi giriniz (+ - * /):");
        //char operation = Convert.ToChar(Console.ReadLine());

        //switch (operation)
        //{
        //    case '+': Console.WriteLine($"{number1} + {number2} = {number1 + number2}"); break;
        //    case '-': Console.WriteLine($"{number1} - {number2} = {number1 - number2}"); break;
        //    case '*': Console.WriteLine($"{number1} * {number2} = {number1 * number2}"); break;
        //    case '/':
        //        if (number1 == 0 && number2 == 0)
        //        {
        //            Console.WriteLine("Tanımsız");
        //        }
        //        else if (number2 == 0)
        //        {
        //            Console.WriteLine("Bölen 0 olamaz");
        //        }
        //        else
        //        {
        //            Console.WriteLine($"{number1} / {number2} = {number1 / number2}");
        //        }
        //        break;
        //}

        #endregion


        #region 86. Girilen metni tersten yazdıran programı yazınız.

        //Console.Write("Bir metin giriniz: ");
        //string text = Console.ReadLine();

        //string reversedText = new string(text.Reverse().ToArray());

        //Console.WriteLine($"Girilen metnin ters hali\n=>{reversedText}");


        #endregion


        #region 87. 2 milyona kadar olan asal sayıların toplamını bulan programı yazınız.

        //int limit = 2000000;
        //bool[] isPrime = new bool[limit];

        //for (int i = 2; i < limit; i++)
        //    isPrime[i] = true;

        //for (int i = 2; i * i < limit; i++)
        //{
        //    if (isPrime[i])
        //    {
        //        for (int j = i * i; j < limit; j += i)
        //            isPrime[j] = false;
        //    }
        //}

        //long total = 0;

        //for (int i = 2; i < limit; i++)
        //{
        //    if (isPrime[i])
        //        total += i;
        //}

        //Console.WriteLine($"Asal sayıların toplamı: {total}");

        #endregion
    }
}