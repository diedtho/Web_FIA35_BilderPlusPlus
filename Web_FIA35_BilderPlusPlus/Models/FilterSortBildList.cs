using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Web_FIA35_BilderPlusPlus.Models
{
    public class FilterSortBildList
    {
        
        public string sortierTyp { get; set; }
        public string sortierRichtung { get; set; }        
        public bool filterJpg { get; set; }
        public bool filterPng { get; set; }
        public bool filterBmp { get; set; }
        public bool filterWebp { get; set; }
        public List<FileInfo> listDateiInfos { get; set; }
    }
}
