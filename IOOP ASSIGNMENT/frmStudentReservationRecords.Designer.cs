
namespace IOOP_ASSIGNMENT
{
    partial class frmStudentReservationRecords
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.reservationTableAdapter = new IOOP_ASSIGNMENT.ReservationSystemDataSet1TableAdapters.reservationTableAdapter();
            this.reservationSystemDataSet1 = new IOOP_ASSIGNMENT.ReservationSystemDataSet1();
            this.reservationBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.reservationTableAdapter1 = new IOOP_ASSIGNMENT.ReservationSystemDataSet1TableAdapters.reservationTableAdapter();
            this.dgvReservation = new System.Windows.Forms.DataGridView();
            this.reservationIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbFilter = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbOrder = new System.Windows.Forms.ComboBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblResults = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.reservationSystemDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(97, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(601, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please select reservation details below to change or cancel:";
            // 
            // btnChange
            // 
            this.btnChange.BackColor = System.Drawing.Color.Transparent;
            this.btnChange.BackgroundImage = global::IOOP_ASSIGNMENT.Properties.Resources.change1;
            this.btnChange.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnChange.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChange.FlatAppearance.BorderSize = 0;
            this.btnChange.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnChange.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnChange.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChange.Location = new System.Drawing.Point(277, 639);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(135, 106);
            this.btnChange.TabIndex = 2;
            this.btnChange.UseVisualStyleBackColor = false;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.BackgroundImage = global::IOOP_ASSIGNMENT.Properties.Resources.cancel;
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(694, 642);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(112, 103);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // reservationTableAdapter
            // 
            this.reservationTableAdapter.ClearBeforeFill = true;
            // 
            // reservationSystemDataSet1
            // 
            this.reservationSystemDataSet1.DataSetName = "ReservationSystemDataSet1";
            this.reservationSystemDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reservationBindingSource1
            // 
            this.reservationBindingSource1.DataMember = "reservation";
            this.reservationBindingSource1.DataSource = this.reservationSystemDataSet1;
            // 
            // reservationTableAdapter1
            // 
            this.reservationTableAdapter1.ClearBeforeFill = true;
            // 
            // dgvReservation
            // 
            this.dgvReservation.AllowUserToAddRows = false;
            this.dgvReservation.AllowUserToDeleteRows = false;
            this.dgvReservation.AutoGenerateColumns = false;
            this.dgvReservation.BackgroundColor = System.Drawing.Color.White;
            this.dgvReservation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.reservationIDDataGridViewTextBoxColumn,
            this.roomNameDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.startTimeDataGridViewTextBoxColumn,
            this.endTimeDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.dgvReservation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvReservation.DataSource = this.reservationBindingSource1;
            this.dgvReservation.GridColor = System.Drawing.Color.White;
            this.dgvReservation.Location = new System.Drawing.Point(32, 234);
            this.dgvReservation.Name = "dgvReservation";
            this.dgvReservation.ReadOnly = true;
            this.dgvReservation.RowHeadersWidth = 62;
            this.dgvReservation.RowTemplate.Height = 28;
            this.dgvReservation.Size = new System.Drawing.Size(992, 371);
            this.dgvReservation.TabIndex = 4;
            this.dgvReservation.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReservation_CellClick);
            this.dgvReservation.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReservation_CellContentClick);
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
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            this.statusDataGridViewTextBoxColumn.Width = 150;
            // 
            // cmbFilter
            // 
            this.cmbFilter.BackColor = System.Drawing.Color.LightYellow;
            this.cmbFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbFilter.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFilter.ForeColor = System.Drawing.Color.Gray;
            this.cmbFilter.FormattingEnabled = true;
            this.cmbFilter.Items.AddRange(new object[] {
            "All Status",
            "Pending",
            "Approved",
            "Rejected",
            "Cancelled"});
            this.cmbFilter.Location = new System.Drawing.Point(101, 55);
            this.cmbFilter.Name = "cmbFilter";
            this.cmbFilter.Size = new System.Drawing.Size(214, 31);
            this.cmbFilter.TabIndex = 5;
            this.cmbFilter.SelectedIndexChanged += new System.EventHandler(this.cmbFilter_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(97, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(262, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Display records via status:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(427, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Sort records by:";
            // 
            // cmbOrder
            // 
            this.cmbOrder.BackColor = System.Drawing.Color.LightYellow;
            this.cmbOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbOrder.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbOrder.ForeColor = System.Drawing.Color.Gray;
            this.cmbOrder.FormattingEnabled = true;
            this.cmbOrder.Items.AddRange(new object[] {
            "Date",
            "Reservation ID",
            "Room Name"});
            this.cmbOrder.Location = new System.Drawing.Point(431, 55);
            this.cmbOrder.Name = "cmbOrder";
            this.cmbOrder.Size = new System.Drawing.Size(212, 31);
            this.cmbOrder.TabIndex = 8;
            this.cmbOrder.SelectedIndexChanged += new System.EventHandler(this.cmbOrder_SelectedIndexChanged);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.BackgroundImage = global::IOOP_ASSIGNMENT.Properties.Resources.arrow_b_;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Location = new System.Drawing.Point(12, 25);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(48, 45);
            this.btnBack.TabIndex = 9;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnDisplay
            // 
            this.btnDisplay.BackColor = System.Drawing.Color.Black;
            this.btnDisplay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDisplay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnDisplay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDisplay.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplay.ForeColor = System.Drawing.Color.White;
            this.btnDisplay.Location = new System.Drawing.Point(711, 35);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(250, 51);
            this.btnDisplay.TabIndex = 10;
            this.btnDisplay.Text = "DISPLAY RESERVATION";
            this.btnDisplay.UseVisualStyleBackColor = false;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(253, 756);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(208, 23);
            this.label4.TabIndex = 11;
            this.label4.Text = "Change Reservation";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(649, 756);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(201, 23);
            this.label5.TabIndex = 12;
            this.label5.Text = "Cancel Reservation";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::IOOP_ASSIGNMENT.Properties.Resources.LOGO_white__shallow_;
            this.pictureBox2.Location = new System.Drawing.Point(944, -9);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(156, 102);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(97, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(611, 23);
            this.label6.TabIndex = 16;
            this.label6.Text = "Enter Reservation ID if you are searching for a specific record:";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtSearch.Location = new System.Drawing.Point(101, 142);
            this.txtSearch.MinimumSize = new System.Drawing.Size(343, 32);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(343, 32);
            this.txtSearch.TabIndex = 17;
            this.txtSearch.Text = "Enter Reservation ID";
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Black;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearch.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(711, 117);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(250, 51);
            this.btnSearch.TabIndex = 18;
            this.btnSearch.Text = "SEARCH RESERVATION";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblResults
            // 
            this.lblResults.AutoSize = true;
            this.lblResults.BackColor = System.Drawing.Color.Transparent;
            this.lblResults.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResults.ForeColor = System.Drawing.Color.DimGray;
            this.lblResults.Location = new System.Drawing.Point(459, 145);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(0, 23);
            this.lblResults.TabIndex = 19;
            this.lblResults.Click += new System.EventHandler(this.lblResults_Click);
            // 
            // frmStudentReservationRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::IOOP_ASSIGNMENT.Properties.Resources.yellow_fradient;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1059, 802);
            this.Controls.Add(this.lblResults);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.cmbOrder);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbFilter);
            this.Controls.Add(this.dgvReservation);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.label1);
            this.Name = "frmStudentReservationRecords";
            this.Text = "Discussion Room Reservation Records";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmStudentReservationRecords_FormClosed);
            this.Load += new System.EventHandler(this.frmStudentReservationRecords_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reservationSystemDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnCancel;
        private ReservationSystemDataSet1TableAdapters.reservationTableAdapter reservationTableAdapter;
        private ReservationSystemDataSet1 reservationSystemDataSet1;
        private System.Windows.Forms.BindingSource reservationBindingSource1;
        private ReservationSystemDataSet1TableAdapters.reservationTableAdapter reservationTableAdapter1;
        private System.Windows.Forms.DataGridView dgvReservation;
        private System.Windows.Forms.DataGridViewTextBoxColumn reservationIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox cmbFilter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbOrder;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblResults;
    }
}