using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class UsersGroupsBanner
    {
        public Guid UgbId { get; set; }
        public Guid UsgId { get; set; }
        public string CompanyName { get; set; }
        public byte[] BannerCropped { get; set; }
        public string BannerCroppedFileSize { get; set; }
        public byte[] BannerSource { get; set; }
        public string BannerSourceFileSize { get; set; }
        public string BannerCropPoints { get; set; }
        public string Zoom { get; set; }

        public virtual UsersGroup Usg { get; set; }
    }
}
