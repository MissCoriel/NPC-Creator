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
    public partial class AddObject : Form
    {
        Bitmap image1;
        public AddObject()
        {
            InitializeComponent();
        }
        public Rectangle GetTileArea(int tileIndex, int tileWidth, int tileHeight, int sheetWidthInTiles)
        {
            int x = tileIndex % sheetWidthInTiles;
            int y = tileIndex / sheetWidthInTiles;
            return new Rectangle(x * tileWidth, y * tileHeight, tileWidth, tileHeight);
        }


        private void AddObject_Load(object sender, EventArgs e)
        {
            if (File.Exists(Environment.CurrentDirectory + "\\Common Data\\springobjects.png"))
            {
                image1 = new Bitmap(Environment.CurrentDirectory + "\\Common Data\\springobjects.png");
                Rectangle pixelAreaForTile = this.GetTileArea(tileIndex: 0, tileWidth: 16, tileHeight: 16, sheetWidthInTiles: 24);               // Rectangle rect = new Rectangle(xmin, ymin, xmaximum, ymaximum);
                Bitmap spriteFrame = image1.Clone(pixelAreaForTile, PixelFormat.DontCare);
                springObject.Image = spriteFrame;

            }

        }

        private void objectFrame_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists(Environment.CurrentDirectory + "\\Common Data\\springobjects.png"))
                {
                    image1 = new Bitmap(Environment.CurrentDirectory + "\\Common Data\\springobjects.png");
                    Rectangle pixelAreaForTile = this.GetTileArea(tileIndex: (int)objectFrame.Value, tileWidth: 16, tileHeight: 16, sheetWidthInTiles: 24);               // Rectangle rect = new Rectangle(xmin, ymin, xmaximum, ymaximum);
                    Bitmap spriteFrame = image1.Clone(pixelAreaForTile, PixelFormat.DontCare);
                    springObject.Image = spriteFrame;

                }

            }
            catch (Exception)
            {
                objectFrame.Value = 0;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int layerID;
            if (string.IsNullOrWhiteSpace(layerSelect.Text))
            {
                string parse = $"addObject {objectX.Value} {objectY.Value} {objectFrame.Value}";
                Conditions mw = (Conditions)Application.OpenForms["Conditions"];
                mw.addCommandtoList(parse);
                this.Close();

            }
            if (!string.IsNullOrWhiteSpace(layerSelect.Text))
            {
                if (layerSelect.Text == "Below")
                {
                    layerID = 0;
                    string parse = $"addObject {objectX.Value} {objectY.Value} {objectFrame.Value} {layerID}";
                    Conditions mw = (Conditions)Application.OpenForms["Conditions"];
                    mw.addCommandtoList(parse);
                    this.Close();

                }
                if (layerSelect.Text == "Above")
                {
                    layerID = 1;
                    string parse = $"addObject {objectX.Value} {objectY.Value} {objectFrame.Value} {layerID}";
                    Conditions mw = (Conditions)Application.OpenForms["Conditions"];
                    mw.addCommandtoList(parse);
                    this.Close();

                }

            }
        }
    }
}
