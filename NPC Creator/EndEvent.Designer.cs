namespace NPC_Creator
{
    partial class EndEvent
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.endY = new System.Windows.Forms.NumericUpDown();
            this.endX = new System.Windows.Forms.NumericUpDown();
            this.endCoords = new System.Windows.Forms.CheckBox();
            this.endInvisible = new System.Windows.Forms.CheckBox();
            this.endWarpOut = new System.Windows.Forms.CheckBox();
            this.dialogueBox = new System.Windows.Forms.TextBox();
            this.npcList = new System.Windows.Forms.ComboBox();
            this.endDialogue = new System.Windows.Forms.CheckBox();
            this.endNewDay = new System.Windows.Forms.CheckBox();
            this.endBed = new System.Windows.Forms.CheckBox();
            this.specialEnd = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.endY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endX)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "If you don\'t wish to do anything but end, then click Commit.";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.endY);
            this.groupBox1.Controls.Add(this.endX);
            this.groupBox1.Controls.Add(this.endCoords);
            this.groupBox1.Controls.Add(this.endInvisible);
            this.groupBox1.Controls.Add(this.endWarpOut);
            this.groupBox1.Controls.Add(this.dialogueBox);
            this.groupBox1.Controls.Add(this.npcList);
            this.groupBox1.Controls.Add(this.endDialogue);
            this.groupBox1.Controls.Add(this.endNewDay);
            this.groupBox1.Controls.Add(this.endBed);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(12, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(570, 250);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Special End Events";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(283, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Y:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(184, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "X:";
            // 
            // endY
            // 
            this.endY.Enabled = false;
            this.endY.InterceptArrowKeys = false;
            this.endY.Location = new System.Drawing.Point(269, 169);
            this.endY.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.endY.Minimum = new decimal(new int[] {
            9999,
            0,
            0,
            -2147483648});
            this.endY.Name = "endY";
            this.endY.Size = new System.Drawing.Size(51, 20);
            this.endY.TabIndex = 11;
            // 
            // endX
            // 
            this.endX.Enabled = false;
            this.endX.Location = new System.Drawing.Point(173, 168);
            this.endX.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.endX.Minimum = new decimal(new int[] {
            9999,
            0,
            0,
            -2147483648});
            this.endX.Name = "endX";
            this.endX.Size = new System.Drawing.Size(51, 20);
            this.endX.TabIndex = 10;
            // 
            // endCoords
            // 
            this.endCoords.AutoSize = true;
            this.endCoords.Location = new System.Drawing.Point(6, 169);
            this.endCoords.Name = "endCoords";
            this.endCoords.Size = new System.Drawing.Size(123, 17);
            this.endCoords.TabIndex = 9;
            this.endCoords.Text = "Place in Coordinates";
            this.endCoords.UseVisualStyleBackColor = true;
            this.endCoords.CheckedChanged += new System.EventHandler(this.endCoords_CheckedChanged);
            // 
            // endInvisible
            // 
            this.endInvisible.AutoSize = true;
            this.endInvisible.Location = new System.Drawing.Point(6, 132);
            this.endInvisible.Name = "endInvisible";
            this.endInvisible.Size = new System.Drawing.Size(118, 17);
            this.endInvisible.TabIndex = 8;
            this.endInvisible.Text = "Make NPC invisible";
            this.endInvisible.UseVisualStyleBackColor = true;
            this.endInvisible.CheckedChanged += new System.EventHandler(this.endInvisible_CheckedChanged);
            // 
            // endWarpOut
            // 
            this.endWarpOut.AutoSize = true;
            this.endWarpOut.Location = new System.Drawing.Point(6, 99);
            this.endWarpOut.Name = "endWarpOut";
            this.endWarpOut.Size = new System.Drawing.Size(72, 17);
            this.endWarpOut.TabIndex = 7;
            this.endWarpOut.Text = "Warp Out";
            this.endWarpOut.UseVisualStyleBackColor = true;
            this.endWarpOut.CheckedChanged += new System.EventHandler(this.endWarpOut_CheckedChanged);
            // 
            // dialogueBox
            // 
            this.dialogueBox.Enabled = false;
            this.dialogueBox.Location = new System.Drawing.Point(245, 60);
            this.dialogueBox.Name = "dialogueBox";
            this.dialogueBox.Size = new System.Drawing.Size(254, 20);
            this.dialogueBox.TabIndex = 6;
            // 
            // npcList
            // 
            this.npcList.Enabled = false;
            this.npcList.FormattingEnabled = true;
            this.npcList.Location = new System.Drawing.Point(105, 59);
            this.npcList.Name = "npcList";
            this.npcList.Size = new System.Drawing.Size(121, 21);
            this.npcList.TabIndex = 5;
            // 
            // endDialogue
            // 
            this.endDialogue.AutoSize = true;
            this.endDialogue.Location = new System.Drawing.Point(6, 59);
            this.endDialogue.Name = "endDialogue";
            this.endDialogue.Size = new System.Drawing.Size(93, 17);
            this.endDialogue.TabIndex = 4;
            this.endDialogue.Text = "NPC Dialogue";
            this.endDialogue.UseVisualStyleBackColor = true;
            this.endDialogue.CheckedChanged += new System.EventHandler(this.endDialogue_CheckedChanged);
            // 
            // endNewDay
            // 
            this.endNewDay.AutoSize = true;
            this.endNewDay.Location = new System.Drawing.Point(173, 19);
            this.endNewDay.Name = "endNewDay";
            this.endNewDay.Size = new System.Drawing.Size(163, 17);
            this.endNewDay.TabIndex = 3;
            this.endNewDay.Text = "End Day and Start Tomorrow";
            this.endNewDay.UseVisualStyleBackColor = true;
            this.endNewDay.CheckedChanged += new System.EventHandler(this.endNewDay_CheckedChanged);
            // 
            // endBed
            // 
            this.endBed.AutoSize = true;
            this.endBed.Location = new System.Drawing.Point(6, 19);
            this.endBed.Name = "endBed";
            this.endBed.Size = new System.Drawing.Size(161, 17);
            this.endBed.TabIndex = 2;
            this.endBed.Text = "Place Farmer in Nearest Bed";
            this.endBed.UseVisualStyleBackColor = true;
            this.endBed.CheckedChanged += new System.EventHandler(this.endBed_CheckedChanged);
            // 
            // specialEnd
            // 
            this.specialEnd.AutoSize = true;
            this.specialEnd.Location = new System.Drawing.Point(458, 13);
            this.specialEnd.Name = "specialEnd";
            this.specialEnd.Size = new System.Drawing.Size(124, 17);
            this.specialEnd.TabIndex = 0;
            this.specialEnd.Text = "Enable Special Ends";
            this.specialEnd.UseVisualStyleBackColor = true;
            this.specialEnd.CheckedChanged += new System.EventHandler(this.specialEnd_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(326, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Commit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // EndEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 298);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.specialEnd);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "EndEvent";
            this.Text = "EndEvent";
            this.Load += new System.EventHandler(this.EndEvent_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.endY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.endX)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown endY;
        private System.Windows.Forms.NumericUpDown endX;
        private System.Windows.Forms.CheckBox endCoords;
        private System.Windows.Forms.CheckBox endInvisible;
        private System.Windows.Forms.CheckBox endWarpOut;
        private System.Windows.Forms.TextBox dialogueBox;
        private System.Windows.Forms.ComboBox npcList;
        private System.Windows.Forms.CheckBox endDialogue;
        private System.Windows.Forms.CheckBox endNewDay;
        private System.Windows.Forms.CheckBox endBed;
        private System.Windows.Forms.CheckBox specialEnd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}