namespace NPC_Creator
{
    partial class Event_Studio
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
            this.eventFileData = new System.Windows.Forms.ListBox();
            this.newEvent = new System.Windows.Forms.Button();
            this.saveEventFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // eventFileData
            // 
            this.eventFileData.FormattingEnabled = true;
            this.eventFileData.Location = new System.Drawing.Point(12, 12);
            this.eventFileData.Name = "eventFileData";
            this.eventFileData.Size = new System.Drawing.Size(776, 355);
            this.eventFileData.TabIndex = 0;
            // 
            // newEvent
            // 
            this.newEvent.Location = new System.Drawing.Point(12, 384);
            this.newEvent.Name = "newEvent";
            this.newEvent.Size = new System.Drawing.Size(156, 23);
            this.newEvent.TabIndex = 1;
            this.newEvent.Text = "Start New Event";
            this.newEvent.UseVisualStyleBackColor = true;
            this.newEvent.Click += new System.EventHandler(this.newEvent_Click);
            // 
            // saveEventFile
            // 
            this.saveEventFile.Location = new System.Drawing.Point(604, 384);
            this.saveEventFile.Name = "saveEventFile";
            this.saveEventFile.Size = new System.Drawing.Size(173, 23);
            this.saveEventFile.TabIndex = 2;
            this.saveEventFile.Text = "Save Event File";
            this.saveEventFile.UseVisualStyleBackColor = true;
            this.saveEventFile.Click += new System.EventHandler(this.saveEventFile_Click);
            // 
            // Event_Studio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.saveEventFile);
            this.Controls.Add(this.newEvent);
            this.Controls.Add(this.eventFileData);
            this.Name = "Event_Studio";
            this.Text = "Event_Studio";
            this.Load += new System.EventHandler(this.Event_Studio_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox eventFileData;
        private System.Windows.Forms.Button newEvent;
        private System.Windows.Forms.Button saveEventFile;
    }
}