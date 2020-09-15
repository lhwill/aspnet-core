using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace StudentMS.Models.Dto
{
    public class CreateUpdateGradeDto : EntityDto<int>
    {
        [Required]
        public string GName { get; set; }
    }
}
