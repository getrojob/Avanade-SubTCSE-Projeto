using System;

namespace Avanade.SubTCSE.Projeto.Domain.Aggregates.EmployeeRole.Entities
{
    public record EmployeeRole : BaseEntity<string>
    {
        public EmployeeRole(string id, string roleName, DateTime createat, DateTime updateat )
        {
            Id = id;
            RoleName = roleName;
            CreateAt = createat;
            UpdateAt = updateat;
        }

        public EmployeeRole(string roleName)
        {
            RoleName = roleName;
        }

        public string RoleName { get; init; }
    }
}
