using System;

namespace Avanade.SubTCSE.Projeto.Domain.Aggregates.Employee.Entities
{
    public record Employee : BaseEntity<string>
    {
        public Employee(
            string firstName,
            string surName,
            DateTime birthday,
            bool active,
            decimal salary,
            EmployeeRole.Entities.EmployeeRole employeeRole,
            DateTime createat, DateTime updateat)
        {
            FirstName = firstName;
            SurName = surName;
            Birthday = birthday;
            Active = active;
            Salary = salary;
            EmployeeRole = employeeRole;
            CreateAt = createat;
            UpdateAt = updateat;
        }

        public string FirstName { get; init; }

        public string SurName { get; init; }

        public DateTime Birthday { get; init; }

        public bool Active { get; init; }

        public decimal Salary { get; init; }

        public EmployeeRole.Entities.EmployeeRole EmployeeRole { get; init; }
    }
}
