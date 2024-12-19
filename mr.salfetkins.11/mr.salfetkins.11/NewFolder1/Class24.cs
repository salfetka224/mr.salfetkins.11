using System.Collections.Generic;

public class Employee
{
    public string Name { get; set; }
    public Department EmployeeDepartment { get; set; }

    public class Department
    {
        public string DepartmentName { get; set; }
        public List<Employee> Employees { get; set; } = new List<Employee>();

        public List<Employee> GetAllEmployees()
        {
            return Employees;
        }
    }
}