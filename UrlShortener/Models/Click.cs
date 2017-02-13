using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace UrlShortener.Models
{
    public class Click
    {
        public int Id { get; set; }
        public DateTime Created { get; set; }

        public string BookmarkId { get; set; }

        [ForeignKey("BookmarkId")]
        public virtual Bookmark Bookmark { get; set; }

        public string OwnerId { get; set; }

        [ForeignKey("OwnerId")]
        public virtual ApplicationUser Owner { get; set; }
    }
}