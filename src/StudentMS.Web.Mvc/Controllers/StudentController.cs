using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Abp.Dependency;
using Microsoft.AspNetCore.Mvc;
using StudentMS.Controllers;
using StudentMS.Models;
using StudentMS.Models.Dto;
using StudentMS.Web.Models.Student;

namespace StudentMS.Web.Controllers
{
    public class StudentController : StudentMSControllerBase,ITransientDependency
    {
        private readonly IStudentAppService _studentAppService;
        public StudentController(IStudentAppService studentAppService)
        {
            _studentAppService = studentAppService;
        }

        public IActionResult Index()
        {

         var stus=  _studentAppService.GetAll(new PagedAndSortedResultRequestDto {  MaxResultCount=10}).Items;
            var model = new StudentViewModel
            {
                Students = stus
            };
            return View(model);
        }
    }
}
