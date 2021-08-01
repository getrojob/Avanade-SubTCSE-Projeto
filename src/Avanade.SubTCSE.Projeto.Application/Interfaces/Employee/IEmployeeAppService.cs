using Avanade.SubTCSE.Projeto.Application.Dtos.Employee;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Avanade.SubTCSE.Projeto.Application.Interfaces.Employee
{
    public interface IEmployeeAppService
    {
        Task<EmployeeDto> AddEmployee(EmployeeDto employeeDto);
        Task<EmployeeDto> UpdateEmployee(EmployeeDto employeeDto);
        Task<EmployeeDto> DeleteEmployee(int Id);
        Task<EmployeeDto> SelectEmployee(int Id);
        Task<IEnumerable<EmployeeDto>> SelectEmployee();
        Task<bool> Exist(int Id);
    }
}
