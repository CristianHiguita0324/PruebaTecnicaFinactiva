﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PruebaTecnicaCristianHiguitaAPP.Aplication.MunicipioAplication.Delete;
using PruebaTecnicaCristianHiguitaAPP.Aplication.MunicipioAplication.Update;
using PruebaTecnicaCristianHiguitaAPP.Aplication.RegionAplication.Delete;
using PruebaTecnicaCristianHiguitaAPP.Aplication.RegionAplication.New;
using PruebaTecnicaCristianHiguitaAPP.Aplication.RegionAplication.Search;
using PruebaTecnicaCristianHiguitaAPP.Aplication.RegionAplication.Update;
using PruebaTecnicaCristianHiguitaAPP.Data.Models;
using PruebaTecnicaCristianHiguitaAPP.Data.UnitOfWork;
using PruebaTecnicaCristianHiguitaAPP.Domain.MunicipioDomain.Delete;
using PruebaTecnicaCristianHiguitaAPP.Domain.MunicipioDomain.Update;
using PruebaTecnicaCristianHiguitaAPP.Domain.Region.Delete;
using PruebaTecnicaCristianHiguitaAPP.Domain.Region.New;
using PruebaTecnicaCristianHiguitaAPP.Domain.RegionDomain.Search;
using PruebaTecnicaCristianHiguitaAPP.Domain.RegionDomain.Update;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaTecnicaCristianHiguitaAPP.Api.App_Start
{
    public class DependencyInjectionConfig
    {
        protected DependencyInjectionConfig() { }
        public static void Register(IServiceCollection services)
        {

            string cadenaConexion = "Server=PSOFKA0319\\SQLEXPRESS;Database=RegionesBD;Trusted_Connection=True;";



            services.AddDbContext<RegionesBDContext>(options => options.UseSqlServer(cadenaConexion));
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IDeleteRegionAplication, DeleteRegionAplication>();
            services.AddScoped<INewRegionAplication, NewRegionAplication>();
            services.AddScoped<IDeleteRegion, DeleteRegion>();
            services.AddScoped<INewRegion, NewRegion>();
            services.AddScoped<ISearchRegionAplication, SearchRegionAplication>();
            services.AddScoped<ISearchRegionDomain, SearchRegionDomain>();
            services.AddScoped<IUpdateMunicipioDomain, UpdateMunicipioDomain>();
            services.AddScoped<IUpdatemunicipioAplication, UpdatemunicipioAplication>();
            services.AddScoped<IDeleteMunicipioDomain, DeleteMunicipioDomain>();
            services.AddScoped<IDeleteMunicipioAplication, DeleteMunicipioAplication>();
            services.AddScoped<IUpdateRegionAplication, UpdateRegionAplication>();
            services.AddScoped<IUpdateRegionDomain, UpdateRegionDomain>();
        }
    }
}
