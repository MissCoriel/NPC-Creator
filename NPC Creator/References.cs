using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPC_Creator
{
    class References
    {
        //public bool marriageable { get; set; }
        public Dictionary<string, string> dialogLibrary { get; set; } = new Dictionary<string, string>();
        public Dictionary<string, string> dialogMarriageLibrary { get; set; } = new Dictionary<string, string>();
        public string projectSystemName { get; set; }
    }
}
