namespace NPC_Creator
{
    partial class StartEventingWindow
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
            this.skippableEvent = new System.Windows.Forms.CheckBox();
            this.actorBox = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ClearAll = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.actorList = new System.Windows.Forms.ListBox();
            this.addActor = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.startFacing = new System.Windows.Forms.NumericUpDown();
            this.startY = new System.Windows.Forms.NumericUpDown();
            this.startX = new System.Windows.Forms.NumericUpDown();
            this.npcList = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.viewportY = new System.Windows.Forms.NumericUpDown();
            this.viewportX = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.actorBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.startFacing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startX)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewportY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewportX)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select or Type Music ID";
            // 
            // musicID
            // 
            this.musicID.FormattingEnabled = true;
            this.musicID.Location = new System.Drawing.Point(20, 37);
            this.musicID.Name = "musicID";
            this.musicID.Size = new System.Drawing.Size(121, 21);
            this.musicID.TabIndex = 1;
            // 
            // skippableEvent
            // 
            this.skippableEvent.AutoSize = true;
            this.skippableEvent.Location = new System.Drawing.Point(216, 27);
            this.skippableEvent.Name = "skippableEvent";
            this.skippableEvent.Size = new System.Drawing.Size(100, 17);
            this.skippableEvent.TabIndex = 2;
            this.skippableEvent.Text = "Can be skipped";
            this.skippableEvent.UseVisualStyleBackColor = true;
            // 
            // actorBox
            // 
            this.actorBox.Controls.Add(this.label8);
            this.actorBox.Controls.Add(this.ClearAll);
            this.actorBox.Controls.Add(this.DeleteButton);
            this.actorBox.Controls.Add(this.actorList);
            this.actorBox.Controls.Add(this.addActor);
            this.actorBox.Controls.Add(this.label5);
            this.actorBox.Controls.Add(this.label4);
            this.actorBox.Controls.Add(this.label3);
            this.actorBox.Controls.Add(this.startFacing);
            this.actorBox.Controls.Add(this.startY);
            this.actorBox.Controls.Add(this.startX);
            this.actorBox.Controls.Add(this.npcList);
            this.actorBox.Controls.Add(this.label2);
            this.actorBox.Location = new System.Drawing.Point(12, 84);
            this.actorBox.Name = "actorBox";
            this.actorBox.Size = new System.Drawing.Size(353, 268);
            this.actorBox.TabIndex = 3;
            this.actorBox.TabStop = false;
            this.actorBox.Text = "Present Actors";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 209);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(192, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Reminder: Farmer must be in the Actors";
            // 
            // ClearAll
            // 
            this.ClearAll.Location = new System.Drawing.Point(146, 141);
            this.ClearAll.Name = "ClearAll";
            this.ClearAll.Size = new System.Drawing.Size(75, 23);
            this.ClearAll.TabIndex = 10;
            this.ClearAll.Text = "Clear";
            this.ClearAll.UseVisualStyleBackColor = true;
            this.ClearAll.Click += new System.EventHandler(this.ClearAll_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(146, 102);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 9;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // actorList
            // 
            this.actorList.FormattingEnabled = true;
            this.actorList.Location = new System.Drawing.Point(227, 102);
            this.actorList.Name = "actorList";
            this.actorList.Size = new System.Drawing.Size(120, 160);
            this.actorList.TabIndex = 4;
            // 
            // addActor
            // 
            this.addActor.Location = new System.Drawing.Point(295, 55);
            this.addActor.Name = "addActor";
            this.addActor.Size = new System.Drawing.Size(52, 23);
            this.addActor.TabIndex = 8;
            this.addActor.Text = "ADD";
            this.addActor.UseVisualStyleBackColor = true;
            this.addActor.Click += new System.EventHandler(this.addActor_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(238, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Facing:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(201, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Y:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(141, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "X:";
            // 
            // startFacing
            // 
            this.startFacing.Location = new System.Drawing.Point(241, 55);
            this.startFacing.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.startFacing.Name = "startFacing";
            this.startFacing.Size = new System.Drawing.Size(48, 20);
            this.startFacing.TabIndex = 4;
            // 
            // startY
            // 
            this.startY.Location = new System.Drawing.Point(187, 55);
            this.startY.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.startY.Minimum = new decimal(new int[] {
            9999,
            0,
            0,
            -2147483648});
            this.startY.Name = "startY";
            this.startY.Size = new System.Drawing.Size(48, 20);
            this.startY.TabIndex = 3;
            // 
            // startX
            // 
            this.startX.Location = new System.Drawing.Point(133, 54);
            this.startX.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.startX.Minimum = new decimal(new int[] {
            9999,
            0,
            0,
            -2147483648});
            this.startX.Name = "startX";
            this.startX.Size = new System.Drawing.Size(48, 20);
            this.startX.TabIndex = 2;
            // 
            // npcList
            // 
            this.npcList.FormattingEnabled = true;
            this.npcList.Location = new System.Drawing.Point(6, 54);
            this.npcList.Name = "npcList";
            this.npcList.Size = new System.Drawing.Size(121, 21);
            this.npcList.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Actors:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.musicID);
            this.groupBox1.Location = new System.Drawing.Point(12, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(158, 76);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Event Music";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.viewportY);
            this.groupBox2.Controls.Add(this.viewportX);
            this.groupBox2.Location = new System.Drawing.Point(371, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 88);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Starting Viewport";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(118, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Y:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "X:";
            // 
            // viewportY
            // 
            this.viewportY.Location = new System.Drawing.Point(105, 41);
            this.viewportY.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.viewportY.Minimum = new decimal(new int[] {
            9999,
            0,
            0,
            -2147483648});
            this.viewportY.Name = "viewportY";
            this.viewportY.Size = new System.Drawing.Size(48, 20);
            this.viewportY.TabIndex = 12;
            // 
            // viewportX
            // 
            this.viewportX.Location = new System.Drawing.Point(24, 41);
            this.viewportX.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.viewportX.Minimum = new decimal(new int[] {
            9999,
            0,
            0,
            -2147483648});
            this.viewportX.Name = "viewportX";
            this.viewportX.Size = new System.Drawing.Size(48, 20);
            this.viewportX.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(395, 186);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Commit and Continue";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // StartEventingWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 356);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.actorBox);
            this.Controls.Add(this.skippableEvent);
            this.Name = "StartEventingWindow";
            this.Text = "StartEventingWindow";
            this.Load += new System.EventHandler(this.StartEventingWindow_Load);
            this.actorBox.ResumeLayout(false);
            this.actorBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.startFacing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startX)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewportY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewportX)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox musicID;
        private System.Windows.Forms.CheckBox skippableEvent;
        private System.Windows.Forms.GroupBox actorBox;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.ListBox actorList;
        private System.Windows.Forms.Button addActor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown startFacing;
        private System.Windows.Forms.NumericUpDown startY;
        private System.Windows.Forms.NumericUpDown startX;
        private System.Windows.Forms.ComboBox npcList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button ClearAll;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown viewportY;
        private System.Windows.Forms.NumericUpDown viewportX;
        private System.Windows.Forms.Button button1;
    }
}