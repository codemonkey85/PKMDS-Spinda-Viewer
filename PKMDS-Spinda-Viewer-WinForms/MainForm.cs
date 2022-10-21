using PKMDS_CS;

namespace PKMDS_Spinda_Viewer_WinForms;

public partial class MainForm : Form
{
    public MainForm() => InitializeComponent();

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
        var r = new Random(DateTime.Now.Millisecond);
        var bytes = new byte[4];
        r.NextBytes(bytes);
        return BitConverter.ToUInt32(bytes);
    }

    private void btnRandom_Click(object sender, EventArgs e) => numPID.Value = GetRandom();

    private void frmMain_Load(object sender, EventArgs e)
    {
        MinimumSize = Size;
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
