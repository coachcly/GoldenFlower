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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fCheckPack));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkPacketToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bankCheckPacketToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.payrollAndHRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.permanentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personnelRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sacramentalRecoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblvendor = new System.Windows.Forms.Label();
            this.txtVendor = new System.Windows.Forms.TextBox();
            this.txtcheck = new System.Windows.Forms.TextBox();
            this.lblcheck = new System.Windows.Forms.Label();
            this.txtFiscalY = new System.Windows.Forms.TextBox();
            this.lblFiscalY = new System.Windows.Forms.Label();
            this.pictureBoxvendor = new System.Windows.Forms.PictureBox();
            this.pictureBoxcheck = new System.Windows.Forms.PictureBox();
            this.pictureBoxfiscal = new System.Windows.Forms.PictureBox();
            this.btn1Generate = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.pblogo = new System.Windows.Forms.PictureBox();
            this.lblcheckpacket = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxvendor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxcheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxfiscal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pblogo)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.formTypeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1023, 28);
            this.menuStrip1.TabIndex = 3;
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
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // formTypeToolStripMenuItem
            // 
            this.formTypeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkPacketToolStripMenuItem,
            this.bankCheckPacketToolStripMenuItem,
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
            this.checkPacketToolStripMenuItem.Click += new System.EventHandler(this.CheckPacketToolStripMenuItem_Click);
            // 
            // bankCheckPacketToolStripMenuItem
            // 
            this.bankCheckPacketToolStripMenuItem.Name = "bankCheckPacketToolStripMenuItem";
            this.bankCheckPacketToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.bankCheckPacketToolStripMenuItem.Text = "Bank Check Packet";
            // 
            // payrollAndHRToolStripMenuItem
            // 
            this.payrollAndHRToolStripMenuItem.Name = "payrollAndHRToolStripMenuItem";
            this.payrollAndHRToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.payrollAndHRToolStripMenuItem.Text = "Payroll and HR";
            // 
            // permanentToolStripMenuItem
            // 
            this.permanentToolStripMenuItem.Name = "permanentToolStripMenuItem";
            this.permanentToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.permanentToolStripMenuItem.Text = "Permanent";
            // 
            // personnelRecordToolStripMenuItem
            // 
            this.personnelRecordToolStripMenuItem.Name = "personnelRecordToolStripMenuItem";
            this.personnelRecordToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.personnelRecordToolStripMenuItem.Text = "Personnel Record";
            // 
            // studentRecordToolStripMenuItem
            // 
            this.studentRecordToolStripMenuItem.Name = "studentRecordToolStripMenuItem";
            this.studentRecordToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.studentRecordToolStripMenuItem.Text = "Student Record";
            // 
            // sacramentalRecoToolStripMenuItem
            // 
            this.sacramentalRecoToolStripMenuItem.Name = "sacramentalRecoToolStripMenuItem";
            this.sacramentalRecoToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.sacramentalRecoToolStripMenuItem.Text = "Sacramental Record";
            // 
            // lblvendor
            // 
            this.lblvendor.AutoSize = true;
            this.lblvendor.Location = new System.Drawing.Point(18, 321);
            this.lblvendor.Name = "lblvendor";
            this.lblvendor.Size = new System.Drawing.Size(54, 17);
            this.lblvendor.TabIndex = 5;
            this.lblvendor.Text = "Vendor";
            // 
            // txtVendor
            // 
            this.txtVendor.Location = new System.Drawing.Point(94, 318);
            this.txtVendor.Name = "txtVendor";
            this.txtVendor.Size = new System.Drawing.Size(211, 22);
            this.txtVendor.TabIndex = 3;
            // 
            // txtcheck
            // 
            this.txtcheck.Location = new System.Drawing.Point(396, 320);
            this.txtcheck.Name = "txtcheck";
            this.txtcheck.Size = new System.Drawing.Size(211, 22);
            this.txtcheck.TabIndex = 1;
            // 
            // lblcheck
            // 
            this.lblcheck.AutoSize = true;
            this.lblcheck.Location = new System.Drawing.Point(320, 323);
            this.lblcheck.Name = "lblcheck";
            this.lblcheck.Size = new System.Drawing.Size(59, 17);
            this.lblcheck.TabIndex = 7;
            this.lblcheck.Text = "Check #";
            // 
            // txtFiscalY
            // 
            this.txtFiscalY.Location = new System.Drawing.Point(718, 320);
            this.txtFiscalY.Name = "txtFiscalY";
            this.txtFiscalY.Size = new System.Drawing.Size(211, 22);
            this.txtFiscalY.TabIndex = 9;
            // 
            // lblFiscalY
            // 
            this.lblFiscalY.AutoSize = true;
            this.lblFiscalY.Location = new System.Drawing.Point(642, 323);
            this.lblFiscalY.Name = "lblFiscalY";
            this.lblFiscalY.Size = new System.Drawing.Size(78, 17);
            this.lblFiscalY.TabIndex = 8;
            this.lblFiscalY.Text = "Fiscal Year";
            // 
            // pictureBoxvendor
            // 
            this.pictureBoxvendor.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBoxvendor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxvendor.Location = new System.Drawing.Point(396, 376);
            this.pictureBoxvendor.Name = "pictureBoxvendor";
            this.pictureBoxvendor.Size = new System.Drawing.Size(217, 152);
            this.pictureBoxvendor.TabIndex = 10;
            this.pictureBoxvendor.TabStop = false;
            this.pictureBoxvendor.Click += new System.EventHandler(this.PictureBoxvendor_Click);
            // 
            // pictureBoxcheck
            // 
            this.pictureBoxcheck.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBoxcheck.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxcheck.Location = new System.Drawing.Point(396, 592);
            this.pictureBoxcheck.Name = "pictureBoxcheck";
            this.pictureBoxcheck.Size = new System.Drawing.Size(217, 152);
            this.pictureBoxcheck.TabIndex = 11;
            this.pictureBoxcheck.TabStop = false;
            // 
            // pictureBoxfiscal
            // 
            this.pictureBoxfiscal.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBoxfiscal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxfiscal.Location = new System.Drawing.Point(396, 808);
            this.pictureBoxfiscal.Name = "pictureBoxfiscal";
            this.pictureBoxfiscal.Size = new System.Drawing.Size(217, 152);
            this.pictureBoxfiscal.TabIndex = 12;
            this.pictureBoxfiscal.TabStop = false;
            // 
            // btn1Generate
            // 
            this.btn1Generate.Location = new System.Drawing.Point(695, 944);
            this.btn1Generate.Name = "btn1Generate";
            this.btn1Generate.Size = new System.Drawing.Size(134, 23);
            this.btn1Generate.TabIndex = 13;
            this.btn1Generate.Text = "Generate";
            this.btn1Generate.UseVisualStyleBackColor = true;
            this.btn1Generate.Click += new System.EventHandler(this.Btn1Generate_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(856, 944);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(134, 23);
            this.btnPrint.TabIndex = 14;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // pblogo
            // 
            this.pblogo.Image = ((System.Drawing.Image)(resources.GetObject("pblogo.Image")));
            this.pblogo.Location = new System.Drawing.Point(112, 64);
            this.pblogo.Name = "pblogo";
            this.pblogo.Size = new System.Drawing.Size(275, 183);
            this.pblogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pblogo.TabIndex = 16;
            this.pblogo.TabStop = false;
            // 
            // lblcheckpacket
            // 
            this.lblcheckpacket.AutoSize = true;
            this.lblcheckpacket.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcheckpacket.Location = new System.Drawing.Point(400, 192);
            this.lblcheckpacket.Name = "lblcheckpacket";
            this.lblcheckpacket.Size = new System.Drawing.Size(562, 55);
            this.lblcheckpacket.TabIndex = 6;
            this.lblcheckpacket.Text = "Check Pack Cover Sheet";
            // 
            // fCheckPack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1023, 1025);
            this.Controls.Add(this.lblcheckpacket);
            this.Controls.Add(this.pblogo);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btn1Generate);
            this.Controls.Add(this.pictureBoxfiscal);
            this.Controls.Add(this.pictureBoxcheck);
            this.Controls.Add(this.pictureBoxvendor);
            this.Controls.Add(this.txtFiscalY);
            this.Controls.Add(this.lblFiscalY);
            this.Controls.Add(this.txtcheck);
            this.Controls.Add(this.lblcheck);
            this.Controls.Add(this.txtVendor);
            this.Controls.Add(this.lblvendor);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(18, 47);
            this.Name = "fCheckPack";
            this.Text = "CheckPacket";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FCheckPack_FormClosing);
            this.Load += new System.EventHandler(this.FCheckPack_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxvendor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxcheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxfiscal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pblogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkPacketToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bankCheckPacketToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem payrollAndHRToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem permanentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personnelRecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentRecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sacramentalRecoToolStripMenuItem;
        private System.Windows.Forms.Label lblvendor;
        private System.Windows.Forms.TextBox txtVendor;
        private System.Windows.Forms.TextBox txtcheck;
        private System.Windows.Forms.Label lblcheck;
        private System.Windows.Forms.TextBox txtFiscalY;
        private System.Windows.Forms.Label lblFiscalY;
        private System.Windows.Forms.PictureBox pictureBoxvendor;
        private System.Windows.Forms.PictureBox pictureBoxcheck;
        private System.Windows.Forms.PictureBox pictureBoxfiscal;
        private System.Windows.Forms.Button btn1Generate;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.PictureBox pblogo;
        private System.Windows.Forms.Label lblcheckpacket;
    }
}