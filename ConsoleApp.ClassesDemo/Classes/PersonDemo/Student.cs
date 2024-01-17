
using ConsoleApp.ClassesDemo.Utils;

namespace ConsoleApp.ClassesDemo.Classes.PersonDemo;

public class Student : Person
{
    public void GenerateStudentIdNumber()
    {
        _idNumber = PersonHelper.GenerateIdNumber("STU");
    }
}
