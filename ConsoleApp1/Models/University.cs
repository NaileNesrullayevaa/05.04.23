using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    internal class University
    {   
        public int Id { get; set; }
        public string Name { get; set; }
        public Student[] Students { get; set; }

        public University(string name,int id)
        {
            Name = name;
            Id = id;
            Students = new Student[10];
        }




        

        public Student[] AddStudent(Student student)
        {
            if (student.Name.Length > 3 && student.Surname.Length > 3)
            {
                students.Add(student);
                
            }
           
            
   
        }
    }
}
