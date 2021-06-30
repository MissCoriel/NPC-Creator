namespace NPC_Creator
{
    partial class PasteEvent
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
            this.eventRaw = new System.Windows.Forms.TextBox();
            this.Commit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Paste Event in TextBox then Press Commit";
            // 
            // eventRaw
            // 
            this.eventRaw.Location = new System.Drawing.Point(15, 37);
            this.eventRaw.Name = "eventRaw";
            this.eventRaw.Size = new System.Drawing.Size(242, 20);
            this.eventRaw.TabIndex = 1;
            // 
            // Commit
            // 
            this.Commit.Location = new System.Drawing.Point(101, 73);
            this.Commit.Name = "Commit";
            this.Commit.Size = new System.Drawing.Size(75, 23);
            this.Commit.TabIndex = 2;
            this.Commit.Text = "Commit";
            this.Commit.UseVisualStyleBackColor = true;
            this.Commit.Click += new System.EventHandler(this.Commit_Click);
            // 
            // PasteEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 123);
            this.Controls.Add(this.Commit);
            this.Controls.Add(this.eventRaw);
            this.Controls.Add(this.label1);
            this.Name = "PasteEvent";
            this.Text = "PasteEvent";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox eventRaw;
        private System.Windows.Forms.Button Commit;
    }
}