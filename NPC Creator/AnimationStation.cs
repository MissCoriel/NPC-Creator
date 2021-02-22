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
namespace NPC_Creator
{
    public partial class AnimationStation : Form
    {
        Bitmap image1; //Frames
        string systemName;
        public Dictionary<string, string> content = new Dictionary<string, string>();


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
            systemName = scheduleStudio.importSystem;
            try
            {
                //Get Spritesheet
                image1 = new Bitmap(Environment.CurrentDirectory + $"\\Export\\[CP]{systemName}\\assets\\img\\spritesheet.png");
                Rectangle pixelAreaForTile = this.GetTileArea(tileIndex: 0, tileWidth: 16, tileHeight: 32, sheetWidthInTiles: 4);               // Rectangle rect = new Rectangle(xmin, ymin, xmaximum, ymaximum);
                Bitmap spriteFrame = image1.Clone(pixelAreaForTile, PixelFormat.DontCare);
                pictureBox1.Image = spriteFrame;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n You cannot exceed the number of frames your Spritesheet has!!", "Why can't I hold all these Frames?!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void seeFrame_Click(object sender, EventArgs e)
        {
            try
            {
                //Get Spritesheet
                image1 = new Bitmap(Environment.CurrentDirectory + $"\\Export\\[CP]{systemName}\\assets\\img\\spritesheet.png");
                Rectangle pixelAreaForTile = this.GetTileArea(tileIndex: (int)frameCount.Value, tileWidth: 16, tileHeight: 32, sheetWidthInTiles: 4);               // Rectangle rect = new Rectangle(xmin, ymin, xmaximum, ymaximum);
                Bitmap spriteFrame = image1.Clone(pixelAreaForTile, PixelFormat.DontCare);
                pictureBox1.Image = spriteFrame;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n You cannot exceed the number of frames your Spritesheet has!!", "Why can't I hold all these Frames?!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void addFrame_Click(object sender, EventArgs e)
        {
            frameList.Items.Add(frameCount.Value);
        }

        private void deleteSelection_Click(object sender, EventArgs e)
        {
            frameList.Items.Remove(frameList.SelectedItem);
        }

        private void clearAll_Click(object sender, EventArgs e)
        {
            frameList.Items.Clear();
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
                File.WriteAllText(Environment.CurrentDirectory + $"\\Save Data\\{systemName}_saveData\\animationSave.json", JsonConvert.SerializeObject(content, new JsonSerializerSettings { Formatting = Formatting.Indented, NullValueHandling = NullValueHandling.Ignore }));

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
        }

        private void addClose_Click(object sender, EventArgs e)
        {
            endFrame.Items.Add(frameCount.Value);
        }

        private void openDel_Click(object sender, EventArgs e)
        {
            openFrame.Items.Remove(openFrame.SelectedItem);
        }

        private void openClear_Click(object sender, EventArgs e)
        {
            openFrame.Items.Clear();
        }

        private void endDelete_Click(object sender, EventArgs e)
        {
            endFrame.Items.Remove(endFrame.SelectedItem);
        }

        private void endClear_Click(object sender, EventArgs e)
        {
            endFrame.Items.Clear();
        }
    }
}
