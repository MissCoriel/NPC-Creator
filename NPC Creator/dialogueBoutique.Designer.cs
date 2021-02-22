namespace NPC_Creator
{
    partial class dialogueBoutique
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dialogueBoutique));
            this.keyList = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.marriageDialog = new System.Windows.Forms.RadioButton();
            this.regularDialog = new System.Windows.Forms.RadioButton();
            this.addToKey = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.customKey = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.addDialogList = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.dialogBody = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.submitQuestion = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.negativePoints = new System.Windows.Forms.NumericUpDown();
            this.positivePoints = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.negativeAnswer = new System.Windows.Forms.TextBox();
            this.positiveAnswer = new System.Windows.Forms.TextBox();
            this.question = new System.Windows.Forms.TextBox();
            this.preQuestion = new System.Windows.Forms.TextBox();
            this.negativeResponse = new System.Windows.Forms.TextBox();
            this.positiveResponse = new System.Windows.Forms.TextBox();
            this.fallBackID = new System.Windows.Forms.TextBox();
            this.negativeID = new System.Windows.Forms.NumericUpDown();
            this.positiveID = new System.Windows.Forms.NumericUpDown();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.loadMarriage = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.createMarriageFile = new System.Windows.Forms.Button();
            this.createDialogFile = new System.Windows.Forms.Button();
            this.removeDialogue = new System.Windows.Forms.Button();
            this.listDialogue = new System.Windows.Forms.ListBox();
            this.portraitSample = new System.Windows.Forms.PictureBox();
            this.label13 = new System.Windows.Forms.Label();
            this.portFrame = new System.Windows.Forms.NumericUpDown();
            this.showPort = new System.Windows.Forms.Button();
            this.addBreak = new System.Windows.Forms.Button();
            this.fullBreak = new System.Windows.Forms.Button();
            this.addFarmer = new System.Windows.Forms.Button();
            this.addFarm = new System.Windows.Forms.Button();
            this.addGender = new System.Windows.Forms.Button();
            this.firstKid = new System.Windows.Forms.Button();
            this.kid2 = new System.Windows.Forms.Button();
            this.addSpouse = new System.Windows.Forms.Button();
            this.addFav = new System.Windows.Forms.Button();
            this.petName = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.negativePoints)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.positivePoints)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.negativeID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.positiveID)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.portraitSample)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.portFrame)).BeginInit();
            this.SuspendLayout();
            // 
            // keyList
            // 
            this.keyList.FormattingEnabled = true;
            this.keyList.Location = new System.Drawing.Point(6, 19);
            this.keyList.Name = "keyList";
            this.keyList.Size = new System.Drawing.Size(148, 95);
            this.keyList.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.marriageDialog);
            this.groupBox1.Controls.Add(this.regularDialog);
            this.groupBox1.Controls.Add(this.addToKey);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.customKey);
            this.groupBox1.Controls.Add(this.keyList);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(351, 123);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dialogue Key";
            // 
            // marriageDialog
            // 
            this.marriageDialog.AutoSize = true;
            this.marriageDialog.Location = new System.Drawing.Point(245, 19);
            this.marriageDialog.Name = "marriageDialog";
            this.marriageDialog.Size = new System.Drawing.Size(66, 17);
            this.marriageDialog.TabIndex = 29;
            this.marriageDialog.TabStop = true;
            this.marriageDialog.Text = "Marriage";
            this.marriageDialog.UseVisualStyleBackColor = true;
            this.marriageDialog.CheckedChanged += new System.EventHandler(this.marriageDialog_CheckedChanged);
            // 
            // regularDialog
            // 
            this.regularDialog.AutoSize = true;
            this.regularDialog.Location = new System.Drawing.Point(160, 19);
            this.regularDialog.Name = "regularDialog";
            this.regularDialog.Size = new System.Drawing.Size(58, 17);
            this.regularDialog.TabIndex = 28;
            this.regularDialog.TabStop = true;
            this.regularDialog.Text = "Normal";
            this.regularDialog.UseVisualStyleBackColor = true;
            this.regularDialog.CheckedChanged += new System.EventHandler(this.regularDialog_CheckedChanged);
            // 
            // addToKey
            // 
            this.addToKey.Location = new System.Drawing.Point(160, 71);
            this.addToKey.Name = "addToKey";
            this.addToKey.Size = new System.Drawing.Size(50, 23);
            this.addToKey.TabIndex = 4;
            this.addToKey.Text = "<- Add";
            this.addToKey.UseVisualStyleBackColor = true;
            this.addToKey.Click += new System.EventHandler(this.AddToKey_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(242, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Custom Key";
            // 
            // customKey
            // 
            this.customKey.Location = new System.Drawing.Point(216, 74);
            this.customKey.Name = "customKey";
            this.customKey.Size = new System.Drawing.Size(126, 20);
            this.customKey.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.petName);
            this.groupBox2.Controls.Add(this.addFav);
            this.groupBox2.Controls.Add(this.addSpouse);
            this.groupBox2.Controls.Add(this.kid2);
            this.groupBox2.Controls.Add(this.firstKid);
            this.groupBox2.Controls.Add(this.addGender);
            this.groupBox2.Controls.Add(this.addFarm);
            this.groupBox2.Controls.Add(this.addFarmer);
            this.groupBox2.Controls.Add(this.fullBreak);
            this.groupBox2.Controls.Add(this.addBreak);
            this.groupBox2.Controls.Add(this.addDialogList);
            this.groupBox2.Controls.Add(this.linkLabel1);
            this.groupBox2.Controls.Add(this.dialogBody);
            this.groupBox2.Location = new System.Drawing.Point(369, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1099, 123);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dialogue";
            // 
            // addDialogList
            // 
            this.addDialogList.Location = new System.Drawing.Point(970, 81);
            this.addDialogList.Name = "addDialogList";
            this.addDialogList.Size = new System.Drawing.Size(117, 23);
            this.addDialogList.TabIndex = 2;
            this.addDialogList.Text = "Commit";
            this.addDialogList.UseVisualStyleBackColor = true;
            this.addDialogList.Click += new System.EventHandler(this.AddDialogList_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(18, 86);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(74, 13);
            this.linkLabel1.TabIndex = 1;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Dialogue Help";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1_LinkClicked);
            // 
            // dialogBody
            // 
            this.dialogBody.Location = new System.Drawing.Point(6, 45);
            this.dialogBody.Name = "dialogBody";
            this.dialogBody.Size = new System.Drawing.Size(1087, 20);
            this.dialogBody.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.submitQuestion);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.negativePoints);
            this.groupBox3.Controls.Add(this.positivePoints);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.negativeAnswer);
            this.groupBox3.Controls.Add(this.positiveAnswer);
            this.groupBox3.Controls.Add(this.question);
            this.groupBox3.Controls.Add(this.preQuestion);
            this.groupBox3.Controls.Add(this.negativeResponse);
            this.groupBox3.Controls.Add(this.positiveResponse);
            this.groupBox3.Controls.Add(this.fallBackID);
            this.groupBox3.Controls.Add(this.negativeID);
            this.groupBox3.Controls.Add(this.positiveID);
            this.groupBox3.Location = new System.Drawing.Point(12, 141);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(597, 381);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Question Maker";
            // 
            // submitQuestion
            // 
            this.submitQuestion.Location = new System.Drawing.Point(480, 314);
            this.submitQuestion.Name = "submitQuestion";
            this.submitQuestion.Size = new System.Drawing.Size(99, 23);
            this.submitQuestion.TabIndex = 22;
            this.submitQuestion.Text = "Add Dialogue";
            this.submitQuestion.UseVisualStyleBackColor = true;
            this.submitQuestion.Click += new System.EventHandler(this.SubmitQuestion_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 298);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(101, 13);
            this.label12.TabIndex = 21;
            this.label12.Text = "Negative Response";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 253);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Positive Response";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 209);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Question";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 155);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Prequestion Dialogue";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(375, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Points Taken";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(283, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Points Awarded";
            // 
            // negativePoints
            // 
            this.negativePoints.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.negativePoints.Location = new System.Drawing.Point(378, 51);
            this.negativePoints.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.negativePoints.Minimum = new decimal(new int[] {
            2500,
            0,
            0,
            -2147483648});
            this.negativePoints.Name = "negativePoints";
            this.negativePoints.Size = new System.Drawing.Size(42, 20);
            this.negativePoints.TabIndex = 15;
            // 
            // positivePoints
            // 
            this.positivePoints.Location = new System.Drawing.Point(303, 51);
            this.positivePoints.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.positivePoints.Name = "positivePoints";
            this.positivePoints.Size = new System.Drawing.Size(42, 20);
            this.positivePoints.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(338, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Negative Key";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(177, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Positive Key";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Fallback Key";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(178, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Negative ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Positive ID";
            // 
            // negativeAnswer
            // 
            this.negativeAnswer.Location = new System.Drawing.Point(6, 314);
            this.negativeAnswer.Name = "negativeAnswer";
            this.negativeAnswer.Size = new System.Drawing.Size(443, 20);
            this.negativeAnswer.TabIndex = 8;
            // 
            // positiveAnswer
            // 
            this.positiveAnswer.Location = new System.Drawing.Point(6, 269);
            this.positiveAnswer.Name = "positiveAnswer";
            this.positiveAnswer.Size = new System.Drawing.Size(443, 20);
            this.positiveAnswer.TabIndex = 7;
            // 
            // question
            // 
            this.question.Location = new System.Drawing.Point(6, 225);
            this.question.Name = "question";
            this.question.Size = new System.Drawing.Size(443, 20);
            this.question.TabIndex = 6;
            // 
            // preQuestion
            // 
            this.preQuestion.Location = new System.Drawing.Point(6, 171);
            this.preQuestion.Name = "preQuestion";
            this.preQuestion.Size = new System.Drawing.Size(443, 20);
            this.preQuestion.TabIndex = 5;
            // 
            // negativeResponse
            // 
            this.negativeResponse.Location = new System.Drawing.Point(315, 115);
            this.negativeResponse.Name = "negativeResponse";
            this.negativeResponse.Size = new System.Drawing.Size(120, 20);
            this.negativeResponse.TabIndex = 4;
            // 
            // positiveResponse
            // 
            this.positiveResponse.Location = new System.Drawing.Point(160, 115);
            this.positiveResponse.Name = "positiveResponse";
            this.positiveResponse.Size = new System.Drawing.Size(120, 20);
            this.positiveResponse.TabIndex = 3;
            // 
            // fallBackID
            // 
            this.fallBackID.Location = new System.Drawing.Point(6, 115);
            this.fallBackID.Name = "fallBackID";
            this.fallBackID.Size = new System.Drawing.Size(120, 20);
            this.fallBackID.TabIndex = 2;
            // 
            // negativeID
            // 
            this.negativeID.Location = new System.Drawing.Point(160, 51);
            this.negativeID.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.negativeID.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.negativeID.Name = "negativeID";
            this.negativeID.Size = new System.Drawing.Size(120, 20);
            this.negativeID.TabIndex = 1;
            this.negativeID.Value = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            // 
            // positiveID
            // 
            this.positiveID.Location = new System.Drawing.Point(6, 51);
            this.positiveID.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.positiveID.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.positiveID.Name = "positiveID";
            this.positiveID.Size = new System.Drawing.Size(120, 20);
            this.positiveID.TabIndex = 0;
            this.positiveID.Value = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button2);
            this.groupBox4.Controls.Add(this.loadMarriage);
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Controls.Add(this.createMarriageFile);
            this.groupBox4.Controls.Add(this.createDialogFile);
            this.groupBox4.Controls.Add(this.removeDialogue);
            this.groupBox4.Controls.Add(this.listDialogue);
            this.groupBox4.Location = new System.Drawing.Point(615, 141);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(853, 381);
            this.groupBox4.TabIndex = 23;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Dialogue List";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(724, 66);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 23);
            this.button2.TabIndex = 25;
            this.button2.Text = "Edit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // loadMarriage
            // 
            this.loadMarriage.Location = new System.Drawing.Point(724, 253);
            this.loadMarriage.Name = "loadMarriage";
            this.loadMarriage.Size = new System.Drawing.Size(123, 23);
            this.loadMarriage.TabIndex = 24;
            this.loadMarriage.Text = "Load Marriage Dialogue";
            this.loadMarriage.UseVisualStyleBackColor = true;
            this.loadMarriage.Click += new System.EventHandler(this.LoadMarriage_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(724, 115);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 23);
            this.button1.TabIndex = 24;
            this.button1.Text = "Load Recent";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // createMarriageFile
            // 
            this.createMarriageFile.Location = new System.Drawing.Point(724, 325);
            this.createMarriageFile.Name = "createMarriageFile";
            this.createMarriageFile.Size = new System.Drawing.Size(123, 23);
            this.createMarriageFile.TabIndex = 24;
            this.createMarriageFile.Text = "Generate Marriage Dialogue";
            this.createMarriageFile.UseVisualStyleBackColor = true;
            this.createMarriageFile.Click += new System.EventHandler(this.CreateMarriageFile_Click);
            // 
            // createDialogFile
            // 
            this.createDialogFile.Location = new System.Drawing.Point(724, 181);
            this.createDialogFile.Name = "createDialogFile";
            this.createDialogFile.Size = new System.Drawing.Size(123, 23);
            this.createDialogFile.TabIndex = 2;
            this.createDialogFile.Text = "Generate Dialogue";
            this.createDialogFile.UseVisualStyleBackColor = true;
            this.createDialogFile.Click += new System.EventHandler(this.CreateDialogFile_Click);
            // 
            // removeDialogue
            // 
            this.removeDialogue.Location = new System.Drawing.Point(724, 19);
            this.removeDialogue.Name = "removeDialogue";
            this.removeDialogue.Size = new System.Drawing.Size(123, 23);
            this.removeDialogue.TabIndex = 1;
            this.removeDialogue.Text = "Delete Selected";
            this.removeDialogue.UseVisualStyleBackColor = true;
            this.removeDialogue.Click += new System.EventHandler(this.RemoveDialogue_Click);
            // 
            // listDialogue
            // 
            this.listDialogue.FormattingEnabled = true;
            this.listDialogue.HorizontalScrollbar = true;
            this.listDialogue.Location = new System.Drawing.Point(3, 16);
            this.listDialogue.Name = "listDialogue";
            this.listDialogue.Size = new System.Drawing.Size(705, 355);
            this.listDialogue.TabIndex = 0;
            // 
            // portraitSample
            // 
            this.portraitSample.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.portraitSample.Location = new System.Drawing.Point(618, 528);
            this.portraitSample.Name = "portraitSample";
            this.portraitSample.Size = new System.Drawing.Size(128, 128);
            this.portraitSample.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.portraitSample.TabIndex = 24;
            this.portraitSample.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(752, 582);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 13);
            this.label13.TabIndex = 25;
            this.label13.Text = "label13";
            // 
            // portFrame
            // 
            this.portFrame.Location = new System.Drawing.Point(755, 541);
            this.portFrame.Name = "portFrame";
            this.portFrame.Size = new System.Drawing.Size(62, 20);
            this.portFrame.TabIndex = 26;
            // 
            // showPort
            // 
            this.showPort.Location = new System.Drawing.Point(823, 538);
            this.showPort.Name = "showPort";
            this.showPort.Size = new System.Drawing.Size(101, 23);
            this.showPort.TabIndex = 27;
            this.showPort.Text = "View Portrait";
            this.showPort.UseVisualStyleBackColor = true;
            this.showPort.Click += new System.EventHandler(this.showPort_Click);
            // 
            // addBreak
            // 
            this.addBreak.Location = new System.Drawing.Point(109, 81);
            this.addBreak.Name = "addBreak";
            this.addBreak.Size = new System.Drawing.Size(75, 23);
            this.addBreak.TabIndex = 28;
            this.addBreak.Text = "Line Break";
            this.addBreak.UseVisualStyleBackColor = true;
            this.addBreak.Click += new System.EventHandler(this.addBreak_Click);
            // 
            // fullBreak
            // 
            this.fullBreak.Location = new System.Drawing.Point(190, 81);
            this.fullBreak.Name = "fullBreak";
            this.fullBreak.Size = new System.Drawing.Size(75, 23);
            this.fullBreak.TabIndex = 29;
            this.fullBreak.Text = "Full Break";
            this.fullBreak.UseVisualStyleBackColor = true;
            this.fullBreak.Click += new System.EventHandler(this.fullBreak_Click);
            // 
            // addFarmer
            // 
            this.addFarmer.Location = new System.Drawing.Point(271, 81);
            this.addFarmer.Name = "addFarmer";
            this.addFarmer.Size = new System.Drawing.Size(75, 23);
            this.addFarmer.TabIndex = 30;
            this.addFarmer.Text = "Farmer";
            this.addFarmer.UseVisualStyleBackColor = true;
            this.addFarmer.Click += new System.EventHandler(this.addFarmer_Click);
            // 
            // addFarm
            // 
            this.addFarm.Location = new System.Drawing.Point(352, 81);
            this.addFarm.Name = "addFarm";
            this.addFarm.Size = new System.Drawing.Size(75, 23);
            this.addFarm.TabIndex = 31;
            this.addFarm.Text = "Farm";
            this.addFarm.UseVisualStyleBackColor = true;
            this.addFarm.Click += new System.EventHandler(this.addFarm_Click);
            // 
            // addGender
            // 
            this.addGender.Location = new System.Drawing.Point(433, 81);
            this.addGender.Name = "addGender";
            this.addGender.Size = new System.Drawing.Size(75, 23);
            this.addGender.TabIndex = 32;
            this.addGender.Text = "Gender Split";
            this.addGender.UseVisualStyleBackColor = true;
            this.addGender.Click += new System.EventHandler(this.addGender_Click);
            // 
            // firstKid
            // 
            this.firstKid.Location = new System.Drawing.Point(514, 81);
            this.firstKid.Name = "firstKid";
            this.firstKid.Size = new System.Drawing.Size(75, 23);
            this.firstKid.TabIndex = 33;
            this.firstKid.Text = "First Child";
            this.firstKid.UseVisualStyleBackColor = true;
            this.firstKid.Click += new System.EventHandler(this.firstKid_Click);
            // 
            // kid2
            // 
            this.kid2.Location = new System.Drawing.Point(595, 81);
            this.kid2.Name = "kid2";
            this.kid2.Size = new System.Drawing.Size(75, 23);
            this.kid2.TabIndex = 34;
            this.kid2.Text = "2nd Child";
            this.kid2.UseVisualStyleBackColor = true;
            this.kid2.Click += new System.EventHandler(this.kid2_Click);
            // 
            // addSpouse
            // 
            this.addSpouse.Location = new System.Drawing.Point(676, 81);
            this.addSpouse.Name = "addSpouse";
            this.addSpouse.Size = new System.Drawing.Size(75, 23);
            this.addSpouse.TabIndex = 35;
            this.addSpouse.Text = "Spouse";
            this.addSpouse.UseVisualStyleBackColor = true;
            this.addSpouse.Click += new System.EventHandler(this.addSpouse_Click);
            // 
            // addFav
            // 
            this.addFav.Location = new System.Drawing.Point(757, 81);
            this.addFav.Name = "addFav";
            this.addFav.Size = new System.Drawing.Size(75, 23);
            this.addFav.TabIndex = 36;
            this.addFav.Text = "Favorite";
            this.addFav.UseVisualStyleBackColor = true;
            this.addFav.Click += new System.EventHandler(this.addFav_Click);
            // 
            // petName
            // 
            this.petName.Location = new System.Drawing.Point(838, 81);
            this.petName.Name = "petName";
            this.petName.Size = new System.Drawing.Size(75, 23);
            this.petName.TabIndex = 37;
            this.petName.Text = "Pet";
            this.petName.UseVisualStyleBackColor = true;
            this.petName.Click += new System.EventHandler(this.petName_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(752, 611);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(101, 23);
            this.button3.TabIndex = 38;
            this.button3.Text = "Add to Dialogue";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dialogueBoutique
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1480, 659);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.showPort);
            this.Controls.Add(this.portFrame);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.portraitSample);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "dialogueBoutique";
            this.Text = "Dialogue Boutique";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.negativePoints)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.positivePoints)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.negativeID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.positiveID)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.portraitSample)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.portFrame)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox keyList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button addToKey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox customKey;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.TextBox dialogBody;
        private System.Windows.Forms.Button addDialogList;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown negativePoints;
        private System.Windows.Forms.NumericUpDown positivePoints;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox negativeAnswer;
        private System.Windows.Forms.TextBox positiveAnswer;
        private System.Windows.Forms.TextBox question;
        private System.Windows.Forms.TextBox preQuestion;
        private System.Windows.Forms.TextBox negativeResponse;
        private System.Windows.Forms.TextBox positiveResponse;
        private System.Windows.Forms.TextBox fallBackID;
        private System.Windows.Forms.NumericUpDown negativeID;
        private System.Windows.Forms.NumericUpDown positiveID;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button submitQuestion;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button createMarriageFile;
        private System.Windows.Forms.Button createDialogFile;
        private System.Windows.Forms.Button removeDialogue;
        private System.Windows.Forms.ListBox listDialogue;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button loadMarriage;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox portraitSample;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown portFrame;
        private System.Windows.Forms.Button showPort;
        private System.Windows.Forms.RadioButton marriageDialog;
        private System.Windows.Forms.RadioButton regularDialog;
        private System.Windows.Forms.Button addBreak;
        private System.Windows.Forms.Button petName;
        private System.Windows.Forms.Button addFav;
        private System.Windows.Forms.Button addSpouse;
        private System.Windows.Forms.Button kid2;
        private System.Windows.Forms.Button firstKid;
        private System.Windows.Forms.Button addGender;
        private System.Windows.Forms.Button addFarm;
        private System.Windows.Forms.Button addFarmer;
        private System.Windows.Forms.Button fullBreak;
        private System.Windows.Forms.Button button3;
    }
}