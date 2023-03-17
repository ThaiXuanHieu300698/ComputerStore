namespace GUI
{
    partial class StatisticalPage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.lblTitlePage = new System.Windows.Forms.Label();
            this.chartTotalAmountOrders = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartTotalAmountReceipts = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Separator = new Bunifu.Framework.UI.BunifuSeparator();
            this.dgvProductsSold = new System.Windows.Forms.DataGridView();
            this.dgvReceipts = new System.Windows.Forms.DataGridView();
            this.lblProductsSold = new System.Windows.Forms.Label();
            this.lblReceipts = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartTotalAmountOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTotalAmountReceipts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductsSold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceipts)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitlePage
            // 
            this.lblTitlePage.AutoSize = true;
            this.lblTitlePage.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitlePage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblTitlePage.Location = new System.Drawing.Point(432, 9);
            this.lblTitlePage.Name = "lblTitlePage";
            this.lblTitlePage.Size = new System.Drawing.Size(140, 38);
            this.lblTitlePage.TabIndex = 40;
            this.lblTitlePage.Text = "Thống kê";
            // 
            // chartTotalAmountOrders
            // 
            chartArea1.Name = "ChartArea1";
            this.chartTotalAmountOrders.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartTotalAmountOrders.Legends.Add(legend1);
            this.chartTotalAmountOrders.Location = new System.Drawing.Point(26, 406);
            this.chartTotalAmountOrders.Name = "chartTotalAmountOrders";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Tổng tiền";
            this.chartTotalAmountOrders.Series.Add(series1);
            this.chartTotalAmountOrders.Size = new System.Drawing.Size(458, 264);
            this.chartTotalAmountOrders.TabIndex = 41;
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "titleChart1";
            title1.Text = "Tổng doanh thu";
            this.chartTotalAmountOrders.Titles.Add(title1);
            // 
            // chartTotalAmountReceipts
            // 
            chartArea2.Name = "ChartArea1";
            this.chartTotalAmountReceipts.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartTotalAmountReceipts.Legends.Add(legend2);
            this.chartTotalAmountReceipts.Location = new System.Drawing.Point(539, 406);
            this.chartTotalAmountReceipts.Name = "chartTotalAmountReceipts";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Tổng tiền";
            this.chartTotalAmountReceipts.Series.Add(series2);
            this.chartTotalAmountReceipts.Size = new System.Drawing.Size(460, 264);
            this.chartTotalAmountReceipts.TabIndex = 43;
            title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title2.Name = "titleChart1";
            title2.Text = "Tổng chi";
            this.chartTotalAmountReceipts.Titles.Add(title2);
            // 
            // Separator
            // 
            this.Separator.BackColor = System.Drawing.Color.Transparent;
            this.Separator.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.Separator.LineThickness = 1;
            this.Separator.Location = new System.Drawing.Point(493, 98);
            this.Separator.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Separator.Name = "Separator";
            this.Separator.Size = new System.Drawing.Size(39, 572);
            this.Separator.TabIndex = 44;
            this.Separator.Transparency = 255;
            this.Separator.Vertical = true;
            // 
            // dgvProductsSold
            // 
            this.dgvProductsSold.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductsSold.Location = new System.Drawing.Point(26, 98);
            this.dgvProductsSold.Name = "dgvProductsSold";
            this.dgvProductsSold.RowTemplate.Height = 24;
            this.dgvProductsSold.Size = new System.Drawing.Size(458, 251);
            this.dgvProductsSold.TabIndex = 45;
            // 
            // dgvReceipts
            // 
            this.dgvReceipts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReceipts.Location = new System.Drawing.Point(539, 98);
            this.dgvReceipts.Name = "dgvReceipts";
            this.dgvReceipts.RowTemplate.Height = 24;
            this.dgvReceipts.Size = new System.Drawing.Size(460, 251);
            this.dgvReceipts.TabIndex = 45;
            // 
            // lblProductsSold
            // 
            this.lblProductsSold.AutoSize = true;
            this.lblProductsSold.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductsSold.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblProductsSold.Location = new System.Drawing.Point(128, 57);
            this.lblProductsSold.Name = "lblProductsSold";
            this.lblProductsSold.Size = new System.Drawing.Size(262, 38);
            this.lblProductsSold.TabIndex = 40;
            this.lblProductsSold.Text = "Hóa đơn bán hàng";
            // 
            // lblReceipts
            // 
            this.lblReceipts.AutoSize = true;
            this.lblReceipts.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReceipts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblReceipts.Location = new System.Drawing.Point(652, 57);
            this.lblReceipts.Name = "lblReceipts";
            this.lblReceipts.Size = new System.Drawing.Size(239, 38);
            this.lblReceipts.TabIndex = 40;
            this.lblReceipts.Text = "Phiếu nhập hàng";
            // 
            // StatisticalPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dgvReceipts);
            this.Controls.Add(this.dgvProductsSold);
            this.Controls.Add(this.Separator);
            this.Controls.Add(this.chartTotalAmountReceipts);
            this.Controls.Add(this.chartTotalAmountOrders);
            this.Controls.Add(this.lblReceipts);
            this.Controls.Add(this.lblProductsSold);
            this.Controls.Add(this.lblTitlePage);
            this.Name = "StatisticalPage";
            this.Size = new System.Drawing.Size(1020, 684);
            this.Load += new System.EventHandler(this.StatisticalPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartTotalAmountOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTotalAmountReceipts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductsSold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceipts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitlePage;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTotalAmountOrders;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTotalAmountReceipts;
        private Bunifu.Framework.UI.BunifuSeparator Separator;
        private System.Windows.Forms.DataGridView dgvProductsSold;
        private System.Windows.Forms.DataGridView dgvReceipts;
        private System.Windows.Forms.Label lblProductsSold;
        private System.Windows.Forms.Label lblReceipts;
    }
}
