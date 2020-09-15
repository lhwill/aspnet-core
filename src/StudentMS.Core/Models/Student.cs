using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentMS.Models
{
  public  class Student: AuditedAggregateRoot<int>
    {
        public string SName { get; set; }
        public int Age { get; set; }
        public bool Sex { get; set; }
        public Grade Grade { get; set; }
    }
}
