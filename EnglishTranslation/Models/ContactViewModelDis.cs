using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace EnglishTranslation.Models
{
    public class ContactViewModelDis
    {
        [DisplayName("Name")]
        [Required(ErrorMessage = "Please Enter Name")]
        public string UserName { get; set; }

        [DisplayName("Email")]
        [RegularExpression(@"^([a-zA-Z0-9_\.\-])+\@(([a-zA-Z0-9\-])+\.)+([a-zA-Z0-9]{2,4})+$",
            ErrorMessage = "Please Enter Correct Email Address")]
        [Required(ErrorMessage = "Please Enter Email Address")]
        public string UserEmail { get; set; }

        [DisplayName("Mobile")]
        [StringLength(10, ErrorMessage = "The Mobile must contains 10 characters", MinimumLength = 10)]
        [Required(ErrorMessage = "Please Enter Phone Number")]
        public string UserPhone { get; set; }

        [DisplayName("Subject")]
        [Required(ErrorMessage = "Please Enter Subject")]
        public string UserMsg { get; set; }
        
    }
}