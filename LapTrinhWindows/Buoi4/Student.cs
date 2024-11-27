using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LapTrinhWindows
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; } 
        public String Phone {  get; set; }

        public Student(int id, String name, string phone)
        {
            Id = id;
            Name = name;
            Phone = phone;
        }
    }
}
