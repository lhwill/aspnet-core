using StudentMS.Models.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentMS.Web.Models.Student
{
    public class StudentViewModel
    {
        public IReadOnlyList<StudentDto> Students { get; set; }
    }
}
