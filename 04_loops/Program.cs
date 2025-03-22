using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace _04_loops
{
    class Program
    {
        static void Main(string[] args)
        {
            #region For Döngüsü
            //for(int i=0;i<10;i++)
            //{
            //    Console.WriteLine(i);
            //} 

            //int x;
            //for (x = 3; x < 17; x += 2)
            //{
            //    Console.WriteLine(x);
            //} 

            //int stopPoint;
            //Console.Write("lütfen kaça kadar gideyim söyle: ");
            //stopPoint = int.Parse(Console.ReadLine());
            //for (int i = 1; i < stopPoint+1; i++)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion

            #region For İle Karar Yapıları
            //for (int i = 0; i < 15; i++)
            //{
            //    if (i%2==0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //for(int i=0;i<50;i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine($"{i} sayısı çiftir");
            //    }
            //    else if (i % 2 == 1)
            //    {
            //        Console.WriteLine($"{i} sayısı tektir");
            //    }
            //}

            //int bakteriX=1;
            //for (int i=1;i<24;i++)
            //{
            //    bakteriX *= 2;
            //    Console.WriteLine($"{i}. saatin sonunda baktesi sayısı: {bakteriX}");
            //}
            #endregion

            #region While Döngüsü
            //int x = 0;
            //while (x < 10)
            //{
            //    Console.WriteLine(x);
            //    x++;
            //}

            //int y = 0;
            //while(y<16)
            //{
            //    if (y % 2 == 0)
            //    {
            //        Console.WriteLine(y);
            //    }
            //    y++;
            //}

            #endregion

            #region Uygulama
            //string sayi;
            //Console.Write("lütfen basamakları toplanması istenen sayıyı giriniz: ");
            //sayi =Console.ReadLine();
            //int basamakToplamı=0;
            //for(int i=0;i<sayi.Length;i++)
            //{
            //    basamakToplamı += int.Parse(sayi[i].ToString()); //çünkü int.Parse bir string bekliyo char değil
            //}
            //Console.WriteLine(basamakToplamı);
            #endregion

            #region Yıldız uygulaması
            //for (int i = 0; i < 5; i++)
            //{
            //    for(int j=0;j<i+1;j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //int yildiz = 1;
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine(new string('*',yildiz)); //yukardakinin başka bir yöntemi
            //    yildiz++;
            //}
            #endregion
            Console.Read();
        }
    }
}
