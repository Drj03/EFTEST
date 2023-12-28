using EFTest.Models;
using EFTest.Repositories;
using EFTest.ViewModels;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace EFTest.Controllers
{
    [Route("[controller]/[action]")]
    public class HomeController : Controller
    {
       
        private readonly IRepository repo;
        //private readonly DbContext context;
 private readonly DataBaseContext baseContext;
        public HomeController(DataBaseContext dataBase,IRepository repository)
        {
          
            this.repo = repository;
           // this.context= dbContext;
            this.baseContext = dataBase;
        }
       [Route("")]
       [Route("~/Home")]
       [Route("~/")]
        public IActionResult Index()
            
        {
            //var st=baseContext.Grades.Include(s=>s.Students).FirstOrDefault
            //       (s=>s.gr);
            // var stu = baseContext.Grades.Include(s => s.Students)
            //   .FirstOrDefault(
            //    s => s.GradeId == 1);
            EmployeeWithDepartement employee = new EmployeeWithDepartement
            {
                emp =baseContext.Employees.ToList(),
                dept=baseContext.Departments.ToList()


            };
            var model = repo.allStudents();
            return View(employee);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult ArtistsDetails()
        {
            var all = baseContext.artists.FromSqlRaw("select a.name as artist1,b.name as artist2,a.education from artists a,artists b where a.id<>b.id  and a.education=b.education  order by education");
         

            ArtistsDetailsViewModel model = new ArtistsDetailsViewModel
            {
                artistsP=baseContext.artists.ToList(),
                albumsP=baseContext.albums.ToList(),
                singlesP=baseContext.singles.ToList()
            };
            return View(all);
        }
    }
}