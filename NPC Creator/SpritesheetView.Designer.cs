namespace NPC_Creator
{
    partial class SpritesheetView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SpritesheetView));
            this.spriteSheet = new System.Windows.Forms.PictureBox();
            this.closeWindow = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.spriteSheet)).BeginInit();
            this.SuspendLayout();
            // 
            // spriteSheet
            // 
            this.spriteSheet.Location = new System.Drawing.Point(35, 12);
            this.spriteSheet.Name = "spriteSheet";
            this.spriteSheet.Size = new System.Drawing.Size(256, 640);
            this.spriteSheet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.spriteSheet.TabIndex = 0;
            this.spriteSheet.TabStop = false;
            // 
            // closeWindow
            // 
            this.closeWindow.Location = new System.Drawing.Point(113, 678);
            this.closeWindow.Name = "closeWindow";
            this.closeWindow.Size = new System.Drawing.Size(75, 23);
            this.closeWindow.TabIndex = 1;
            this.closeWindow.Text = "Confirm";
            this.closeWindow.UseVisualStyleBackColor = true;
            this.closeWindow.Click += new System.EventHandler(this.CloseWindow_Click);
            // 
            // SpritesheetView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(327, 730);
            this.Controls.Add(this.closeWindow);
            this.Controls.Add(this.spriteSheet);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SpritesheetView";
            this.Text = "Spritesheet View";
            this.Load += new System.EventHandler(this.SpritesheetView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spriteSheet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox spriteSheet;
        private System.Windows.Forms.Button closeWindow;
    }
}