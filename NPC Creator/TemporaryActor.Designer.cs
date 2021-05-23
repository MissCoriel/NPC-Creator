namespace NPC_Creator
{
    partial class TemporaryActor
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
            this.actorName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dimX = new System.Windows.Forms.NumericUpDown();
            this.dimY = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.actorX = new System.Windows.Forms.NumericUpDown();
            this.actorY = new System.Windows.Forms.NumericUpDown();
            this.actorFacing = new System.Windows.Forms.NumericUpDown();
            this.isBreathing = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Commit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dimX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dimY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actorX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actorY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actorFacing)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // actorName
            // 
            this.actorName.Location = new System.Drawing.Point(105, 37);
            this.actorName.Name = "actorName";
            this.actorName.Size = new System.Drawing.Size(100, 20);
            this.actorName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Actor Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Sprite Dimensions:";
            // 
            // dimX
            // 
            this.dimX.Increment = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.dimX.Location = new System.Drawing.Point(106, 75);
            this.dimX.Maximum = new decimal(new int[] {
            512,
            0,
            0,
            0});
            this.dimX.Minimum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.dimX.Name = "dimX";
            this.dimX.Size = new System.Drawing.Size(44, 20);
            this.dimX.TabIndex = 4;
            this.dimX.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            // 
            // dimY
            // 
            this.dimY.Increment = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.dimY.Location = new System.Drawing.Point(177, 75);
            this.dimY.Maximum = new decimal(new int[] {
            512,
            0,
            0,
            0});
            this.dimY.Minimum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.dimY.Name = "dimY";
            this.dimY.Size = new System.Drawing.Size(44, 20);
            this.dimY.TabIndex = 5;
            this.dimY.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Actor Location:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(90, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "X:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(188, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Y:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(272, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Facing:";
            // 
            // actorX
            // 
            this.actorX.Location = new System.Drawing.Point(113, 123);
            this.actorX.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.actorX.Minimum = new decimal(new int[] {
            9999,
            0,
            0,
            -2147483648});
            this.actorX.Name = "actorX";
            this.actorX.Size = new System.Drawing.Size(59, 20);
            this.actorX.TabIndex = 10;
            // 
            // actorY
            // 
            this.actorY.Location = new System.Drawing.Point(207, 123);
            this.actorY.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.actorY.Minimum = new decimal(new int[] {
            9999,
            0,
            0,
            -2147483648});
            this.actorY.Name = "actorY";
            this.actorY.Size = new System.Drawing.Size(59, 20);
            this.actorY.TabIndex = 11;
            // 
            // actorFacing
            // 
            this.actorFacing.Location = new System.Drawing.Point(320, 123);
            this.actorFacing.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.actorFacing.Name = "actorFacing";
            this.actorFacing.Size = new System.Drawing.Size(32, 20);
            this.actorFacing.TabIndex = 12;
            // 
            // isBreathing
            // 
            this.isBreathing.AutoSize = true;
            this.isBreathing.Location = new System.Drawing.Point(234, 39);
            this.isBreathing.Name = "isBreathing";
            this.isBreathing.Size = new System.Drawing.Size(120, 17);
            this.isBreathing.TabIndex = 13;
            this.isBreathing.Text = "Breathing Animation";
            this.isBreathing.UseVisualStyleBackColor = true;
            this.isBreathing.CheckedChanged += new System.EventHandler(this.isBreathing_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Commit);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.isBreathing);
            this.groupBox1.Controls.Add(this.actorName);
            this.groupBox1.Controls.Add(this.actorFacing);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.actorY);
            this.groupBox1.Controls.Add(this.dimX);
            this.groupBox1.Controls.Add(this.actorX);
            this.groupBox1.Controls.Add(this.dimY);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(1, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(364, 184);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Temporary Actor Information";
            // 
            // Commit
            // 
            this.Commit.Location = new System.Drawing.Point(60, 155);
            this.Commit.Name = "Commit";
            this.Commit.Size = new System.Drawing.Size(254, 23);
            this.Commit.TabIndex = 15;
            this.Commit.Text = "Commit";
            this.Commit.UseVisualStyleBackColor = true;
            this.Commit.Click += new System.EventHandler(this.Commit_Click);
            // 
            // TemporaryActor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 187);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Name = "TemporaryActor";
            this.Text = "TemporaryActor";
            this.Load += new System.EventHandler(this.TemporaryActor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dimX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dimY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actorX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actorY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actorFacing)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox actorName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown dimX;
        private System.Windows.Forms.NumericUpDown dimY;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown actorX;
        private System.Windows.Forms.NumericUpDown actorY;
        private System.Windows.Forms.NumericUpDown actorFacing;
        private System.Windows.Forms.CheckBox isBreathing;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Commit;
    }
}