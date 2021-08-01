using Avanade.SubTCSE.Projeto.Application.Dtos.Employee;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Avanade.SubTCSE.Projeto.Application.Interfaces.Employee
{
    public interface IEmployeeAppService
    {
        Task<EmployeeDto> AddEmployeeAsync(EmployeeDto employeeDto);
    }
}
