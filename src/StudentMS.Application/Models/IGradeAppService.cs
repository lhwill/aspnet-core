using Abp.Application.Services;
using Abp.Application.Services.Dto;
using StudentMS.Models.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentMS.Models
{
    public interface IGradeAppService: ICrudAppService<GradeDto, int, PagedAndSortedResultRequestDto, CreateUpdateGradeDto>, IApplicationService
    {
    }
}
