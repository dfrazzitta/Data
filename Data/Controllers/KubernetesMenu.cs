using Demo.Data;
using Demo.SchoolModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace Demo.Controllers
{
    public class KubernetesMenu : Controller
    {
        private readonly SchoolContext _context;


        public KubernetesMenu(SchoolContext context)
        {
            _context = context;
        }


        public IActionResult GetGridWeb() // Task<ActionResult<IEnumerable<object>>> Grid()
        //public async IEnumerable<object> Grid()
        {
            // var rtn =  await _context.Students.ToListAsync();
            return View(); // rtn);
        }

        public IActionResult ClusterInfo()
        {
            return View();
        }
        // GET: kubernetes
        public ActionResult Index()
        {
            return View();
        }

        // GET: kubernetes/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: kubernetes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: kubernetes/Create
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

        // GET: kubernetes/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: kubernetes/Edit/5
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

        // GET: kubernetes/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: kubernetes/Delete/5
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
