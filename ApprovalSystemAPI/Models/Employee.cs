﻿namespace ApprovalSystemAPI.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime HireDate { get; set; }
        public int JobTitleId { get; set; }
        public decimal Salary { get; set; }
        public int DepartmentId { get; set; }
        public int? ManagerId { get; set; }

        public virtual Employee Manager { get; set; }
        public virtual ICollection<Employee> Subordinates { get; set; }
    }
}
