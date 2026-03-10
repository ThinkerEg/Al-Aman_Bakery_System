namespace Al_Aman_Bakery_System.PL
{
    partial class FRM_PRODUCTS
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btn_Close = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btn_Minimize = new Guna.UI2.WinForms.Guna2CircleButton();
            this.groupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.txt_ProdName = new Guna.UI2.WinForms.Guna2TextBox();
            this.num_Weight = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.num_PriceWholesale = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.num_PriceSemi = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.num_PriceRetail = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.btn_Add = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Edit = new Guna.UI2.WinForms.Guna2Button();
            this.btn_New = new Guna.UI2.WinForms.Guna2Button();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.txt_Search = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_Search = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgv_Products = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.pnlHeader.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_Weight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_PriceWholesale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_PriceSemi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_PriceRetail)).BeginInit();
            this.guna2GroupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Products)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Controls.Add(this.btn_Close);
            this.pnlHeader.Controls.Add(this.btn_Minimize);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(842, 50);
            this.pnlHeader.TabIndex = 3;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(263, 17);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(254, 23);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "إدارة منتجات المخبز";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Close
            // 
            this.btn_Close.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.btn_Close.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Close.ForeColor = System.Drawing.Color.White;
            this.btn_Close.Location = new System.Drawing.Point(10, 10);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(30, 30);
            this.btn_Close.TabIndex = 1;
            this.btn_Close.Text = "X";
            // 
            // btn_Minimize
            // 
            this.btn_Minimize.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btn_Minimize.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Minimize.ForeColor = System.Drawing.Color.White;
            this.btn_Minimize.Location = new System.Drawing.Point(50, 10);
            this.btn_Minimize.Name = "btn_Minimize";
            this.btn_Minimize.Size = new System.Drawing.Size(30, 30);
            this.btn_Minimize.TabIndex = 2;
            this.btn_Minimize.Text = "—";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_ProdName);
            this.groupBox1.Controls.Add(this.num_Weight);
            this.groupBox1.Controls.Add(this.num_PriceWholesale);
            this.groupBox1.Controls.Add(this.num_PriceSemi);
            this.groupBox1.Controls.Add(this.num_PriceRetail);
            this.groupBox1.Controls.Add(this.btn_Add);
            this.groupBox1.Controls.Add(this.btn_Edit);
            this.groupBox1.Controls.Add(this.btn_New);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.groupBox1.Location = new System.Drawing.Point(462, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(380, 550);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.Text = "بيانات المنتج";
            this.groupBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_ProdName
            // 
            this.txt_ProdName.BorderRadius = 15;
            this.txt_ProdName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_ProdName.DefaultText = "";
            this.txt_ProdName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_ProdName.Location = new System.Drawing.Point(50, 60);
            this.txt_ProdName.Name = "txt_ProdName";
            this.txt_ProdName.PlaceholderText = "اسم المنتج";
            this.txt_ProdName.SelectedText = "";
            this.txt_ProdName.Size = new System.Drawing.Size(300, 36);
            this.txt_ProdName.TabIndex = 0;
            // 
            // num_Weight
            // 
            this.num_Weight.BackColor = System.Drawing.Color.Transparent;
            this.num_Weight.BorderRadius = 15;
            this.num_Weight.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.num_Weight.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.num_Weight.Location = new System.Drawing.Point(173, 120);
            this.num_Weight.Name = "num_Weight";
            this.num_Weight.Size = new System.Drawing.Size(177, 36);
            this.num_Weight.TabIndex = 1;
            // 
            // num_PriceWholesale
            // 
            this.num_PriceWholesale.BackColor = System.Drawing.Color.Transparent;
            this.num_PriceWholesale.BorderRadius = 15;
            this.num_PriceWholesale.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.num_PriceWholesale.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.num_PriceWholesale.Location = new System.Drawing.Point(173, 180);
            this.num_PriceWholesale.Name = "num_PriceWholesale";
            this.num_PriceWholesale.Size = new System.Drawing.Size(177, 36);
            this.num_PriceWholesale.TabIndex = 2;
            // 
            // num_PriceSemi
            // 
            this.num_PriceSemi.BackColor = System.Drawing.Color.Transparent;
            this.num_PriceSemi.BorderRadius = 15;
            this.num_PriceSemi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.num_PriceSemi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.num_PriceSemi.Location = new System.Drawing.Point(173, 240);
            this.num_PriceSemi.Name = "num_PriceSemi";
            this.num_PriceSemi.Size = new System.Drawing.Size(177, 36);
            this.num_PriceSemi.TabIndex = 3;
            // 
            // num_PriceRetail
            // 
            this.num_PriceRetail.BackColor = System.Drawing.Color.Transparent;
            this.num_PriceRetail.BorderRadius = 15;
            this.num_PriceRetail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.num_PriceRetail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.num_PriceRetail.Location = new System.Drawing.Point(173, 300);
            this.num_PriceRetail.Name = "num_PriceRetail";
            this.num_PriceRetail.Size = new System.Drawing.Size(177, 36);
            this.num_PriceRetail.TabIndex = 4;
            // 
            // btn_Add
            // 
            this.btn_Add.BorderRadius = 18;
            this.btn_Add.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btn_Add.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Add.ForeColor = System.Drawing.Color.White;
            this.btn_Add.Location = new System.Drawing.Point(250, 420);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(100, 40);
            this.btn_Add.TabIndex = 5;
            this.btn_Add.Text = "إضافة";
            // 
            // btn_Edit
            // 
            this.btn_Edit.BorderRadius = 18;
            this.btn_Edit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btn_Edit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Edit.ForeColor = System.Drawing.Color.White;
            this.btn_Edit.Location = new System.Drawing.Point(130, 420);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(100, 40);
            this.btn_Edit.TabIndex = 6;
            this.btn_Edit.Text = "تعديل";
            // 
            // btn_New
            // 
            this.btn_New.BorderRadius = 18;
            this.btn_New.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.btn_New.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_New.ForeColor = System.Drawing.Color.White;
            this.btn_New.Location = new System.Drawing.Point(10, 420);
            this.btn_New.Name = "btn_New";
            this.btn_New.Size = new System.Drawing.Size(100, 40);
            this.btn_New.TabIndex = 7;
            this.btn_New.Text = "جديد";
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.Controls.Add(this.txt_Search);
            this.guna2GroupBox1.Controls.Add(this.btn_Search);
            this.guna2GroupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox1.Location = new System.Drawing.Point(0, 50);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.guna2GroupBox1.Size = new System.Drawing.Size(462, 150);
            this.guna2GroupBox1.TabIndex = 1;
            this.guna2GroupBox1.Text = "البحث";
            this.guna2GroupBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_Search
            // 
            this.txt_Search.BorderRadius = 15;
            this.txt_Search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Search.DefaultText = "";
            this.txt_Search.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_Search.Location = new System.Drawing.Point(120, 60);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.PlaceholderText = "ابحث باسم المنتج...";
            this.txt_Search.SelectedText = "";
            this.txt_Search.Size = new System.Drawing.Size(300, 36);
            this.txt_Search.TabIndex = 0;
            // 
            // btn_Search
            // 
            this.btn_Search.BorderRadius = 18;
            this.btn_Search.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btn_Search.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Search.ForeColor = System.Drawing.Color.White;
            this.btn_Search.Location = new System.Drawing.Point(10, 60);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(100, 40);
            this.btn_Search.TabIndex = 1;
            this.btn_Search.Text = "بحث";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgv_Products);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 200);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(462, 400);
            this.panel1.TabIndex = 0;
            // 
            // dgv_Products
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.dgv_Products.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Products.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Products.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_Products.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Products.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.dgv_Products.Location = new System.Drawing.Point(0, 0);
            this.dgv_Products.Name = "dgv_Products";
            this.dgv_Products.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgv_Products.RowHeadersVisible = false;
            this.dgv_Products.Size = new System.Drawing.Size(462, 400);
            this.dgv_Products.TabIndex = 0;
            this.dgv_Products.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Dark;
            this.dgv_Products.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.dgv_Products.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_Products.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_Products.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_Products.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_Products.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv_Products.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.dgv_Products.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.dgv_Products.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_Products.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_Products.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_Products.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_Products.ThemeStyle.HeaderStyle.Height = 23;
            this.dgv_Products.ThemeStyle.ReadOnly = false;
            this.dgv_Products.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.dgv_Products.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_Products.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_Products.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_Products.ThemeStyle.RowsStyle.Height = 22;
            this.dgv_Products.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            this.dgv_Products.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.pnlHeader;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // FRM_PRODUCTS
            // 
            this.ClientSize = new System.Drawing.Size(842, 600);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_PRODUCTS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.pnlHeader.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.num_Weight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_PriceWholesale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_PriceSemi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_PriceRetail)).EndInit();
            this.guna2GroupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Products)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2CircleButton btn_Minimize;
        private Guna.UI2.WinForms.Guna2CircleButton btn_Close;

        private Guna.UI2.WinForms.Guna2GroupBox groupBox1;
        private Guna.UI2.WinForms.Guna2TextBox txt_ProdName;
        private Guna.UI2.WinForms.Guna2NumericUpDown num_Weight;
        private Guna.UI2.WinForms.Guna2NumericUpDown num_PriceWholesale;
        private Guna.UI2.WinForms.Guna2NumericUpDown num_PriceSemi;
        private Guna.UI2.WinForms.Guna2NumericUpDown num_PriceRetail;

        private Guna.UI2.WinForms.Guna2Button btn_Add;
        private Guna.UI2.WinForms.Guna2Button btn_Edit;
        private Guna.UI2.WinForms.Guna2Button btn_New;

        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2TextBox txt_Search;
        private Guna.UI2.WinForms.Guna2Button btn_Search;

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2DataGridView dgv_Products;

        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
    }
}