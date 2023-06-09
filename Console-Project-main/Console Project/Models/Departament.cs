using System;
using System.Collections.Generic;
using System.Text;

namespace Console_Project.Models
{
    class Department
    {

        private string _name;
        public string Name 
        {
            get => _name;
            set
            {
                while (!(value.Length>=2))
                {
                    Console.WriteLine("Department adi minimum 2 herfden ibaret olmalidir");
                }
                _name = value;
            } 
        }
        private int _worklimit;
        public int WorkLimit 
        {
            get => _worklimit;
            set
            {
                while (value<1)
                {
                    Console.WriteLine("Departament'de maksimum isci sayi 1 ola biler.");
                }
                _worklimit = value;
            }
        }
        private int _salarylimit;
        public int SalaryLimit 
        {
            get => _salarylimit;
            set
            {
                while (value<250)
                {
                    Console.WriteLine("Minimum maas 250 manat ola biler");
                }
                _salarylimit = value;
            }
        }

        Employee[] Employees;

        public Department(string name, int worklimit, int salarylimit)
        {
            Name = name;
            WorkLimit = worklimit;
            SalaryLimit = salarylimit;
        }
    }
}
