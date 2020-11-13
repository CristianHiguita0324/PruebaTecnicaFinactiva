using PruebaTecnicaCristianHiguitaAPP.Cross.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaTecnicaCristianHiguitaAPP.Aplication.MunicipioAplication.Update
{
  public  interface IUpdatemunicipioAplication
    {
        MunicipioDto execute(MunicipioDto municipioDto);
    }
}
