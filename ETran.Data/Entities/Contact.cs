using System.ComponentModel.DataAnnotations;
using ETran.Data.Entities.Base;

namespace ETran.Data.Entities
{
    public class Contact:Entity
    {
        public string Name { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        [Phone]
        public string Phone { get; set; }
        public string Subject { get; set; }
        public bool IsSendMail { get; set; }
    }
}
