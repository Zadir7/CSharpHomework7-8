using CSharpHomework7_8.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharpHomework7_8.Services.Abstracts
{
    public interface IEmployeeService
    {
        public Employee Get(int ID);

        public List<Employee> GetEmployees();
        public void Add(Employee employee);
    }
}
