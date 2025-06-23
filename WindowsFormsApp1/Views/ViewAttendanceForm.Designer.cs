namespace WindowsFormsApp1.Views
{
    partial class ViewAttendanceForm
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
            this.dgvStudentAttendance = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentAttendance)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStudentAttendance
            // 
            this.dgvStudentAttendance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudentAttendance.Location = new System.Drawing.Point(65, 183);
            this.dgvStudentAttendance.Name = "dgvStudentAttendance";
            this.dgvStudentAttendance.RowHeadersWidth = 51;
            this.dgvStudentAttendance.RowTemplate.Height = 24;
            this.dgvStudentAttendance.Size = new System.Drawing.Size(953, 373);
            this.dgvStudentAttendance.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Font = new System.Drawing.Font("Imprint MT Shadow", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(361, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "View Attendance";
            // 
            // ViewAttendanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1101, 622);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvStudentAttendance);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewAttendanceForm";
            this.Text = "ViewAttendanceForm";
            this.Load += new System.EventHandler(this.ViewAttendanceForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentAttendance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStudentAttendance;
        private System.Windows.Forms.Label label1;
    }
}