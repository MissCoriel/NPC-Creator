using System;
using System.Collections;
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
    public partial class StartEventingWindow : Form
    {
        List<string> actorCast = new List<string>();
        List<string> actorsRaw = new List<string>();
        public bool farmerPresent;
        public StartEventingWindow()
        {
            InitializeComponent();
        }

        private void StartEventingWindow_Load(object sender, EventArgs e)
        {
            ClearTempFiles();
            //Load Music IDs
            musicID.Items.Add("continue");
            musicID.Items.Add("none");
            musicID.Items.AddRange(File.ReadAllLines(Environment.CurrentDirectory + "\\Common Data\\MusicList.txt"));
            //Load NPCs
            npcList.Items.Add("farmer");
            npcList.Items.AddRange(File.ReadAllLines(Environment.CurrentDirectory + "\\Common Data\\NPCNames.txt"));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Check for Farmer
            ScanForFarmer();
            if (!string.IsNullOrWhiteSpace(musicID.Text) && actorList.Items.Count > 0 && farmerPresent == true)
            {
                Conditions mw = (Conditions)Application.OpenForms["Conditions"];
                //Add Music
                mw.addCommandtoList(musicID.Text);
                //Add Viewport
                mw.addCommandtoList($"{viewportX.Value} {viewportY.Value}");
                //check for temporary folder
                if (!Directory.Exists(Environment.CurrentDirectory + "\\Save Data\\TempEventInformation"))
                {
                    Directory.CreateDirectory(Environment.CurrentDirectory + "\\Save Data\\TempEventInformation");
                }
                //Add Actors
                foreach (var actor in actorList.Items)
                {
                    string entry = actor.ToString();                    
                    actorCast.Add(entry);

                }
                //create temp file to isolate the actor names
                string[] castingList = actorsRaw.ToArray();
                File.WriteAllLines(Environment.CurrentDirectory + "\\Save Data\\TempEventInformation\\tempEventActorData.txt", castingList);
                //Create Initial Commands
                string parse = string.Join(" ", actorCast);
                mw.addCommandtoList(parse);
                if(skippableEvent.Checked == true)
                {
                    mw.addCommandtoList("skippable");
                }
                this.Close();


            }
            else
            {
                if (farmerPresent == false)
                {
                    MessageBox.Show("Farmer has not been added as an actor.\nAll events need the farmer even if not used.", "Need that Farmer.", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    MessageBox.Show("Missing Data!\nAll fields must be complete!");

                }
            }

        }
        public void ScanForFarmer()
        {
            IEnumerable items = actorList.Items;
            
            foreach( var item in items)
            {
                string actor = item as string;
                if (actor.Contains("farmer"))
                {
                    farmerPresent = true;
                }
            }
        }

        private void addActor_Click(object sender, EventArgs e)
        {
            string parse = $"{npcList.Text} {startX.Value} {startY.Value} {startFacing.Value}";
            actorList.Items.Add(parse);
            actorsRaw.Add(npcList.Text);
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            actorsRaw.Remove(actorList.SelectedItem.ToString());
            actorList.Items.Remove(actorList.SelectedItem);
        }

        private void ClearAll_Click(object sender, EventArgs e)
        {
            actorsRaw.Clear();
            actorList.Items.Clear();
        }
        public void ClearTempFiles()
        {
            if(Directory.Exists(Environment.CurrentDirectory + "\\Save Data\\TempEventInformation"))
            {
                if (File.Exists(Environment.CurrentDirectory + "\\Save Data\\TempEventInformation\\tempEventActorData.txt"))
                {
                    File.Delete(Environment.CurrentDirectory + "\\Save Data\\TempEventInformation\\tempEventActorData.txt");
                }
            }
        }
    }
}
