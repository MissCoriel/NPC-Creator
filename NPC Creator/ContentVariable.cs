using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace NPC_Creator
{
    class ContentVariable
    {
        public string Format { get; set; }
        public PatchVariable[] Changes { get; set; }
    }
}
