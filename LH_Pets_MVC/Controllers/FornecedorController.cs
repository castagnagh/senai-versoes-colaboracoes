using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LH_Pets_MVC.Controllers
{
    public class FornecedorController : Controller
    {
        // GET: FornecedorController
        public ActionResult Index()
        {
            return View();
        }

        // GET: FornecedorController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: FornecedorController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FornecedorController/Create
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

        // GET: FornecedorController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: FornecedorController/Edit/5
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

        // GET: FornecedorController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: FornecedorController/Delete/5
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
    }
}
