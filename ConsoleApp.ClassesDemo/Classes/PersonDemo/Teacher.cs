using ConsoleApp.ClassesDemo.Utils;

namespace ConsoleApp.ClassesDemo.Classes.PersonDemo;

public class Teacher : Person
{
    public void GenerateTeacherIdNumber()
    {
        _idNumber = PersonHelper.GenerateIdNumber("TCH");

    }
}
