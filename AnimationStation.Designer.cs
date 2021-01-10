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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.frameCount = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.frameList = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.animKey = new System.Windows.Forms.TextBox();
            this.addToList = new System.Windows.Forms.Button();
            this.deleteSelection = new System.Windows.Forms.Button();
            this.clearAll = new System.Windows.Forms.Button();
            this.addFrame = new System.Windows.Forms.Button();
            this.prepDescrip = new System.Windows.Forms.ListBox();
            this.createFile = new System.Windows.Forms.Button();
            this.delSelected = new System.Windows.Forms.Button();
            this.clearList = new System.Windows.Forms.Button();
            this.recentLoad = new System.Windows.Forms.Button();
            this.editData = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frameCount)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.addFrame);
            this.groupBox1.Controls.Add(this.frameCount);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(236, 161);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Frame Viewer";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(18, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 64);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Frame";
            // 
            // frameCount
            // 
            this.frameCount.Location = new System.Drawing.Point(109, 52);
            this.frameCount.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.frameCount.Name = "frameCount";
            this.frameCount.Size = new System.Drawing.Size(97, 20);
            this.frameCount.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.clearAll);
            this.groupBox2.Controls.Add(this.deleteSelection);
            this.groupBox2.Controls.Add(this.addToList);
            this.groupBox2.Controls.Add(this.animKey);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.frameList);
            this.groupBox2.Location = new System.Drawing.Point(254, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(311, 161);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Frame List";
            // 
            // frameList
            // 
            this.frameList.FormattingEnabled = true;
            this.frameList.Location = new System.Drawing.Point(21, 19);
            this.frameList.Name = "frameList";
            this.frameList.Size = new System.Drawing.Size(120, 95);
            this.frameList.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Animation List";
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
            // animKey
            // 
            this.animKey.Location = new System.Drawing.Point(167, 35);
            this.animKey.Name = "animKey";
            this.animKey.Size = new System.Drawing.Size(100, 20);
            this.animKey.TabIndex = 2;
            // 
            // addToList
            // 
            this.addToList.Location = new System.Drawing.Point(177, 61);
            this.addToList.Name = "addToList";
            this.addToList.Size = new System.Drawing.Size(75, 23);
            this.addToList.TabIndex = 3;
            this.addToList.Text = "Commit";
            this.addToList.UseVisualStyleBackColor = true;
            // 
            // deleteSelection
            // 
            this.deleteSelection.Location = new System.Drawing.Point(21, 120);
            this.deleteSelection.Name = "deleteSelection";
            this.deleteSelection.Size = new System.Drawing.Size(57, 23);
            this.deleteSelection.TabIndex = 4;
            this.deleteSelection.Text = "Delete";
            this.deleteSelection.UseVisualStyleBackColor = true;
            // 
            // clearAll
            // 
            this.clearAll.Location = new System.Drawing.Point(84, 120);
            this.clearAll.Name = "clearAll";
            this.clearAll.Size = new System.Drawing.Size(57, 23);
            this.clearAll.TabIndex = 5;
            this.clearAll.Text = "Clear";
            this.clearAll.UseVisualStyleBackColor = true;
            // 
            // addFrame
            // 
            this.addFrame.Location = new System.Drawing.Point(109, 91);
            this.addFrame.Name = "addFrame";
            this.addFrame.Size = new System.Drawing.Size(85, 23);
            this.addFrame.TabIndex = 6;
            this.addFrame.Text = "Add Frame ->";
            this.addFrame.UseVisualStyleBackColor = true;
            // 
            // prepDescrip
            // 
            this.prepDescrip.FormattingEnabled = true;
            this.prepDescrip.Location = new System.Drawing.Point(15, 192);
            this.prepDescrip.Name = "prepDescrip";
            this.prepDescrip.Size = new System.Drawing.Size(550, 147);
            this.prepDescrip.TabIndex = 2;
            // 
            // createFile
            // 
            this.createFile.Location = new System.Drawing.Point(15, 356);
            this.createFile.Name = "createFile";
            this.createFile.Size = new System.Drawing.Size(75, 23);
            this.createFile.TabIndex = 3;
            this.createFile.Text = "Generate";
            this.createFile.UseVisualStyleBackColor = true;
            // 
            // delSelected
            // 
            this.delSelected.Location = new System.Drawing.Point(109, 356);
            this.delSelected.Name = "delSelected";
            this.delSelected.Size = new System.Drawing.Size(75, 23);
            this.delSelected.TabIndex = 4;
            this.delSelected.Text = "Delete";
            this.delSelected.UseVisualStyleBackColor = true;
            // 
            // clearList
            // 
            this.clearList.Location = new System.Drawing.Point(214, 356);
            this.clearList.Name = "clearList";
            this.clearList.Size = new System.Drawing.Size(75, 23);
            this.clearList.TabIndex = 5;
            this.clearList.Text = "Clear All";
            this.clearList.UseVisualStyleBackColor = true;
            // 
            // recentLoad
            // 
            this.recentLoad.Location = new System.Drawing.Point(320, 356);
            this.recentLoad.Name = "recentLoad";
            this.recentLoad.Size = new System.Drawing.Size(75, 23);
            this.recentLoad.TabIndex = 6;
            this.recentLoad.Text = "Load";
            this.recentLoad.UseVisualStyleBackColor = true;
            // 
            // editData
            // 
            this.editData.Location = new System.Drawing.Point(468, 356);
            this.editData.Name = "editData";
            this.editData.Size = new System.Drawing.Size(75, 23);
            this.editData.TabIndex = 7;
            this.editData.Text = "Edit";
            this.editData.UseVisualStyleBackColor = true;
            // 
            // AnimationStation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 407);
            this.Controls.Add(this.editData);
            this.Controls.Add(this.recentLoad);
            this.Controls.Add(this.clearList);
            this.Controls.Add(this.delSelected);
            this.Controls.Add(this.createFile);
            this.Controls.Add(this.prepDescrip);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "AnimationStation";
            this.Text = "AnimationStation";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frameCount)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.Button editData;
    }
}