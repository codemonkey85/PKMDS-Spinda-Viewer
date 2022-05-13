using PKMDS_CS;
using System;
using System.Windows.Forms;

namespace PKMDS_Spinda_Viewer
{
    public partial class frmMain : Form
    {
        public frmMain() => InitializeComponent();

        private void numPID_ValueChanged(object sender, EventArgs e) => UpdateSpindaSprite();

        private void chkShiny_CheckedChanged(object sender, EventArgs e) => UpdateSpindaSprite();

        private void UpdateSpindaSprite()
        {
            pbSpriteNormal.Image = PKMDS.GetSpindaSprite((uint)numPID.Value, false);
            pbSpriteShiny.Image = PKMDS.GetSpindaSprite((uint)numPID.Value, true);
        }

        private void chkHex_CheckedChanged(object sender, EventArgs e) => numPID.Hexadecimal = chkHex.Checked;

        private uint GetRandom()
        {
            var rnd = new Random(DateTime.Now.Millisecond);
            var rand = (uint)rnd.Next(int.MinValue, int.MaxValue);
            return rand;
        }

        private void btnRandom_Click(object sender, EventArgs e) => numPID.Value = GetRandom();

        private void frmMain_Load(object sender, EventArgs e)
        {
            msMain.Visible = false;
            numPID.Value = GetRandom();
        }

        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
