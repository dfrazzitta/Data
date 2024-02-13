using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;
using System.Web;
using System.Xml;

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
            var b = RuntimeInformation.IsOSPlatform(OSPlatform.Windows);
            if (b)
            {
                string htmlFilePath = Path.Combine(_hostingEnvironment.WebRootPath, "yamls/" + jsonInput + "/" + filename + ".yaml");
                ProcessStartInfo startInfo = new ProcessStartInfo(@"c:\notepad++\notepad++.exe");
                startInfo.WindowStyle = ProcessWindowStyle.Normal;
                startInfo.Arguments = htmlFilePath;
                Process p = Process.Start(startInfo);
                return "";
            }
            else
            {
                 
                var serverPath = _hostingEnvironment.WebRootPath + "\\yamls\\" + jsonInput + "\\" + filename + ".yaml";
                var fileContents = System.IO.File.ReadAllText(_hostingEnvironment.WebRootPath + "\\yamls\\" + jsonInput + "\\" + filename + ".yaml");
                int ct = fileContents.Split('\n').Length * 25;

                JArray array = new JArray();
                JValue text = new JValue(ct.ToString());
                JValue date = new JValue(fileContents);

                array.Add(text);
                array.Add(date);

                return array.ToString(); // fileContents;
               // string htmlFilePath = Path.Combine(_hostingEnvironment.WebRootPath, "yamls/" + jsonInput + "/" + filename + ".yaml");
               // ProcessStartInfo startInfo = new ProcessStartInfo(@"gedit");
              //  startInfo.WindowStyle = ProcessWindowStyle.Normal;
              //  startInfo.Arguments = htmlFilePath;
              //  Process p = Process.Start(startInfo);

            }
           // p.MainWindowHandle;
          //   return ""; // sb.ToString(); ;
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
