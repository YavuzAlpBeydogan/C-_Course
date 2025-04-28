using System.Data;
using Microsoft.Data.SqlClient;

Console.WriteLine("***** Menü Sipariş İşlem Paneli *****");
Console.WriteLine();

#region Kategori Ekleme İşlemi
// Console.WriteLine("----------------------------------");
// Console.Write("Eklemek İstediğiniz Kategori Adı: ");
// string categoryName=Console.ReadLine();
// SqlConnection connection = new SqlConnection ("Server=localhost,1433;Database=EgitimKampiDb;User Id=SA;Password=reallyStrongPwd123;TrustServerCertificate=True;");
// connection.Open();
// SqlCommand command = new SqlCommand ("Insert into TblCategory (CategoryName) values (@p1)", connection);
// command.Parameters.AddWithValue("@p1",categoryName);
// command.ExecuteNonQuery();
// connection.Close();
// Console.Write("Kategori Başarıyla Eklendi");
#endregion

#region Ürün Ekleme İşlemi
// string productName;
// decimal productPrice;
// bool productStatus;

// Console.Write("Ürün Adı: ");
// productName = Console.ReadLine();

// Console.Write("Ürün Fiyatı:");
// productPrice = decimal.Parse(Console.ReadLine());

// SqlConnection connection = new SqlConnection("Server=localhost,1433;Database=EgitimKampiDb;User Id=SA;Password=reallyStrongPwd123;TrustServerCertificate=True;");
// connection.Open();
// SqlCommand command = new SqlCommand("insert into TblProduct (ProductName,ProductPrice,ProductStatus) values (@p1,@p2,@p3)",connection);
// command.Parameters.AddWithValue("@p1",productName);
// command.Parameters.AddWithValue("@p2",productPrice);
// command.Parameters.AddWithValue("@p3",true);
// command.ExecuteNonQuery();
// connection.Close();
// Console.WriteLine("Ürün Başarıyla Eklendi");
#endregion

#region Ürün Listeleme İşlemi
// SqlConnection connection = new SqlConnection ("Server=localhost,1433;Database=EgitimKampiDb;User Id=SA;Password=reallyStrongPwd123;TrustServerCertificate=True;");
// connection.Open();
// SqlCommand command = new SqlCommand("select * from TblProduct",connection);
// SqlDataAdapter adapter = new SqlDataAdapter(command);
// DataTable dataTable = new DataTable();
// adapter.Fill(dataTable);
// foreach(DataRow row in dataTable.Rows){
//     foreach(var item in row.ItemArray){
//         Console.Write(item.ToString()+" ");
//     }
//     Console.WriteLine();
// }
#endregion

#region Ürün Silme İşlemi
// Console.Write("Silinecek Ürün Id: ");
// int productId=int.Parse(Console.ReadLine());
// SqlConnection connection = new SqlConnection ("Server=localhost,1433;Database=EgitimKampiDb;User Id=SA;Password=reallyStrongPwd123;TrustServerCertificate=True;");
// connection.Open();
// SqlCommand command = new SqlCommand ("Delete from TblProduct Where ProductId=@productId",connection);
// command.Parameters.AddWithValue("@productId",productId);
// command.ExecuteNonQuery();
// connection.Close();
// Console.WriteLine("Ürün Başarıyla Silindi.");
#endregion

#region Ürün Güncelleme İşlemi
// Console.Write("Güncellenecek Ürün Id: ");
// int productId =int.Parse(Console.ReadLine());
// Console.Write("Güncellenecek Ürün Adı: ");
// string productName = Console.ReadLine();
// Console.Write("Güncellenecek Ürün Fiyatı: ");
// decimal productPrice = decimal.Parse(Console.ReadLine());
// SqlConnection connection = new SqlConnection ("Server=localhost,1433;Database=EgitimKampiDb;User Id=SA;Password=reallyStrongPwd123;TrustServerCertificate=True;");
// connection.Open();
// SqlCommand command = new SqlCommand ("Update TblProduct Set ProductName=@productName, ProductPrice=@productPrice where ProductId=@productId",connection);
// command.Parameters.AddWithValue("ProductName",productName);
// command.Parameters.AddWithValue("ProductPrice",productPrice);
// command.Parameters.AddWithValue("ProductId",productId);
// command.ExecuteNonQuery();
// connection.Close();
// Console.WriteLine("Güncelleme Başarılı");
#endregion



