namespace NPC_Creator
{
    partial class MakeInvisible
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
            this.originX = new System.Windows.Forms.NumericUpDown();
            this.originY = new System.Windows.Forms.NumericUpDown();
            this.areaX = new System.Windows.Forms.NumericUpDown();
            this.areaY = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.areaCheck = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.originX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.originY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.areaX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.areaY)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Create Coordinates";
            // 
            // originX
            // 
            this.originX.Location = new System.Drawing.Point(34, 49);
            this.originX.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.originX.Minimum = new decimal(new int[] {
            9999,
            0,
            0,
            -2147483648});
            this.originX.Name = "originX";
            this.originX.Size = new System.Drawing.Size(75, 20);
            this.originX.TabIndex = 1;
            // 
            // originY
            // 
            this.originY.Location = new System.Drawing.Point(141, 49);
            this.originY.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.originY.Minimum = new decimal(new int[] {
            9999,
            0,
            0,
            -2147483648});
            this.originY.Name = "originY";
            this.originY.Size = new System.Drawing.Size(75, 20);
            this.originY.TabIndex = 2;
            // 
            // areaX
            // 
            this.areaX.Enabled = false;
            this.areaX.Location = new System.Drawing.Point(34, 121);
            this.areaX.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.areaX.Minimum = new decimal(new int[] {
            9999,
            0,
            0,
            -2147483648});
            this.areaX.Name = "areaX";
            this.areaX.Size = new System.Drawing.Size(75, 20);
            this.areaX.TabIndex = 3;
            // 
            // areaY
            // 
            this.areaY.Enabled = false;
            this.areaY.Location = new System.Drawing.Point(141, 121);
            this.areaY.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.areaY.Minimum = new decimal(new int[] {
            9999,
            0,
            0,
            -2147483648});
            this.areaY.Name = "areaY";
            this.areaY.Size = new System.Drawing.Size(75, 20);
            this.areaY.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "X:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "X:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(118, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Y:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(118, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Y:";
            // 
            // areaCheck
            // 
            this.areaCheck.AutoSize = true;
            this.areaCheck.Location = new System.Drawing.Point(71, 86);
            this.areaCheck.Name = "areaCheck";
            this.areaCheck.Size = new System.Drawing.Size(82, 17);
            this.areaCheck.TabIndex = 9;
            this.areaCheck.Text = "Create Area";
            this.areaCheck.UseVisualStyleBackColor = true;
            this.areaCheck.CheckedChanged += new System.EventHandler(this.areaCheck_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(78, 168);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Commit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MakeInvisible
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 222);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.areaCheck);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.areaY);
            this.Controls.Add(this.areaX);
            this.Controls.Add(this.originY);
            this.Controls.Add(this.originX);
            this.Controls.Add(this.label1);
            this.Name = "MakeInvisible";
            this.Text = "MakeInvisible";
            ((System.ComponentModel.ISupportInitialize)(this.originX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.originY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.areaX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.areaY)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown originX;
        private System.Windows.Forms.NumericUpDown originY;
        private System.Windows.Forms.NumericUpDown areaX;
        private System.Windows.Forms.NumericUpDown areaY;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox areaCheck;
        private System.Windows.Forms.Button button1;
    }
}