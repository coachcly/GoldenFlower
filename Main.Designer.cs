namespace GoldenFlower
{
    partial class Cbarcode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cbarcode));
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
            this.picBox1logo = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox1logo)).BeginInit();
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
            this.menuStrip1.Size = new System.Drawing.Size(963, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MenuStrip1_ItemClicked);
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
            this.checkPacketToolStripMenuItem.Click += new System.EventHandler(this.CheckPacketToolStripMenuItem_Click);
            // 
            // bankRECToolStripMenuItem
            // 
            this.bankRECToolStripMenuItem.Name = "bankRECToolStripMenuItem";
            this.bankRECToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.bankRECToolStripMenuItem.Text = "Bank Rec Deposit";
            this.bankRECToolStripMenuItem.Click += new System.EventHandler(this.BankCheckPacketToolStripMenuItem_Click);
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
            // picBox1logo
            // 
            this.picBox1logo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picBox1logo.Image = ((System.Drawing.Image)(resources.GetObject("picBox1logo.Image")));
            this.picBox1logo.Location = new System.Drawing.Point(208, 48);
            this.picBox1logo.Name = "picBox1logo";
            this.picBox1logo.Size = new System.Drawing.Size(489, 284);
            this.picBox1logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox1logo.TabIndex = 3;
            this.picBox1logo.TabStop = false;
            this.picBox1logo.Click += new System.EventHandler(this.PicBox1logo_Click);
            // 
            // Cbarcode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(963, 691);
            this.Controls.Add(this.picBox1logo);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Cbarcode";
            this.Text = "Barcode Creator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Cbarcode_FormClosing_1);
            this.Load += new System.EventHandler(this.Cbarcode_Load_1);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox1logo)).EndInit();
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
        private System.Windows.Forms.ToolStripMenuItem bankRECToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem payrollAndHRToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem permanentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personnelRecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentRecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sacramentalRecoToolStripMenuItem;
        protected System.Windows.Forms.PictureBox picBox1logo;
    }
}

