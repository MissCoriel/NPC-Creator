namespace NPC_Creator
{
    partial class EditSchedule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditSchedule));
            this.label1 = new System.Windows.Forms.Label();
            this.editLine = new System.Windows.Forms.TextBox();
            this.updateList = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Edit Dialogue";
            // 
            // editLine
            // 
            this.editLine.Location = new System.Drawing.Point(12, 52);
            this.editLine.Name = "editLine";
            this.editLine.Size = new System.Drawing.Size(1236, 20);
            this.editLine.TabIndex = 2;
            // 
            // updateList
            // 
            this.updateList.Location = new System.Drawing.Point(66, 100);
            this.updateList.Name = "updateList";
            this.updateList.Size = new System.Drawing.Size(108, 23);
            this.updateList.TabIndex = 3;
            this.updateList.Text = "Commit Change";
            this.updateList.UseVisualStyleBackColor = true;
            this.updateList.Click += new System.EventHandler(this.updateList_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(1045, 111);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 4;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // EditSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1273, 157);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.updateList);
            this.Controls.Add(this.editLine);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditSchedule";
            this.Text = "Edit Schedule";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox editLine;
        private System.Windows.Forms.Button updateList;
        private System.Windows.Forms.Button cancel;
    }
}