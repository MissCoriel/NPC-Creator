namespace NPC_Creator
{
    partial class Create_Question
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
            this.enableFork = new System.Windows.Forms.CheckBox();
            this.enableThird = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.thirdFP = new System.Windows.Forms.NumericUpDown();
            this.secondFP = new System.Windows.Forms.NumericUpDown();
            this.firstFP = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.firstKey = new System.Windows.Forms.TextBox();
            this.secondKey = new System.Windows.Forms.TextBox();
            this.thirdKey = new System.Windows.Forms.TextBox();
            this.thirdResponseID = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.secondResponseID = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.firstResponse = new System.Windows.Forms.NumericUpDown();
            this.npcList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.thirdAnswer = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.secondAnswer = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.firstAnswer = new System.Windows.Forms.TextBox();
            this.askQuestion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.forkData = new System.Windows.Forms.GroupBox();
            this.thirdSub = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.secondSub = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.firstSub = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thirdFP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondFP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstFP)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thirdResponseID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondResponseID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstResponse)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.forkData.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.enableFork);
            this.groupBox1.Controls.Add(this.enableThird);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.thirdResponseID);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.secondResponseID);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.firstResponse);
            this.groupBox1.Controls.Add(this.npcList);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(404, 299);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Question Event Data";
            // 
            // enableFork
            // 
            this.enableFork.AutoSize = true;
            this.enableFork.Location = new System.Drawing.Point(296, 51);
            this.enableFork.Name = "enableFork";
            this.enableFork.Size = new System.Drawing.Size(90, 17);
            this.enableFork.TabIndex = 0;
            this.enableFork.Text = "Fork Answers";
            this.enableFork.UseVisualStyleBackColor = true;
            this.enableFork.CheckedChanged += new System.EventHandler(this.enableFork_CheckedChanged);
            // 
            // enableThird
            // 
            this.enableThird.AutoSize = true;
            this.enableThird.Location = new System.Drawing.Point(171, 51);
            this.enableThird.Name = "enableThird";
            this.enableThird.Size = new System.Drawing.Size(106, 17);
            this.enableThird.TabIndex = 17;
            this.enableThird.Text = "Use third Answer";
            this.enableThird.UseVisualStyleBackColor = true;
            this.enableThird.CheckedChanged += new System.EventHandler(this.enableThird_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.thirdFP);
            this.groupBox3.Controls.Add(this.secondFP);
            this.groupBox3.Controls.Add(this.firstFP);
            this.groupBox3.Location = new System.Drawing.Point(297, 91);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(103, 202);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Friendship Points";
            // 
            // thirdFP
            // 
            this.thirdFP.Enabled = false;
            this.thirdFP.Location = new System.Drawing.Point(32, 170);
            this.thirdFP.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.thirdFP.Minimum = new decimal(new int[] {
            250,
            0,
            0,
            -2147483648});
            this.thirdFP.Name = "thirdFP";
            this.thirdFP.Size = new System.Drawing.Size(47, 20);
            this.thirdFP.TabIndex = 16;
            // 
            // secondFP
            // 
            this.secondFP.Location = new System.Drawing.Point(32, 100);
            this.secondFP.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.secondFP.Minimum = new decimal(new int[] {
            250,
            0,
            0,
            -2147483648});
            this.secondFP.Name = "secondFP";
            this.secondFP.Size = new System.Drawing.Size(47, 20);
            this.secondFP.TabIndex = 15;
            // 
            // firstFP
            // 
            this.firstFP.Location = new System.Drawing.Point(32, 28);
            this.firstFP.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.firstFP.Minimum = new decimal(new int[] {
            250,
            0,
            0,
            -2147483648});
            this.firstFP.Name = "firstFP";
            this.firstFP.Size = new System.Drawing.Size(47, 20);
            this.firstFP.TabIndex = 14;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.firstKey);
            this.groupBox2.Controls.Add(this.secondKey);
            this.groupBox2.Controls.Add(this.thirdKey);
            this.groupBox2.Location = new System.Drawing.Point(165, 91);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(129, 202);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dialogue Keys";
            // 
            // firstKey
            // 
            this.firstKey.Location = new System.Drawing.Point(6, 27);
            this.firstKey.Name = "firstKey";
            this.firstKey.Size = new System.Drawing.Size(120, 20);
            this.firstKey.TabIndex = 8;
            // 
            // secondKey
            // 
            this.secondKey.Location = new System.Drawing.Point(6, 99);
            this.secondKey.Name = "secondKey";
            this.secondKey.Size = new System.Drawing.Size(120, 20);
            this.secondKey.TabIndex = 9;
            // 
            // thirdKey
            // 
            this.thirdKey.Enabled = false;
            this.thirdKey.Location = new System.Drawing.Point(6, 170);
            this.thirdKey.Name = "thirdKey";
            this.thirdKey.Size = new System.Drawing.Size(120, 20);
            this.thirdKey.TabIndex = 10;
            // 
            // thirdResponseID
            // 
            this.thirdResponseID.Enabled = false;
            this.thirdResponseID.Location = new System.Drawing.Point(15, 262);
            this.thirdResponseID.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.thirdResponseID.Name = "thirdResponseID";
            this.thirdResponseID.Size = new System.Drawing.Size(120, 20);
            this.thirdResponseID.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Third Answer Response ID";
            // 
            // secondResponseID
            // 
            this.secondResponseID.Location = new System.Drawing.Point(15, 190);
            this.secondResponseID.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.secondResponseID.Name = "secondResponseID";
            this.secondResponseID.Size = new System.Drawing.Size(120, 20);
            this.secondResponseID.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Second Answer Response ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "First Answer Response ID";
            // 
            // firstResponse
            // 
            this.firstResponse.Location = new System.Drawing.Point(15, 119);
            this.firstResponse.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.firstResponse.Name = "firstResponse";
            this.firstResponse.Size = new System.Drawing.Size(120, 20);
            this.firstResponse.TabIndex = 2;
            // 
            // npcList
            // 
            this.npcList.FormattingEnabled = true;
            this.npcList.Location = new System.Drawing.Point(15, 51);
            this.npcList.Name = "npcList";
            this.npcList.Size = new System.Drawing.Size(138, 21);
            this.npcList.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Who is asking the question?";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.thirdAnswer);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.secondAnswer);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.firstAnswer);
            this.groupBox4.Controls.Add(this.askQuestion);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Location = new System.Drawing.Point(410, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(512, 295);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Question Data";
            // 
            // thirdAnswer
            // 
            this.thirdAnswer.Enabled = false;
            this.thirdAnswer.Location = new System.Drawing.Point(9, 256);
            this.thirdAnswer.Name = "thirdAnswer";
            this.thirdAnswer.Size = new System.Drawing.Size(487, 20);
            this.thirdAnswer.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 230);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Third Answer";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 158);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Second Answer";
            // 
            // secondAnswer
            // 
            this.secondAnswer.Location = new System.Drawing.Point(9, 187);
            this.secondAnswer.Name = "secondAnswer";
            this.secondAnswer.Size = new System.Drawing.Size(487, 20);
            this.secondAnswer.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "First Answer";
            // 
            // firstAnswer
            // 
            this.firstAnswer.Location = new System.Drawing.Point(9, 114);
            this.firstAnswer.Name = "firstAnswer";
            this.firstAnswer.Size = new System.Drawing.Size(487, 20);
            this.firstAnswer.TabIndex = 2;
            // 
            // askQuestion
            // 
            this.askQuestion.Location = new System.Drawing.Point(9, 48);
            this.askQuestion.Name = "askQuestion";
            this.askQuestion.Size = new System.Drawing.Size(487, 20);
            this.askQuestion.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Question";
            // 
            // forkData
            // 
            this.forkData.Controls.Add(this.thirdSub);
            this.forkData.Controls.Add(this.label11);
            this.forkData.Controls.Add(this.secondSub);
            this.forkData.Controls.Add(this.label10);
            this.forkData.Controls.Add(this.firstSub);
            this.forkData.Controls.Add(this.label9);
            this.forkData.Enabled = false;
            this.forkData.Location = new System.Drawing.Point(0, 299);
            this.forkData.Name = "forkData";
            this.forkData.Size = new System.Drawing.Size(260, 122);
            this.forkData.TabIndex = 18;
            this.forkData.TabStop = false;
            this.forkData.Text = "Fork Data";
            // 
            // thirdSub
            // 
            this.thirdSub.Enabled = false;
            this.thirdSub.Location = new System.Drawing.Point(153, 85);
            this.thirdSub.Name = "thirdSub";
            this.thirdSub.Size = new System.Drawing.Size(100, 20);
            this.thirdSub.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 88);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(122, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "Third Answer Sub Event";
            // 
            // secondSub
            // 
            this.secondSub.Location = new System.Drawing.Point(153, 55);
            this.secondSub.Name = "secondSub";
            this.secondSub.Size = new System.Drawing.Size(100, 20);
            this.secondSub.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 57);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(135, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Second Answer Sub Event";
            // 
            // firstSub
            // 
            this.firstSub.Location = new System.Drawing.Point(153, 26);
            this.firstSub.Name = "firstSub";
            this.firstSub.Size = new System.Drawing.Size(100, 20);
            this.firstSub.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "First Answer Sub Event";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(531, 346);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(293, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Commit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Create_Question
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 421);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.forkData);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Name = "Create_Question";
            this.Text = "Create_Question";
            this.Load += new System.EventHandler(this.Create_Question_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.thirdFP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondFP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstFP)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thirdResponseID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondResponseID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstResponse)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.forkData.ResumeLayout(false);
            this.forkData.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox enableFork;
        private System.Windows.Forms.CheckBox enableThird;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown thirdFP;
        private System.Windows.Forms.NumericUpDown secondFP;
        private System.Windows.Forms.NumericUpDown firstFP;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox firstKey;
        private System.Windows.Forms.TextBox secondKey;
        private System.Windows.Forms.TextBox thirdKey;
        private System.Windows.Forms.NumericUpDown thirdResponseID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown secondResponseID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown firstResponse;
        private System.Windows.Forms.ComboBox npcList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox thirdAnswer;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox secondAnswer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox firstAnswer;
        private System.Windows.Forms.TextBox askQuestion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox forkData;
        private System.Windows.Forms.TextBox thirdSub;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox secondSub;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox firstSub;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
    }
}