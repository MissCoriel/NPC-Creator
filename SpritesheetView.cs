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

namespace NPC_Creator
{
    public partial class SpritesheetView : Form
    {
        string systemName;
        
        public SpritesheetView()
        {
            InitializeComponent();
        }

        private void SpritesheetView_Load(object sender, EventArgs e)
        {
            
            systemName = Form1.exportSystem;
            //MessageBox.Show($"System Name is {systemName}", "Test", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            string spriteLocation = Environment.CurrentDirectory + $"\\Export\\[CP]{systemName}\\assets\\img\\spritesheet.png";
            try
            {
                OpenFileDialog importDialog = new OpenFileDialog();

                if (importDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    File.Copy(importDialog.FileName, spriteLocation);

                    Bitmap addSprite = new Bitmap(spriteLocation);
                    spriteSheet.Image = addSprite;


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Please ensure:\n -The image is not already in the img folder.\n -That you have created a system folder.", "Flagarant Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void CloseWindow_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
