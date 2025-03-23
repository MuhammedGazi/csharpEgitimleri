using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _06_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Temel Dizi Örnekleri
            //değişken türü [] dizi adı=new değişkentürü[eleman sayısı]

            //string[] names = new string[4];
            //names[0] = "ahmet";
            //names[1] = "hasan";
            //names[2] = "mustafa";
            //Console.WriteLine(names[2]);

            //int[] ages = new int[4];
            //ages[2] = 343;
            //Console.WriteLine(ages[3]); //eğer değer vermezsen default olarak 0 veriyor

            //string[] citys = { "istanbul", "ankara", "adıyaman" }; //boyutu belli olmayan dizi
            //Console.WriteLine(citys[2]);

            #endregion

            #region Dizideki Tüm Elemanları Gösterme
            //int[] points = { 34, 34, 45, 56, 67, 768, 79, 89, 90, 5 };
            //for (int i=0;i<points.Length;i++)
            //{
            //    if (points[i]<50)
            //    {
            //        Console.WriteLine($"{points[i]} sayısı 50 den küçük");
            //    }
            //}

            //int[] ages = { 23, 23, 43, 65, 8, 89, 34, 465, 68, 89 };
            //int bigAge=ages[1];
            //for (int i=0;i<ages.Length;i++)
            //{
            //    if (ages[i]>=bigAge)
            //    {
            //        bigAge = ages[i];
            //    }
            //}
            //Console.WriteLine(bigAge);
            #endregion

            #region Dizi Metodları
            //string[] names = { "hasan", "can", "burak" };
            //Console.WriteLine(names.Length);

            //int[] ages = { 34, 56, 23, 345, 56, 2, 34, 7, 8 };
            //Array.Sort(ages);
            //for(int i=0;i<ages.Length;i++)
            //{
            //    Console.WriteLine(ages[i]);
            //}

            //int[] points = { 34, 45, 56 };
            //Array.Reverse(points);
            //for(int i = 0; i < points.Length; i++)
            //{
            //    Console.WriteLine(points[i]);
            //}

            //string[] color = { "blue", "red", "black" };
            //int index = Array.IndexOf(color, "red");  //eğer dizide değer yoksa -1 dönüyor bu karar yapılarında kullanılabilir
            //Console.WriteLine(index);

            //int[] numbers = { 12, 34, 65, 78, 34, 45 };
            //Console.WriteLine("enbüyük sayı: " + numbers.Max() + " enküçük sayı: " + numbers.Min());

            #endregion

            #region Kullanıcıdan Değer Alma
            //int[] score = new int[4];
            //for (int i=0;i<score.Length;i++)
            //{
            //    Console.Write($"{i+1}. skoru giriniz: ");
            //    score[i] =int.Parse(Console.ReadLine());
            //}

            //for (int i = 0; i < score.Length; i++)
            //{
            //    Console.WriteLine(score[i]);
            //}

            #endregion
            Console.Read();
        }
    }
}
