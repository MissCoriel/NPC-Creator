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
using System.Diagnostics;

namespace NPC_Creator
{
    public partial class dialogueBoutique : Form
    {
        string systemName;
        public Dictionary<string, string> content = new Dictionary<string, string>();
        public Dictionary<string, string> marriage = new Dictionary<string, string>();
        public Dictionary<string, string> scheduleDialog = new Dictionary<string, string>();
        public Dictionary<string, string> savedata;
        public string editData;
        Bitmap image1;
        public static bool independantMode;
        public static string overhaulDirectory;
        PatchVariable[] overhaulPatch;
        public string portraitTemp = Environment.CurrentDirectory + "\\Save Data\\temp\\Portrait.png";
        private bool scheduleMode;

        public void updateList(string commitChange)
        {
            listDialogue.Items.Add(commitChange);
            string key = commitChange.Substring(0, commitChange.IndexOf(':'));
            string value = commitChange.Substring(commitChange.IndexOf(':') + 2); // +1 to get past :, and +1 to get past the space
            if (regularDialog.Checked == true)
            {
                content.Add(key, value);
            }
            if (marriageDialog.Checked == true)
            {
                marriage.Add(key, value);
            }

        }
        public void DialogIndependant(string name)
        {
            systemName = name;
        }
        public void FrontRunningCommands(string addCommand)
        {
            dialogBody.Text = addCommand + dialogBody.Text;
        }
        public void InsertingCommand(string addCommand)
        {
            dialogBody.Text = dialogBody.Text.Insert(dialogBody.SelectionStart, addCommand);
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
            if(scheduleStudio.scheduleDialogueMode == true)
            {
                scheduleMode = true;
                regularDialog.Enabled = false;
                marriageDialog.Enabled = false;
                groupBox3.Enabled = false;
                keyList.Items.Clear();
                keyList.Items.AddRange(System.IO.File.ReadAllLines(Environment.CurrentDirectory + "\\Common Data\\BasicScheduleData.txt"));
                groupBox1.Text = "Schedule Dialogue Mode";
                groupBox3.Enabled = true;
                listDialogue.Items.Clear();
                foreach (KeyValuePair<string, string> entry in scheduleDialog)
                {
                    listDialogue.Items.Add($"{entry.Key}: {entry.Value}");
                    keyList.Items.Remove(entry.Key);
                }


            }
            else
            {
                scheduleMode = false;
            }
            if(File.Exists(portraitTemp))
            {
                File.Delete(portraitTemp);
            }
            try
            {
                systemName = Form1.exportSystem;
                if(string.IsNullOrEmpty(systemName))
                {
                    createDialogFile.Enabled = false;
                    Dialogue_File_Without_Project frRem = new Dialogue_File_Without_Project();
                    frRem.ShowDialog();

                }

            }
            catch (Exception)
            {
                createDialogFile.Enabled = false;
                Dialogue_File_Without_Project frRem = new Dialogue_File_Without_Project();
                frRem.ShowDialog();

            }


            if (File.Exists(Environment.CurrentDirectory + $"\\Save Data\\{systemName}_saveData\\normalDialogue.json"))
            {
                string json = File.ReadAllText(Environment.CurrentDirectory + $"\\Save Data\\{systemName}_saveData\\normalDialogue.json");
                var recentLoad = JsonConvert.DeserializeObject<Dictionary<string, string>>(json);
                
                foreach (KeyValuePair<string, string> pair in recentLoad)
                {
                    content.Add(pair.Key, pair.Value);
                }

            }
            if(!File.Exists(Environment.CurrentDirectory + $"\\Save Data\\{systemName}_saveData\\normalDialogue.json") && File.Exists(Environment.CurrentDirectory + $"\\Export\\[CP]{systemName}\\assets\\dialogue\\Dialogue.json"))
            {
                string json = File.ReadAllText(Environment.CurrentDirectory + $"\\Export\\[CP]{systemName}\\assets\\dialogue\\Dialogue.json");
                var recentLoad = JsonConvert.DeserializeObject<Dictionary<string, string>>(json);

                foreach (KeyValuePair<string, string> pair in recentLoad)
                {
                    content.Add(pair.Key, pair.Value);
                }

            }
            if (!File.Exists(Environment.CurrentDirectory + $"\\Save Data\\{systemName}_saveData\\normalDialogue.json") && File.Exists(Environment.CurrentDirectory + $"\\Export\\[CP]{systemName}\\assets\\dialogue\\MarriageDialogue.json"))
            {
                string json = File.ReadAllText(Environment.CurrentDirectory + $"\\Export\\[CP]{systemName}\\assets\\dialogue\\MarriageDialogue.json");
                var recentLoad = JsonConvert.DeserializeObject<Dictionary<string, string>>(json);

                foreach (KeyValuePair<string, string> pair in recentLoad)
                {
                    marriage.Add(pair.Key, pair.Value);
                }

            }
            foreach (var item in listDialogue.Items)
            {
                string entry = item.ToString();
                string key = entry.Substring(0, entry.IndexOf(':'));
                string value = entry.Substring(entry.IndexOf(':') + 2); // +1 to get past :, and +1 to get past the space
            }
            try
            {
                //Get Spritesheet
                image1 = new Bitmap(Environment.CurrentDirectory + $"\\Export\\[CP]{systemName}\\assets\\img\\Portrait.png");
                Rectangle pixelAreaForTile = this.GetTileArea(tileIndex: 0, tileWidth: 64, tileHeight: 64, sheetWidthInTiles: 2);               // Rectangle rect = new Rectangle(xmin, ymin, xmaximum, ymaximum);
                Bitmap spriteFrame = image1.Clone(pixelAreaForTile, PixelFormat.DontCare);
                portraitSample.Image = spriteFrame;
                label13.Text = $"Showing Portrait: ${portFrame.Value}";
                independantMode = false;
                CreateOverhaul.Enabled = false;
                button6.Enabled = false;

            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message + "\nNo Portraits Found!\nYou may be in Independant Mode or you haven't Loaded any.\nDisabling Portrait Feature.", "Why can't I hold all these Frames?!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                label13.Text = $"Showing Portrait: ${portFrame.Value}";
                portFrame.Enabled = false;
                independantMode = true;
                CreateOverhaul.Enabled = true;
                button6.Enabled = true;

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
            if (!string.IsNullOrWhiteSpace(keyList.Text))
            {
                if (regularDialog.Checked == true)
                {
                    content.Add(keyList.SelectedItem.ToString(), dialogBody.Text);
                    listDialogue.Items.Add(keyList.SelectedItem + ": " + dialogBody.Text);
                    keyList.Items.Remove(keyList.SelectedItem);
                    dialogBody.Text = String.Empty;
                }
                if (marriageDialog.Checked == true)
                {
                    marriage.Add(keyList.SelectedItem.ToString(), dialogBody.Text);
                    listDialogue.Items.Add(keyList.SelectedItem + ": " + dialogBody.Text);
                    keyList.Items.Remove(keyList.SelectedItem);
                    dialogBody.Text = String.Empty;
                }
                if(scheduleMode == true)
                {
                    scheduleDialog.Add(keyList.SelectedItem.ToString(), dialogBody.Text);
                    listDialogue.Items.Add(keyList.SelectedItem + ": " + dialogBody.Text);
                    keyList.Items.Remove(keyList.SelectedItem);
                    dialogBody.Text = String.Empty;

                }

            }
            else
            {
                MessageBox.Show("You have not selected a Key!", "What's this going to?", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //listDialogue.Items.Add(keyList.SelectedItem + ": " + dialogBody.Text);
            //keyList.Items.Remove(keyList.SelectedItem);
            //dialogBody.Text = String.Empty;
        }

        private void SubmitQuestion_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(keyList.Text))
            {
                if (regularDialog.Checked == true)
                {
                    string parse = preQuestion.Text + "#$b#$q " + positiveID.Value + "/" + negativeID.Value + " " + fallBackID.Text + "#" + question.Text + "#$r " + positiveID.Value + " " + positivePoints.Value + " " + positiveResponse.Text + "#" + positiveAnswer.Text + "#$r " + negativeID.Value + " " + negativePoints.Value + " " + negativeResponse.Text + "#" + negativeAnswer.Text;
                    content.Add(keyList.SelectedItem.ToString(), parse);
                    listDialogue.Items.Add(keyList.SelectedItem + ": " + parse);
                    keyList.Items.Remove(keyList.SelectedItem);
                    preQuestion.Text = String.Empty;
                    fallBackID.Text = String.Empty;
                    question.Text = String.Empty;
                    positiveResponse.Text = String.Empty;
                    positiveAnswer.Text = String.Empty;
                    negativeResponse.Text = String.Empty;
                    negativeAnswer.Text = String.Empty;
                }
                if (marriageDialog.Checked == true)
                {
                    string parse = preQuestion.Text + "#$b#$q " + positiveID.Value + "/" + negativeID.Value + " " + fallBackID.Text + "#" + question.Text + "#$r " + positiveID.Value + " " + positivePoints.Value + " " + positiveResponse.Text + "#" + positiveAnswer.Text + "#$r " + negativeID.Value + " " + negativePoints.Value + " " + negativeResponse.Text + "#" + negativeAnswer.Text;
                    marriage.Add(keyList.SelectedItem.ToString(), parse);
                    listDialogue.Items.Add(keyList.SelectedItem + ": " + parse);
                    keyList.Items.Remove(keyList.SelectedItem);
                    preQuestion.Text = String.Empty;
                    fallBackID.Text = String.Empty;
                    question.Text = String.Empty;
                    positiveResponse.Text = String.Empty;
                    positiveAnswer.Text = String.Empty;
                    negativeResponse.Text = String.Empty;
                    negativeAnswer.Text = String.Empty;
                }
                if (scheduleMode == true)
                {
                    string parse = preQuestion.Text + "#$b#$q " + positiveID.Value + "/" + negativeID.Value + " " + fallBackID.Text + "#" + question.Text + "#$r " + positiveID.Value + " " + positivePoints.Value + " " + positiveResponse.Text + "#" + positiveAnswer.Text + "#$r " + negativeID.Value + " " + negativePoints.Value + " " + negativeResponse.Text + "#" + negativeAnswer.Text;
                    scheduleDialog.Add(keyList.SelectedItem.ToString(), parse);
                    listDialogue.Items.Add(keyList.SelectedItem + ": " + parse);
                    keyList.Items.Remove(keyList.SelectedItem);
                    preQuestion.Text = String.Empty;
                    fallBackID.Text = String.Empty;
                    question.Text = String.Empty;
                    positiveResponse.Text = String.Empty;
                    positiveAnswer.Text = String.Empty;
                    negativeResponse.Text = String.Empty;
                    negativeAnswer.Text = String.Empty;
                }

            }
            else
            {
                MessageBox.Show("You have not selected a Key!", "What's this going to?", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void RemoveDialogue_Click(object sender, EventArgs e)
        {
            string key = listDialogue.SelectedItem.ToString().Substring(0, listDialogue.SelectedItem.ToString().IndexOf(':'));
            string value = listDialogue.SelectedItem.ToString().Substring(listDialogue.SelectedItem.ToString().IndexOf(':') + 2); // +1 to get past :, and +1 to get past the space

            if(regularDialog.Checked == true)
            {
                content.Remove(key);
            }
            if(marriageDialog.Checked == true)
            {
                marriage.Remove(key);
            }
            if(scheduleMode == true)
            {
                scheduleDialog.Remove(key);
            }
            listDialogue.Items.Remove(listDialogue.SelectedItem);
            keyList.Items.Add(key);

        }

        private void CreateDialogFile_Click(object sender, EventArgs e)
        {
            /*foreach (var item in listDialogue.Items)
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
                
            }*/
            if(scheduleMode == true)
            {
                File.WriteAllText(Environment.CurrentDirectory + $"\\Export\\[CP]{systemName}\\assets\\schedules\\scheduleDialogue.json", JsonConvert.SerializeObject(scheduleDialog, new JsonSerializerSettings { Formatting = Formatting.Indented, NullValueHandling = NullValueHandling.Ignore }));
                File.WriteAllText(Environment.CurrentDirectory + $"\\Save Data\\{systemName}_saveData\\scheduleDialogue.json", JsonConvert.SerializeObject(scheduleDialog, new JsonSerializerSettings { Formatting = Formatting.Indented, NullValueHandling = NullValueHandling.Ignore }));

            }
            if (regularDialog.Checked == true)
            {
                File.WriteAllText(Environment.CurrentDirectory + $"\\Export\\[CP]{systemName}\\assets\\dialogue\\Dialogue.json", JsonConvert.SerializeObject(content, new JsonSerializerSettings { Formatting = Formatting.Indented, NullValueHandling = NullValueHandling.Ignore }));
                File.WriteAllText(Environment.CurrentDirectory + $"\\Save Data\\{systemName}_saveData\\normalDialogue.json", JsonConvert.SerializeObject(content, new JsonSerializerSettings { Formatting = Formatting.Indented, NullValueHandling = NullValueHandling.Ignore }));
                MessageBox.Show("Dialogue.Json Created Successfully!", "Dialogue Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if(marriage.Count > 0)
                {
                    File.WriteAllText(Environment.CurrentDirectory + $"\\Export\\[CP]{systemName}\\assets\\dialogue\\MarriageDialogue.json", JsonConvert.SerializeObject(marriage, new JsonSerializerSettings { Formatting = Formatting.Indented, NullValueHandling = NullValueHandling.Ignore }));
                    //string save = Path.Combine($"Export/[CP]{systemName}/assets/dialogue", "BackupMarriageDialogue.json");
                    File.WriteAllText(Environment.CurrentDirectory + $"\\Save Data\\{systemName}_saveData\\marriageDialogue.json", JsonConvert.SerializeObject(marriage, new JsonSerializerSettings { Formatting = Formatting.Indented, NullValueHandling = NullValueHandling.Ignore }));
                    MessageBox.Show("MarriageDialogue.Json Created!", "Dialogue Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            if (marriageDialog.Checked == true)
            {
                File.WriteAllText(Environment.CurrentDirectory + $"\\Export\\[CP]{systemName}\\assets\\dialogue\\MarriageDialogue.json", JsonConvert.SerializeObject(marriage, new JsonSerializerSettings { Formatting = Formatting.Indented, NullValueHandling = NullValueHandling.Ignore }));
                //string save = Path.Combine($"Export/[CP]{systemName}/assets/dialogue", "BackupMarriageDialogue.json");
                File.WriteAllText(Environment.CurrentDirectory + $"\\Save Data\\{systemName}_saveData\\marriageDialogue.json", JsonConvert.SerializeObject(marriage, new JsonSerializerSettings { Formatting = Formatting.Indented, NullValueHandling = NullValueHandling.Ignore }));
                MessageBox.Show("MarriageDialogue.Json Created!", "Dialogue Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if(content.Count > 0)
                {
                    File.WriteAllText(Environment.CurrentDirectory + $"\\Export\\[CP]{systemName}\\assets\\dialogue\\Dialogue.json", JsonConvert.SerializeObject(content, new JsonSerializerSettings { Formatting = Formatting.Indented, NullValueHandling = NullValueHandling.Ignore }));
                    File.WriteAllText(Environment.CurrentDirectory + $"\\Save Data\\{systemName}_saveData\\normalDialogue.json", JsonConvert.SerializeObject(content, new JsonSerializerSettings { Formatting = Formatting.Indented, NullValueHandling = NullValueHandling.Ignore }));
                    MessageBox.Show("Dialogue.Json Created Successfully!", "Dialogue Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            /*string path = Path.Combine($"Export/[CP]{systemName}/assets/dialogue", "Dialogue.json");
            File.WriteAllText(path, JsonConvert.SerializeObject(content, new JsonSerializerSettings { Formatting = Formatting.Indented, NullValueHandling = NullValueHandling.Ignore }));
            string save = Path.Combine($"Export/[CP]{systemName}/assets/dialogue", "Dialogue-backup.json");
            File.WriteAllText(save, JsonConvert.SerializeObject(content, new JsonSerializerSettings { Formatting = Formatting.Indented, NullValueHandling = NullValueHandling.Ignore }));
            MessageBox.Show("Dialogue.Json Created!  Remember not all Keys are for the Main Dialogue", "Dialogue Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);*/

        }


        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog importJson = new OpenFileDialog();
                
                if (importJson.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    listDialogue.Items.Clear();
                    string loadedFile = File.ReadAllText(importJson.FileName);
                    var recentLoad = JsonConvert.DeserializeObject<Dictionary<string, string>>(loadedFile);
                    if (regularDialog.Checked == true)
                    {
                        foreach (KeyValuePair<string, string> pair in recentLoad)
                        {
                            content.Add(pair.Key, pair.Value);
                            listDialogue.Items.Add($"{pair.Key}: {pair.Value}");
                            keyList.Items.Remove(pair.Key);

                        }


                    }
                    if (marriageDialog.Checked == true)
                    {
                        foreach (KeyValuePair<string, string> pair in recentLoad)
                        {
                            marriage.Add(pair.Key, pair.Value);
                            listDialogue.Items.Add($"{pair.Key}: {pair.Value}");
                            keyList.Items.Remove(pair.Key);

                        }

                    }
                    if (scheduleMode == true)
                    {
                        foreach (KeyValuePair<string, string> pair in recentLoad)
                        {
                            scheduleDialog.Add(pair.Key, pair.Value);
                            listDialogue.Items.Add($"{pair.Key}: {pair.Value}");
                            keyList.Items.Remove(pair.Key);
                        }

                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            editData = $"{listDialogue.SelectedItem}";
            listDialogue.Items.Remove(listDialogue.SelectedItem);
            string key = editData.Substring(0, editData.ToString().IndexOf(':'));
            if (regularDialog.Checked == true)
            {
                content.Remove(key);
            }
            if (marriageDialog.Checked == true)
            {
                marriage.Remove(key);
            }
            if (scheduleMode == true)
            {
                scheduleDialog.Remove(key);
            }    
            EditDialogue frRem = new EditDialogue(editData);
            frRem.ShowDialog();

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
                        groupBox3.Enabled = true;
                        listDialogue.Items.Clear();
                        foreach (KeyValuePair<string, string> entry in content)
                        {
                            listDialogue.Items.Add($"{entry.Key}: {entry.Value}");
                            keyList.Items.Remove(entry.Key);

                        }
                    }
                }
                else
                {
                    keyList.Items.Clear();
                    keyList.Items.AddRange(System.IO.File.ReadAllLines(Environment.CurrentDirectory + "\\Common Data\\dialogueKeys.txt"));
                    groupBox1.Text = "Normal Dialogue Mode";
                    groupBox3.Enabled = true;
                    listDialogue.Items.Clear();
                    foreach (KeyValuePair<string, string>entry in content)
                    {
                        listDialogue.Items.Add($"{entry.Key}: {entry.Value}");
                        keyList.Items.Remove(entry.Key);
                    }

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
                        groupBox3.Enabled = false;
                        listDialogue.Items.Clear();
                        foreach (KeyValuePair<string, string> entry in marriage)
                        {
                            listDialogue.Items.Add($"{entry.Key}: {entry.Value}");
                            keyList.Items.Remove(entry.Key);

                        }


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
                    groupBox3.Enabled = false;
                    listDialogue.Items.Clear();
                    foreach (KeyValuePair<string, string> entry in marriage)
                    {
                        listDialogue.Items.Add($"{entry.Key}: {entry.Value}");
                        keyList.Items.Remove(entry.Key);

                    }

                }

            }
        }

        private void addBreak_Click(object sender, EventArgs e)
        {
            dialogBody.Text = dialogBody.Text.Insert(dialogBody.SelectionStart, "#$b#");
        }

        private void fullBreak_Click(object sender, EventArgs e)
        {
            dialogBody.Text = dialogBody.Text.Insert(dialogBody.SelectionStart, "#$e#");
        }

        private void addFarmer_Click(object sender, EventArgs e)
        {
            dialogBody.Text = dialogBody.Text.Insert(dialogBody.SelectionStart, "@");
        }

        private void addFarm_Click(object sender, EventArgs e)
        {
            dialogBody.Text = dialogBody.Text.Insert(dialogBody.SelectionStart, "%farm");
        }

        private void addGender_Click(object sender, EventArgs e)
        {
            dialogBody.Text = dialogBody.Text.Insert(dialogBody.SelectionStart, "^");
        }

        private void firstKid_Click(object sender, EventArgs e)
        {
            dialogBody.Text = dialogBody.Text.Insert(dialogBody.SelectionStart, "%kid1");
        }

        private void kid2_Click(object sender, EventArgs e)
        {
            dialogBody.Text = dialogBody.Text.Insert(dialogBody.SelectionStart, "%kid2");
        }

        private void addSpouse_Click(object sender, EventArgs e)
        {
            dialogBody.Text = dialogBody.Text.Insert(dialogBody.SelectionStart, "%spouse");
        }

        private void addFav_Click(object sender, EventArgs e)
        {
            dialogBody.Text = dialogBody.Text.Insert(dialogBody.SelectionStart, "%favorite");
        }

        private void petName_Click(object sender, EventArgs e)
        {
            dialogBody.Text = dialogBody.Text.Insert(dialogBody.SelectionStart, "%pet");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(portFrame.Value == 0)
            {
                MessageBox.Show("Having $0 or neutral portraits in dialogue is pointless.\nThe game will do this by default!", "Nope.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                dialogBody.Text = dialogBody.Text.Insert(dialogBody.SelectionStart, $"${portFrame.Value}");
            }
        }

        private void portFrame_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if(independantMode = true && File.Exists(portraitTemp))
                {
                    image1 = new Bitmap(portraitTemp);
                    Rectangle pixelAreaForTile = this.GetTileArea(tileIndex: (int)portFrame.Value, tileWidth: 64, tileHeight: 64, sheetWidthInTiles: 2);               // Rectangle rect = new Rectangle(xmin, ymin, xmaximum, ymaximum);
                    Bitmap spriteFrame = image1.Clone(pixelAreaForTile, PixelFormat.DontCare);
                    portraitSample.Image = spriteFrame;
                    label13.Text = $"Showing Portrait: ${portFrame.Value}";

                }
                else
                {
                    //Get Spritesheet
                    image1 = new Bitmap(Environment.CurrentDirectory + $"\\Export\\[CP]{systemName}\\assets\\img\\Portrait.png");
                    Rectangle pixelAreaForTile = this.GetTileArea(tileIndex: (int)portFrame.Value, tileWidth: 64, tileHeight: 64, sheetWidthInTiles: 2);               // Rectangle rect = new Rectangle(xmin, ymin, xmaximum, ymaximum);
                    Bitmap spriteFrame = image1.Clone(pixelAreaForTile, PixelFormat.DontCare);
                    portraitSample.Image = spriteFrame;
                    label13.Text = $"Showing Portrait: ${portFrame.Value}";

                }

            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message + "\n You cannot exceed the number of frames your Spritesheet has!!", "Why can't I hold all these Frames?!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                portFrame.Value = 0;

            }

        }

        private void exportDialogFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.InitialDirectory = Environment.CurrentDirectory;
            saveFile.Title = "Export Dialogue";
            saveFile.CheckPathExists = true;
            saveFile.DefaultExt = "json";
            saveFile.Filter = "json files (*.json)|*.json";
            saveFile.FilterIndex = 1;
            saveFile.RestoreDirectory = true;
            
            if(saveFile.ShowDialog() == DialogResult.OK)
            {
                if(regularDialog.Checked == true)
                {
                    File.WriteAllText(saveFile.FileName, JsonConvert.SerializeObject(content, new JsonSerializerSettings { Formatting = Formatting.Indented, NullValueHandling = NullValueHandling.Ignore }));

                }
                if(marriageDialog.Checked == true)
                {
                    File.WriteAllText(saveFile.FileName, JsonConvert.SerializeObject(marriage, new JsonSerializerSettings { Formatting = Formatting.Indented, NullValueHandling = NullValueHandling.Ignore }));

                }
            }
            //saveFile.ShowDialog();
        }

        private void ChanceCommand_Click(object sender, EventArgs e)
        {
            Chance_Command frRem = new Chance_Command();
            frRem.ShowDialog();
        }

        private void StateCommand_Click(object sender, EventArgs e)
        {
            Check_State frRem = new Check_State();
            frRem.ShowDialog();
        }

        private void FastQuestion_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This does not replace the $q for questions and your repsonses cannot be saved.\nThis is a repeatable question, however.", "Before you continue..", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Fast_Question frRem = new Fast_Question();
            frRem.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This command is meant to be used with fallback dialogue.", "Before you continue..", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Dialogue_Prerequisite frRem = new Dialogue_Prerequisite();
            frRem.ShowDialog();

        }

        private void OneTime_Click(object sender, EventArgs e)
        {
            One_Time_Dialogue frRem = new One_Time_Dialogue();
            frRem.ShowDialog();
        }

        private void AddItems_Click(object sender, EventArgs e)
        {
            Add_Items frRem = new Add_Items();
            frRem.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dialogBody.Text = dialogBody.Text.Insert(dialogBody.SelectionStart, "%time");
        }

        private void ShowBook_Click(object sender, EventArgs e)
        {
            dialogBody.Text = dialogBody.Text.Insert(dialogBody.SelectionStart, "%book");
        }

        private void CreateOverhaul_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog create = new FolderBrowserDialog();
            create.Description = $"Select folder for {systemName}'s Overhaul Mod";
            if (create.ShowDialog() == DialogResult.Cancel)
                return;
            else
            {
                overhaulDirectory = create.SelectedPath;
                Directory.CreateDirectory(overhaulDirectory + "\\assets");
                //save dialogue
                if (regularDialog.Checked == true)
                {
                    File.WriteAllText(overhaulDirectory + "\\assets\\Dialogue.json", JsonConvert.SerializeObject(content, new JsonSerializerSettings { Formatting = Formatting.Indented, NullValueHandling = NullValueHandling.Ignore }));
                    if (marriage.Count > 0)
                    {
                        File.WriteAllText(overhaulDirectory + "\\assets\\MarriageDialogue.json", JsonConvert.SerializeObject(new JsonSerializerSettings { Formatting = Formatting.Indented, NullValueHandling = NullValueHandling.Ignore }));

                    }
                }
                if (marriageDialog.Checked == true)
                {
                    File.WriteAllText(overhaulDirectory + "\\assets\\MarriageDialogue.json", JsonConvert.SerializeObject(new JsonSerializerSettings { Formatting = Formatting.Indented, NullValueHandling = NullValueHandling.Ignore }));
                    if (content.Count > 0)
                    {
                        File.WriteAllText(overhaulDirectory + "\\assets\\Dialogue.json", JsonConvert.SerializeObject(content, new JsonSerializerSettings { Formatting = Formatting.Indented, NullValueHandling = NullValueHandling.Ignore }));

                    }
                }
                //Create Manifest File
                manifestCreator frRem = new manifestCreator();
                dialogueBoutique.overhaulDirectory = create.SelectedPath;
                frRem.Text = "Overhaul Manifest Mode";
                frRem.ShowDialog();
                //Build Content.json
                if(File.Exists(portraitTemp))
                {
                    File.Copy(portraitTemp, overhaulDirectory + "\\assets\\Portrait.png");
                }
                PatchVariable mainDialog = new PatchVariable
                {
                    LogName = "Main Dialogue",
                    Action = "Load",
                    Target = $"Characters/Dialogue/{systemName}",
                    FromFile = "assets/Dialogue.json",
                };
                PatchVariable patchMarriage = new PatchVariable
                {
                    LogName = "Marriage Dialogue",
                    Action = "Load",
                    Target = $"Characters/Dialogue/MarriageDialogue{systemName}",
                    FromFile = "assets/dialogue/MarriageDialogue.json",
                };
                PatchVariable patchEngagement = new PatchVariable
                {
                    LogName = "Engagement Dialogue",
                    Action = "EditData",
                    Target = "Data/EngagementDialogue",
                    Entries = new Dictionary<string, string>
                    {
                        [$"{systemName}0"] = $"I'm so nervous and excited!$1",
                        [$"{systemName}1"] = $"Pinch me.. I feel like I'm in a dream.$1",
                    }
                };
                if (File.Exists(overhaulDirectory + "\\assets\\MarriageDialogue.json"))
                {
                    overhaulPatch = new PatchVariable[] { mainDialog, patchMarriage, patchEngagement };
                }
                else
                {
                    overhaulPatch = new PatchVariable[] { mainDialog };
                }
                ContentVariable contentPatch = new ContentVariable
                {

                    Format = "1.19.0",
                    Changes = overhaulPatch
                };
                try
                {
                    File.WriteAllText(overhaulDirectory + "//content.json", JsonConvert.SerializeObject(contentPatch, new JsonSerializerSettings { Formatting = Formatting.Indented, NullValueHandling = NullValueHandling.Ignore }));
                    //Mod Created
                    MessageBox.Show("Overhaul Mod complete!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Process.Start(overhaulDirectory);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "\nYou cannot access this directory with your current permissions.\nEither choose another Location or Run NPC Creator as an Administrator.", "Unauthorized Access Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Directory.CreateDirectory(Environment.CurrentDirectory + "\\Save Data\\temp");
            portraitTemp = Environment.CurrentDirectory + "\\Save Data\\temp\\Portrait.png";
            try
            {
                OpenFileDialog importDialog = new OpenFileDialog();

                if (importDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    File.Copy(importDialog.FileName, portraitTemp);

                    try
                    {
                        //Get Spritesheet
                        image1 = new Bitmap(portraitTemp);
                        Rectangle pixelAreaForTile = this.GetTileArea(tileIndex: 0, tileWidth: 64, tileHeight: 64, sheetWidthInTiles: 2);               // Rectangle rect = new Rectangle(xmin, ymin, xmaximum, ymaximum);
                        Bitmap spriteFrame = image1.Clone(pixelAreaForTile, PixelFormat.DontCare);
                        portraitSample.Image = spriteFrame;
                        portFrame.Enabled = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message + "\n You cannot exceed the number of frames your Spritesheet has!!", "Why can't I hold all these Frames?!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Please ensure:\n -The image is not already in the img folder.\n -That you have created a system folder.", "Flagarant Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
