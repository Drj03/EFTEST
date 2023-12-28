using EFTest.Models;
using Microsoft.EntityFrameworkCore;

namespace EFTest.Repositories
{
    public class SqlServerRepository :IRepository
    {
        private readonly DataBaseContext context;
        public SqlServerRepository(DataBaseContext _context)
        {
            this.context = _context;
        }

        public IEnumerable<Department> allDepartment()
        {
            return context.Departments;
        }

        public IEnumerable<Employee> allEmployee()
        {
            return context.Employees;
        }

        public IEnumerable<Student> allStudents()
        {
            return context.Students;
        }

        public IEnumerable<Artists> allArtists()
        {
            return context.artists;
        }

        public IEnumerable<Singles> allSingles()
        {
            return context.singles;
        }

        public IEnumerable<Albums> allAlbums()
        {
            return context.albums;
        }
    }
}
