namespace PKMDS_Spinda_Viewer
{
    partial class frmMain
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
            this.msMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.numPID = new System.Windows.Forms.NumericUpDown();
            this.lblPID = new System.Windows.Forms.Label();
            this.pbSpriteNormal = new System.Windows.Forms.PictureBox();
            this.chkHex = new System.Windows.Forms.CheckBox();
            this.pbSpriteShiny = new System.Windows.Forms.PictureBox();
            this.btnRandom = new System.Windows.Forms.Button();
            this.msMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSpriteNormal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSpriteShiny)).BeginInit();
            this.SuspendLayout();
            // 
            // msMain
            // 
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.msMain.Location = new System.Drawing.Point(0, 0);
            this.msMain.Name = "msMain";
            this.msMain.Size = new System.Drawing.Size(324, 24);
            this.msMain.TabIndex = 0;
            this.msMain.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importToolStripMenuItem,
            this.exportToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.importToolStripMenuItem.Text = "Import...";
            this.importToolStripMenuItem.Click += new System.EventHandler(this.importToolStripMenuItem_Click);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exportToolStripMenuItem.Text = "Export...";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
            // 
            // numPID
            // 
            this.numPID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numPID.Location = new System.Drawing.Point(43, 204);
            this.numPID.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.numPID.Name = "numPID";
            this.numPID.Size = new System.Drawing.Size(218, 20);
            this.numPID.TabIndex = 2;
            this.numPID.ValueChanged += new System.EventHandler(this.numPID_ValueChanged);
            // 
            // lblPID
            // 
            this.lblPID.AutoSize = true;
            this.lblPID.Location = new System.Drawing.Point(12, 206);
            this.lblPID.Name = "lblPID";
            this.lblPID.Size = new System.Drawing.Size(25, 13);
            this.lblPID.TabIndex = 1;
            this.lblPID.Text = "PID";
            // 
            // pbSpriteNormal
            // 
            this.pbSpriteNormal.Location = new System.Drawing.Point(12, 27);
            this.pbSpriteNormal.Name = "pbSpriteNormal";
            this.pbSpriteNormal.Size = new System.Drawing.Size(147, 171);
            this.pbSpriteNormal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbSpriteNormal.TabIndex = 4;
            this.pbSpriteNormal.TabStop = false;
            // 
            // chkHex
            // 
            this.chkHex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkHex.AutoSize = true;
            this.chkHex.Location = new System.Drawing.Point(267, 205);
            this.chkHex.Name = "chkHex";
            this.chkHex.Size = new System.Drawing.Size(45, 17);
            this.chkHex.TabIndex = 3;
            this.chkHex.Text = "Hex";
            this.chkHex.UseVisualStyleBackColor = true;
            this.chkHex.CheckedChanged += new System.EventHandler(this.chkHex_CheckedChanged);
            // 
            // pbSpriteShiny
            // 
            this.pbSpriteShiny.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbSpriteShiny.Location = new System.Drawing.Point(165, 27);
            this.pbSpriteShiny.Name = "pbSpriteShiny";
            this.pbSpriteShiny.Size = new System.Drawing.Size(147, 171);
            this.pbSpriteShiny.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbSpriteShiny.TabIndex = 6;
            this.pbSpriteShiny.TabStop = false;
            // 
            // btnRandom
            // 
            this.btnRandom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRandom.Location = new System.Drawing.Point(12, 230);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(300, 23);
            this.btnRandom.TabIndex = 4;
            this.btnRandom.Text = "Random!";
            this.btnRandom.UseVisualStyleBackColor = true;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // frmMain
            // 
            this.AcceptButton = this.btnRandom;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 265);
            this.Controls.Add(this.btnRandom);
            this.Controls.Add(this.pbSpriteShiny);
            this.Controls.Add(this.chkHex);
            this.Controls.Add(this.pbSpriteNormal);
            this.Controls.Add(this.lblPID);
            this.Controls.Add(this.numPID);
            this.Controls.Add(this.msMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.msMain;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "PKMDS Spinda Viewer";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.msMain.ResumeLayout(false);
            this.msMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSpriteNormal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSpriteShiny)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.NumericUpDown numPID;
        private System.Windows.Forms.Label lblPID;
        private System.Windows.Forms.PictureBox pbSpriteNormal;
        private System.Windows.Forms.CheckBox chkHex;
        private System.Windows.Forms.PictureBox pbSpriteShiny;
        private System.Windows.Forms.Button btnRandom;
    }
}

