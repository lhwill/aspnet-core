using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentMS.Models.Dto
{
    [AutoMapFrom(typeof(Models.Grade))]
   public class GradeDto:EntityDto<int>
    {
        public string GName { get; set; }
    }
}
