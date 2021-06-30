namespace NPC_Creator
{
    partial class AddToFestival
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
            this.npcFacing = new System.Windows.Forms.ComboBox();
            this.npcY = new System.Windows.Forms.NumericUpDown();
            this.npcX = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.festivalList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.marriedDialog = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.normalDialog = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.mainX = new System.Windows.Forms.NumericUpDown();
            this.mainY = new System.Windows.Forms.NumericUpDown();
            this.mainFacing = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.npcY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.npcX)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainY)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mainFacing);
            this.groupBox1.Controls.Add(this.mainY);
            this.groupBox1.Controls.Add(this.mainX);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.npcFacing);
            this.groupBox1.Controls.Add(this.npcY);
            this.groupBox1.Controls.Add(this.npcX);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.festivalList);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(676, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Festival Information";
            // 
            // npcFacing
            // 
            this.npcFacing.FormattingEnabled = true;
            this.npcFacing.Items.AddRange(new object[] {
            "Up",
            "Right",
            "Down",
            "Left"});
            this.npcFacing.Location = new System.Drawing.Point(549, 34);
            this.npcFacing.Name = "npcFacing";
            this.npcFacing.Size = new System.Drawing.Size(121, 21);
            this.npcFacing.TabIndex = 5;
            // 
            // npcY
            // 
            this.npcY.Location = new System.Drawing.Point(476, 34);
            this.npcY.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.npcY.Minimum = new decimal(new int[] {
            9999,
            0,
            0,
            -2147483648});
            this.npcY.Name = "npcY";
            this.npcY.Size = new System.Drawing.Size(57, 20);
            this.npcY.TabIndex = 4;
            // 
            // npcX
            // 
            this.npcX.Location = new System.Drawing.Point(393, 35);
            this.npcX.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.npcX.Minimum = new decimal(new int[] {
            9999,
            0,
            0,
            -2147483648});
            this.npcX.Name = "npcX";
            this.npcX.Size = new System.Drawing.Size(57, 20);
            this.npcX.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(321, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Main Event:";
            // 
            // festivalList
            // 
            this.festivalList.FormattingEnabled = true;
            this.festivalList.Items.AddRange(new object[] {
            "Egg Festival",
            "Flower Dance",
            "Summer Luau",
            "Dance of the Moonlight Jellies",
            "Stardew Valley Fair",
            "Spirit\'s Eve",
            "Festival of Ice",
            "Feast of the Winter Star"});
            this.festivalList.Location = new System.Drawing.Point(58, 34);
            this.festivalList.Name = "festivalList";
            this.festivalList.Size = new System.Drawing.Size(221, 21);
            this.festivalList.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Festival:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.marriedDialog);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.normalDialog);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(0, 106);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(676, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Festival Dialogue";
            // 
            // marriedDialog
            // 
            this.marriedDialog.Enabled = false;
            this.marriedDialog.Location = new System.Drawing.Point(66, 58);
            this.marriedDialog.Name = "marriedDialog";
            this.marriedDialog.Size = new System.Drawing.Size(604, 20);
            this.marriedDialog.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Married:";
            // 
            // normalDialog
            // 
            this.normalDialog.Location = new System.Drawing.Point(66, 24);
            this.normalDialog.Name = "normalDialog";
            this.normalDialog.Size = new System.Drawing.Size(604, 20);
            this.normalDialog.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Normal:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(249, 231);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Commit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(337, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Set Up:";
            // 
            // mainX
            // 
            this.mainX.Location = new System.Drawing.Point(393, 74);
            this.mainX.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.mainX.Minimum = new decimal(new int[] {
            9999,
            0,
            0,
            -2147483648});
            this.mainX.Name = "mainX";
            this.mainX.Size = new System.Drawing.Size(57, 20);
            this.mainX.TabIndex = 6;
            // 
            // mainY
            // 
            this.mainY.Location = new System.Drawing.Point(476, 74);
            this.mainY.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.mainY.Minimum = new decimal(new int[] {
            9999,
            0,
            0,
            -2147483648});
            this.mainY.Name = "mainY";
            this.mainY.Size = new System.Drawing.Size(57, 20);
            this.mainY.TabIndex = 7;
            // 
            // mainFacing
            // 
            this.mainFacing.FormattingEnabled = true;
            this.mainFacing.Items.AddRange(new object[] {
            "Up",
            "Right",
            "Down",
            "Left"});
            this.mainFacing.Location = new System.Drawing.Point(549, 73);
            this.mainFacing.Name = "mainFacing";
            this.mainFacing.Size = new System.Drawing.Size(121, 21);
            this.mainFacing.TabIndex = 8;
            // 
            // AddToFestival
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 266);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddToFestival";
            this.Text = "AddToFestival";
            this.Load += new System.EventHandler(this.AddToFestival_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.npcY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.npcX)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainY)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox npcFacing;
        private System.Windows.Forms.NumericUpDown npcY;
        private System.Windows.Forms.NumericUpDown npcX;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox festivalList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox marriedDialog;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox normalDialog;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox mainFacing;
        private System.Windows.Forms.NumericUpDown mainY;
        private System.Windows.Forms.NumericUpDown mainX;
        private System.Windows.Forms.Label label5;
    }
}