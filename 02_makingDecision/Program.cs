using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_makingDecision
{
    class Program
    {
        static void Main(string[] args)
        {
            #region If Else yapısı
            //string password;
            //Console.Write("lütfen şifreyi giriniz : ");
            //password = Console.ReadLine();
            //if (password == "abc12")
            //{
            //    Console.WriteLine("şifre doğru");
            //}
            //else
            //{
            //    Console.WriteLine("şifre yanlış");
            //}

            //int point;
            //Console.Write("lütfen notunuzu giriniz: ");
            //point = int.Parse(Console.ReadLine());
            //if (100 >= point && point>= 85)
            //{
            //    Console.WriteLine("notunuz 5");
            //}
            //else if (85>point && point>=70)
            //{
            //    Console.WriteLine("notunuz 4");
            //}
            //else if (point==50 | point==0)
            //{
            //    Console.WriteLine("üzgünüm dostum");
            //}
            //else
            //{
            //    Console.WriteLine("yanlış değer seçimi");
            //}

            #endregion

            #region Mod İşlemleri
            //int number;
            //Console.Write("lütfen çift mi tek mi kontrol için sayı gir: ");
            //number = int.Parse(Console.ReadLine());
            //if (number %2==0)
            //{
            //    Console.WriteLine("sayı tektir");
            //}
            //else if (number %2==1) 
            //{
            //    Console.WriteLine("sayı tektir");
            //}
            //else
            //{
            //    Console.WriteLine("pozitif tam sayı giriniz");
            //}

            #endregion

            #region Switch Case Yapısı
            //char letter;
            //Console.Write("harf giriniz: ");
            //letter=char.Parse(Console.ReadLine());
            //switch (letter)
            //{
            //    case 'a':Console.WriteLine("ilk harf");break;
            //    case 'b':Console.WriteLine("ikinci harf");break;
            //    case 'c':Console.WriteLine("üçüncü harf");break;
            //    default:Console.WriteLine("lütfen doğru bir harf giriniz");break;
            //}
            #endregion

            #region Hesap Makinesi
            //int number1, number2, result;
            //Console.Write("ilk sayıyı giriniz: ");
            //number1=int.Parse(Console.ReadLine());
            //Console.Write("ikinci sayıyı giriniz: ");
            //number2 = int.Parse(Console.ReadLine());
            //char operand;
            //Console.Write("lüttfen yapmak istediğiniz işlemi giriniz: ");
            //operand = char.Parse(Console.ReadLine());
            //switch (operand)
            //{
            //    case '+':
            //        result = number1 + number2;
            //        Console.WriteLine(result);
            //        break;
            //    case '-':
            //        result = number1 - number2;
            //        Console.WriteLine(result);
            //        break;
            //    case '*':
            //        result=number1 * number2;
            //        Console.WriteLine(result);
            //        break;
            //    case '/':
            //        result = number1 / number2;
            //        Console.WriteLine(result);
            //        break;
            //    default:
            //        Console.WriteLine("lütfen doğru işlem giriniz");
            //        break;
            //}

            #endregion

            Console.Read();

        }
    }
}
