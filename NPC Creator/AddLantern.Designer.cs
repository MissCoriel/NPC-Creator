namespace NPC_Creator
{
    partial class AddLantern
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
            this.springObjects = new System.Windows.Forms.PictureBox();
            this.objectFrame = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lanternX = new System.Windows.Forms.NumericUpDown();
            this.lanternY = new System.Windows.Forms.NumericUpDown();
            this.lanternRad = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.springObjects)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objectFrame)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lanternX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lanternY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lanternRad)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.objectFrame);
            this.groupBox1.Controls.Add(this.springObjects);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(263, 153);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lantern Image";
            // 
            // springObjects
            // 
            this.springObjects.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.springObjects.Location = new System.Drawing.Point(3, 16);
            this.springObjects.Name = "springObjects";
            this.springObjects.Size = new System.Drawing.Size(128, 128);
            this.springObjects.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.springObjects.TabIndex = 0;
            this.springObjects.TabStop = false;
            // 
            // objectFrame
            // 
            this.objectFrame.Location = new System.Drawing.Point(137, 45);
            this.objectFrame.Maximum = new decimal(new int[] {
            935,
            0,
            0,
            0});
            this.objectFrame.Name = "objectFrame";
            this.objectFrame.Size = new System.Drawing.Size(55, 20);
            this.objectFrame.TabIndex = 1;
            this.objectFrame.ValueChanged += new System.EventHandler(this.objectFrame_ValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.lanternRad);
            this.groupBox2.Controls.Add(this.lanternY);
            this.groupBox2.Controls.Add(this.lanternX);
            this.groupBox2.Location = new System.Drawing.Point(269, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(259, 100);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lantern Data";
            // 
            // lanternX
            // 
            this.lanternX.Location = new System.Drawing.Point(6, 45);
            this.lanternX.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.lanternX.Minimum = new decimal(new int[] {
            9999,
            0,
            0,
            -2147483648});
            this.lanternX.Name = "lanternX";
            this.lanternX.Size = new System.Drawing.Size(47, 20);
            this.lanternX.TabIndex = 0;
            // 
            // lanternY
            // 
            this.lanternY.Location = new System.Drawing.Point(78, 45);
            this.lanternY.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.lanternY.Minimum = new decimal(new int[] {
            9999,
            0,
            0,
            -2147483648});
            this.lanternY.Name = "lanternY";
            this.lanternY.Size = new System.Drawing.Size(47, 20);
            this.lanternY.TabIndex = 1;
            // 
            // lanternRad
            // 
            this.lanternRad.Location = new System.Drawing.Point(145, 45);
            this.lanternRad.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.lanternRad.Name = "lanternRad";
            this.lanternRad.Size = new System.Drawing.Size(52, 20);
            this.lanternRad.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "X:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Y:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(142, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Radius";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(275, 121);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(236, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Commit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddLantern
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 159);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddLantern";
            this.Text = "AddLantern";
            this.Load += new System.EventHandler(this.AddLantern_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.springObjects)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objectFrame)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lanternX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lanternY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lanternRad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown objectFrame;
        private System.Windows.Forms.PictureBox springObjects;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown lanternRad;
        private System.Windows.Forms.NumericUpDown lanternY;
        private System.Windows.Forms.NumericUpDown lanternX;
        private System.Windows.Forms.Button button1;
    }
}