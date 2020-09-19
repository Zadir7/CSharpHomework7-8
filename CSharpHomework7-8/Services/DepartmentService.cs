using CSharpHomework7_8.Context;
using CSharpHomework7_8.Model;
using CSharpHomework7_8.Services.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace CSharpHomework7_8.Services
{
    public class DepartmentService : IDepartmentService
    {
        public readonly APIContext _db;

        public DepartmentService(APIContext db)
        {
            _db = db;
        }

        public Department Get(int ID)
        {
            return _db.Departments.FirstOrDefault(x => x.ID == ID);
        }

        public List<Department> GetDepartments()
        {
            return _db.Departments.Select(x => x).ToList();
        }
        public void Add(Department department)
        {
            _db.Departments.Add(department);
            _db.SaveChanges();
        }
    }
}
