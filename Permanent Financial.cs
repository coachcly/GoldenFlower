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
    public partial class PFinancial : Form
    {
        public PFinancial()
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
            pictureBoxfiscal.Image = brcode.Draw(comboBoxPFFis.Text,3 ,3);
            pictureBoxDocType.Image = brcode.Draw(comboDocType.Text, 3, 3);
            UFdoc.Image = brcode.Draw(comboBoxSelect.Text + "_" + lblPfinancial.Text, 1, 1);


        }

        private void PFinancial_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void PFinancial_Load(object sender, EventArgs e)
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
            e.Graphics.DrawString("Form Info:  " + lblPfinancial.Text + " " + comboBoxSelect.Text, new Font("Calibri", 14, FontStyle.Bold), Brushes.Black, new PointF(500,45));
            e.Graphics.DrawImage(UFdoc.Image, new PointF(750,75));

            e.Graphics.DrawString("Fiscal Year: " + comboBoxPFFis.Text, new Font("Calibri", 14, FontStyle.Bold), Brushes.Black, new PointF(300, 275));
            e.Graphics.DrawImage(pictureBoxfiscal.Image, new PointF(350,325));

            e.Graphics.DrawString("Doc Type: " + comboDocType.Text, new Font("Calibri", 14, FontStyle.Bold), Brushes.Black, new PointF(300, 550));
            e.Graphics.DrawImage(pictureBoxDocType.Image, new PointF(350,600));
        }

        private void BtnPrint_Click(object sender, EventArgs e)
            
        {
            if (string.IsNullOrEmpty(comboBoxPFFis.Text))
            {

                comboBoxPFFis.Focus();
                errorProvider1.SetError(comboBoxPFFis, "Please Enter Vendor Name");
            }

            if (string.IsNullOrEmpty(comboDocType.Text))
            {
                comboDocType.Focus();
                errorProvider1.SetError(comboDocType, "Please Enter Check Number");
            }

            if (string.IsNullOrEmpty(comboBoxPFFis.Text))
            {

                comboBoxPFFis.Focus();
                errorProvider1.SetError(comboBoxPFFis, "Please Enter Year");
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
                    comboBoxPFFis.DataSource = Vendor.Tables[0];
                    comboBoxPFFis.DisplayMember = "Fiscal Year";
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

        private void ComboDocType_MouseClick(object sender, MouseEventArgs e)
        {
            {
                try
                {
                    System.Data.OleDb.OleDbConnection MyConnection;
                    System.Data.DataSet PF;
                    System.Data.OleDb.OleDbDataAdapter MyCommand;
                    MyConnection = new System.Data.OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source='C:\\Tables\\Vendors.xls'; Extended Properties = Excel 8.0");
                    MyCommand = new System.Data.OleDb.OleDbDataAdapter("select * from [Doc Type List$]", MyConnection);
                    PF = new System.Data.DataSet();
                    MyCommand.Fill(PF);
                    comboDocType.DataSource = PF.Tables[0];
                    comboDocType.DisplayMember = "Perm Financial";
                    MyConnection.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void PersonnelRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Personnel PNN = new Personnel();
            PNN.ShowDialog();
        }

        private void StudentRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Student STU = new Student();
            STU.ShowDialog();
        }
    }
}