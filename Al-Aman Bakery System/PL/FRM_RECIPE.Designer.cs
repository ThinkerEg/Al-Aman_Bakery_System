namespace Al_Aman_Bakery_System.PL
{
    partial class FRM_RECIPE
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btn_Close = new Guna.UI2.WinForms.Guna2CircleButton();
            this.lbl_Product = new System.Windows.Forms.Label();
            this.cmb_Product = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dgv_RecipeDetails = new Guna.UI2.WinForms.Guna2DataGridView();
            this.lbl_Material = new System.Windows.Forms.Label();
            this.cmb_Material = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lbl_Qty = new System.Windows.Forms.Label();
            this.num_Qty = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.btn_AddLine = new Guna.UI2.WinForms.Guna2Button();
            this.btn_SaveRecipe = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Minimize = new Guna.UI2.WinForms.Guna2CircleButton();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_RecipeDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Qty)).BeginInit();
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
            this.pnlHeader.Size = new System.Drawing.Size(800, 60);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(300, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(225, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "ضبط وصفة إنتاج المنتج";
            // 
            // btn_Close
            // 
            this.btn_Close.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.btn_Close.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Close.ForeColor = System.Drawing.Color.White;
            this.btn_Close.Location = new System.Drawing.Point(10, 15);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(30, 30);
            this.btn_Close.TabIndex = 1;
            this.btn_Close.Text = "X";
            // 
            // lbl_Product
            // 
            this.lbl_Product.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lbl_Product.Location = new System.Drawing.Point(50, 80);
            this.lbl_Product.Name = "lbl_Product";
            this.lbl_Product.Size = new System.Drawing.Size(100, 23);
            this.lbl_Product.TabIndex = 1;
            this.lbl_Product.Text = "اختر المنتج:";
            // 
            // cmb_Product
            // 
            this.cmb_Product.BackColor = System.Drawing.Color.Transparent;
            this.cmb_Product.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_Product.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Product.FocusedColor = System.Drawing.Color.Empty;
            this.cmb_Product.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmb_Product.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmb_Product.ItemHeight = 30;
            this.cmb_Product.Location = new System.Drawing.Point(50, 105);
            this.cmb_Product.Name = "cmb_Product";
            this.cmb_Product.Size = new System.Drawing.Size(300, 36);
            this.cmb_Product.TabIndex = 2;
            // 
            // dgv_RecipeDetails
            // 
            this.dgv_RecipeDetails.AllowUserToAddRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgv_RecipeDetails.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_RecipeDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_RecipeDetails.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_RecipeDetails.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_RecipeDetails.Location = new System.Drawing.Point(50, 160);
            this.dgv_RecipeDetails.Name = "dgv_RecipeDetails";
            this.dgv_RecipeDetails.RowHeadersVisible = false;
            this.dgv_RecipeDetails.Size = new System.Drawing.Size(700, 280);
            this.dgv_RecipeDetails.TabIndex = 3;
            this.dgv_RecipeDetails.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_RecipeDetails.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_RecipeDetails.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_RecipeDetails.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_RecipeDetails.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_RecipeDetails.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv_RecipeDetails.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_RecipeDetails.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgv_RecipeDetails.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_RecipeDetails.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_RecipeDetails.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_RecipeDetails.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_RecipeDetails.ThemeStyle.HeaderStyle.Height = 23;
            this.dgv_RecipeDetails.ThemeStyle.ReadOnly = false;
            this.dgv_RecipeDetails.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_RecipeDetails.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_RecipeDetails.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_RecipeDetails.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_RecipeDetails.ThemeStyle.RowsStyle.Height = 22;
            this.dgv_RecipeDetails.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_RecipeDetails.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // lbl_Material
            // 
            this.lbl_Material.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lbl_Material.Location = new System.Drawing.Point(50, 460);
            this.lbl_Material.Name = "lbl_Material";
            this.lbl_Material.Size = new System.Drawing.Size(100, 23);
            this.lbl_Material.TabIndex = 4;
            this.lbl_Material.Text = "اختر المادة الخام:";
            // 
            // cmb_Material
            // 
            this.cmb_Material.BackColor = System.Drawing.Color.Transparent;
            this.cmb_Material.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_Material.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Material.FocusedColor = System.Drawing.Color.Empty;
            this.cmb_Material.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmb_Material.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmb_Material.ItemHeight = 30;
            this.cmb_Material.Location = new System.Drawing.Point(50, 485);
            this.cmb_Material.Name = "cmb_Material";
            this.cmb_Material.Size = new System.Drawing.Size(250, 36);
            this.cmb_Material.TabIndex = 5;
            // 
            // lbl_Qty
            // 
            this.lbl_Qty.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lbl_Qty.Location = new System.Drawing.Point(320, 460);
            this.lbl_Qty.Name = "lbl_Qty";
            this.lbl_Qty.Size = new System.Drawing.Size(100, 23);
            this.lbl_Qty.TabIndex = 6;
            this.lbl_Qty.Text = "الكمية:";
            // 
            // num_Qty
            // 
            this.num_Qty.BackColor = System.Drawing.Color.Transparent;
            this.num_Qty.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.num_Qty.DecimalPlaces = 2;
            this.num_Qty.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.num_Qty.Location = new System.Drawing.Point(320, 485);
            this.num_Qty.Name = "num_Qty";
            this.num_Qty.Size = new System.Drawing.Size(100, 36);
            this.num_Qty.TabIndex = 7;
            // 
            // btn_AddLine
            // 
            this.btn_AddLine.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_AddLine.ForeColor = System.Drawing.Color.White;
            this.btn_AddLine.Location = new System.Drawing.Point(450, 485);
            this.btn_AddLine.Name = "btn_AddLine";
            this.btn_AddLine.Size = new System.Drawing.Size(150, 36);
            this.btn_AddLine.TabIndex = 8;
            this.btn_AddLine.Text = "إضافة خامة";
            // 
            // btn_SaveRecipe
            // 
            this.btn_SaveRecipe.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btn_SaveRecipe.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_SaveRecipe.ForeColor = System.Drawing.Color.White;
            this.btn_SaveRecipe.Location = new System.Drawing.Point(300, 540);
            this.btn_SaveRecipe.Name = "btn_SaveRecipe";
            this.btn_SaveRecipe.Size = new System.Drawing.Size(200, 45);
            this.btn_SaveRecipe.TabIndex = 9;
            this.btn_SaveRecipe.Text = "حفظ الوصفة";
            // 
            // btn_Minimize
            // 
            this.btn_Minimize.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btn_Minimize.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Minimize.ForeColor = System.Drawing.Color.White;
            this.btn_Minimize.Location = new System.Drawing.Point(50, 15);
            this.btn_Minimize.Name = "btn_Minimize";
            this.btn_Minimize.Size = new System.Drawing.Size(30, 30);
            this.btn_Minimize.TabIndex = 3;
            this.btn_Minimize.Text = "—";
            this.btn_Minimize.TextOffset = new System.Drawing.Point(0, -2);
            // 
            // FRM_RECIPE
            // 
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.lbl_Product);
            this.Controls.Add(this.cmb_Product);
            this.Controls.Add(this.dgv_RecipeDetails);
            this.Controls.Add(this.lbl_Material);
            this.Controls.Add(this.cmb_Material);
            this.Controls.Add(this.lbl_Qty);
            this.Controls.Add(this.num_Qty);
            this.Controls.Add(this.btn_AddLine);
            this.Controls.Add(this.btn_SaveRecipe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_RECIPE";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_RecipeDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Qty)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2CircleButton btn_Close;

        private System.Windows.Forms.Label lbl_Product;
        private Guna.UI2.WinForms.Guna2ComboBox cmb_Product;

        private Guna.UI2.WinForms.Guna2DataGridView dgv_RecipeDetails;

        private System.Windows.Forms.Label lbl_Material;
        private Guna.UI2.WinForms.Guna2ComboBox cmb_Material;

        private System.Windows.Forms.Label lbl_Qty;
        private Guna.UI2.WinForms.Guna2NumericUpDown num_Qty;

        private Guna.UI2.WinForms.Guna2Button btn_AddLine;
        private Guna.UI2.WinForms.Guna2Button btn_SaveRecipe;
        private Guna.UI2.WinForms.Guna2CircleButton btn_Minimize;
    }
}