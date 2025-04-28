using System.Drawing;

namespace _03_MakingDecision;

class Program
{
static void Main(string[] args)
{
    #region If Else 1.Uygulama
    //string password;
    //Console.Write("Şifrenizi Girin: ");
    //password = Console.ReadLine();
    //if (password=="abcd"){
    //Console.WriteLine("Şifre Doğru!");
    //}
    //else{
    // Console.WriteLine("Şifre Yanlış!");
    //}
#endregion
    #region If Else 2.Uygulama 
    //2.Uygulama
    //string capital, country;
    //Console.Write("Şehir Giriniz: ");
    //capital=Console.ReadLine();
    //Console.Write("Ülkeyi Giriniz: ");
    //country=Console.ReadLine();
    //if (capital=="ankara" & country=="türkiye"){
    //Console.WriteLine("Girilen Bilgiler Doğru");
    // }
    // else{
    // Console.WriteLine("Girilen Bilgiler Yanlış");
    //  }
    #endregion
    #region If Else 3.Uygulama 
    //3.Uygulama
    //  int sayi;
    //  Console.Write("Sayı Girin: ");
    //  sayi=int.Parse(Console.ReadLine());
    //  if (sayi==777){
    // Console.WriteLine("Girilen sayı doğru!");
    //  }else{
    // Console.WriteLine("Girilen sayı yanlış!");
    // }
    #endregion
    #region If Else 4.Uygulama 
    // int exam1, exam2, exam3, result;
    // Console.Write("1.Sınav Notunu Girin: ");
    // exam1=int.Parse(Console.ReadLine());
    // Console.Write("2.Sınav Notunu Girin: ");
    // exam2=int.Parse(Console.ReadLine());
    // Console.Write("3.Sınav Notunu Girin: ");
    // exam3=int.Parse(Console.ReadLine());
    // result=(exam1+exam2+exam3)/3;
    // if (0<result & 50>=result){
    // Console.WriteLine("Çok Kötü");
    // }
    // else if (50<result & 70>=result){
    // Console.WriteLine("Orta");
    // }
    // else{
    // Console.WriteLine("İyi");
    // }
    #endregion
    #region If Else 5.Uygulama
    // string city;
    // Console.Write("Şehir Girin:");
    // city=Console.ReadLine();
    // if (city=="mersin" | city=="ankara" | city=="muş" | city=="trabzon"){
    //     Console.WriteLine("Mevcut şehir var!");
    // }else{
    //     Console.WriteLine("Mevcut şehir yok!");
    // }
    #endregion
    #region If Else 6.Uygulama
    // Console.Write("Kullanıcı adını giriniz: ");
    // string username = Console.ReadLine();
    // if (username!="admin"){
    //     Console.WriteLine("Kullanıcı kabul edilemez!");
    // }else{
    //     Console.WriteLine("Hoş Geldiniz");
    // }
    #endregion
    #region Mod 1.Uygulama
    // Console.Write("1.Sayıyı Giriniz: ");
    // int number1 = int.Parse(Console.ReadLine());
    // Console.Write("2.Sayıyı Giriniz: ");
    // int number2= int.Parse(Console.ReadLine());
    // int result = number1%number2;
    // Console.WriteLine("1.sayının 2.sayıya bölümünden kalan: "+ result);
    #endregion
    #region Tek mi Çift mi?
    // Console.Write("Sayı Giriniz: ");
    // int number = int.Parse(Console.ReadLine());
    // if (number%2==0){
    //     Console.WriteLine("Girilen sayı: "+number+", bu sayı çifttir.");
    // }else
    // {
    //     Console.WriteLine("Girilen sayı: "+number+", bu sayı tektir.");
    // }
    #endregion
    #region Takım Getirme  
    //Console.Write("Tuttuğunuz takımın başharfi:");
    // char harf = char.Parse(Console.ReadLine());
    // if (harf=='g' | harf=='G'){
    //     Console.WriteLine("Galatasaray");
    // }
    // else if(harf=='f' | harf=='F'){
    //     Console.WriteLine("Fenerbahçe");
    // }
    // else if (harf=='b' | harf=='B'){
    //     Console.WriteLine("Beşiktaş");
    // }
    // else{
    //     Console.WriteLine("Kayıtlı takım yok!");
    // }
    #endregion
    #region Mini Restoran
    // Console.WriteLine("***** Restoran Menüsü *****");
    // Console.WriteLine();
    // Console.WriteLine("------------------------------");
    // Console.WriteLine("1-Ana Yemekler");
    // Console.WriteLine("2-Çorbalar");
    // Console.WriteLine("3-Pizzalar");
    // Console.WriteLine("4-İçecekler");
    // Console.WriteLine("5-Tatlılar");
    // Console.WriteLine("------------------------------");
    // Console.Write("Detayını görmek istediğiniz kategori: "); 
    // int menuItem=int.Parse(Console.ReadLine());
    // if (menuItem==1){
    //     Console.WriteLine("---------- Ana Yemekler ----------");
    //     Console.WriteLine();
    //     Console.WriteLine("1-Kori Soslu Tavuk");
    //     Console.WriteLine("2-Kızartma Tabağı");
    //     Console.WriteLine("3-Fasülye Pilav");
    //     Console.WriteLine("4-Fırında Somon");
    //     Console.WriteLine("5-Patlıcan Musakka");
    //     Console.WriteLine();
    // }else if (menuItem==2){
    //     Console.WriteLine("---------- Çorbalar ----------");
    //     Console.WriteLine();
    //     Console.WriteLine("1-Mercimek Çorbası");
    //     Console.WriteLine("2-Ezogelin Çorbası");
    //     Console.WriteLine();
    // }else if (menuItem==3){
    //     Console.WriteLine("---------- Pizzalar ----------");
    //     Console.WriteLine();
    //     Console.WriteLine("1-Akdeniz Pizza");
    //     Console.WriteLine("2-Margarita Pizza");
    //     Console.WriteLine("3-Tavuklu Pizza");
    //     Console.WriteLine();
    // }else if (menuItem==4){
    //     Console.WriteLine("---------- İçecekler ----------");
    //     Console.WriteLine();
    //     Console.WriteLine("1-Kola");
    //     Console.WriteLine("2-Ayran");
    //     Console.WriteLine("3-Su");
    //     Console.WriteLine();       
    // }else if (menuItem==5){
    //     Console.WriteLine("---------- Tatlılar ----------");
    //     Console.WriteLine();
    //     Console.WriteLine("1-Triliçe");
    //     Console.WriteLine("2-Kazandibi");
    //     Console.WriteLine("3-Sütlaç");
    //     Console.WriteLine();       
    // }else{
    //     Console.WriteLine("Böyle bir kategori bulunmamaktadır.");
    // }
    #endregion
    #region Switch Case 
    // Console.Write("Lütfen ay girişi yapınız: ");
    // int monthNumber = int.Parse(Console.ReadLine());
    // switch(monthNumber){
    //     case 1:Console.WriteLine("Ocak");break;
    //     case 2:Console.WriteLine("Şubat");break;
    //     case 3:Console.WriteLine("Mart");break;
    //     case 4:Console.WriteLine("Nisan");break;
    //     case 5:Console.WriteLine("Mayıs");break;
    //     case 6:Console.WriteLine("Haziran");break;
    //     case 7:Console.WriteLine("Temmuz");break;
    //     case 8:Console.WriteLine("Ağustos");break;
    //     case 9:Console.WriteLine("Eylül");break;
    //     case 10:Console.WriteLine("Ekim");break;
    //     case 11:Console.WriteLine("Kasım");break;
    //     case 12:Console.WriteLine("Aralık");break;
    //     default:Console.WriteLine("Böyle bir ay yok!");break;
    // }
    #endregion
    #region Switch Case Hesap Makinesi
    // Console.WriteLine("***** Hesap Makinesi *****");
    // Console.WriteLine();
    // Console.WriteLine("1-Toplama");
    // Console.WriteLine("2-Çıkartma");
    // Console.WriteLine("3-Çarpma");
    // Console.WriteLine("4-Bölme");
    // Console.Write("Yapmak istediğiniz işlemi seçin: ");
    // int secim = int.Parse(Console.ReadLine());
    // Console.Write("1. sayıyı seçiniz: ");
    // int number1=int.Parse(Console.ReadLine());    
    // Console.Write("2. sayıyı seçiniz: ");
    // int number2=int.Parse(Console.ReadLine());
    // switch (secim){
    //     case 1:Console.WriteLine("Sonuç: "+ (number1+number2));break;
    //     case 2:Console.WriteLine("Sonuç: "+ (number1-number2));break;
    //     case 3:Console.WriteLine("Sonuç: "+(number1*number2));break;
    //     case 4:Console.WriteLine("Sonuç: "+(number1/number2));break;
    //     default:Console.WriteLine("Geçersiz işlem!");break;
    // }

    #endregion

}


}
