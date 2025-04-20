using System.Drawing;

namespace _04_Loops;
class Program
{
    static void Main(string[] args)
    {
        #region For Döngüsü
        // Console.Write("1'den kaça kadar yazılsın: ");
        // int adet =int.Parse(Console.ReadLine());
        // Console.WriteLine();
        // for (int i=1; i<=adet; i++){
        //     Console.WriteLine(i);
        // }
        #endregion
        #region For Döngüsü Örnek 1
        // int total = 0;
        // for (int i=1; i<=10; i++){
        //     total+=i;
        // }
        // Console.WriteLine(total);
        #endregion
        #region For DÖngüsü İle Karar Yapıları Örnek 1
        // for (int i = 1; i<=100; i++){
        //     if (i%5==0){
        //         Console.WriteLine(i);
        //     }
        // }
        #endregion     
        #region For Döngüsü İle Karar Yapıları Örnek 2
        // int total=0;
        // for (int i=1; i<=20; i++){
        //     if (i%2==0){
        //         total+=i;
        //     }
        // }
        // Console.WriteLine(total);
        #endregion
        #region For Döngüsü İle Karar Yapıları Örnek 3
        // int count=0;
        // for (int i = 1; i<=50; i++){
        //     if(i%7==0){
        //         count++;
        //     }
        // }
        // Console.WriteLine(count);
        #endregion
        #region For Döngüsü İleBakteri Çoğalması Uygulaması
        // int bakteri=1;
        // for (int i=1; i<=24; i++){
        //     bakteri*=2;
        //     Console.WriteLine(i +" Saat sonra oluşan bakteri: "+bakteri);
        // }
        #endregion
        #region While Döngüsü
        // int totalVal=0;
        // int i=1;
        // while(i<=10){
        //     totalVal+=i;
        //     i++;
        // }
        // Console.WriteLine(totalVal);
        #endregion
        #region Sınav Sorusu
        Console.Write("3 basamaklı bir sayı giriniz: ");
        int number = int.Parse(Console.ReadLine());
        int numberOne, numberTwo, numberThree;
        int sum = 0;
        numberThree=number/100;
        numberOne=number%10;
        numberTwo=(number%100)/10;
        sum=numberOne+numberTwo+numberThree;
        Console.WriteLine(numberThree+" + "+numberTwo+" + "+numberOne+ " = "+ sum);
        #endregion
    }

}
