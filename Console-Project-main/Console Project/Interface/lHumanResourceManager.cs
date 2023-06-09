using Console_Project.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Console_Project.Interface
{
    interface IHumanResourceManager
    {
        Department[] Departments { get; }
        void AddDepartment(string name, int worklimit, int salarylimit);
        void AddEmployee(string no, string fullname, string position, int salary, string departmentname);
        
       


    }
}
