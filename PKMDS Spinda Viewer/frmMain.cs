using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PKMDS_CS;
namespace PKMDS_Spinda_Viewer
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        private void numPID_ValueChanged(object sender, EventArgs e)
        {
            UpdateSpindaSprite();
        }
        private void chkShiny_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSpindaSprite();
        }
        private void UpdateSpindaSprite()
        {
            pbSpriteNormal.Image = PKMDS.GetSpindaSprite(((UInt32)(numPID.Value)), false);
            pbSpriteShiny.Image = PKMDS.GetSpindaSprite(((UInt32)(numPID.Value)), true);
        }
        private void chkHex_CheckedChanged(object sender, EventArgs e)
        {
            numPID.Hexadecimal = chkHex.Checked;
        }
        private UInt32 GetRandom()
        {
            UInt32 rand = 0;
            Random rnd = new Random(DateTime.Now.Millisecond);
            rand = (UInt32)rnd.Next(Int32.MinValue, Int32.MaxValue);
            return rand;
        }
        private void btnRandom_Click(object sender, EventArgs e)
        {
            numPID.Value = GetRandom();
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            numPID.Value = GetRandom();
        }
    }
}
