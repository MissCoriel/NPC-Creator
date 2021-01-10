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
    public partial class scheduleStudio : Form
    {
        private string systemName;
        public Dictionary<string, string> content = new Dictionary<string, string>();

        public scheduleStudio()
        {
            InitializeComponent();
            Load += scheduleStudio_Load;
        }
        private void scheduleStudio_Load(object sender, EventArgs e)
        {
            systemName = Form1.exportSystem;
        }

        private IEnumerable<string> GetItems(ListBox listbox)
        {
            foreach (object entry in listbox.Items)
                yield return entry.ToString();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

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
                    scheduleData.Items.Add(timeStamp.Value + " " + locations.SelectedItem + " " + npcX.Value + " " + npcY.Value + " " + npcFacing.Value + $" \"Strings\\schedules\\{systemName}:{scheduleDialog.Text}\"");
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
            string commit = $"{scheduleName.Text}: " + string.Join("/", this.GetItems(scheduleData));
            finalScheduleCheck.Items.Add(commit);
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
            File.WriteAllText(path, JsonConvert.SerializeObject(content, Formatting.Indented));
            string save = Path.Combine($"Export/[CP]{systemName}/assets/schedules", "schedule-backup.json");
            File.WriteAllText(save, JsonConvert.SerializeObject(content, Formatting.Indented));
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
    }
}
