namespace Al_Aman_Bakery_System.PL
{
    partial class FRM_RAW_PRODUCTION
    {
        // 1. التعريفات الأساسية (المتغيرات)
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2TextBox txt_ProdName;
        private Guna.UI2.WinForms.Guna2NumericUpDown num_TotalWeight;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtp_ProdDate;
        private Guna.UI2.WinForms.Guna2Button btn_Save, btn_Edit, btn_New, btn_Delete;
        private Guna.UI2.WinForms.Guna2TextBox txt_Search;
        private Guna.UI2.WinForms.Guna2Button btn_Search;
        private Guna.UI2.WinForms.Guna2DataGridView dgv_RawLog;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txt_ProdName = new Guna.UI2.WinForms.Guna2TextBox();
            this.num_TotalWeight = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.dtp_ProdDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btn_Save = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Edit = new Guna.UI2.WinForms.Guna2Button();
            this.txt_Search = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_Search = new Guna.UI2.WinForms.Guna2Button();
            this.dgv_RawLog = new Guna.UI2.WinForms.Guna2DataGridView();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_TotalWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_RawLog)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(900, 50);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(600, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(269, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "تسجيل إنتاج الخبز الخام (بيت النار)";
            // 
            // txt_ProdName
            // 
            this.txt_ProdName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_ProdName.DefaultText = "";
            this.txt_ProdName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_ProdName.Location = new System.Drawing.Point(600, 80);
            this.txt_ProdName.Name = "txt_ProdName";
            this.txt_ProdName.PlaceholderText = "اسم الصنف المنتج (مثال: عجين فينو)";
            this.txt_ProdName.SelectedText = "";
            this.txt_ProdName.Size = new System.Drawing.Size(260, 36);
            this.txt_ProdName.TabIndex = 1;
            // 
            // num_TotalWeight
            // 
            this.num_TotalWeight.BackColor = System.Drawing.Color.Transparent;
            this.num_TotalWeight.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.num_TotalWeight.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.num_TotalWeight.Location = new System.Drawing.Point(600, 130);
            this.num_TotalWeight.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.num_TotalWeight.Name = "num_TotalWeight";
            this.num_TotalWeight.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.num_TotalWeight.Size = new System.Drawing.Size(260, 36);
            this.num_TotalWeight.TabIndex = 2;
            // 
            // dtp_ProdDate
            // 
            this.dtp_ProdDate.Checked = true;
            this.dtp_ProdDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtp_ProdDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtp_ProdDate.Location = new System.Drawing.Point(600, 180);
            this.dtp_ProdDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtp_ProdDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtp_ProdDate.Name = "dtp_ProdDate";
            this.dtp_ProdDate.Size = new System.Drawing.Size(260, 36);
            this.dtp_ProdDate.TabIndex = 3;
            this.dtp_ProdDate.Value = new System.DateTime(2026, 3, 13, 19, 31, 9, 844);
            // 
            // btn_Save
            // 
            this.btn_Save.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btn_Save.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Save.ForeColor = System.Drawing.Color.White;
            this.btn_Save.Location = new System.Drawing.Point(740, 240);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(120, 40);
            this.btn_Save.TabIndex = 4;
            this.btn_Save.Text = "حفظ (إضافة)";
            // 
            // btn_Edit
            // 
            this.btn_Edit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btn_Edit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Edit.ForeColor = System.Drawing.Color.White;
            this.btn_Edit.Location = new System.Drawing.Point(600, 240);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(120, 40);
            this.btn_Edit.TabIndex = 5;
            this.btn_Edit.Text = "تعديل";
            // 
            // txt_Search
            // 
            this.txt_Search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Search.DefaultText = "";
            this.txt_Search.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_Search.Location = new System.Drawing.Point(150, 70);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.PlaceholderText = "بحث باسم الصنف...";
            this.txt_Search.SelectedText = "";
            this.txt_Search.Size = new System.Drawing.Size(250, 36);
            this.txt_Search.TabIndex = 6;
            // 
            // btn_Search
            // 
            this.btn_Search.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Search.ForeColor = System.Drawing.Color.White;
            this.btn_Search.Location = new System.Drawing.Point(30, 70);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(110, 36);
            this.btn_Search.TabIndex = 7;
            this.btn_Search.Text = "بحث";
            // 
            // dgv_RawLog
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgv_RawLog.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_RawLog.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_RawLog.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_RawLog.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_RawLog.Location = new System.Drawing.Point(30, 120);
            this.dgv_RawLog.Name = "dgv_RawLog";
            this.dgv_RawLog.RowHeadersVisible = false;
            this.dgv_RawLog.Size = new System.Drawing.Size(540, 380);
            this.dgv_RawLog.TabIndex = 8;
            this.dgv_RawLog.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_RawLog.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_RawLog.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_RawLog.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_RawLog.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_RawLog.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv_RawLog.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_RawLog.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgv_RawLog.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_RawLog.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_RawLog.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_RawLog.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_RawLog.ThemeStyle.HeaderStyle.Height = 23;
            this.dgv_RawLog.ThemeStyle.ReadOnly = false;
            this.dgv_RawLog.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_RawLog.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_RawLog.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_RawLog.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_RawLog.ThemeStyle.RowsStyle.Height = 22;
            this.dgv_RawLog.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_RawLog.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // FRM_RAW_PRODUCTION
            // 
            this.ClientSize = new System.Drawing.Size(900, 550);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.txt_ProdName);
            this.Controls.Add(this.num_TotalWeight);
            this.Controls.Add(this.dtp_ProdDate);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.txt_Search);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.dgv_RawLog);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_RAW_PRODUCTION";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_TotalWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_RawLog)).EndInit();
            this.ResumeLayout(false);

        }
    }
}