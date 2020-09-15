using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using StudentMS.Models.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentMS.Models
{
  public  class StudentAppService : CrudAppService<
             Student, //The Book entity
             StudentDto, //Used to show books
             int, //Primary key of the book entity
             PagedAndSortedResultRequestDto, //Used for paging/sorting
             CreateUpdateStudentDto>,//Used to create/update a book
         IStudentAppService
    {

        public StudentAppService(IRepository<Student, int> repository)
          : base(repository)
        {

        }

        public override StudentDto Create(CreateUpdateStudentDto input)
        {
            return base.Create(input);
        }

        public override StudentDto Update(CreateUpdateStudentDto input)
        {
            return base.Update(input);
        }

        public override StudentDto Get(EntityDto<int> input)
        {
            return base.Get(input);
        }

        public override PagedResultDto<StudentDto> GetAll(PagedAndSortedResultRequestDto input)
        {
            return base.GetAll(input);
        }

        protected override Student GetEntityById(int id)
        {
            return base.GetEntityById(id);
        }

    }
}
