using Casting_Operator_overloading_Indexer.Services.Interfaces;
using Casting_Operator_overloading_Indexer.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Casting_Operator_overloading_Indexer.Helpers.Responses;
using Casting_Operator_overloading_Indexer.Helpers.Constants;
using Casting_Operator_overloading_Indexer.Models;

namespace Casting_Operator_overloading_Indexer.Controllers
{
    internal class EmployeeController
    {
        private readonly IEmployeeService employeeService;
        public EmployeeController()
        {
            employeeService = new EmployeeService();

        }

       

        public void GetAll()
        {
            var employees = employeeService.GetAll();
            foreach (var employee in employees)
            {
                string result = $"{employee.Name} {employee.Surname} {employee.Age} {employee.Email} {employee.Address} {employee.Birthday.ToString("MM/dd/yyyy")}";
                Console.WriteLine(result);
            }

        }

        public void Search()
        {
            Console.WriteLine("Add search text");
            string searchtext=Console.ReadLine();

            var response=employeeService.Search(employeeService.GetAll(),searchtext);
            if (response.Length == 0)
            {
                Console.WriteLine(EmployeeResponseMessages.Notfound);
                return;
            }
            else
            {
                foreach (var employee in response)
                {
                    string result = $"{employee.Name} {employee.Surname} {employee.Age} {employee.Email} {employee.Address} {employee.Birthday.ToString("MM/dd/yyyy")}";
                    Console.WriteLine(result);
                }

            }

        }
    }
}
