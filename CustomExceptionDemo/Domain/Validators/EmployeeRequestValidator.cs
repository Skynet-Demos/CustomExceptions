using CustomExceptionDemo.Domain.Exceptions;
using CustomExceptionDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CustomExceptionDemo.Domain.Validators
{
    public static class EmployeeRequestValidator
    {
        public static void Validate(EmployeeRequest employeeRequest)
        {
            if(employeeRequest == null)
            {
                throw new EmployeeArgumentException($"{nameof(employeeRequest)} is null");
            }
            else if (string.IsNullOrWhiteSpace(employeeRequest.Name))
            {
                throw new EmployeeArgumentException($"{nameof(employeeRequest.Name)} is Null/Empty/Whitespace");
            }
            else if (string.IsNullOrWhiteSpace(employeeRequest.Mobile))
            {
                throw new EmployeeArgumentException($"{nameof(employeeRequest.Mobile)} is Null/Empty/Whitesapce");
            }
            else if(employeeRequest.Mobile.Length != 10)
            {
                throw new EmployeeArgumentException($"{nameof(employeeRequest.Mobile)} is invalid");
            }
            else if (string.IsNullOrWhiteSpace(employeeRequest.Email))
            {
                throw new EmployeeArgumentException($"{nameof(employeeRequest.Email)} is Null/Empty/Whitesapce");
            }
            else if(employeeRequest.Email.Length > 0)
            {
                Regex emailRegex = new Regex(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                                                 @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                                                 @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
                if (!emailRegex.IsMatch(employeeRequest.Email))
                {
                    throw new EmployeeArgumentException($"{nameof(employeeRequest.Email)} is invalid");
                }
            }
            else if (string.IsNullOrWhiteSpace(employeeRequest.Role))
            {
                throw new EmployeeArgumentException($"{nameof(employeeRequest.Role)} is Null/Empty/Whitesapce");
            }
        }
    }
}
