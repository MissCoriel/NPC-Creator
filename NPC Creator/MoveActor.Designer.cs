namespace NPC_Creator
{
    partial class MoveActor
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.npcList = new System.Windows.Forms.ComboBox();
            this.moveX = new System.Windows.Forms.NumericUpDown();
            this.moveY = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.isContinue = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.moveX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moveY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.isContinue);
            this.groupBox1.Controls.Add(this.npcList);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(155, 119);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select NPC or Type Name";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.numericUpDown3);
            this.groupBox2.Controls.Add(this.moveY);
            this.groupBox2.Controls.Add(this.moveX);
            this.groupBox2.Location = new System.Drawing.Point(161, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 87);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Movements";
            // 
            // npcList
            // 
            this.npcList.FormattingEnabled = true;
            this.npcList.Location = new System.Drawing.Point(12, 29);
            this.npcList.Name = "npcList";
            this.npcList.Size = new System.Drawing.Size(121, 21);
            this.npcList.TabIndex = 0;
            // 
            // moveX
            // 
            this.moveX.Location = new System.Drawing.Point(6, 30);
            this.moveX.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.moveX.Minimum = new decimal(new int[] {
            9999,
            0,
            0,
            -2147483648});
            this.moveX.Name = "moveX";
            this.moveX.Size = new System.Drawing.Size(51, 20);
            this.moveX.TabIndex = 1;
            this.moveX.ValueChanged += new System.EventHandler(this.moveX_ValueChanged);
            // 
            // moveY
            // 
            this.moveY.Location = new System.Drawing.Point(72, 30);
            this.moveY.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.moveY.Minimum = new decimal(new int[] {
            9999,
            0,
            0,
            -2147483648});
            this.moveY.Name = "moveY";
            this.moveY.Size = new System.Drawing.Size(51, 20);
            this.moveY.TabIndex = 2;
            this.moveY.ValueChanged += new System.EventHandler(this.moveY_ValueChanged);
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(141, 30);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(37, 20);
            this.numericUpDown3.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Y";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(139, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Facing";
            // 
            // isContinue
            // 
            this.isContinue.AutoSize = true;
            this.isContinue.Location = new System.Drawing.Point(12, 70);
            this.isContinue.Name = "isContinue";
            this.isContinue.Size = new System.Drawing.Size(121, 17);
            this.isContinue.TabIndex = 1;
            this.isContinue.Text = "Continue with Event";
            this.isContinue.UseVisualStyleBackColor = true;
            this.isContinue.CheckedChanged += new System.EventHandler(this.isContinue_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(167, 96);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Commit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MoveActor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 124);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MoveActor";
            this.Text = "MoveActor";
            this.Load += new System.EventHandler(this.MoveActor_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.moveX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moveY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox npcList;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.NumericUpDown moveY;
        private System.Windows.Forms.NumericUpDown moveX;
        private System.Windows.Forms.CheckBox isContinue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}