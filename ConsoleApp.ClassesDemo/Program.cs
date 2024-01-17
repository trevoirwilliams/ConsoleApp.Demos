// See https://aka.ms/new-console-template for more information

using ConsoleApp.ClassesDemo.Classes.PersonDemo;
using ConsoleApp.ClassesDemo.Classes.ShapeDemo;

Console.WriteLine("************* - Classes and Objects - *************");
// Read more https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/object-and-collection-initializers 
/* Define an object of type Person. this will be null by default. Without the new instance, it will give a null exception if it is used.
*/
Person person;  
// person = new Person(); // Can be initialized at another point of the code. 

// It is best to define and declare a new object. 
Person baby = new Person();

// Using the 
baby.LastName = "Thompson";
baby.FirstName = "Theresa";
baby.DateofBirth = new DateOnly(2023, 10, 29);

/*
 * Objects can be initialized like this alternatively, where the object's properties  are set all at once. 
   Person baby = new Person
   {
       LastName = "Thompson",
       FirstName = "Theresa",
       DateofBirth = new DateOnly(2023, 10, 29)
   };
 */

baby.PrintFullName();
baby.PrintInitials();
baby.GenerateTaxNumber();
var taxNumber = baby.GetTaxNumber();
Console.WriteLine(taxNumber);

// Object declaration using non-default constructors
var person1 =  new Person("Developer", "One", new DateOnly(2000,10,31));
person1.PrintFullName();
person1.PrintInitials();

var person2 = new Person("Developer", "Two", "741852963");
person2.PrintFullName();
person2.PrintInitials();
person2.GenerateTaxNumber();
var person2IdNumber = person2.GetIdNumber();
Console.WriteLine(person2IdNumber);

// Using classes derived from the base class
var teacher = new Teacher();
teacher.LastName = "Thompson";
teacher.FirstName = "Theresa";
teacher.DateofBirth = new DateOnly(2023, 10, 29);

teacher.PrintFullName();
teacher.PrintInitials();
teacher.GenerateTaxNumber();
var teachertaxNumber = teacher.GetTaxNumber();
Console.WriteLine(teachertaxNumber);
teacher.GenerateTeacherIdNumber();
var teacherIdNumber = teacher.GetIdNumber();
Console.WriteLine(teacherIdNumber);


Student student = new();
student.LastName = "Thompson";
student.FirstName = "Theresa";
student.DateofBirth = new DateOnly(2023, 10, 29);
student.PrintFullName();
student.PrintInitials();
student.GenerateTaxNumber();
student.GenerateStudentIdNumber();
var studentIdNumber = student.GetIdNumber();
Console.WriteLine(studentIdNumber);


//Polygon polygon = new Polygon(); // compiler error
Rectangle rectangle = new(10,20);
var rectangleArea = rectangle.Area();
var rectanglePerimeter = rectangle.Perimeter();
rectangle.GetShapeName();
Console.WriteLine($"Rectangle perimeter is: {rectanglePerimeter}");
Console.WriteLine($"Rectangle area is: {rectangleArea}");

Square square = new(50);
var sqaureArea = square.Area();
Console.WriteLine($"Sqaure area is: {sqaureArea}");


Cuboid cuboid = new(1, 5, 7);
var cuboidArea = cuboid.Area();
var cuboidVolume = cuboid.Volume();
var cuboidPerimeter = cuboid.Perimeter();
Console.WriteLine($"Cuboid area is: {cuboidArea}");
Console.WriteLine($"Cuboid volume is: {cuboidVolume}");
Console.WriteLine($"Cuboid perimeter is: {cuboidPerimeter}");

Sphere sphere = new(7);
var sphereCircumference = sphere.Circumference();
var sphereVolume = sphere.Volume();
Console.WriteLine($"{nameof(Sphere)} volume is: {sphereVolume}");
Console.WriteLine($"{nameof(Sphere)} Circumference is: {sphereCircumference}");