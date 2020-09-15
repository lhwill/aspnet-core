using StudentMS.Models.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentMS.Web.Models.Grade
{
    public class GradeViewModel
    {
        public IReadOnlyList<GradeDto> Grades { get; set; }
    }
}
