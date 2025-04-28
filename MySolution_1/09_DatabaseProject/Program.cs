using System.Data;
using Microsoft.Data.SqlClient;

Console.WriteLine("***** C# Veri Tabanlı Ürün-Kategori Bilgi Sistemi *****");
Console.WriteLine();
Console.WriteLine();
string tableNumber;
Console.WriteLine("--------------------------------------");
Console.WriteLine("1-Kategoriler");
Console.WriteLine("2-Ürünler");
Console.WriteLine("3-Siparişler");
Console.WriteLine("4-Çıkış Yap");
Console.Write("Lütfen getirmek istediğiniz tablo numarasını giriniz: ");
tableNumber = Console.ReadLine();
Console.WriteLine("--------------------------------------");

SqlConnection connection = new SqlConnection("Server=localhost,1433;Database=EgitimKampiDb;User Id=SA;Password=reallyStrongPwd123;TrustServerCertificate=True;");
connection.Open();
SqlCommand command = new SqlCommand("Select * From TblCategory",connection);
SqlDataAdapter adapter = new SqlDataAdapter(command);
DataTable dataTable = new DataTable();
adapter.Fill(dataTable);
connection.Close();
foreach(DataRow row in dataTable.Rows){
    foreach(var item in row.ItemArray){
        Console.Write(item.ToString());
    }
    Console.WriteLine();
}
