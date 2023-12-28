using EFTest.Models;

namespace EFTest.Repositories
{
    public interface IRepository
    {
        IEnumerable<Student> allStudents();
        IEnumerable<Employee> allEmployee();
        IEnumerable<Department> allDepartment();
    }
}
