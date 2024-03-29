﻿using Bogus;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Net;
using System.Text;

namespace Demo.Controllers
{
    public class MongoController : Controller
    {
        private readonly ILogger<MongoController> _logger;
        private IConfiguration _configuration;
        public MongoClient Client { get; set; }

        public MongoController(ILogger<MongoController> logger, IConfiguration configuration)
        {
            _logger = logger;
            _configuration = configuration;
        }

        // GET: MongoController
        public async Task<ActionResult> Index()
        {
            // var Client = new MongoClient(_configuration.GetValue<string>("MongoConnection"));
            _logger.Log(LogLevel.Information, "be4 the client");
            Client = new MongoClient("root:example@db:27017");
            _logger.Log(LogLevel.Information, "after the client");
            _logger.Log(LogLevel.Information, Client.Settings.ReplicaSetName);
            var rs = Client.Settings.ReplicaSetName;

            var databases = await Client.ListDatabasesAsync();
            StringBuilder sb = new StringBuilder();

            while (databases.MoveNext())
            {
                var currentBatch = databases.Current;

                foreach (BsonDocument s in currentBatch)
                    sb.Append(s.ToString() + "   ");

            }
            ViewData["goodcall"] = sb.ToString(); //.AddressList[0];
            ViewData["rsname"] = rs;

            /*
            IPHostEntry hostInfo1 = Dns.GetHostEntry("www.microsoft.com");
            try
            {
               IPHostEntry hostInfo = Dns.GetHostEntry("mongodb-replica-0.mongo.svc.cluster.local");
                ViewData["goodcall"] = hostInfo.AddressList[0];
            }
            catch {
                ViewData["failedcall"] = rs;
            }
            */

            return View();
        }

        public void Connect()
        {

            var server = new MongoServerAddress(host: "172.16.0.14", port: 27017);
            //var server = new MongoServerAddress(host: "localhost", port: 27014);
            var credentials = MongoCredential.CreateCredential(
                databaseName: "admin",
                username: "test",
                password: "test"
            );
            var mongodbClientSettings = new MongoClientSettings
            {
                Credential = credentials,
                Server = server,
                //ConnectionMode = ConnectionMode.Standalone,
                ServerSelectionTimeout = TimeSpan.FromSeconds(3)
            };

            Client = new MongoClient("mongodb://mongodb:27017"); // mongodbClientSettings);

            var database = Client.GetDatabase("EventSampleApiDB");
            // Client.DropDatabase(database);

            var databases = Client.ListDatabases();
            while (databases.MoveNext())
            {
                _logger.Log(LogLevel.Information, databases.Current.ToString());
                var currentBatch = databases.Current;

            }
            // var collection = database.GetCollection<T>(typeof(T).Name);
            /*
            _logger.Log(LogLevel.Information, "be4 the client");
            Client = new MongoClient("mongodb://localhost:27017");
            _logger.Log(LogLevel.Information, "after the client");
            _logger.Log(LogLevel.Information, Client.Settings.ReplicaSetName);
            var rs = Client.Settings.ReplicaSetName;
            */

            //  ViewData["goodcall"] = sb.ToString(); //.AddressList[0];
            // ViewData["rsname"] = rs;
        }



        // GET: MongoController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MongoController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MongoController/Create
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

        // GET: MongoController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MongoController/Edit/5
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

        // GET: MongoController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MongoController/Delete/5
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
