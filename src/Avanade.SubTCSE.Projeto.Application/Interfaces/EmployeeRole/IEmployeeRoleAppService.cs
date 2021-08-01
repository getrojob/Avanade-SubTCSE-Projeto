using Avanade.SubTCSE.Projeto.Application.Dtos.EmployeeRole;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Avanade.SubTCSE.Projeto.Application.Interfaces.EmployeeRole
{
    public interface IEmployeeRoleAppService
    {
        Task<EmployeeRoleDto> AddEmployeeRole(EmployeeRoleDto employeeRoleDto);
        Task<EmployeeRoleDto> UpdateEmployee(EmployeeRoleDto employeeDto);
        Task<EmployeeRoleDto> DeleteEmployee(int Id);
        Task<EmployeeRoleDto> SelectEmployee(int Id);
        Task<IEnumerable<EmployeeRoleDto>> SelectEmployee();
        Task<bool> Exist(int Id);
    }
}