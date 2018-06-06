﻿using System.Collections.Generic;
using ETran.Data.Entities.Base;

namespace ETran.Data.Entities
{
    public class NewsComment : Entity
    {
        public NewsComment()
        {
            ChildComments = new List<NewsComment>();
            NewsLike = new List<Like>();
        }

        public int NewsId { get; set; }
        public int? ParentCommentId { get; set; }
        public string Comment { get; set; }
        public int UserProfileId { get; set; }

        public virtual News News { get; set; }
        public ICollection<NewsComment> ChildComments { get; set; }
        public virtual News ParentComment { get; set; }
        public virtual UserProfile UserProfile { get; set; }
        public ICollection<Like> NewsLike { get; set; }
    }
}
