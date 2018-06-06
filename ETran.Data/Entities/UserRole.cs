using ETran.Data.Entities.Base;

namespace ETran.Data.Entities
{
    public class UserRole : Entity
    {
        public int UserProfileId { get; set; }
        public int RoleId { get; set; }
        public virtual UserProfile UserProfile { get; set; }
        public virtual Role Role { get; set; }
    }
}
