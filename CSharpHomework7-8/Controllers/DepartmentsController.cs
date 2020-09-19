using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CSharpHomework7_8.Model;
using CSharpHomework7_8.Services.Abstracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CSharpHomework7_8.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class DepartmentsController : ControllerBase
    {
        public readonly IDepartmentService _depService;
        public DepartmentsController(IDepartmentService depService)
        {
            _depService = depService;
        }
        [HttpGet("{id}")]
        public Department Get(int ID)
        {
            return _depService.Get(ID);
        }
        [HttpGet]
        public List<Department> GetDepartments()
        {
            return _depService.GetDepartments();
        }

        [HttpPost]
        public void Add(Department department)
        {
            _depService.Add(department);
        }
    }
}
