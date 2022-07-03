using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiWeb.Controllers
{
    public class IvaController : Controller
    {
        // GET: IvaController
        public ActionResult Index()
        {
            return View();
        }

        // GET: IvaController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: IvaController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: IvaController/Create
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

        // GET: IvaController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: IvaController/Edit/5
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

        // GET: IvaController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: IvaController/Delete/5
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
