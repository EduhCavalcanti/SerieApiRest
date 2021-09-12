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
    public class SerieController : Controller
    {
        private readonly ISeriesService _ISerieService;

        public SerieController(ISeriesService IserviceSerie)
        {
            _ISerieService = IserviceSerie;
        }
        // GET: SerieController
        public ActionResult Index()
        {
            var Serie = _ISerieService.Listar();

            return View(Serie);
        }

        // GET: SerieController/Details/5
        public ActionResult Details(int id)
        {
            var SerieById = _ISerieService.ObterById(id);
            return View(SerieById);
        }

        // POST: SerieController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(SeriesModel Serie)
        {
            try
            {
                var SerieCriada = _ISerieService.Inserir(Serie);

                return Ok(SerieCriada);
            }
            catch
            {
                return View();
            }
        }

        // POST: SerieController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, SeriesModel serie)
        {
            try
            {
                _ISerieService.Editar(id, serie);

                return Ok();
            }
            catch
            {
                return View();
            }
        }

        // POST: SerieController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            try
            {
                _ISerieService.Excluir(id);

                return Ok();
            }
            catch
            {
                return View();
            }
        }
    }
}
