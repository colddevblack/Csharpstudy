using System.Linq;
using System.Web.Mvc;
using Segundodotnet.Models;
using Segundodotnet.DataAccess;
using System;

namespace Segundodotnet.Controllers
{
    public class CdController : Controller
    {
        private ArtistaContext db = new ArtistaContext();

       

        
        public ActionResult Index()
        {
            ViewBag.CadastroArtista = "Artista Cadastrados";
            ViewBag.Artista = db.Artistadb.ToList();
            return View(db.Artistadb.ToList());
        }

      

        public ActionResult CadastrarCd()
        {

            CarregarArtistasNaViewBag();
            return View();

        }

       
        [HttpPost]
        public ActionResult CadastrarCd(ArtistaModel interprete)

        {
            db.Artistadb.Add(interprete);
            db.SaveChanges();
            return RedirectToAction("Index");

        }



        [HttpPost]
        private void CarregarArtistasNaViewBag()
        {
            var lista = db.Artistadb.ToList();
            ViewBag.Artista = lista;
        }

        public ActionResult EditarCd (int id)
        {
            var model = db.Artistadb.Find(id);
            CarregarArtistasNaViewBag();

            return View(model);
        }

        [HttpPost]
        public ActionResult EditarCd (ArtistaModel interprete)
        {

            db.Entry(interprete).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();

            return RedirectToAction("Index");
        }


        // api delete
        public ActionResult Apagar(int id)
        {

            var obj = db.Artistadb.Find(id);
            
            db.SaveChanges();
            return RedirectToAction("Index");
        }

 

        [HttpPost]
        public ActionResult ExcluirAjax(int id)
        {
            try
            {
                var obj = db.Artistadb.Find(id);
                db.Artistadb.Remove(obj);
                db.SaveChanges();
            }
            catch (Exception ex)
            {

                return Json(ex.Message);
            }

            return Json("Cd excluido via ajax");
        }




    }
}
  