#region Temel Diziler
// string [] cities = new string[5];
// cities[0]="Mersin";
// cities[1]="Adana";
// cities[2]="Ankara";
// cities[3]="İzmir";
// cities[4]="Eskişehir";

// string [] Lessons = {"Matematik","Fizik","Kimya","Türkçe"};
// Console.WriteLine(Lessons[0]);
#endregion

#region Tüm Diziyi Yazdırma
// string [] colors = {"mavi","yeşil","kırmızı","turuncu"};
// for (int i=0; i<colors.Length; i++){
//     Console.WriteLine(colors[i]);
// }
#endregion

#region Dizi Örnek 1
// int [] numbers ={3, 6,96,74,125,635,488,520,7456,12,1120};
// for (int i=0; i<numbers.Length; i++){
//     if (numbers[i]%3==0){
//         Console.WriteLine(numbers[i]);
//     }
// }
#endregion

#region Dizi Örnek 2
int [] myArrays ={47,85,95,41 ,25,635,789 };
int maxNumber=myArrays[0];
for (int i=0; i<myArrays.Length;i++){
    if (myArrays[i]>maxNumber){
        maxNumber=myArrays[i];
    }
    
}
Console.WriteLine(  maxNumber);
#endregion

#region 
#endregion

