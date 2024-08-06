
namespace QLTiemVacxin
{
    partial class frmTimKH
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaso = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDiachi = new System.Windows.Forms.TextBox();
            this.txtCMT = new System.Windows.Forms.TextBox();
            this.txtHoten = new System.Windows.Forms.TextBox();
            this.txtSodienthoai = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dGridViewNT = new System.Windows.Forms.DataGridView();
            this.sTTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mSNTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tENNTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cMTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pHAIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nGAYSINHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dIACHIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataSetNT = new System.Data.DataSet();
            this.dataTable1 = new System.Data.DataTable();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataColumn2 = new System.Data.DataColumn();
            this.dataColumn3 = new System.Data.DataColumn();
            this.dataColumn4 = new System.Data.DataColumn();
            this.dataColumn5 = new System.Data.DataColumn();
            this.dataColumn6 = new System.Data.DataColumn();
            this.dataColumn7 = new System.Data.DataColumn();
            this.dataColumn8 = new System.Data.DataColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btTim = new System.Windows.Forms.Button();
            this.btThoat = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btChon = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGridViewNT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetNT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtMaso);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtDiachi);
            this.groupBox1.Controls.Add(this.txtCMT);
            this.groupBox1.Controls.Add(this.txtHoten);
            this.groupBox1.Controls.Add(this.txtSodienthoai);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1063, 151);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin cần tìm kiếm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "MSKH :";
            // 
            // txtMaso
            // 
            this.txtMaso.Location = new System.Drawing.Point(101, 37);
            this.txtMaso.Multiline = true;
            this.txtMaso.Name = "txtMaso";
            this.txtMaso.Size = new System.Drawing.Size(220, 35);
            this.txtMaso.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(723, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "CMT :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(723, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Số điện thoại :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(345, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Họ tên :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Địa chỉ :";
            // 
            // txtDiachi
            // 
            this.txtDiachi.Location = new System.Drawing.Point(101, 85);
            this.txtDiachi.Multiline = true;
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.Size = new System.Drawing.Size(589, 35);
            this.txtDiachi.TabIndex = 4;
            // 
            // txtCMT
            // 
            this.txtCMT.Location = new System.Drawing.Point(828, 87);
            this.txtCMT.Multiline = true;
            this.txtCMT.Name = "txtCMT";
            this.txtCMT.Size = new System.Drawing.Size(210, 35);
            this.txtCMT.TabIndex = 3;
            // 
            // txtHoten
            // 
            this.txtHoten.Location = new System.Drawing.Point(428, 37);
            this.txtHoten.Multiline = true;
            this.txtHoten.Name = "txtHoten";
            this.txtHoten.Size = new System.Drawing.Size(262, 35);
            this.txtHoten.TabIndex = 2;
            // 
            // txtSodienthoai
            // 
            this.txtSodienthoai.Location = new System.Drawing.Point(828, 37);
            this.txtSodienthoai.Multiline = true;
            this.txtSodienthoai.Name = "txtSodienthoai";
            this.txtSodienthoai.Size = new System.Drawing.Size(210, 35);
            this.txtSodienthoai.TabIndex = 3;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dGridViewNT);
            this.groupBox3.Location = new System.Drawing.Point(12, 232);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1069, 364);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách Khách hàng";
            // 
            // dGridViewNT
            // 
            this.dGridViewNT.AutoGenerateColumns = false;
            this.dGridViewNT.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dGridViewNT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGridViewNT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sTTDataGridViewTextBoxColumn,
            this.mSNTDataGridViewTextBoxColumn,
            this.tENNTDataGridViewTextBoxColumn,
            this.cMTDataGridViewTextBoxColumn,
            this.pHAIDataGridViewTextBoxColumn,
            this.nGAYSINHDataGridViewTextBoxColumn,
            this.dIACHIDataGridViewTextBoxColumn,
            this.dTDataGridViewTextBoxColumn});
            this.dGridViewNT.DataMember = "DSNguoitiem";
            this.dGridViewNT.DataSource = this.dataSetNT;
            this.dGridViewNT.Location = new System.Drawing.Point(12, 30);
            this.dGridViewNT.Name = "dGridViewNT";
            this.dGridViewNT.RowHeadersWidth = 51;
            this.dGridViewNT.RowTemplate.Height = 24;
            this.dGridViewNT.Size = new System.Drawing.Size(1057, 334);
            this.dGridViewNT.TabIndex = 0;
            this.dGridViewNT.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGridViewNT_CellClick);
            // 
            // sTTDataGridViewTextBoxColumn
            // 
            this.sTTDataGridViewTextBoxColumn.DataPropertyName = "STT";
            this.sTTDataGridViewTextBoxColumn.HeaderText = "STT";
            this.sTTDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sTTDataGridViewTextBoxColumn.Name = "sTTDataGridViewTextBoxColumn";
            this.sTTDataGridViewTextBoxColumn.Width = 60;
            // 
            // mSNTDataGridViewTextBoxColumn
            // 
            this.mSNTDataGridViewTextBoxColumn.DataPropertyName = "MSNT";
            this.mSNTDataGridViewTextBoxColumn.HeaderText = "Mã Số";
            this.mSNTDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mSNTDataGridViewTextBoxColumn.Name = "mSNTDataGridViewTextBoxColumn";
            this.mSNTDataGridViewTextBoxColumn.Width = 125;
            // 
            // tENNTDataGridViewTextBoxColumn
            // 
            this.tENNTDataGridViewTextBoxColumn.DataPropertyName = "TENNT";
            this.tENNTDataGridViewTextBoxColumn.HeaderText = "Họ và Tên";
            this.tENNTDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tENNTDataGridViewTextBoxColumn.Name = "tENNTDataGridViewTextBoxColumn";
            this.tENNTDataGridViewTextBoxColumn.Width = 250;
            // 
            // cMTDataGridViewTextBoxColumn
            // 
            this.cMTDataGridViewTextBoxColumn.DataPropertyName = "CMT";
            this.cMTDataGridViewTextBoxColumn.HeaderText = "CMT";
            this.cMTDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cMTDataGridViewTextBoxColumn.Name = "cMTDataGridViewTextBoxColumn";
            this.cMTDataGridViewTextBoxColumn.Width = 150;
            // 
            // pHAIDataGridViewTextBoxColumn
            // 
            this.pHAIDataGridViewTextBoxColumn.DataPropertyName = "PHAI";
            this.pHAIDataGridViewTextBoxColumn.HeaderText = "Giới Tính";
            this.pHAIDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pHAIDataGridViewTextBoxColumn.Name = "pHAIDataGridViewTextBoxColumn";
            this.pHAIDataGridViewTextBoxColumn.Width = 125;
            // 
            // nGAYSINHDataGridViewTextBoxColumn
            // 
            this.nGAYSINHDataGridViewTextBoxColumn.DataPropertyName = "NGAYSINH";
            this.nGAYSINHDataGridViewTextBoxColumn.HeaderText = "Ngày Sinh";
            this.nGAYSINHDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nGAYSINHDataGridViewTextBoxColumn.Name = "nGAYSINHDataGridViewTextBoxColumn";
            this.nGAYSINHDataGridViewTextBoxColumn.Width = 150;
            // 
            // dIACHIDataGridViewTextBoxColumn
            // 
            this.dIACHIDataGridViewTextBoxColumn.DataPropertyName = "DIACHI";
            this.dIACHIDataGridViewTextBoxColumn.HeaderText = "Địa Chỉ";
            this.dIACHIDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dIACHIDataGridViewTextBoxColumn.Name = "dIACHIDataGridViewTextBoxColumn";
            this.dIACHIDataGridViewTextBoxColumn.Width = 300;
            // 
            // dTDataGridViewTextBoxColumn
            // 
            this.dTDataGridViewTextBoxColumn.DataPropertyName = "DT";
            this.dTDataGridViewTextBoxColumn.HeaderText = "Số ĐT";
            this.dTDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dTDataGridViewTextBoxColumn.Name = "dTDataGridViewTextBoxColumn";
            this.dTDataGridViewTextBoxColumn.Width = 150;
            // 
            // dataSetNT
            // 
            this.dataSetNT.DataSetName = "NewDataSet";
            this.dataSetNT.Tables.AddRange(new System.Data.DataTable[] {
            this.dataTable1});
            // 
            // dataTable1
            // 
            this.dataTable1.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn1,
            this.dataColumn2,
            this.dataColumn3,
            this.dataColumn4,
            this.dataColumn5,
            this.dataColumn6,
            this.dataColumn7,
            this.dataColumn8});
            this.dataTable1.TableName = "DSNguoitiem";
            // 
            // dataColumn1
            // 
            this.dataColumn1.ColumnName = "STT";
            this.dataColumn1.DataType = typeof(short);
            // 
            // dataColumn2
            // 
            this.dataColumn2.ColumnName = "MSNT";
            this.dataColumn2.MaxLength = 100;
            // 
            // dataColumn3
            // 
            this.dataColumn3.ColumnName = "TENNT";
            this.dataColumn3.MaxLength = 250;
            // 
            // dataColumn4
            // 
            this.dataColumn4.ColumnName = "CMT";
            this.dataColumn4.MaxLength = 100;
            // 
            // dataColumn5
            // 
            this.dataColumn5.ColumnName = "PHAI";
            this.dataColumn5.MaxLength = 70;
            // 
            // dataColumn6
            // 
            this.dataColumn6.ColumnName = "NGAYSINH";
            this.dataColumn6.DataType = typeof(System.DateTime);
            // 
            // dataColumn7
            // 
            this.dataColumn7.ColumnName = "DIACHI";
            this.dataColumn7.MaxLength = 300;
            // 
            // dataColumn8
            // 
            this.dataColumn8.ColumnName = "DT";
            this.dataColumn8.MaxLength = 100;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btTim);
            this.groupBox2.Controls.Add(this.btThoat);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.btChon);
            this.groupBox2.Location = new System.Drawing.Point(12, 169);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1063, 65);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức Năng";
            // 
            // btTim
            // 
            this.btTim.Location = new System.Drawing.Point(726, 21);
            this.btTim.Name = "btTim";
            this.btTim.Size = new System.Drawing.Size(79, 36);
            this.btTim.TabIndex = 9;
            this.btTim.Text = "Tìm";
            this.btTim.UseVisualStyleBackColor = true;
            this.btTim.Click += new System.EventHandler(this.btTim_Click);
            // 
            // btThoat
            // 
            this.btThoat.Location = new System.Drawing.Point(959, 21);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(79, 36);
            this.btThoat.TabIndex = 8;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(101, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(264, 36);
            this.button1.TabIndex = 7;
            this.button1.Text = "Thêm Khách Hàng Mới";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btChon
            // 
            this.btChon.Location = new System.Drawing.Point(874, 21);
            this.btChon.Name = "btChon";
            this.btChon.Size = new System.Drawing.Size(79, 36);
            this.btChon.TabIndex = 6;
            this.btChon.Text = "Chọn";
            this.btChon.UseVisualStyleBackColor = true;
            this.btChon.Click += new System.EventHandler(this.btChon_Click);
            // 
            // frmTimKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 596);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "frmTimKH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tìm Kiếm Thông Tin Khách Hàng";
            this.Load += new System.EventHandler(this.frmTimNT_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGridViewNT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetNT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaso;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDiachi;
        private System.Windows.Forms.TextBox txtHoten;
        private System.Windows.Forms.TextBox txtSodienthoai;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dGridViewNT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCMT;
        private System.Data.DataSet dataSetNT;
        private System.Data.DataTable dataTable1;
        private System.Data.DataColumn dataColumn1;
        private System.Data.DataColumn dataColumn2;
        private System.Data.DataColumn dataColumn3;
        private System.Data.DataColumn dataColumn4;
        private System.Data.DataColumn dataColumn5;
        private System.Data.DataColumn dataColumn6;
        private System.Data.DataColumn dataColumn7;
        private System.Data.DataColumn dataColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mSNTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tENNTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cMTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pHAIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nGAYSINHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dIACHIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dTDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btTim;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button btChon;
    }
}