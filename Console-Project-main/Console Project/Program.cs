using Console_Project.Interface;
using Console_Project.Models;
using Console_Project.Services;
using System;

namespace Console_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            IHumanResourceManager humanResourceManager = new HumanResourceManager();
            do
            {
                Console.WriteLine("etmek istediyiniz emeliyyati qeyd edin");
                string choice = Console.ReadLine();
                int choicenum;
                int.TryParse(choice, out choicenum);
                Console.WriteLine("1-Departameantlerin siyahisini gostermek");
                Console.WriteLine("2-Departamenet yaratmaq");
                Console.WriteLine("3-Departmanetde deyisiklik etmek");
                Console.WriteLine("4-Iscilerin siyahisini gostermek");
                Console.WriteLine("5-Departamentdeki iscilerin siyahisini gostermrek");
                Console.WriteLine("6-Isci elave etmek");
                Console.WriteLine("7-Isci uzerinde deyisiklik etmek");
                Console.WriteLine("8-Departamentden isci silinmesi");

                switch (choicenum)
                {
                    case 1:

                        break;
                    case 2:
                        AddDepartment(ref humanResourceManager);
                        break;
                    case 3:

                        break;
                    case 4:

                        break;
                    case 5:

                        break;
                    case 6:
                        AddEmployee(ref humanResourceManager);
                        break;
                    case 7:
                        
                        break;
                    case 8:

                        break;
                }

            } while (true);

        }
        static void AddDepartment(ref IHumanResourceManager humanResourceManager)
        {
            string departmentname;
            int workernum;
            int salarynum;
            Console.WriteLine("Yaradacaginiz departmentin adini daxil edin");

            departmentname = Console.ReadLine();

            while (departmentname==null||departmentname.Length<2)
            {
                Console.WriteLine("Duzgun ad daxil edin");
                departmentname = Console.ReadLine();

            }
            foreach (Department item in humanResourceManager.Departments)
            {
                if (item.Name.ToLower()==departmentname.ToLower())
                {
                    Console.WriteLine("Bu adda department movcuddur");

                }

            }
            Console.WriteLine("Departmentde max ola bilecek isci sayini elave edin");
            string worker = Console.ReadLine();

            while (!int.TryParse(worker, out workernum) || workernum < 1)
            {
                Console.WriteLine("Duzgun isci sayi  daxil edin");
                Console.ReadLine();

            }
            while (true)
            {
                Console.WriteLine("Iscilere verilecek ayliq maas limitini daxil edin");
                string salarlimit = Console.ReadLine();
                while (!int.TryParse(salarlimit,out salarynum)||salarynum<250)
                {
                    Console.WriteLine("Maasi duzgun daxil edin");
                    salarlimit = Console.ReadLine();
                }

                if (salarynum / workernum <250)
                {
                    Console.WriteLine("Maas limitini duzgun daxil edin");
                    continue;
                }
                else
                {
                    break;
                }

                Console.WriteLine("Department yaradildi");
                humanResourceManager.AddDepartment(departmentname, workernum, salarynum);
            }
        }

        static void AddEmployee(ref IHumanResourceManager humanResourceManager)
        {
            Console.WriteLine("Ad soyad daxil edin");
            string fullname = Console.ReadLine();

            Console.WriteLine("elave etmek istediyiniz departmentin adini yazin");
            string Departmentname = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(Departmentname))
            {
                Console.WriteLine("Duzgun ad daxil edin");
            }
            Console.WriteLine("Iscinin maasini daxil edin");
            string SalaryStr = Console.ReadLine();
            int salarynum;
            while (!int.TryParse(SalaryStr,out salarynum)|| salarynum<250)
            {
                Console.WriteLine("Min maas 250 manat olmalidir");
                Console.ReadLine();
            }
        }

    }
}
