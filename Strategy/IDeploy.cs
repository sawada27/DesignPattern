using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Strategy
{
    public abstract class DeployTask
    {
        public string ApplicationName { get; set; }

        public string ApplicationVersion { get; set; }

        public string Type { get; set; }

        public string[] Servers { get; set; }

        public virtual void GetServers(string cluster)
        {



            Servers = new string[0];
        }


    }


    public class DeployTaskFromDI : DeployTask
    {

        public override void GetServers(string cluster)
        {
            
            Servers = new string[0];
        }

    }


    public interface IDeployer
    {

        Task Deploy(DeployTask application, string environment, Uri callBackUrl, string cluster = null);

        Task Rollback(DeployTask application, string environment, Uri callBackUrl, int deployAppId, string cluster = null);

        string DeployIdentify { get; set; }
    }

    public class ServerDeployer : IDeployer
    {


        public string DeployIdentify { get; set ; }

        public Task Deploy(DeployTask application, string environment, Uri callBackUrl, string cluster = null)
        {
            Console.WriteLine($"部署应用{application.ApplicationName}在[{environment}]");



            return Task.CompletedTask;
        }

        public Task Rollback(DeployTask application, string environment, Uri callBackUrl, int deployAppId, string cluster = null)
        {
            throw new NotImplementedException();
        }

        //private readonly ServerClient _serverClient;
     

        //调用部署最大重试次数
        private int serverDeployMaxRetry;
        //部署后检查服务器状态最大重试次数 
        private int getServerMaxRetry;
        //检查服务器状态间隔时间 配合检查服务器状态重试次数确定部署
        private TimeSpan checkServerStatusPeriod;
        //每次调用部署接口间隔时间
        private TimeSpan serverDeployPeriod;
        //新框架应用服务器数据源  区分ServerCenter 和 Resource
        private string nebulaServersSource;

        public ServerDeployer()
        {
            DeployIdentify = "ServerCenter";
        }

    }

    public class BlueKingDeployer : IDeployer
    {


        public string DeployIdentify { get ; set; }

        public Task Deploy(DeployTask application, string environment, Uri callBackUrl, string cluster = null)
        {
            Console.WriteLine($"通过蓝鲸部署应用{application.ApplicationName}在[{environment}]");



            return Task.CompletedTask;
        }

        public Task Rollback(DeployTask application, string environment, Uri callBackUrl, int deployAppId, string cluster = null)
        {
            throw new NotImplementedException();
        }

        //private readonly ServerClient _serverClient;


        //调用部署最大重试次数
        private int serverDeployMaxRetry;

        //部署后检查服务器状态最大重试次数 
        private int getServerMaxRetry;

        //检查服务器状态间隔时间 配合检查服务器状态重试次数确定部署
        private TimeSpan checkServerStatusPeriod;

        //每次调用部署接口间隔时间
        private TimeSpan serverDeployPeriod;

        //新框架应用服务器数据源  区分ServerCenter 和 Resource
        private string nebulaServersSource;

        public BlueKingDeployer()
        {
            DeployIdentify = "BlueKing";
        }

    }



 

}
