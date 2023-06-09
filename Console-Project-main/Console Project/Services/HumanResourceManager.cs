using Console_Project.Interface;
using Console_Project.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Console_Project.Services
{
    class HumanResourceManager : IHumanResourceManager
    {

        public Department[] _departments;
        public Employee[] employees;

        public HumanResourceManager()
        {
            Department Developer = new Department("developer", 4, 300);
            Department Teacher = new Department("teacher", 50, 800);
            Department Coach = new Department("coach", 14, 750);
            _departments = new Department[3];
            _departments[0] = Developer;
            _departments[1] = Teacher;
            _departments[2] = Coach;
        }

        public Department[] Departments => _departments;

        public void AddDepartment(string name, int worklimit, int salarylimit)
        {
            Department department = new Department(name, worklimit, salarylimit);
            Array.Resize(ref _departments, _departments.Length +1);
            _departments[_departments.Length - 1] = employees;
        } 

        public void AddEmployee(string no, string fullname, string position, int salary, string departmentname)
        {
            Employee employee = new Employee(no, fullname, position, salary, departmentname);
            bool check = false;
            foreach (Department department in _departments)
            {
                if (departmentname.ToUpper() == department.Name.ToUpper())
                {
                    Array.Resize(ref department.Employees, department.employee.Length + 1);
                    department.Employees[department.Employees.Length - 1] = employee;
                    check = true;
                    break;
                }
            }
            if (check = false)
            {
                Console.WriteLine("Department tapilmadi");
            }
        }


        
    }
}
