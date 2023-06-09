using System;
using System.Collections.Generic;
using System.Text;

namespace Console_Project.Models
{
    class Employee
    {
        static int _no;
        public string No;
        public string Fullname;
        private string _position;
        public string Position 
        {
            get => _position;
            set
            {
                while (!(value.Length >= 2))
                {
                    Console.WriteLine("Iscinin vezifesini duzgun daxil edin.Min 2 herfden ibaret olmalidir.");
                }
                _position = value;
            } 
            
        }
        private int _salary;
        public int Salary 
        {
            get => _salary;
            set
            {
                while (value<250)
                {
                    Console.WriteLine("iscinin maasi 250-den asagi ola bilmez");
                }
                _salary = value;
            } 
        }
        public string DepartmentName;


        static Employee()
        {
            _no = 1000;
        }

        public Employee(string no,string fullname,string position,int salary,string departmentname)
        {
            _no++;
            No = $"{departmentname[0]}{departmentname[1]}{_no}";
            No = no;
            Fullname = fullname;
            Position = position;
            Salary = salary;
            DepartmentName = departmentname;
            
        }

    }
}
