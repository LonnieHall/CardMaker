/*******************************************************************************************
** Author: Lonnie Hall
** Created: 11/05/2015
** Last Modified: 11/20/2015
 * Description:    
 *      CardMaker is a tool to quickly create images for cards. Images are
 *      loaded from and saved to the MyPictures folder. A normal size image
 *      as well as mini size image is saved. Border color and font size can
 *      be adjusted. The filename is the Title of the card.
** Requirements: 
 *      (none)
** Notes:
 *      Dimensons of card are: 63mm x 88mm ~ 2.5in x 3.5in ~ 236 x 330 pixels
 *      Dimensions of picture window are: 50.8mm x 38.1mm ~ 2in x 1.5in ~ 191 x 143 pixels
******************************************************************************************/


using System;
using System.Windows.Forms;
using System.Drawing;

namespace CardMaker
{
    public partial class frmGeneric : Form
    {
        public frmGeneric() { InitializeComponent(); resizeAndRelocateTextWindow(); resizeAndRelocateTypeWindow(); }

        private void frmCardMaker_Load(object sender, EventArgs e) { }

        public void resizeAndRelocateTypeWindow(int Width = 190, int Height = 21, int X = 12, int Y = 187)
        {
            txtType.Width = Width;
            txtType.Height = Height;
            Point p = new Point(X, Y);
            txtType.Location = p;
        }

        public void resizeAndRelocateTextWindow(int Width = 190, int Height = 67, int X = 13, int Y = 213)
        {
            txtCardText.Width = Width;
            txtCardText.Height = Height;
            Point p = new Point(X, Y);
            txtCardText.Location = p;               
        }

        public void setType(string Type) { txtType.Text = Type; }

        private void pbCardImage_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            { cmsRightClick.Show(Cursor.Position); }            
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string fileName = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures) + "\\" + txtCardTitle.Text + ".bmp";
            string miniFileName = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures) + "\\" + txtCardTitle.Text + "_Mini.bmp";
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Bitmap bmp = new Bitmap(this.Width, this.Height);            
            this.DrawToBitmap(bmp, new Rectangle(Point.Empty, bmp.Size));            
            bmp.Save(fileName);

            Bitmap miniBmp = new Bitmap(bmp, new Size(bmp.Width / 4, bmp.Height / 4));
            miniBmp.Save(miniFileName);

            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            System.Diagnostics.Process.Start(fileName);            
        } 

        private void imageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ofdImage.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            ofdImage.ShowDialog();
        }               

        private void ofdImage_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            pbCardImage.Image = Image.FromFile(ofdImage.FileName);
            pbCardImage.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void blackToolStripMenuItem_Click(object sender, EventArgs e)
        { this.BackColor = Color.Black; }

        private void whiteToolStripMenuItem_Click(object sender, EventArgs e)
        { this.BackColor = Color.White; }

        private void greyToolStripMenuItem_Click(object sender, EventArgs e)
        { this.BackColor = Color.Gray; }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        { this.BackColor = Color.Blue; }        

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        { this.BackColor = Color.Red; }

        private void yellowToolStripMenuItem_Click(object sender, EventArgs e)
        { this.BackColor = Color.Yellow; }

        private void orangeToolStripMenuItem_Click(object sender, EventArgs e)
        { this.BackColor = Color.Orange; }

        private void purpleToolStripMenuItem_Click(object sender, EventArgs e)
        { this.BackColor = Color.Purple; }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        { this.BackColor = Color.Green; }

        private void shrinkBodyToolStripMenuItem_Click(object sender, EventArgs e)
        { txtCardText.Font = new Font(txtCardText.Font.FontFamily, txtCardText.Font.Size - 1); }

        private void growBodyToolStripMenuItem_Click(object sender, EventArgs e)
        { txtCardText.Font = new Font(txtCardText.Font.FontFamily, txtCardText.Font.Size + 1); }

        private void shrinkTitleToolStripMenuItem_Click(object sender, EventArgs e)
        { txtCardTitle.Font = new Font(txtCardTitle.Font.FontFamily, txtCardTitle.Font.Size - 1); }

        private void growTitleToolStripMenuItem_Click(object sender, EventArgs e)
        { txtCardTitle.Font = new Font(txtCardTitle.Font.FontFamily, txtCardTitle.Font.Size + 1); }
        
        private void txtCardTitle_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1) { frmCharacter frm = new frmCharacter(); frm.Show(); }
            else if (e.KeyCode == Keys.F2) { frmAction frm = new frmAction(); frm.Show(); }
            else if (e.KeyCode == Keys.F3) { frmEffect frm = new frmEffect(); frm.Show(); }
            else if (e.KeyCode == Keys.F4) { frmTrap frm = new frmTrap(); frm.Show(); }
            else if (e.KeyCode == Keys.F5) { frmLocation frm = new frmLocation(); frm.Show(); }
            else if (e.KeyCode == Keys.F6) { frmBase frm = new frmBase(); frm.Show(); }
        }
    }
}