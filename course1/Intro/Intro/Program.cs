// See https://aka.ms/new-console-template for more information
using Intro.Business;
using Intro.Entities;

Console.WriteLine("Hello, World!");

string message1 = "Krediler";
int term = 12;
double amount = 100_000.5;
bool isAuthenticated = true;


//variables --> camelCase yazılır
Console.WriteLine(message1);

//conditions
if (isAuthenticated)
{
    Console.WriteLine("Buton--> Hoşgeldin Cihat");
}
else
{
    Console.WriteLine("Buton-->Sisteme Giriş Yap");
}
string[] loans = { "Kredi 1", "Kredi 2", "Kredi 3", "Kredi 4", "Kredi 5", "Kredi 6"};

for (int i = 0; i < loans.Length; i++)
{
    Console.WriteLine(loans[i]);

}


//Newleyip oluşturmak gerekiyor.
Course course1 = new Course();
course1.Id = 1;
course1.Name = ".Net 8";
course1.Description = ".net and c#";
course1.Price = 0;

Course course2 = new Course();
course2.Id = 2;
course2.Name = "Java 17";
course2.Description = "Java17";
course2.Price = 0;

Course course3 = new Course();
course3.Id = 3;
course3.Name = "Python";
course3.Description = "Python 3.5";
course3.Price = 0;

Course[] courses = { course1, course2, course3 };


for (int i = 0; i< courses.Length; i++)
{
    Console.WriteLine(courses[i].Name + "/" + courses[i].Price);
}
// bunu tek tek yazamayız.
Console.WriteLine("Kod Tamamlandı.");



//Yukarıdaki kısım kaldırılabilir ama basit kısımlar olduğu için kalsın

CourseManager courseManger = new();
courseManger.GetAll();
Course[] courses2 = { course1, course2, course3 };
for (int i = 0; i < courses.Length; i++)
{
    Console.WriteLine(courses2[i].Name + "/" + courses2[i].Price);
}
