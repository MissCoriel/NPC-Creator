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
    public partial class Event_Studio : Form
    {
        private string systemName;
        public Dictionary<string, string> eventData = new Dictionary<string, string>();
        public Event_Studio()
        {
            InitializeComponent();
        }

        private void Event_Studio_Load(object sender, EventArgs e)
        {

        }
        public void addEventtoList(string key, string value)
        {
            //Raw Data for Saving
            eventData.Add(key, value);
            //Convert
            string data = $"{key}: {value}";
            eventFileData.Items.Add(data);
        }

        private void newEvent_Click(object sender, EventArgs e)
        {
            Conditions frRem = new Conditions();
            frRem.Text = "Create Event File";
            frRem.ShowDialog();
        }

        private void saveEventFile_Click(object sender, EventArgs e)
        {
            MessageBox.Show("While you have the freedom to save the file with any name, be aware that NPCCreator requires the file to be named after the map in which the events take place.", "Shop Smart, Shop S-Mart", MessageBoxButtons.OK, MessageBoxIcon.Information);
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.InitialDirectory = Environment.CurrentDirectory;
            saveFile.Title = "Save Event File";
            saveFile.CheckPathExists = true;
            saveFile.DefaultExt = "json";
            saveFile.Filter = "json files (*.json)|*.json";
            saveFile.FilterIndex = 1;
            saveFile.RestoreDirectory = true;
            if(saveFile.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFile.FileName, JsonConvert.SerializeObject(eventData, new JsonSerializerSettings { Formatting = Formatting.Indented }));
                MessageBox.Show($"Saved File {saveFile.FileName}", "Save Successful!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}
