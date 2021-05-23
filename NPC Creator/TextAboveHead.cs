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
    public partial class TextAboveHead : Form
    {
        public TextAboveHead()
        {
            InitializeComponent();
        }

        private void TextAboveHead_Load(object sender, EventArgs e)
        {
            if (File.Exists(Environment.CurrentDirectory + "\\Save Data\\TempEventInformation\\tempEventActorData.txt"))
            {
                npcList.Items.AddRange(File.ReadAllLines(Environment.CurrentDirectory + "\\Save Data\\TempEventInformation\\tempEventActorData.txt"));
            }
            if (!File.Exists(Environment.CurrentDirectory + "\\Save Data\\TempEventInformation\\tempEventActorData.txt"))
            {
                npcList.Items.AddRange(File.ReadAllLines(Environment.CurrentDirectory + "\\Common Data\\NPCNames.txt"));
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string parse = $"textAboveHead {npcList.Text} \"{dialogBody.Text}\"";
            Conditions mw = (Conditions)Application.OpenForms["Conditions"];
            mw.addCommandtoList(parse);
            this.Close();

        }
    }
}
