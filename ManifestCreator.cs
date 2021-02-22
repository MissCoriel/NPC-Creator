using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace NPC_Creator
{
    public partial class manifestCreator : Form
    {
        private string systemName;
        public manifestCreator()
        {
            InitializeComponent();
            Load += ManifestCreator_Load;
        }

        
        private void ManifestCreator_Load(object sender, EventArgs e)
        {
            systemName = Form1.exportSystem;
        }
        private void Button1_Click(object sender, EventArgs e)
        {

            ManifestModel portManifest = new ManifestModel
            {
                Name = $"{modName.Text}",
                Author = $"{modAuthor.Text}",
                Description = $"{modDescription.Text}-=Created By MissCoriel's NPC Creator=-",
                UniqueID = $"{uniqueID.Text}",
                Version = $"{majorVersion.Value}.{minorVersion.Value}.{bugFix.Value}",
                ContentPackFor = new Dictionary<string, string>
                {
                    ["UniqueID"] = "Pathoschild.ContentPatcher"
                },
                UpdateKeys = new List<string>
                {
                    "Nexus: "
                }
            };
            string path = Path.Combine($"Export/[CP]{systemName}", "manifest.json");
            File.WriteAllText(path, JsonConvert.SerializeObject(portManifest, Formatting.Indented));
            MessageBox.Show("Manifest Created!","Manifest.json Created", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();

        }

    }
}
