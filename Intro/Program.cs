// See https://aka.ms/new-console-template for more information
using Intro.Business;
using Intro.Enities;

Console.WriteLine("Hello, World!");

string message1 = "krediler";
int term = 12;
double amount = 10000;

bool isAuthenticated = true;
Console.WriteLine(message1);

//condition
if (isAuthenticated==true) // aynısı ->if(isAtuthenticated)
{
    Console.WriteLine("buton --> hg");
}
else
{
    Console.WriteLine("buton -> sisteme giris yap");
}

/*
string[] loans = { "kredi1", "kredi2", "kredi3", "kredi4" };

for (int i = 0; i < loans.Length; i++)
{
    Console.WriteLine(loans[i]);
}


Course course1 = new Course(); // MECBUR
course1.Id = 1;
course1.Name = "c#";
course1.Description = "sürüm1";
course1.Price = 0;


Course course2 = new Course();
course2.Id = 2;
course2.Name = "python";
course2.Description = "sürüm2";
course2.Price = 0;

Course course3 = new Course();
course3.Id = 3;
course3.Name = "java";
course3.Description = "sürüm3";
course3.Price = 0;

Course[] courses = new Course[] { course1, course2, course3 }; // -> businessten aldık
for (int i = 0; i < courses.Length; i++)
{
    Console.WriteLine(courses[i].Name + " / " + courses[i].Price);

}
*/
CourseManager courseManager = new();
Course[] courses2 = courseManager.GetAll();
for (int i = 0; i < courses2.Length; i++)
{
    Console.WriteLine(courses2[i].Name + " / " + courses2[i].Price);

}


Console.WriteLine("kod bitti");


