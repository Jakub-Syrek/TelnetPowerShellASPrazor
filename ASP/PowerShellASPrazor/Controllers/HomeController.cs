using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Management.Automation;
using System.Management.Automation.Runspaces;
using System.Text;
using System.Web.Mvc;
using PowerShellASPrazor.Models;
using System.Threading.Tasks;

namespace PowerShellASPrazor.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Test(string? IP1 ,  string? SOURCEIP1 , string? PORT1)
        {
            
            List<Results> resultsList = new List<Results>();

            if (IP1.Contains(';'))
            {
                int size = IP1.Count(f => f == ';');
                string[] listaIP = new string[size];
                string[] listaPORT = new string[size+1];
                listaIP = IP1.ToString().Split(';');
                listaPORT = PORT1.ToString().Split(';');
                Parallel.For(0, listaIP.Length,
                    index =>
                    {
                        var shell1 = PowerShell.Create();
                        shell1.AddScript($"Test-NetConnection -ComputerName {listaIP[index]} -Port {listaPORT[index]} | out-string");
                        var results1 = shell1.Invoke();
                        var resultsSplitted = results1[0].ToString().Split(':');
                        PowerShellASPrazor.Models.Results res1 = new Results();
                        res1.ComputerName = resultsSplitted[1].ToString().Replace("\r\nRemoteAddress", "");
                        res1.RemoteAddress = resultsSplitted[2].ToString().Replace("\r\nRemotePort", "");
                        res1.RemotePort = resultsSplitted[3].ToString().Replace("\r\nInterfaceAlias", "");
                        res1.InterfaceAlias = resultsSplitted[4].ToString().Replace("\r\nSourceAddress", "");
                        res1.SourceAddress = resultsSplitted[5].ToString().Replace("\r\nTcpTestSucceeded", "");
                        res1.SourceAddress = resultsSplitted[5].ToString().Replace("\r\nPingSucceeded", "");
                        
                        res1.TcpTestSucceeded = resultsSplitted[6].ToString().Replace("\r\n\r\n\r\n\r\n", "");
                        resultsList.Add(res1);
                    });
            }
            else
            {
                var shell = PowerShell.Create();
                shell.AddScript($"Test-NetConnection  -ComputerName {IP1} -Port {PORT1} | out-string");
                PowerShellASPrazor.Models.Results res = new Results();
                var results = shell.Invoke();
                if (results.Count > 0)
                {
                    var resultsSplitted = results[0].ToString().Split(':');
                    var builder = new StringBuilder();
                    foreach (var psObject in results)
                    {

                        builder.Append(psObject.BaseObject.ToString() + "\r\n");
                    }
                    res.ResultsString = Server.HtmlEncode(builder.ToString());


                    res.ComputerName = resultsSplitted[1].ToString().Replace("\r\nRemoteAddress", "");
                    res.RemoteAddress = resultsSplitted[2].ToString().Replace("\r\nRemotePort", "");
                    res.RemotePort = resultsSplitted[3].ToString().Replace("\r\nInterfaceAlias", "");
                    res.InterfaceAlias = resultsSplitted[4].ToString().Replace("\r\nSourceAddress", "");
                    res.SourceAddress = resultsSplitted[5].ToString().Replace("\r\nTcpTestSucceeded", "");
                    res.TcpTestSucceeded = resultsSplitted[6].ToString().Replace("\r\n\r\n\r\n\r\n", "");




                }
                resultsList.Add(res);
            }
            //return Content(res.ResultsString);
           return View("Test", resultsList);
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}