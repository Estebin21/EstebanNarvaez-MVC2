using EstebanNarvaez_MVC2.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EstebanNarvaez_MVC2.Controllers
{
    public class EstudianteUDLAController : Controller
    {
        // GET: EstudianteUDLAController
        public ActionResult Index()
        {
            return View();
        }

        // GET: EstudianteUDLAController/Details/5
        public ActionResult Details(string id)
        {
            EstudianteUDLA estudiante = new EstudianteUDLA
            {
                IdBanner = id,
                Nombre = "Esteban Narváez",
                Correo = "narvaez.beta@udla.edu.ec"
            };

            return View(estudiante);
        }

        // GET: EstudianteUDLAController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EstudianteUDLAController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EstudianteUDLAController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: EstudianteUDLAController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EstudianteUDLAController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: EstudianteUDLAController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        public IActionResult List()
        {
            List<EstudianteUDLA> estudiantes = new List<EstudianteUDLA>();
            EstudianteUDLA estudiante1 = new EstudianteUDLA
            {
                IdBanner = "1",
                Nombre = "Juan",
                Correo = "JN@udla"
            };
            EstudianteUDLA estudiante2 = new EstudianteUDLA
            {
                IdBanner = "2",
                Nombre = "Diana",
                Correo = "Da@udla"
            };
            estudiantes.Add(estudiante1 );
            estudiantes.Add (estudiante2 );
            return View(estudiantes);
        }
    }
}
