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
using System.Drawing.Imaging;
using System.Xml.Schema;
using Newtonsoft.Json;
using System.Security.Policy;

namespace NPC_Creator
{
    public partial class AnimationStation : Form
    {
        Bitmap image1; //Frames
        Bitmap image2;
        string systemName;
        public Dictionary<string, string> content = new Dictionary<string, string>();
        public List<int> animationList = new List<int>();
        public List<string> rawOpeningList = new List<string>();
        public List<string> rawLoopingList = new List<string>();
        public List<string> rawEndingList = new List<string>();
        private bool independantMode;
        public System.Windows.Forms.Timer framePause = new System.Windows.Forms.Timer();
        public bool playToggle;


        public AnimationStation()
        {
            InitializeComponent();
        }
        public void updateList(string commitChange)
        {
            prepDescrip.Items.Add(commitChange);
        }
        private IEnumerable<string> GetItems(ListBox listbox)
        {
            foreach (object entry in listbox.Items)
                yield return entry.ToString();
        }

        public Rectangle GetTileArea(int tileIndex, int tileWidth, int tileHeight, int sheetWidthInTiles)
        {
            int x = tileIndex % sheetWidthInTiles;
            int y = tileIndex / sheetWidthInTiles;
            return new Rectangle(x * tileWidth, y * tileHeight, tileWidth, tileHeight);
        }
        private void AnimationStation_Load(object sender, EventArgs e)
        {
            independantMode = scheduleStudio.independentAnimationMode;
            systemName = scheduleStudio.importSystem;
            if (independantMode == false && File.Exists(Environment.CurrentDirectory + $"\\Save Data\\{systemName}_saveData\\animationSave.json"))
            {
                string json = File.ReadAllText(Environment.CurrentDirectory + $"\\Save Data\\{systemName}_saveData\\animationSave.json");
                var recentLoad = JsonConvert.DeserializeObject<Dictionary<string, string>>(json);
                foreach (KeyValuePair<string, string> pair in recentLoad)
                {
                    prepDescrip.Items.Add($"{pair.Key}: {pair.Value}");
                }

            }
            try
            {
                if(independantMode == false)
                {
                    //Get Spritesheet
                    image1 = new Bitmap(Environment.CurrentDirectory + $"\\Export\\[CP]{systemName}\\assets\\img\\spritesheet.png");
                    Rectangle pixelAreaForTile = this.GetTileArea(tileIndex: 0, tileWidth: 16, tileHeight: 32, sheetWidthInTiles: 4);               // Rectangle rect = new Rectangle(xmin, ymin, xmaximum, ymaximum);
                    Bitmap spriteFrame = image1.Clone(pixelAreaForTile, PixelFormat.DontCare);
                    pictureBox1.Image = spriteFrame;

                }
                if(independantMode == true)
                {
                    image1 = new Bitmap(scheduleStudio.spriteTemp);
                    Rectangle pixelAreaForTile = this.GetTileArea(tileIndex: 0, tileWidth: 16, tileHeight: 32, sheetWidthInTiles: 4);               // Rectangle rect = new Rectangle(xmin, ymin, xmaximum, ymaximum);
                    Bitmap spriteFrame = image1.Clone(pixelAreaForTile, PixelFormat.DontCare);
                    pictureBox1.Image = spriteFrame;

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n You cannot exceed the number of frames your Spritesheet has!!", "Why can't I hold all these Frames?!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void addFrame_Click(object sender, EventArgs e)
        {
            frameList.Items.Add(frameCount.Value);
            rawLoopingList.Add(frameCount.Value.ToString());
        }

        private void deleteSelection_Click(object sender, EventArgs e)
        {
            rawLoopingList.Remove(frameList.SelectedItem.ToString());
            frameList.Items.Remove(frameList.SelectedItem);
        }

        private void clearAll_Click(object sender, EventArgs e)
        {
            frameList.Items.Clear();
            rawLoopingList.Clear();
        }

        private void addToList_Click(object sender, EventArgs e)
        {

            string main = $"{animKey.Text}: " + string.Join(" ", this.GetItems(openFrame)) + "/" + string.Join(" ", this.GetItems(frameList)) + "/" + string.Join(" ", this.GetItems(endFrame));
            prepDescrip.Items.Add(main);
            openFrame.Items.Clear();
            frameList.Items.Clear();
            endFrame.Items.Clear();
        }

        private void delSelected_Click(object sender, EventArgs e)
        {
            prepDescrip.Items.Remove(prepDescrip.SelectedItem);
        }

        private void clearList_Click(object sender, EventArgs e)
        {
            prepDescrip.Items.Clear();
        }

        private void createFile_Click(object sender, EventArgs e)
        {
            foreach (var item in prepDescrip.Items)
            {
                string entry = item.ToString();
                string key = entry.Substring(0, entry.IndexOf(':'));
                string value = entry.Substring(entry.IndexOf(':') + 2); // +1 to get past :, and +1 to get past the space
                try
                {
                    content.Add(key, value);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "\nOnly the first key was accepted... Check your Animation List", "Duplicate Keys Detected!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //create save
                if(independantMode == false)
                {
                    File.WriteAllText(Environment.CurrentDirectory + $"\\Save Data\\{systemName}_saveData\\animationSave.json", JsonConvert.SerializeObject(content, new JsonSerializerSettings { Formatting = Formatting.Indented, NullValueHandling = NullValueHandling.Ignore }));

                }
                if(independantMode == true)
                {
                    File.WriteAllText(Environment.CurrentDirectory + $"\\Save Data\\temp\\animationTemp.json", JsonConvert.SerializeObject(content, new JsonSerializerSettings { Formatting = Formatting.Indented, NullValueHandling = NullValueHandling.Ignore }));
                    SaveFileDialog saveAnimation = new SaveFileDialog();
                    saveAnimation.InitialDirectory = Environment.CurrentDirectory;
                    saveAnimation.Title = "Export Dialogue";
                    saveAnimation.CheckPathExists = true;
                    saveAnimation.DefaultExt = "json";
                    saveAnimation.Filter = "json files (*.json)|*.json";
                    saveAnimation.FilterIndex = 1;
                    saveAnimation.RestoreDirectory = true;
                    if(saveAnimation.ShowDialog() == DialogResult.OK)
                    {
                        File.WriteAllText(saveAnimation.FileName, JsonConvert.SerializeObject(content, new JsonSerializerSettings { Formatting = Formatting.Indented, NullValueHandling = NullValueHandling.Ignore }));

                    }

                }

            }
            PatchVariable AnimationSave = new PatchVariable
            {
                Action = "EditData",
                Target = "Data/animationDescriptions",
                Entries = content
            };
            ContentVariable animPatching = new ContentVariable
            {
                Changes = new PatchVariable[] { AnimationSave }
            };
            string path = Path.Combine($"Export/[CP]{systemName}/assets/anim", "Animations.json");
            File.WriteAllText(path, JsonConvert.SerializeObject(animPatching, new JsonSerializerSettings { Formatting = Formatting.Indented, NullValueHandling = NullValueHandling.Ignore }));
            string save = Path.Combine($"Export/[CP]{systemName}/assets/anim", "Animations_backup.json");
            File.WriteAllText(save, JsonConvert.SerializeObject(animPatching, new JsonSerializerSettings { Formatting = Formatting.Indented, NullValueHandling = NullValueHandling.Ignore }));
            MessageBox.Show("Animation File Created!", "Animation File Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void recentLoad_Click(object sender, EventArgs e)
        {
            prepDescrip.Items.Clear();
            string json = File.ReadAllText(Environment.CurrentDirectory + $"\\Save Data\\{systemName}_saveData\\animationSave.json");
            var recentLoad = JsonConvert.DeserializeObject<Dictionary<string, string>>(json);
            foreach (KeyValuePair<string, string> pair in recentLoad)
            {
                prepDescrip.Items.Add($"{pair.Key}: {pair.Value}");
            }

        }

        private void addInitial_Click(object sender, EventArgs e)
        {
            openFrame.Items.Add(frameCount.Value);
            rawOpeningList.Add(frameCount.Value.ToString());
        }

        private void addClose_Click(object sender, EventArgs e)
        {
            endFrame.Items.Add(frameCount.Value);
            rawEndingList.Add(frameCount.Value.ToString());
        }

        private void openDel_Click(object sender, EventArgs e)
        {
            rawOpeningList.Remove(openFrame.SelectedItem.ToString());
            openFrame.Items.Remove(openFrame.SelectedItem);
        }

        private void openClear_Click(object sender, EventArgs e)
        {
            openFrame.Items.Clear();
            rawOpeningList.Clear();
        }

        private void endDelete_Click(object sender, EventArgs e)
        {
            rawEndingList.Remove(endFrame.SelectedItem.ToString());
            endFrame.Items.Remove(endFrame.SelectedItem);
        }

        private void endClear_Click(object sender, EventArgs e)
        {
            endFrame.Items.Clear();
            rawEndingList.Clear();
        }

        private void frameCount_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (independantMode == false)
                {
                    //Get Spritesheet
                    image1 = new Bitmap(Environment.CurrentDirectory + $"\\Export\\[CP]{systemName}\\assets\\img\\spritesheet.png");
                    Rectangle pixelAreaForTile = this.GetTileArea(tileIndex: (int)frameCount.Value, tileWidth: 16, tileHeight: 32, sheetWidthInTiles: 4);               // Rectangle rect = new Rectangle(xmin, ymin, xmaximum, ymaximum);
                    Bitmap spriteFrame = image1.Clone(pixelAreaForTile, PixelFormat.DontCare);
                    pictureBox1.Image = spriteFrame;

                }
                if (independantMode == true)
                {
                    image1 = new Bitmap(scheduleStudio.spriteTemp);
                    Rectangle pixelAreaForTile = this.GetTileArea(tileIndex: (int)frameCount.Value, tileWidth: 16, tileHeight: 32, sheetWidthInTiles: 4);               // Rectangle rect = new Rectangle(xmin, ymin, xmaximum, ymaximum);
                    Bitmap spriteFrame = image1.Clone(pixelAreaForTile, PixelFormat.DontCare);
                    pictureBox1.Image = spriteFrame;

                }

            }
            catch (Exception ex)
            {
                frameCount.Value = 0;

            }

        }
        void AcquireAnimationFrames()
        {
            foreach(string item in rawOpeningList)
            {
                int conversion = Int32.Parse(item);
                animationList.Add(conversion);
            }
            foreach (string item in rawLoopingList)
            {
                int conversion = Int32.Parse(item);
                animationList.Add(conversion);
            }
            foreach (string item in rawLoopingList)
            {
                int conversion = Int32.Parse(item);
                animationList.Add(conversion);
            }
            foreach (string item in rawLoopingList)
            {
                int conversion = Int32.Parse(item);
                animationList.Add(conversion);
            }
            foreach (string item in rawEndingList)
            {
                int conversion = Int32.Parse(item);
                animationList.Add(conversion);
            }

        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            if(openFrame.Items.Count == 0 || frameList.Items.Count == 0 || endFrame.Items.Count == 0)
            {
                MessageBox.Show("You have to have at least one frame in each category in order to play the animation", "Insufficient Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                animationList.Clear();
                AcquireAnimationFrames();
                playToggle = true;
                framePause.Interval = 120;
                framePause.Tick += new System.EventHandler(framePause_Tick);
                framePause.Start();
            }
        }
        private void framePause_Tick(object sender, EventArgs e)
        {
            if(playToggle == true)
            {
                if(animationList.Count != 0)
                {
                    int previewFrame = animationList[0];
                    image2 = new Bitmap(Environment.CurrentDirectory + $"\\Export\\[CP]{systemName}\\assets\\img\\spritesheet.png");
                    Rectangle pixelAreaForTile = this.GetTileArea(tileIndex: previewFrame, tileWidth: 16, tileHeight: 32, sheetWidthInTiles: 4);               // Rectangle rect = new Rectangle(xmin, ymin, xmaximum, ymaximum);
                    Bitmap spriteFrame = image2.Clone(pixelAreaForTile, PixelFormat.DontCare);
                    testAnimation.Image = spriteFrame;
                    animationList.Remove(previewFrame);
                    image2.Dispose();
                }
            }
            if(animationList.Count == 0)
            {
                playToggle = false;
                framePause.Stop();
            }
        }
    }
}
