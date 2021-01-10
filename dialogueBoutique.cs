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
    public partial class dialogueBoutique : Form
    {
        string systemName;
        public Dictionary<string, string> content = new Dictionary<string, string>();
        public Dictionary<string, string> marriage = new Dictionary<string, string>();
        public Dictionary<string, string> savedata;
        public string editData;

        public void updateList(string commitChange)
        {
            listDialogue.Items.Add(commitChange);
        }

        public dialogueBoutique()
        {
            InitializeComponent();
            Load += dialogueBoutique_Load;
        }
        private void dialogueBoutique_Load(object sender, EventArgs e)
        {
            systemName = Form1.exportSystem;
        }
        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://stardewvalleywiki.com/Modding:Dialogue");
        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void AddToKey_Click(object sender, EventArgs e)
        {
            keyList.Items.Add(customKey.Text);
        }

        private void SpouseDialog_Click(object sender, EventArgs e)
        {
            keyList.Items.Add($"patio_{systemName}");
            keyList.Items.Add($"Rainy_Day_{systemName}");
            keyList.Items.Add($"Rainy_Night_{systemName}");
            keyList.Items.Add($"Indoor_Day_{systemName}");
            keyList.Items.Add($"Indoor_Night_{systemName}");
            keyList.Items.Add($"Outdoor_{systemName}");
            keyList.Items.Add($"funLeave_{systemName}");
            keyList.Items.Add($"funReturn_{systemName}");
            keyList.Items.Add($"jobLeave_{systemName}");
            keyList.Items.Add($"jobReturn_{systemName}");
            MessageBox.Show($"Special Marriage Dialogue has been added for {systemName}!  Check bottom of the list.", "Dialogue Added!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void AddDialogList_Click(object sender, EventArgs e)
        {
            listDialogue.Items.Add(keyList.SelectedItem + ": " + dialogBody.Text);
            dialogBody.Text = String.Empty;
        }

        private void SubmitQuestion_Click(object sender, EventArgs e)
        {
            listDialogue.Items.Add(keyList.SelectedItem + ": " + preQuestion.Text + "#$b#$q " + positiveID.Value + "/" + negativeID.Value + " " + fallBackID.Text + "#" + question.Text + "#$r " + positiveID.Value + " " + positivePoints.Value + " " + positiveResponse.Text + "#" + positiveAnswer.Text + "#$r " + negativeID.Value + " " + negativePoints.Value + " " + negativeResponse.Text + "#" + negativeAnswer.Text);
            keyList.Items.Add(fallBackID.Text);
            keyList.Items.Add(positiveResponse.Text);
            keyList.Items.Add(negativeResponse.Text);
            MessageBox.Show($"{fallBackID.Text}, {positiveResponse.Text}, and {negativeResponse.Text} were added to the Key List.  Do NOT Forget to add them to the dialogue!", "REMINDER!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            preQuestion.Text = String.Empty;
            fallBackID.Text = String.Empty;
            question.Text = String.Empty;
            positiveResponse.Text = String.Empty;
            positiveAnswer.Text = String.Empty;
            negativeResponse.Text = String.Empty;
            negativeAnswer.Text = String.Empty;

        }

        private void RemoveDialogue_Click(object sender, EventArgs e)
        {
            listDialogue.Items.Remove(listDialogue.SelectedItem);
        }

        private void CreateDialogFile_Click(object sender, EventArgs e)
        {
            foreach (var item in listDialogue.Items)
            {
                string entry = item.ToString();
                string key = entry.Substring(0, entry.IndexOf(':'));
                string value = entry.Substring(entry.IndexOf(':') + 2); // +1 to get past :, and +1 to get past the space
                /*string[] duplicateKeys = key
                .GroupBy(p => p.Key)
                .Where(p => p.Count() > 1)
                .Select(p => p.Key)
                .ToArray();*/
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
            string path = Path.Combine($"Export/[CP]{systemName}/assets/dialogue", "Dialogue.json");
            File.WriteAllText(path, JsonConvert.SerializeObject(content, Formatting.Indented));
            string save = Path.Combine($"Export/[CP]{systemName}/assets/dialogue", "Dialogue-backup.json");
            File.WriteAllText(save, JsonConvert.SerializeObject(content, Formatting.Indented));
            MessageBox.Show("Dialogue.Json Created!  Remember not all Keys are for the Main Dialogue", "Dialogue Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void CreateMarriageFile_Click(object sender, EventArgs e)
        {
            foreach (var item in listDialogue.Items)
            {
                string entry = item.ToString();
                string key = entry.Substring(0, entry.IndexOf(':'));
                string value = entry.Substring(entry.IndexOf(':') + 2); // +1 to get past :, and +1 to get past the space
                marriage.Add(key, value);
            }
            
            string path = Path.Combine($"Export/[CP]{systemName}/assets/dialogue", "MarriageDialogue.json");
            File.WriteAllText(path, JsonConvert.SerializeObject(marriage, Formatting.Indented));
            string save = Path.Combine($"Export/[CP]{systemName}/assets/dialogue", "BackupMarriageDialogue.json");
            File.WriteAllText(save, JsonConvert.SerializeObject(marriage, Formatting.Indented));
            MessageBox.Show("MarriageDialogue.Json Created!  Remember not all Keys are for the MarriageDialogue", "Dialogue Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            listDialogue.Items.Clear();
            string save = Path.Combine($"Export/[CP]{systemName}/assets/dialogue", "Dialogue-backup.json");
            string json = File.ReadAllText(save);
            var recentLoad = JsonConvert.DeserializeObject<Dictionary<string, string>>(json);
            foreach (KeyValuePair<string, string> pair in recentLoad)
            {
                listDialogue.Items.Add($"{pair.Key}: {pair.Value}");
            }
        }

        private void LoadMarriage_Click(object sender, EventArgs e)
        {
            listDialogue.Items.Clear();
            string save = Path.Combine($"Export/[CP]{systemName}/assets/dialogue", "BackupMarriageDialogue.json");
            string json = File.ReadAllText(save);
            var recentLoad = JsonConvert.DeserializeObject<Dictionary<string, string>>(json);
            foreach (KeyValuePair<string, string> pair in recentLoad)
            {
                listDialogue.Items.Add($"{pair.Key}: {pair.Value}");
            }

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            editData = $"{listDialogue.SelectedItem}";
            listDialogue.Items.Remove(listDialogue.SelectedItem);
            EditDialogue frRem = new EditDialogue(editData);
            frRem.ShowDialog();

        }
    }
}
