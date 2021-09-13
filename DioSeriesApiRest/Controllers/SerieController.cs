using DioSeriesApiRest.InputModel;
using DioSeriesApiRest.Services;
using DioSeriesApiRest.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;


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
        public async Task<ActionResult<SerieViewModel>> Index()
        {
            return Ok();
        }

        // GET: SerieController/Details/5
        [HttpGet("/{id}")]
        public async Task Details([FromRoute] int id)
        {
            return Ok();
        }

        // POST: SerieController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task Create([FromBody] SerieInputModel Serie)
        {
            try
            {
                return Ok();
            }
            catch
            {
                return Ok();
            }
        }

        // POST: SerieController/Edit/5
        [HttpPost("/{id}")]
        [ValidateAntiForgeryToken]
        public async Task<SerieViewModel> Edit([FromRoute] int id, [FromBody] SerieInputModel serie)
        {
            try
            {
                return Ok();
            }
            catch
            {
                return Ok();
            }
        }

        // POST: SerieController/Delete/5
        [HttpPost("/{id}")]
        [ValidateAntiForgeryToken]
        public async Task Delete([FromRoute] int id)
        {
            try
            {
                return Ok();
            }
            catch
            {
                return Ok();
            }
        }
    }
}
