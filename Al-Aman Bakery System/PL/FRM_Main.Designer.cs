namespace Al_Aman_Bakery_System.PL
{
    partial class FRM_Main
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
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.menuBasicData = new System.Windows.Forms.ToolStripMenuItem();
            this.itemMaterials = new System.Windows.Forms.ToolStripMenuItem();
            this.itemProducts = new System.Windows.Forms.ToolStripMenuItem();
            this.تعريفالموردينToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuProduction = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSales = new System.Windows.Forms.ToolStripMenuItem();
            this.menuReports = new System.Windows.Forms.ToolStripMenuItem();
            this.تسجيلمبيعاتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.الفواتيرالسابقةToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.تسحيلالمشترياتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.الفواتيرالسابقةToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.التقاريرToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.نسجيلوصفةمنتجToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.mainMenu.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuBasicData,
            this.menuProduction,
            this.menuSales,
            this.menuReports,
            this.التقاريرToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Padding = new System.Windows.Forms.Padding(6, 4, 0, 4);
            this.mainMenu.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mainMenu.Size = new System.Drawing.Size(1008, 31);
            this.mainMenu.TabIndex = 0;
            this.mainMenu.Text = "menuStrip1";
            // 
            // menuBasicData
            // 
            this.menuBasicData.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemMaterials,
            this.itemProducts,
            this.تعريفالموردينToolStripMenuItem,
            this.نسجيلوصفةمنتجToolStripMenuItem});
            this.menuBasicData.Name = "menuBasicData";
            this.menuBasicData.Size = new System.Drawing.Size(123, 23);
            this.menuBasicData.Text = "البيانات الأساسية";
            // 
            // itemMaterials
            // 
            this.itemMaterials.Name = "itemMaterials";
            this.itemMaterials.Size = new System.Drawing.Size(173, 24);
            this.itemMaterials.Text = "تعريف الخامات";
            this.itemMaterials.Click += new System.EventHandler(this.itemMaterials_Click);
            // 
            // itemProducts
            // 
            this.itemProducts.Name = "itemProducts";
            this.itemProducts.Size = new System.Drawing.Size(173, 24);
            this.itemProducts.Text = "تعريف المنتجات";
            this.itemProducts.Click += new System.EventHandler(this.itemProducts_Click);
            // 
            // تعريفالموردينToolStripMenuItem
            // 
            this.تعريفالموردينToolStripMenuItem.Name = "تعريفالموردينToolStripMenuItem";
            this.تعريفالموردينToolStripMenuItem.Size = new System.Drawing.Size(173, 24);
            this.تعريفالموردينToolStripMenuItem.Text = "تعريف الموردين";
            this.تعريفالموردينToolStripMenuItem.Click += new System.EventHandler(this.تعريفالموردينToolStripMenuItem_Click);
            // 
            // menuProduction
            // 
            this.menuProduction.Name = "menuProduction";
            this.menuProduction.Size = new System.Drawing.Size(87, 23);
            this.menuProduction.Text = "إدارة الإنتاج";
            // 
            // menuSales
            // 
            this.menuSales.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.تسجيلمبيعاتToolStripMenuItem,
            this.الفواتيرالسابقةToolStripMenuItem});
            this.menuSales.Name = "menuSales";
            this.menuSales.Size = new System.Drawing.Size(73, 23);
            this.menuSales.Text = "المبيعات";
            // 
            // menuReports
            // 
            this.menuReports.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.تسحيلالمشترياتToolStripMenuItem,
            this.الفواتيرالسابقةToolStripMenuItem1});
            this.menuReports.Name = "menuReports";
            this.menuReports.Size = new System.Drawing.Size(84, 23);
            this.menuReports.Text = "المشتريات";
            // 
            // تسجيلمبيعاتToolStripMenuItem
            // 
            this.تسجيلمبيعاتToolStripMenuItem.Name = "تسجيلمبيعاتToolStripMenuItem";
            this.تسجيلمبيعاتToolStripMenuItem.Size = new System.Drawing.Size(169, 24);
            this.تسجيلمبيعاتToolStripMenuItem.Text = "تسجيل مبيعات";
            this.تسجيلمبيعاتToolStripMenuItem.Click += new System.EventHandler(this.تسجيلمبيعاتToolStripMenuItem_Click);
            // 
            // الفواتيرالسابقةToolStripMenuItem
            // 
            this.الفواتيرالسابقةToolStripMenuItem.Name = "الفواتيرالسابقةToolStripMenuItem";
            this.الفواتيرالسابقةToolStripMenuItem.Size = new System.Drawing.Size(169, 24);
            this.الفواتيرالسابقةToolStripMenuItem.Text = "الفواتير السابقة";
            // 
            // تسحيلالمشترياتToolStripMenuItem
            // 
            this.تسحيلالمشترياتToolStripMenuItem.Name = "تسحيلالمشترياتToolStripMenuItem";
            this.تسحيلالمشترياتToolStripMenuItem.Size = new System.Drawing.Size(184, 24);
            this.تسحيلالمشترياتToolStripMenuItem.Text = "تسحيل المشتريات";
            this.تسحيلالمشترياتToolStripMenuItem.Click += new System.EventHandler(this.تسحيلالمشترياتToolStripMenuItem_Click);
            // 
            // الفواتيرالسابقةToolStripMenuItem1
            // 
            this.الفواتيرالسابقةToolStripMenuItem1.Name = "الفواتيرالسابقةToolStripMenuItem1";
            this.الفواتيرالسابقةToolStripMenuItem1.Size = new System.Drawing.Size(184, 24);
            this.الفواتيرالسابقةToolStripMenuItem1.Text = "الفواتير السابقة";
            // 
            // التقاريرToolStripMenuItem
            // 
            this.التقاريرToolStripMenuItem.Name = "التقاريرToolStripMenuItem";
            this.التقاريرToolStripMenuItem.Size = new System.Drawing.Size(64, 23);
            this.التقاريرToolStripMenuItem.Text = "التقارير";
            // 
            // نسجيلوصفةمنتجToolStripMenuItem
            // 
            this.نسجيلوصفةمنتجToolStripMenuItem.Name = "نسجيلوصفةمنتجToolStripMenuItem";
            this.نسجيلوصفةمنتجToolStripMenuItem.Size = new System.Drawing.Size(186, 24);
            this.نسجيلوصفةمنتجToolStripMenuItem.Text = "نسجيل وصفة منتج";
            this.نسجيلوصفةمنتجToolStripMenuItem.Click += new System.EventHandler(this.نسجيلوصفةمنتجToolStripMenuItem_Click);
            // 
            // FRM_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1008, 621);
            this.Controls.Add(this.mainMenu);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mainMenu;
            this.Name = "FRM_Main";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Al-Aman Bakery System - نظام الأمان لإدارة المخابز";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem menuBasicData;
        private System.Windows.Forms.ToolStripMenuItem itemMaterials;
        private System.Windows.Forms.ToolStripMenuItem itemProducts;
        private System.Windows.Forms.ToolStripMenuItem menuProduction;
        private System.Windows.Forms.ToolStripMenuItem menuSales;
        private System.Windows.Forms.ToolStripMenuItem menuReports;
        private System.Windows.Forms.ToolStripMenuItem تعريفالموردينToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem تسجيلمبيعاتToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem الفواتيرالسابقةToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem تسحيلالمشترياتToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem الفواتيرالسابقةToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem التقاريرToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem نسجيلوصفةمنتجToolStripMenuItem;
    }
}