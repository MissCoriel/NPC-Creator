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
    public partial class PlayMusic : Form
    {
        public PlayMusic()
        {
            InitializeComponent();
        }

        private void PlayMusic_Load(object sender, EventArgs e)
        {
            musicID.Items.AddRange(File.ReadAllLines(Environment.CurrentDirectory + "\\Common Data\\MusicList.txt"));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string parse = $"playMusic {musicID.Text}";
            Conditions mw = (Conditions)Application.OpenForms["Conditions"];
            mw.addCommandtoList(parse);
            this.Close();


        }
    }
}
