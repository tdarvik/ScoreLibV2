using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Models
{
    public class Score : BaseEntity
    {
        public string Title { get; set; }
        public string OpusNr { get; set; }
        public string Type { get; set; }
        public string Version { get; set; }
        public int Published { get; set; }
        public string PhysicalForm { get; set; }
        public string Location { get; set; }
        public string Bind { get; set; }

    }
}
