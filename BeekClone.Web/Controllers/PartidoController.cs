using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BeekClone.Web.DataBase;

namespace BeekClone.Web.Controllers
{
    public class PartidoController : Controller
    {
        // GET: Partido
        public ActionResult Index(DateTime? fecha)
        {
            var db = new DbEntities();

            fecha = fecha == null ? DateTime.Now : fecha;
            var siguienteDia = fecha.GetValueOrDefault().AddDays(1);

            var partidosDeHoy = db.Partidos
                .Where(o => o.Fecha >= fecha && o.Fecha < siguienteDia)
                .Include(o => o.EquipoLocal)
                .Include(o => o.EquipoVisitante)
                .ToList();

            return View(partidosDeHoy);
        }
    }
}