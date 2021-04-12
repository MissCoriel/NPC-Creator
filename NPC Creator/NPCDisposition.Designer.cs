namespace NPC_Creator
{
    partial class NPCDisposition
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NPCDisposition));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.npcDisplayName1 = new System.Windows.Forms.TextBox();
            this.isDatable = new System.Windows.Forms.CheckBox();
            this.isFemale = new System.Windows.Forms.CheckBox();
            this.npcOptimism1 = new System.Windows.Forms.ComboBox();
            this.npcSocial1 = new System.Windows.Forms.ComboBox();
            this.npcManners1 = new System.Windows.Forms.ComboBox();
            this.npcAge1 = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.startY1 = new System.Windows.Forms.NumericUpDown();
            this.startX1 = new System.Windows.Forms.NumericUpDown();
            this.npcStartingMap1 = new System.Windows.Forms.ComboBox();
            this.npcBday1 = new System.Windows.Forms.NumericUpDown();
            this.npcBdayMonth1 = new System.Windows.Forms.ComboBox();
            this.npcHome1 = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.allowPregRole = new System.Windows.Forms.CheckBox();
            this.npcPregnancyRole1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.npcRelations1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.npcLoveInt1 = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.clearAll = new System.Windows.Forms.Button();
            this.delSelect = new System.Windows.Forms.Button();
            this.addWhen = new System.Windows.Forms.Button();
            this.whenList = new System.Windows.Forms.ListBox();
            this.whenData = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.altPregRole = new System.Windows.Forms.ComboBox();
            this.altMapY = new System.Windows.Forms.NumericUpDown();
            this.altMapX = new System.Windows.Forms.NumericUpDown();
            this.altStartLocation = new System.Windows.Forms.ComboBox();
            this.isDatableAlt = new System.Windows.Forms.CheckBox();
            this.altDisplayName = new System.Windows.Forms.TextBox();
            this.enableDispoAlt = new System.Windows.Forms.CheckBox();
            this.processDispo = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.startY1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startX1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.npcBday1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.altMapY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.altMapX)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.npcDisplayName1);
            this.groupBox1.Controls.Add(this.isDatable);
            this.groupBox1.Controls.Add(this.isFemale);
            this.groupBox1.Controls.Add(this.npcOptimism1);
            this.groupBox1.Controls.Add(this.npcSocial1);
            this.groupBox1.Controls.Add(this.npcManners1);
            this.groupBox1.Controls.Add(this.npcAge1);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(206, 186);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // npcDisplayName1
            // 
            this.npcDisplayName1.Location = new System.Drawing.Point(6, 35);
            this.npcDisplayName1.Name = "npcDisplayName1";
            this.npcDisplayName1.Size = new System.Drawing.Size(100, 20);
            this.npcDisplayName1.TabIndex = 6;
            // 
            // isDatable
            // 
            this.isDatable.AutoSize = true;
            this.isDatable.Location = new System.Drawing.Point(6, 125);
            this.isDatable.Name = "isDatable";
            this.isDatable.Size = new System.Drawing.Size(74, 17);
            this.isDatable.TabIndex = 5;
            this.isDatable.Text = "Can Marry";
            this.isDatable.UseVisualStyleBackColor = true;
            this.isDatable.CheckedChanged += new System.EventHandler(this.isDatable_CheckedChanged);
            // 
            // isFemale
            // 
            this.isFemale.AutoSize = true;
            this.isFemale.Location = new System.Drawing.Point(6, 85);
            this.isFemale.Name = "isFemale";
            this.isFemale.Size = new System.Drawing.Size(71, 17);
            this.isFemale.TabIndex = 4;
            this.isFemale.Text = "Is Female";
            this.isFemale.UseVisualStyleBackColor = true;
            this.isFemale.CheckedChanged += new System.EventHandler(this.isFemale_CheckedChanged);
            // 
            // npcOptimism1
            // 
            this.npcOptimism1.FormattingEnabled = true;
            this.npcOptimism1.Items.AddRange(new object[] {
            "positive",
            "neutral",
            "negative"});
            this.npcOptimism1.Location = new System.Drawing.Point(122, 135);
            this.npcOptimism1.Name = "npcOptimism1";
            this.npcOptimism1.Size = new System.Drawing.Size(72, 21);
            this.npcOptimism1.TabIndex = 3;
            this.npcOptimism1.Text = "Optimisim";
            // 
            // npcSocial1
            // 
            this.npcSocial1.FormattingEnabled = true;
            this.npcSocial1.Items.AddRange(new object[] {
            "outgoing",
            "neutral",
            "shy"});
            this.npcSocial1.Location = new System.Drawing.Point(122, 96);
            this.npcSocial1.Name = "npcSocial1";
            this.npcSocial1.Size = new System.Drawing.Size(64, 21);
            this.npcSocial1.TabIndex = 2;
            this.npcSocial1.Text = "Social";
            // 
            // npcManners1
            // 
            this.npcManners1.FormattingEnabled = true;
            this.npcManners1.Items.AddRange(new object[] {
            "polite",
            "neutral",
            "rude"});
            this.npcManners1.Location = new System.Drawing.Point(122, 56);
            this.npcManners1.Name = "npcManners1";
            this.npcManners1.Size = new System.Drawing.Size(64, 21);
            this.npcManners1.TabIndex = 1;
            this.npcManners1.Text = "Manners";
            // 
            // npcAge1
            // 
            this.npcAge1.FormattingEnabled = true;
            this.npcAge1.Items.AddRange(new object[] {
            "child",
            "teen",
            "adult"});
            this.npcAge1.Location = new System.Drawing.Point(122, 19);
            this.npcAge1.Name = "npcAge1";
            this.npcAge1.Size = new System.Drawing.Size(64, 21);
            this.npcAge1.TabIndex = 0;
            this.npcAge1.Text = "Age";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.startY1);
            this.groupBox2.Controls.Add(this.startX1);
            this.groupBox2.Controls.Add(this.npcStartingMap1);
            this.groupBox2.Controls.Add(this.npcBday1);
            this.groupBox2.Controls.Add(this.npcBdayMonth1);
            this.groupBox2.Controls.Add(this.npcHome1);
            this.groupBox2.Location = new System.Drawing.Point(212, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 184);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "X             Y";
            // 
            // startY1
            // 
            this.startY1.Location = new System.Drawing.Point(146, 110);
            this.startY1.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.startY1.Minimum = new decimal(new int[] {
            9999,
            0,
            0,
            -2147483648});
            this.startY1.Name = "startY1";
            this.startY1.Size = new System.Drawing.Size(43, 20);
            this.startY1.TabIndex = 5;
            // 
            // startX1
            // 
            this.startX1.Location = new System.Drawing.Point(97, 109);
            this.startX1.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.startX1.Minimum = new decimal(new int[] {
            9999,
            0,
            0,
            -2147483648});
            this.startX1.Name = "startX1";
            this.startX1.Size = new System.Drawing.Size(43, 20);
            this.startX1.TabIndex = 4;
            // 
            // npcStartingMap1
            // 
            this.npcStartingMap1.FormattingEnabled = true;
            this.npcStartingMap1.Location = new System.Drawing.Point(6, 109);
            this.npcStartingMap1.Name = "npcStartingMap1";
            this.npcStartingMap1.Size = new System.Drawing.Size(85, 21);
            this.npcStartingMap1.TabIndex = 3;
            this.npcStartingMap1.Text = "Starting Map";
            // 
            // npcBday1
            // 
            this.npcBday1.Location = new System.Drawing.Point(83, 60);
            this.npcBday1.Maximum = new decimal(new int[] {
            28,
            0,
            0,
            0});
            this.npcBday1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.npcBday1.Name = "npcBday1";
            this.npcBday1.Size = new System.Drawing.Size(36, 20);
            this.npcBday1.TabIndex = 2;
            this.npcBday1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // npcBdayMonth1
            // 
            this.npcBdayMonth1.FormattingEnabled = true;
            this.npcBdayMonth1.Items.AddRange(new object[] {
            "spring",
            "summer",
            "fall",
            "winter"});
            this.npcBdayMonth1.Location = new System.Drawing.Point(6, 59);
            this.npcBdayMonth1.Name = "npcBdayMonth1";
            this.npcBdayMonth1.Size = new System.Drawing.Size(71, 21);
            this.npcBdayMonth1.TabIndex = 1;
            this.npcBdayMonth1.Text = "Birthday";
            // 
            // npcHome1
            // 
            this.npcHome1.FormattingEnabled = true;
            this.npcHome1.Items.AddRange(new object[] {
            "Town",
            "Desert",
            "Other"});
            this.npcHome1.Location = new System.Drawing.Point(6, 32);
            this.npcHome1.Name = "npcHome1";
            this.npcHome1.Size = new System.Drawing.Size(54, 21);
            this.npcHome1.TabIndex = 0;
            this.npcHome1.Text = "Home";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.allowPregRole);
            this.groupBox3.Controls.Add(this.npcPregnancyRole1);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.npcRelations1);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.npcLoveInt1);
            this.groupBox3.Location = new System.Drawing.Point(418, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(304, 184);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // allowPregRole
            // 
            this.allowPregRole.AutoSize = true;
            this.allowPregRole.Location = new System.Drawing.Point(142, 109);
            this.allowPregRole.Name = "allowPregRole";
            this.allowPregRole.Size = new System.Drawing.Size(142, 17);
            this.allowPregRole.TabIndex = 5;
            this.allowPregRole.Text = "Support Pregnancy Role";
            this.allowPregRole.UseVisualStyleBackColor = true;
            this.allowPregRole.CheckedChanged += new System.EventHandler(this.allowPregRole_CheckedChanged);
            // 
            // npcPregnancyRole1
            // 
            this.npcPregnancyRole1.Enabled = false;
            this.npcPregnancyRole1.FormattingEnabled = true;
            this.npcPregnancyRole1.Items.AddRange(new object[] {
            "PregnancyRole become",
            "PregnancyRole make",
            "PregnancyRole adopt"});
            this.npcPregnancyRole1.Location = new System.Drawing.Point(6, 108);
            this.npcPregnancyRole1.Name = "npcPregnancyRole1";
            this.npcPregnancyRole1.Size = new System.Drawing.Size(121, 21);
            this.npcPregnancyRole1.TabIndex = 4;
            this.npcPregnancyRole1.Text = "Choose Role";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(112, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "<- Relationships - leave blank if none";
            // 
            // npcRelations1
            // 
            this.npcRelations1.Location = new System.Drawing.Point(6, 70);
            this.npcRelations1.Name = "npcRelations1";
            this.npcRelations1.Size = new System.Drawing.Size(100, 20);
            this.npcRelations1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "<- Love Interest - Leave Null";
            // 
            // npcLoveInt1
            // 
            this.npcLoveInt1.Location = new System.Drawing.Point(6, 32);
            this.npcLoveInt1.Name = "npcLoveInt1";
            this.npcLoveInt1.Size = new System.Drawing.Size(100, 20);
            this.npcLoveInt1.TabIndex = 0;
            this.npcLoveInt1.Text = "null";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.clearAll);
            this.groupBox4.Controls.Add(this.delSelect);
            this.groupBox4.Controls.Add(this.addWhen);
            this.groupBox4.Controls.Add(this.whenList);
            this.groupBox4.Controls.Add(this.whenData);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.altPregRole);
            this.groupBox4.Controls.Add(this.altMapY);
            this.groupBox4.Controls.Add(this.altMapX);
            this.groupBox4.Controls.Add(this.altStartLocation);
            this.groupBox4.Controls.Add(this.isDatableAlt);
            this.groupBox4.Controls.Add(this.altDisplayName);
            this.groupBox4.Enabled = false;
            this.groupBox4.Location = new System.Drawing.Point(0, 241);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(722, 145);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Alternate Disposition";
            // 
            // clearAll
            // 
            this.clearAll.Location = new System.Drawing.Point(510, 97);
            this.clearAll.Name = "clearAll";
            this.clearAll.Size = new System.Drawing.Size(75, 23);
            this.clearAll.TabIndex = 19;
            this.clearAll.Text = "Clear";
            this.clearAll.UseVisualStyleBackColor = true;
            this.clearAll.Click += new System.EventHandler(this.clearAll_Click);
            // 
            // delSelect
            // 
            this.delSelect.Location = new System.Drawing.Point(510, 68);
            this.delSelect.Name = "delSelect";
            this.delSelect.Size = new System.Drawing.Size(75, 23);
            this.delSelect.TabIndex = 18;
            this.delSelect.Text = "Delete";
            this.delSelect.UseVisualStyleBackColor = true;
            this.delSelect.Click += new System.EventHandler(this.delSelect_Click);
            // 
            // addWhen
            // 
            this.addWhen.Location = new System.Drawing.Point(427, 42);
            this.addWhen.Name = "addWhen";
            this.addWhen.Size = new System.Drawing.Size(75, 23);
            this.addWhen.TabIndex = 17;
            this.addWhen.Text = "Add ->";
            this.addWhen.UseVisualStyleBackColor = true;
            this.addWhen.Click += new System.EventHandler(this.addWhen_Click);
            // 
            // whenList
            // 
            this.whenList.FormattingEnabled = true;
            this.whenList.Location = new System.Drawing.Point(591, 37);
            this.whenList.Name = "whenList";
            this.whenList.Size = new System.Drawing.Size(120, 95);
            this.whenList.TabIndex = 16;
            // 
            // whenData
            // 
            this.whenData.Location = new System.Drawing.Point(427, 16);
            this.whenData.Name = "whenData";
            this.whenData.Size = new System.Drawing.Size(100, 20);
            this.whenData.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(392, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "When:";
            // 
            // altPregRole
            // 
            this.altPregRole.Enabled = false;
            this.altPregRole.FormattingEnabled = true;
            this.altPregRole.Items.AddRange(new object[] {
            "PregnancyRole become",
            "PregnancyRole make",
            "PregnancyRole adopt"});
            this.altPregRole.Location = new System.Drawing.Point(140, 81);
            this.altPregRole.Name = "altPregRole";
            this.altPregRole.Size = new System.Drawing.Size(121, 21);
            this.altPregRole.TabIndex = 14;
            this.altPregRole.Text = "Alternate Role";
            // 
            // altMapY
            // 
            this.altMapY.Location = new System.Drawing.Point(320, 38);
            this.altMapY.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.altMapY.Minimum = new decimal(new int[] {
            9999,
            0,
            0,
            -2147483648});
            this.altMapY.Name = "altMapY";
            this.altMapY.Size = new System.Drawing.Size(46, 20);
            this.altMapY.TabIndex = 13;
            // 
            // altMapX
            // 
            this.altMapX.Location = new System.Drawing.Point(267, 38);
            this.altMapX.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.altMapX.Minimum = new decimal(new int[] {
            9999,
            0,
            0,
            -2147483648});
            this.altMapX.Name = "altMapX";
            this.altMapX.Size = new System.Drawing.Size(46, 20);
            this.altMapX.TabIndex = 12;
            // 
            // altStartLocation
            // 
            this.altStartLocation.FormattingEnabled = true;
            this.altStartLocation.Location = new System.Drawing.Point(140, 37);
            this.altStartLocation.Name = "altStartLocation";
            this.altStartLocation.Size = new System.Drawing.Size(121, 21);
            this.altStartLocation.TabIndex = 11;
            this.altStartLocation.Text = "Alternate Start";
            // 
            // isDatableAlt
            // 
            this.isDatableAlt.AutoSize = true;
            this.isDatableAlt.Location = new System.Drawing.Point(12, 83);
            this.isDatableAlt.Name = "isDatableAlt";
            this.isDatableAlt.Size = new System.Drawing.Size(74, 17);
            this.isDatableAlt.TabIndex = 10;
            this.isDatableAlt.Text = "Can Marry";
            this.isDatableAlt.UseVisualStyleBackColor = true;
            this.isDatableAlt.CheckedChanged += new System.EventHandler(this.isDatableAlt_CheckedChanged);
            // 
            // altDisplayName
            // 
            this.altDisplayName.Location = new System.Drawing.Point(12, 37);
            this.altDisplayName.Name = "altDisplayName";
            this.altDisplayName.Size = new System.Drawing.Size(100, 20);
            this.altDisplayName.TabIndex = 9;
            this.altDisplayName.Text = "Alternate Name";
            // 
            // enableDispoAlt
            // 
            this.enableDispoAlt.AutoSize = true;
            this.enableDispoAlt.Location = new System.Drawing.Point(12, 208);
            this.enableDispoAlt.Name = "enableDispoAlt";
            this.enableDispoAlt.Size = new System.Drawing.Size(216, 17);
            this.enableDispoAlt.TabIndex = 0;
            this.enableDispoAlt.Text = "Enable Alternate Disposition (Advanced)";
            this.enableDispoAlt.UseVisualStyleBackColor = true;
            this.enableDispoAlt.CheckedChanged += new System.EventHandler(this.enableDispoAlt_CheckedChanged);
            // 
            // processDispo
            // 
            this.processDispo.Location = new System.Drawing.Point(510, 204);
            this.processDispo.Name = "processDispo";
            this.processDispo.Size = new System.Drawing.Size(166, 23);
            this.processDispo.TabIndex = 20;
            this.processDispo.Text = "Generate Disposition";
            this.processDispo.UseVisualStyleBackColor = true;
            this.processDispo.Click += new System.EventHandler(this.processDispo_Click);
            // 
            // NPCDisposition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 391);
            this.Controls.Add(this.processDispo);
            this.Controls.Add(this.enableDispoAlt);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NPCDisposition";
            this.Text = "NPCDisposition";
            this.Load += new System.EventHandler(this.NPCDisposition_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.startY1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startX1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.npcBday1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.altMapY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.altMapX)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox npcAge1;
        private System.Windows.Forms.ComboBox npcManners1;
        private System.Windows.Forms.ComboBox npcSocial1;
        private System.Windows.Forms.ComboBox npcOptimism1;
        private System.Windows.Forms.CheckBox isDatable;
        private System.Windows.Forms.CheckBox isFemale;
        private System.Windows.Forms.TextBox npcDisplayName1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox npcHome1;
        private System.Windows.Forms.NumericUpDown npcBday1;
        private System.Windows.Forms.ComboBox npcBdayMonth1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown startY1;
        private System.Windows.Forms.NumericUpDown startX1;
        private System.Windows.Forms.ComboBox npcStartingMap1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox npcLoveInt1;
        private System.Windows.Forms.CheckBox allowPregRole;
        private System.Windows.Forms.ComboBox npcPregnancyRole1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox npcRelations1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button clearAll;
        private System.Windows.Forms.Button delSelect;
        private System.Windows.Forms.Button addWhen;
        private System.Windows.Forms.ListBox whenList;
        private System.Windows.Forms.TextBox whenData;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox altPregRole;
        private System.Windows.Forms.NumericUpDown altMapY;
        private System.Windows.Forms.NumericUpDown altMapX;
        private System.Windows.Forms.ComboBox altStartLocation;
        private System.Windows.Forms.CheckBox isDatableAlt;
        private System.Windows.Forms.TextBox altDisplayName;
        private System.Windows.Forms.CheckBox enableDispoAlt;
        private System.Windows.Forms.Button processDispo;
    }
}