using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PruebaTecnicaCristianHiguitaAPP.Aplication.MunicipioAplication.Delete;
using PruebaTecnicaCristianHiguitaAPP.Aplication.MunicipioAplication.Update;
using PruebaTecnicaCristianHiguitaAPP.Aplication.RegionAplication.New;
using PruebaTecnicaCristianHiguitaAPP.Cross.Cls;
using PruebaTecnicaCristianHiguitaAPP.Cross.Entities;
using PruebaTecnicaCristianHiguitaAPP.Cross.Exception_;

namespace PruebaTecnicaCristianHiguitaAPP.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MunicipioController : ControllerBase
    {
        private readonly IUpdatemunicipioAplication _updatemunicipioAplication;
        private readonly IDeleteMunicipioAplication _deleteMunicipioAplication;
        public MunicipioController(IUpdatemunicipioAplication updatemunicipioAplication, IDeleteMunicipioAplication deleteMunicipioAplication)
        {
            _updatemunicipioAplication = updatemunicipioAplication;
            _deleteMunicipioAplication = deleteMunicipioAplication;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Request"></param>
        /// <returns></returns>
        [HttpPut("Update")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]
        [ProducesResponseType(504)]
        public IActionResult Update([FromBody] MunicipioDto Request)
        {

            try
            {
                
                    var _resultado = _updatemunicipioAplication.execute(Request);
                    return StatusCode(StatusCodes.Status200OK, _resultado);
            }
            catch (TecnicalException ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, CreateResponseService.execute(StatusCodes.Status500InternalServerError.ToString(), ex.Message.ToString(), string.Empty));
            }

            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }



        [HttpDelete("Delete")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]
        [ProducesResponseType(504)]
        public IActionResult Delete([Required] int id)
        {

            try
            {
                var _resultado = _deleteMunicipioAplication.execute(id);
                return StatusCode(StatusCodes.Status200OK, _resultado);
            }
            catch (TecnicalException ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, CreateResponseService.execute(StatusCodes.Status500InternalServerError.ToString(), ex.Message.ToString(), string.Empty));
            }

            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

    }
}
