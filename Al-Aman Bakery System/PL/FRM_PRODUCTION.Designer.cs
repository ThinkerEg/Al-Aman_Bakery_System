namespace Al_Aman_Bakery_System.PL
{
    partial class FRM_PRODUCTION
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btn_Close = new Guna.UI2.WinForms.Guna2CircleButton();
            this.dgv_ProductionMaterials = new Guna.UI2.WinForms.Guna2DataGridView();
            this.cmb_Material = new Guna.UI2.WinForms.Guna2ComboBox();
            this.num_QtyToUse = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.btn_AddMaterial = new Guna.UI2.WinForms.Guna2Button();
            this.lblMaterial = new System.Windows.Forms.Label();
            this.lblQty = new System.Windows.Forms.Label();
            this.pnlSummary = new System.Windows.Forms.Panel();
            this.lblTotalResult = new System.Windows.Forms.Label();
            this.num_FinalWeight = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.lblWeightNote = new System.Windows.Forms.Label();
            this.btn_SaveProduction = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Minimize = new Guna.UI2.WinForms.Guna2CircleButton();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ProductionMaterials)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_QtyToUse)).BeginInit();
            this.pnlSummary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_FinalWeight)).BeginInit();
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
            this.pnlHeader.Size = new System.Drawing.Size(850, 50);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(560, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTitle.Size = new System.Drawing.Size(278, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "عملية الإنتاج (سحب خامات -> خبز)";
            // 
            // btn_Close
            // 
            this.btn_Close.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btn_Close.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Close.ForeColor = System.Drawing.Color.White;
            this.btn_Close.Location = new System.Drawing.Point(12, 10);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(30, 30);
            this.btn_Close.TabIndex = 1;
            this.btn_Close.Text = "X";
            // 
            // dgv_ProductionMaterials
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.dgv_ProductionMaterials.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_ProductionMaterials.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_ProductionMaterials.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgv_ProductionMaterials.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_ProductionMaterials.Location = new System.Drawing.Point(40, 150);
            this.dgv_ProductionMaterials.Name = "dgv_ProductionMaterials";
            this.dgv_ProductionMaterials.RowHeadersVisible = false;
            this.dgv_ProductionMaterials.Size = new System.Drawing.Size(770, 280);
            this.dgv_ProductionMaterials.TabIndex = 6;
            this.dgv_ProductionMaterials.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_ProductionMaterials.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_ProductionMaterials.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_ProductionMaterials.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_ProductionMaterials.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_ProductionMaterials.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv_ProductionMaterials.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_ProductionMaterials.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgv_ProductionMaterials.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_ProductionMaterials.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_ProductionMaterials.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_ProductionMaterials.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_ProductionMaterials.ThemeStyle.HeaderStyle.Height = 23;
            this.dgv_ProductionMaterials.ThemeStyle.ReadOnly = false;
            this.dgv_ProductionMaterials.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_ProductionMaterials.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_ProductionMaterials.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_ProductionMaterials.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_ProductionMaterials.ThemeStyle.RowsStyle.Height = 22;
            this.dgv_ProductionMaterials.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_ProductionMaterials.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // cmb_Material
            // 
            this.cmb_Material.BackColor = System.Drawing.Color.Transparent;
            this.cmb_Material.BorderRadius = 15;
            this.cmb_Material.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_Material.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Material.FocusedColor = System.Drawing.Color.Empty;
            this.cmb_Material.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmb_Material.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmb_Material.ItemHeight = 30;
            this.cmb_Material.Location = new System.Drawing.Point(520, 95);
            this.cmb_Material.Name = "cmb_Material";
            this.cmb_Material.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmb_Material.Size = new System.Drawing.Size(280, 36);
            this.cmb_Material.TabIndex = 2;
            // 
            // num_QtyToUse
            // 
            this.num_QtyToUse.BackColor = System.Drawing.Color.Transparent;
            this.num_QtyToUse.BorderRadius = 15;
            this.num_QtyToUse.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.num_QtyToUse.DecimalPlaces = 2;
            this.num_QtyToUse.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.num_QtyToUse.Location = new System.Drawing.Point(300, 95);
            this.num_QtyToUse.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.num_QtyToUse.Name = "num_QtyToUse";
            this.num_QtyToUse.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.num_QtyToUse.Size = new System.Drawing.Size(150, 36);
            this.num_QtyToUse.TabIndex = 4;
            // 
            // btn_AddMaterial
            // 
            this.btn_AddMaterial.BorderRadius = 15;
            this.btn_AddMaterial.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btn_AddMaterial.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_AddMaterial.ForeColor = System.Drawing.Color.White;
            this.btn_AddMaterial.Location = new System.Drawing.Point(80, 95);
            this.btn_AddMaterial.Name = "btn_AddMaterial";
            this.btn_AddMaterial.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_AddMaterial.Size = new System.Drawing.Size(180, 36);
            this.btn_AddMaterial.TabIndex = 5;
            this.btn_AddMaterial.Text = "إضافة للطبخة";
            // 
            // lblMaterial
            // 
            this.lblMaterial.AutoSize = true;
            this.lblMaterial.Location = new System.Drawing.Point(740, 70);
            this.lblMaterial.Name = "lblMaterial";
            this.lblMaterial.Size = new System.Drawing.Size(104, 13);
            this.lblMaterial.TabIndex = 1;
            this.lblMaterial.Text = "اختر الخامة المسحوبة:";
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.Location = new System.Drawing.Point(400, 70);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(71, 13);
            this.lblQty.TabIndex = 3;
            this.lblQty.Text = "الكمية بالجرام:";
            // 
            // pnlSummary
            // 
            this.pnlSummary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.pnlSummary.Controls.Add(this.lblTotalResult);
            this.pnlSummary.Controls.Add(this.num_FinalWeight);
            this.pnlSummary.Controls.Add(this.lblWeightNote);
            this.pnlSummary.Location = new System.Drawing.Point(40, 445);
            this.pnlSummary.Name = "pnlSummary";
            this.pnlSummary.Size = new System.Drawing.Size(770, 100);
            this.pnlSummary.TabIndex = 7;
            // 
            // lblTotalResult
            // 
            this.lblTotalResult.AutoSize = true;
            this.lblTotalResult.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotalResult.Location = new System.Drawing.Point(520, 35);
            this.lblTotalResult.Name = "lblTotalResult";
            this.lblTotalResult.Size = new System.Drawing.Size(216, 21);
            this.lblTotalResult.TabIndex = 0;
            this.lblTotalResult.Text = "إجمالي وزن الخبز الناتج (بالجرام):";
            // 
            // num_FinalWeight
            // 
            this.num_FinalWeight.BackColor = System.Drawing.Color.Transparent;
            this.num_FinalWeight.BorderRadius = 15;
            this.num_FinalWeight.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.num_FinalWeight.DecimalPlaces = 2;
            this.num_FinalWeight.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.num_FinalWeight.Location = new System.Drawing.Point(300, 30);
            this.num_FinalWeight.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.num_FinalWeight.Name = "num_FinalWeight";
            this.num_FinalWeight.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.num_FinalWeight.Size = new System.Drawing.Size(200, 45);
            this.num_FinalWeight.TabIndex = 1;
            // 
            // lblWeightNote
            // 
            this.lblWeightNote.ForeColor = System.Drawing.Color.Gray;
            this.lblWeightNote.Location = new System.Drawing.Point(20, 35);
            this.lblWeightNote.Name = "lblWeightNote";
            this.lblWeightNote.Size = new System.Drawing.Size(250, 40);
            this.lblWeightNote.TabIndex = 2;
            this.lblWeightNote.Text = "* سيتم حساب الهالك تلقائياً بناءً على وزن الخامات.";
            // 
            // btn_SaveProduction
            // 
            this.btn_SaveProduction.BorderRadius = 15;
            this.btn_SaveProduction.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btn_SaveProduction.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn_SaveProduction.ForeColor = System.Drawing.Color.White;
            this.btn_SaveProduction.Location = new System.Drawing.Point(325, 560);
            this.btn_SaveProduction.Name = "btn_SaveProduction";
            this.btn_SaveProduction.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_SaveProduction.Size = new System.Drawing.Size(200, 50);
            this.btn_SaveProduction.TabIndex = 8;
            this.btn_SaveProduction.Text = "إتمام عملية الخبز";
            // 
            // btn_Minimize
            // 
            this.btn_Minimize.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btn_Minimize.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Minimize.ForeColor = System.Drawing.Color.White;
            this.btn_Minimize.Location = new System.Drawing.Point(48, 10);
            this.btn_Minimize.Name = "btn_Minimize";
            this.btn_Minimize.Size = new System.Drawing.Size(30, 30);
            this.btn_Minimize.TabIndex = 4;
            this.btn_Minimize.Text = "—";
            this.btn_Minimize.TextOffset = new System.Drawing.Point(0, -2);
            // 
            // FRM_PRODUCTION
            // 
            this.ClientSize = new System.Drawing.Size(850, 630);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.lblMaterial);
            this.Controls.Add(this.cmb_Material);
            this.Controls.Add(this.lblQty);
            this.Controls.Add(this.num_QtyToUse);
            this.Controls.Add(this.btn_AddMaterial);
            this.Controls.Add(this.dgv_ProductionMaterials);
            this.Controls.Add(this.pnlSummary);
            this.Controls.Add(this.btn_SaveProduction);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_PRODUCTION";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ProductionMaterials)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_QtyToUse)).EndInit();
            this.pnlSummary.ResumeLayout(false);
            this.pnlSummary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_FinalWeight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2CircleButton btn_Close;
        private Guna.UI2.WinForms.Guna2DataGridView dgv_ProductionMaterials;
        private Guna.UI2.WinForms.Guna2ComboBox cmb_Material;
        private Guna.UI2.WinForms.Guna2NumericUpDown num_QtyToUse;
        private Guna.UI2.WinForms.Guna2Button btn_AddMaterial;
        private System.Windows.Forms.Label lblMaterial;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.Panel pnlSummary;
        private System.Windows.Forms.Label lblTotalResult;
        private Guna.UI2.WinForms.Guna2NumericUpDown num_FinalWeight;
        private Guna.UI2.WinForms.Guna2Button btn_SaveProduction;
        private System.Windows.Forms.Label lblWeightNote;
        private Guna.UI2.WinForms.Guna2CircleButton btn_Minimize;
    }
}