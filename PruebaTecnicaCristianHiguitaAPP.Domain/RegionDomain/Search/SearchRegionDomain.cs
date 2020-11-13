using Microsoft.EntityFrameworkCore.Internal;
using PruebaTecnicaCristianHiguitaAPP.Cross.Entities;
using PruebaTecnicaCristianHiguitaAPP.Data.Models;
using PruebaTecnicaCristianHiguitaAPP.Data.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace PruebaTecnicaCristianHiguitaAPP.Domain.RegionDomain.Search
{
    public class SearchRegionDomain : ISearchRegionDomain
    {
        private readonly IUnitOfWork _unitOfWork;
        internal RegionesBDContext _contexto;
        public SearchRegionDomain(IUnitOfWork unitOfWork, RegionesBDContext bDContext)
        {
            _unitOfWork = unitOfWork;
            _contexto = bDContext;
        }
        public RegionDto execute()
        {
           // var res = _unitOfWork.RegionRepository.GetAll().Join(_unitOfWork.RegionMunicipioRepository.GetAll();
                throw new NotImplementedException();
        }
    }
}
