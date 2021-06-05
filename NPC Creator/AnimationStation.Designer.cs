namespace NPC_Creator
{
    partial class AnimationStation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnimationStation));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.addClose = new System.Windows.Forms.Button();
            this.addInitial = new System.Windows.Forms.Button();
            this.addFrame = new System.Windows.Forms.Button();
            this.frameCount = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.endClear = new System.Windows.Forms.Button();
            this.endDelete = new System.Windows.Forms.Button();
            this.openClear = new System.Windows.Forms.Button();
            this.openDel = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.endFrame = new System.Windows.Forms.ListBox();
            this.openFrame = new System.Windows.Forms.ListBox();
            this.clearAll = new System.Windows.Forms.Button();
            this.deleteSelection = new System.Windows.Forms.Button();
            this.addToList = new System.Windows.Forms.Button();
            this.animKey = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.frameList = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.prepDescrip = new System.Windows.Forms.ListBox();
            this.createFile = new System.Windows.Forms.Button();
            this.delSelected = new System.Windows.Forms.Button();
            this.clearList = new System.Windows.Forms.Button();
            this.recentLoad = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.PlayButton = new System.Windows.Forms.Button();
            this.testAnimation = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frameCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.testAnimation)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.addClose);
            this.groupBox1.Controls.Add(this.addInitial);
            this.groupBox1.Controls.Add(this.addFrame);
            this.groupBox1.Controls.Add(this.frameCount);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(236, 199);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Frame Viewer";
            // 
            // addClose
            // 
            this.addClose.Location = new System.Drawing.Point(79, 130);
            this.addClose.Name = "addClose";
            this.addClose.Size = new System.Drawing.Size(85, 23);
            this.addClose.TabIndex = 10;
            this.addClose.Text = "Add Ending";
            this.addClose.UseVisualStyleBackColor = true;
            this.addClose.Click += new System.EventHandler(this.addClose_Click);
            // 
            // addInitial
            // 
            this.addInitial.Location = new System.Drawing.Point(79, 49);
            this.addInitial.Name = "addInitial";
            this.addInitial.Size = new System.Drawing.Size(85, 23);
            this.addInitial.TabIndex = 9;
            this.addInitial.Text = "Add Initial";
            this.addInitial.UseVisualStyleBackColor = true;
            this.addInitial.Click += new System.EventHandler(this.addInitial_Click);
            // 
            // addFrame
            // 
            this.addFrame.Location = new System.Drawing.Point(79, 90);
            this.addFrame.Name = "addFrame";
            this.addFrame.Size = new System.Drawing.Size(85, 23);
            this.addFrame.TabIndex = 6;
            this.addFrame.Text = "Add Main";
            this.addFrame.UseVisualStyleBackColor = true;
            this.addFrame.Click += new System.EventHandler(this.addFrame_Click);
            // 
            // frameCount
            // 
            this.frameCount.Location = new System.Drawing.Point(118, 17);
            this.frameCount.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.frameCount.Name = "frameCount";
            this.frameCount.Size = new System.Drawing.Size(44, 20);
            this.frameCount.TabIndex = 2;
            this.frameCount.ValueChanged += new System.EventHandler(this.frameCount_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Frame";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(6, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.endClear);
            this.groupBox2.Controls.Add(this.endDelete);
            this.groupBox2.Controls.Add(this.openClear);
            this.groupBox2.Controls.Add(this.openDel);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.endFrame);
            this.groupBox2.Controls.Add(this.openFrame);
            this.groupBox2.Controls.Add(this.clearAll);
            this.groupBox2.Controls.Add(this.deleteSelection);
            this.groupBox2.Controls.Add(this.addToList);
            this.groupBox2.Controls.Add(this.animKey);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.frameList);
            this.groupBox2.Location = new System.Drawing.Point(254, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(311, 212);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Frame List";
            // 
            // endClear
            // 
            this.endClear.Location = new System.Drawing.Point(113, 176);
            this.endClear.Name = "endClear";
            this.endClear.Size = new System.Drawing.Size(41, 23);
            this.endClear.TabIndex = 13;
            this.endClear.Text = "Clear";
            this.endClear.UseVisualStyleBackColor = true;
            this.endClear.Click += new System.EventHandler(this.endClear_Click);
            // 
            // endDelete
            // 
            this.endDelete.Location = new System.Drawing.Point(113, 149);
            this.endDelete.Name = "endDelete";
            this.endDelete.Size = new System.Drawing.Size(41, 23);
            this.endDelete.TabIndex = 12;
            this.endDelete.Text = "Del";
            this.endDelete.UseVisualStyleBackColor = true;
            this.endDelete.Click += new System.EventHandler(this.endDelete_Click);
            // 
            // openClear
            // 
            this.openClear.Location = new System.Drawing.Point(6, 176);
            this.openClear.Name = "openClear";
            this.openClear.Size = new System.Drawing.Size(48, 23);
            this.openClear.TabIndex = 11;
            this.openClear.Text = "Clear";
            this.openClear.UseVisualStyleBackColor = true;
            this.openClear.Click += new System.EventHandler(this.openClear_Click);
            // 
            // openDel
            // 
            this.openDel.Location = new System.Drawing.Point(6, 149);
            this.openDel.Name = "openDel";
            this.openDel.Size = new System.Drawing.Size(48, 23);
            this.openDel.TabIndex = 10;
            this.openDel.Text = "Del";
            this.openDel.UseVisualStyleBackColor = true;
            this.openDel.Click += new System.EventHandler(this.openDel_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(95, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(12, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "/";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(12, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "/";
            // 
            // endFrame
            // 
            this.endFrame.FormattingEnabled = true;
            this.endFrame.Location = new System.Drawing.Point(113, 48);
            this.endFrame.Name = "endFrame";
            this.endFrame.Size = new System.Drawing.Size(31, 95);
            this.endFrame.TabIndex = 7;
            // 
            // openFrame
            // 
            this.openFrame.FormattingEnabled = true;
            this.openFrame.Location = new System.Drawing.Point(6, 48);
            this.openFrame.Name = "openFrame";
            this.openFrame.Size = new System.Drawing.Size(30, 95);
            this.openFrame.TabIndex = 6;
            // 
            // clearAll
            // 
            this.clearAll.Location = new System.Drawing.Point(60, 176);
            this.clearAll.Name = "clearAll";
            this.clearAll.Size = new System.Drawing.Size(45, 23);
            this.clearAll.TabIndex = 5;
            this.clearAll.Text = "Clear";
            this.clearAll.UseVisualStyleBackColor = true;
            this.clearAll.Click += new System.EventHandler(this.clearAll_Click);
            // 
            // deleteSelection
            // 
            this.deleteSelection.Location = new System.Drawing.Point(60, 149);
            this.deleteSelection.Name = "deleteSelection";
            this.deleteSelection.Size = new System.Drawing.Size(45, 23);
            this.deleteSelection.TabIndex = 4;
            this.deleteSelection.Text = "Del";
            this.deleteSelection.UseVisualStyleBackColor = true;
            this.deleteSelection.Click += new System.EventHandler(this.deleteSelection_Click);
            // 
            // addToList
            // 
            this.addToList.Location = new System.Drawing.Point(177, 61);
            this.addToList.Name = "addToList";
            this.addToList.Size = new System.Drawing.Size(75, 23);
            this.addToList.TabIndex = 3;
            this.addToList.Text = "Commit";
            this.addToList.UseVisualStyleBackColor = true;
            this.addToList.Click += new System.EventHandler(this.addToList_Click);
            // 
            // animKey
            // 
            this.animKey.Location = new System.Drawing.Point(167, 35);
            this.animKey.Name = "animKey";
            this.animKey.Size = new System.Drawing.Size(100, 20);
            this.animKey.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(174, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Animation Name";
            // 
            // frameList
            // 
            this.frameList.FormattingEnabled = true;
            this.frameList.Location = new System.Drawing.Point(60, 48);
            this.frameList.Name = "frameList";
            this.frameList.Size = new System.Drawing.Size(29, 95);
            this.frameList.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Animation List";
            // 
            // prepDescrip
            // 
            this.prepDescrip.FormattingEnabled = true;
            this.prepDescrip.Location = new System.Drawing.Point(10, 230);
            this.prepDescrip.Name = "prepDescrip";
            this.prepDescrip.Size = new System.Drawing.Size(550, 147);
            this.prepDescrip.TabIndex = 2;
            // 
            // createFile
            // 
            this.createFile.Location = new System.Drawing.Point(7, 394);
            this.createFile.Name = "createFile";
            this.createFile.Size = new System.Drawing.Size(75, 23);
            this.createFile.TabIndex = 3;
            this.createFile.Text = "Generate";
            this.createFile.UseVisualStyleBackColor = true;
            this.createFile.Click += new System.EventHandler(this.createFile_Click);
            // 
            // delSelected
            // 
            this.delSelected.Location = new System.Drawing.Point(168, 394);
            this.delSelected.Name = "delSelected";
            this.delSelected.Size = new System.Drawing.Size(75, 23);
            this.delSelected.TabIndex = 4;
            this.delSelected.Text = "Delete";
            this.delSelected.UseVisualStyleBackColor = true;
            this.delSelected.Click += new System.EventHandler(this.delSelected_Click);
            // 
            // clearList
            // 
            this.clearList.Location = new System.Drawing.Point(333, 394);
            this.clearList.Name = "clearList";
            this.clearList.Size = new System.Drawing.Size(75, 23);
            this.clearList.TabIndex = 5;
            this.clearList.Text = "Clear All";
            this.clearList.UseVisualStyleBackColor = true;
            this.clearList.Click += new System.EventHandler(this.clearList_Click);
            // 
            // recentLoad
            // 
            this.recentLoad.Location = new System.Drawing.Point(476, 394);
            this.recentLoad.Name = "recentLoad";
            this.recentLoad.Size = new System.Drawing.Size(75, 23);
            this.recentLoad.TabIndex = 6;
            this.recentLoad.Text = "Load";
            this.recentLoad.UseVisualStyleBackColor = true;
            this.recentLoad.Click += new System.EventHandler(this.recentLoad_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.PlayButton);
            this.groupBox3.Controls.Add(this.testAnimation);
            this.groupBox3.Location = new System.Drawing.Point(571, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(95, 212);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Test Animation";
            // 
            // PlayButton
            // 
            this.PlayButton.Location = new System.Drawing.Point(16, 163);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(64, 23);
            this.PlayButton.TabIndex = 12;
            this.PlayButton.Text = "Play Animation";
            this.PlayButton.UseVisualStyleBackColor = true;
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // testAnimation
            // 
            this.testAnimation.BackColor = System.Drawing.SystemColors.Highlight;
            this.testAnimation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.testAnimation.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.testAnimation.Location = new System.Drawing.Point(16, 19);
            this.testAnimation.Name = "testAnimation";
            this.testAnimation.Size = new System.Drawing.Size(64, 128);
            this.testAnimation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.testAnimation.TabIndex = 11;
            this.testAnimation.TabStop = false;
            // 
            // AnimationStation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 443);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.recentLoad);
            this.Controls.Add(this.clearList);
            this.Controls.Add(this.delSelected);
            this.Controls.Add(this.createFile);
            this.Controls.Add(this.prepDescrip);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AnimationStation";
            this.Text = "Animation Station";
            this.Load += new System.EventHandler(this.AnimationStation_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frameCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.testAnimation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown frameCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox frameList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addFrame;
        private System.Windows.Forms.Button clearAll;
        private System.Windows.Forms.Button deleteSelection;
        private System.Windows.Forms.Button addToList;
        private System.Windows.Forms.TextBox animKey;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox prepDescrip;
        private System.Windows.Forms.Button createFile;
        private System.Windows.Forms.Button delSelected;
        private System.Windows.Forms.Button clearList;
        private System.Windows.Forms.Button recentLoad;
        private System.Windows.Forms.Button addClose;
        private System.Windows.Forms.Button addInitial;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox endFrame;
        private System.Windows.Forms.ListBox openFrame;
        private System.Windows.Forms.Button endClear;
        private System.Windows.Forms.Button endDelete;
        private System.Windows.Forms.Button openClear;
        private System.Windows.Forms.Button openDel;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button PlayButton;
        private System.Windows.Forms.PictureBox testAnimation;
    }
}