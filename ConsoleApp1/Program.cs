using ConsoleApp1.Models;
using System.Reflection.Metadata;
using System.Xml.Linq;

internal class Program
{
    private static void Main(string[] args)
    {
        Student student = new Student();
        student.Name = "Naile";
        Console.WriteLine(student.Name);
        student.Surname = "abfhhjj";
        Console.WriteLine(student.Surname);

        University university = new University("asf",2);
        university.Students=new Student[] {student};
        Console.WriteLine("universitet adini daxil edin:");
        string input1= Console.ReadLine();
        Console.WriteLine("Id daxil edin:");
        string input2= Console.ReadLine();



        while (true)
        {
          

            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    Console.WriteLine("Enter student name:");
                    string studentName = Console.ReadLine();

                    Console.WriteLine("Enter student surname:");
                    string studentSurname = Console.ReadLine();

                    Console.WriteLine("Enter student id:");
                    int studentId = int.Parse(Console.ReadLine());

                   

                    break;
                case "2":
                    var students = university.GetStudents();

                    foreach (var item in students)
                    {
                        Console.WriteLine(item.Students());
                    }

                    break;
                case "3":
                    return;
            }
        }

        


    }
}