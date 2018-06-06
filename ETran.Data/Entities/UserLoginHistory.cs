using System;
using ETran.Data.Entities.Base;

namespace ETran.Data.Entities
{
    public class UserLoginHistory : Entity
    {
        public int UserId { get; set; }
        public virtual UserProfile User { get; set; }
        public Guid AccessToken { get; set; }
        public bool IsLoggedOut { get; set; }
        public bool IsAppToken { get; set; }
    }
}
