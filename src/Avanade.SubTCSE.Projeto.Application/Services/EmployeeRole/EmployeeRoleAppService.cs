using Avanade.SubTCSE.Projeto.Application.Dtos.EmployeeRole;
using Avanade.SubTCSE.Projeto.Application.Interfaces.EmployeeRole;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Avanade.SubTCSE.Projeto.Application.Services.EmployeeRole
{
    public class EmployeeRoleAppService : IEmployeeRoleAppService
    {
        public Task<EmployeeRoleDto> AddEmployeeRole(EmployeeRoleDto employeeRoleDto)
        {
            throw new System.NotImplementedException();
        }

        public Task<EmployeeRoleDto> DeleteEmployee(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Exist(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<EmployeeRoleDto> SelectEmployee(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<EmployeeRoleDto>> SelectEmployee()
        {
            throw new NotImplementedException();
        }

        public Task<EmployeeRoleDto> UpdateEmployee(EmployeeRoleDto employeeDto)
        {
            throw new NotImplementedException();
        }
    }
}
