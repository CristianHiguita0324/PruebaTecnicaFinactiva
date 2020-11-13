using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PruebaTecnicaCristianHiguitaAPP.Aplication.RegionAplication.Delete;
using PruebaTecnicaCristianHiguitaAPP.Aplication.RegionAplication.New;
using PruebaTecnicaCristianHiguitaAPP.Data.Models;
using PruebaTecnicaCristianHiguitaAPP.Data.UnitOfWork;
using PruebaTecnicaCristianHiguitaAPP.Domain.Region.Delete;
using PruebaTecnicaCristianHiguitaAPP.Domain.Region.New;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaTecnicaCristianHiguitaAPP.App_Config
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
        }
    }
}
