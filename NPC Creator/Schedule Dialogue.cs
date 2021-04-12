using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;

namespace NPC_Creator
{
    public partial class Schedule_Dialogue : Form
    {
        private string systemName;
        public string editDatum;
        public Dictionary<string, string> content = new Dictionary<string, string>();

        public Schedule_Dialogue()
        {
            InitializeComponent();
            Load += Schedule_Dialogue_Load;
        }
        public void updateList(string commitChange)
        {
            scheduleDialogList.Items.Add(commitChange);
        }


        private void Schedule_Dialogue_Load(object sender, EventArgs e)
        {
            systemName = scheduleStudio.importSystem;
        }
        private IEnumerable<string> GetItems(ListBox listbox)
        {
            foreach (object entry in listbox.Items)
                yield return entry.ToString();
        }

        private void sendToList_Click(object sender, EventArgs e)
        {
            scheduleDialogList.Items.Add(keyString.Text + "." + keyNumber.Text + ": " + dialogValue.Text);
            keyNumber.Text = string.Empty;
            keyString.Text = string.Empty;
            dialogValue.Text = string.Empty;
        }

        private void deleteSelected_Click(object sender, EventArgs e)
        {
            scheduleDialogList.Items.Remove(scheduleDialogList.SelectedItem);
        }

        private void listClear_Click(object sender, EventArgs e)
        {
            scheduleDialogList.Items.Clear();
        }

        private void createDialog_Click(object sender, EventArgs e)
        {
            foreach (var item in scheduleDialogList.Items)
            {
                string entry = item.ToString();
                string key = entry.Substring(0, entry.IndexOf(':'));
                string value = entry.Substring(entry.IndexOf(':') + 2); // +1 to get past :, and +1 to get past the space
                try
                {
                    content.Add(key, value);
                    //content[key] = value;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "\nOnly the first key was accepted... Check your dialogue!!", "Duplicate Keys Detected!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            string path = Path.Combine($"Export/[CP]{systemName}/assets/schedules", "scheduleDialogue.json");
            File.WriteAllText(path, JsonConvert.SerializeObject(content, Formatting.Indented));
            string save = Path.Combine($"Export/[CP]{systemName}/assets/schedules", "scheduleDialogue_Backup.json");
            File.WriteAllText(save, JsonConvert.SerializeObject(content, Formatting.Indented));
            MessageBox.Show("scheduleDialogue.json Created!\nYou will find it in the schedules Folder!", "Dialogue File Created!", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            scheduleDialogList.Items.Clear();
            string save = Path.Combine($"Export/[CP]{systemName}/assets/schedules", "scheduleDialogue_Backup.json");
            string json = File.ReadAllText(save);
            var recentLoad = JsonConvert.DeserializeObject<Dictionary<string, string>>(json);
            foreach (KeyValuePair<string, string> pair in recentLoad)
            {
                scheduleDialogList.Items.Add($"{pair.Key}: {pair.Value}");
            }

        }

        private void editData_Click(object sender, EventArgs e)
        {
            editDatum = $"{scheduleDialogList.SelectedItem}";
            scheduleDialogList.Items.Remove(scheduleDialogList.SelectedItem);
            EditSchedule frRem = new EditSchedule(editDatum);
            frRem.ShowDialog();

        }
    }
}
