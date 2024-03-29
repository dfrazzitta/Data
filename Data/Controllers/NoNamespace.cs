﻿using k8s.Models;
using k8s;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.InteropServices;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Demo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NoNamespace : ControllerBase
    {

 
        [HttpGet("[action]")]  // There are HttpGet, HttpPost, HttpPut, HttpDelete.
        public V1ReplicaSetList ReplicaSets(string jsonInput) //[FromBody] kubeParams value) //string jsonInput)
        {

            var b = RuntimeInformation.IsOSPlatform(OSPlatform.Windows);
            if (b)
            {
                // var k8SClientConfig = KubernetesClientConfiguration.BuildConfigFromConfigFile("/app/config");
                var k8SClientConfig = KubernetesClientConfiguration.BuildConfigFromConfigFile("C:\\a\\Demo\\Demo\\config");
                IKubernetes client = new Kubernetes(k8SClientConfig);
                var list = client.AppsV1.ListReplicaSetForAllNamespaces(); //.kubenamespace); //.ListNamespace();
                return list;
            }
            else
            {
                var k8SClientConfig = KubernetesClientConfiguration.BuildConfigFromConfigFile("/app/config");
                IKubernetes client = new Kubernetes(k8SClientConfig);
                var list = client.AppsV1.ListReplicaSetForAllNamespaces();
                return list;
            }
        }
 


        [HttpGet("[action]")]  // There are HttpGet, HttpPost, HttpPut, HttpDelete.
        public V1DeploymentList deploy1(string jsonInput) //[FromBody] kubeParams value) //string jsonInput)
        {

            var b = RuntimeInformation.IsOSPlatform(OSPlatform.Windows);
            if (b)
            {
                // var k8SClientConfig = KubernetesClientConfiguration.BuildConfigFromConfigFile("/app/config");
                var k8SClientConfig = KubernetesClientConfiguration.BuildConfigFromConfigFile("C:\\a\\Demo\\Demo\\config");
                IKubernetes client = new Kubernetes(k8SClientConfig);
                var list = client.AppsV1.ListNamespacedDeployment(jsonInput); //.kubenamespace); //.ListNamespace();
                return list;
            }
            else
            {
                var k8SClientConfig = KubernetesClientConfiguration.BuildConfigFromConfigFile("/app/config");
                IKubernetes client = new Kubernetes(k8SClientConfig);
                var list = client.AppsV1.ListNamespacedDeployment(jsonInput); //.kubenamespace); //.ListNamespace();
                return list;
            }
 
        }



        [HttpGet("[action]")]  // There are HttpGet, HttpPost, HttpPut, HttpDelete.
        public V1DeploymentList deploy(string jsonInput) //[FromBody] kubeParams value) //string jsonInput)
        {
            var b = RuntimeInformation.IsOSPlatform(OSPlatform.Windows);
            if (b)
            {
                // var k8SClientConfig = KubernetesClientConfiguration.BuildConfigFromConfigFile("/app/config");
                var k8SClientConfig = KubernetesClientConfiguration.BuildConfigFromConfigFile("C:\\a\\Demo\\Demo\\config");
                IKubernetes client = new Kubernetes(k8SClientConfig);
                var list = client.AppsV1.ListDeploymentForAllNamespaces(); //.kubenamespace); //.ListNamespace();
                return list;
            }
            else
            {
                var k8SClientConfig = KubernetesClientConfiguration.BuildConfigFromConfigFile("/app/config");
                IKubernetes client = new Kubernetes(k8SClientConfig);
                var list = client.AppsV1.ListDeploymentForAllNamespaces(); //.kubenamespace); //.ListNamespace();
                return list;
            }
         }



        [HttpGet("[action]")]  // There are HttpGet, HttpPost, HttpPut, HttpDelete.
        public V1PodDisruptionBudgetList poddisruptionbudgets(string jsonInput) //[FromBody] kubeParams value) //string jsonInput)
        {
            var b = RuntimeInformation.IsOSPlatform(OSPlatform.Windows);
            if (b)
            {
                // var k8SClientConfig = KubernetesClientConfiguration.BuildConfigFromConfigFile("/app/config");
                var k8SClientConfig = KubernetesClientConfiguration.BuildConfigFromConfigFile("C:\\a\\Demo\\Demo\\config");
                IKubernetes client = new Kubernetes(k8SClientConfig);
                var list = client.PolicyV1.ListPodDisruptionBudgetForAllNamespaces(); //.kubenamespace); //.ListNamespace();
                return list;
            }
            else
            {
                var k8SClientConfig = KubernetesClientConfiguration.BuildConfigFromConfigFile("/app/config");
                IKubernetes client = new Kubernetes(k8SClientConfig);
                var list = client.PolicyV1.ListPodDisruptionBudgetForAllNamespaces(); //.kubenamespace); //.ListNamespace();
                return list;
            }
        }



        [HttpGet("[action]")]  // There are HttpGet, HttpPost, HttpPut, HttpDelete.
        public V1RuntimeClassList runtimeclasses(string jsonInput) //[FromBody] kubeParams value) //string jsonInput)
        {

            var b = RuntimeInformation.IsOSPlatform(OSPlatform.Windows);
            if (b)
            {
                // var k8SClientConfig = KubernetesClientConfiguration.BuildConfigFromConfigFile("/app/config");
                var k8SClientConfig = KubernetesClientConfiguration.BuildConfigFromConfigFile("C:\\a\\Demo\\Demo\\config");
                IKubernetes client = new Kubernetes(k8SClientConfig);
                var list = client.NodeV1.ListRuntimeClass();  //.kubenamespace); //.ListNamespace();
                return list;
            }
            else
            {
                var k8SClientConfig = KubernetesClientConfiguration.BuildConfigFromConfigFile("/app/config");
                IKubernetes client = new Kubernetes(k8SClientConfig);
                var list = client.NodeV1.ListRuntimeClass();  //.kubenamespace); //.ListNamespace();
                return list;
            }
        }




        [HttpGet("[action]")]  // There are HttpGet, HttpPost, HttpPut, HttpDelete.
        public V1ServiceAccountList serviceaccounts(string jsonInput) //[FromBody] kubeParams value) //string jsonInput)
        {
            var b = RuntimeInformation.IsOSPlatform(OSPlatform.Windows);
            if (b)
            {
                // var k8SClientConfig = KubernetesClientConfiguration.BuildConfigFromConfigFile("/app/config");
                var k8SClientConfig = KubernetesClientConfiguration.BuildConfigFromConfigFile("C:\\a\\Demo\\Demo\\config");
                IKubernetes client = new Kubernetes(k8SClientConfig);
                var list = client.CoreV1.ListServiceAccountForAllNamespaces(); //.kubenamespace); //.ListNamespace();
                return list;
            }
            else
            {
                var k8SClientConfig = KubernetesClientConfiguration.BuildConfigFromConfigFile("/app/config");
                IKubernetes client = new Kubernetes(k8SClientConfig);
                var list = client.CoreV1.ListServiceAccountForAllNamespaces(); //.kubenamespace); //.ListNamespace();
                return list;
            }
        }



        [HttpGet("[action]")]  // There are HttpGet, HttpPost, HttpPut, HttpDelete.
        public V1StatefulSetList StateFullSet(string jsonInput) //[FromBody] kubeParams value) //string jsonInput)
        {
            var b = RuntimeInformation.IsOSPlatform(OSPlatform.Windows);
            if (b)
            {
                // var k8SClientConfig = KubernetesClientConfiguration.BuildConfigFromConfigFile("/app/config");
                var k8SClientConfig = KubernetesClientConfiguration.BuildConfigFromConfigFile("C:\\a\\Demo\\Demo\\config");
                IKubernetes client = new Kubernetes(k8SClientConfig);
                var list = client.AppsV1.ListStatefulSetForAllNamespaces(); //.kubenamespace); //.ListNamespace();
                return list;
            }
            else
            {
                var k8SClientConfig = KubernetesClientConfiguration.BuildConfigFromConfigFile("/app/config");
                IKubernetes client = new Kubernetes(k8SClientConfig);
                var list = client.AppsV1.ListStatefulSetForAllNamespaces(); //.kubenamespace); //.ListNamespace();
                return list;
            }
        }

        [HttpGet("[action]")]  // There are HttpGet, HttpPost, HttpPut, HttpDelete.
        public V1CSINodeList CsiNodes(string jsonInput) //[FromBody] kubeParams value) //string jsonInput)
        {
            var b = RuntimeInformation.IsOSPlatform(OSPlatform.Windows);
            if (b)
            {
                // var k8SClientConfig = KubernetesClientConfiguration.BuildConfigFromConfigFile("/app/config");
                var k8SClientConfig = KubernetesClientConfiguration.BuildConfigFromConfigFile("C:\\a\\Demo\\Demo\\config");
                IKubernetes client = new Kubernetes(k8SClientConfig);
                var list = client.StorageV1.ListCSINode(); //.kubenamespace); //.ListNamespace();
                return list;
            }
            else
            {
                var k8SClientConfig = KubernetesClientConfiguration.BuildConfigFromConfigFile("/app/config");
                IKubernetes client = new Kubernetes(k8SClientConfig);
                var list = client.StorageV1.ListCSINode(); //.kubenamespace); //.ListNamespace();
                return list;
            }
        }


        [HttpGet("[action]")]  // There are HttpGet, HttpPost, HttpPut, HttpDelete.
        public V1CSIDriverList CsiDrivers(string jsonInput) //[FromBody] kubeParams value) //string jsonInput)
        {
            var b = RuntimeInformation.IsOSPlatform(OSPlatform.Windows);
            if (b)
            {
                // var k8SClientConfig = KubernetesClientConfiguration.BuildConfigFromConfigFile("/app/config");
                var k8SClientConfig = KubernetesClientConfiguration.BuildConfigFromConfigFile("C:\\a\\Demo\\Demo\\config");
                IKubernetes client = new Kubernetes(k8SClientConfig);
                var list = client.StorageV1.ListCSIDriver(); //.kubenamespace); //.ListNamespace();
                return list;
            }
            else
            {
                var k8SClientConfig = KubernetesClientConfiguration.BuildConfigFromConfigFile("/app/config");
                IKubernetes client = new Kubernetes(k8SClientConfig);
                var list = client.StorageV1.ListCSIDriver(); //.kubenamespace); //.ListNamespace();
                return list;
            }
        }





        [HttpGet("[action]")]  // There are HttpGet, HttpPost, HttpPut, HttpDelete.
        public V1DeploymentList AllDeployments(string jsonInput) //[FromBody] kubeParams value) //string jsonInput)
        {
            var b = RuntimeInformation.IsOSPlatform(OSPlatform.Windows);
            if (b)
            {
                // var k8SClientConfig = KubernetesClientConfiguration.BuildConfigFromConfigFile("/app/config");
                var k8SClientConfig = KubernetesClientConfiguration.BuildConfigFromConfigFile("C:\\a\\Demo\\Demo\\config");
                IKubernetes client = new Kubernetes(k8SClientConfig);
                var list = client.AppsV1.ListDeploymentForAllNamespaces(); //.kubenamespace); //.ListNamespace();
                return list;
            }
            else
            {
                var k8SClientConfig = KubernetesClientConfiguration.BuildConfigFromConfigFile("/app/config");
                IKubernetes client = new Kubernetes(k8SClientConfig);
                var list = client.AppsV1.ListDeploymentForAllNamespaces(); //.kubenamespace); //.ListNamespace();
                return list;
            }
        }
      

        [HttpGet("[action]")]  // There are HttpGet, HttpPost, HttpPut, HttpDelete.
        public V1StorageClassList ProtectedVolume(string jsonInput) //[FromBody] kubeParams value) //string jsonInput)
        {
            var b = RuntimeInformation.IsOSPlatform(OSPlatform.Windows);
            if (b)
            {
                // var k8SClientConfig = KubernetesClientConfiguration.BuildConfigFromConfigFile("/app/config");
                var k8SClientConfig = KubernetesClientConfiguration.BuildConfigFromConfigFile("C:\\a\\Demo\\Demo\\config");
                IKubernetes client = new Kubernetes(k8SClientConfig);
                var list = client.StorageV1.ListStorageClass(); //.kubenamespace); //.ListNamespace();
                return list;
            }
            else
            {
                var k8SClientConfig = KubernetesClientConfiguration.BuildConfigFromConfigFile("/app/config");
                IKubernetes client = new Kubernetes(k8SClientConfig);
                var list = client.StorageV1.ListStorageClass(); //.kubenamespace); //.ListNamespace();
                return list;
            }
        }


        //ResourceQuota

        [HttpGet("[action]")]  // There are HttpGet, HttpPost, HttpPut, HttpDelete.
        public V1EndpointsList EndPoints(string jsonInput) //[FromBody] kubeParams value) //string jsonInput)
        {
            var b = RuntimeInformation.IsOSPlatform(OSPlatform.Windows);
            if (b)
            {
                // var k8SClientConfig = KubernetesClientConfiguration.BuildConfigFromConfigFile("/app/config");
                var k8SClientConfig = KubernetesClientConfiguration.BuildConfigFromConfigFile("C:\\a\\Demo\\Demo\\config");
                IKubernetes client = new Kubernetes(k8SClientConfig);
                var list = client.CoreV1.ListEndpointsForAllNamespaces(); //.kubenamespace); //.ListNamespace();
                return list;
            }
            else
            {
                var k8SClientConfig = KubernetesClientConfiguration.BuildConfigFromConfigFile("/app/config");
                IKubernetes client = new Kubernetes(k8SClientConfig);
                var list = client.CoreV1.ListEndpointsForAllNamespaces(); //.kubenamespace); //.ListNamespace();
                return list;
            }

        }



        [HttpGet("[action]")]  // There are HttpGet, HttpPost, HttpPut, HttpDelete.
        public Eventsv1EventList Events(string jsonInput) //[FromBody] kubeParams value) //string jsonInput)
        {
            var b = RuntimeInformation.IsOSPlatform(OSPlatform.Windows);
            if (b)
            {
                // var k8SClientConfig = KubernetesClientConfiguration.BuildConfigFromConfigFile("/app/config");
                var k8SClientConfig = KubernetesClientConfiguration.BuildConfigFromConfigFile("C:\\a\\Demo\\Demo\\config");
                IKubernetes client = new Kubernetes(k8SClientConfig);
                var list = client.EventsV1.ListEventForAllNamespaces();   //.kubenamespace); //.ListNamespace();
                return list;
            }
            else
            {
                var k8SClientConfig = KubernetesClientConfiguration.BuildConfigFromConfigFile("/app/config");
                IKubernetes client = new Kubernetes(k8SClientConfig);
                var list = client.EventsV1.ListEventForAllNamespaces();   //.kubenamespace); //.ListNamespace();
                return list;
            }
        }




        [HttpGet("[action]")]  // There are HttpGet, HttpPost, HttpPut, HttpDelete.
        public V1DaemonSetList DaemonSets(string jsonInput) //[FromBody] kubeParams value) //string jsonInput)
        {
            var b = RuntimeInformation.IsOSPlatform(OSPlatform.Windows);
            if (b)
            {
                // var k8SClientConfig = KubernetesClientConfiguration.BuildConfigFromConfigFile("/app/config");
                var k8SClientConfig = KubernetesClientConfiguration.BuildConfigFromConfigFile("C:\\a\\Demo\\Demo\\config");
                IKubernetes client = new Kubernetes(k8SClientConfig);
                var list = client.AppsV1.ListDaemonSetForAllNamespaces(); //.kubenamespace); //.ListNamespace();
                return list;
            }
            else
            {
                var k8SClientConfig = KubernetesClientConfiguration.BuildConfigFromConfigFile("/app/config");
                IKubernetes client = new Kubernetes(k8SClientConfig);
                var list = client.AppsV1.ListDaemonSetForAllNamespaces(); //.kubenamespace); //.ListNamespace();
                return list;
            }
        }



        [HttpGet("[action]")]  // There are HttpGet, HttpPost, HttpPut, HttpDelete.
        public V1PriorityClassList PriortyClasses(string jsonInput) //[FromBody] kubeParams value) //string jsonInput)
        {
            var b = RuntimeInformation.IsOSPlatform(OSPlatform.Windows);
            if (b)
            {
                // var k8SClientConfig = KubernetesClientConfiguration.BuildConfigFromConfigFile("/app/config");
                var k8SClientConfig = KubernetesClientConfiguration.BuildConfigFromConfigFile("C:\\a\\Demo\\Demo\\config");
                IKubernetes client = new Kubernetes(k8SClientConfig);
                var list = client.SchedulingV1.ListPriorityClass(); //.kubenamespace); //.ListNamespace();
                return list;
            }
            else
            {
                var k8SClientConfig = KubernetesClientConfiguration.BuildConfigFromConfigFile("/app/config");
                IKubernetes client = new Kubernetes(k8SClientConfig);
                var list = client.SchedulingV1.ListPriorityClass(); //.kubenamespace); //.ListNamespace();
                return list;
            }
        }
  

        [HttpGet("[action]")]  // There are HttpGet, HttpPost, HttpPut, HttpDelete.
        public V1NodeList nodes(string jsonInput) //[FromBody] kubeParams value) //string jsonInput)
        {
            var b = RuntimeInformation.IsOSPlatform(OSPlatform.Windows);
            if (b)
            {
                // var k8SClientConfig = KubernetesClientConfiguration.BuildConfigFromConfigFile("/app/config");
                var k8SClientConfig = KubernetesClientConfiguration.BuildConfigFromConfigFile("C:\\a\\Demo\\Demo\\config");
                IKubernetes client = new Kubernetes(k8SClientConfig);
                var list = client.CoreV1.ListNode(); //.kubenamespace); //.ListNamespace();
                return list;
            }
            else
            {
                var k8SClientConfig = KubernetesClientConfiguration.BuildConfigFromConfigFile("/app/config");
                IKubernetes client = new Kubernetes(k8SClientConfig);
                var list = client.CoreV1.ListNode(); //.kubenamespace); //.ListNamespace();
                return list;
            }
        }



        [HttpGet("[action]")]  // There are HttpGet, HttpPost, HttpPut, HttpDelete.
        public V1ComponentStatusList component1(string jsonInput) //[FromBody] kubeParams value) //string jsonInput)
        {
            var b = RuntimeInformation.IsOSPlatform(OSPlatform.Windows);
            if (b)
            {
                // var k8SClientConfig = KubernetesClientConfiguration.BuildConfigFromConfigFile("/app/config");
                var k8SClientConfig = KubernetesClientConfiguration.BuildConfigFromConfigFile("C:\\a\\Demo\\Demo\\config");
                IKubernetes client = new Kubernetes(k8SClientConfig);
                var list = client.CoreV1.ListComponentStatus(); //.kubenamespace); //.ListNamespace();
                return list;
            }
            else
            {
                var k8SClientConfig = KubernetesClientConfiguration.BuildConfigFromConfigFile("/app/config");
                IKubernetes client = new Kubernetes(k8SClientConfig);
                var list = client.CoreV1.ListComponentStatus(); //.kubenamespace); //.ListNamespace();
                return list;
            }
        }










        // GET: api/<NoNamespace>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<NoNamespace>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<NoNamespace>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<NoNamespace>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<NoNamespace>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
