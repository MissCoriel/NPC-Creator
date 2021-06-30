using Newtonsoft.Json;
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

namespace NPC_Creator
{
    public partial class AddToFestival : Form
    {
        public string systemName = Form1.exportSystem;
        public string festivalFile;
        private PatchVariable[] dialogPatch;
        public AddToFestival()
        {
            InitializeComponent();
        }

        private void AddToFestival_Load(object sender, EventArgs e)
        {
            if (File.Exists(Environment.CurrentDirectory + $"\\Save Data\\{systemName}_saveData\\canDate.date"))
            {
                marriedDialog.Enabled = true;
            }
            if (!File.Exists(Environment.CurrentDirectory + $"\\Save Data\\{systemName}_saveData\\canDate.date"))
            {
                marriedDialog.Enabled = false;
            }
            Directory.CreateDirectory(Environment.CurrentDirectory + $"\\Export\\[CP]{systemName}\\assets\\Festivals");
            Directory.CreateDirectory(Environment.CurrentDirectory + $"\\Export\\[CP]{systemName}\\assets\\Festivals\\Dialogue");

        }
        private void ParseData()
        {
            if (festivalList.SelectedIndex == 0)
            {
                festivalFile = "spring13";
            }
            if (festivalList.SelectedIndex == 1)
            {
                festivalFile = "spring24";
            }
            if (festivalList.SelectedIndex == 2)
            {
                festivalFile = "summer11";
            }
            if (festivalList.SelectedIndex == 3)
            {
                festivalFile = "summer28";
            }
            if (festivalList.SelectedIndex == 4)
            {
                festivalFile = "fall16";
            }
            if (festivalList.SelectedIndex == 5)
            {
                festivalFile = "fall27";
            }
            if (festivalList.SelectedIndex == 6)
            {
                festivalFile = "winter8";
            }
            if (festivalList.SelectedIndex == 7)
            {
                festivalFile = "winter25";
            }
        }
        private void CreateFestival()
        {
            FestivalModel addFestival = new FestivalModel
            {
                Operation = "Append",
                Target = new string[] { "Entries", "Set-Up_additionalCharacters" },
                Value = $"{systemName} {npcX.Value} {npcY.Value} {npcFacing.SelectedIndex}",
            };
            FestivalModel addFestivalB = new FestivalModel
            {
                Operation = "Append",
                Target = new string[] { "Entries", "MainEvent_additionalCharacters" },
                Value = $"{systemName} {mainX.Value} {mainY.Value} {mainFacing.SelectedIndex}",
            };

            PatchVariable festivalAdd = new PatchVariable
            {
                Action = "EditData",
                Target = $"Data/Festivals/{festivalFile}",
                TextOperations = new FestivalModel[] { addFestival, addFestivalB }
            };
            ContentVariable festivalCreation = new ContentVariable
            {
                Changes = new PatchVariable[] { festivalAdd }
            };
            string path = Environment.CurrentDirectory + $"\\Export\\[CP]{systemName}\\assets\\Festivals\\{festivalFile}.json";
            File.WriteAllText(path, JsonConvert.SerializeObject(festivalCreation, new JsonSerializerSettings { Formatting = Formatting.Indented, NullValueHandling = NullValueHandling.Ignore }));
        }
        private void CreateDialog()
        {
            List<PatchVariable> createPatch = new List<PatchVariable>();
            if(marriedDialog.Enabled == true)
            {
                PatchVariable festivalPatchDialog = new PatchVariable
                {
                    Action = "EditData",
                    Target = $"Data/Festivals/{festivalFile}",
                    Entries = new Dictionary<string, string>
                    {
                        [$"{systemName}"] = normalDialog.Text,
                        [$"{systemName}_spouse"] = marriedDialog.Text,
                    }
                };
                createPatch.Add(festivalPatchDialog);
            }
            if(marriedDialog.Enabled == false)
            {
                PatchVariable festivalPatchDialog = new PatchVariable
                {
                    LogName = $"Dialogue for {festivalFile}",
                    Action = "EditData",
                    Target = $"Data/Festivals/{festivalFile}",
                    Entries = new Dictionary<string, string>
                    {
                        [$"{systemName}"] = normalDialog.Text,
                    }
                };
                createPatch.Add(festivalPatchDialog);
            }
            dialogPatch = createPatch.ToArray();
            ContentVariable dialogFileCreate = new ContentVariable
            {
                Changes = dialogPatch
            };
            string path = Environment.CurrentDirectory + $"\\Export\\[CP]{systemName}\\assets\\Festivals\\Dialogue\\{festivalFile}.json";
            File.WriteAllText(path, JsonConvert.SerializeObject(dialogFileCreate, new JsonSerializerSettings { Formatting = Formatting.Indented, NullValueHandling = NullValueHandling.Ignore }));

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ParseData();
            CreateFestival();
            CreateDialog();
            MessageBox.Show($"{systemName} has been added to {festivalList.Text}!", $"{festivalList.Text} Modified!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            npcX.Value = 0;
            npcY.Value = 0;
            normalDialog.Text = string.Empty;
            marriedDialog.Text = string.Empty;
        }
    }
}
