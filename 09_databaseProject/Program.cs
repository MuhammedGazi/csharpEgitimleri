using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_databaseProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ado .Net

            //Console.WriteLine("c# veritabanı uygulaması");
            //Console.WriteLine();

            //string tableNumber;
            //Console.WriteLine("------------------------------------");
            //Console.WriteLine("1-kategoriler");
            //Console.WriteLine("2-ürünler");
            //Console.WriteLine("3-siparişler");
            //Console.WriteLine("4-çıkış");
            //Console.Write("getimek istediğiniz tablo numarasını giriniz: ");
            //tableNumber = Console.ReadLine();
            //Console.WriteLine("------------------------------------");

            //SqlConnection connection= new SqlConnection("Data Source=DESKTOP-GLCB4AC;initial Catalog=csharpEgitimDB;integrated security=true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("SELECT * FROM TblCategory", connection);
            //SqlDataAdapter adapter = new SqlDataAdapter(command);
            //DataTable dataTable = new DataTable();
            //adapter.Fill(dataTable);

            //connection.Close();

            //foreach(DataRow row in dataTable.Rows)
            //{
            //    foreach(var item in row.ItemArray)
            //    {
            //        Console.Write(item.ToString());
            //    }
            //    Console.WriteLine();
            //}

            //Console.Read();
        }
    }
}
