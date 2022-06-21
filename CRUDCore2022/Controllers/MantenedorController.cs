using Microsoft.AspNetCore.Mvc;
using CRUDCore2022.Models;
using CRUDCore2022.Datos;

namespace CRUDCore2022.Controllers
{
    public class MantenedorController : Controller
    {
        private ContactoDatos contactoDatos = new ContactoDatos();

        public IActionResult Listar()
        {
            var olista = contactoDatos.Listar();

            return View(olista);
        }

        public IActionResult Guardar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Guardar(Contacto oContacto)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            bool respuesta = contactoDatos.Guardar(oContacto);

            if (respuesta)
            {
                return RedirectToAction("Listar");
            }
            else
            {
                return View();
            }
        }

        public IActionResult Editar(int idContacto)
        {
            var oContacto = contactoDatos.Obtener(idContacto);
            return View(oContacto);
        }

        [HttpPost]
        public IActionResult Editar(Contacto oContacto)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            bool respuesta = contactoDatos.Editar(oContacto);

            if (respuesta)
            {
                return RedirectToAction("Listar");
            }
            else
            {
                return View();
            }
        }

        [HttpPost]
        public IActionResult Eliminar(int idContacto)
        {
            bool respuesta = contactoDatos.Eliminar(idContacto);

            if (respuesta)
            {
                return RedirectToAction("Listar");
            }
            else
            {
                return View();
            }
        }
    }
}
