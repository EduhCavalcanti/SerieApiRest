using DioSeriesApiRest.Entities;
using DioSeriesApiRest.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DioSeriesApiRest.Controllers
{
    [ApiController]
    [Route("v1")]
    public class SerieController : ControllerBase
    {
        private readonly ISeriesService _ISerieService;

        public SerieController(ISeriesService IserviceSerie)
        {
            _ISerieService = IserviceSerie;
        }
        // GET: SerieController
        [HttpGet]
        public ActionResult Index()
        {
            return Ok();
        }

        // GET: SerieController/Details/5
        [HttpGet("{id}")]
        public ActionResult Details([FromRoute] int id)
        {
            return Ok();
        }

        // POST: SerieController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([FromBody] SeriesModel Serie)
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
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, SeriesModel serie)
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
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
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
