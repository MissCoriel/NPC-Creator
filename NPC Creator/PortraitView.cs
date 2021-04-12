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
    public partial class PortraitView : Form
    {
        
        public PortraitView()
        {
            InitializeComponent();
        }

        private void PortraitView_Load(object sender, EventArgs e)
        {
            string systemName = Form1.exportSystem;
            //MessageBox.Show($"System Name is {systemName}", "Test", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            string spriteLocation = Environment.CurrentDirectory + $"\\Export\\[CP]{systemName}\\assets\\img\\portrait.png";
            if (File.Exists(spriteLocation))
            {
                try
                {
                    Bitmap addSprite = new Bitmap(Environment.CurrentDirectory + $"\\Export\\[CP]{systemName}\\assets\\img\\portrait.png");
                    portraitSheet.Image = addSprite;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "\nHow did you even get here!?");
                }
            }
        }

        private void CloseView_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

