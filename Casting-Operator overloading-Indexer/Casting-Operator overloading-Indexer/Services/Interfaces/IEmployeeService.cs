using Casting_Operator_overloading_Indexer.Helpers.Responses;
using Casting_Operator_overloading_Indexer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casting_Operator_overloading_Indexer.Services.Interfaces
{
    public interface IEmployeeService
    {
        Employee[] GetAll();
       
        Employee[] Search(Employee[] employees, string searchText);

    }
}
