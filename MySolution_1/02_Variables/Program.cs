namespace _02_Variables;

class Program
{
    static void Main(string[] args)
    {
        #region Dışarıdan String Veri Girme 
    
        // string passengerName, passengerSurName, passengerDistrict, passengerCity, passengerAge, passengerID;
        // Console.WriteLine("****** Hava Yolları Yolcu Bilgisi *****");
        // Console.WriteLine();

        // Console.Write("ID: ");
        // passengerID=Console.ReadLine();
        
        // Console.Write("İsim: ");
        // passengerName=Console.ReadLine();
        
        // Console.Write("Soyisim: ");
        // passengerSurName=Console.ReadLine();

        // Console.Write("İlçe: ");
        // passengerDistrict=Console.ReadLine();

        // Console.Write("Şehir: ");
        // passengerCity=Console.ReadLine();

        // Console.Write("Yaş: ");
        // passengerAge=Console.ReadLine();


        // Console.WriteLine();
        // Console.WriteLine("------------------------");
        // Console.WriteLine("Yolcu TC: "+passengerID+"-----"+ "Yolcu Bilgileri: "+ passengerName+ " "+ passengerSurName+ 
        // "-"+passengerAge +" "+ passengerDistrict+"/"+ passengerCity);
        
        #endregion
        #region Dışarıdan İnteger Veri Girme ve Dönüşümler
    
        // int shoesPrice, computerPrice, chairPrice, tvPrice, totalPrice;
        // shoesPrice=1000;
        // computerPrice=20000;
        // chairPrice=5000;
        // tvPrice=12000;
        // int shoesCount, computerCount, chairCount, tvCount;

        // Console.Write("Lütfen aldığınız ayakkabı sayısını giriniz: ");
        // shoesCount= int.Parse(Console.ReadLine());
        // Console.Write("Lütfen aldığınız bilgisayar sayısını giriniz: ");
        // computerCount=int.Parse(Console.ReadLine());
        // Console.Write("Lütfen aldığınız sandalye sayısını giriniz: ");
        // chairCount=int.Parse(Console.ReadLine());
        // Console.Write("Lütfen aldığınız televizyon sayısını giriniz: ");
        // tvCount=int.Parse(Console.ReadLine());

        // totalPrice=shoesCount*shoesPrice+computerCount*computerPrice+chairCount*chairPrice+tvCount*tvPrice;
        // Console.WriteLine();
        // Console.WriteLine("Toplam Ödemeniz Gereken Tutar: "+totalPrice+" TL");

        #endregion
        #region Dışarıdan Ondalıklı Sayı İşlemleri
        // double exam1, exam2 ,exam3, result;

        // Console.Write("1.Sınav Notunu Giriniz: ");
        // exam1=double.Parse(Console.ReadLine());

        // Console.Write("2.Sınav Notunu Giriniz: ");
        // exam2=double.Parse(Console.ReadLine());

        // Console.Write("3.Sınav Notunu Giriniz: ");
        // exam3=double.Parse(Console.ReadLine());

        // result=(exam1+exam2+exam3)/3;
        // Console.WriteLine("Sınav Ortalamanız: "+ result);
        #endregion
        #region Dışarıdan Karakter Girişleri
        // char gender;
        // Console.Write("Cinsiyet: ");
        // gender=char.Parse(Console.ReadLine());
        // Console.WriteLine("Seçtiğin Cinsiyet: "+ gender);
        #endregion
    }


}
