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
    public partial class fCheckPack : Form
    {
        public fCheckPack()
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

        private void PictureBoxvendor_Click(object sender, EventArgs e)
        {

        }

        private void Btn1Generate_Click(object sender, EventArgs e)
        {
            //Generating Barcode
            Zen.Barcode.CodeQrBarcodeDraw brcode = Zen.Barcode.BarcodeDrawFactory.CodeQr;
            pictureBoxvendor.Image = brcode.Draw(comboBoxVendor.Text ,3 ,3);
            pictureBoxcheck.Image = brcode.Draw(txtcheck.Text,3 ,3);
            pictureBoxfiscal.Image = brcode.Draw(comboBox1year.Text,3 ,3);
            UFdoc.Image = brcode.Draw(comboBoxSelect.Text + "_" + lblcheckpacket.Text, 1, 1);


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
            e.Graphics.DrawString("Form Info:  " + lblcheckpacket.Text + " " + comboBoxSelect.Text, new Font("Calibri", 14, FontStyle.Bold), Brushes.Black, new PointF(500,55));
            e.Graphics.DrawImage(UFdoc.Image, new PointF(750,75));

            e.Graphics.DrawString("Vendor: " + comboBoxVendor.Text, new Font("Calibri", 14, FontStyle.Bold), Brushes.Black, new PointF(300, 275));
            e.Graphics.DrawImage(pictureBoxvendor.Image, new PointF(350,325));

            e.Graphics.DrawString("Check Number: " + txtcheck.Text, new Font("Calibri", 14, FontStyle.Bold), Brushes.Black, new PointF(300, 550));
            e.Graphics.DrawImage(pictureBoxcheck.Image, new PointF(350,600));

            e.Graphics.DrawString("Fiscal Year: " + comboBox1year.Text, new Font("Calibri", 14, FontStyle.Bold), Brushes.Black, new PointF(300, 800));
            e.Graphics.DrawImage(pictureBoxfiscal.Image, new PointF(350, 850));
        }

        private void BtnPrint_Click(object sender, EventArgs e)
            
        {
            if (string.IsNullOrEmpty(comboBoxVendor.Text))
            {

                comboBoxVendor.Focus();
                errorProvider1.SetError(comboBoxVendor, "Please Enter Vendor Name");
            }

            if (string.IsNullOrEmpty(txtcheck.Text))
            {
                txtcheck.Focus();
                errorProvider1.SetError(txtcheck, "Please Enter Check Number");
            }

            if (string.IsNullOrEmpty(comboBox1year.Text))
            {

                comboBox1year.Focus();
                errorProvider1.SetError(comboBox1year, "Please Enter Year");
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
        private void ComboBoxVendor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ComboBoxVendor_MouseClick(object sender, MouseEventArgs e)
        {
            {
                try
                {
                    System.Data.OleDb.OleDbConnection MyConnection;
                    System.Data.DataSet Vendor;
                    System.Data.OleDb.OleDbDataAdapter MyCommand;
                    MyConnection = new System.Data.OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source='C:\\Tables\\Vendors.xls'; Extended Properties = Excel 8.0");
                    MyCommand = new System.Data.OleDb.OleDbDataAdapter("select * from [Vendor List$]", MyConnection);
                    Vendor = new System.Data.DataSet();
                    MyCommand.Fill(Vendor);
                    comboBoxVendor.DataSource = Vendor.Tables[0];
                    comboBoxVendor.DisplayMember = "Vendors";
                    MyConnection.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }

        }

        private void ComboBoxFiscal_MouseClick(object sender, MouseEventArgs e)
        {
            {
                try
                {
                    System.Data.OleDb.OleDbConnection MyConnection;
                    System.Data.DataSet Vendor;
                    System.Data.OleDb.OleDbDataAdapter MyCommand;
                    MyConnection = new System.Data.OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source='C:\\Tables\\Vendors.xls'; Extended Properties = Excel 8.0");
                    MyCommand = new System.Data.OleDb.OleDbDataAdapter("select * from [Fiscal List$]", MyConnection);
                    Vendor = new System.Data.DataSet();
                    MyCommand.Fill(Vendor);
                    comboBox1year.DataSource = Vendor.Tables[0];
                    comboBox1year.DisplayMember = "Fiscal Year";
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

        private void Txtcheck_KeyPress(object sender, KeyPressEventArgs e)
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