using System.ComponentModel.DataAnnotations;

namespace MalamuleleHealth.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}