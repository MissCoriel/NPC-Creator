namespace NPC_Creator
{
    partial class ChangeAmbientLight
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
            this.blueVal = new System.Windows.Forms.Label();
            this.greenVal = new System.Windows.Forms.Label();
            this.redVal = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.blueBar = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.greenBar = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.redBar = new System.Windows.Forms.TrackBar();
            this.button1 = new System.Windows.Forms.Button();
            this.colorSample = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.blueBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorSample)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.blueVal);
            this.groupBox1.Controls.Add(this.greenVal);
            this.groupBox1.Controls.Add(this.redVal);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.blueBar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.greenBar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.redBar);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(729, 188);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Adjust Sliders";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // blueVal
            // 
            this.blueVal.AutoSize = true;
            this.blueVal.Location = new System.Drawing.Point(691, 132);
            this.blueVal.Name = "blueVal";
            this.blueVal.Size = new System.Drawing.Size(25, 13);
            this.blueVal.TabIndex = 8;
            this.blueVal.Text = "255";
            // 
            // greenVal
            // 
            this.greenVal.AutoSize = true;
            this.greenVal.Location = new System.Drawing.Point(691, 79);
            this.greenVal.Name = "greenVal";
            this.greenVal.Size = new System.Drawing.Size(25, 13);
            this.greenVal.TabIndex = 7;
            this.greenVal.Text = "255";
            // 
            // redVal
            // 
            this.redVal.AutoSize = true;
            this.redVal.Location = new System.Drawing.Point(691, 28);
            this.redVal.Name = "redVal";
            this.redVal.Size = new System.Drawing.Size(25, 13);
            this.redVal.TabIndex = 6;
            this.redVal.Text = "255";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Blue:";
            // 
            // blueBar
            // 
            this.blueBar.Location = new System.Drawing.Point(53, 132);
            this.blueBar.Maximum = 255;
            this.blueBar.Name = "blueBar";
            this.blueBar.Size = new System.Drawing.Size(621, 45);
            this.blueBar.TabIndex = 4;
            this.blueBar.TickFrequency = 5;
            this.blueBar.Value = 255;
            this.blueBar.Scroll += new System.EventHandler(this.blueBar_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Green:";
            // 
            // greenBar
            // 
            this.greenBar.Location = new System.Drawing.Point(53, 70);
            this.greenBar.Maximum = 255;
            this.greenBar.Name = "greenBar";
            this.greenBar.Size = new System.Drawing.Size(621, 45);
            this.greenBar.TabIndex = 2;
            this.greenBar.TickFrequency = 5;
            this.greenBar.Value = 255;
            this.greenBar.Scroll += new System.EventHandler(this.greenBar_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Red:";
            // 
            // redBar
            // 
            this.redBar.Location = new System.Drawing.Point(53, 19);
            this.redBar.Maximum = 255;
            this.redBar.Name = "redBar";
            this.redBar.Size = new System.Drawing.Size(621, 45);
            this.redBar.TabIndex = 0;
            this.redBar.TickFrequency = 5;
            this.redBar.Value = 255;
            this.redBar.Scroll += new System.EventHandler(this.redBar_Scroll);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(261, 204);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Commit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // colorSample
            // 
            this.colorSample.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.colorSample.Location = new System.Drawing.Point(735, 19);
            this.colorSample.Name = "colorSample";
            this.colorSample.Size = new System.Drawing.Size(147, 147);
            this.colorSample.TabIndex = 2;
            this.colorSample.TabStop = false;
            this.colorSample.Click += new System.EventHandler(this.colorSample_Click);
            // 
            // ChangeAmbientLight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 239);
            this.ControlBox = false;
            this.Controls.Add(this.colorSample);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Name = "ChangeAmbientLight";
            this.Text = "ChangeAmbientLight";
            this.Load += new System.EventHandler(this.ChangeAmbientLight_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.blueBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorSample)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label blueVal;
        private System.Windows.Forms.Label greenVal;
        private System.Windows.Forms.Label redVal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar blueBar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar greenBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar redBar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox colorSample;
    }
}