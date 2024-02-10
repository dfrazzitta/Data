using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Text;
using System.Web;

namespace Demo.Controllers
{
    public class YamlController : Controller
    {
        private readonly IWebHostEnvironment _hostingEnvironment;
        public YamlController (IWebHostEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;

        }

        public string TextToHtml(string text)
        {
            text = HttpUtility.HtmlEncode(text);
            text = text.Replace("\r\n", "\r");
            text = text.Replace("\n", "\r");
            text = text.Replace("\r", "<br>\r\n");
            text = text.Replace("  ", " &nbsp;");
            return text;
        }



        public string Config(string jsonInput, string filename)
        {
            string htmlFilePath = Path.Combine(_hostingEnvironment.WebRootPath, "yamls/" + jsonInput + "/" + filename + ".yaml");
            ProcessStartInfo startInfo = new ProcessStartInfo(@"c:\notepad++\notepad++.exe");
            startInfo.WindowStyle = ProcessWindowStyle.Normal;
            startInfo.Arguments = htmlFilePath;
            Process p  = Process.Start(startInfo);
           // p.MainWindowHandle;
            return ""; // sb.ToString(); ;
        }



        // GET: YamlController
        public ActionResult Index()
        {
            return View();
        }

        // GET: YamlController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: YamlController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: YamlController/Create
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

        // GET: YamlController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: YamlController/Edit/5
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

        // GET: YamlController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: YamlController/Delete/5
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
