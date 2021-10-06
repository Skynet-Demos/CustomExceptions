using CustomExceptionDemo.Domain.Exceptions;
using CustomExceptionDemo.Domain.Validators;
using CustomExceptionDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomExceptionDemo.Domain
{
    public class EmployeeManager
    {
        public void Save(EmployeeRequest employeeRequest)
        {
            EmployeeRequestValidator.Validate(employeeRequest);

            // save to data source
        }

        public EmployeeResponse Get(int id)
        {
            if(id == 1)
            {
                return new EmployeeResponse
                {
                    Id = 1,
                    Name = "Raj",
                    Salary = 10000,
                    Manager = "Robert"
                };
            }
            else
            {
                // if no data found from out data source i.e., database
                throw new EmployeeNotFoundException("Employee data not found");
            }
        }
    }
}
