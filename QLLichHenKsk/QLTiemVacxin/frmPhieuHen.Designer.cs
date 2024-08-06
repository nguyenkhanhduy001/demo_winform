
namespace QLTiemVacxin
{
    partial class frmPhieuHen
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
            this.btLapPT = new System.Windows.Forms.Button();
            this.dataSetPH = new System.Data.DataSet();
            this.dataTable1 = new System.Data.DataTable();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataColumn2 = new System.Data.DataColumn();
            this.dataColumn3 = new System.Data.DataColumn();
            this.dataColumn4 = new System.Data.DataColumn();
            this.dataColumn5 = new System.Data.DataColumn();
            this.dataColumn6 = new System.Data.DataColumn();
            this.dataColumn7 = new System.Data.DataColumn();
            this.dataColumn8 = new System.Data.DataColumn();
            this.dataColumn9 = new System.Data.DataColumn();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btThoat = new System.Windows.Forms.Button();
            this.btIn = new System.Windows.Forms.Button();
            this.btTim = new System.Windows.Forms.Button();
            this.btKhongluu = new System.Windows.Forms.Button();
            this.btLuu = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dGridViewPH = new System.Windows.Forms.DataGridView();
            this.sTTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mSPTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENBS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYLPH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NDKHAM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYHEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbNDKham = new System.Windows.Forms.ComboBox();
            this.dateTimePiNgayhen = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.cbTenBS = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cbTG = new System.Windows.Forms.ComboBox();
            this.txtMaPH = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTPiNgayLph = new System.Windows.Forms.DateTimePicker();
            this.txtDienthoai = new System.Windows.Forms.TextBox();
            this.btTnt = new System.Windows.Forms.Button();
            this.txtDiachi = new System.Windows.Forms.TextBox();
            this.cbGioitinh = new System.Windows.Forms.ComboBox();
            this.cbKhachHang = new System.Windows.Forms.ComboBox();
            this.cbNhanvien = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGridViewPH)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btLapPT
            // 
            this.btLapPT.Location = new System.Drawing.Point(28, 26);
            this.btLapPT.Name = "btLapPT";
            this.btLapPT.Size = new System.Drawing.Size(160, 36);
            this.btLapPT.TabIndex = 9;
            this.btLapPT.Text = "Lập Phiếu Hẹn";
            this.btLapPT.UseVisualStyleBackColor = true;
            this.btLapPT.Click += new System.EventHandler(this.btLapPT_Click);
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
            this.dataColumn1,
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
            // dataColumn1
            // 
            this.dataColumn1.AutoIncrementSeed = ((long)(1));
            this.dataColumn1.ColumnName = "STT";
            this.dataColumn1.MaxLength = 150;
            // 
            // dataColumn2
            // 
            this.dataColumn2.ColumnName = "MSPT";
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
            this.dataColumn7.ColumnName = "NDKHAM";
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
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnCapNhat);
            this.groupBox4.Controls.Add(this.btnSua);
            this.groupBox4.Controls.Add(this.btnXoa);
            this.groupBox4.Controls.Add(this.btThoat);
            this.groupBox4.Controls.Add(this.btIn);
            this.groupBox4.Controls.Add(this.btTim);
            this.groupBox4.Controls.Add(this.btKhongluu);
            this.groupBox4.Controls.Add(this.btLuu);
            this.groupBox4.Controls.Add(this.btLapPT);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(19, 724);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1047, 118);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Chức Năng";
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(676, 26);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(166, 36);
            this.btnCapNhat.TabIndex = 17;
            this.btnCapNhat.Text = "Cập Nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(565, 26);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(88, 36);
            this.btnSua.TabIndex = 16;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(860, 26);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(144, 36);
            this.btnXoa.TabIndex = 15;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btThoat
            // 
            this.btThoat.Location = new System.Drawing.Point(912, 74);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(84, 36);
            this.btThoat.TabIndex = 14;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // btIn
            // 
            this.btIn.Location = new System.Drawing.Point(805, 74);
            this.btIn.Name = "btIn";
            this.btIn.Size = new System.Drawing.Size(84, 36);
            this.btIn.TabIndex = 13;
            this.btIn.Text = "In";
            this.btIn.UseVisualStyleBackColor = true;
            this.btIn.Click += new System.EventHandler(this.btIn_Click);
            // 
            // btTim
            // 
            this.btTim.Location = new System.Drawing.Point(694, 74);
            this.btTim.Name = "btTim";
            this.btTim.Size = new System.Drawing.Size(84, 36);
            this.btTim.TabIndex = 12;
            this.btTim.Text = "Tìm";
            this.btTim.UseVisualStyleBackColor = true;
            this.btTim.Click += new System.EventHandler(this.btTim_Click);
            // 
            // btKhongluu
            // 
            this.btKhongluu.Location = new System.Drawing.Point(337, 26);
            this.btKhongluu.Name = "btKhongluu";
            this.btKhongluu.Size = new System.Drawing.Size(166, 36);
            this.btKhongluu.TabIndex = 11;
            this.btKhongluu.Text = "Không lưu";
            this.btKhongluu.UseVisualStyleBackColor = true;
            this.btKhongluu.Click += new System.EventHandler(this.btKhongluu_Click);
            // 
            // btLuu
            // 
            this.btLuu.Location = new System.Drawing.Point(223, 26);
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new System.Drawing.Size(84, 36);
            this.btLuu.TabIndex = 10;
            this.btLuu.Text = "Lưu";
            this.btLuu.UseVisualStyleBackColor = true;
            this.btLuu.Click += new System.EventHandler(this.btLuu_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dGridViewPH);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(19, 412);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1048, 306);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh Sách Phiếu Hẹn";
            // 
            // dGridViewPH
            // 
            this.dGridViewPH.AutoGenerateColumns = false;
            this.dGridViewPH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGridViewPH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sTTDataGridViewTextBoxColumn,
            this.mSPTDataGridViewTextBoxColumn,
            this.TENNV,
            this.TENKH,
            this.TENBS,
            this.NGAYLPH,
            this.NDKHAM,
            this.NGAYHEN,
            this.TG});
            this.dGridViewPH.DataMember = "DSPHIEUHEN";
            this.dGridViewPH.DataSource = this.dataSetPH;
            this.dGridViewPH.Location = new System.Drawing.Point(6, 24);
            this.dGridViewPH.Name = "dGridViewPH";
            this.dGridViewPH.RowHeadersWidth = 51;
            this.dGridViewPH.RowTemplate.Height = 24;
            this.dGridViewPH.Size = new System.Drawing.Size(1018, 276);
            this.dGridViewPH.TabIndex = 0;
            this.dGridViewPH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGridViewPT_CellClick);
            // 
            // sTTDataGridViewTextBoxColumn
            // 
            this.sTTDataGridViewTextBoxColumn.DataPropertyName = "STT";
            this.sTTDataGridViewTextBoxColumn.HeaderText = "STT";
            this.sTTDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sTTDataGridViewTextBoxColumn.Name = "sTTDataGridViewTextBoxColumn";
            this.sTTDataGridViewTextBoxColumn.Width = 125;
            // 
            // mSPTDataGridViewTextBoxColumn
            // 
            this.mSPTDataGridViewTextBoxColumn.DataPropertyName = "MSPT";
            this.mSPTDataGridViewTextBoxColumn.HeaderText = "Mã Phiếu Tiêm";
            this.mSPTDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mSPTDataGridViewTextBoxColumn.Name = "mSPTDataGridViewTextBoxColumn";
            this.mSPTDataGridViewTextBoxColumn.Width = 150;
            // 
            // TENNV
            // 
            this.TENNV.DataPropertyName = "TENNV";
            this.TENNV.HeaderText = "Tên Nhân Viên ";
            this.TENNV.MinimumWidth = 6;
            this.TENNV.Name = "TENNV";
            this.TENNV.Width = 200;
            // 
            // TENKH
            // 
            this.TENKH.DataPropertyName = "TENKH";
            this.TENKH.HeaderText = "Tên Khách Hàng";
            this.TENKH.MinimumWidth = 6;
            this.TENKH.Name = "TENKH";
            this.TENKH.Width = 200;
            // 
            // TENBS
            // 
            this.TENBS.DataPropertyName = "TENBS";
            this.TENBS.HeaderText = "Tên Bác Sĩ";
            this.TENBS.MinimumWidth = 6;
            this.TENBS.Name = "TENBS";
            this.TENBS.Width = 200;
            // 
            // NGAYLPH
            // 
            this.NGAYLPH.DataPropertyName = "NGAYLPH";
            this.NGAYLPH.HeaderText = "Ngày LpH";
            this.NGAYLPH.MinimumWidth = 6;
            this.NGAYLPH.Name = "NGAYLPH";
            this.NGAYLPH.Width = 150;
            // 
            // NDKHAM
            // 
            this.NDKHAM.DataPropertyName = "NDKHAM";
            this.NDKHAM.HeaderText = "Nội Dung Khám ";
            this.NDKHAM.MinimumWidth = 6;
            this.NDKHAM.Name = "NDKHAM";
            this.NDKHAM.Width = 250;
            // 
            // NGAYHEN
            // 
            this.NGAYHEN.DataPropertyName = "NGAYHEN";
            this.NGAYHEN.HeaderText = "Ngày Hẹn";
            this.NGAYHEN.MinimumWidth = 6;
            this.NGAYHEN.Name = "NGAYHEN";
            this.NGAYHEN.Width = 150;
            // 
            // TG
            // 
            this.TG.DataPropertyName = "TG";
            this.TG.HeaderText = "Thời Gian";
            this.TG.MinimumWidth = 6;
            this.TG.Name = "TG";
            this.TG.Width = 150;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cbNDKham);
            this.groupBox2.Controls.Add(this.dateTimePiNgayhen);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cbTenBS);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.cbTG);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(19, 259);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1048, 147);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin hẹn :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(488, 36);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(119, 20);
            this.label13.TabIndex = 13;
            this.label13.Text = "Thời gian hẹn :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Nội dung khám  :";
            // 
            // cbNDKham
            // 
            this.cbNDKham.FormattingEnabled = true;
            this.cbNDKham.Items.AddRange(new object[] {
            "Hẹn khám sức khoẻ",
            "Hẹn tái Khám"});
            this.cbNDKham.Location = new System.Drawing.Point(212, 88);
            this.cbNDKham.Name = "cbNDKham";
            this.cbNDKham.Size = new System.Drawing.Size(247, 28);
            this.cbNDKham.TabIndex = 12;
            // 
            // dateTimePiNgayhen
            // 
            this.dateTimePiNgayhen.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePiNgayhen.Location = new System.Drawing.Point(805, 89);
            this.dateTimePiNgayhen.Name = "dateTimePiNgayhen";
            this.dateTimePiNgayhen.Size = new System.Drawing.Size(225, 27);
            this.dateTimePiNgayhen.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(713, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Ngày hẹn:";
            // 
            // cbTenBS
            // 
            this.cbTenBS.FormattingEnabled = true;
            this.cbTenBS.Location = new System.Drawing.Point(120, 32);
            this.cbTenBS.Name = "cbTenBS";
            this.cbTenBS.Size = new System.Drawing.Size(339, 28);
            this.cbTenBS.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(47, 36);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 20);
            this.label11.TabIndex = 2;
            this.label11.Text = "Bác sĩ :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(488, 92);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 20);
            this.label12.TabIndex = 0;
            this.label12.Text = "  Lúc:";
            // 
            // cbTG
            // 
            this.cbTG.FormattingEnabled = true;
            this.cbTG.Items.AddRange(new object[] {
            "7h - 9h",
            "9h - 11h",
            "13h30\' - 15h30\'",
            "15h30\' - 17h"});
            this.cbTG.Location = new System.Drawing.Point(556, 88);
            this.cbTG.Name = "cbTG";
            this.cbTG.Size = new System.Drawing.Size(142, 28);
            this.cbTG.TabIndex = 8;
            // 
            // txtMaPH
            // 
            this.txtMaPH.Location = new System.Drawing.Point(931, 39);
            this.txtMaPH.Multiline = true;
            this.txtMaPH.Name = "txtMaPH";
            this.txtMaPH.ReadOnly = true;
            this.txtMaPH.Size = new System.Drawing.Size(134, 26);
            this.txtMaPH.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(784, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Mã số phiếu hẹn :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(303, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(369, 29);
            this.label2.TabIndex = 11;
            this.label2.Text = "PHIẾU HẸN KHÁM SỨC KHOẺ\r\n";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTPiNgayLph);
            this.groupBox1.Controls.Add(this.txtDienthoai);
            this.groupBox1.Controls.Add(this.btTnt);
            this.groupBox1.Controls.Add(this.txtDiachi);
            this.groupBox1.Controls.Add(this.cbGioitinh);
            this.groupBox1.Controls.Add(this.cbKhachHang);
            this.groupBox1.Controls.Add(this.cbNhanvien);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(19, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1048, 169);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin Khách hàng - Nhân viên lập phiếu hẹn";
            // 
            // dateTPiNgayLph
            // 
            this.dateTPiNgayLph.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTPiNgayLph.Location = new System.Drawing.Point(860, 40);
            this.dateTPiNgayLph.Name = "dateTPiNgayLph";
            this.dateTPiNgayLph.Size = new System.Drawing.Size(170, 27);
            this.dateTPiNgayLph.TabIndex = 2;
            // 
            // txtDienthoai
            // 
            this.txtDienthoai.Location = new System.Drawing.Point(860, 84);
            this.txtDienthoai.Multiline = true;
            this.txtDienthoai.Name = "txtDienthoai";
            this.txtDienthoai.ReadOnly = true;
            this.txtDienthoai.Size = new System.Drawing.Size(170, 26);
            this.txtDienthoai.TabIndex = 5;
            // 
            // btTnt
            // 
            this.btTnt.Location = new System.Drawing.Point(453, 83);
            this.btTnt.Name = "btTnt";
            this.btTnt.Size = new System.Drawing.Size(44, 29);
            this.btTnt.TabIndex = 3;
            this.btTnt.Text = "...";
            this.btTnt.UseVisualStyleBackColor = true;
            this.btTnt.Click += new System.EventHandler(this.btTnt_Click);
            // 
            // txtDiachi
            // 
            this.txtDiachi.Location = new System.Drawing.Point(177, 123);
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.ReadOnly = true;
            this.txtDiachi.Size = new System.Drawing.Size(853, 27);
            this.txtDiachi.TabIndex = 6;
            // 
            // cbGioitinh
            // 
            this.cbGioitinh.Enabled = false;
            this.cbGioitinh.FormattingEnabled = true;
            this.cbGioitinh.Location = new System.Drawing.Point(598, 83);
            this.cbGioitinh.Name = "cbGioitinh";
            this.cbGioitinh.Size = new System.Drawing.Size(100, 28);
            this.cbGioitinh.TabIndex = 4;
            // 
            // cbKhachHang
            // 
            this.cbKhachHang.FormattingEnabled = true;
            this.cbKhachHang.Location = new System.Drawing.Point(177, 83);
            this.cbKhachHang.Name = "cbKhachHang";
            this.cbKhachHang.Size = new System.Drawing.Size(270, 28);
            this.cbKhachHang.TabIndex = 2;
            this.cbKhachHang.SelectionChangeCommitted += new System.EventHandler(this.cbNguoitiem_SelectionChangeCommitted);
            this.cbKhachHang.Click += new System.EventHandler(this.cbNguoitiem_SelectionChangeCommitted);
            // 
            // cbNhanvien
            // 
            this.cbNhanvien.FormattingEnabled = true;
            this.cbNhanvien.Location = new System.Drawing.Point(177, 39);
            this.cbNhanvien.Name = "cbNhanvien";
            this.cbNhanvien.Size = new System.Drawing.Size(270, 28);
            this.cbNhanvien.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(47, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Địa chỉ :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(713, 45);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(129, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "Ngày lập phiếu :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(713, 87);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Điện Thoại :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(514, 87);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Giới tính :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Khách hàng :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Nhân viên :";
            // 
            // frmPhieuHen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 867);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtMaPH);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.MaximizeBox = false;
            this.Name = "frmPhieuHen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lập Phiếu Hẹn";
            this.Load += new System.EventHandler(this.frmPhieutiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGridViewPH)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btLapPT;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Button btIn;
        private System.Windows.Forms.Button btTim;
        private System.Windows.Forms.Button btKhongluu;
        private System.Windows.Forms.Button btLuu;
        //private System.Windows.Forms.DataGridViewTextBoxColumn tENNVDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn tENNTDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn tENVXDataGridViewTextBoxColumn;
        private System.Data.DataSet dataSetPH;
        private System.Data.DataTable dataTable1;
        private System.Data.DataColumn dataColumn1;
        private System.Data.DataColumn dataColumn2;
        private System.Data.DataColumn dataColumn3;
        private System.Data.DataColumn dataColumn4;
        private System.Data.DataColumn dataColumn5;
        private System.Data.DataColumn dataColumn6;
        private System.Data.DataColumn dataColumn7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dGridViewPH;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbNDKham;
        private System.Windows.Forms.DateTimePicker dateTimePiNgayhen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbTenBS;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbTG;
        private System.Windows.Forms.TextBox txtMaPH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTPiNgayLph;
        private System.Windows.Forms.TextBox txtDienthoai;
        private System.Windows.Forms.Button btTnt;
        private System.Windows.Forms.TextBox txtDiachi;
        private System.Windows.Forms.ComboBox cbGioitinh;
        private System.Windows.Forms.ComboBox cbKhachHang;
        private System.Windows.Forms.ComboBox cbNhanvien;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Data.DataColumn dataColumn8;
        private System.Data.DataColumn dataColumn9;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mSPTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENBS;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYLPH;
        private System.Windows.Forms.DataGridViewTextBoxColumn NDKHAM;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYHEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn TG;
    }
}