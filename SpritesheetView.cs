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

namespace NPC_Creator
{
    public partial class SpritesheetView : Form
    {
        string systemName;
        Bitmap image1;
        public SpritesheetView()
        {
            InitializeComponent();
        }

        private void SpritesheetView_Load(object sender, EventArgs e)
        {
            
            systemName = Form1.exportSystem;
           if (File.Exists(Environment.CurrentDirectory + $"\\Export\\[CP]{systemName}\\assets\\img\\spritesheet.png"))
            {
                try
                {
                    Bitmap addSprite = new Bitmap(Environment.CurrentDirectory + $"\\Export\\[CP]{systemName}\\assets\\img\\spritesheet.png");
                    spriteSheet.Image = addSprite;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "How did you even get here without loading a sprite?!");
                }

            }
        }
        public Rectangle GetTileArea(int tileIndex, int tileWidth, int tileHeight, int sheetWidthInTiles)
        {
            int x = tileIndex % sheetWidthInTiles;
            int y = tileIndex / sheetWidthInTiles;
            return new Rectangle(x * tileWidth, y * tileHeight, tileWidth, tileHeight);
        }

        private void CloseWindow_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
