#region Foreach 

// string [] colors = {"mavi","sarı","yeşil","kırmızı","turuncu"};
// foreach (string x in colors){
//     Console.WriteLine(x);
// }

#endregion

#region list

// List<string> cities =new List<string>(){
//     "mersin","adana","denizli"
// };
// foreach (string x in cities){
//     Console.WriteLine(x);
// }
#endregion

#region char
using System.Globalization;

string word="merhaba";
foreach(char c in word){
    Console.WriteLine(c);
}
#endregion

#region Genel Uygulama 

Console.WriteLine("***** Öğrenci Takip Uygulaması *****");
Console.WriteLine();

Console.Write("Sınıfta kaç öğrenci var: ");
int studentCount = int.Parse(Console.ReadLine());

string [] studentName = new string [studentCount];
double [] studentNoteAvg = new double [studentCount];

for (int i=0; i<studentCount; i++){
    Console.Write($"{i+1}. öğrencinin adını giriniz:");
    studentName[i]=Console.ReadLine();
    double totalNote=0;
    for (int j=0; j<3; j++){
        Console.Write($"{studentName[i]} isimli öğrencinin {j+1}.notunu giriniz:");
        double value =int.Parse(Console.ReadLine());
        totalNote+=value;
    }
    studentNoteAvg[i]=totalNote/3;
}
for (int i=0; i<studentCount;i++){
    Console.WriteLine($"{studentName[i]} isimli öğrencinin sınav ortalaması {studentNoteAvg[i]}");
}
for (int i=0; i<studentCount; i++){
    if (studentNoteAvg[i]>= 50){
        Console.WriteLine($"{studentName[i]} isimli öğrenci dersi geçti!");
    }else{
        Console.WriteLine($"{studentName[i]} isimli öğrenci dersten kaldı");
    }
}

#endregion

























