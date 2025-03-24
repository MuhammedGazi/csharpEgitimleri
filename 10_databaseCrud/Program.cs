using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_databaseCrud
{
    class Program
    {
        static void Main(string[] args)
        {
            //crud-->create,read,update,delete
            #region Kategori Ekleme İşlemi
            //Console.WriteLine("**** menü işlem paneli****");
            //Console.WriteLine();

            //Console.Write("eklemek istediğiniz kategori ismini yazınız: ");
            //string categoryName=Console.ReadLine();

            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-GLCB4AC;initial catalog=csharpEgitimDB;integrated security=true");
            //connection.Open();

            //SqlCommand command = new SqlCommand("insert into TblCategory (CategoryName) values (@p1)",connection);
            //command.Parameters.AddWithValue("@p1",categoryName);
            //command.ExecuteNonQuery();
            //connection.Close(); 

            //Console.WriteLine("kategori başarıyla eklendi");
            #endregion

            #region Ürün Ekleme İşlemi
            //string productName;
            //decimal productPrice;
            //bool productStatus;

            //Console.WriteLine("**** menü işlem menüsü****");
            //Console.Write("eklemek istediğiniz ürünün adı: ");
            //productName = Console.ReadLine();
            //Console.Write("eklemek istediğiniz ürünün fiyatı: ");
            //productPrice=decimal.Parse(Console.ReadLine());
            //Console.Write("eklemek istediğiniz ürünün durumu: ");
            //productStatus=bool.Parse(Console.ReadLine());

            //SqlConnection conn = new SqlConnection("Data Source=DESKTOP-GLCB4AC;initial catalog=csharpEgitimDB;integrated security=true");
            //conn.Open();
            //SqlCommand cmd = new SqlCommand("insert into TblProduct (ProductName,ProductPrice,ProductStatus) values (@p1,@p2,@p3)",conn);
            //cmd.Parameters.AddWithValue("@p1",productName);
            //cmd.Parameters.AddWithValue("@p2", productPrice);
            //cmd.Parameters.AddWithValue("@p3", productStatus);
            //cmd.ExecuteNonQuery();
            //conn.Close();
            //Console.WriteLine("ürün başarıyla eklendi");
            #endregion

            #region Ürün Listeleme İşlemi
            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-GLCB4AC;initial catalog=csharpEgitimDB;integrated security=true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("SELECT * FROM TblProduct",connection);
            //SqlDataAdapter adapter=new SqlDataAdapter(command);
            //DataTable dataTable=new DataTable();
            //adapter.Fill(dataTable);
            //foreach(DataRow row in dataTable.Rows)
            //{
            //    foreach(var item in row.ItemArray)
            //    {
            //        Console.Write(item.ToString()+" ");
            //    }
            //    Console.WriteLine();
            //}
            //connection.Close();
            #endregion

            #region Ürün Silme İşlemi
            //Console.WriteLine("***ürün silme menüsü***");
            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-GLCB4AC;initial catalog=csharpEgitimDB;integrated security=true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("SELECT * FROM TblProduct",connection);
            //SqlDataAdapter adapter=new SqlDataAdapter(command);
            //DataTable dataTable=new DataTable();
            //adapter.Fill(dataTable);


            //    foreach (DataRow row in dataTable.Rows)
            //    {
            //        foreach (var item in row.ItemArray)
            //        {
            //            Console.Write(item.ToString() + " ");
            //        }
            //        Console.WriteLine();
            //    }

            //connection.Close();
            #endregion

            #region Ürün Silme İşlemi
            //int productId;
            //Console.Write("silmek istediğiniz ürünün id numarası: ");
            //productId = int.Parse(Console.ReadLine());
            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-GLCB4AC;initial catalog=csharpEgitimDB;integrated security=true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("DELETE FROM TblProduct WHERE ProductId=@p1", connection);
            //command.Parameters.AddWithValue("@p1", productId);
            //command.ExecuteNonQuery();
            //connection.Close();
            #endregion

            #region Ürün Güncelleme İşlemi
            //Console.Write("güncellenecek ürünün ıd: ");
            //int productId = int.Parse(Console.ReadLine());
            //Console.Write("güncellenecek ürünün adı: ");
            //string productName = Console.ReadLine();
            //Console.Write("güncellenecek ürünün fiyatı: ");
            //decimal productPrice = decimal.Parse(Console.ReadLine());
            //Console.Write("güncellenecek ürünün durumu: ");
            //bool productStatus = bool.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-GLCB4AC;initial catalog=csharpEgitimDB;integrated security=true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("update TblProduct set ProductName=@p1,ProductPrice=@p2,ProductStatus=@p3 where ProductId=@p4", connection);
            //command.Parameters.AddWithValue("@p1", productName);
            //command.Parameters.AddWithValue("@p2", productPrice);
            //command.Parameters.AddWithValue("@p3", productStatus);
            //command.Parameters.AddWithValue("@p4", productId);
            //command.ExecuteNonQuery();
            //connection.Close();

            #endregion
            Console.Read();
        }
    }
}
