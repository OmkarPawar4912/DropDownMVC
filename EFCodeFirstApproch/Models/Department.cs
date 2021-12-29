using System.Collections.Generic;

namespace EFCodeFirstApproch.Entity
{
    public class Department
    {
        public int ID { get; set; }
        public string DepartmentName { get; set; }
        public ICollection<Employee> Employees { get; set; }
    }
}