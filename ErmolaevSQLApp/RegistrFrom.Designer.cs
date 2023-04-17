namespace ErmolaevSQLApp
{
	partial class RegistrFrom
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.CloseButton = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.MainMenu = new System.Windows.Forms.Panel();
			this.UserSurname = new System.Windows.Forms.TextBox();
			this.UserName = new System.Windows.Forms.TextBox();
			this.Login = new System.Windows.Forms.TextBox();
			this.Password = new System.Windows.Forms.TextBox();
			this.ButtonRegister = new System.Windows.Forms.Button();
			this.Avto = new System.Windows.Forms.Label();
			this.SvBtt = new System.Windows.Forms.Label();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.panel1.SuspendLayout();
			this.MainMenu.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.panel1.Controls.Add(this.SvBtt);
			this.panel1.Controls.Add(this.CloseButton);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(644, 138);
			this.panel1.TabIndex = 2;
			this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
			this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
			// 
			// CloseButton
			// 
			this.CloseButton.AutoSize = true;
			this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.CloseButton.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.CloseButton.Location = new System.Drawing.Point(612, 9);
			this.CloseButton.Name = "CloseButton";
			this.CloseButton.Size = new System.Drawing.Size(20, 20);
			this.CloseButton.TabIndex = 2;
			this.CloseButton.Text = "X";
			this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
			this.CloseButton.MouseEnter += new System.EventHandler(this.CloseButton_MouseEnter);
			this.CloseButton.MouseLeave += new System.EventHandler(this.CloseButton_MouseLeave);
			// 
			// label1
			// 
			this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label1.Font = new System.Drawing.Font("SimSun", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.MenuText;
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(644, 138);
			this.label1.TabIndex = 0;
			this.label1.Text = "Регистрация";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
			this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label1_MouseMove);
			// 
			// MainMenu
			// 
			this.MainMenu.BackColor = System.Drawing.SystemColors.Info;
			this.MainMenu.Controls.Add(this.pictureBox4);
			this.MainMenu.Controls.Add(this.Avto);
			this.MainMenu.Controls.Add(this.pictureBox3);
			this.MainMenu.Controls.Add(this.UserSurname);
			this.MainMenu.Controls.Add(this.UserName);
			this.MainMenu.Controls.Add(this.Login);
			this.MainMenu.Controls.Add(this.Password);
			this.MainMenu.Controls.Add(this.ButtonRegister);
			this.MainMenu.Controls.Add(this.pictureBox1);
			this.MainMenu.Controls.Add(this.pictureBox2);
			this.MainMenu.Dock = System.Windows.Forms.DockStyle.Fill;
			this.MainMenu.Location = new System.Drawing.Point(0, 138);
			this.MainMenu.Name = "MainMenu";
			this.MainMenu.Size = new System.Drawing.Size(644, 469);
			this.MainMenu.TabIndex = 7;
			this.MainMenu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainMenu_MouseDown);
			this.MainMenu.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainMenu_MouseMove);
			// 
			// UserSurname
			// 
			this.UserSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.UserSurname.Location = new System.Drawing.Point(102, 90);
			this.UserSurname.Multiline = true;
			this.UserSurname.Name = "UserSurname";
			this.UserSurname.Size = new System.Drawing.Size(462, 64);
			this.UserSurname.TabIndex = 14;
			this.UserSurname.Enter += new System.EventHandler(this.UserSurname_Enter);
			this.UserSurname.Leave += new System.EventHandler(this.UserSurname_Leave);
			// 
			// UserName
			// 
			this.UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.UserName.Location = new System.Drawing.Point(102, 20);
			this.UserName.Multiline = true;
			this.UserName.Name = "UserName";
			this.UserName.Size = new System.Drawing.Size(462, 64);
			this.UserName.TabIndex = 13;
			this.UserName.Enter += new System.EventHandler(this.UserName_Enter);
			this.UserName.Leave += new System.EventHandler(this.UserName_Leave);
			// 
			// Login
			// 
			this.Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Login.Location = new System.Drawing.Point(102, 160);
			this.Login.Multiline = true;
			this.Login.Name = "Login";
			this.Login.Size = new System.Drawing.Size(462, 64);
			this.Login.TabIndex = 10;
			this.Login.Enter += new System.EventHandler(this.Login_Enter);
			this.Login.Leave += new System.EventHandler(this.Login_Leave);
			// 
			// Password
			// 
			this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Password.Location = new System.Drawing.Point(102, 230);
			this.Password.Name = "Password";
			this.Password.Size = new System.Drawing.Size(462, 47);
			this.Password.TabIndex = 12;
			this.Password.UseSystemPasswordChar = true;
			this.Password.Enter += new System.EventHandler(this.Password_Enter);
			this.Password.Leave += new System.EventHandler(this.Password_Leave);
			// 
			// ButtonRegister
			// 
			this.ButtonRegister.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.ButtonRegister.Cursor = System.Windows.Forms.Cursors.Hand;
			this.ButtonRegister.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.ButtonRegister.FlatAppearance.BorderSize = 3;
			this.ButtonRegister.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.ButtonRegister.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.ButtonRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ButtonRegister.Font = new System.Drawing.Font("Segoe Print", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.ButtonRegister.Location = new System.Drawing.Point(12, 312);
			this.ButtonRegister.Name = "ButtonRegister";
			this.ButtonRegister.Size = new System.Drawing.Size(620, 70);
			this.ButtonRegister.TabIndex = 8;
			this.ButtonRegister.Text = "Зарегистрироваться";
			this.ButtonRegister.UseVisualStyleBackColor = false;
			this.ButtonRegister.Click += new System.EventHandler(this.ButtonRegister_Click);
			// 
			// Avto
			// 
			this.Avto.AutoSize = true;
			this.Avto.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Avto.Location = new System.Drawing.Point(191, 400);
			this.Avto.Name = "Avto";
			this.Avto.Size = new System.Drawing.Size(264, 33);
			this.Avto.TabIndex = 16;
			this.Avto.Text = "Перейти к авторизации";
			this.Avto.Click += new System.EventHandler(this.Avto_Click);
			this.Avto.MouseEnter += new System.EventHandler(this.Avto_MouseEnter);
			this.Avto.MouseLeave += new System.EventHandler(this.Avto_MouseLeave);
			// 
			// SvBtt
			// 
			this.SvBtt.AutoSize = true;
			this.SvBtt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.SvBtt.Location = new System.Drawing.Point(587, 5);
			this.SvBtt.Name = "SvBtt";
			this.SvBtt.Size = new System.Drawing.Size(19, 25);
			this.SvBtt.TabIndex = 3;
			this.SvBtt.Text = "-";
			this.SvBtt.Click += new System.EventHandler(this.SvBtt_Click);
			this.SvBtt.MouseEnter += new System.EventHandler(this.SvBtt_MouseEnter);
			this.SvBtt.MouseLeave += new System.EventHandler(this.SvBtt_MouseLeave);
			// 
			// pictureBox3
			// 
			this.pictureBox3.Image = global::ErmolaevSQLApp.Properties.Resources._34267_browser_earth_global_globe_international_icon;
			this.pictureBox3.Location = new System.Drawing.Point(12, 160);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(70, 64);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox3.TabIndex = 15;
			this.pictureBox3.TabStop = false;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::ErmolaevSQLApp.Properties.Resources.user;
			this.pictureBox1.Location = new System.Drawing.Point(12, 20);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(70, 64);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 9;
			this.pictureBox1.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = global::ErmolaevSQLApp.Properties.Resources._lock;
			this.pictureBox2.Location = new System.Drawing.Point(12, 230);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(70, 64);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox2.TabIndex = 11;
			this.pictureBox2.TabStop = false;
			// 
			// pictureBox4
			// 
			this.pictureBox4.Image = global::ErmolaevSQLApp.Properties.Resources._8530588_eye_slash_icon;
			this.pictureBox4.Location = new System.Drawing.Point(570, 230);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(65, 64);
			this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox4.TabIndex = 8;
			this.pictureBox4.TabStop = false;
			this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
			this.pictureBox4.MouseLeave += new System.EventHandler(this.pictureBox4_MouseLeave);
			// 
			// RegistrFrom
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(644, 607);
			this.Controls.Add(this.MainMenu);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "RegistrFrom";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "RegistrFrom";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.MainMenu.ResumeLayout(false);
			this.MainMenu.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label CloseButton;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel MainMenu;
		private System.Windows.Forms.TextBox Password;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.TextBox Login;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button ButtonRegister;
		private System.Windows.Forms.TextBox UserSurname;
		private System.Windows.Forms.TextBox UserName;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.Label Avto;
		private System.Windows.Forms.Label SvBtt;
		private System.Windows.Forms.PictureBox pictureBox4;
	}
}