using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 ****************************************************************
 * Must Select Generate before print or program will Crash
 * //pictureBoxvendor.Image = brcode.Draw(txtVendor.Text + "_" + txtcheck.Text ,3 ,3);
 * 
 * 
 * **************************************************************
 */

namespace GoldenFlower

{
    public partial class Personnel : Form
    {
        public Personnel()
        {
            InitializeComponent();
            //Zen.Barcode.CodeQrBarcodeDraw brcode = Zen.Barcode.BarcodeDrawFactory.CodeQr;
            
        }

        private void CheckPacketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            fCheckPack cpack = new fCheckPack();
            cpack.ShowDialog();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Btn1Generate_Click(object sender, EventArgs e)
        {
            //Generating Barcode
            Zen.Barcode.CodeQrBarcodeDraw brcode = Zen.Barcode.BarcodeDrawFactory.CodeQr;
            pictureBoxBRC.Image = brcode.Draw(txtLast.Text + "_" + txtFirst.Text + "_" + txtHireY.Text + "_" + txtTY, 5, 5);
            UFdoc.Image = brcode.Draw(comboBoxSelect.Text + "_" + lblPersonnel.Text, 1, 1);


        }

        private void Personnel_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Personnel_Load(object sender, EventArgs e)
        {
            
        }

        private void BankCheckPacketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
             this.Hide();
            BankRec brec = new BankRec();
            brec.ShowDialog();
   
        }

        private void PictureBoxcheck_Click(object sender, EventArgs e)
        {

        }

        private void PrintDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            

            //Creating Logo to PDF
            Bitmap bmp = Properties.Resources.SPlogo;
            Image newImage = bmp;
            e.Graphics.DrawImage(newImage, 25, 25, newImage.Width, newImage.Height);

            //Creating Barcode to PDF
            //Left Right then Up down
            e.Graphics.DrawString("Form Info:  " + lblPersonnel.Text + " " + comboBoxSelect.Text, new Font("Calibri", 14, FontStyle.Bold), Brushes.Black, new PointF(500,45));
            e.Graphics.DrawImage(UFdoc.Image, new PointF(750,75));

            e.Graphics.DrawString("Last Name:" +" "+ txtLast.Text, new Font("Calibri", 14, FontStyle.Bold), Brushes.Black, new PointF(200, 275));
            e.Graphics.DrawString("Hire Year:" +" "+ txtHireY.Text, new Font("Calibri", 14, FontStyle.Bold), Brushes.Black, new PointF(200, 325));

            e.Graphics.DrawString("First Name:" + " " + txtFirst.Text, new Font("Calibri", 14, FontStyle.Bold), Brushes.Black, new PointF(500, 275));
            e.Graphics.DrawString("Term Year:" +" "+ txtTY.Text, new Font("Calibri", 14, FontStyle.Bold), Brushes.Black, new PointF(500, 325));


            e.Graphics.DrawImage(pictureBoxBRC.Image, new PointF(300,400));
        }

        private void BtnPrint_Click(object sender, EventArgs e)
            
        {
            if (string.IsNullOrEmpty(txtLast.Text))
            {

                txtLast.Focus();
                errorProvider1.SetError(txtLast, "Please Enter Last Name");
            }

            if (string.IsNullOrEmpty(txtFirst.Text))
            {
                txtFirst.Focus();
                errorProvider1.SetError(txtFirst, "Please Enter First Name");
            }

            if (string.IsNullOrEmpty(txtHireY.Text))
            {

                txtHireY.Focus();
                errorProvider1.SetError(txtHireY, "Please Enter Year");
            }

            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
                printDocument1.Print();

        }

        private void PrintPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void ComboBox1year_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Lblcheckpacket_Click(object sender, EventArgs e)
        {

        }

        private void BankRECToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            BankRec brec = new BankRec();
            brec.ShowDialog();
        }

        private void CheckPacketToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            fCheckPack fpack = new fCheckPack();
            fpack.ShowDialog();
        }

        private void ExitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PayrollAndHRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            PayrollHR pHR = new PayrollHR();
            pHR.ShowDialog();
        }

        private void Lblvendor_Click(object sender, EventArgs e)
        {

        }

        private void ComboBoxSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void SacramentalRecoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //testf test = new testf();
            //test.ShowDialog();
        }

        private void ComboBoxVendor_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void ComboBoxFiscal_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void PermanentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            PFinancial PF = new PFinancial();
            PF.ShowDialog();
        }

            private void ComboDocType_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void TxtLast_TextChanged(object sender, EventArgs e)
        {

        }

        private void PictureBoxBRC_Click(object sender, EventArgs e)
        {

        }

        private void PersonnelRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Personnel PNN = new Personnel();
            PNN.ShowDialog();
        }

        private void TxtLast_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void TxtFirst_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void TxtHireY_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtHireY_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void TxtTY_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void StudentRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Student SR = new Student();
            SR.ShowDialog();
        }
    }
}