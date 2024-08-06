
namespace QLTiemVacxin
{
    partial class frmTimphieuhen
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btChon = new System.Windows.Forms.Button();
            this.rbNgayHen = new System.Windows.Forms.RadioButton();
            this.rbMasoPH = new System.Windows.Forms.RadioButton();
            this.dateTimePiNgayhen = new System.Windows.Forms.DateTimePicker();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.btThoat = new System.Windows.Forms.Button();
            this.btTim = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dGridViewPH = new System.Windows.Forms.DataGridView();
            this.MSPH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENBS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYLPH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NDKHAM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYHEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mSPHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tENNVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tENKHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tENBSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nGAYLPHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOIDUNGKHAMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nGAYHENDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataSetPH = new System.Data.DataSet();
            this.dataTable1 = new System.Data.DataTable();
            this.dataColumn2 = new System.Data.DataColumn();
            this.dataColumn3 = new System.Data.DataColumn();
            this.dataColumn4 = new System.Data.DataColumn();
            this.dataColumn5 = new System.Data.DataColumn();
            this.dataColumn6 = new System.Data.DataColumn();
            this.dataColumn7 = new System.Data.DataColumn();
            this.dataColumn8 = new System.Data.DataColumn();
            this.dataColumn9 = new System.Data.DataColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGridViewPH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btChon);
            this.groupBox1.Controls.Add(this.rbNgayHen);
            this.groupBox1.Controls.Add(this.rbMasoPH);
            this.groupBox1.Controls.Add(this.dateTimePiNgayhen);
            this.groupBox1.Controls.Add(this.txtTenKH);
            this.groupBox1.Controls.Add(this.btThoat);
            this.groupBox1.Controls.Add(this.btTim);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(977, 151);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin cần tìm";
            // 
            // btChon
            // 
            this.btChon.Location = new System.Drawing.Point(20, 102);
            this.btChon.Name = "btChon";
            this.btChon.Size = new System.Drawing.Size(94, 43);
            this.btChon.TabIndex = 16;
            this.btChon.Text = "Chọn PH";
            this.btChon.UseVisualStyleBackColor = true;
            this.btChon.Click += new System.EventHandler(this.btChon_Click);
            // 
            // rbNgayHen
            // 
            this.rbNgayHen.AutoSize = true;
            this.rbNgayHen.Location = new System.Drawing.Point(279, 92);
            this.rbNgayHen.Name = "rbNgayHen";
            this.rbNgayHen.Size = new System.Drawing.Size(108, 24);
            this.rbNgayHen.TabIndex = 15;
            this.rbNgayHen.TabStop = true;
            this.rbNgayHen.Text = "Ngày hẹn";
            this.rbNgayHen.UseVisualStyleBackColor = true;
            this.rbNgayHen.CheckedChanged += new System.EventHandler(this.rbNgayHD_CheckedChanged);
            // 
            // rbMasoPH
            // 
            this.rbMasoPH.AutoSize = true;
            this.rbMasoPH.Location = new System.Drawing.Point(279, 42);
            this.rbMasoPH.Name = "rbMasoPH";
            this.rbMasoPH.Size = new System.Drawing.Size(141, 24);
            this.rbMasoPH.TabIndex = 15;
            this.rbMasoPH.TabStop = true;
            this.rbMasoPH.Text = "Tìm theo tên ";
            this.rbMasoPH.UseVisualStyleBackColor = true;
            this.rbMasoPH.CheckedChanged += new System.EventHandler(this.rbMasoHD_CheckedChanged);
            // 
            // dateTimePiNgayhen
            // 
            this.dateTimePiNgayhen.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePiNgayhen.Location = new System.Drawing.Point(481, 89);
            this.dateTimePiNgayhen.Name = "dateTimePiNgayhen";
            this.dateTimePiNgayhen.Size = new System.Drawing.Size(205, 27);
            this.dateTimePiNgayhen.TabIndex = 14;
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(481, 39);
            this.txtTenKH.Multiline = true;
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(205, 27);
            this.txtTenKH.TabIndex = 1;
            // 
            // btThoat
            // 
            this.btThoat.Location = new System.Drawing.Point(776, 87);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(79, 29);
            this.btThoat.TabIndex = 6;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // btTim
            // 
            this.btTim.Location = new System.Drawing.Point(776, 37);
            this.btTim.Name = "btTim";
            this.btTim.Size = new System.Drawing.Size(79, 29);
            this.btTim.TabIndex = 5;
            this.btTim.Text = "Tìm";
            this.btTim.UseVisualStyleBackColor = true;
            this.btTim.Click += new System.EventHandler(this.btTim_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dGridViewPH);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 177);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(973, 386);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh Sách Phiếu Hẹn";
            // 
            // dGridViewPH
            // 
            this.dGridViewPH.AutoGenerateColumns = false;
            this.dGridViewPH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGridViewPH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MSPH,
            this.TENNV,
            this.TENKH,
            this.TENBS,
            this.NGAYLPH,
            this.NDKHAM,
            this.NGAYHEN,
            this.TG,
            this.mSPHDataGridViewTextBoxColumn,
            this.tENNVDataGridViewTextBoxColumn,
            this.tENKHDataGridViewTextBoxColumn,
            this.tENBSDataGridViewTextBoxColumn,
            this.nGAYLPHDataGridViewTextBoxColumn,
            this.nOIDUNGKHAMDataGridViewTextBoxColumn,
            this.nGAYHENDataGridViewTextBoxColumn,
            this.tGDataGridViewTextBoxColumn});
            this.dGridViewPH.DataMember = "DSPHIEUHEN";
            this.dGridViewPH.DataSource = this.dataSetPH;
            this.dGridViewPH.Location = new System.Drawing.Point(6, 25);
            this.dGridViewPH.Name = "dGridViewPH";
            this.dGridViewPH.RowHeadersWidth = 51;
            this.dGridViewPH.RowTemplate.Height = 24;
            this.dGridViewPH.Size = new System.Drawing.Size(957, 355);
            this.dGridViewPH.TabIndex = 0;
            this.dGridViewPH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGridViewPT_CellClick);
            // 
            // MSPH
            // 
            this.MSPH.DataPropertyName = "MSPH";
            this.MSPH.HeaderText = "Mã số PH";
            this.MSPH.MinimumWidth = 6;
            this.MSPH.Name = "MSPH";
            this.MSPH.Width = 150;
            // 
            // TENNV
            // 
            this.TENNV.DataPropertyName = "TENNV";
            this.TENNV.HeaderText = "Tên nhân viên";
            this.TENNV.MinimumWidth = 6;
            this.TENNV.Name = "TENNV";
            this.TENNV.Width = 200;
            // 
            // TENKH
            // 
            this.TENKH.DataPropertyName = "TENKH";
            this.TENKH.HeaderText = "Tên khách hàng";
            this.TENKH.MinimumWidth = 6;
            this.TENKH.Name = "TENKH";
            this.TENKH.Width = 200;
            // 
            // TENBS
            // 
            this.TENBS.DataPropertyName = "TENBS";
            this.TENBS.HeaderText = "Tên bác sĩ";
            this.TENBS.MinimumWidth = 6;
            this.TENBS.Name = "TENBS";
            this.TENBS.Width = 200;
            // 
            // NGAYLPH
            // 
            this.NGAYLPH.DataPropertyName = "NGAYLPH";
            this.NGAYLPH.HeaderText = "Ngày lập PH";
            this.NGAYLPH.MinimumWidth = 6;
            this.NGAYLPH.Name = "NGAYLPH";
            this.NGAYLPH.Width = 150;
            // 
            // NDKHAM
            // 
            this.NDKHAM.DataPropertyName = "NOIDUNGKHAM";
            this.NDKHAM.HeaderText = "Nội dụng hẹn khám ";
            this.NDKHAM.MinimumWidth = 6;
            this.NDKHAM.Name = "NDKHAM";
            this.NDKHAM.Width = 250;
            // 
            // NGAYHEN
            // 
            this.NGAYHEN.DataPropertyName = "NGAYHEN";
            this.NGAYHEN.HeaderText = "Ngày hẹn";
            this.NGAYHEN.MinimumWidth = 6;
            this.NGAYHEN.Name = "NGAYHEN";
            this.NGAYHEN.Width = 150;
            // 
            // TG
            // 
            this.TG.DataPropertyName = "TG";
            this.TG.HeaderText = "Thời gian";
            this.TG.MinimumWidth = 6;
            this.TG.Name = "TG";
            this.TG.Width = 150;
            // 
            // mSPHDataGridViewTextBoxColumn
            // 
            this.mSPHDataGridViewTextBoxColumn.DataPropertyName = "MSPH";
            this.mSPHDataGridViewTextBoxColumn.HeaderText = "MSPH";
            this.mSPHDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mSPHDataGridViewTextBoxColumn.Name = "mSPHDataGridViewTextBoxColumn";
            this.mSPHDataGridViewTextBoxColumn.Width = 125;
            // 
            // tENNVDataGridViewTextBoxColumn
            // 
            this.tENNVDataGridViewTextBoxColumn.DataPropertyName = "TENNV";
            this.tENNVDataGridViewTextBoxColumn.HeaderText = "TENNV";
            this.tENNVDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tENNVDataGridViewTextBoxColumn.Name = "tENNVDataGridViewTextBoxColumn";
            this.tENNVDataGridViewTextBoxColumn.Width = 125;
            // 
            // tENKHDataGridViewTextBoxColumn
            // 
            this.tENKHDataGridViewTextBoxColumn.DataPropertyName = "TENKH";
            this.tENKHDataGridViewTextBoxColumn.HeaderText = "TENKH";
            this.tENKHDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tENKHDataGridViewTextBoxColumn.Name = "tENKHDataGridViewTextBoxColumn";
            this.tENKHDataGridViewTextBoxColumn.Width = 125;
            // 
            // tENBSDataGridViewTextBoxColumn
            // 
            this.tENBSDataGridViewTextBoxColumn.DataPropertyName = "TENBS";
            this.tENBSDataGridViewTextBoxColumn.HeaderText = "TENBS";
            this.tENBSDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tENBSDataGridViewTextBoxColumn.Name = "tENBSDataGridViewTextBoxColumn";
            this.tENBSDataGridViewTextBoxColumn.Width = 125;
            // 
            // nGAYLPHDataGridViewTextBoxColumn
            // 
            this.nGAYLPHDataGridViewTextBoxColumn.DataPropertyName = "NGAYLPH";
            this.nGAYLPHDataGridViewTextBoxColumn.HeaderText = "NGAYLPH";
            this.nGAYLPHDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nGAYLPHDataGridViewTextBoxColumn.Name = "nGAYLPHDataGridViewTextBoxColumn";
            this.nGAYLPHDataGridViewTextBoxColumn.Width = 125;
            // 
            // nOIDUNGKHAMDataGridViewTextBoxColumn
            // 
            this.nOIDUNGKHAMDataGridViewTextBoxColumn.DataPropertyName = "NOIDUNGKHAM";
            this.nOIDUNGKHAMDataGridViewTextBoxColumn.HeaderText = "NOIDUNGKHAM";
            this.nOIDUNGKHAMDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nOIDUNGKHAMDataGridViewTextBoxColumn.Name = "nOIDUNGKHAMDataGridViewTextBoxColumn";
            this.nOIDUNGKHAMDataGridViewTextBoxColumn.Width = 125;
            // 
            // nGAYHENDataGridViewTextBoxColumn
            // 
            this.nGAYHENDataGridViewTextBoxColumn.DataPropertyName = "NGAYHEN";
            this.nGAYHENDataGridViewTextBoxColumn.HeaderText = "NGAYHEN";
            this.nGAYHENDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nGAYHENDataGridViewTextBoxColumn.Name = "nGAYHENDataGridViewTextBoxColumn";
            this.nGAYHENDataGridViewTextBoxColumn.Width = 125;
            // 
            // tGDataGridViewTextBoxColumn
            // 
            this.tGDataGridViewTextBoxColumn.DataPropertyName = "TG";
            this.tGDataGridViewTextBoxColumn.HeaderText = "TG";
            this.tGDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tGDataGridViewTextBoxColumn.Name = "tGDataGridViewTextBoxColumn";
            this.tGDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataSetPH
            // 
            this.dataSetPH.DataSetName = "NewDataSet";
            this.dataSetPH.Tables.AddRange(new System.Data.DataTable[] {
            this.dataTable1});
            // 
            // dataTable1
            // 
            this.dataTable1.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn2,
            this.dataColumn3,
            this.dataColumn4,
            this.dataColumn5,
            this.dataColumn6,
            this.dataColumn7,
            this.dataColumn8,
            this.dataColumn9});
            this.dataTable1.TableName = "DSPHIEUHEN";
            // 
            // dataColumn2
            // 
            this.dataColumn2.ColumnName = "MSPH";
            this.dataColumn2.MaxLength = 150;
            // 
            // dataColumn3
            // 
            this.dataColumn3.ColumnName = "TENNV";
            this.dataColumn3.MaxLength = 250;
            // 
            // dataColumn4
            // 
            this.dataColumn4.ColumnName = "TENKH";
            this.dataColumn4.MaxLength = 250;
            // 
            // dataColumn5
            // 
            this.dataColumn5.ColumnName = "TENBS";
            this.dataColumn5.MaxLength = 250;
            // 
            // dataColumn6
            // 
            this.dataColumn6.ColumnName = "NGAYLPH";
            this.dataColumn6.MaxLength = 250;
            // 
            // dataColumn7
            // 
            this.dataColumn7.ColumnName = "NOIDUNGKHAM";
            this.dataColumn7.MaxLength = 150;
            // 
            // dataColumn8
            // 
            this.dataColumn8.ColumnName = "NGAYHEN";
            this.dataColumn8.DataType = typeof(System.DateTime);
            // 
            // dataColumn9
            // 
            this.dataColumn9.ColumnName = "TG";
            // 
            // frmTimphieuhen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 575);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "frmTimphieuhen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tìm Phiếu Hẹn";
            this.Load += new System.EventHandler(this.frmTimphieutiem_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGridViewPH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbNgayHen;
        private System.Windows.Forms.RadioButton rbMasoPH;
        private System.Windows.Forms.DateTimePicker dateTimePiNgayhen;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Button btTim;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dGridViewPH;
        public System.Windows.Forms.Button btChon;
        private System.Data.DataSet dataSetPH;
        private System.Data.DataTable dataTable1;
        private System.Data.DataColumn dataColumn2;
        private System.Data.DataColumn dataColumn3;
        private System.Data.DataColumn dataColumn4;
        private System.Data.DataColumn dataColumn5;
        private System.Data.DataColumn dataColumn6;
        private System.Data.DataColumn dataColumn7;
        private System.Data.DataColumn dataColumn8;
        private System.Data.DataColumn dataColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn MSPH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENBS;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYLPH;
        private System.Windows.Forms.DataGridViewTextBoxColumn NDKHAM;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYHEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn TG;
        private System.Windows.Forms.DataGridViewTextBoxColumn mSPHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tENNVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tENKHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tENBSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nGAYLPHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOIDUNGKHAMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nGAYHENDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tGDataGridViewTextBoxColumn;
    }
}