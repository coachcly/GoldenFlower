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
    public partial class BankRec : Form
    {
        public BankRec()
        {
            InitializeComponent();
            
        }

        private void CheckPacketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            BankRec cpack = new BankRec();
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
            pictureBoxacct.Image = brcode.Draw(cmbAcct.Text, 3,3);
            pictureBoxDoc.Image = brcode.Draw(txtDocty.Text, 3,3);
            pictureBoxBRyear.Image = brcode.Draw(cmbBRyear.Text, 3,3);
            UFdoc.Image = brcode.Draw(comboBoxSelect.Text + "_" + lbldoctype.Text, 1, 1);

        }

        private void BankRec_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void BankRec_Load(object sender, EventArgs e)
        {

        }

        private void BankCheckPacketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*
             this.Hide();
            bCheckPack cpack = new bCheckPack();
            cpack.ShowDialog();
            */
        }

        private void PictureBoxcheck_Click(object sender, EventArgs e)
        {

        }

        private void PrintDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bmp = Properties.Resources.SPlogo;
            Image newImage = bmp;
            e.Graphics.DrawImage(newImage, 25, 25, newImage.Width, newImage.Height);
            e.Graphics.DrawString("Form Type:  " + lblRecs.Text, new Font("Calibri", 14, FontStyle.Bold), Brushes.Black, new PointF(500,55));
            e.Graphics.DrawImage(UFdoc.Image, new PointF(750,75));

            e.Graphics.DrawString("Account #: " + cmbAcct.Text, new Font("Calibri", 14, FontStyle.Bold), Brushes.Black, new PointF(300,275));
            e.Graphics.DrawImage(pictureBoxacct.Image, new PointF(350,325));

            e.Graphics.DrawString("Doc Type: " + txtDocty.Text, new Font("Calibri", 14, FontStyle.Bold), Brushes.Black, new PointF(300,550));
            e.Graphics.DrawImage(pictureBoxDoc.Image, new PointF(350,600));

            e.Graphics.DrawString("Fiscal Year: " + cmbBRyear.Text, new Font("Calibri", 14, FontStyle.Bold), Brushes.Black, new PointF(300,800));
            e.Graphics.DrawImage(pictureBoxBRyear.Image, new PointF(350, 850));
        }

        private void BtnPrint_Click(object sender, EventArgs e)
            
        {
            if (string.IsNullOrEmpty(cmbAcct.Text))
            {

                cmbAcct.Focus();
                errorProvider1.SetError(cmbAcct, "Please Enter Account Name");
            }

            if (string.IsNullOrEmpty(txtDocty.Text))
            {
                txtDocty.Focus();
                errorProvider1.SetError(txtDocty, "Please Enter Doc Type Number");
            }

            if (string.IsNullOrEmpty(cmbBRyear.Text))
            {

                cmbBRyear.Focus();
                errorProvider1.SetError(cmbBRyear, "Please Enter Year");
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

        private void BankRECToolStripMenuItem_Click(object sender, EventArgs e)
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
            //test
        }

        private void ComboBoxBRyear_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CmbAcct_MouseClick(object sender, MouseEventArgs e)
        {
            {
                try
                {
                    System.Data.OleDb.OleDbConnection MyConnection;
                    System.Data.DataSet BA;
                    System.Data.OleDb.OleDbDataAdapter MyCommand;
                    MyConnection = new System.Data.OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source='C:\\Tables\\Vendors.xls'; Extended Properties = Excel 8.0");
                    MyCommand = new System.Data.OleDb.OleDbDataAdapter("select * from [Bank Account List$]", MyConnection);
                    BA = new System.Data.DataSet();
                    MyCommand.Fill(BA);
                    cmbAcct.DataSource = BA.Tables[0];
                    cmbAcct.DisplayMember = "Bank Account";
                    MyConnection.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void CmbBRyear_MouseClick(object sender, MouseEventArgs e)
        {
            {
                try
                {
                    System.Data.OleDb.OleDbConnection MyConnection;
                    System.Data.DataSet FY;
                    System.Data.OleDb.OleDbDataAdapter MyCommand;
                    MyConnection = new System.Data.OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source='C:\\Tables\\Vendors.xls'; Extended Properties = Excel 8.0");
                    MyCommand = new System.Data.OleDb.OleDbDataAdapter("select * from [Fiscal List$]", MyConnection);
                    FY = new System.Data.DataSet();
                    MyCommand.Fill(FY);
                    cmbBRyear.DataSource = FY.Tables[0];
                    cmbBRyear.DisplayMember = "Fiscal Year";
                    MyConnection.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void CmbAcct_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CmbBRyear_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        private void StudentRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Student SR = new Student();
            SR.ShowDialog();
        }
    }
}