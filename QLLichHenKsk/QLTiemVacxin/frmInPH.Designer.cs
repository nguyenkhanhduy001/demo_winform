﻿namespace QLLichHen
{
    partial class frmInPH
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
            this.btInPH = new System.Windows.Forms.Button();
            this.btTimPH = new System.Windows.Forms.Button();
            this.txtMSPH = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.crystalReportViewerPH = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btInPH);
            this.groupBox1.Controls.Add(this.btTimPH);
            this.groupBox1.Controls.Add(this.txtMSPH);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1022, 105);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin in phiếu tim";
            // 
            // btInPH
            // 
            this.btInPH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btInPH.Location = new System.Drawing.Point(523, 43);
            this.btInPH.Name = "btInPH";
            this.btInPH.Size = new System.Drawing.Size(182, 39);
            this.btInPH.TabIndex = 3;
            this.btInPH.Text = "In Phiếu Hẹn";
            this.btInPH.UseVisualStyleBackColor = true;
            this.btInPH.Click += new System.EventHandler(this.btInPH_Click);
            // 
            // btTimPH
            // 
            this.btTimPH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTimPH.Location = new System.Drawing.Point(481, 43);
            this.btTimPH.Name = "btTimPH";
            this.btTimPH.Size = new System.Drawing.Size(36, 39);
            this.btTimPH.TabIndex = 2;
            this.btTimPH.Text = "...";
            this.btTimPH.UseVisualStyleBackColor = true;
            this.btTimPH.Click += new System.EventHandler(this.btTimPH_Click);
            // 
            // txtMSPH
            // 
            this.txtMSPH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMSPH.Location = new System.Drawing.Point(245, 43);
            this.txtMSPH.Multiline = true;
            this.txtMSPH.Name = "txtMSPH";
            this.txtMSPH.Size = new System.Drawing.Size(230, 39);
            this.txtMSPH.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(95, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã số phiếu hẹn :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.crystalReportViewerPH);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 105);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1022, 406);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // crystalReportViewerPH
            // 
            this.crystalReportViewerPH.ActiveViewIndex = -1;
            this.crystalReportViewerPH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewerPH.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewerPH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewerPH.Location = new System.Drawing.Point(3, 18);
            this.crystalReportViewerPH.Name = "crystalReportViewerPH";
            this.crystalReportViewerPH.Size = new System.Drawing.Size(1016, 385);
            this.crystalReportViewerPH.TabIndex = 0;
            // 
            // frmInPH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 511);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmInPH";
            this.Text = "In Phiếu Hẹn Khám Sức Khoẻ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btInPH;
        private System.Windows.Forms.Button btTimPH;
        private System.Windows.Forms.TextBox txtMSPH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewerPH;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
    }
}