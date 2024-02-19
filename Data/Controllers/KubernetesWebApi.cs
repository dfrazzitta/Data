using Demo.Data;
using Demo.Models;
using Demo.SchoolModels;
using k8s;
using k8s.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Runtime.InteropServices;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Demo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KubernetesWebApi : ControllerBase
    {
        private readonly SchoolContext _context;

        public KubernetesWebApi(SchoolContext context)
        {
            _context = context;
        }

        [HttpGet("[action]")]
        public string GetCustomers11()
        {
            var students = from s in _context.Customers
                           select s;
            string jsonString = JsonConvert.SerializeObject(students as IEnumerable<Student>);
            return jsonString;

        }




        [HttpGet("[action]")]
        public string getStudents1()
        {
            var students = from s in _context.Students
                           select s;
            string jsonString = JsonConvert.SerializeObject(students as IEnumerable<Student>);
            return jsonString;

        }



        [HttpGet("[action]")]  // There are HttpGet, HttpPost, HttpPut, HttpDelete.
        public V1ComponentStatusList component(string jsonInput) //[FromBody] kubeParams value) //string jsonInput)
        {
            var b = RuntimeInformation.IsOSPlatform(OSPlatform.Windows);
            if (b)
            {
                // var k8SClientConfig = KubernetesClientConfiguration.BuildConfigFromConfigFile("/app/config");
                var k8SClientConfig = KubernetesClientConfiguration.BuildConfigFromConfigFile("C:\\a\\Demo\\Demo\\config");
                IKubernetes client = new Kubernetes(k8SClientConfig);
                var list = client.CoreV1.ListComponentStatus( ); //.kubenamespace); //.ListNamespace();
                return list;
            }
            else
            {
                var k8SClientConfig = KubernetesClientConfiguration.BuildConfigFromConfigFile("/app/config");
                IKubernetes client = new Kubernetes(k8SClientConfig);
                
                var list = client.CoreV1.ListComponentStatus( ); //.kubenamespace); //.ListNamespace();
                return list;
            }
        }
 
        [HttpGet("[action]")]  // There are HttpGet, HttpPost, HttpPut, HttpDelete.
        public V1SecretList Secrets(string jsonInput) //[FromBody] kubeParams value) //string jsonInput)
        {
              

            var b = RuntimeInformation.IsOSPlatform(OSPlatform.Windows);
            if (b)
            {
                // var k8SClientConfig = KubernetesClientConfiguration.BuildConfigFromConfigFile("/app/config");
                var k8SClientConfig = KubernetesClientConfiguration.BuildConfigFromConfigFile("C:\\a\\Demo\\Demo\\config");
                IKubernetes client = new Kubernetes(k8SClientConfig);
                var list = client.CoreV1.ListNamespacedSecret(jsonInput); //.kubenamespace); //.ListNamespace();
                return list;
            }
            else
            {
                var k8SClientConfig = KubernetesClientConfiguration.BuildConfigFromConfigFile("/app/config");
                IKubernetes client = new Kubernetes(k8SClientConfig);
                var list = client.CoreV1.ListNamespacedSecret(jsonInput); //.kubenamespace); //.ListNamespace();
                return list;
            }
        }

        [HttpGet("[action]")]  // There are HttpGet, HttpPost, HttpPut, HttpDelete.
        public V1ConfigMapList Config(string jsonInput) //[FromBody] kubeParams value) //string jsonInput)
        {
            var b = RuntimeInformation.IsOSPlatform(OSPlatform.Windows);
            if (b)
            {
                // var k8SClientConfig = KubernetesClientConfiguration.BuildConfigFromConfigFile("/app/config");
                var k8SClientConfig = KubernetesClientConfiguration.BuildConfigFromConfigFile("C:\\a\\Demo\\Demo\\config");
                IKubernetes client = new Kubernetes(k8SClientConfig);
                var list = client.CoreV1.ListNamespacedConfigMap(jsonInput); //.kubenamespace); //.ListNamespace();
                return list;
            }
            else
            {
                var k8SClientConfig = KubernetesClientConfiguration.BuildConfigFromConfigFile("/app/config");
                IKubernetes client = new Kubernetes(k8SClientConfig);
                var list = client.CoreV1.ListNamespacedConfigMap(jsonInput); //.kubenamespace); //.ListNamespace();
                return list;
            }
 
        }

        [HttpGet("[action]")]  // There are HttpGet, HttpPost, HttpPut, HttpDelete.
        public V1ServiceList Service(string jsonInput) //[FromBody] kubeParams value) //string jsonInput)
        {
            var b = RuntimeInformation.IsOSPlatform(OSPlatform.Windows);
            if (b)
            {
                // var k8SClientConfig = KubernetesClientConfiguration.BuildConfigFromConfigFile("/app/config");
                var k8SClientConfig = KubernetesClientConfiguration.BuildConfigFromConfigFile("C:\\a\\Demo\\Demo\\config");
                IKubernetes client = new Kubernetes(k8SClientConfig);
                var list = client.CoreV1.ListNamespacedService(jsonInput); //.kubenamespace); //.ListNamespace();
                return list;
            }
            else
            {
                var k8SClientConfig = KubernetesClientConfiguration.BuildConfigFromConfigFile("/app/config");
                IKubernetes client = new Kubernetes(k8SClientConfig);
                var list = client.CoreV1.ListNamespacedService(jsonInput); //.kubenamespace); //.ListNamespace();
                return list;
            }
 
        }



        [HttpGet("[action]")]  // There are HttpGet, HttpPost, HttpPut, HttpDelete.
        public V1PodList Pods(string jsonInput) //[FromBody] kubeParams value) //string jsonInput)
        {

            var b = RuntimeInformation.IsOSPlatform(OSPlatform.Windows);
            if (b)
            {
                // var k8SClientConfig = KubernetesClientConfiguration.BuildConfigFromConfigFile("/app/config");
                var k8SClientConfig = KubernetesClientConfiguration.BuildConfigFromConfigFile("C:\\a\\Demo\\Demo\\config");
                IKubernetes client = new Kubernetes(k8SClientConfig);
                var list = client.CoreV1.ListNamespacedPod(jsonInput); //.kubenamespace); //.ListNamespace();
                return list;
            }
            else
            {
                var k8SClientConfig = KubernetesClientConfiguration.BuildConfigFromConfigFile("/app/config");
                IKubernetes client = new Kubernetes(k8SClientConfig);
                var list = client.CoreV1.ListNamespacedPod(jsonInput); //.kubenamespace); //.ListNamespace();
                return list;
            }
  
        }

        [HttpGet("[action]")]  // There are HttpGet, HttpPost, HttpPut, HttpDelete.
        public V1NamespaceList Namespaces() //[FromBody] kubeParams value) //string jsonInput)
        {
            var b = RuntimeInformation.IsOSPlatform(OSPlatform.Windows);
            if (b)
            {
                // var k8SClientConfig = KubernetesClientConfiguration.BuildConfigFromConfigFile("/app/config");
                var k8SClientConfig = KubernetesClientConfiguration.BuildConfigFromConfigFile("C:\\a\\Demo\\Demo\\config");
                IKubernetes client = new Kubernetes(k8SClientConfig);
                var list = client.CoreV1.ListNamespace( ); //.kubenamespace); //.ListNamespace();
                return list;
            }
            else
            {
                var k8SClientConfig = KubernetesClientConfiguration.BuildConfigFromConfigFile("/app/config");
                IKubernetes client = new Kubernetes(k8SClientConfig);
                var list = client.CoreV1.ListNamespace( ); //.kubenamespace); //.ListNamespace();
                return list;
            }

        }

        // GET: api/<KubernetesController>  
        [HttpGet]
        public string GetHelp()
        {
            JArray array = new JArray();
            array.Add("Manual text");
            array.Add(new DateTime(2000, 5, 23));

            JObject o = new JObject();
            o["MyArray"] = array;
            return "";
        }


        // GET: api/<KubernetesController>  
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<KubernetesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<KubernetesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<KubernetesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<KubernetesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
