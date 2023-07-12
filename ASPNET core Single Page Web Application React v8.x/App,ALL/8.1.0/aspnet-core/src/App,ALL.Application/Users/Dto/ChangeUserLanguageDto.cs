using System.ComponentModel.DataAnnotations;

namespace App,ALL.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}