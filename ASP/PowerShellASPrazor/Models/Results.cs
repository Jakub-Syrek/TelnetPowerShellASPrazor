using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PowerShellASPrazor.Models
{
    public class Results
    {
        public string ResultsString {get;set;}

        public string ComputerName { get; set; }
        public string RemoteAddress { get; set; }
        public string RemotePort { get; set; }
        public string InterfaceAlias { get; set; }
        public string SourceAddress { get; set; }
        public string TcpTestSucceeded { get; set; }

    }
}