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
        public List<string> filterBildTyp { get; set; }
        public List<FileInfo> listDateiInfos { get; set; }
    }
}
