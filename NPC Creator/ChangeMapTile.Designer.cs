namespace NPC_Creator
{
    partial class ChangeMapTile
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
            this.layerBar = new System.Windows.Forms.TrackBar();
            this.layerLabel = new System.Windows.Forms.Label();
            this.tileX = new System.Windows.Forms.NumericUpDown();
            this.tileY = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tileIndex = new System.Windows.Forms.NumericUpDown();
            this.Commit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.layerBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileIndex)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Set Tile Parameter";
            // 
            // layerBar
            // 
            this.layerBar.LargeChange = 10;
            this.layerBar.Location = new System.Drawing.Point(15, 44);
            this.layerBar.Maximum = 100;
            this.layerBar.Name = "layerBar";
            this.layerBar.Size = new System.Drawing.Size(104, 45);
            this.layerBar.TabIndex = 1;
            this.layerBar.TickFrequency = 10;
            this.layerBar.Scroll += new System.EventHandler(this.layerBar_Scroll);
            // 
            // layerLabel
            // 
            this.layerLabel.AutoSize = true;
            this.layerLabel.Location = new System.Drawing.Point(138, 53);
            this.layerLabel.Name = "layerLabel";
            this.layerLabel.Size = new System.Drawing.Size(45, 13);
            this.layerLabel.TabIndex = 2;
            this.layerLabel.Text = "Layer: 0";
            // 
            // tileX
            // 
            this.tileX.Location = new System.Drawing.Point(35, 111);
            this.tileX.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.tileX.Minimum = new decimal(new int[] {
            9999,
            0,
            0,
            -2147483648});
            this.tileX.Name = "tileX";
            this.tileX.Size = new System.Drawing.Size(64, 20);
            this.tileX.TabIndex = 3;
            // 
            // tileY
            // 
            this.tileY.Location = new System.Drawing.Point(128, 111);
            this.tileY.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.tileY.Minimum = new decimal(new int[] {
            9999,
            0,
            0,
            -2147483648});
            this.tileY.Name = "tileY";
            this.tileY.Size = new System.Drawing.Size(64, 20);
            this.tileY.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "X:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(105, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Y:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Index";
            // 
            // tileIndex
            // 
            this.tileIndex.Location = new System.Drawing.Point(51, 165);
            this.tileIndex.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.tileIndex.Name = "tileIndex";
            this.tileIndex.Size = new System.Drawing.Size(120, 20);
            this.tileIndex.TabIndex = 8;
            // 
            // Commit
            // 
            this.Commit.Location = new System.Drawing.Point(76, 205);
            this.Commit.Name = "Commit";
            this.Commit.Size = new System.Drawing.Size(75, 23);
            this.Commit.TabIndex = 9;
            this.Commit.Text = "Commit";
            this.Commit.UseVisualStyleBackColor = true;
            this.Commit.Click += new System.EventHandler(this.Commit_Click);
            // 
            // ChangeMapTile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(217, 240);
            this.ControlBox = false;
            this.Controls.Add(this.Commit);
            this.Controls.Add(this.tileIndex);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tileY);
            this.Controls.Add(this.tileX);
            this.Controls.Add(this.layerLabel);
            this.Controls.Add(this.layerBar);
            this.Controls.Add(this.label1);
            this.Name = "ChangeMapTile";
            this.Text = "ChangeMapTile";
            ((System.ComponentModel.ISupportInitialize)(this.layerBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileIndex)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar layerBar;
        private System.Windows.Forms.Label layerLabel;
        private System.Windows.Forms.NumericUpDown tileX;
        private System.Windows.Forms.NumericUpDown tileY;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown tileIndex;
        private System.Windows.Forms.Button Commit;
    }
}