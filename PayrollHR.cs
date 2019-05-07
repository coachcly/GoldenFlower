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
 * 
 * 
 * 
 * **************************************************************
 */

namespace GoldenFlower

{
    public partial class PayrollHR : Form
    {
        public PayrollHR()
        {
            InitializeComponent();
            //Zen.Barcode.CodeQrBarcodeDraw brcode = Zen.Barcode.BarcodeDrawFactory.CodeQr;
            //UFdoc.Image = brcode.Draw(lblRecs.Text, 1,1);
        }

        private void CheckPacketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            PayrollHR cpack = new PayrollHR();
            cpack.ShowDialog();
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
            pictureBoxLast.Image = brcode.Draw(txtLast.Text, 3,3);
            pictureBoxDT.Image = brcode.Draw(cmbdocType.Text, 3,3);
            pictureBoxFirst.Image = brcode.Draw(txtFN.Text, 3,3);
            pictureBoxDOB.Image = brcode.Draw(DOBpick.Text, 3, 3);
            UFdoc.Image = brcode.Draw(comboBoxSelect.Text + "_" + lblRecs.Text, 1, 1);

        }

        private void PayrollHR_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void PayrollHR_Load(object sender, EventArgs e)
        {

        }

        private void BankCheckPacketToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void PictureBoxcheck_Click(object sender, EventArgs e)
        {

        }

        private void PrintDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //Left Right then Up down
            Bitmap bmp = Properties.Resources.SPlogo;
            Image newImage = bmp;
            e.Graphics.DrawImage(newImage, 25, 25, newImage.Width, newImage.Height);
            e.Graphics.DrawString("Form Type:  " + lblRecs.Text, new Font("Calibri", 14, FontStyle.Bold), Brushes.Black, new PointF(500,55));
            e.Graphics.DrawImage(UFdoc.Image, new PointF(750,75));

            e.Graphics.DrawString("Last Name: " + txtLast.Text, new Font("Calibri", 14, FontStyle.Bold), Brushes.Black, new PointF(150,275));
            e.Graphics.DrawImage(pictureBoxLast.Image, new PointF(150,325));

            e.Graphics.DrawString("First Name: " + txtFN.Text, new Font("Calibri", 14, FontStyle.Bold), Brushes.Black, new PointF(375, 275));
            e.Graphics.DrawImage(pictureBoxFirst.Image, new PointF(375, 325));

            e.Graphics.DrawString("Doc Type: " + cmbdocType.Text, new Font("Calibri", 14, FontStyle.Bold), Brushes.Black, new PointF(375,550));
            e.Graphics.DrawImage(pictureBoxDT.Image, new PointF(375,600));

            e.Graphics.DrawString("" + DOBpick.Text, new Font("Calibri", 14, FontStyle.Bold), Brushes.Black, new PointF(375,800));
            e.Graphics.DrawImage(pictureBoxDOB.Image, new PointF(375, 850));
        }

        private void BtnPrint_Click(object sender, EventArgs e)
            
        {
            if (string.IsNullOrEmpty(txtLast.Text))
            {

                txtLast.Focus();
                errorProvider1.SetError(txtLast, "Please Enter Last Name");
            }

            if (string.IsNullOrEmpty(cmbdocType.Text))
            {
                cmbdocType.Focus();
                errorProvider1.SetError(cmbdocType, "Please Enter Doc Type");
            }

            if (string.IsNullOrEmpty(DOBpick.Text))
            {

                DOBpick.Focus();
                errorProvider1.SetError(DOBpick, "Please Enter DOB");
            }
            if (string.IsNullOrEmpty(txtFN.Text))
            {

                txtFN.Focus();
                errorProvider1.SetError(txtFN, "Please Enter First Name");
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

        private void CheckPacketToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            fCheckPack fpack = new fCheckPack();
            fpack.ShowDialog();
        }

        private void PayrollHRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            BankRec brec = new BankRec();
            brec.ShowDialog();
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

        private void ComboBoxSelect_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CmbdocType_MouseClick(object sender, MouseEventArgs e)
        {
            {
                try
                {
                    System.Data.OleDb.OleDbConnection MyConnection;
                    System.Data.DataSet BA;
                    System.Data.OleDb.OleDbDataAdapter MyCommand;
                    MyConnection = new System.Data.OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source='C:\\Tables\\Vendors.xls'; Extended Properties = Excel 8.0");
                    MyCommand = new System.Data.OleDb.OleDbDataAdapter("select * from [Payroll List$]", MyConnection);
                    BA = new System.Data.DataSet();
                    MyCommand.Fill(BA);
                    cmbdocType.DataSource = BA.Tables[0];
                    cmbdocType.DisplayMember = "Payroll";
                    MyConnection.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void PermanentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            PFinancial PF = new PFinancial();
            PF.ShowDialog();
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

        private void CmbdocType_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (Char.IsDigit(ch) && ch != 8 && ch != 46)
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