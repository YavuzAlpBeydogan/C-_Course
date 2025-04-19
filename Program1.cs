using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _01_MainSubjects
{
    internal class Program{
        static void Main(string[]args){
            #region YazdırmaKomutları
            //Yazdırma Komutları
            //Console.WriteLine("***** Yemek Kategorileri *****");
            //Console.WriteLine();
            //Console.WriteLine("1-Çorbalar");
            //Console.WriteLine("2-Ana Yemekler");
            //Console.WriteLine("3-Soğuk Başlangıçlar");
            //Console.WriteLine("4-Salatalar");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("6-İçecekler");
            #endregion
            #region StingDeğişkenler 
            
            // string customerName;
            // string customerSurname;
            // string customerPhone;
            // string customerEmail, district, city;
            // customerName = "Yavuz";
            // customerSurname = "Beydogan";
            // customerPhone = "+90 533 640 39 33";
            // customerEmail= "yavuzalp@beydogan.com";
            // district = "Yenisehir";
            // city = "Mersin" ; 
            // Console.WriteLine("***** Rezervasyon Kartı *****");
            // Console.WriteLine();
            // Console.WriteLine("-------------------------------------------");
            // Console.WriteLine("Müşteri:" + customerName+ " "+ customerSurname);
            // Console.WriteLine("Telefon:"+customerPhone);
            // Console.WriteLine("Mail:"+customerEmail);
            // Console.WriteLine("Adres:"+ district+ " / " +city);
            // Console.WriteLine("-------------------------------------------");
            // customerName = "Aysenur";
            // customerSurname = "Ekici";
            // customerPhone = "+90 533 329 76 42";
            // customerEmail= "aysenurekici@gmail.com";
            // district = "Akdeniz";
            // city = "Mersin" ; 
            // Console.WriteLine();
            // Console.WriteLine("Müşteri:" + customerName+ " "+ customerSurname);
            // Console.WriteLine("Telefon:"+customerPhone);
            // Console.WriteLine("Mail:"+customerEmail);
            // Console.WriteLine("Adres:"+ district+ " / " +city);
            // Console.WriteLine("-------------------------------------------");
            #endregion
            #region İntDeğişkenler
            int hamburgerPrice = 300;
            int cokePrice = 35;
            int waterPrice = 10;
            int friesPrice = 50;
            int pizzaPrice = 250;
            int lemonadePrice = 30;
            Console.WriteLine("***** Restoran Menü Fiyatı *****");
            Console.WriteLine();
            Console.WriteLine("-----Hamburger Fiyatı:"+hamburgerPrice+" TL");
            Console.WriteLine("-----Kola Fiyatı:"+cokePrice+" TL");
            Console.WriteLine("-----Su Fiyatı:"+waterPrice+" TL");
            Console.WriteLine("-----Patates Fiyatı:"+friesPrice+" TL");
            Console.WriteLine("-----Pizza Fiyatı:"+pizzaPrice+" TL");            
            Console.WriteLine("-----Limonata Fiyatı:"+lemonadePrice+" TL");
            Console.WriteLine("***** Restoran Menü Fiyatı *****");
            Console.WriteLine();
            int hamburgerCount;
            int cokeCount;
            int waterCount;
            int friesCount;
            int pizzaCount;
            int lemonadeCount;

            int totalHamburgerPrice = 0;
            int totalCokePrice = 0;
            int totalWaterPrice = 0;
            int totalFriesPrice = 0;
            int totalPizzaPrice = 0;
            int totalLemonadePrice = 0;
            int totalPrice =0;

            hamburgerCount=3;
            cokeCount=3;
            waterCount=3;
            friesCount=1;
            pizzaCount=0;
            lemonadeCount=0;
            
            totalHamburgerPrice=hamburgerCount*hamburgerPrice;
        
            Console.WriteLine("Hamburger Tutarı:"+totalHamburgerPrice+" TL");
            totalCokePrice=cokeCount*cokePrice;
        
            Console.WriteLine("Kola Tutarı:"+totalCokePrice+" TL");
            totalWaterPrice=waterCount*waterPrice;
        
            Console.WriteLine("Su Tutarı:"+totalWaterPrice+" TL");
            totalFriesPrice=friesCount*friesPrice;
        
            Console.WriteLine("Patates Tutarı:"+totalFriesPrice+" TL");
            totalPizzaPrice=pizzaCount*pizzaPrice;
        
            Console.WriteLine("Pizza Tutarı:"+totalPizzaPrice+" TL");
            totalLemonadePrice=lemonadeCount*lemonadePrice;
        
            Console.WriteLine("Limonata Tutarı:"+totalLemonadePrice+" TL");

            totalPrice = totalCokePrice+totalFriesPrice+totalHamburgerPrice+totalLemonadePrice+totalPizzaPrice+totalWaterPrice;
            Console.WriteLine("Toplam Tutar:"+totalPrice+" TL");
            #endregion
        }
    }
}
