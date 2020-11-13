using PruebaTecnicaCristianHiguitaAPP.Cross.Entities;
using PruebaTecnicaCristianHiguitaAPP.Domain.MunicipioDomain.Delete;
using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaTecnicaCristianHiguitaAPP.Aplication.MunicipioAplication.Delete
{
    public class DeleteMunicipioAplication : IDeleteMunicipioAplication
    {
        private readonly IDeleteMunicipioDomain _deleteMunicipioDomain;
        public DeleteMunicipioAplication(IDeleteMunicipioDomain deleteMunicipioDomain)
        {
            _deleteMunicipioDomain = deleteMunicipioDomain;
        }
        public ResponseService execute(int id)
        {
            return _deleteMunicipioDomain.execute(id);
        }
    }
}
