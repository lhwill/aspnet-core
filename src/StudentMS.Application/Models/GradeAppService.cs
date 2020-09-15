using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using StudentMS.Models.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentMS.Models
{
    public class GradeAppService : CrudAppService<
             Grade, //The Book entity
             GradeDto, //Used to show books
             int, //Primary key of the book entity
             PagedAndSortedResultRequestDto, //Used for paging/sorting
             CreateUpdateGradeDto>,//Used to create/update a book
         IGradeAppService
    {
        public GradeAppService(IRepository<Grade, int> repository)
           : base(repository)
        {

        }

        public override GradeDto Create(CreateUpdateGradeDto input)
        {
            return base.Create(input);
        }

        public override GradeDto Update(CreateUpdateGradeDto input)
        {
            return base.Update(input);
        }

        public override void Delete(EntityDto<int> input)
        {
            base.Delete(input);
        }

        public override GradeDto Get(EntityDto<int> input)
        {
            return base.Get(input);
        }

        public override PagedResultDto<GradeDto> GetAll(PagedAndSortedResultRequestDto input)
        {
            return base.GetAll(input);
        }
    }
}
