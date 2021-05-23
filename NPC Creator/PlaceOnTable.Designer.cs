namespace NPC_Creator
{
    partial class PlaceOnTable
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
            this.objectFrame = new System.Windows.Forms.NumericUpDown();
            this.springObject = new System.Windows.Forms.PictureBox();
            this.Parameters = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.objectY = new System.Windows.Forms.NumericUpDown();
            this.objectX = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.objectFrame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.springObject)).BeginInit();
            this.Parameters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.objectY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objectX)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.objectFrame);
            this.groupBox1.Controls.Add(this.springObject);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 160);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Object";
            // 
            // objectFrame
            // 
            this.objectFrame.Location = new System.Drawing.Point(146, 58);
            this.objectFrame.Maximum = new decimal(new int[] {
            935,
            0,
            0,
            0});
            this.objectFrame.Name = "objectFrame";
            this.objectFrame.Size = new System.Drawing.Size(87, 20);
            this.objectFrame.TabIndex = 1;
            this.objectFrame.ValueChanged += new System.EventHandler(this.objectFrame_ValueChanged);
            // 
            // springObject
            // 
            this.springObject.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.springObject.Location = new System.Drawing.Point(6, 19);
            this.springObject.Name = "springObject";
            this.springObject.Size = new System.Drawing.Size(128, 128);
            this.springObject.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.springObject.TabIndex = 0;
            this.springObject.TabStop = false;
            // 
            // Parameters
            // 
            this.Parameters.Controls.Add(this.label2);
            this.Parameters.Controls.Add(this.label1);
            this.Parameters.Controls.Add(this.objectY);
            this.Parameters.Controls.Add(this.objectX);
            this.Parameters.Location = new System.Drawing.Point(268, 12);
            this.Parameters.Name = "Parameters";
            this.Parameters.Size = new System.Drawing.Size(124, 113);
            this.Parameters.TabIndex = 3;
            this.Parameters.TabStop = false;
            this.Parameters.Text = "Object Parameters";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Y:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "X:";
            // 
            // objectY
            // 
            this.objectY.Location = new System.Drawing.Point(64, 58);
            this.objectY.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.objectY.Minimum = new decimal(new int[] {
            9999,
            0,
            0,
            -2147483648});
            this.objectY.Name = "objectY";
            this.objectY.Size = new System.Drawing.Size(52, 20);
            this.objectY.TabIndex = 1;
            // 
            // objectX
            // 
            this.objectX.Location = new System.Drawing.Point(6, 58);
            this.objectX.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.objectX.Minimum = new decimal(new int[] {
            9999,
            0,
            0,
            -2147483648});
            this.objectX.Name = "objectX";
            this.objectX.Size = new System.Drawing.Size(52, 20);
            this.objectX.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(268, 136);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Commit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PlaceOnTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 177);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Parameters);
            this.Controls.Add(this.groupBox1);
            this.Name = "PlaceOnTable";
            this.Text = "PlaceOnTable";
            this.Load += new System.EventHandler(this.PlaceOnTable_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.objectFrame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.springObject)).EndInit();
            this.Parameters.ResumeLayout(false);
            this.Parameters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.objectY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objectX)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown objectFrame;
        private System.Windows.Forms.PictureBox springObject;
        private System.Windows.Forms.GroupBox Parameters;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown objectY;
        private System.Windows.Forms.NumericUpDown objectX;
        private System.Windows.Forms.Button button1;
    }
}