namespace GoldenFlower
{
    partial class fCheckPack
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fCheckPack));
            this.lblvendor = new System.Windows.Forms.Label();
            this.txtcheck = new System.Windows.Forms.TextBox();
            this.lblcheck = new System.Windows.Forms.Label();
            this.lblFiscalY = new System.Windows.Forms.Label();
            this.pictureBoxvendor = new System.Windows.Forms.PictureBox();
            this.pictureBoxcheck = new System.Windows.Forms.PictureBox();
            this.pictureBoxfiscal = new System.Windows.Forms.PictureBox();
            this.btn1Generate = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.pblogo = new System.Windows.Forms.PictureBox();
            this.lblcheckpacket = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.UFdoc = new System.Windows.Forms.PictureBox();
            this.comboBox1year = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkPacketToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bankRECToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.payrollAndHRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.permanentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personnelRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sacramentalRecoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBoxSelect = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxVendor = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxvendor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxcheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxfiscal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pblogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UFdoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblvendor
            // 
            this.lblvendor.AutoSize = true;
            this.lblvendor.Location = new System.Drawing.Point(312, 110);
            this.lblvendor.Name = "lblvendor";
            this.lblvendor.Size = new System.Drawing.Size(54, 17);
            this.lblvendor.TabIndex = 5;
            this.lblvendor.Text = "Vendor";
            this.lblvendor.Click += new System.EventHandler(this.Lblvendor_Click);
            // 
            // txtcheck
            // 
            this.txtcheck.AcceptsTab = true;
            this.txtcheck.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtcheck.Location = new System.Drawing.Point(528, 131);
            this.txtcheck.Name = "txtcheck";
            this.txtcheck.Size = new System.Drawing.Size(216, 22);
            this.txtcheck.TabIndex = 2;
            this.txtcheck.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtcheck_KeyPress);
            // 
            // lblcheck
            // 
            this.lblcheck.AutoSize = true;
            this.lblcheck.Location = new System.Drawing.Point(600, 110);
            this.lblcheck.Name = "lblcheck";
            this.lblcheck.Size = new System.Drawing.Size(59, 17);
            this.lblcheck.TabIndex = 7;
            this.lblcheck.Text = "Check #";
            // 
            // lblFiscalY
            // 
            this.lblFiscalY.AutoSize = true;
            this.lblFiscalY.Location = new System.Drawing.Point(872, 110);
            this.lblFiscalY.Name = "lblFiscalY";
            this.lblFiscalY.Size = new System.Drawing.Size(78, 17);
            this.lblFiscalY.TabIndex = 8;
            this.lblFiscalY.Text = "Fiscal Year";
            // 
            // pictureBoxvendor
            // 
            this.pictureBoxvendor.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBoxvendor.Location = new System.Drawing.Point(240, 176);
            this.pictureBoxvendor.Name = "pictureBoxvendor";
            this.pictureBoxvendor.Size = new System.Drawing.Size(217, 152);
            this.pictureBoxvendor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxvendor.TabIndex = 10;
            this.pictureBoxvendor.TabStop = false;
            this.pictureBoxvendor.Click += new System.EventHandler(this.PictureBoxvendor_Click);
            // 
            // pictureBoxcheck
            // 
            this.pictureBoxcheck.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBoxcheck.Location = new System.Drawing.Point(528, 176);
            this.pictureBoxcheck.Name = "pictureBoxcheck";
            this.pictureBoxcheck.Size = new System.Drawing.Size(217, 152);
            this.pictureBoxcheck.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxcheck.TabIndex = 11;
            this.pictureBoxcheck.TabStop = false;
            this.pictureBoxcheck.Click += new System.EventHandler(this.PictureBoxcheck_Click);
            // 
            // pictureBoxfiscal
            // 
            this.pictureBoxfiscal.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBoxfiscal.Location = new System.Drawing.Point(816, 176);
            this.pictureBoxfiscal.Name = "pictureBoxfiscal";
            this.pictureBoxfiscal.Size = new System.Drawing.Size(216, 152);
            this.pictureBoxfiscal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxfiscal.TabIndex = 12;
            this.pictureBoxfiscal.TabStop = false;
            // 
            // btn1Generate
            // 
            this.btn1Generate.Location = new System.Drawing.Point(687, 363);
            this.btn1Generate.Name = "btn1Generate";
            this.btn1Generate.Size = new System.Drawing.Size(134, 33);
            this.btn1Generate.TabIndex = 13;
            this.btn1Generate.Text = "Generate";
            this.btn1Generate.UseVisualStyleBackColor = true;
            this.btn1Generate.Click += new System.EventHandler(this.Btn1Generate_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(848, 363);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(134, 33);
            this.btnPrint.TabIndex = 14;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.BtnPrint_Click);
            // 
            // pblogo
            // 
            this.pblogo.Image = ((System.Drawing.Image)(resources.GetObject("pblogo.Image")));
            this.pblogo.Location = new System.Drawing.Point(32, 44);
            this.pblogo.Name = "pblogo";
            this.pblogo.Size = new System.Drawing.Size(96, 68);
            this.pblogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pblogo.TabIndex = 16;
            this.pblogo.TabStop = false;
            // 
            // lblcheckpacket
            // 
            this.lblcheckpacket.AutoSize = true;
            this.lblcheckpacket.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcheckpacket.Location = new System.Drawing.Point(384, 44);
            this.lblcheckpacket.Name = "lblcheckpacket";
            this.lblcheckpacket.Size = new System.Drawing.Size(281, 55);
            this.lblcheckpacket.TabIndex = 6;
            this.lblcheckpacket.Text = "Check Pack";
            this.lblcheckpacket.Click += new System.EventHandler(this.Lblcheckpacket_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            this.printPreviewDialog1.Load += new System.EventHandler(this.PrintPreviewDialog1_Load);
            // 
            // UFdoc
            // 
            this.UFdoc.BackColor = System.Drawing.SystemColors.Window;
            this.UFdoc.Location = new System.Drawing.Point(912, 44);
            this.UFdoc.Name = "UFdoc";
            this.UFdoc.Size = new System.Drawing.Size(64, 55);
            this.UFdoc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.UFdoc.TabIndex = 17;
            this.UFdoc.TabStop = false;
            // 
            // comboBox1year
            // 
            this.comboBox1year.FormattingEnabled = true;
            this.comboBox1year.Location = new System.Drawing.Point(816, 132);
            this.comboBox1year.Name = "comboBox1year";
            this.comboBox1year.Size = new System.Drawing.Size(216, 24);
            this.comboBox1year.TabIndex = 18;
            this.comboBox1year.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ComboBoxFiscal_MouseClick);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.formTypeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1063, 28);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.ShowShortcutKeys = false;
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click_1);
            // 
            // formTypeToolStripMenuItem
            // 
            this.formTypeToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.formTypeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkPacketToolStripMenuItem,
            this.bankRECToolStripMenuItem,
            this.payrollAndHRToolStripMenuItem,
            this.permanentToolStripMenuItem,
            this.personnelRecordToolStripMenuItem,
            this.studentRecordToolStripMenuItem,
            this.sacramentalRecoToolStripMenuItem});
            this.formTypeToolStripMenuItem.Name = "formTypeToolStripMenuItem";
            this.formTypeToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
            this.formTypeToolStripMenuItem.Text = "Form Type";
            // 
            // checkPacketToolStripMenuItem
            // 
            this.checkPacketToolStripMenuItem.Name = "checkPacketToolStripMenuItem";
            this.checkPacketToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.checkPacketToolStripMenuItem.Text = "Check Packet";
            this.checkPacketToolStripMenuItem.Click += new System.EventHandler(this.CheckPacketToolStripMenuItem_Click_1);
            // 
            // bankRECToolStripMenuItem
            // 
            this.bankRECToolStripMenuItem.Name = "bankRECToolStripMenuItem";
            this.bankRECToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.bankRECToolStripMenuItem.Text = "Bank Rec Deposit";
            this.bankRECToolStripMenuItem.Click += new System.EventHandler(this.BankRECToolStripMenuItem_Click);
            // 
            // payrollAndHRToolStripMenuItem
            // 
            this.payrollAndHRToolStripMenuItem.Name = "payrollAndHRToolStripMenuItem";
            this.payrollAndHRToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.payrollAndHRToolStripMenuItem.Text = "Payroll and HR";
            this.payrollAndHRToolStripMenuItem.Click += new System.EventHandler(this.PayrollAndHRToolStripMenuItem_Click);
            // 
            // permanentToolStripMenuItem
            // 
            this.permanentToolStripMenuItem.Name = "permanentToolStripMenuItem";
            this.permanentToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.permanentToolStripMenuItem.Text = "Permanent";
            this.permanentToolStripMenuItem.Click += new System.EventHandler(this.PermanentToolStripMenuItem_Click);
            // 
            // personnelRecordToolStripMenuItem
            // 
            this.personnelRecordToolStripMenuItem.Name = "personnelRecordToolStripMenuItem";
            this.personnelRecordToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.personnelRecordToolStripMenuItem.Text = "Personnel Record";
            this.personnelRecordToolStripMenuItem.Click += new System.EventHandler(this.PersonnelRecordToolStripMenuItem_Click);
            // 
            // studentRecordToolStripMenuItem
            // 
            this.studentRecordToolStripMenuItem.Name = "studentRecordToolStripMenuItem";
            this.studentRecordToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.studentRecordToolStripMenuItem.Text = "Student Record";
            this.studentRecordToolStripMenuItem.Click += new System.EventHandler(this.StudentRecordToolStripMenuItem_Click);
            // 
            // sacramentalRecoToolStripMenuItem
            // 
            this.sacramentalRecoToolStripMenuItem.Name = "sacramentalRecoToolStripMenuItem";
            this.sacramentalRecoToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.sacramentalRecoToolStripMenuItem.Text = "Sacramental Record";
            this.sacramentalRecoToolStripMenuItem.Click += new System.EventHandler(this.SacramentalRecoToolStripMenuItem_Click);
            // 
            // comboBoxSelect
            // 
            this.comboBoxSelect.FormattingEnabled = true;
            this.comboBoxSelect.Items.AddRange(new object[] {
            "Church",
            "School"});
            this.comboBoxSelect.Location = new System.Drawing.Point(56, 220);
            this.comboBoxSelect.Name = "comboBoxSelect";
            this.comboBoxSelect.Size = new System.Drawing.Size(121, 24);
            this.comboBoxSelect.TabIndex = 20;
            this.comboBoxSelect.SelectedIndexChanged += new System.EventHandler(this.ComboBoxSelect_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "Church or School";
            // 
            // comboBoxVendor
            // 
            this.comboBoxVendor.FormattingEnabled = true;
            this.comboBoxVendor.Location = new System.Drawing.Point(240, 132);
            this.comboBoxVendor.Name = "comboBoxVendor";
            this.comboBoxVendor.Size = new System.Drawing.Size(216, 24);
            this.comboBoxVendor.TabIndex = 23;
            this.comboBoxVendor.SelectedIndexChanged += new System.EventHandler(this.ComboBoxVendor_SelectedIndexChanged);
            this.comboBoxVendor.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ComboBoxVendor_MouseClick);
            // 
            // fCheckPack
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1063, 432);
            this.Controls.Add(this.comboBoxVendor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxSelect);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.comboBox1year);
            this.Controls.Add(this.UFdoc);
            this.Controls.Add(this.lblcheckpacket);
            this.Controls.Add(this.pblogo);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btn1Generate);
            this.Controls.Add(this.pictureBoxfiscal);
            this.Controls.Add(this.pictureBoxcheck);
            this.Controls.Add(this.pictureBoxvendor);
            this.Controls.Add(this.lblFiscalY);
            this.Controls.Add(this.txtcheck);
            this.Controls.Add(this.lblcheck);
            this.Controls.Add(this.lblvendor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fCheckPack";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CheckPacket";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FCheckPack_FormClosing);
            this.Load += new System.EventHandler(this.FCheckPack_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxvendor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxcheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxfiscal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pblogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UFdoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblvendor;
        private System.Windows.Forms.TextBox txtcheck;
        private System.Windows.Forms.Label lblcheck;
        private System.Windows.Forms.Label lblFiscalY;
        private System.Windows.Forms.PictureBox pictureBoxvendor;
        private System.Windows.Forms.PictureBox pictureBoxcheck;
        private System.Windows.Forms.PictureBox pictureBoxfiscal;
        private System.Windows.Forms.Button btn1Generate;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.PictureBox pblogo;
        private System.Windows.Forms.Label lblcheckpacket;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PictureBox UFdoc;
        private System.Windows.Forms.ComboBox comboBox1year;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkPacketToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bankRECToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem payrollAndHRToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem permanentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personnelRecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentRecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sacramentalRecoToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxSelect;
        private System.Windows.Forms.ComboBox comboBoxVendor;
    }
}