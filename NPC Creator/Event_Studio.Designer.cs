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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Event_Studio));
            this.eventFileData = new System.Windows.Forms.ListBox();
            this.newEvent = new System.Windows.Forms.Button();
            this.saveEventFile = new System.Windows.Forms.Button();
            this.EditEvent = new System.Windows.Forms.Button();
            this.PasteEvent = new System.Windows.Forms.Button();
            this.LoadFile = new System.Windows.Forms.Button();
            this.LoadGameJson = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
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
            this.saveEventFile.Location = new System.Drawing.Point(632, 384);
            this.saveEventFile.Name = "saveEventFile";
            this.saveEventFile.Size = new System.Drawing.Size(156, 23);
            this.saveEventFile.TabIndex = 2;
            this.saveEventFile.Text = "Save Event File";
            this.saveEventFile.UseVisualStyleBackColor = true;
            this.saveEventFile.Click += new System.EventHandler(this.saveEventFile_Click);
            // 
            // EditEvent
            // 
            this.EditEvent.Location = new System.Drawing.Point(174, 384);
            this.EditEvent.Name = "EditEvent";
            this.EditEvent.Size = new System.Drawing.Size(156, 23);
            this.EditEvent.TabIndex = 3;
            this.EditEvent.Text = "Edit Event";
            this.EditEvent.UseVisualStyleBackColor = true;
            this.EditEvent.Click += new System.EventHandler(this.EditEvent_Click);
            // 
            // PasteEvent
            // 
            this.PasteEvent.Location = new System.Drawing.Point(470, 384);
            this.PasteEvent.Name = "PasteEvent";
            this.PasteEvent.Size = new System.Drawing.Size(156, 23);
            this.PasteEvent.TabIndex = 4;
            this.PasteEvent.Text = "Paste Event";
            this.PasteEvent.UseVisualStyleBackColor = true;
            this.PasteEvent.Click += new System.EventHandler(this.PasteEvent_Click);
            // 
            // LoadFile
            // 
            this.LoadFile.Location = new System.Drawing.Point(336, 384);
            this.LoadFile.Name = "LoadFile";
            this.LoadFile.Size = new System.Drawing.Size(128, 23);
            this.LoadFile.TabIndex = 5;
            this.LoadFile.Text = "Load Event.json";
            this.LoadFile.UseVisualStyleBackColor = true;
            this.LoadFile.Click += new System.EventHandler(this.LoadFile_Click);
            // 
            // LoadGameJson
            // 
            this.LoadGameJson.Location = new System.Drawing.Point(336, 415);
            this.LoadGameJson.Name = "LoadGameJson";
            this.LoadGameJson.Size = new System.Drawing.Size(128, 23);
            this.LoadGameJson.TabIndex = 6;
            this.LoadGameJson.Text = "Load Json from Game";
            this.LoadGameJson.UseVisualStyleBackColor = true;
            this.LoadGameJson.Click += new System.EventHandler(this.LoadGameJson_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(470, 413);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Copy Event to Clipboard";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Event_Studio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LoadGameJson);
            this.Controls.Add(this.LoadFile);
            this.Controls.Add(this.PasteEvent);
            this.Controls.Add(this.EditEvent);
            this.Controls.Add(this.saveEventFile);
            this.Controls.Add(this.newEvent);
            this.Controls.Add(this.eventFileData);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Event_Studio";
            this.Text = "Event_Studio";
            this.Load += new System.EventHandler(this.Event_Studio_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox eventFileData;
        private System.Windows.Forms.Button newEvent;
        private System.Windows.Forms.Button saveEventFile;
        private System.Windows.Forms.Button EditEvent;
        private System.Windows.Forms.Button PasteEvent;
        private System.Windows.Forms.Button LoadFile;
        private System.Windows.Forms.Button LoadGameJson;
        private System.Windows.Forms.Button button1;
    }
}