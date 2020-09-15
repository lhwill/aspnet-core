using Abp.Application.Services.Dto;
using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace StudentMS.Models.Dto
{
    public class CreateUpdateStudentDto:EntityDto<int>
    {
        [Required]
        public string SName { get; set; }
        public int Age { get; set; }
        public bool Sex { get; set; }
        [Required]
        public Grade Grade { get; set; }
    }
}
