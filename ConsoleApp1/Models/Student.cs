using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    internal class Student
    {
        private string _name;
        private string _surname;
        public string Name 
        { 
            get 
            {
                return _name; 
            } 
            set 
            {
                if (value.Length > 3)
                {
                    _name = value;
                }
                
            } 
        }

        public string Surname
        {
            get
            {
                return _surname;
            }
            set
            {
                if (value.Length > 3)
                {
                    _surname = value;
                }

            }
        }

        public string GetFullName()
        {
            return $"{Name} {Surname}";
        }


    }
}
