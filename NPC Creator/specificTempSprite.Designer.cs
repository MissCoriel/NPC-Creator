﻿namespace NPC_Creator
{
    partial class specificTempSprite
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
            this.spriteList = new System.Windows.Forms.ComboBox();
            this.spriteParams = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose or type name of sprite and extra parameters.";
            // 
            // spriteList
            // 
            this.spriteList.FormattingEnabled = true;
            this.spriteList.Items.AddRange(new object[] {
            "heart"});
            this.spriteList.Location = new System.Drawing.Point(15, 40);
            this.spriteList.Name = "spriteList";
            this.spriteList.Size = new System.Drawing.Size(121, 21);
            this.spriteList.TabIndex = 1;
            // 
            // spriteParams
            // 
            this.spriteParams.Location = new System.Drawing.Point(164, 41);
            this.spriteParams.Name = "spriteParams";
            this.spriteParams.Size = new System.Drawing.Size(100, 20);
            this.spriteParams.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(97, 77);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Commit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // specificTempSprite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 123);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.spriteParams);
            this.Controls.Add(this.spriteList);
            this.Controls.Add(this.label1);
            this.Name = "specificTempSprite";
            this.Text = "specificTempSprite";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox spriteList;
        private System.Windows.Forms.TextBox spriteParams;
        private System.Windows.Forms.Button button1;
    }
}