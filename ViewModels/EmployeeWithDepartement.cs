using EFTest.Models;

namespace EFTest.ViewModels
{
    public class EmployeeWithDepartement
    {
        public IEnumerable<Employee> emp { get; set; }
        public IEnumerable<Department> dept { get; set; }
    }
}
