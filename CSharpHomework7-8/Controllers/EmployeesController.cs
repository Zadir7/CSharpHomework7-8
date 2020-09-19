using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CSharpHomework7_8.Model;
using CSharpHomework7_8.Services;
using CSharpHomework7_8.Services.Abstracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CSharpHomework7_8.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        public readonly IEmployeeService _empService;
        public EmployeesController(IEmployeeService empService)
        {
            _empService = empService;
        }
        [HttpGet("{id}")]
        public Employee Get(int ID)
        {
            return _empService.Get(ID);
        }
        [HttpGet]
        public List<Employee> GetEmployees()
        {
            return _empService.GetEmployees();
        }

        [HttpPost]
        public void Add(Employee employee)
        {
            _empService.Add(employee);
        }
    }
}
