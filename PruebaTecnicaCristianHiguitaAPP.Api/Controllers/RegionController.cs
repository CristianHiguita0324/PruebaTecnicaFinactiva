using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PruebaTecnicaCristianHiguitaAPP.Aplication.RegionAplication.Delete;
using PruebaTecnicaCristianHiguitaAPP.Aplication.RegionAplication.New;
using PruebaTecnicaCristianHiguitaAPP.Aplication.RegionAplication.Search;
using PruebaTecnicaCristianHiguitaAPP.Aplication.RegionAplication.Update;
using PruebaTecnicaCristianHiguitaAPP.Cross.Cls;
using PruebaTecnicaCristianHiguitaAPP.Cross.Entities;
using PruebaTecnicaCristianHiguitaAPP.Cross.Exception_;

namespace PruebaTecnicaCristianHiguitaAPP.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegionController : ControllerBase
    {
        private readonly INewRegionAplication _newRegionAplication;
        private readonly IDeleteRegionAplication _deleteRegionAplication;
        private readonly ISearchRegionAplication _searchRegionAplication;
        private readonly IUpdateRegionAplication _updateRegionAplication;
        public RegionController(INewRegionAplication newRegionAplication, IDeleteRegionAplication deleteRegionAplication, 
            ISearchRegionAplication searchRegionAplication, IUpdateRegionAplication updateRegionAplication)
        {
            _newRegionAplication = newRegionAplication;
            _deleteRegionAplication = deleteRegionAplication;
            _searchRegionAplication = searchRegionAplication;
            _updateRegionAplication = updateRegionAplication;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Request"></param>
        /// <returns></returns>
        [HttpPost("NewRegion")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]
        [ProducesResponseType(504)]
        public IActionResult NewRegion([FromBody] RegionDto Request)
        {

            try
            {
                var _resultado = _newRegionAplication.execute(Request.NombreRegion);
                return StatusCode(StatusCodes.Status200OK, _resultado);
            }
            catch (TecnicalException ex)
            {
                return StatusCode(StatusCodes.Status204NoContent, CreateResponseService.execute(StatusCodes.Status500InternalServerError.ToString(), ex.Message.ToString(), string.Empty));
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
                var _resultado = _deleteRegionAplication.execute(id);
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

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetAll")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]
        [ProducesResponseType(504)]
        public IActionResult GetAll()
        {

            try
            {
                var _resultado = _searchRegionAplication.GetAll();
                return StatusCode(StatusCodes.Status200OK, _resultado);
            }
            catch (TecnicalException ex)
            {
                return StatusCode(StatusCodes.Status200OK, CreateResponseService.execute(StatusCodes.Status500InternalServerError.ToString(), ex.Message.ToString(), string.Empty));
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet("Get")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]
        [ProducesResponseType(504)]
        public IActionResult Get(int id)
        {

            try
            {
                var _resultado = _searchRegionAplication.GetId(id);
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
        public IActionResult Update([FromBody] RegionDetails Request)
        {

            try
            {
                var _resultado = _updateRegionAplication.execute(Request);
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
