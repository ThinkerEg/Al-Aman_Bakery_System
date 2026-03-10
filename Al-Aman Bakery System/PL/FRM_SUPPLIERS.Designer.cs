namespace Al_Aman_Bakery_System.PL
{
    partial class FRM_SUPPLIERS
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

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_SUPPLIERS));
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btn_Minimize = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btn_Close = new Guna.UI2.WinForms.Guna2CircleButton();
            this.groupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.num_SuppBalance = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.rb_OnHim = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rb_ForHim = new Guna.UI2.WinForms.Guna2RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Edit = new Guna.UI2.WinForms.Guna2Button();
            this.btn_New = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Add = new Guna.UI2.WinForms.Guna2Button();
            this.txt_SuppAddress = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_SuppPhone = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_SuppName = new Guna.UI2.WinForms.Guna2TextBox();
            this.dgv_Suppliers = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.lblSearchSuppName = new System.Windows.Forms.Label();
            this.lblSearchPhone = new System.Windows.Forms.Label();
            this.lblSearchAddress = new System.Windows.Forms.Label();
            this.btn_Search = new Guna.UI2.WinForms.Guna2Button();
            this.txt_SearchAddress = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_SearchPhone = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_SearchName = new Guna.UI2.WinForms.Guna2TextBox();
            this.pnlHeader.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_SuppBalance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Suppliers)).BeginInit();
            this.guna2GroupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Controls.Add(this.btn_Minimize);
            this.pnlHeader.Controls.Add(this.btn_Close);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(878, 50);
            this.pnlHeader.TabIndex = 2;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(320, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(170, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "إدارة بيانات الموردين";
            // 
            // btn_Minimize
            // 
            this.btn_Minimize.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btn_Minimize.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Minimize.ForeColor = System.Drawing.Color.White;
            this.btn_Minimize.Location = new System.Drawing.Point(50, 10);
            this.btn_Minimize.Name = "btn_Minimize";
            this.btn_Minimize.Size = new System.Drawing.Size(30, 30);
            this.btn_Minimize.TabIndex = 1;
            this.btn_Minimize.Text = "—";
            this.btn_Minimize.TextOffset = new System.Drawing.Point(0, -2);
            this.btn_Minimize.Click += new System.EventHandler(this.btn_Minimize_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.btn_Close.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btn_Close.ForeColor = System.Drawing.Color.White;
            this.btn_Close.Location = new System.Drawing.Point(10, 10);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(30, 30);
            this.btn_Close.TabIndex = 2;
            this.btn_Close.Text = "X";
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.num_SuppBalance);
            this.groupBox1.Controls.Add(this.rb_OnHim);
            this.groupBox1.Controls.Add(this.rb_ForHim);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btn_Edit);
            this.groupBox1.Controls.Add(this.btn_New);
            this.groupBox1.Controls.Add(this.btn_Add);
            this.groupBox1.Controls.Add(this.txt_SuppAddress);
            this.groupBox1.Controls.Add(this.txt_SuppPhone);
            this.groupBox1.Controls.Add(this.txt_SuppName);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.groupBox1.Location = new System.Drawing.Point(534, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(344, 550);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.Text = "بيانات المورد";
            this.groupBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // num_SuppBalance
            // 
            this.num_SuppBalance.BackColor = System.Drawing.Color.Transparent;
            this.num_SuppBalance.BorderRadius = 15;
            this.num_SuppBalance.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.num_SuppBalance.FillColor = System.Drawing.Color.WhiteSmoke;
            this.num_SuppBalance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_SuppBalance.Location = new System.Drawing.Point(221, 351);
            this.num_SuppBalance.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.num_SuppBalance.Name = "num_SuppBalance";
            this.num_SuppBalance.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.num_SuppBalance.Size = new System.Drawing.Size(100, 36);
            this.num_SuppBalance.TabIndex = 7;
            // 
            // rb_OnHim
            // 
            this.rb_OnHim.AutoSize = true;
            this.rb_OnHim.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rb_OnHim.CheckedState.BorderThickness = 0;
            this.rb_OnHim.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rb_OnHim.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rb_OnHim.CheckedState.InnerOffset = -4;
            this.rb_OnHim.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_OnHim.Location = new System.Drawing.Point(91, 288);
            this.rb_OnHim.Name = "rb_OnHim";
            this.rb_OnHim.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rb_OnHim.Size = new System.Drawing.Size(94, 19);
            this.rb_OnHim.TabIndex = 13;
            this.rb_OnHim.Text = "عليه (مديونية)";
            this.rb_OnHim.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rb_OnHim.UncheckedState.BorderThickness = 2;
            this.rb_OnHim.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rb_OnHim.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // rb_ForHim
            // 
            this.rb_ForHim.AutoSize = true;
            this.rb_ForHim.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rb_ForHim.CheckedState.BorderThickness = 0;
            this.rb_ForHim.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rb_ForHim.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rb_ForHim.CheckedState.InnerOffset = -4;
            this.rb_ForHim.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_ForHim.Location = new System.Drawing.Point(227, 288);
            this.rb_ForHim.Name = "rb_ForHim";
            this.rb_ForHim.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rb_ForHim.Size = new System.Drawing.Size(94, 19);
            this.rb_ForHim.TabIndex = 12;
            this.rb_ForHim.Text = "له (مستحقات)";
            this.rb_ForHim.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rb_ForHim.UncheckedState.BorderThickness = 2;
            this.rb_ForHim.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rb_ForHim.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(237, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "اسم المورد:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(238, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "رقم الهاتف:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(261, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "العنوان:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(263, 327);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "الرصيد:";
            // 
            // btn_Edit
            // 
            this.btn_Edit.BorderRadius = 18;
            this.btn_Edit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btn_Edit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Edit.ForeColor = System.Drawing.Color.White;
            this.btn_Edit.Location = new System.Drawing.Point(119, 418);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(106, 40);
            this.btn_Edit.TabIndex = 4;
            this.btn_Edit.Text = "تعديل";
            // 
            // btn_New
            // 
            this.btn_New.BorderRadius = 18;
            this.btn_New.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.btn_New.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_New.ForeColor = System.Drawing.Color.White;
            this.btn_New.Location = new System.Drawing.Point(11, 418);
            this.btn_New.Name = "btn_New";
            this.btn_New.Size = new System.Drawing.Size(106, 40);
            this.btn_New.TabIndex = 5;
            this.btn_New.Text = "جديد";
            // 
            // btn_Add
            // 
            this.btn_Add.BorderRadius = 18;
            this.btn_Add.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btn_Add.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Add.ForeColor = System.Drawing.Color.White;
            this.btn_Add.Location = new System.Drawing.Point(228, 418);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(106, 40);
            this.btn_Add.TabIndex = 6;
            this.btn_Add.Text = "إضافة";
            // 
            // txt_SuppAddress
            // 
            this.txt_SuppAddress.BorderRadius = 15;
            this.txt_SuppAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_SuppAddress.DefaultText = "";
            this.txt_SuppAddress.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_SuppAddress.Location = new System.Drawing.Point(25, 148);
            this.txt_SuppAddress.Name = "txt_SuppAddress";
            this.txt_SuppAddress.PlaceholderText = "";
            this.txt_SuppAddress.SelectedText = "";
            this.txt_SuppAddress.Size = new System.Drawing.Size(296, 36);
            this.txt_SuppAddress.TabIndex = 8;
            this.txt_SuppAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_SuppPhone
            // 
            this.txt_SuppPhone.BorderRadius = 15;
            this.txt_SuppPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_SuppPhone.DefaultText = "";
            this.txt_SuppPhone.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_SuppPhone.Location = new System.Drawing.Point(121, 218);
            this.txt_SuppPhone.Name = "txt_SuppPhone";
            this.txt_SuppPhone.PlaceholderText = "";
            this.txt_SuppPhone.SelectedText = "";
            this.txt_SuppPhone.Size = new System.Drawing.Size(200, 36);
            this.txt_SuppPhone.TabIndex = 9;
            this.txt_SuppPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_SuppName
            // 
            this.txt_SuppName.BorderRadius = 15;
            this.txt_SuppName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_SuppName.DefaultText = "";
            this.txt_SuppName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_SuppName.Location = new System.Drawing.Point(21, 79);
            this.txt_SuppName.Name = "txt_SuppName";
            this.txt_SuppName.PlaceholderText = "";
            this.txt_SuppName.SelectedText = "";
            this.txt_SuppName.Size = new System.Drawing.Size(300, 36);
            this.txt_SuppName.TabIndex = 10;
            this.txt_SuppName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dgv_Suppliers
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.dgv_Suppliers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Suppliers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Suppliers.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_Suppliers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Suppliers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.dgv_Suppliers.Location = new System.Drawing.Point(0, 25);
            this.dgv_Suppliers.Name = "dgv_Suppliers";
            this.dgv_Suppliers.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgv_Suppliers.RowHeadersVisible = false;
            this.dgv_Suppliers.Size = new System.Drawing.Size(534, 342);
            this.dgv_Suppliers.TabIndex = 0;
            this.dgv_Suppliers.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Dark;
            this.dgv_Suppliers.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.dgv_Suppliers.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_Suppliers.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_Suppliers.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_Suppliers.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_Suppliers.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv_Suppliers.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.dgv_Suppliers.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.dgv_Suppliers.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_Suppliers.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.dgv_Suppliers.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_Suppliers.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_Suppliers.ThemeStyle.HeaderStyle.Height = 23;
            this.dgv_Suppliers.ThemeStyle.ReadOnly = false;
            this.dgv_Suppliers.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.dgv_Suppliers.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_Suppliers.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.dgv_Suppliers.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.dgv_Suppliers.ThemeStyle.RowsStyle.Height = 22;
            this.dgv_Suppliers.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            this.dgv_Suppliers.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.pnlHeader;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.Controls.Add(this.panel1);
            this.guna2GroupBox1.Controls.Add(this.lblSearchSuppName);
            this.guna2GroupBox1.Controls.Add(this.lblSearchPhone);
            this.guna2GroupBox1.Controls.Add(this.lblSearchAddress);
            this.guna2GroupBox1.Controls.Add(this.btn_Search);
            this.guna2GroupBox1.Controls.Add(this.txt_SearchAddress);
            this.guna2GroupBox1.Controls.Add(this.txt_SearchPhone);
            this.guna2GroupBox1.Controls.Add(this.txt_SearchName);
            this.guna2GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox1.Location = new System.Drawing.Point(0, 50);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.guna2GroupBox1.Size = new System.Drawing.Size(534, 550);
            this.guna2GroupBox1.TabIndex = 14;
            this.guna2GroupBox1.Text = "بحث وتعديل";
            this.guna2GroupBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgv_Suppliers);
            this.panel1.Controls.Add(this.bindingNavigator1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 183);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(534, 367);
            this.panel1.TabIndex = 12;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(534, 25);
            this.bindingNavigator1.TabIndex = 12;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // lblSearchSuppName
            // 
            this.lblSearchSuppName.AutoSize = true;
            this.lblSearchSuppName.Location = new System.Drawing.Point(444, 49);
            this.lblSearchSuppName.Name = "lblSearchSuppName";
            this.lblSearchSuppName.Size = new System.Drawing.Size(84, 21);
            this.lblSearchSuppName.TabIndex = 0;
            this.lblSearchSuppName.Text = "اسم المورد:";
            // 
            // lblSearchPhone
            // 
            this.lblSearchPhone.AutoSize = true;
            this.lblSearchPhone.Location = new System.Drawing.Point(127, 49);
            this.lblSearchPhone.Name = "lblSearchPhone";
            this.lblSearchPhone.Size = new System.Drawing.Size(83, 21);
            this.lblSearchPhone.TabIndex = 1;
            this.lblSearchPhone.Text = "رقم الهاتف:";
            // 
            // lblSearchAddress
            // 
            this.lblSearchAddress.AutoSize = true;
            this.lblSearchAddress.Location = new System.Drawing.Point(468, 117);
            this.lblSearchAddress.Name = "lblSearchAddress";
            this.lblSearchAddress.Size = new System.Drawing.Size(60, 21);
            this.lblSearchAddress.TabIndex = 2;
            this.lblSearchAddress.Text = "العنوان:";
            // 
            // btn_Search
            // 
            this.btn_Search.BorderRadius = 18;
            this.btn_Search.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btn_Search.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Search.ForeColor = System.Drawing.Color.White;
            this.btn_Search.Location = new System.Drawing.Point(82, 137);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(112, 40);
            this.btn_Search.TabIndex = 4;
            this.btn_Search.Text = "بحث";
            // 
            // txt_SearchAddress
            // 
            this.txt_SearchAddress.BorderRadius = 15;
            this.txt_SearchAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_SearchAddress.DefaultText = "";
            this.txt_SearchAddress.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_SearchAddress.Location = new System.Drawing.Point(228, 141);
            this.txt_SearchAddress.Name = "txt_SearchAddress";
            this.txt_SearchAddress.PlaceholderText = "";
            this.txt_SearchAddress.SelectedText = "";
            this.txt_SearchAddress.Size = new System.Drawing.Size(300, 36);
            this.txt_SearchAddress.TabIndex = 8;
            this.txt_SearchAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_SearchPhone
            // 
            this.txt_SearchPhone.BorderRadius = 15;
            this.txt_SearchPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_SearchPhone.DefaultText = "";
            this.txt_SearchPhone.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_SearchPhone.Location = new System.Drawing.Point(6, 74);
            this.txt_SearchPhone.Name = "txt_SearchPhone";
            this.txt_SearchPhone.PlaceholderText = "";
            this.txt_SearchPhone.SelectedText = "";
            this.txt_SearchPhone.Size = new System.Drawing.Size(200, 36);
            this.txt_SearchPhone.TabIndex = 9;
            this.txt_SearchPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_SearchName
            // 
            this.txt_SearchName.BorderRadius = 15;
            this.txt_SearchName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_SearchName.DefaultText = "";
            this.txt_SearchName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_SearchName.Location = new System.Drawing.Point(228, 74);
            this.txt_SearchName.Name = "txt_SearchName";
            this.txt_SearchName.PlaceholderText = "";
            this.txt_SearchName.SelectedText = "";
            this.txt_SearchName.Size = new System.Drawing.Size(300, 36);
            this.txt_SearchName.TabIndex = 10;
            this.txt_SearchName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FRM_SUPPLIERS
            // 
            this.ClientSize = new System.Drawing.Size(878, 600);
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_SUPPLIERS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FRM_SUPPLIERS_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_SuppBalance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Suppliers)).EndInit();
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2CircleButton btn_Minimize;
        private Guna.UI2.WinForms.Guna2CircleButton btn_Close;
        private Guna.UI2.WinForms.Guna2GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Button btn_Edit;
        private Guna.UI2.WinForms.Guna2Button btn_New;
        private Guna.UI2.WinForms.Guna2Button btn_Add;
        private Guna.UI2.WinForms.Guna2NumericUpDown num_SuppBalance;
        private Guna.UI2.WinForms.Guna2TextBox txt_SuppAddress;
        private Guna.UI2.WinForms.Guna2TextBox txt_SuppPhone;
        private Guna.UI2.WinForms.Guna2TextBox txt_SuppName;
        private Guna.UI2.WinForms.Guna2DataGridView dgv_Suppliers;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2RadioButton rb_OnHim;
        private Guna.UI2.WinForms.Guna2RadioButton rb_ForHim;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private System.Windows.Forms.Label lblSearchSuppName;
        private System.Windows.Forms.Label lblSearchPhone;
        private System.Windows.Forms.Label lblSearchAddress;
        private Guna.UI2.WinForms.Guna2Button btn_Search;
        private Guna.UI2.WinForms.Guna2TextBox txt_SearchAddress;
        private Guna.UI2.WinForms.Guna2TextBox txt_SearchPhone;
        private Guna.UI2.WinForms.Guna2TextBox txt_SearchName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
    }
}