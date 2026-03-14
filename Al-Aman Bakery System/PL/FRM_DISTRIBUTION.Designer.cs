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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txt_InvoiceNum = new Guna.UI2.WinForms.Guna2TextBox();
            this.dtp_Date = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dgv_SalesItems = new Guna.UI2.WinForms.Guna2DataGridView();
            this.cmb_Client = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmb_ProdName = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_Store = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SalesItems)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(800, 50);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(633, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(131, 21);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "تسليم عهدة السائق";
            // 
            // txt_InvoiceNum
            // 
            this.txt_InvoiceNum.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_InvoiceNum.DefaultText = "";
            this.txt_InvoiceNum.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_InvoiceNum.Location = new System.Drawing.Point(600, 56);
            this.txt_InvoiceNum.Name = "txt_InvoiceNum";
            this.txt_InvoiceNum.PlaceholderText = "رقم الفاتورة";
            this.txt_InvoiceNum.SelectedText = "";
            this.txt_InvoiceNum.Size = new System.Drawing.Size(200, 36);
            this.txt_InvoiceNum.TabIndex = 1;
            // 
            // dtp_Date
            // 
            this.dtp_Date.Checked = true;
            this.dtp_Date.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtp_Date.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtp_Date.Location = new System.Drawing.Point(12, 56);
            this.dtp_Date.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtp_Date.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtp_Date.Name = "dtp_Date";
            this.dtp_Date.Size = new System.Drawing.Size(150, 36);
            this.dtp_Date.TabIndex = 4;
            this.dtp_Date.Value = new System.DateTime(2026, 3, 13, 19, 5, 7, 105);
            // 
            // dgv_SalesItems
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgv_SalesItems.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_SalesItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_SalesItems.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_SalesItems.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_SalesItems.Location = new System.Drawing.Point(48, 188);
            this.dgv_SalesItems.Name = "dgv_SalesItems";
            this.dgv_SalesItems.RowHeadersVisible = false;
            this.dgv_SalesItems.Size = new System.Drawing.Size(700, 300);
            this.dgv_SalesItems.TabIndex = 5;
            this.dgv_SalesItems.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_SalesItems.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_SalesItems.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_SalesItems.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_SalesItems.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_SalesItems.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv_SalesItems.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_SalesItems.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgv_SalesItems.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_SalesItems.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_SalesItems.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_SalesItems.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_SalesItems.ThemeStyle.HeaderStyle.Height = 23;
            this.dgv_SalesItems.ThemeStyle.ReadOnly = false;
            this.dgv_SalesItems.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_SalesItems.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_SalesItems.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_SalesItems.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_SalesItems.ThemeStyle.RowsStyle.Height = 22;
            this.dgv_SalesItems.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_SalesItems.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // cmb_Client
            // 
            this.cmb_Client.BackColor = System.Drawing.Color.Transparent;
            this.cmb_Client.BorderRadius = 15;
            this.cmb_Client.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_Client.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Client.FocusedColor = System.Drawing.Color.Empty;
            this.cmb_Client.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmb_Client.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmb_Client.ItemHeight = 30;
            this.cmb_Client.Location = new System.Drawing.Point(262, 104);
            this.cmb_Client.Name = "cmb_Client";
            this.cmb_Client.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmb_Client.Size = new System.Drawing.Size(242, 36);
            this.cmb_Client.TabIndex = 6;
            // 
            // cmb_ProdName
            // 
            this.cmb_ProdName.BackColor = System.Drawing.Color.Transparent;
            this.cmb_ProdName.BorderRadius = 15;
            this.cmb_ProdName.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_ProdName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_ProdName.FocusedColor = System.Drawing.Color.Empty;
            this.cmb_ProdName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmb_ProdName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmb_ProdName.ItemHeight = 30;
            this.cmb_ProdName.Location = new System.Drawing.Point(262, 146);
            this.cmb_ProdName.Name = "cmb_ProdName";
            this.cmb_ProdName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmb_ProdName.Size = new System.Drawing.Size(242, 36);
            this.cmb_ProdName.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(510, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 19);
            this.label1.TabIndex = 9;
            this.label1.Text = "اسم السائق:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(510, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "اسم الصنف:";
            // 
            // cmb_Store
            // 
            this.cmb_Store.BackColor = System.Drawing.Color.Transparent;
            this.cmb_Store.BorderRadius = 15;
            this.cmb_Store.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_Store.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Store.FocusedColor = System.Drawing.Color.Empty;
            this.cmb_Store.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmb_Store.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmb_Store.ItemHeight = 30;
            this.cmb_Store.Location = new System.Drawing.Point(262, 56);
            this.cmb_Store.Name = "cmb_Store";
            this.cmb_Store.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmb_Store.Size = new System.Drawing.Size(242, 36);
            this.cmb_Store.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(510, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 19);
            this.label3.TabIndex = 12;
            this.label3.Text = "اسم المخزن:";
            // 
            // FRM_DISTRIBUTION
            // 
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmb_Store);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_ProdName);
            this.Controls.Add(this.cmb_Client);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.txt_InvoiceNum);
            this.Controls.Add(this.dtp_Date);
            this.Controls.Add(this.dgv_SalesItems);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_DISTRIBUTION";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SalesItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        // المكونات (تم تعريفها في الكود أعلاه)
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2TextBox txt_InvoiceNum;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtp_Date;
        private Guna.UI2.WinForms.Guna2DataGridView dgv_SalesItems;
        private Guna.UI2.WinForms.Guna2ComboBox cmb_Client;
        private Guna.UI2.WinForms.Guna2ComboBox cmb_ProdName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ComboBox cmb_Store;
        private System.Windows.Forms.Label label3;
    }
}