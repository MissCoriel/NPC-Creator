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
using System.Drawing.Imaging;

namespace NPC_Creator
{
    public partial class dialogueBoutique : Form
    {
        string systemName;
        public Dictionary<string, string> content = new Dictionary<string, string>();
        public Dictionary<string, string> marriage = new Dictionary<string, string>();
        public Dictionary<string, string> savedata;
        public string editData;
        Bitmap image1;

        public void updateList(string commitChange)
        {
            listDialogue.Items.Add(commitChange);
        }

        public dialogueBoutique()
        {
            InitializeComponent();
            Load += dialogueBoutique_Load;
        }
        public Rectangle GetTileArea(int tileIndex, int tileWidth, int tileHeight, int sheetWidthInTiles)
        {
            int x = tileIndex % sheetWidthInTiles;
            int y = tileIndex / sheetWidthInTiles;
            return new Rectangle(x * tileWidth, y * tileHeight, tileWidth, tileHeight);
        }

        private void dialogueBoutique_Load(object sender, EventArgs e)
        {
            systemName = Form1.exportSystem;
            try
            {
                //Get Spritesheet
                image1 = new Bitmap(Environment.CurrentDirectory + $"\\Export\\[CP]{systemName}\\assets\\img\\Portrait.png");
                Rectangle pixelAreaForTile = this.GetTileArea(tileIndex: 0, tileWidth: 64, tileHeight: 64, sheetWidthInTiles: 2);               // Rectangle rect = new Rectangle(xmin, ymin, xmaximum, ymaximum);
                Bitmap spriteFrame = image1.Clone(pixelAreaForTile, PixelFormat.DontCare);
                portraitSample.Image = spriteFrame;
                label13.Text = $"Showing Portrait: ${portFrame.Value}";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n You cannot exceed the number of frames your Spritesheet has!!", "Why can't I hold all these Frames?!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://stardewvalleywiki.com/Modding:Dialogue");
        }


        private void AddToKey_Click(object sender, EventArgs e)
        {
            keyList.Items.Add(customKey.Text);
        }

        private void SpouseDialog_Click(object sender, EventArgs e)
        {
        }

        private void AddDialogList_Click(object sender, EventArgs e)
        {
            listDialogue.Items.Add(keyList.SelectedItem + ": " + dialogBody.Text);
            keyList.Items.Remove(keyList.SelectedItem);
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
            keyList.Items.Remove(keyList.SelectedItem);


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
            File.WriteAllText(path, JsonConvert.SerializeObject(content, new JsonSerializerSettings { Formatting = Formatting.Indented, NullValueHandling = NullValueHandling.Ignore }));
            string save = Path.Combine($"Export/[CP]{systemName}/assets/dialogue", "Dialogue-backup.json");
            File.WriteAllText(save, JsonConvert.SerializeObject(content, new JsonSerializerSettings { Formatting = Formatting.Indented, NullValueHandling = NullValueHandling.Ignore }));
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
            File.WriteAllText(path, JsonConvert.SerializeObject(marriage, new JsonSerializerSettings { Formatting = Formatting.Indented, NullValueHandling = NullValueHandling.Ignore }));
            string save = Path.Combine($"Export/[CP]{systemName}/assets/dialogue", "BackupMarriageDialogue.json");
            File.WriteAllText(save, JsonConvert.SerializeObject(marriage, new JsonSerializerSettings { Formatting = Formatting.Indented, NullValueHandling = NullValueHandling.Ignore }));
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


        private void showPort_Click(object sender, EventArgs e)
        {
            try
            {
                //Get Spritesheet
                image1 = new Bitmap(Environment.CurrentDirectory + $"\\Export\\[CP]{systemName}\\assets\\img\\Portrait.png");
                Rectangle pixelAreaForTile = this.GetTileArea(tileIndex: (int)portFrame.Value, tileWidth: 64, tileHeight: 64, sheetWidthInTiles: 2);               // Rectangle rect = new Rectangle(xmin, ymin, xmaximum, ymaximum);
                Bitmap spriteFrame = image1.Clone(pixelAreaForTile, PixelFormat.DontCare);
                portraitSample.Image = spriteFrame;
                label13.Text = $"Showing Portrait: ${portFrame.Value}";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n You cannot exceed the number of frames your Spritesheet has!!", "Why can't I hold all these Frames?!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void regularDialog_CheckedChanged(object sender, EventArgs e)
        {
            if(regularDialog.Checked == true)
            {
                if (marriageDialog.Checked == true)
                {
                    DialogResult regulate = MessageBox.Show("Are you sure?\nChanging dialogue keys will reset the key list if you come back.", "Change Dialogue", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (regulate == DialogResult.Yes)
                    {
                        marriageDialog.Checked = false;
                        keyList.Items.Clear();
                        keyList.Items.AddRange(System.IO.File.ReadAllLines(Environment.CurrentDirectory + "\\Common Data\\dialogueKeys.txt"));
                        groupBox1.Text = "Normal Dialogue Mode";
                        regularDialog.Checked = true;

                    }
                }
                else
                {
                    keyList.Items.Clear();
                    keyList.Items.AddRange(System.IO.File.ReadAllLines(Environment.CurrentDirectory + "\\Common Data\\dialogueKeys.txt"));
                    groupBox1.Text = "Normal Dialogue Mode";

                }

            }

        }

        private void marriageDialog_CheckedChanged(object sender, EventArgs e)
        {
            if(marriageDialog.Checked == true)
            {
                if (regularDialog.Checked == true)
                {
                    DialogResult regulate = MessageBox.Show("Are you sure?\nChanging dialogue keys will reset the key list if you come back.", "Change Dialogue", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (regulate == DialogResult.Yes)
                    {
                        regularDialog.Checked = false;
                        keyList.Items.Clear();
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

                        keyList.Items.AddRange(System.IO.File.ReadAllLines(Environment.CurrentDirectory + "\\Common Data\\marriedKeys.txt"));
                        groupBox1.Text = "Marriage Dialogue Mode";


                    }
                }
                else
                {
                    keyList.Items.Clear();
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

                    keyList.Items.AddRange(System.IO.File.ReadAllLines(Environment.CurrentDirectory + "\\Common Data\\marriedKeys.txt"));
                    groupBox1.Text = "Marriage Dialogue Mode";

                }

            }
        }

        private void addBreak_Click(object sender, EventArgs e)
        {
            dialogBody.Text = dialogBody.Text + "#$b#";
        }

        private void fullBreak_Click(object sender, EventArgs e)
        {
            dialogBody.Text = dialogBody.Text + "#$e#";
        }

        private void addFarmer_Click(object sender, EventArgs e)
        {
            dialogBody.Text = dialogBody.Text + "@";
        }

        private void addFarm_Click(object sender, EventArgs e)
        {
            dialogBody.Text = dialogBody.Text + "%farm";
        }

        private void addGender_Click(object sender, EventArgs e)
        {
            dialogBody.Text = dialogBody.Text + "^";
        }

        private void firstKid_Click(object sender, EventArgs e)
        {
            dialogBody.Text = dialogBody.Text + "%kid1";
        }

        private void kid2_Click(object sender, EventArgs e)
        {
            dialogBody.Text = dialogBody.Text + "%kid2";
        }

        private void addSpouse_Click(object sender, EventArgs e)
        {
            dialogBody.Text = dialogBody.Text + "%spouse";
        }

        private void addFav_Click(object sender, EventArgs e)
        {
            dialogBody.Text = dialogBody.Text + "%favorite";
        }

        private void petName_Click(object sender, EventArgs e)
        {
            dialogBody.Text = dialogBody.Text + "%pet";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(portFrame.Value == 0)
            {
                MessageBox.Show("Having $0 or neutral portraits in dialogue is pointless.\nThe game will do this by default!", "Nope.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                dialogBody.Text = dialogBody.Text + $"${portFrame.Value}";
            }
        }
    }
}
