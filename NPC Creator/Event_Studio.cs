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
        public void pasteEventtoList(string data)
        {
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
            Dictionary<string, string> saveEvents = new Dictionary<string, string>();
            List<string> BackupEventFile = new List<string>();
            if(Directory.Exists(Environment.CurrentDirectory + "\\Save Data\\EventBackups"))
            {
                Directory.CreateDirectory($"Save Data/EventBackups");
            }
            foreach (string item in eventFileData.Items)
            {
                BackupEventFile.Add(item);
                string keys = item.Substring(0, item.IndexOf(':'));
                string values = item.Substring(item.IndexOf(':') + 2); // +2 to get past the : and space
                saveEvents.Add(keys, values);
            }
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
                string backup = Environment.CurrentDirectory + "\\Save Data\\EventBackups\\" + Path.GetFileNameWithoutExtension(saveFile.FileName) + "_" + DateTime.Now.ToString("yyyy-MM-dd-hh-mm-ss tt") + ".json";
                //Create File for inclusion
                PatchVariable eventCreate = new PatchVariable
                {
                    Action = "EditData",
                    Target = "Data/Events/" + Path.GetFileNameWithoutExtension(saveFile.FileName),
                    Entries = saveEvents
                };
                //Create everything
                ContentVariable eventFile = new ContentVariable
                {
                    Changes = new PatchVariable[] {eventCreate}
                };
                File.WriteAllText(backup, JsonConvert.SerializeObject(eventFile, new JsonSerializerSettings { Formatting = Formatting.Indented }));

                File.WriteAllText(saveFile.FileName, JsonConvert.SerializeObject(eventFile, new JsonSerializerSettings { Formatting = Formatting.Indented, NullValueHandling = NullValueHandling.Ignore }));
                MessageBox.Show($"Saved File {saveFile.FileName}!\nA back up was saved in Save Data", "Save Successful!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void PasteEvent_Click(object sender, EventArgs e)
        {
            PasteEvent frRem = new PasteEvent();
            frRem.Text = "Paste Event";
            frRem.ShowDialog();
        }
        private void ParseEvent()
        {
            //Divide Event to Key and Value
            string conditions = eventFileData.SelectedItem.ToString().Substring(0, eventFileData.SelectedItem.ToString().IndexOf(':'));
            string commands = eventFileData.SelectedItem.ToString().Substring(eventFileData.SelectedItem.ToString().IndexOf(':') + 2); // +2 to get past the : and space
            //Fix the strings
            conditions = conditions.Trim('"');
            commands = commands.Trim('"');
            //Now, divide conditions and isolate eventID
            char splitArea = '/';
            List<string> parseConditions = new List<string>();
            string[] dividedConditions = conditions.Split(splitArea);
            foreach (var condition in dividedConditions)
            {
                parseConditions.Add(condition.ToString());
            }
            //Acquire EventID
            string eventID = parseConditions[0].ToString();
            parseConditions.Remove(parseConditions[0]); //Removes event ID from conditions list
            //create a temporary file space for next window to look for
            Directory.CreateDirectory(Environment.CurrentDirectory + "\\Save Data\\tmp\\editevent");
            //Create Files
            File.WriteAllText(Environment.CurrentDirectory + "\\Save Data\\tmp\\editevent\\eventID.txt", eventID);//just stores the event ID
            if(parseConditions.Count > 0)
            {
                File.WriteAllLines(Environment.CurrentDirectory + "\\Save Data\\tmp\\editevent\\conditions.txt", parseConditions);//Add Conditions File if conditions present

            }
            //Divide Commands
            List<string> parsedCommands = new List<string>();
            string[] dividedCommands = commands.Split(splitArea);
            foreach(var command in dividedCommands)
            {
                parsedCommands.Add(command.ToString());
            }
            //Create Text File containing all commands
            //Check to see if there is anything there
            if(parsedCommands.Count > 0)
            {
                File.WriteAllLines(Environment.CurrentDirectory + "\\Save Data\\tmp\\editevent\\commands.txt", parsedCommands);
            }
            //Delete Old Event
            eventFileData.Items.Remove(eventFileData.SelectedItem);
            //Open Event Editing
            Conditions frRem = new Conditions();
            frRem.Text = "Edit Event";
            frRem.ShowDialog();
        }

        private void EditEvent_Click(object sender, EventArgs e)
        {
            ParseEvent();
        }

        private void LoadFile_Click(object sender, EventArgs e)
        {
            MessageBox.Show("If you are loading a direct rip from an XNB file, You should use the Load Json From Game Button.", "Before you Proceed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            OpenFileDialog loadEvent = new OpenFileDialog();
            loadEvent.InitialDirectory = Environment.CurrentDirectory;
            loadEvent.Filter = "json File (*.json)|*.json";
            loadEvent.FilterIndex = 1;
            loadEvent.RestoreDirectory = true;
            if (loadEvent.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string loadedFile = File.ReadAllText(loadEvent.FileName);
                    ContentVariable content = JsonConvert.DeserializeObject<ContentVariable>(loadedFile);
                    foreach (PatchVariable patch in content.Changes)
                    {
                        foreach (var entry in patch.Entries)
                        {
                            string parse = $"{entry.Key}: {entry.Value}";
                            eventFileData.Items.Add(parse);
                        }
                    }

                }
                catch (Exception)
                {
                    //Just in case we need it
                    string loadedFile = File.ReadAllText(loadEvent.FileName);
                    var parseJson = JsonConvert.DeserializeObject<Dictionary<string, string>>(loadedFile);
                    foreach (KeyValuePair<string, string> pair in parseJson)
                    {
                        string parse = $"{pair.Key}: {pair.Value}";
                        eventFileData.Items.Add(parse);
                    }
                }
            }            
        }

        private void LoadGameJson_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This button is for extracted files from XNB.\nIf you have an event file you edited for use, use the other Load Button", "WARNING!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            OpenFileDialog openRaw = new OpenFileDialog();
            openRaw.InitialDirectory = Environment.CurrentDirectory;
            openRaw.Filter = "json File (*.json)|*.json";
            openRaw.FilterIndex = 1;
            openRaw.RestoreDirectory = true;
            if(openRaw.ShowDialog() == DialogResult.OK)
            {
                string loadedFile = File.ReadAllText(openRaw.FileName);
                RawModel raw = JsonConvert.DeserializeObject<RawModel>(loadedFile);
                foreach (var entry in raw.content)
                {
                    string parse = $"{entry.Key}: {entry.Value}";
                    eventFileData.Items.Add(parse);
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string prepare = eventFileData.SelectedItem.ToString();
            string keys = prepare.Substring(0, prepare.IndexOf(':'));
            string values = prepare.Substring(prepare.IndexOf(':') + 2); // +2 to get past the : and space

            Clipboard.SetText($"\"{keys}\": \"{values}\"");
            MessageBox.Show("Event Copied to clipboard.", "Guess what?!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}