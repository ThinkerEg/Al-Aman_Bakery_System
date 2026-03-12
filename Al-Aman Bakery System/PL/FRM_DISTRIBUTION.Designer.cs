namespace Al_Aman_Bakery_System.PL
{
    partial class FRM_DISTRIBUTION
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            // إنشاء المكونات
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txt_InvoiceNum = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_Client = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_Store = new Guna.UI2.WinForms.Guna2TextBox();
            this.dtp_Date = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dgv_SalesItems = new Guna.UI2.WinForms.Guna2DataGridView();

            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SalesItems)).BeginInit();
            this.SuspendLayout();

            // 1. الهيدر
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Size = new System.Drawing.Size(800, 50);
            this.pnlHeader.Controls.Add(this.lblTitle);

            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(680, 15);
            this.lblTitle.Text = "فاتورة مبيعات";

            // 2. الحقول العلوية
            this.txt_InvoiceNum.Location = new System.Drawing.Point(600, 70);
            this.txt_InvoiceNum.PlaceholderText = "رقم الفاتورة";
            this.txt_Client.Location = new System.Drawing.Point(400, 70);
            this.txt_Client.PlaceholderText = "العميل";
            this.txt_Store.Location = new System.Drawing.Point(200, 70);
            this.txt_Store.PlaceholderText = "المخزن";
            this.dtp_Date.Location = new System.Drawing.Point(20, 70);
            this.dtp_Date.Size = new System.Drawing.Size(150, 36);

            // 3. الجدول
            this.dgv_SalesItems.Location = new System.Drawing.Point(50, 130);
            this.dgv_SalesItems.Size = new System.Drawing.Size(700, 300);

            // 4. إعدادات الفورم
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.txt_InvoiceNum);
            this.Controls.Add(this.txt_Client);
            this.Controls.Add(this.txt_Store);
            this.Controls.Add(this.dtp_Date);
            this.Controls.Add(this.dgv_SalesItems);

            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SalesItems)).EndInit();
            this.ResumeLayout(false);
        }
        #endregion

        // المكونات (تم تعريفها في الكود أعلاه)
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2TextBox txt_InvoiceNum;
        private Guna.UI2.WinForms.Guna2TextBox txt_Client;
        private Guna.UI2.WinForms.Guna2TextBox txt_Store;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtp_Date;
        private Guna.UI2.WinForms.Guna2DataGridView dgv_SalesItems;
    }
}