namespace NPC_Creator
{
    partial class PortraitView
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
            this.portraitSheet = new System.Windows.Forms.PictureBox();
            this.closeView = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.portraitSheet)).BeginInit();
            this.SuspendLayout();
            // 
            // portraitSheet
            // 
            this.portraitSheet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.portraitSheet.Location = new System.Drawing.Point(12, 12);
            this.portraitSheet.Name = "portraitSheet";
            this.portraitSheet.Size = new System.Drawing.Size(512, 768);
            this.portraitSheet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.portraitSheet.TabIndex = 0;
            this.portraitSheet.TabStop = false;
            // 
            // closeView
            // 
            this.closeView.Location = new System.Drawing.Point(215, 823);
            this.closeView.Name = "closeView";
            this.closeView.Size = new System.Drawing.Size(75, 23);
            this.closeView.TabIndex = 1;
            this.closeView.Text = "Confirm";
            this.closeView.UseVisualStyleBackColor = true;
            this.closeView.Click += new System.EventHandler(this.CloseView_Click);
            // 
            // PortraitView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 894);
            this.Controls.Add(this.closeView);
            this.Controls.Add(this.portraitSheet);
            this.Name = "PortraitView";
            this.Text = "Portrait View";
            this.Load += new System.EventHandler(this.PortraitView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.portraitSheet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox portraitSheet;
        private System.Windows.Forms.Button closeView;
    }
}