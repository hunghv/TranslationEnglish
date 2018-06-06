using ETran.Data.Entities.Base;

namespace ETran.Data.Entities
{
    public class ShareNews : Entity
    {
        public int NewsId { get; set; }
        public string Users { get; set; }
        public bool? IsMailSent { get; set; }

        public virtual News News { get; set; }

    }
}
