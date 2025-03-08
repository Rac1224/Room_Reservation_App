
namespace IOOP_ASSIGNMENT
{
    partial class frmLibrarianFunctionality
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
            this.lblWelcomeLibrarian = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblDDR = new System.Windows.Forms.Label();
            this.lblRRC = new System.Windows.Forms.Label();
            this.btnMonthlyReport = new System.Windows.Forms.Button();
            this.btnDailyReport = new System.Windows.Forms.Button();
            this.btnReservationChanges = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWelcomeLibrarian
            // 
            this.lblWelcomeLibrarian.AutoSize = true;
            this.lblWelcomeLibrarian.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcomeLibrarian.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lblWelcomeLibrarian.Location = new System.Drawing.Point(128, 28);
            this.lblWelcomeLibrarian.Name = "lblWelcomeLibrarian";
            this.lblWelcomeLibrarian.Size = new System.Drawing.Size(173, 38);
            this.lblWelcomeLibrarian.TabIndex = 0;
            this.lblWelcomeLibrarian.Text = "Welcome!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(98, 322);
            this.label2.MaximumSize = new System.Drawing.Size(250, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(229, 46);
            this.label2.TabIndex = 5;
            this.label2.Text = "Check for reservation change requests from students";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(88, 631);
            this.label3.MaximumSize = new System.Drawing.Size(250, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(216, 46);
            this.label3.TabIndex = 6;
            this.label3.Text = "View daily discussion room reservation in the library";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(442, 322);
            this.label4.MaximumSize = new System.Drawing.Size(250, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(209, 46);
            this.label4.TabIndex = 7;
            this.label4.Text = "View a report of all room reservations for the month";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(432, 629);
            this.label1.MaximumSize = new System.Drawing.Size(250, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 46);
            this.label1.TabIndex = 10;
            this.label1.Text = "Search reservation records via Reservation ID or Student ID";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lblDDR);
            this.panel1.Controls.Add(this.lblRRC);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnMonthlyReport);
            this.panel1.Controls.Add(this.btnDailyReport);
            this.panel1.Controls.Add(this.btnReservationChanges);
            this.panel1.Controls.Add(this.lblWelcomeLibrarian);
            this.panel1.Location = new System.Drawing.Point(48, 60);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(742, 711);
            this.panel1.TabIndex = 11;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = global::IOOP_ASSIGNMENT.Properties.Resources.loupe;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(480, 125);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(128, 118);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::IOOP_ASSIGNMENT.Properties.Resources.LOGO_shallow;
            this.pictureBox1.Location = new System.Drawing.Point(594, -5);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(184, 122);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gold;
            this.label6.Location = new System.Drawing.Point(368, 592);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(318, 25);
            this.label6.TabIndex = 14;
            this.label6.Text = "Monthly Room Utilization Report";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gold;
            this.label5.Location = new System.Drawing.Point(382, 277);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(339, 29);
            this.label5.TabIndex = 13;
            this.label5.Text = "Search ReservationRecords";
            // 
            // lblDDR
            // 
            this.lblDDR.AutoSize = true;
            this.lblDDR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDDR.ForeColor = System.Drawing.Color.Gold;
            this.lblDDR.Location = new System.Drawing.Point(42, 589);
            this.lblDDR.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDDR.Name = "lblDDR";
            this.lblDDR.Size = new System.Drawing.Size(249, 25);
            this.lblDDR.TabIndex = 12;
            this.lblDDR.Text = "Daily Reservation Report";
            // 
            // lblRRC
            // 
            this.lblRRC.AutoSize = true;
            this.lblRRC.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRRC.ForeColor = System.Drawing.Color.Gold;
            this.lblRRC.Location = new System.Drawing.Point(30, 275);
            this.lblRRC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRRC.Name = "lblRRC";
            this.lblRRC.Size = new System.Drawing.Size(338, 29);
            this.lblRRC.TabIndex = 11;
            this.lblRRC.Text = "Room Reservation Changes";
            // 
            // btnMonthlyReport
            // 
            this.btnMonthlyReport.BackgroundImage = global::IOOP_ASSIGNMENT.Properties.Resources.report_y_;
            this.btnMonthlyReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMonthlyReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMonthlyReport.FlatAppearance.BorderSize = 0;
            this.btnMonthlyReport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnMonthlyReport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnMonthlyReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMonthlyReport.Location = new System.Drawing.Point(477, 400);
            this.btnMonthlyReport.Name = "btnMonthlyReport";
            this.btnMonthlyReport.Size = new System.Drawing.Size(156, 165);
            this.btnMonthlyReport.TabIndex = 3;
            this.btnMonthlyReport.UseVisualStyleBackColor = true;
            this.btnMonthlyReport.Click += new System.EventHandler(this.btnMonthlyReport_Click);
            // 
            // btnDailyReport
            // 
            this.btnDailyReport.BackgroundImage = global::IOOP_ASSIGNMENT.Properties.Resources._4341726;
            this.btnDailyReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDailyReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDailyReport.FlatAppearance.BorderSize = 0;
            this.btnDailyReport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDailyReport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDailyReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDailyReport.Location = new System.Drawing.Point(123, 400);
            this.btnDailyReport.Name = "btnDailyReport";
            this.btnDailyReport.Size = new System.Drawing.Size(171, 165);
            this.btnDailyReport.TabIndex = 2;
            this.btnDailyReport.UseVisualStyleBackColor = true;
            this.btnDailyReport.Click += new System.EventHandler(this.btnDailyReport_Click);
            // 
            // btnReservationChanges
            // 
            this.btnReservationChanges.BackgroundImage = global::IOOP_ASSIGNMENT.Properties.Resources._3277724;
            this.btnReservationChanges.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReservationChanges.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReservationChanges.FlatAppearance.BorderSize = 0;
            this.btnReservationChanges.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnReservationChanges.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnReservationChanges.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReservationChanges.Location = new System.Drawing.Point(120, 103);
            this.btnReservationChanges.Name = "btnReservationChanges";
            this.btnReservationChanges.Size = new System.Drawing.Size(171, 165);
            this.btnReservationChanges.TabIndex = 1;
            this.btnReservationChanges.UseVisualStyleBackColor = true;
            this.btnReservationChanges.Click += new System.EventHandler(this.btnReservationChanges_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackgroundImage = global::IOOP_ASSIGNMENT.Properties.Resources.arrow_y_;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Location = new System.Drawing.Point(22, 17);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(48, 45);
            this.btnBack.TabIndex = 8;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmLibrarianFunctionality
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(808, 792);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnBack);
            this.Name = "frmLibrarianFunctionality";
            this.Text = "Discussion Room Reservation System";
            this.Load += new System.EventHandler(this.frmLibrarianFunctionality_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblWelcomeLibrarian;
        private System.Windows.Forms.Button btnReservationChanges;
        private System.Windows.Forms.Button btnDailyReport;
        private System.Windows.Forms.Button btnMonthlyReport;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblDDR;
        private System.Windows.Forms.Label lblRRC;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}