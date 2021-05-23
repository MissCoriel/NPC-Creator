using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NPC_Creator
{
    public partial class ShowFrame : Form
    {
        public ShowFrame()
        {
            InitializeComponent();
        }
        Bitmap image1;
        public string spriteTemp = Environment.CurrentDirectory + "\\Save Data\\temp\\tempSprites.png";

        private void ShowFrame_Load(object sender, EventArgs e)
        {
            if(Directory.Exists(Environment.CurrentDirectory + "\\Save Data\\temp"))
            {
                if(File.Exists(spriteTemp))
                {
                    File.Delete(spriteTemp);
                }
            }

            if (File.Exists(Environment.CurrentDirectory + "\\Save Data\\TempEventInformation\\tempEventActorData.txt"))
            {
                npcList.Items.Add("farmer(alternate)");

                npcList.Items.AddRange(File.ReadAllLines(Environment.CurrentDirectory + "\\Save Data\\TempEventInformation\\tempEventActorData.txt"));
            }
            if (!File.Exists(Environment.CurrentDirectory + "\\Save Data\\TempEventInformation\\tempEventActorData.txt"))
            {
                npcList.Items.Add("farmer(alternate)");
                npcList.Items.Add("farmer");
                npcList.Items.AddRange(File.ReadAllLines(Environment.CurrentDirectory + "\\Common Data\\NPCNames.txt"));
            }

        }
        public Rectangle GetTileArea(int tileIndex, int tileWidth, int tileHeight, int sheetWidthInTiles)
        {
            int x = tileIndex % sheetWidthInTiles;
            int y = tileIndex / sheetWidthInTiles;
            return new Rectangle(x * tileWidth, y * tileHeight, tileWidth, tileHeight);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(Environment.CurrentDirectory + "\\Save Data\\temp"))
            {
                Directory.CreateDirectory(Environment.CurrentDirectory + "\\Save Data\\temp");
            }

            OpenFileDialog import = new OpenFileDialog();
            if (import.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {

                File.Copy(import.FileName, spriteTemp, true);
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
            if (File.Exists(spriteTemp))
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
            string parse = $"showFrame {npcList.Text} {animationFrame.Value}";
            if(npcList.Text == "farmer(alternate)")
            {
                parse = $"showFrame {animationFrame.Value}";
            }
            Conditions mw = (Conditions)Application.OpenForms["Conditions"];
            mw.addCommandtoList(parse);
            this.Close();

        }
    }
}
