using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace NPC_Creator
{
    class PatchVariable
    {
        public string LogName { get; set; }
        public string Action { get; set; }
        public string Target { get; set; }
        public string FromFile { get; set; }
        public IDictionary<string, string> When { get; set; }
       

        public IDictionary<string, string> Entries { get; set; }


    }
}
