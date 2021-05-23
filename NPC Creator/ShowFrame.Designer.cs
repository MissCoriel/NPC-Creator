namespace NPC_Creator
{
    partial class ShowFrame
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.animationFrame = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.npcList = new System.Windows.Forms.ComboBox();
            this.spriteImage = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.animationFrame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spriteImage)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.animationFrame);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.npcList);
            this.groupBox1.Controls.Add(this.spriteImage);
            this.groupBox1.Location = new System.Drawing.Point(6, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(290, 213);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stop Animation Details";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(127, 164);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(145, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Commit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Show Frame:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "NPC:";
            // 
            // animationFrame
            // 
            this.animationFrame.Location = new System.Drawing.Point(170, 78);
            this.animationFrame.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.animationFrame.Name = "animationFrame";
            this.animationFrame.Size = new System.Drawing.Size(52, 20);
            this.animationFrame.TabIndex = 3;
            this.animationFrame.ValueChanged += new System.EventHandler(this.animationFrame_ValueChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 164);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Load";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // npcList
            // 
            this.npcList.FormattingEnabled = true;
            this.npcList.Location = new System.Drawing.Point(162, 30);
            this.npcList.Name = "npcList";
            this.npcList.Size = new System.Drawing.Size(121, 21);
            this.npcList.TabIndex = 1;
            // 
            // spriteImage
            // 
            this.spriteImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.spriteImage.Location = new System.Drawing.Point(22, 30);
            this.spriteImage.Name = "spriteImage";
            this.spriteImage.Size = new System.Drawing.Size(64, 128);
            this.spriteImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.spriteImage.TabIndex = 0;
            this.spriteImage.TabStop = false;
            // 
            // ShowFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 234);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Name = "ShowFrame";
            this.Text = "ShowFrame";
            this.Load += new System.EventHandler(this.ShowFrame_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.animationFrame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spriteImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown animationFrame;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox npcList;
        private System.Windows.Forms.PictureBox spriteImage;
    }
}