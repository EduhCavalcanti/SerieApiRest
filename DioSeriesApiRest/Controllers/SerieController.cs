using DioSeriesApiRest.InputModel;
using DioSeriesApiRest.Services;
using DioSeriesApiRest.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System.Collections.Generic;


namespace DioSeriesApiRest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SerieController : ControllerBase
    {
        private readonly ISeriesService _ISerieService;

        public SerieController(ISeriesService IserviceSerie)
        {
            _ISerieService = IserviceSerie;
        }
        // GET: SerieController
        [HttpGet]
        public async Task<ActionResult<List<SerieViewModel>>> Index()
        {
            var listaSeries = await _ISerieService.Listar();
            return Ok(listaSeries);
        }

        // GET: SerieController/Details/5
        [HttpGet("/{id}")]
        public async Task<ActionResult<SerieViewModel>> DetailsById([FromRoute] int id)
        {
            var serieById = await _ISerieService.ObterById(id);
            return Ok(serieById);
        }

        // POST: SerieController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task Create([FromBody] SerieInputModel serie)
        {
            try
            {
                await _ISerieService.Inserir(serie);
                Ok();
            }
            catch
            {
                NoContent();
            }
        }

        // POST: SerieController/Edit/5
        [HttpPut("/{id}")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([FromRoute] int id, [FromBody] SerieInputModel serie)
        {
            try
            {
                await _ISerieService.Editar(id, serie);
                return Ok();
            }
            catch
            {
                return NotFound();
            }
        }

        // POST: SerieController/Delete/5
        [HttpDelete("/{id}")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete([FromRoute] int id)
        {
            try
            {
                await _ISerieService.Excluir(id);
                return Ok();
            }
            catch
            {
                return Ok();
            }
        }
    }
}
