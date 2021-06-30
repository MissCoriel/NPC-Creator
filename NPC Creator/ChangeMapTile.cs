using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NPC_Creator
{
    public partial class ChangeMapTile : Form
    {
        double realLayer;
        public ChangeMapTile()
        {
            InitializeComponent();
        }

        private void layerBar_Scroll(object sender, EventArgs e)
        {
            realLayer = (double)layerBar.Value / 100;
            layerLabel.Text = $"Layer: {realLayer}";
        }

        private void Commit_Click(object sender, EventArgs e)
        {
            string parse = $"changeMapTile {realLayer} {tileX.Value} {tileY.Value} {tileIndex.Value}";
            Conditions mw = (Conditions)Application.OpenForms["Conditions"];
            mw.addCommandtoList(parse);
            this.Close();

        }
    }
}
