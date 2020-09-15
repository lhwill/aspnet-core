using Abp.Application.Services;
using Abp.Application.Services.Dto;
using StudentMS.Models.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentMS.Models
{
   public interface IStudentAppService: ICrudAppService<StudentDto, int, PagedAndSortedResultRequestDto, CreateUpdateStudentDto>, IApplicationService
    {
    }
}
