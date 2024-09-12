using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Informe_Azure_Rivera.Models;
namespace Informe_Azure_Rivera.Controllers
{
    public class PersonaController : Controller
    {
        public static List<ClsPersona> listaPersonas = new List<ClsPersona>();
        // GET: Persona
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult RegistrarPersona(ClsPersona ObjPersona)
        {
            if (ModelState.IsValid)
            {
                //Registramos persona
                listaPersonas.Add(ObjPersona);
                return RedirectToAction("ListarPersonas");
            }
            return View(ObjPersona);
        }
        public ActionResult ListarPersonas()
        {
            // Utilizamos la lista estática directamente
            return View(listaPersonas);
        }
    }
}