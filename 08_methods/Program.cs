using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _08_methods
{
    class Program
    {
        static void Main(string[] args)
        {
            #region  Void Metodlar
            //Void gerige değer döndürmeyen metodlardır

            //void ogrGoster()
            //{
            //    Console.WriteLine("canan");
            //    Console.WriteLine("cem");
            //}
            //ogrGoster();

            //void Toplama()
            //{
            //    int x = 5;
            //    int y = 3;
            //    int sum = x + y;
            //    Console.WriteLine(sum);
            //}
            //Toplama();

            #endregion

            #region Parametreli Void Metodlar
            //void Sum(int x,int y)
            //{
            //    Console.WriteLine(x + y);
            //}
            //Sum(2, 5);

            //void OgrGoster(string name,string surname)
            //{
            //    Console.WriteLine($"öğrenci adı : {name} öğrenci soyadı : {surname}");
            //}
            //OgrGoster("ahmet", "haydar");
            //OgrGoster("mehmet", "canan");
            #endregion

             #region Geriye Değer Dönen Metodlar
            //string CustomerName()
            //{
            //    string name = "hasanlar";
            //    return name;
            //}
            //string customerName = CustomerName();
            //Console.WriteLine(customerName);

            //int Sum(int x,int y)
            //{
            //    int sum = x + y;
            //    return sum;
            //}
            //int toplam = Sum(5, 6);
            //Console.WriteLine(toplam);

            #endregion
            Console.Read();
        }
    }
}
