using System;
using System.Collections.Generic;

namespace PruebaTecnicaCristianHiguitaAPP.Data.Models
{
    public partial class TblMunicipio
    {
        public TblMunicipio()
        {
            TblRegionMunicipio = new HashSet<TblRegionMunicipio>();
        }

        public int IdMunicipio { get; set; }
        public string NombreMunicipio { get; set; }
        public bool Estado { get; set; }

        public virtual ICollection<TblRegionMunicipio> TblRegionMunicipio { get; set; }
    }
}
