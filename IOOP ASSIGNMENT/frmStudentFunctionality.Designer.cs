
namespace IOOP_ASSIGNMENT
{
    partial class frmStudentFunctionality
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
            this.lblWelcomeStudent = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblResR = new System.Windows.Forms.Label();
            this.lblResRcd = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnRecords = new System.Windows.Forms.Button();
            this.btnReserve = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWelcomeStudent
            // 
            this.lblWelcomeStudent.AutoSize = true;
            this.lblWelcomeStudent.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcomeStudent.ForeColor = System.Drawing.Color.Gold;
            this.lblWelcomeStudent.Location = new System.Drawing.Point(75, 43);
            this.lblWelcomeStudent.Name = "lblWelcomeStudent";
            this.lblWelcomeStudent.Size = new System.Drawing.Size(151, 36);
            this.lblWelcomeStudent.TabIndex = 0;
            this.lblWelcomeStudent.Text = "Welcome";
            this.lblWelcomeStudent.Click += new System.EventHandler(this.lblWelcomeStudent_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(4, 363);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "You can reserve a room via this portal.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(310, 355);
            this.label2.MaximumSize = new System.Drawing.Size(300, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(289, 92);
            this.label2.TabIndex = 4;
            this.label2.Text = "View details of your reservation, you may also cancel or change your reservations" +
    ", approval subjected to librarian.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblResR
            // 
            this.lblResR.AutoSize = true;
            this.lblResR.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResR.ForeColor = System.Drawing.Color.Gray;
            this.lblResR.Location = new System.Drawing.Point(40, 305);
            this.lblResR.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResR.Name = "lblResR";
            this.lblResR.Size = new System.Drawing.Size(237, 33);
            this.lblResR.TabIndex = 6;
            this.lblResR.Text = "Reserve A Room";
            // 
            // lblResRcd
            // 
            this.lblResRcd.AutoSize = true;
            this.lblResRcd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblResRcd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResRcd.ForeColor = System.Drawing.Color.Gray;
            this.lblResRcd.Location = new System.Drawing.Point(306, 308);
            this.lblResRcd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResRcd.Name = "lblResRcd";
            this.lblResRcd.Size = new System.Drawing.Size(288, 33);
            this.lblResRcd.TabIndex = 7;
            this.lblResRcd.Text = "Reservation Records";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.lblWelcomeStudent);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.lblResR);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnRecords);
            this.panel2.Controls.Add(this.btnReserve);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lblResRcd);
            this.panel2.Location = new System.Drawing.Point(42, 69);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(644, 494);
            this.panel2.TabIndex = 10;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::IOOP_ASSIGNMENT.Properties.Resources.LOGO_shallow;
            this.pictureBox1.Location = new System.Drawing.Point(506, -5);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(166, 106);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnRecords
            // 
            this.btnRecords.BackgroundImage = global::IOOP_ASSIGNMENT.Properties.Resources.report2;
            this.btnRecords.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRecords.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRecords.FlatAppearance.BorderSize = 0;
            this.btnRecords.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnRecords.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnRecords.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecords.Location = new System.Drawing.Point(358, 111);
            this.btnRecords.Name = "btnRecords";
            this.btnRecords.Size = new System.Drawing.Size(189, 177);
            this.btnRecords.TabIndex = 3;
            this.btnRecords.UseVisualStyleBackColor = true;
            this.btnRecords.Click += new System.EventHandler(this.btnRecords_Click);
            // 
            // btnReserve
            // 
            this.btnReserve.BackgroundImage = global::IOOP_ASSIGNMENT.Properties.Resources._8863292;
            this.btnReserve.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReserve.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReserve.FlatAppearance.BorderSize = 0;
            this.btnReserve.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnReserve.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnReserve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReserve.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReserve.ForeColor = System.Drawing.Color.Gold;
            this.btnReserve.Location = new System.Drawing.Point(72, 117);
            this.btnReserve.Name = "btnReserve";
            this.btnReserve.Size = new System.Drawing.Size(172, 160);
            this.btnReserve.TabIndex = 1;
            this.btnReserve.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReserve.UseVisualStyleBackColor = true;
            this.btnReserve.Click += new System.EventHandler(this.btnReserve_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackgroundImage = global::IOOP_ASSIGNMENT.Properties.Resources.arrow_b_;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Location = new System.Drawing.Point(16, 17);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(48, 45);
            this.btnBack.TabIndex = 5;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmStudentFunctionality
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(704, 597);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnBack);
            this.Name = "frmStudentFunctionality";
            this.Text = "Discussion Room Reservation System";
            this.Load += new System.EventHandler(this.frmStudentFunctionality_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblWelcomeStudent;
        private System.Windows.Forms.Button btnReserve;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRecords;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblResR;
        private System.Windows.Forms.Label lblResRcd;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
    }
}