using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class XmlPoke
    {
        public Guid PokeId { get; set; }
        public string Poke { get; set; }
        public string ActivityReference { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
