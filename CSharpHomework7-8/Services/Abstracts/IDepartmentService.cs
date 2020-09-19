using CSharpHomework7_8.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharpHomework7_8.Services.Abstracts
{
    public interface IDepartmentService
    {
        public Department Get(int ID);
        public List<Department> GetDepartments();
        public void Add(Department department);
    }
}
