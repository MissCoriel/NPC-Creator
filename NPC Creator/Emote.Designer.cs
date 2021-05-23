namespace NPC_Creator
{
    partial class Emote
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.npcList = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.emoteList = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select or Type NPC Name";
            // 
            // npcList
            // 
            this.npcList.FormattingEnabled = true;
            this.npcList.Location = new System.Drawing.Point(15, 35);
            this.npcList.Name = "npcList";
            this.npcList.Size = new System.Drawing.Size(121, 21);
            this.npcList.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(193, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Select Emote";
            // 
            // emoteList
            // 
            this.emoteList.FormattingEnabled = true;
            this.emoteList.Items.AddRange(new object[] {
            "Blank",
            "Empty Watercan",
            "Question Mark",
            "Frustrated/Mad",
            "Exclaimation",
            "Heart",
            "Sleep",
            "Sweatdrop",
            "Smile",
            "X",
            "...",
            "No Tackle",
            "Golden Plaque",
            "Controller",
            "Music Note",
            "Blush"});
            this.emoteList.Location = new System.Drawing.Point(169, 35);
            this.emoteList.Name = "emoteList";
            this.emoteList.Size = new System.Drawing.Size(121, 21);
            this.emoteList.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(116, 75);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Commit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Emote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 122);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.emoteList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.npcList);
            this.Controls.Add(this.label1);
            this.Name = "Emote";
            this.Text = "Emote";
            this.Load += new System.EventHandler(this.Emote_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox npcList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox emoteList;
        private System.Windows.Forms.Button button1;
    }
}