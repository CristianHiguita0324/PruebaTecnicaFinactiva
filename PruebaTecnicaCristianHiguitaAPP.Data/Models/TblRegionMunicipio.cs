using System;
using System.Collections.Generic;

namespace PruebaTecnicaCristianHiguitaAPP.Data.Models
{
    public partial class TblRegionMunicipio
    {
        public int IdRegionMunicipio { get; set; }
        public int IdMunicipio { get; set; }
        public int Idregion { get; set; }

        public virtual TblMunicipio IdMunicipioNavigation { get; set; }
        public virtual TblRegion IdregionNavigation { get; set; }
    }
}
