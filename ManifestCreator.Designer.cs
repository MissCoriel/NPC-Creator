namespace NPC_Creator
{
    partial class manifestCreator
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
            this.button1 = new System.Windows.Forms.Button();
            this.uniqueID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.bugFix = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.minorVersion = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.majorVersion = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.modDescription = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.modAuthor = new System.Windows.Forms.TextBox();
            this.modName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bugFix)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minorVersion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.majorVersion)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.uniqueID);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.bugFix);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.minorVersion);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.majorVersion);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.modDescription);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.modAuthor);
            this.groupBox1.Controls.Add(this.modName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(631, 178);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Manifest.json";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(481, 133);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Save Manifest";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // uniqueID
            // 
            this.uniqueID.Location = new System.Drawing.Point(68, 133);
            this.uniqueID.Name = "uniqueID";
            this.uniqueID.Size = new System.Drawing.Size(239, 20);
            this.uniqueID.TabIndex = 12;
            this.uniqueID.Text = "Author.Mod";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Unique ID";
            // 
            // bugFix
            // 
            this.bugFix.Location = new System.Drawing.Point(180, 104);
            this.bugFix.Name = "bugFix";
            this.bugFix.Size = new System.Drawing.Size(35, 20);
            this.bugFix.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(164, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(10, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = ".";
            // 
            // minorVersion
            // 
            this.minorVersion.Location = new System.Drawing.Point(125, 104);
            this.minorVersion.Name = "minorVersion";
            this.minorVersion.Size = new System.Drawing.Size(33, 20);
            this.minorVersion.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(109, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(10, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = ".";
            // 
            // majorVersion
            // 
            this.majorVersion.Location = new System.Drawing.Point(68, 104);
            this.majorVersion.Name = "majorVersion";
            this.majorVersion.Size = new System.Drawing.Size(35, 20);
            this.majorVersion.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Version";
            // 
            // modDescription
            // 
            this.modDescription.Location = new System.Drawing.Point(69, 74);
            this.modDescription.Name = "modDescription";
            this.modDescription.Size = new System.Drawing.Size(556, 20);
            this.modDescription.TabIndex = 5;
            this.modDescription.Text = "Created by MissCoriel\'s NPC Creator!";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Description";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mod Author";
            // 
            // modAuthor
            // 
            this.modAuthor.Location = new System.Drawing.Point(68, 45);
            this.modAuthor.Name = "modAuthor";
            this.modAuthor.Size = new System.Drawing.Size(359, 20);
            this.modAuthor.TabIndex = 2;
            // 
            // modName
            // 
            this.modName.Location = new System.Drawing.Point(68, 19);
            this.modName.Name = "modName";
            this.modName.Size = new System.Drawing.Size(359, 20);
            this.modName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mod Name";
            // 
            // manifestCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(640, 186);
            this.Controls.Add(this.groupBox1);
            this.Name = "manifestCreator";
            this.Text = "Manifest Creator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bugFix)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minorVersion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.majorVersion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox uniqueID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown bugFix;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown minorVersion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown majorVersion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox modDescription;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox modAuthor;
        private System.Windows.Forms.TextBox modName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}