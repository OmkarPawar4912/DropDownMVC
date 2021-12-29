namespace EFCodeFirstApproch.Entity
{
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        // Foreign Key for the Department 
        public int DepartmentID { get; set; }

        public Department Department { get; set; }
    }
}
