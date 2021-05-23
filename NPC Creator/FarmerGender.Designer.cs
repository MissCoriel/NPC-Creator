namespace NPC_Creator
{
    partial class FarmerGender
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
            this.AddMale = new System.Windows.Forms.Button();
            this.AddFemale = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Gender";
            // 
            // AddMale
            // 
            this.AddMale.Location = new System.Drawing.Point(12, 41);
            this.AddMale.Name = "AddMale";
            this.AddMale.Size = new System.Drawing.Size(75, 23);
            this.AddMale.TabIndex = 1;
            this.AddMale.Text = "Male";
            this.AddMale.UseVisualStyleBackColor = true;
            this.AddMale.Click += new System.EventHandler(this.AddMale_Click);
            // 
            // AddFemale
            // 
            this.AddFemale.Location = new System.Drawing.Point(113, 41);
            this.AddFemale.Name = "AddFemale";
            this.AddFemale.Size = new System.Drawing.Size(75, 23);
            this.AddFemale.TabIndex = 2;
            this.AddFemale.Text = "Female";
            this.AddFemale.UseVisualStyleBackColor = true;
            this.AddFemale.Click += new System.EventHandler(this.AddFemale_Click);
            // 
            // FarmerGender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(197, 89);
            this.ControlBox = false;
            this.Controls.Add(this.AddFemale);
            this.Controls.Add(this.AddMale);
            this.Controls.Add(this.label1);
            this.Name = "FarmerGender";
            this.Text = "FarmerGender";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddMale;
        private System.Windows.Forms.Button AddFemale;
    }
}