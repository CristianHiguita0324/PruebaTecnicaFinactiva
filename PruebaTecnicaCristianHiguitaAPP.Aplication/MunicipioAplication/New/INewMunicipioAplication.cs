using PruebaTecnicaCristianHiguitaAPP.Cross.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaTecnicaCristianHiguitaAPP.Aplication.MunicipioAplication.New
{
    public interface INewMunicipioAplication
    {
        ResponseService execute(MunicipioDto municipioDto);
    }
}
