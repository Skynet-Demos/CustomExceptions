using CustomExceptionDemo.Domain;
using CustomExceptionDemo.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomExceptionDemo.Controllers
{
    [Route("employee")]
    public class EmployeeController : ControllerBase
    {
        EmployeeManager employeeManager;

        public EmployeeController()
        {
            employeeManager = new EmployeeManager();
        }

        [HttpPost("save")]
        public void Save([FromBody]EmployeeRequest employeeRequest)
        {
            employeeManager.Save(employeeRequest);
        }

        [HttpGet("get")]
        public EmployeeResponse Get(int id)
        {
            return employeeManager.Get(id);
        }
    }
}
