using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Proactive
{
    public partial class Blog
    {
        public int BlogId { get; set; }
        public string Title { get; set; }
        public string SubHeading { get; set; }
        public string Description { get; set; }
        public string Body { get; set; }
        public bool Published { get; set; }
        public string Metadesc { get; set; }
        public string Slug { get; set; }
        public string Image { get; set; }
        public DateTime? DatePublished { get; set; }
        public bool HasVideo { get; set; }
        public string VideoUrl { get; set; }
        public string VideoDuration { get; set; }
        public string Category { get; set; }
        public DateTime? DateUpdated { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
