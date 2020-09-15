using System.ComponentModel.DataAnnotations;

namespace StudentMS.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}