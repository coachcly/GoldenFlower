namespace GoldenFlower
{
    partial class PayrollHR
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PayrollHR));
            this.lblLast = new System.Windows.Forms.Label();
            this.txtLast = new System.Windows.Forms.TextBox();
            this.pictureBoxLast = new System.Windows.Forms.PictureBox();
            this.btn1Generate = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.pblogo = new System.Windows.Forms.PictureBox();
            this.lblRecs = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.UFdoc = new System.Windows.Forms.PictureBox();
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
            this.pictureBoxDT = new System.Windows.Forms.PictureBox();
            this.lblDocType = new System.Windows.Forms.Label();
            this.pictureBoxFirst = new System.Windows.Forms.PictureBox();
            this.txtFN = new System.Windows.Forms.TextBox();
            this.lblFirst = new System.Windows.Forms.Label();
            this.DOBpick = new System.Windows.Forms.DateTimePicker();
            this.labelDOB = new System.Windows.Forms.Label();
            this.pictureBoxDOB = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxSelect = new System.Windows.Forms.ComboBox();
            this.cmbdocType = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pblogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UFdoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFirst)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDOB)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLast
            // 
            this.lblLast.AutoSize = true;
            this.lblLast.Location = new System.Drawing.Point(600, 132);
            this.lblLast.Name = "lblLast";
            this.lblLast.Size = new System.Drawing.Size(76, 17);
            this.lblLast.TabIndex = 5;
            this.lblLast.Text = "Last Name";
            // 
            // txtLast
            // 
            this.txtLast.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtLast.Location = new System.Drawing.Point(554, 151);
            this.txtLast.Name = "txtLast";
            this.txtLast.Size = new System.Drawing.Size(152, 22);
            this.txtLast.TabIndex = 1;
            this.txtLast.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtLast_KeyPress);
            // 
            // pictureBoxLast
            // 
            this.pictureBoxLast.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBoxLast.Location = new System.Drawing.Point(552, 198);
            this.pictureBoxLast.Name = "pictureBoxLast";
            this.pictureBoxLast.Size = new System.Drawing.Size(152, 110);
            this.pictureBoxLast.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLast.TabIndex = 10;
            this.pictureBoxLast.TabStop = false;
            this.pictureBoxLast.Click += new System.EventHandler(this.PictureBoxvendor_Click);
            // 
            // btn1Generate
            // 
            this.btn1Generate.Location = new System.Drawing.Point(768, 396);
            this.btn1Generate.Name = "btn1Generate";
            this.btn1Generate.Size = new System.Drawing.Size(134, 33);
            this.btn1Generate.TabIndex = 13;
            this.btn1Generate.Text = "Generate";
            this.btn1Generate.UseVisualStyleBackColor = true;
            this.btn1Generate.Click += new System.EventHandler(this.Btn1Generate_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(920, 396);
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
            // lblRecs
            // 
            this.lblRecs.AutoSize = true;
            this.lblRecs.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecs.Location = new System.Drawing.Point(432, 44);
            this.lblRecs.Name = "lblRecs";
            this.lblRecs.Size = new System.Drawing.Size(253, 55);
            this.lblRecs.TabIndex = 6;
            this.lblRecs.Text = "Payroll HR";
            this.lblRecs.Click += new System.EventHandler(this.Lblcheckpacket_Click);
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
            this.UFdoc.Location = new System.Drawing.Point(984, 44);
            this.UFdoc.Name = "UFdoc";
            this.UFdoc.Size = new System.Drawing.Size(64, 55);
            this.UFdoc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.UFdoc.TabIndex = 17;
            this.UFdoc.TabStop = false;
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
            this.menuStrip1.Size = new System.Drawing.Size(1091, 28);
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
            this.bankRECToolStripMenuItem.Click += new System.EventHandler(this.PayrollHRToolStripMenuItem_Click);
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
            // 
            // pictureBoxDT
            // 
            this.pictureBoxDT.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBoxDT.Location = new System.Drawing.Point(896, 198);
            this.pictureBoxDT.Name = "pictureBoxDT";
            this.pictureBoxDT.Size = new System.Drawing.Size(152, 110);
            this.pictureBoxDT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxDT.TabIndex = 25;
            this.pictureBoxDT.TabStop = false;
            // 
            // lblDocType
            // 
            this.lblDocType.AutoSize = true;
            this.lblDocType.Location = new System.Drawing.Point(936, 132);
            this.lblDocType.Name = "lblDocType";
            this.lblDocType.Size = new System.Drawing.Size(69, 17);
            this.lblDocType.TabIndex = 24;
            this.lblDocType.Text = "Doc Type";
            // 
            // pictureBoxFirst
            // 
            this.pictureBoxFirst.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBoxFirst.Location = new System.Drawing.Point(720, 198);
            this.pictureBoxFirst.Name = "pictureBoxFirst";
            this.pictureBoxFirst.Size = new System.Drawing.Size(152, 110);
            this.pictureBoxFirst.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxFirst.TabIndex = 28;
            this.pictureBoxFirst.TabStop = false;
            // 
            // txtFN
            // 
            this.txtFN.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFN.Location = new System.Drawing.Point(720, 154);
            this.txtFN.Name = "txtFN";
            this.txtFN.Size = new System.Drawing.Size(152, 22);
            this.txtFN.TabIndex = 26;
            this.txtFN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtLast_KeyPress);
            // 
            // lblFirst
            // 
            this.lblFirst.AutoSize = true;
            this.lblFirst.Location = new System.Drawing.Point(760, 132);
            this.lblFirst.Name = "lblFirst";
            this.lblFirst.Size = new System.Drawing.Size(76, 17);
            this.lblFirst.TabIndex = 27;
            this.lblFirst.Text = "First Name";
            // 
            // DOBpick
            // 
            this.DOBpick.Location = new System.Drawing.Point(304, 154);
            this.DOBpick.Name = "DOBpick";
            this.DOBpick.Size = new System.Drawing.Size(224, 22);
            this.DOBpick.TabIndex = 31;
            // 
            // labelDOB
            // 
            this.labelDOB.AutoSize = true;
            this.labelDOB.Location = new System.Drawing.Point(368, 132);
            this.labelDOB.Name = "labelDOB";
            this.labelDOB.Size = new System.Drawing.Size(87, 17);
            this.labelDOB.TabIndex = 32;
            this.labelDOB.Text = "Date of Birth";
            // 
            // pictureBoxDOB
            // 
            this.pictureBoxDOB.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBoxDOB.Location = new System.Drawing.Point(328, 198);
            this.pictureBoxDOB.Name = "pictureBoxDOB";
            this.pictureBoxDOB.Size = new System.Drawing.Size(152, 110);
            this.pictureBoxDOB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxDOB.TabIndex = 33;
            this.pictureBoxDOB.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 17);
            this.label2.TabIndex = 35;
            this.label2.Text = "Church or School";
            // 
            // comboBoxSelect
            // 
            this.comboBoxSelect.FormattingEnabled = true;
            this.comboBoxSelect.Items.AddRange(new object[] {
            "Church",
            "School"});
            this.comboBoxSelect.Location = new System.Drawing.Point(112, 198);
            this.comboBoxSelect.Name = "comboBoxSelect";
            this.comboBoxSelect.Size = new System.Drawing.Size(121, 24);
            this.comboBoxSelect.TabIndex = 34;
            this.comboBoxSelect.SelectedIndexChanged += new System.EventHandler(this.ComboBoxSelect_SelectedIndexChanged);
            // 
            // cmbdocType
            // 
            this.cmbdocType.FormattingEnabled = true;
            this.cmbdocType.Location = new System.Drawing.Point(896, 154);
            this.cmbdocType.Name = "cmbdocType";
            this.cmbdocType.Size = new System.Drawing.Size(152, 24);
            this.cmbdocType.TabIndex = 36;
            this.cmbdocType.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CmbdocType_KeyPress);
            this.cmbdocType.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CmbdocType_MouseClick);
            // 
            // PayrollHR
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1091, 462);
            this.Controls.Add(this.cmbdocType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxSelect);
            this.Controls.Add(this.pictureBoxDOB);
            this.Controls.Add(this.labelDOB);
            this.Controls.Add(this.DOBpick);
            this.Controls.Add(this.pictureBoxFirst);
            this.Controls.Add(this.txtFN);
            this.Controls.Add(this.lblFirst);
            this.Controls.Add(this.pictureBoxDT);
            this.Controls.Add(this.lblDocType);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.UFdoc);
            this.Controls.Add(this.lblRecs);
            this.Controls.Add(this.pblogo);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btn1Generate);
            this.Controls.Add(this.pictureBoxLast);
            this.Controls.Add(this.txtLast);
            this.Controls.Add(this.lblLast);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PayrollHR";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bank Recs";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PayrollHR_FormClosing);
            this.Load += new System.EventHandler(this.PayrollHR_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLast)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pblogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UFdoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFirst)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDOB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblLast;
        private System.Windows.Forms.TextBox txtLast;
        private System.Windows.Forms.PictureBox pictureBoxLast;
        private System.Windows.Forms.Button btn1Generate;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.PictureBox pblogo;
        private System.Windows.Forms.Label lblRecs;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PictureBox UFdoc;
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
        private System.Windows.Forms.PictureBox pictureBoxFirst;
        private System.Windows.Forms.TextBox txtFN;
        private System.Windows.Forms.Label lblFirst;
        private System.Windows.Forms.PictureBox pictureBoxDT;
        private System.Windows.Forms.Label lblDocType;
        private System.Windows.Forms.Label labelDOB;
        private System.Windows.Forms.DateTimePicker DOBpick;
        private System.Windows.Forms.PictureBox pictureBoxDOB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxSelect;
        private System.Windows.Forms.ComboBox cmbdocType;
    }
}