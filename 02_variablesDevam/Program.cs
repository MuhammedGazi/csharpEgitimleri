using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_variablesDevam
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Double Değişkenler
            //double değişkenAdı;
            //double number = 4.78;
            //Console.WriteLine(number);
            //double applePrice;
            //double tomatoPrice;
            //double bananaPrice;
            //applePrice = 4.89;
            //bananaPrice = 3.56;
            //tomatoPrice = 223.34;
            //double totalPrice = applePrice + bananaPrice + tomatoPrice;
            //Console.WriteLine(totalPrice);

            //double appleUpdate, tomatoUpdate, bananaUpdate;
            //appleUpdate = 23.23;
            //tomatoUpdate = 343.0;
            //bananaUpdate = 45;
            //Console.WriteLine(appleUpdate+" "+tomatoUpdate+" "+bananaUpdate);

            #endregion

            #region Char Değişkenler
            //char değişkenAdı;
            //değer atarken tek tırnak kullanılır ' '
            //char sembol;
            //sembol = 'a';
            //Console.WriteLine(sembol);
            #endregion

            #region Klavyeden Veri Girişi String Girişi
            //string personName, personSurname, personAge;
            //Console.Write("kullanıcı adı: ");
            //personName=Console.ReadLine();
            //Console.Write("kullanıcı soyadı: ");
            //personSurname=Console.ReadLine();
            //Console.Write("kullanıcı yaşı: ");
            //personAge=Console.ReadLine();
            //Console.WriteLine("kullanıcı adı: " + personName + " kullanıcı soyadı: " + personSurname + " kullanıcı yaşı: " + personAge);
            #endregion

            #region Klavyeden Tam Sayı Girişi Ve Dönüşümler
            // normalde Console.Read() okunan değeristring olarak alır sen onu int.Parse() ile tam sayıya çevirmen gerekiyor
            //int age, height, number;
            //Console.Write("lütfen yaşı gir : ");
            //age=int.Parse(Console.ReadLine());
            //Console.Write("lütfen boyu gir : ");
            //height = int.Parse(Console.ReadLine());
            //Console.Write("lütfen sayıyı giriniz : ");
            //number=int.Parse(Console.ReadLine());
            //Console.WriteLine("yaşı "+age+" boyu "+height+" sayısı "+number);
            #endregion

            #region Klavyeden Ondalıklı Sayı Girişi Ve Dönüşümü
            //double exam1, exam2, exam3, result;
            //Console.Write("lütfen 1. sınav notunu gir: ");
            //exam1=double.Parse(Console.ReadLine());
            //Console.Write("lütfen 2. sınav notunu gir: ");
            //exam2 = double.Parse(Console.ReadLine());
            //Console.Write("lütfen 3. sınav notunu gir: ");
            //exam3 = double.Parse(Console.ReadLine());
            //result = (exam1 + exam2 + exam3) / 3;
            //Console.Write($"birinci sınav notu: {exam1}\nikinci sınav notu: {exam2}\nüçüncü sınav notu: {exam3}\nortlama: {result}");

            #endregion

            #region Klavyeden Karakter Girişleri
            //yalnızca tek bir karakte girilmesini istediğimde kullanılır çoklu karakter girildiğinde hata verir
            //char gender;
            //Console.Write("lütfen cinbsiyet seçiniz: ");
            //gender=char.Parse(Console.ReadLine());
            //Console.WriteLine($"seçtiğiniz cinsiyet {gender}");
            #endregion
            

            Console.Read();
        }
    }
}
