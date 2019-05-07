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
    public partial class Cbarcode : Form
    {
        public Cbarcode()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Cbarcode_Load(object sender, EventArgs e)
        {

        }

        private void Cbarcode_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void MenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void CheckPacketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            fCheckPack cpack = new fCheckPack();
            cpack.ShowDialog();
        }

        private void Cbarcode_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Cbarcode_Load_1(object sender, EventArgs e)
        {

        }

        private void BankCheckPacketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            BankRec brec = new BankRec();
            brec.ShowDialog();
        }

        private void PicBox1logo_Click(object sender, EventArgs e)
        {

        }

        private void PayrollAndHRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            PayrollHR pHR = new PayrollHR();
            pHR.ShowDialog();
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
