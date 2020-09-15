using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentMS.Models
{
   public class Grade:AuditedAggregateRoot<int>
    {
        public string GName { get; set; }
    }
}
