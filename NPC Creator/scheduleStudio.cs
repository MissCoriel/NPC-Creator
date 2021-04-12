using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace NPC_Creator
{
    public partial class scheduleStudio : Form
    {
        private string systemName;
        public static string importSystem;
        public Dictionary<string, string> content = new Dictionary<string, string>();

        public scheduleStudio()
        {
            InitializeComponent();
            Load += scheduleStudio_Load;
        }
        private void scheduleStudio_Load(object sender, EventArgs e)
        {
            systemName = Form1.exportSystem;
            locations.Items.AddRange(System.IO.File.ReadAllLines(Environment.CurrentDirectory + "\\Common Data\\ValidLocations.txt"));
            if(Directory.Exists(Environment.CurrentDirectory + "\\Coordinates"))
            {
                groupBox4.Enabled = true;
                groupBox4.Text = "Positioner Coordinates";
                disableManual.Enabled = true;
                string[] saveData = System.IO.Directory.GetFiles(Environment.CurrentDirectory + "\\Coordinates", "*.txt");
                foreach (string save in saveData)
                {
                    string parse = Path.GetFileNameWithoutExtension(save);
                    coordFiles.Items.Add(parse);
                }

            }
            else
            {
                groupBox4.Text = "Positioner Tool Coordinate Folder not Found!";
                groupBox4.Enabled = false;
                disableManual.Enabled = false;
            }

        }

        private IEnumerable<string> GetItems(ListBox listbox)
        {
            foreach (object entry in listbox.Items)
                yield return entry.ToString();
        }


        private void AddToLine_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(npcAnimation.Text))
            {
                if (string.IsNullOrWhiteSpace(scheduleDialog.Text))
                {
                    scheduleData.Items.Add(timeStamp.Value + " " + locations.SelectedItem + " " + npcX.Value + " " + npcY.Value + " " + npcFacing.Value);
                }
                else
                {
                    scheduleData.Items.Add(timeStamp.Value + " " + locations.SelectedItem + " " + npcX.Value + " " + npcY.Value + " " + npcFacing.Value + $" Strings\\schedules\\{systemName}:{scheduleDialog.Text}");
                }
            }
            else if (string.IsNullOrWhiteSpace(scheduleDialog.Text))
            {
                scheduleData.Items.Add(timeStamp.Value + " " + locations.SelectedItem + " " + npcX.Value + " " + npcY.Value + " " + npcFacing.Value + " " + npcAnimation.Text);
            }
            else
            {
                scheduleData.Items.Add(timeStamp.Value + " " + locations.SelectedItem + " " + npcX.Value + " " + npcY.Value + " " + npcFacing.Value + " " + npcAnimation.Text + $" \"Strings\\schedules\\{systemName}:{scheduleDialog.Text}\"");
            }
            scheduleName.Text = "";
            timeStamp.Value = 600;
            newLocation.Text = "";
            npcX.Value = 0;
            npcY.Value = 0;
            npcFacing.Value = 0;
            npcAnimation.Text = "";
            scheduleDialog.Text = "";
        }

        private void RemoveSelected_Click(object sender, EventArgs e)
        {
            scheduleData.Items.Remove(scheduleData.SelectedItem);
        }

        private void ClearAll_Click(object sender, EventArgs e)
        {
            scheduleData.Items.Clear();
        }

        private void CommitSchedule_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(scheduleName.Text))
            {
                string commit = $"{scheduleName.Text}: " + string.Join("/", this.GetItems(scheduleData));
                finalScheduleCheck.Items.Add(commit);
                scheduleData.Items.Clear();

            }
            else
            {
                MessageBox.Show("The schedule is missing the key data.\nYou must enter something there or your schedule will not work.\n(Ex. 'spring')", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteScheduleEntry_Click(object sender, EventArgs e)
        {
            finalScheduleCheck.Items.Remove(finalScheduleCheck.SelectedItem);
        }

        private void GenerateSchedule_Click(object sender, EventArgs e)
        {
            foreach (var item in finalScheduleCheck.Items)
            {
                string entry = item.ToString();
                string key = entry.Substring(0, entry.IndexOf(':'));
                string value = entry.Substring(entry.IndexOf(':') + 2); // +1 to get past :, and +1 to get past the space
                content.Add(key, value);
            }
            //How to parse finalScheduleCheck to be a list going top to bottom 
            string path = Path.Combine($"Export/[CP]{systemName}/assets/schedules", "schedule.json");
            File.WriteAllText(path, JsonConvert.SerializeObject(content, new JsonSerializerSettings { Formatting = Formatting.Indented, NullValueHandling = NullValueHandling.Ignore }));
            string save = Path.Combine($"Export/[CP]{systemName}/assets/schedules", "schedule-backup.json");
            File.WriteAllText(save, JsonConvert.SerializeObject(content, new JsonSerializerSettings { Formatting = Formatting.Indented, NullValueHandling = NullValueHandling.Ignore }));
            MessageBox.Show("Schedule.json Created! Be sure to press Manifest NPC to add it to your project!", "Schedule Created... idk if successful tho.", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void AddLocation_Click(object sender, EventArgs e)
        {
            locations.Items.Add(newLocation.Text);
        }

        private void ReloadSchedule_Click(object sender, EventArgs e)
        {
            string save = Path.Combine($"Export/[CP]{systemName}/assets/schedules", "schedule-backup.json");
            string json = File.ReadAllText(save);
            var recentLoad = JsonConvert.DeserializeObject<Dictionary<string, string>>(json);
            foreach (KeyValuePair<string, string> pair in recentLoad)
            {
                finalScheduleCheck.Items.Add($"{pair.Key}: {pair.Value}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Schedule_Dialogue frRem = new Schedule_Dialogue();
            scheduleStudio.importSystem = systemName;
            frRem.ShowDialog();
        }

        private void animationButton_Click(object sender, EventArgs e)
        {
            AnimationStation frRem = new AnimationStation();
            scheduleStudio.importSystem = systemName;
            frRem.ShowDialog();
        }


        private void editTextFile_Click(object sender, EventArgs e)
        {
            Process.Start(Environment.CurrentDirectory + "\\Common Data\\ValidLocations.txt");
        }

        private void loadCoord_Click(object sender, EventArgs e)
        {
            coordList.Items.Clear();
            coordList.Items.AddRange(File.ReadAllLines(Environment.CurrentDirectory + $"//Coordinates//{coordFiles.Text}.txt"));

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(npcAnimation.Text))
            {
                if (string.IsNullOrWhiteSpace(scheduleDialog.Text))
                {
                    scheduleData.Items.Add(timeStamp.Value + " " + coordList.SelectedItem);
                }
                else
                {
                    scheduleData.Items.Add(timeStamp.Value + " " + coordList.SelectedItem + " " + $" Strings\\schedules\\{systemName}:{scheduleDialog.Text}");
                }
            }
            else if (string.IsNullOrWhiteSpace(scheduleDialog.Text))
            {
                scheduleData.Items.Add(timeStamp.Value + " " + coordList.SelectedItem + " " + npcAnimation.Text);
            }
            else
            {
                scheduleData.Items.Add(timeStamp.Value + " " + coordList.SelectedItem + " " + npcAnimation.Text + $" \"Strings\\schedules\\{systemName}:{scheduleDialog.Text}\"");
            }

        }

        private void disableManual_CheckedChanged(object sender, EventArgs e)
        {
            if(disableManual.Checked == true)
            {
                locations.Enabled = false;
                newLocation.Enabled = false;
                addLocation.Enabled = false;
                npcX.Enabled = false;
                npcY.Enabled = false;
                npcFacing.Enabled = false;
                addToLine.Enabled = false;
            }
            if(disableManual.Checked == false)
            {
                locations.Enabled = true;
                newLocation.Enabled = true;
                addLocation.Enabled = true;
                npcX.Enabled = true;
                npcY.Enabled = true;
                npcFacing.Enabled = true;
                addToLine.Enabled = true;

            }
        }

        private void timeStamp_ValueChanged(object sender, EventArgs e)
        {
            int timeCreation = (int)timeStamp.Value / 100;
            int timeCalc = timeCreation * 100;
            int actualTime = (int)timeStamp.Value - timeCalc;
            //MessageBox.Show($"{timeCreation}: {actualTime}", "Time");
            if (actualTime > 50)
            {
                timeStamp.Value = timeCalc + 100;
                if (timeStamp.Value > 2600)
                {
                    timeStamp.Value = 2600;
                }
            }
        }
    }
}
