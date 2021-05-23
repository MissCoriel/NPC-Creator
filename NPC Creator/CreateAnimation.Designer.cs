namespace NPC_Creator
{
    partial class Create_Animation
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
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.frameList = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.animationFrame = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.spriteImage = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.isLooped = new System.Windows.Forms.CheckBox();
            this.isFlipped = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.frameTime = new System.Windows.Forms.NumericUpDown();
            this.npcList = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button7 = new System.Windows.Forms.Button();
            this.labelFrame = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.preview = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.animationFrame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spriteImage)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frameTime)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.preview)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.frameList);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.animationFrame);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.spriteImage);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(223, 230);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sprite Animations";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(148, 149);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(58, 23);
            this.button4.TabIndex = 6;
            this.button4.Text = "Clear";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(150, 103);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(56, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // frameList
            // 
            this.frameList.FormattingEnabled = true;
            this.frameList.Location = new System.Drawing.Point(87, 103);
            this.frameList.Name = "frameList";
            this.frameList.Size = new System.Drawing.Size(57, 108);
            this.frameList.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(150, 64);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(56, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "ADD";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Frame";
            // 
            // animationFrame
            // 
            this.animationFrame.Location = new System.Drawing.Point(82, 67);
            this.animationFrame.Name = "animationFrame";
            this.animationFrame.Size = new System.Drawing.Size(62, 20);
            this.animationFrame.TabIndex = 0;
            this.animationFrame.ValueChanged += new System.EventHandler(this.animationFrame_ValueChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 166);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Load";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // spriteImage
            // 
            this.spriteImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.spriteImage.Location = new System.Drawing.Point(12, 32);
            this.spriteImage.Name = "spriteImage";
            this.spriteImage.Size = new System.Drawing.Size(64, 128);
            this.spriteImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.spriteImage.TabIndex = 0;
            this.spriteImage.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.isLooped);
            this.groupBox2.Controls.Add(this.isFlipped);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.frameTime);
            this.groupBox2.Controls.Add(this.npcList);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(229, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(162, 230);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Other Data";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(6, 201);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(150, 23);
            this.button5.TabIndex = 13;
            this.button5.Text = "Commit";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // isLooped
            // 
            this.isLooped.AutoSize = true;
            this.isLooped.Location = new System.Drawing.Point(9, 172);
            this.isLooped.Name = "isLooped";
            this.isLooped.Size = new System.Drawing.Size(99, 17);
            this.isLooped.TabIndex = 12;
            this.isLooped.Text = "Loop Animation";
            this.isLooped.UseVisualStyleBackColor = true;
            this.isLooped.CheckedChanged += new System.EventHandler(this.isLooped_CheckedChanged);
            // 
            // isFlipped
            // 
            this.isFlipped.AutoSize = true;
            this.isFlipped.Location = new System.Drawing.Point(9, 143);
            this.isFlipped.Name = "isFlipped";
            this.isFlipped.Size = new System.Drawing.Size(72, 17);
            this.isFlipped.TabIndex = 11;
            this.isFlipped.Text = "Flip Sprite";
            this.isFlipped.UseVisualStyleBackColor = true;
            this.isFlipped.CheckedChanged += new System.EventHandler(this.isFlipped_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Time Between each Frame (ms):";
            // 
            // frameTime
            // 
            this.frameTime.Location = new System.Drawing.Point(9, 103);
            this.frameTime.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.frameTime.Name = "frameTime";
            this.frameTime.Size = new System.Drawing.Size(118, 20);
            this.frameTime.TabIndex = 9;
            // 
            // npcList
            // 
            this.npcList.FormattingEnabled = true;
            this.npcList.Location = new System.Drawing.Point(6, 51);
            this.npcList.Name = "npcList";
            this.npcList.Size = new System.Drawing.Size(121, 21);
            this.npcList.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Select or Type NPC";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button7);
            this.groupBox3.Controls.Add(this.labelFrame);
            this.groupBox3.Controls.Add(this.button6);
            this.groupBox3.Controls.Add(this.preview);
            this.groupBox3.Enabled = false;
            this.groupBox3.Location = new System.Drawing.Point(397, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(191, 230);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Preview";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(125, 168);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(39, 23);
            this.button7.TabIndex = 7;
            this.button7.Text = "Stop";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // labelFrame
            // 
            this.labelFrame.AutoSize = true;
            this.labelFrame.Location = new System.Drawing.Point(21, 206);
            this.labelFrame.Name = "labelFrame";
            this.labelFrame.Size = new System.Drawing.Size(39, 13);
            this.labelFrame.TabIndex = 6;
            this.labelFrame.Text = "Frame:";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(21, 168);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(39, 23);
            this.button6.TabIndex = 5;
            this.button6.Text = "Play";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // preview
            // 
            this.preview.BackColor = System.Drawing.SystemColors.Highlight;
            this.preview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.preview.Location = new System.Drawing.Point(60, 32);
            this.preview.Name = "preview";
            this.preview.Size = new System.Drawing.Size(64, 128);
            this.preview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.preview.TabIndex = 4;
            this.preview.TabStop = false;
            // 
            // Create_Animation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(592, 233);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Create_Animation";
            this.Text = "Create_Animation";
            this.Load += new System.EventHandler(this.Create_Animation_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.animationFrame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spriteImage)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frameTime)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.preview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListBox frameList;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown animationFrame;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox spriteImage;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.CheckBox isLooped;
        private System.Windows.Forms.CheckBox isFlipped;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown frameTime;
        private System.Windows.Forms.ComboBox npcList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.PictureBox preview;
        private System.Windows.Forms.Label labelFrame;
        private System.Windows.Forms.Button button7;
    }
}