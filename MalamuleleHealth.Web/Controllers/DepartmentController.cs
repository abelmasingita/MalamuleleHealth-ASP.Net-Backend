using MalamuleleHealth.Application.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MalamuleleHealth.Application.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DepartmentController : Controller  
    {
        private readonly IUnitofWork unitofWork;

        public DepartmentController(IUnitofWork unitofWork)
        {
            this.unitofWork = unitofWork;
        }

        public string GetDepartments()
        {

            var departments = unitofWork.Department.GetList();

            return "";
        }
    }
}
