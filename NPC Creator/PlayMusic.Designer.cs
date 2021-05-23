namespace NPC_Creator
{
    partial class PlayMusic
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
            this.musicID = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select or Type the Song ID";
            // 
            // musicID
            // 
            this.musicID.FormattingEnabled = true;
            this.musicID.Location = new System.Drawing.Point(15, 36);
            this.musicID.Name = "musicID";
            this.musicID.Size = new System.Drawing.Size(121, 21);
            this.musicID.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(36, 63);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Commit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PlayMusic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(153, 93);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.musicID);
            this.Controls.Add(this.label1);
            this.Name = "PlayMusic";
            this.Text = "PlayMusic";
            this.Load += new System.EventHandler(this.PlayMusic_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox musicID;
        private System.Windows.Forms.Button button1;
    }
}