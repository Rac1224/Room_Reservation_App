
namespace IOOP_ASSIGNMENT
{
    partial class frmDailyReport
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dgvReservation = new System.Windows.Forms.DataGridView();
            this.reservationIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reservationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dailyReportDataSet = new IOOP_ASSIGNMENT.DailyReportDataSet();
            this.btnBack = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbOption = new System.Windows.Forms.ComboBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.reservationTableAdapter = new IOOP_ASSIGNMENT.DailyReportDataSetTableAdapters.reservationTableAdapter();
            this.gbReport = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblReportAnalysis = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dailyReportDataSet)).BeginInit();
            this.gbReport.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(18, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Date:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateTimePicker1.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(176, 9);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(373, 31);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // dgvReservation
            // 
            this.dgvReservation.AllowUserToAddRows = false;
            this.dgvReservation.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvReservation.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvReservation.AutoGenerateColumns = false;
            this.dgvReservation.BackgroundColor = System.Drawing.Color.Gold;
            this.dgvReservation.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReservation.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvReservation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.reservationIDDataGridViewTextBoxColumn,
            this.roomNameDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.startTimeDataGridViewTextBoxColumn,
            this.endTimeDataGridViewTextBoxColumn,
            this.studentIDDataGridViewTextBoxColumn,
            this.studentNameDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.dgvReservation.DataSource = this.reservationBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvReservation.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvReservation.GridColor = System.Drawing.Color.Gold;
            this.dgvReservation.Location = new System.Drawing.Point(42, 346);
            this.dgvReservation.Name = "dgvReservation";
            this.dgvReservation.ReadOnly = true;
            this.dgvReservation.RowHeadersWidth = 62;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.dgvReservation.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvReservation.RowTemplate.Height = 28;
            this.dgvReservation.Size = new System.Drawing.Size(994, 345);
            this.dgvReservation.TabIndex = 2;
            // 
            // reservationIDDataGridViewTextBoxColumn
            // 
            this.reservationIDDataGridViewTextBoxColumn.DataPropertyName = "reservationID";
            this.reservationIDDataGridViewTextBoxColumn.HeaderText = "Reservation ID";
            this.reservationIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.reservationIDDataGridViewTextBoxColumn.Name = "reservationIDDataGridViewTextBoxColumn";
            this.reservationIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.reservationIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // roomNameDataGridViewTextBoxColumn
            // 
            this.roomNameDataGridViewTextBoxColumn.DataPropertyName = "roomName";
            this.roomNameDataGridViewTextBoxColumn.HeaderText = "Room Name";
            this.roomNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.roomNameDataGridViewTextBoxColumn.Name = "roomNameDataGridViewTextBoxColumn";
            this.roomNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.roomNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateDataGridViewTextBoxColumn.Width = 150;
            // 
            // startTimeDataGridViewTextBoxColumn
            // 
            this.startTimeDataGridViewTextBoxColumn.DataPropertyName = "startTime";
            this.startTimeDataGridViewTextBoxColumn.HeaderText = "Start Time";
            this.startTimeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.startTimeDataGridViewTextBoxColumn.Name = "startTimeDataGridViewTextBoxColumn";
            this.startTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.startTimeDataGridViewTextBoxColumn.Width = 150;
            // 
            // endTimeDataGridViewTextBoxColumn
            // 
            this.endTimeDataGridViewTextBoxColumn.DataPropertyName = "endTime";
            this.endTimeDataGridViewTextBoxColumn.HeaderText = "End Time";
            this.endTimeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.endTimeDataGridViewTextBoxColumn.Name = "endTimeDataGridViewTextBoxColumn";
            this.endTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.endTimeDataGridViewTextBoxColumn.Width = 150;
            // 
            // studentIDDataGridViewTextBoxColumn
            // 
            this.studentIDDataGridViewTextBoxColumn.DataPropertyName = "studentID";
            this.studentIDDataGridViewTextBoxColumn.HeaderText = "Student ID";
            this.studentIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.studentIDDataGridViewTextBoxColumn.Name = "studentIDDataGridViewTextBoxColumn";
            this.studentIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.studentIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // studentNameDataGridViewTextBoxColumn
            // 
            this.studentNameDataGridViewTextBoxColumn.DataPropertyName = "studentName";
            this.studentNameDataGridViewTextBoxColumn.HeaderText = "Student Name";
            this.studentNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.studentNameDataGridViewTextBoxColumn.Name = "studentNameDataGridViewTextBoxColumn";
            this.studentNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.studentNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            this.statusDataGridViewTextBoxColumn.Width = 150;
            // 
            // reservationBindingSource
            // 
            this.reservationBindingSource.DataMember = "reservation";
            this.reservationBindingSource.DataSource = this.dailyReportDataSet;
            // 
            // dailyReportDataSet
            // 
            this.dailyReportDataSet.DataSetName = "DailyReportDataSet";
            this.dailyReportDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.BackgroundImage = global::IOOP_ASSIGNMENT.Properties.Resources.arrow_b_;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Location = new System.Drawing.Point(36, 29);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(46, 46);
            this.btnBack.TabIndex = 3;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(18, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Select Room:";
            // 
            // cmbOption
            // 
            this.cmbOption.BackColor = System.Drawing.Color.Gold;
            this.cmbOption.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbOption.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbOption.ForeColor = System.Drawing.Color.Black;
            this.cmbOption.FormattingEnabled = true;
            this.cmbOption.Items.AddRange(new object[] {
            "All Rooms",
            "Amber 1",
            "Amber 2",
            "Amber 3",
            "Amber 4",
            "Amber 5",
            "BlackThorn 1",
            "BlackThorn 2",
            "BlackThorn 3",
            "BlackThorn 4",
            "Cedar 1",
            "Cedar 2",
            "Cedar 3",
            "Cedar 4",
            "Cedar 5",
            "Cedar 6",
            "Daphne 1",
            "Daphne 2",
            "Daphne 3",
            "Daphne 4",
            "Daphne 5"});
            this.cmbOption.Location = new System.Drawing.Point(177, 68);
            this.cmbOption.Name = "cmbOption";
            this.cmbOption.Size = new System.Drawing.Size(220, 31);
            this.cmbOption.TabIndex = 5;
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.Color.Gold;
            this.btnGenerate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGenerate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnGenerate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnGenerate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGenerate.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.ForeColor = System.Drawing.Color.White;
            this.btnGenerate.Location = new System.Drawing.Point(748, 83);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(270, 48);
            this.btnGenerate.TabIndex = 6;
            this.btnGenerate.Text = "GENERATE DAILY REPORT";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // reservationTableAdapter
            // 
            this.reservationTableAdapter.ClearBeforeFill = true;
            // 
            // gbReport
            // 
            this.gbReport.BackColor = System.Drawing.Color.Transparent;
            this.gbReport.BackgroundImage = global::IOOP_ASSIGNMENT.Properties.Resources.black_background_shallow_;
            this.gbReport.Controls.Add(this.lblReportAnalysis);
            this.gbReport.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbReport.ForeColor = System.Drawing.Color.White;
            this.gbReport.Location = new System.Drawing.Point(208, 180);
            this.gbReport.Name = "gbReport";
            this.gbReport.Size = new System.Drawing.Size(686, 151);
            this.gbReport.TabIndex = 12;
            this.gbReport.TabStop = false;
            this.gbReport.Text = "Daily Room Reservation Report:";
            this.gbReport.Enter += new System.EventHandler(this.gbReport_Enter);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::IOOP_ASSIGNMENT.Properties.Resources.black_background_shallow_;
            this.panel1.Controls.Add(this.cmbOption);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(116, 29);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(612, 128);
            this.panel1.TabIndex = 13;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::IOOP_ASSIGNMENT.Properties.Resources.LOGO_shallow;
            this.pictureBox2.Location = new System.Drawing.Point(945, -6);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(147, 95);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            // 
            // lblReportAnalysis
            // 
            this.lblReportAnalysis.AutoSize = true;
            this.lblReportAnalysis.BackColor = System.Drawing.Color.Transparent;
            this.lblReportAnalysis.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportAnalysis.ForeColor = System.Drawing.Color.LightGray;
            this.lblReportAnalysis.Location = new System.Drawing.Point(20, 43);
            this.lblReportAnalysis.Name = "lblReportAnalysis";
            this.lblReportAnalysis.Size = new System.Drawing.Size(408, 23);
            this.lblReportAnalysis.TabIndex = 23;
            this.lblReportAnalysis.Text = "Total Number of Reservations Approved:";
            // 
            // frmDailyReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::IOOP_ASSIGNMENT.Properties.Resources.black_background1;
            this.ClientSize = new System.Drawing.Size(1060, 709);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gbReport);
            this.Controls.Add(this.dgvReservation);
            this.Controls.Add(this.btnBack);
            this.Name = "frmDailyReport";
            this.Text = "Discussion Room Daily Reservation Report";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDailyReport_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmDailyReport_FormClosed);
            this.Load += new System.EventHandler(this.frmDailyReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dailyReportDataSet)).EndInit();
            this.gbReport.ResumeLayout(false);
            this.gbReport.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dgvReservation;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbOption;
        private System.Windows.Forms.Button btnGenerate;
        private DailyReportDataSet dailyReportDataSet;
        private System.Windows.Forms.BindingSource reservationBindingSource;
        private DailyReportDataSetTableAdapters.reservationTableAdapter reservationTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn reservationIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox gbReport;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblReportAnalysis;
    }
}