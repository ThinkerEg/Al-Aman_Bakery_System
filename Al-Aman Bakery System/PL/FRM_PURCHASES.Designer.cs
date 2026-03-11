namespace Al_Aman_Bakery_System.PL
{
    partial class FRM_PURCHASES
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btn_Close = new Guna.UI2.WinForms.Guna2CircleButton();
            this.gb_BillInfo = new Guna.UI2.WinForms.Guna2GroupBox();
            this.lbl_BillID = new System.Windows.Forms.Label();
            this.txt_BillID = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_BillDate = new System.Windows.Forms.Label();
            this.dtp_BillDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lbl_Supplier = new System.Windows.Forms.Label();
            this.cmb_Suppliers = new Guna.UI2.WinForms.Guna2ComboBox();
            this.gb_ItemEntry = new Guna.UI2.WinForms.Guna2GroupBox();
            this.lbl_ItemName = new System.Windows.Forms.Label();
            this.txt_ItemName = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_Qty = new System.Windows.Forms.Label();
            this.num_Qty = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.lbl_Price = new System.Windows.Forms.Label();
            this.num_Price = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.btn_SaveBill = new Guna.UI2.WinForms.Guna2Button();
            this.dgv_BillDetails = new Guna.UI2.WinForms.Guna2DataGridView();
            this.pnl_Footer = new System.Windows.Forms.Panel();
            this.lbl_Total = new System.Windows.Forms.Label();
            this.txt_TotalBill = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_Minimize = new Guna.UI2.WinForms.Guna2CircleButton();
            this.pnlHeader.SuspendLayout();
            this.gb_BillInfo.SuspendLayout();
            this.gb_ItemEntry.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_Qty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Price)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BillDetails)).BeginInit();
            this.pnl_Footer.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.pnlHeader.Controls.Add(this.btn_Minimize);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Controls.Add(this.btn_Close);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(950, 45);
            this.pnlHeader.TabIndex = 4;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(362, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(213, 45);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "فاتورة مشتريات جديدة";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Close
            // 
            this.btn_Close.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.btn_Close.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Close.ForeColor = System.Drawing.Color.White;
            this.btn_Close.Location = new System.Drawing.Point(10, 8);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(30, 30);
            this.btn_Close.TabIndex = 1;
            this.btn_Close.Text = "X";
            // 
            // gb_BillInfo
            // 
            this.gb_BillInfo.Controls.Add(this.lbl_BillID);
            this.gb_BillInfo.Controls.Add(this.txt_BillID);
            this.gb_BillInfo.Controls.Add(this.lbl_BillDate);
            this.gb_BillInfo.Controls.Add(this.dtp_BillDate);
            this.gb_BillInfo.Controls.Add(this.lbl_Supplier);
            this.gb_BillInfo.Controls.Add(this.cmb_Suppliers);
            this.gb_BillInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.gb_BillInfo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gb_BillInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.gb_BillInfo.Location = new System.Drawing.Point(0, 45);
            this.gb_BillInfo.Name = "gb_BillInfo";
            this.gb_BillInfo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gb_BillInfo.Size = new System.Drawing.Size(950, 122);
            this.gb_BillInfo.TabIndex = 3;
            this.gb_BillInfo.Text = "معلومات الفاتورة";
            this.gb_BillInfo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_BillID
            // 
            this.lbl_BillID.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_BillID.Location = new System.Drawing.Point(750, 46);
            this.lbl_BillID.Name = "lbl_BillID";
            this.lbl_BillID.Size = new System.Drawing.Size(150, 20);
            this.lbl_BillID.TabIndex = 0;
            this.lbl_BillID.Text = "رقم الفاتورة:";
            // 
            // txt_BillID
            // 
            this.txt_BillID.BorderRadius = 15;
            this.txt_BillID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_BillID.DefaultText = "";
            this.txt_BillID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_BillID.Location = new System.Drawing.Point(750, 71);
            this.txt_BillID.Name = "txt_BillID";
            this.txt_BillID.PlaceholderText = "";
            this.txt_BillID.ReadOnly = true;
            this.txt_BillID.SelectedText = "";
            this.txt_BillID.Size = new System.Drawing.Size(150, 36);
            this.txt_BillID.TabIndex = 1;
            // 
            // lbl_BillDate
            // 
            this.lbl_BillDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_BillDate.Location = new System.Drawing.Point(450, 46);
            this.lbl_BillDate.Name = "lbl_BillDate";
            this.lbl_BillDate.Size = new System.Drawing.Size(100, 20);
            this.lbl_BillDate.TabIndex = 2;
            this.lbl_BillDate.Text = "تاريخ الفاتورة:";
            // 
            // dtp_BillDate
            // 
            this.dtp_BillDate.BorderRadius = 15;
            this.dtp_BillDate.Checked = true;
            this.dtp_BillDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtp_BillDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtp_BillDate.Location = new System.Drawing.Point(450, 71);
            this.dtp_BillDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtp_BillDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtp_BillDate.Name = "dtp_BillDate";
            this.dtp_BillDate.Size = new System.Drawing.Size(250, 36);
            this.dtp_BillDate.TabIndex = 3;
            this.dtp_BillDate.Value = new System.DateTime(2026, 3, 11, 14, 51, 30, 140);
            // 
            // lbl_Supplier
            // 
            this.lbl_Supplier.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_Supplier.Location = new System.Drawing.Point(50, 46);
            this.lbl_Supplier.Name = "lbl_Supplier";
            this.lbl_Supplier.Size = new System.Drawing.Size(100, 20);
            this.lbl_Supplier.TabIndex = 4;
            this.lbl_Supplier.Text = "المورد:";
            // 
            // cmb_Suppliers
            // 
            this.cmb_Suppliers.BackColor = System.Drawing.Color.Transparent;
            this.cmb_Suppliers.BorderRadius = 15;
            this.cmb_Suppliers.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_Suppliers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Suppliers.FocusedColor = System.Drawing.Color.Empty;
            this.cmb_Suppliers.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmb_Suppliers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmb_Suppliers.ItemHeight = 30;
            this.cmb_Suppliers.Location = new System.Drawing.Point(50, 71);
            this.cmb_Suppliers.Name = "cmb_Suppliers";
            this.cmb_Suppliers.Size = new System.Drawing.Size(350, 36);
            this.cmb_Suppliers.TabIndex = 5;
            // 
            // gb_ItemEntry
            // 
            this.gb_ItemEntry.Controls.Add(this.lbl_ItemName);
            this.gb_ItemEntry.Controls.Add(this.txt_ItemName);
            this.gb_ItemEntry.Controls.Add(this.lbl_Qty);
            this.gb_ItemEntry.Controls.Add(this.num_Qty);
            this.gb_ItemEntry.Controls.Add(this.lbl_Price);
            this.gb_ItemEntry.Controls.Add(this.num_Price);
            this.gb_ItemEntry.Controls.Add(this.btn_SaveBill);
            this.gb_ItemEntry.Dock = System.Windows.Forms.DockStyle.Top;
            this.gb_ItemEntry.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gb_ItemEntry.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.gb_ItemEntry.Location = new System.Drawing.Point(0, 167);
            this.gb_ItemEntry.Name = "gb_ItemEntry";
            this.gb_ItemEntry.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gb_ItemEntry.Size = new System.Drawing.Size(950, 142);
            this.gb_ItemEntry.TabIndex = 2;
            this.gb_ItemEntry.Text = "إضافة أصناف للفاتورة";
            this.gb_ItemEntry.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_ItemName
            // 
            this.lbl_ItemName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_ItemName.Location = new System.Drawing.Point(550, 68);
            this.lbl_ItemName.Name = "lbl_ItemName";
            this.lbl_ItemName.Size = new System.Drawing.Size(150, 20);
            this.lbl_ItemName.TabIndex = 0;
            this.lbl_ItemName.Text = "اسم المادة:";
            // 
            // txt_ItemName
            // 
            this.txt_ItemName.BorderRadius = 15;
            this.txt_ItemName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_ItemName.DefaultText = "";
            this.txt_ItemName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_ItemName.Location = new System.Drawing.Point(550, 93);
            this.txt_ItemName.Name = "txt_ItemName";
            this.txt_ItemName.PlaceholderText = "اسم المادة الخام (مثال: دقيق فاخر)";
            this.txt_ItemName.SelectedText = "";
            this.txt_ItemName.Size = new System.Drawing.Size(350, 36);
            this.txt_ItemName.TabIndex = 1;
            // 
            // lbl_Qty
            // 
            this.lbl_Qty.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_Qty.Location = new System.Drawing.Point(400, 68);
            this.lbl_Qty.Name = "lbl_Qty";
            this.lbl_Qty.Size = new System.Drawing.Size(120, 20);
            this.lbl_Qty.TabIndex = 2;
            this.lbl_Qty.Text = "الكمية:";
            // 
            // num_Qty
            // 
            this.num_Qty.BackColor = System.Drawing.Color.Transparent;
            this.num_Qty.BorderRadius = 15;
            this.num_Qty.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.num_Qty.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.num_Qty.Location = new System.Drawing.Point(400, 93);
            this.num_Qty.Name = "num_Qty";
            this.num_Qty.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.num_Qty.Size = new System.Drawing.Size(120, 36);
            this.num_Qty.TabIndex = 3;
            // 
            // lbl_Price
            // 
            this.lbl_Price.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_Price.Location = new System.Drawing.Point(250, 68);
            this.lbl_Price.Name = "lbl_Price";
            this.lbl_Price.Size = new System.Drawing.Size(120, 20);
            this.lbl_Price.TabIndex = 4;
            this.lbl_Price.Text = "سعر الوحدة:";
            // 
            // num_Price
            // 
            this.num_Price.BackColor = System.Drawing.Color.Transparent;
            this.num_Price.BorderRadius = 15;
            this.num_Price.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.num_Price.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.num_Price.Location = new System.Drawing.Point(250, 93);
            this.num_Price.Name = "num_Price";
            this.num_Price.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.num_Price.Size = new System.Drawing.Size(120, 36);
            this.num_Price.TabIndex = 5;
            // 
            // btn_SaveBill
            // 
            this.btn_SaveBill.BorderRadius = 15;
            this.btn_SaveBill.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_SaveBill.ForeColor = System.Drawing.Color.White;
            this.btn_SaveBill.Location = new System.Drawing.Point(75, 89);
            this.btn_SaveBill.Name = "btn_SaveBill";
            this.btn_SaveBill.Size = new System.Drawing.Size(140, 40);
            this.btn_SaveBill.TabIndex = 6;
            this.btn_SaveBill.Text = "حفظ الصنف";
            // 
            // dgv_BillDetails
            // 
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.dgv_BillDetails.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_BillDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_BillDetails.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgv_BillDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_BillDetails.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_BillDetails.Location = new System.Drawing.Point(0, 309);
            this.dgv_BillDetails.Name = "dgv_BillDetails";
            this.dgv_BillDetails.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgv_BillDetails.RowHeadersVisible = false;
            this.dgv_BillDetails.Size = new System.Drawing.Size(950, 311);
            this.dgv_BillDetails.TabIndex = 0;
            this.dgv_BillDetails.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_BillDetails.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_BillDetails.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_BillDetails.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_BillDetails.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_BillDetails.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv_BillDetails.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_BillDetails.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgv_BillDetails.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_BillDetails.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_BillDetails.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_BillDetails.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_BillDetails.ThemeStyle.HeaderStyle.Height = 23;
            this.dgv_BillDetails.ThemeStyle.ReadOnly = false;
            this.dgv_BillDetails.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_BillDetails.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_BillDetails.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_BillDetails.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_BillDetails.ThemeStyle.RowsStyle.Height = 22;
            this.dgv_BillDetails.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_BillDetails.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // pnl_Footer
            // 
            this.pnl_Footer.Controls.Add(this.lbl_Total);
            this.pnl_Footer.Controls.Add(this.txt_TotalBill);
            this.pnl_Footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_Footer.Location = new System.Drawing.Point(0, 620);
            this.pnl_Footer.Name = "pnl_Footer";
            this.pnl_Footer.Size = new System.Drawing.Size(950, 80);
            this.pnl_Footer.TabIndex = 1;
            // 
            // lbl_Total
            // 
            this.lbl_Total.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_Total.Location = new System.Drawing.Point(350, 25);
            this.lbl_Total.Name = "lbl_Total";
            this.lbl_Total.Size = new System.Drawing.Size(100, 23);
            this.lbl_Total.TabIndex = 0;
            this.lbl_Total.Text = "إجمالي الفاتورة:";
            // 
            // txt_TotalBill
            // 
            this.txt_TotalBill.BorderRadius = 15;
            this.txt_TotalBill.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_TotalBill.DefaultText = "";
            this.txt_TotalBill.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_TotalBill.Location = new System.Drawing.Point(96, 20);
            this.txt_TotalBill.Name = "txt_TotalBill";
            this.txt_TotalBill.PlaceholderText = "";
            this.txt_TotalBill.ReadOnly = true;
            this.txt_TotalBill.SelectedText = "";
            this.txt_TotalBill.Size = new System.Drawing.Size(234, 40);
            this.txt_TotalBill.TabIndex = 1;
            // 
            // btn_Minimize
            // 
            this.btn_Minimize.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btn_Minimize.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Minimize.ForeColor = System.Drawing.Color.White;
            this.btn_Minimize.Location = new System.Drawing.Point(50, 8);
            this.btn_Minimize.Name = "btn_Minimize";
            this.btn_Minimize.Size = new System.Drawing.Size(30, 30);
            this.btn_Minimize.TabIndex = 2;
            this.btn_Minimize.Text = "—";
            this.btn_Minimize.TextOffset = new System.Drawing.Point(0, -2);
            // 
            // FRM_PURCHASES
            // 
            this.ClientSize = new System.Drawing.Size(950, 700);
            this.Controls.Add(this.dgv_BillDetails);
            this.Controls.Add(this.pnl_Footer);
            this.Controls.Add(this.gb_ItemEntry);
            this.Controls.Add(this.gb_BillInfo);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_PURCHASES";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.pnlHeader.ResumeLayout(false);
            this.gb_BillInfo.ResumeLayout(false);
            this.gb_ItemEntry.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.num_Qty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Price)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BillDetails)).EndInit();
            this.pnl_Footer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2CircleButton btn_Close;
        private Guna.UI2.WinForms.Guna2GroupBox gb_BillInfo;
        private Guna.UI2.WinForms.Guna2TextBox txt_BillID;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtp_BillDate;
        private Guna.UI2.WinForms.Guna2ComboBox cmb_Suppliers;
        private Guna.UI2.WinForms.Guna2GroupBox gb_ItemEntry;
        private Guna.UI2.WinForms.Guna2TextBox txt_ItemName;
        private Guna.UI2.WinForms.Guna2NumericUpDown num_Qty;
        private Guna.UI2.WinForms.Guna2NumericUpDown num_Price;
        private Guna.UI2.WinForms.Guna2DataGridView dgv_BillDetails;
        private System.Windows.Forms.Panel pnl_Footer;
        private System.Windows.Forms.Label lbl_Total;
        private Guna.UI2.WinForms.Guna2TextBox txt_TotalBill;
        private Guna.UI2.WinForms.Guna2Button btn_SaveBill;
        private System.Windows.Forms.Label lbl_BillID;
        private System.Windows.Forms.Label lbl_BillDate;
        private System.Windows.Forms.Label lbl_Supplier;
        private System.Windows.Forms.Label lbl_ItemName;
        private System.Windows.Forms.Label lbl_Qty;
        private System.Windows.Forms.Label lbl_Price;
        private Guna.UI2.WinForms.Guna2CircleButton btn_Minimize;
    }
}