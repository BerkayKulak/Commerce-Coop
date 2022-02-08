using System.ComponentModel.DataAnnotations;

namespace ECommerce.NET_Angular.API.Dtos
{
    public class RegisterDto
    {
        [Required]
        public string DisplayName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [RegularExpression(@"(?=^.{6,10}$)(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[!@#$%^&amp;*()_+}{&quot;:;'?/&gt;.&lt;,])(?!.*\s).*$",ErrorMessage = "Şifre Formatı Bir Büyük Karakter, Bir Küçük Karakter ve Bir Rakam içermelidir")]
        public string Password { get; set; }
    }
}
