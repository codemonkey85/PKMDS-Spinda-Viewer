namespace PKMDS_Spinda_Viewer_WinForms;

partial class MainForm
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
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
            this.msMain.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.msMain.Location = new System.Drawing.Point(0, 0);
            this.msMain.Name = "msMain";
            this.msMain.Padding = new System.Windows.Forms.Padding(13, 5, 0, 5);
            this.msMain.Size = new System.Drawing.Size(610, 46);
            this.msMain.TabIndex = 0;
            this.msMain.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importToolStripMenuItem,
            this.exportToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(71, 36);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.importToolStripMenuItem.Text = "Import...";
            this.importToolStripMenuItem.Click += new System.EventHandler(this.importToolStripMenuItem_Click);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.exportToolStripMenuItem.Text = "Export...";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
            // 
            // numPID
            // 
            this.numPID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numPID.Location = new System.Drawing.Point(93, 347);
            this.numPID.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.numPID.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.numPID.Name = "numPID";
            this.numPID.Size = new System.Drawing.Size(403, 39);
            this.numPID.TabIndex = 2;
            this.numPID.ValueChanged += new System.EventHandler(this.numPID_ValueChanged);
            // 
            // lblPID
            // 
            this.lblPID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPID.Location = new System.Drawing.Point(15, 349);
            this.lblPID.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPID.Name = "lblPID";
            this.lblPID.Size = new System.Drawing.Size(66, 41);
            this.lblPID.TabIndex = 1;
            this.lblPID.Text = "PID";
            this.lblPID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbSpriteNormal
            // 
            this.pbSpriteNormal.Location = new System.Drawing.Point(15, 53);
            this.pbSpriteNormal.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.pbSpriteNormal.Name = "pbSpriteNormal";
            this.pbSpriteNormal.Size = new System.Drawing.Size(240, 240);
            this.pbSpriteNormal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSpriteNormal.TabIndex = 4;
            this.pbSpriteNormal.TabStop = false;
            // 
            // chkHex
            // 
            this.chkHex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.chkHex.AutoSize = true;
            this.chkHex.Location = new System.Drawing.Point(508, 348);
            this.chkHex.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.chkHex.Name = "chkHex";
            this.chkHex.Size = new System.Drawing.Size(87, 36);
            this.chkHex.TabIndex = 3;
            this.chkHex.Text = "Hex";
            this.chkHex.UseVisualStyleBackColor = true;
            this.chkHex.CheckedChanged += new System.EventHandler(this.chkHex_CheckedChanged);
            // 
            // pbSpriteShiny
            // 
            this.pbSpriteShiny.Location = new System.Drawing.Point(355, 53);
            this.pbSpriteShiny.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.pbSpriteShiny.Name = "pbSpriteShiny";
            this.pbSpriteShiny.Size = new System.Drawing.Size(240, 240);
            this.pbSpriteShiny.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSpriteShiny.TabIndex = 6;
            this.pbSpriteShiny.TabStop = false;
            // 
            // btnRandom
            // 
            this.btnRandom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRandom.Location = new System.Drawing.Point(15, 400);
            this.btnRandom.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(580, 57);
            this.btnRandom.TabIndex = 4;
            this.btnRandom.Text = "Random!";
            this.btnRandom.UseVisualStyleBackColor = true;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // MainForm
            // 
            this.AcceptButton = this.btnRandom;
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 473);
            this.Controls.Add(this.btnRandom);
            this.Controls.Add(this.pbSpriteShiny);
            this.Controls.Add(this.chkHex);
            this.Controls.Add(this.pbSpriteNormal);
            this.Controls.Add(this.lblPID);
            this.Controls.Add(this.numPID);
            this.Controls.Add(this.msMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.msMain;
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.MaximizeBox = false;
            this.Name = "MainForm";
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
