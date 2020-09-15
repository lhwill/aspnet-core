using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Abp.Dependency;
using Microsoft.AspNetCore.Mvc;
using StudentMS.Controllers;
using StudentMS.Models;
using StudentMS.Web.Models.Grade;

namespace StudentMS.Web.Controllers
{
    public class GradeController : StudentMSControllerBase, ITransientDependency
    {

        private readonly IGradeAppService _gradeAppService;
        public GradeController(IGradeAppService gradeAppService)
        {
            _gradeAppService = gradeAppService;
        }
        public IActionResult Index()
        {
            var grade = _gradeAppService.GetAll(new PagedAndSortedResultRequestDto { MaxResultCount = 10 }).Items;
            var model = new GradeViewModel
            {
                Grades = grade
            };
            return View(model);
        }
    }
}
