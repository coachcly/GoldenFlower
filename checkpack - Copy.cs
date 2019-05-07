using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoldenFlower
{
    public partial class fCheckPack : Form
    {
        public fCheckPack()
        {
            InitializeComponent();
        }

        private void CheckPacketToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PictureBoxvendor_Click(object sender, EventArgs e)
        {
           
        }

        private void Btn1Generate_Click(object sender, EventArgs e)
        {
            Zen.Barcode.CodeQrBarcodeDraw brcode = Zen.Barcode.BarcodeDrawFactory.CodeQr;
            pictureBoxvendor.Image = brcode.Draw(txtVendor.Text,15);
            pictureBoxcheck.Image = brcode.Draw(txtcheck.Text, 30);
            pictureBoxfiscal.Image = brcode.Draw(txtFiscalY.Text, 30);
        }

        private void FCheckPack_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Label1_Click(object sender, EventArgs e)
        {
           
        }

        private void FCheckPack_Load(object sender, EventArgs e)
        {

        }
    }
}
