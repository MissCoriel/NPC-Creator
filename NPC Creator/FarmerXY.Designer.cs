namespace NPC_Creator
{
    partial class FarmerXY
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
            this.farmerX = new System.Windows.Forms.NumericUpDown();
            this.farmerY = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.fileList = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.LoadFile = new System.Windows.Forms.Button();
            this.AddCommand = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.farmerX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.farmerY)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Farmer\'s Position";
            // 
            // farmerX
            // 
            this.farmerX.Location = new System.Drawing.Point(15, 34);
            this.farmerX.Name = "farmerX";
            this.farmerX.Size = new System.Drawing.Size(47, 20);
            this.farmerX.TabIndex = 1;
            // 
            // farmerY
            // 
            this.farmerY.Location = new System.Drawing.Point(103, 34);
            this.farmerY.Name = "farmerY";
            this.farmerY.Size = new System.Drawing.Size(47, 20);
            this.farmerY.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "X";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(156, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Y";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LoadFile);
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Controls.Add(this.fileList);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(159, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(364, 151);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Positioner Coords - Not Yet Implemented";
            // 
            // fileList
            // 
            this.fileList.FormattingEnabled = true;
            this.fileList.Location = new System.Drawing.Point(6, 40);
            this.fileList.Name = "fileList";
            this.fileList.Size = new System.Drawing.Size(121, 21);
            this.fileList.TabIndex = 0;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(203, 40);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 1;
            // 
            // LoadFile
            // 
            this.LoadFile.Location = new System.Drawing.Point(133, 40);
            this.LoadFile.Name = "LoadFile";
            this.LoadFile.Size = new System.Drawing.Size(64, 23);
            this.LoadFile.TabIndex = 2;
            this.LoadFile.Text = "Load";
            this.LoadFile.UseVisualStyleBackColor = true;
            // 
            // AddCommand
            // 
            this.AddCommand.Location = new System.Drawing.Point(40, 81);
            this.AddCommand.Name = "AddCommand";
            this.AddCommand.Size = new System.Drawing.Size(75, 23);
            this.AddCommand.TabIndex = 3;
            this.AddCommand.Text = "Commit";
            this.AddCommand.UseVisualStyleBackColor = true;
            this.AddCommand.Click += new System.EventHandler(this.AddCommand_Click);
            // 
            // FarmerXY
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 176);
            this.ControlBox = false;
            this.Controls.Add(this.AddCommand);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.farmerY);
            this.Controls.Add(this.farmerX);
            this.Controls.Add(this.label1);
            this.Name = "FarmerXY";
            this.Text = "FarmerXY";
            ((System.ComponentModel.ISupportInitialize)(this.farmerX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.farmerY)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown farmerX;
        private System.Windows.Forms.NumericUpDown farmerY;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button LoadFile;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ComboBox fileList;
        private System.Windows.Forms.Button AddCommand;
    }
}