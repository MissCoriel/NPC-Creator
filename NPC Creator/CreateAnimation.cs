using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace NPC_Creator
{
    public partial class Create_Animation : Form
    {
        Bitmap image1;
        Bitmap image2;
        public string spriteTemp = Environment.CurrentDirectory + "\\Save Data\\temp\\tempSprites.png";
        List<string> animationFrameList = new List<string>();
        public string flipped = "false";
        public string looped = "false";
        public bool playToggle = false;
        public List<int> AnimationFrameQue = new List<int>();
        public int frameCount = 0;
        public System.Windows.Forms.Timer framePause = new System.Windows.Forms.Timer();
        public int previewFrame;


        public Create_Animation()
        {
            InitializeComponent();
        }
        public Rectangle GetTileArea(int tileIndex, int tileWidth, int tileHeight, int sheetWidthInTiles)
        {
            int x = tileIndex % sheetWidthInTiles;
            int y = tileIndex / sheetWidthInTiles;
            return new Rectangle(x * tileWidth, y * tileHeight, tileWidth, tileHeight);
        }

        private void Create_Animation_Load(object sender, EventArgs e)
        {
            //Load NPC List.. if the Temp list exists, use instead
            if (File.Exists(Environment.CurrentDirectory + "\\Save Data\\TempEventInformation\\tempEventActorData.txt"))
            {
                npcList.Items.AddRange(File.ReadAllLines(Environment.CurrentDirectory + "\\Save Data\\TempEventInformation\\tempEventActorData.txt"));
                npcList.Items.Remove("farmer");
            }
            else
            {
                npcList.Items.AddRange(File.ReadAllLines(Environment.CurrentDirectory + "\\Common Data\\NPCNames.txt"));
            }
            MessageBox.Show("Preview can be janky sometimes.  If your animation is not showing properly, press again.  It should work in two or three clicks.", "Disclaimer:", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Check to see if a temp Folder is made
            if(!Directory.Exists(Environment.CurrentDirectory + "\\Save Data\\temp"))
            {
                Directory.CreateDirectory(Environment.CurrentDirectory + "\\Save Data\\temp");
            }
            OpenFileDialog import = new OpenFileDialog();
            if (import.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                
                File.Copy(import.FileName, spriteTemp, true);
                groupBox3.Enabled = true;
                try
                {
                    //Get Spritesheet
                    image1 = new Bitmap(spriteTemp);
                    Rectangle pixelAreaForTile = this.GetTileArea(tileIndex: 0, tileWidth: 16, tileHeight: 32, sheetWidthInTiles: 4);               // Rectangle rect = new Rectangle(xmin, ymin, xmaximum, ymaximum);
                    Bitmap spriteFrame = image1.Clone(pixelAreaForTile, PixelFormat.DontCare);
                    spriteImage.Image = spriteFrame;
                    image1.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "\n You cannot exceed the number of frames your Spritesheet has!!", "Why can't I hold all these Frames?!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void animationFrame_ValueChanged(object sender, EventArgs e)
        {
            if(File.Exists(spriteTemp))
            {
                try
                {
                    //Get Spritesheet
                    image1 = new Bitmap(spriteTemp);
                    Rectangle pixelAreaForTile = this.GetTileArea(tileIndex: (int)animationFrame.Value, tileWidth: 16, tileHeight: 32, sheetWidthInTiles: 4);               // Rectangle rect = new Rectangle(xmin, ymin, xmaximum, ymaximum);
                    Bitmap spriteFrame = image1.Clone(pixelAreaForTile, PixelFormat.DontCare);
                    spriteImage.Image = spriteFrame;
                    image1.Dispose();
                }
                catch (Exception ex)
                {
                    animationFrame.Value = 0;

                }

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frameList.Items.Add(animationFrame.Value);
            animationFrameList.Add(animationFrame.Value.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            animationFrameList.Remove(frameList.SelectedItem.ToString());
            frameList.Items.Remove(frameList.SelectedItem);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            animationFrameList.Clear();
            frameList.Items.Clear();
        }

        private void isFlipped_CheckedChanged(object sender, EventArgs e)
        {
            if(isFlipped.Checked == true)
            {
                flipped = "true";
            }
            if(isFlipped.Checked == false)
            {
                flipped = "false";
            }
        }

        private void isLooped_CheckedChanged(object sender, EventArgs e)
        {
            if(isLooped.Checked == true)
            {
                looped = "true";
            }
            if(isLooped.Checked == false)
            {
                looped = "false";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Create Command
            string parse = $"animate {npcList.Text} {flipped} {looped} {frameTime.Value} " + string.Join(" ", animationFrameList);
            Conditions mw = (Conditions)Application.OpenForms["Conditions"];
            mw.addCommandtoList(parse);
            if(playToggle == true)
            {
                playToggle = false;
                framePause.Stop();
            }
            this.Close();

        }
        void AcquireAnimationFrames()
        {
            foreach(string item in animationFrameList)
            {
                int conversion = Int32.Parse(item);
                AnimationFrameQue.Add(conversion);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if(frameList.Items.Count == 0 || frameTime.Value == 0)
            {
                MessageBox.Show("Cannot make a preview with missing Data.. Please add Frames or a pause interval!", "You can't divide by Zero!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                AnimationFrameQue.Clear();
                AcquireAnimationFrames();
                playToggle = true;
                framePause.Interval = (int)frameTime.Value;
                framePause.Tick += new System.EventHandler(framePause_Tick);
                framePause.Start();

            }

        }
        private void framePause_Tick(object sender, EventArgs e)
        {
            if(playToggle == true)
            {
                if(AnimationFrameQue.Count != 0)
                {
                    previewFrame = AnimationFrameQue[0];
                    //MessageBox.Show($"Frame: {previewFrame}", "Test", MessageBoxButtons.OK);
                    labelFrame.Text = $"Frame: {previewFrame} at {frameTime.Value}ms";
                    image2 = new Bitmap(spriteTemp);
                    Rectangle pixelAreaForTile = this.GetTileArea(tileIndex: previewFrame, tileWidth: 16, tileHeight: 32, sheetWidthInTiles: 4);               // Rectangle rect = new Rectangle(xmin, ymin, xmaximum, ymaximum);
                    Bitmap spriteFrame = image2.Clone(pixelAreaForTile, PixelFormat.DontCare);
                    preview.Image = spriteFrame;
                    AnimationFrameQue.Remove(previewFrame);
                    image2.Dispose();
                }
                if(AnimationFrameQue.Count == 0)
                {
                    AnimationFrameQue.Clear();
                    AcquireAnimationFrames();

                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            playToggle = false;
            framePause.Stop();
            AnimationFrameQue.Clear();
            preview.Image= null;
            previewFrame = 0;
            labelFrame.Text = "Frame:";
        }
    }

}


