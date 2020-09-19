using CSharpHomework7_8.Context;
using CSharpHomework7_8.Model;
using CSharpHomework7_8.Services.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharpHomework7_8.Services
{
    public class EmployeeService : IEmployeeService
    {
        public readonly APIContext _db;
        public EmployeeService(APIContext db)
        {
            _db = db;
        }
        public Employee Get(int ID)
        {
            return _db.Employees.FirstOrDefault(x => x.ID == ID);
        }

        public List<Employee> GetEmployees()
        {
            return _db.Employees.Select(x => x).ToList();
        }
        public void Add(Employee employee)
        {
            _db.Employees.Add(employee);
            _db.SaveChanges();
        }
    }
}
