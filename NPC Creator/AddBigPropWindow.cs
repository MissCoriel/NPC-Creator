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
    public partial class AddBigPropWindow : Form
    {
        Bitmap image1;
        public AddBigPropWindow()
        {
            InitializeComponent();
        }
        public Rectangle GetTileArea(int tileIndex, int tileWidth, int tileHeight, int sheetWidthInTiles)
        {
            int x = tileIndex % sheetWidthInTiles;
            int y = tileIndex / sheetWidthInTiles;
            return new Rectangle(x * tileWidth, y * tileHeight, tileWidth, tileHeight);
        }

        private void AddBigPropWindow_Load(object sender, EventArgs e)
        {
            if(File.Exists(Environment.CurrentDirectory + "\\Common Data\\Craftables.png"))
            {
                image1 = new Bitmap(Environment.CurrentDirectory + "\\Common Data\\Craftables.png");
                Rectangle pixelAreaForTile = this.GetTileArea(tileIndex: 0, tileWidth: 16, tileHeight: 32, sheetWidthInTiles: 4);               // Rectangle rect = new Rectangle(xmin, ymin, xmaximum, ymaximum);
                Bitmap spriteFrame = image1.Clone(pixelAreaForTile, PixelFormat.DontCare);
                bigPropImg.Image = spriteFrame;

            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (File.Exists(Environment.CurrentDirectory + "\\Common Data\\Craftables.png"))
            {
                try
                {
                    image1 = new Bitmap(Environment.CurrentDirectory + $"\\Common Data\\Craftables.png");
                    Rectangle pixelAreaForTile = this.GetTileArea(tileIndex: (int)numericUpDown1.Value, tileWidth: 16, tileHeight: 32, sheetWidthInTiles: 4);               // Rectangle rect = new Rectangle(xmin, ymin, xmaximum, ymaximum);
                    Bitmap spriteFrame = image1.Clone(pixelAreaForTile, PixelFormat.DontCare);
                    bigPropImg.Image = spriteFrame;

                }
                catch (Exception)
                {
                    numericUpDown1.Value = 0;
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("To Have Visuals on this window, you must place an extracted copy of Craftables.png in the Common Data Folder.\nIf you need further help, contact an experienced modder on the Official or MissCoriel's Discord.", "How to see the props", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void AddCommand_Click(object sender, EventArgs e)
        {
            string parse = $"addBigProp {propX.Value} {propY.Value} {numericUpDown1.Value}";
            Conditions mw = (Conditions)Application.OpenForms["Conditions"];
            mw.addCommandtoList(parse);
            this.Close();

        }
    }
}
