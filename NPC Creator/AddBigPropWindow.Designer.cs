namespace NPC_Creator
{
    partial class AddBigPropWindow
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
            this.bigPropImg = new System.Windows.Forms.PictureBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.propY = new System.Windows.Forms.NumericUpDown();
            this.propX = new System.Windows.Forms.NumericUpDown();
            this.AddCommand = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bigPropImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.propY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.propX)).BeginInit();
            this.SuspendLayout();
            // 
            // bigPropImg
            // 
            this.bigPropImg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.bigPropImg.Location = new System.Drawing.Point(6, 15);
            this.bigPropImg.Name = "bigPropImg";
            this.bigPropImg.Size = new System.Drawing.Size(64, 128);
            this.bigPropImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bigPropImg.TabIndex = 1;
            this.bigPropImg.TabStop = false;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(101, 60);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            143,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(66, 20);
            this.numericUpDown1.TabIndex = 2;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Prop ID";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.bigPropImg);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(2, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(262, 153);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Prop ID";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(101, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Image Help";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.propY);
            this.groupBox2.Controls.Add(this.propX);
            this.groupBox2.Location = new System.Drawing.Point(270, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(156, 110);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Prop Location";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Y:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "X:";
            // 
            // propY
            // 
            this.propY.Location = new System.Drawing.Point(89, 48);
            this.propY.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.propY.Minimum = new decimal(new int[] {
            9999,
            0,
            0,
            -2147483648});
            this.propY.Name = "propY";
            this.propY.Size = new System.Drawing.Size(57, 20);
            this.propY.TabIndex = 1;
            // 
            // propX
            // 
            this.propX.Location = new System.Drawing.Point(6, 48);
            this.propX.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.propX.Minimum = new decimal(new int[] {
            9999,
            0,
            0,
            -2147483648});
            this.propX.Name = "propX";
            this.propX.Size = new System.Drawing.Size(57, 20);
            this.propX.TabIndex = 0;
            // 
            // AddCommand
            // 
            this.AddCommand.Location = new System.Drawing.Point(270, 130);
            this.AddCommand.Name = "AddCommand";
            this.AddCommand.Size = new System.Drawing.Size(156, 23);
            this.AddCommand.TabIndex = 4;
            this.AddCommand.Text = "Commit";
            this.AddCommand.UseVisualStyleBackColor = true;
            this.AddCommand.Click += new System.EventHandler(this.AddCommand_Click);
            // 
            // AddBigPropWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 160);
            this.ControlBox = false;
            this.Controls.Add(this.AddCommand);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddBigPropWindow";
            this.Text = "AddBigPropWindow";
            this.Load += new System.EventHandler(this.AddBigPropWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bigPropImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.propY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.propX)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox bigPropImg;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown propY;
        private System.Windows.Forms.NumericUpDown propX;
        private System.Windows.Forms.Button AddCommand;
    }
}