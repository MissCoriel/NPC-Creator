namespace NPC_Creator
{
    partial class scheduleStudio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(scheduleStudio));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.disableManual = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.loadCoord = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.coordList = new System.Windows.Forms.ListBox();
            this.coordFiles = new System.Windows.Forms.ComboBox();
            this.editTextFile = new System.Windows.Forms.Button();
            this.animationButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.addLocation = new System.Windows.Forms.Button();
            this.newLocation = new System.Windows.Forms.TextBox();
            this.locations = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.scheduleDialog = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.scheduleName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.addToLine = new System.Windows.Forms.Button();
            this.npcAnimation = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.npcFacing = new System.Windows.Forms.NumericUpDown();
            this.npcY = new System.Windows.Forms.NumericUpDown();
            this.npcX = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timeStamp = new System.Windows.Forms.NumericUpDown();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.commitSchedule = new System.Windows.Forms.Button();
            this.clearAll = new System.Windows.Forms.Button();
            this.removeSelected = new System.Windows.Forms.Button();
            this.scheduleData = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.reloadSchedule = new System.Windows.Forms.Button();
            this.deleteScheduleEntry = new System.Windows.Forms.Button();
            this.generateSchedule = new System.Windows.Forms.Button();
            this.finalScheduleCheck = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.npcFacing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.npcY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.npcX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeStamp)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.disableManual);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.editTextFile);
            this.groupBox1.Controls.Add(this.animationButton);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.addLocation);
            this.groupBox1.Controls.Add(this.newLocation);
            this.groupBox1.Controls.Add(this.locations);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.scheduleDialog);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.scheduleName);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.addToLine);
            this.groupBox1.Controls.Add(this.npcAnimation);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.npcFacing);
            this.groupBox1.Controls.Add(this.npcY);
            this.groupBox1.Controls.Add(this.npcX);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.timeStamp);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(726, 238);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Schedule Studio";
            // 
            // disableManual
            // 
            this.disableManual.AutoSize = true;
            this.disableManual.Location = new System.Drawing.Point(576, 62);
            this.disableManual.Name = "disableManual";
            this.disableManual.Size = new System.Drawing.Size(140, 17);
            this.disableManual.TabIndex = 16;
            this.disableManual.Text = "Disable Manual Controls";
            this.disableManual.UseVisualStyleBackColor = true;
            this.disableManual.CheckedChanged += new System.EventHandler(this.disableManual_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.loadCoord);
            this.groupBox4.Controls.Add(this.button2);
            this.groupBox4.Controls.Add(this.coordList);
            this.groupBox4.Controls.Add(this.coordFiles);
            this.groupBox4.Location = new System.Drawing.Point(422, 91);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(294, 119);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Positioner Coordinates";
            // 
            // loadCoord
            // 
            this.loadCoord.Location = new System.Drawing.Point(6, 55);
            this.loadCoord.Name = "loadCoord";
            this.loadCoord.Size = new System.Drawing.Size(75, 23);
            this.loadCoord.TabIndex = 3;
            this.loadCoord.Text = "Load";
            this.loadCoord.UseVisualStyleBackColor = true;
            this.loadCoord.Click += new System.EventHandler(this.loadCoord_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(141, 90);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Add to Schedule ->";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // coordList
            // 
            this.coordList.FormattingEnabled = true;
            this.coordList.Location = new System.Drawing.Point(141, 19);
            this.coordList.Name = "coordList";
            this.coordList.Size = new System.Drawing.Size(120, 69);
            this.coordList.TabIndex = 1;
            // 
            // coordFiles
            // 
            this.coordFiles.FormattingEnabled = true;
            this.coordFiles.Location = new System.Drawing.Point(6, 28);
            this.coordFiles.Name = "coordFiles";
            this.coordFiles.Size = new System.Drawing.Size(121, 21);
            this.coordFiles.TabIndex = 0;
            this.coordFiles.Text = "Select File";
            // 
            // editTextFile
            // 
            this.editTextFile.Location = new System.Drawing.Point(308, 92);
            this.editTextFile.Name = "editTextFile";
            this.editTextFile.Size = new System.Drawing.Size(112, 23);
            this.editTextFile.TabIndex = 7;
            this.editTextFile.Text = "Open Locations File";
            this.editTextFile.UseVisualStyleBackColor = true;
            this.editTextFile.Click += new System.EventHandler(this.editTextFile_Click);
            // 
            // animationButton
            // 
            this.animationButton.Location = new System.Drawing.Point(26, 120);
            this.animationButton.Name = "animationButton";
            this.animationButton.Size = new System.Drawing.Size(121, 23);
            this.animationButton.TabIndex = 14;
            this.animationButton.Text = "Create Animations";
            this.animationButton.UseVisualStyleBackColor = true;
            this.animationButton.Click += new System.EventHandler(this.animationButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(139, 169);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Create Schedule Dialogue";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(305, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Add Custom Location";
            // 
            // addLocation
            // 
            this.addLocation.Location = new System.Drawing.Point(308, 58);
            this.addLocation.Name = "addLocation";
            this.addLocation.Size = new System.Drawing.Size(75, 23);
            this.addLocation.TabIndex = 12;
            this.addLocation.Text = "<- ADD";
            this.addLocation.UseVisualStyleBackColor = true;
            this.addLocation.Click += new System.EventHandler(this.AddLocation_Click);
            // 
            // newLocation
            // 
            this.newLocation.Location = new System.Drawing.Point(308, 32);
            this.newLocation.Name = "newLocation";
            this.newLocation.Size = new System.Drawing.Size(100, 20);
            this.newLocation.TabIndex = 11;
            // 
            // locations
            // 
            this.locations.FormattingEnabled = true;
            this.locations.Location = new System.Drawing.Point(186, 32);
            this.locations.Name = "locations";
            this.locations.Size = new System.Drawing.Size(116, 82);
            this.locations.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(45, 213);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(654, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "If you do not have animations in the animationDescriptions.json or a schedule dia" +
    "log set up, please leave Animation Set and Dialog Blank!";
            // 
            // scheduleDialog
            // 
            this.scheduleDialog.Location = new System.Drawing.Point(26, 172);
            this.scheduleDialog.Name = "scheduleDialog";
            this.scheduleDialog.Size = new System.Drawing.Size(100, 20);
            this.scheduleDialog.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Dialog: Optional";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Schedule";
            // 
            // scheduleName
            // 
            this.scheduleName.Location = new System.Drawing.Point(6, 32);
            this.scheduleName.Name = "scheduleName";
            this.scheduleName.Size = new System.Drawing.Size(100, 20);
            this.scheduleName.TabIndex = 1;
            this.scheduleName.Text = "spring";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Animation Set: Optional";
            // 
            // addToLine
            // 
            this.addToLine.Location = new System.Drawing.Point(422, 62);
            this.addToLine.Name = "addToLine";
            this.addToLine.Size = new System.Drawing.Size(123, 23);
            this.addToLine.TabIndex = 9;
            this.addToLine.Text = "Add to Schedule List";
            this.addToLine.UseVisualStyleBackColor = true;
            this.addToLine.Click += new System.EventHandler(this.AddToLine_Click);
            // 
            // npcAnimation
            // 
            this.npcAnimation.Location = new System.Drawing.Point(12, 94);
            this.npcAnimation.Name = "npcAnimation";
            this.npcAnimation.Size = new System.Drawing.Size(145, 20);
            this.npcAnimation.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(419, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Coordinates and Facing";
            // 
            // npcFacing
            // 
            this.npcFacing.Location = new System.Drawing.Point(529, 33);
            this.npcFacing.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.npcFacing.Name = "npcFacing";
            this.npcFacing.Size = new System.Drawing.Size(31, 20);
            this.npcFacing.TabIndex = 6;
            // 
            // npcY
            // 
            this.npcY.Location = new System.Drawing.Point(473, 33);
            this.npcY.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.npcY.Minimum = new decimal(new int[] {
            99999,
            0,
            0,
            -2147483648});
            this.npcY.Name = "npcY";
            this.npcY.Size = new System.Drawing.Size(50, 20);
            this.npcY.TabIndex = 5;
            // 
            // npcX
            // 
            this.npcX.Location = new System.Drawing.Point(414, 32);
            this.npcX.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.npcX.Minimum = new decimal(new int[] {
            99999,
            0,
            0,
            -2147483648});
            this.npcX.Name = "npcX";
            this.npcX.Size = new System.Drawing.Size(53, 20);
            this.npcX.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(186, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Location Selection";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Game Time";
            // 
            // timeStamp
            // 
            this.timeStamp.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.timeStamp.Location = new System.Drawing.Point(122, 33);
            this.timeStamp.Maximum = new decimal(new int[] {
            2400,
            0,
            0,
            0});
            this.timeStamp.Minimum = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.timeStamp.Name = "timeStamp";
            this.timeStamp.Size = new System.Drawing.Size(58, 20);
            this.timeStamp.TabIndex = 2;
            this.timeStamp.Value = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.timeStamp.ValueChanged += new System.EventHandler(this.timeStamp_ValueChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.commitSchedule);
            this.groupBox3.Controls.Add(this.clearAll);
            this.groupBox3.Controls.Add(this.removeSelected);
            this.groupBox3.Controls.Add(this.scheduleData);
            this.groupBox3.Location = new System.Drawing.Point(732, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(321, 331);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Schedule Task List";
            // 
            // commitSchedule
            // 
            this.commitSchedule.Location = new System.Drawing.Point(180, 281);
            this.commitSchedule.Name = "commitSchedule";
            this.commitSchedule.Size = new System.Drawing.Size(89, 23);
            this.commitSchedule.TabIndex = 13;
            this.commitSchedule.Text = "Commit";
            this.commitSchedule.UseVisualStyleBackColor = true;
            this.commitSchedule.Click += new System.EventHandler(this.CommitSchedule_Click);
            // 
            // clearAll
            // 
            this.clearAll.Location = new System.Drawing.Point(24, 302);
            this.clearAll.Name = "clearAll";
            this.clearAll.Size = new System.Drawing.Size(111, 23);
            this.clearAll.TabIndex = 12;
            this.clearAll.Text = "Clear All Data";
            this.clearAll.UseVisualStyleBackColor = true;
            this.clearAll.Click += new System.EventHandler(this.ClearAll_Click);
            // 
            // removeSelected
            // 
            this.removeSelected.Location = new System.Drawing.Point(24, 263);
            this.removeSelected.Name = "removeSelected";
            this.removeSelected.Size = new System.Drawing.Size(111, 23);
            this.removeSelected.TabIndex = 11;
            this.removeSelected.Text = "Remove Selected";
            this.removeSelected.UseVisualStyleBackColor = true;
            this.removeSelected.Click += new System.EventHandler(this.RemoveSelected_Click);
            // 
            // scheduleData
            // 
            this.scheduleData.FormattingEnabled = true;
            this.scheduleData.Location = new System.Drawing.Point(24, 31);
            this.scheduleData.Name = "scheduleData";
            this.scheduleData.Size = new System.Drawing.Size(287, 212);
            this.scheduleData.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(54, 298);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(541, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Your NPC needs a lot of time to make their destination!  Put 3-5 hours between ac" +
    "tions depending on how far it is!";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(269, 264);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Miss Coriel Says:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(601, 264);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(82, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.reloadSchedule);
            this.groupBox2.Controls.Add(this.deleteScheduleEntry);
            this.groupBox2.Controls.Add(this.generateSchedule);
            this.groupBox2.Controls.Add(this.finalScheduleCheck);
            this.groupBox2.Location = new System.Drawing.Point(0, 359);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1053, 222);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Schedule";
            // 
            // reloadSchedule
            // 
            this.reloadSchedule.Location = new System.Drawing.Point(466, 180);
            this.reloadSchedule.Name = "reloadSchedule";
            this.reloadSchedule.Size = new System.Drawing.Size(129, 23);
            this.reloadSchedule.TabIndex = 7;
            this.reloadSchedule.Text = "Load Recent";
            this.reloadSchedule.UseVisualStyleBackColor = true;
            this.reloadSchedule.Click += new System.EventHandler(this.ReloadSchedule_Click);
            // 
            // deleteScheduleEntry
            // 
            this.deleteScheduleEntry.Location = new System.Drawing.Point(901, 180);
            this.deleteScheduleEntry.Name = "deleteScheduleEntry";
            this.deleteScheduleEntry.Size = new System.Drawing.Size(127, 23);
            this.deleteScheduleEntry.TabIndex = 16;
            this.deleteScheduleEntry.Text = "Delete Selection";
            this.deleteScheduleEntry.UseVisualStyleBackColor = true;
            this.deleteScheduleEntry.Click += new System.EventHandler(this.DeleteScheduleEntry_Click);
            // 
            // generateSchedule
            // 
            this.generateSchedule.Location = new System.Drawing.Point(26, 180);
            this.generateSchedule.Name = "generateSchedule";
            this.generateSchedule.Size = new System.Drawing.Size(131, 23);
            this.generateSchedule.TabIndex = 15;
            this.generateSchedule.Text = "Generate Schedule.json";
            this.generateSchedule.UseVisualStyleBackColor = true;
            this.generateSchedule.Click += new System.EventHandler(this.GenerateSchedule_Click);
            // 
            // finalScheduleCheck
            // 
            this.finalScheduleCheck.FormattingEnabled = true;
            this.finalScheduleCheck.Location = new System.Drawing.Point(3, 16);
            this.finalScheduleCheck.Name = "finalScheduleCheck";
            this.finalScheduleCheck.Size = new System.Drawing.Size(1040, 147);
            this.finalScheduleCheck.TabIndex = 14;
            // 
            // scheduleStudio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1087, 584);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "scheduleStudio";
            this.Text = "Schedule Studio";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.npcFacing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.npcY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.npcX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeStamp)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown timeStamp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown npcFacing;
        private System.Windows.Forms.NumericUpDown npcY;
        private System.Windows.Forms.NumericUpDown npcX;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox scheduleName;
        private System.Windows.Forms.Button addToLine;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox scheduleDialog;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox npcAnimation;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button removeSelected;
        private System.Windows.Forms.ListBox scheduleData;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button clearAll;
        private System.Windows.Forms.Label label9;
        
        private System.Windows.Forms.Button commitSchedule;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button deleteScheduleEntry;
        private System.Windows.Forms.Button generateSchedule;
        private System.Windows.Forms.ListBox finalScheduleCheck;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button addLocation;
        private System.Windows.Forms.TextBox newLocation;
        private System.Windows.Forms.ListBox locations;
        private System.Windows.Forms.Button reloadSchedule;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button animationButton;
        private System.Windows.Forms.Button editTextFile;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button loadCoord;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox coordList;
        private System.Windows.Forms.ComboBox coordFiles;
        private System.Windows.Forms.CheckBox disableManual;
    }
}