using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiWeb
{
    public class Startup : Controller
    {
        // GET: Starttop
        public ActionResult Index()
        {
            return View();
        }

        // GET: Starttop/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Starttop/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Starttop/Create
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

        // GET: Starttop/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Starttop/Edit/5
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

        // GET: Starttop/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Starttop/Delete/5
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
