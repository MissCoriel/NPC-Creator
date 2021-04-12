using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPC_Creator
{
    class DispoModel
    {
        public string npcsysName { get; set; }
        public string npcstrName { get; set; }
        public string projName { get; set; }
        public string npcrelText { get; set; }
        public string npclovInt { get; set; }
        public bool npcCanDate { get; set; }
        public string lstAge { get; set; }
        public string lstPerMan { get; set; }
        public string lstPerOpt { get; set; }
        public string lstPerSoc { get; set; }
        public string lstGender { get; set; }
        public string lstMapSpawn { get; set; }
        public string lstBdaySeas { get; set; }
        public string lstOrigin { get; set; }
        public int varMapX { get; set; }
        public int varMapY { get; set; }
        public int varBday { get; set; }
        public string altNPCName { get; set; }
        public string altMaparea { get; set; }
        public int varAltMapX { get; set; }
        public int varAltMapY { get; set; }
        public bool altCanDate { get; set; }
        public bool pregRoleFlag { get; set; }
        public string npcPregRolesave { get; set; }
        public string altPregRole { get; set; }
        public bool enabledAltDispo { get; set; }

    }
}
