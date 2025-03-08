
namespace IOOP_ASSIGNMENT
{
    partial class frmStart
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
            this.grbUser = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picBox1 = new System.Windows.Forms.PictureBox();
            this.rdnLibrarian = new System.Windows.Forms.RadioButton();
            this.rdnStudent = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.lblSignUp = new System.Windows.Forms.Label();
            this.lblNoAcc = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.grbUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // grbUser
            // 
            this.grbUser.Controls.Add(this.pictureBox1);
            this.grbUser.Controls.Add(this.picBox1);
            this.grbUser.Controls.Add(this.rdnLibrarian);
            this.grbUser.Controls.Add(this.rdnStudent);
            this.grbUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grbUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbUser.ForeColor = System.Drawing.Color.Gold;
            this.grbUser.Location = new System.Drawing.Point(414, 91);
            this.grbUser.Name = "grbUser";
            this.grbUser.Size = new System.Drawing.Size(453, 252);
            this.grbUser.TabIndex = 2;
            this.grbUser.TabStop = false;
            this.grbUser.Text = "Select User Type:";
            this.grbUser.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::IOOP_ASSIGNMENT.Properties.Resources.librarian;
            this.pictureBox1.Location = new System.Drawing.Point(256, 51);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(142, 138);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // picBox1
            // 
            this.picBox1.BackColor = System.Drawing.Color.White;
            this.picBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBox1.Image = global::IOOP_ASSIGNMENT.Properties.Resources.student;
            this.picBox1.Location = new System.Drawing.Point(27, 51);
            this.picBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picBox1.Name = "picBox1";
            this.picBox1.Size = new System.Drawing.Size(146, 138);
            this.picBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox1.TabIndex = 2;
            this.picBox1.TabStop = false;
            // 
            // rdnLibrarian
            // 
            this.rdnLibrarian.AutoSize = true;
            this.rdnLibrarian.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdnLibrarian.Location = new System.Drawing.Point(256, 197);
            this.rdnLibrarian.Name = "rdnLibrarian";
            this.rdnLibrarian.Size = new System.Drawing.Size(114, 26);
            this.rdnLibrarian.TabIndex = 1;
            this.rdnLibrarian.TabStop = true;
            this.rdnLibrarian.Text = "Librarian";
            this.rdnLibrarian.UseVisualStyleBackColor = true;
            // 
            // rdnStudent
            // 
            this.rdnStudent.AutoSize = true;
            this.rdnStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdnStudent.Location = new System.Drawing.Point(40, 197);
            this.rdnStudent.Name = "rdnStudent";
            this.rdnStudent.Size = new System.Drawing.Size(104, 26);
            this.rdnStudent.TabIndex = 0;
            this.rdnStudent.TabStop = true;
            this.rdnStudent.Text = "Student";
            this.rdnStudent.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(468, 348);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "User ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(446, 405);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password:";
            // 
            // txtUserID
            // 
            this.txtUserID.BackColor = System.Drawing.Color.LightYellow;
            this.txtUserID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserID.ForeColor = System.Drawing.Color.DimGray;
            this.txtUserID.Location = new System.Drawing.Point(600, 343);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(234, 30);
            this.txtUserID.TabIndex = 5;
            // 
            // btnSignIn
            // 
            this.btnSignIn.BackColor = System.Drawing.Color.Gold;
            this.btnSignIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSignIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignIn.FlatAppearance.BorderColor = System.Drawing.Color.Goldenrod;
            this.btnSignIn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSignIn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSignIn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignIn.ForeColor = System.Drawing.Color.White;
            this.btnSignIn.Location = new System.Drawing.Point(564, 462);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(190, 45);
            this.btnSignIn.TabIndex = 8;
            this.btnSignIn.Text = "SIGN IN";
            this.btnSignIn.UseVisualStyleBackColor = false;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.DimGray;
            this.txtPassword.Location = new System.Drawing.Point(600, 400);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(234, 30);
            this.txtPassword.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(144, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(624, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to CJR University Room Reservation System";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gold;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(876, 78);
            this.panel1.TabIndex = 13;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::IOOP_ASSIGNMENT.Properties.Resources.LOGO_white;
            this.pictureBox5.Location = new System.Drawing.Point(27, 0);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(120, 78);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 2;
            this.pictureBox5.TabStop = false;
            // 
            // lblSignUp
            // 
            this.lblSignUp.AutoSize = true;
            this.lblSignUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignUp.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblSignUp.Location = new System.Drawing.Point(597, 515);
            this.lblSignUp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSignUp.Name = "lblSignUp";
            this.lblSignUp.Size = new System.Drawing.Size(163, 20);
            this.lblSignUp.TabIndex = 14;
            this.lblSignUp.Text = "Create New Account";
            this.lblSignUp.Click += new System.EventHandler(this.lblSignUp_Click);
            // 
            // lblNoAcc
            // 
            this.lblNoAcc.AutoSize = true;
            this.lblNoAcc.ForeColor = System.Drawing.Color.Gold;
            this.lblNoAcc.Location = new System.Drawing.Point(496, 515);
            this.lblNoAcc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNoAcc.Name = "lblNoAcc";
            this.lblNoAcc.Size = new System.Drawing.Size(99, 20);
            this.lblNoAcc.TabIndex = 15;
            this.lblNoAcc.Text = "No account?";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::IOOP_ASSIGNMENT.Properties.Resources.secure_icon_png_4988;
            this.pictureBox4.Location = new System.Drawing.Point(566, 400);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(34, 34);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 17;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::IOOP_ASSIGNMENT.Properties.Resources.user;
            this.pictureBox2.Location = new System.Drawing.Point(568, 343);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::IOOP_ASSIGNMENT.Properties.Resources._20fae4a3dfe347c4e99d8b29eb290df9;
            this.pictureBox3.Location = new System.Drawing.Point(22, 102);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(390, 406);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // frmStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(876, 558);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblNoAcc);
            this.Controls.Add(this.lblSignUp);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnSignIn);
            this.Controls.Add(this.txtUserID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.grbUser);
            this.Name = "frmStart";
            this.Text = "Discussion Room Reservation System";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbUser.ResumeLayout(false);
            this.grbUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox grbUser;
        private System.Windows.Forms.RadioButton rdnLibrarian;
        private System.Windows.Forms.RadioButton rdnStudent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.MaskedTextBox txtPassword;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox picBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblSignUp;
        private System.Windows.Forms.Label lblNoAcc;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
    }
}

