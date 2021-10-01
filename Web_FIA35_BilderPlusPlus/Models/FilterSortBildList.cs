﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Web_FIA35_BilderPlusPlus.Models
{
    public class FilterSortBildList
    {
        
        // Bilderliste
        public List<FileInfo> listDateiInfos { get; set; }

        // Für die möglichen Radios
        public string sortierTyp { get; set; }
        public string sortierRichtung { get; set; }

        // Für die Ergebnisse der Radiobuttons
        public bool filterJpg { get; set; }
        public bool filterPng { get; set; }
        public bool filterBmp { get; set; }
        public bool filterWebp { get; set; }
        public bool filterJfif { get; set; }

        public void filterBildListe()
        {
            if (filterJpg) { listDateiInfos.RemoveAll(item => item.Name.Contains(".jpg")); }
            if (filterPng) { listDateiInfos.RemoveAll(item => item.Name.Contains(".png")); }
            if (filterBmp) { listDateiInfos.RemoveAll(item => item.Name.Contains(".bpm")); }
            if (filterWebp) { listDateiInfos.RemoveAll(item => item.Name.Contains(".webp")); }
            if (filterJfif) { listDateiInfos.RemoveAll(item => item.Name.Contains(".jfif")); }
            
            if (sortierRichtung == "aufsteigend") {
                if (sortierTyp == "nach Name") { listDateiInfos = listDateiInfos.OrderBy(o => o.Name).ToList(); }
                if (sortierTyp == "nach Größe") { listDateiInfos = listDateiInfos.OrderBy(o => o.Length).ToList(); }
            }
            if (sortierRichtung == "absteigend") {
                if (sortierTyp == "nach Name") { listDateiInfos = listDateiInfos.OrderByDescending(o => o.Name).ToList(); }
                if (sortierTyp == "nach Größe") { listDateiInfos = listDateiInfos.OrderByDescending(o => o.Length).ToList(); }
            }
        }
    }
}
