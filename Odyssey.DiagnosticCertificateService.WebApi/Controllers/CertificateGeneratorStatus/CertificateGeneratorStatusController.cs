using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Odyssey.DiagnosticCertificateService.WebApi.Controllers.CertificateGeneratorStatus
{
    public class CertificateGeneratorStatusController : Controller
    {
        // GET: CertificateGeneratorController
        public ActionResult Index()
        {
            return View();
        }

        // GET: CertificateGeneratorController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CertificateGeneratorController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CertificateGeneratorController/Create
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

        // GET: CertificateGeneratorController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CertificateGeneratorController/Edit/5
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

        // GET: CertificateGeneratorController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CertificateGeneratorController/Delete/5
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
