using System;
using System.Collections.Generic;

namespace PruebaTecnicaCristianHiguitaAPP.Data.Models
{
    public partial class TblRegion
    {
        public TblRegion()
        {
            TblRegionMunicipio = new HashSet<TblRegionMunicipio>();
        }

        public int IdRegion { get; set; }
        public string NombreRegion { get; set; }

        public virtual ICollection<TblRegionMunicipio> TblRegionMunicipio { get; set; }
    }
}
