namespace QLLichHen
{
    partial class frmLichTN
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
            this.crystalReportViewerLHTN = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crystalReportViewerLHTN
            // 
            this.crystalReportViewerLHTN.ActiveViewIndex = -1;
            this.crystalReportViewerLHTN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewerLHTN.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewerLHTN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewerLHTN.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewerLHTN.Name = "crystalReportViewerLHTN";
            this.crystalReportViewerLHTN.Size = new System.Drawing.Size(800, 450);
            this.crystalReportViewerLHTN.TabIndex = 0;
            // 
            // frmLichTN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crystalReportViewerLHTN);
            this.Name = "frmLichTN";
            this.Text = "Lịch Hẹn Trong Ngày";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmLichTN_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewerLHTN;
    }
}