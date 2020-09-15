using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentMS.Models.Dto
{
    [AutoMapFrom(typeof(Models.Student))]
    public class StudentDto : EntityDto<int>
    {
        public string SName { get; set; }
        public int Age { get; set; }
        public bool Sex { get; set; }
        public Grade Grade { get; set; }
    }
}
