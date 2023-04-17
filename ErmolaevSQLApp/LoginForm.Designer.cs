namespace ErmolaevSQLApp
{
	partial class LoginForm
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.ButtonLogin = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.SvBtt = new System.Windows.Forms.Label();
			this.CloseButton = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.Login = new System.Windows.Forms.TextBox();
			this.Password = new System.Windows.Forms.TextBox();
			this.MainMenu = new System.Windows.Forms.Panel();
			this.Regist = new System.Windows.Forms.Label();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.panel1.SuspendLayout();
			this.MainMenu.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			this.SuspendLayout();
			// 
			// ButtonLogin
			// 
			this.ButtonLogin.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.ButtonLogin.Cursor = System.Windows.Forms.Cursors.Hand;
			this.ButtonLogin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.ButtonLogin.FlatAppearance.BorderSize = 3;
			this.ButtonLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.ButtonLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.ButtonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ButtonLogin.Font = new System.Drawing.Font("Segoe Print", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.ButtonLogin.Location = new System.Drawing.Point(12, 357);
			this.ButtonLogin.Name = "ButtonLogin";
			this.ButtonLogin.Size = new System.Drawing.Size(600, 70);
			this.ButtonLogin.TabIndex = 0;
			this.ButtonLogin.Text = "Войти";
			this.ButtonLogin.UseVisualStyleBackColor = false;
			this.ButtonLogin.Click += new System.EventHandler(this.ButtonLogin_Click);
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
			this.panel1.Size = new System.Drawing.Size(624, 138);
			this.panel1.TabIndex = 1;
			this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
			this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
			// 
			// SvBtt
			// 
			this.SvBtt.AutoSize = true;
			this.SvBtt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.SvBtt.Location = new System.Drawing.Point(567, -4);
			this.SvBtt.Name = "SvBtt";
			this.SvBtt.Size = new System.Drawing.Size(19, 25);
			this.SvBtt.TabIndex = 7;
			this.SvBtt.Text = "-";
			this.SvBtt.Click += new System.EventHandler(this.SvBtt_Click);
			this.SvBtt.MouseEnter += new System.EventHandler(this.SvBtt_MouseEnter);
			this.SvBtt.MouseLeave += new System.EventHandler(this.SvBtt_MouseLeave);
			// 
			// CloseButton
			// 
			this.CloseButton.AutoSize = true;
			this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.CloseButton.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.CloseButton.Location = new System.Drawing.Point(592, 1);
			this.CloseButton.Name = "CloseButton";
			this.CloseButton.Size = new System.Drawing.Size(20, 20);
			this.CloseButton.TabIndex = 2;
			this.CloseButton.Text = "X";
			this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click_1);
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
			this.label1.Size = new System.Drawing.Size(624, 138);
			this.label1.TabIndex = 0;
			this.label1.Text = "Авторизация";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
			this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label1_MouseMove);
			// 
			// Login
			// 
			this.Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Login.Location = new System.Drawing.Point(117, 156);
			this.Login.Multiline = true;
			this.Login.Name = "Login";
			this.Login.Size = new System.Drawing.Size(433, 64);
			this.Login.TabIndex = 3;
			this.Login.Enter += new System.EventHandler(this.Login_Enter);
			this.Login.Leave += new System.EventHandler(this.Login_Leave);
			// 
			// Password
			// 
			this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Password.Location = new System.Drawing.Point(117, 244);
			this.Password.Name = "Password";
			this.Password.Size = new System.Drawing.Size(433, 47);
			this.Password.TabIndex = 5;
			this.Password.UseSystemPasswordChar = true;
			this.Password.Enter += new System.EventHandler(this.Password_Enter);
			this.Password.Leave += new System.EventHandler(this.Password_Leave);
			// 
			// MainMenu
			// 
			this.MainMenu.Controls.Add(this.pictureBox3);
			this.MainMenu.Controls.Add(this.Regist);
			this.MainMenu.Dock = System.Windows.Forms.DockStyle.Fill;
			this.MainMenu.Location = new System.Drawing.Point(0, 0);
			this.MainMenu.Name = "MainMenu";
			this.MainMenu.Size = new System.Drawing.Size(624, 562);
			this.MainMenu.TabIndex = 6;
			this.MainMenu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainMenu_MouseDown);
			this.MainMenu.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainMenu_MouseMove);
			// 
			// Regist
			// 
			this.Regist.AutoSize = true;
			this.Regist.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Regist.Location = new System.Drawing.Point(69, 458);
			this.Regist.Name = "Regist";
			this.Regist.Size = new System.Drawing.Size(496, 33);
			this.Regist.TabIndex = 0;
			this.Regist.Text = "Вы не зарегистрированы? Зарегистрируйтесь!";
			this.Regist.Click += new System.EventHandler(this.Regist_Click);
			this.Regist.MouseEnter += new System.EventHandler(this.Regist_MouseEnter);
			this.Regist.MouseLeave += new System.EventHandler(this.Regist_MouseLeave);
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = global::ErmolaevSQLApp.Properties.Resources._lock;
			this.pictureBox2.Location = new System.Drawing.Point(12, 244);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(70, 64);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox2.TabIndex = 4;
			this.pictureBox2.TabStop = false;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::ErmolaevSQLApp.Properties.Resources._34267_browser_earth_global_globe_international_icon;
			this.pictureBox1.Location = new System.Drawing.Point(12, 156);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(70, 64);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 2;
			this.pictureBox1.TabStop = false;
			// 
			// pictureBox3
			// 
			this.pictureBox3.Image = global::ErmolaevSQLApp.Properties.Resources._8530588_eye_slash_icon;
			this.pictureBox3.Location = new System.Drawing.Point(556, 244);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(65, 64);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox3.TabIndex = 1;
			this.pictureBox3.TabStop = false;
			this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
			this.pictureBox3.MouseLeave += new System.EventHandler(this.pictureBox3_MouseLeave);
			// 
			// LoginForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Info;
			this.ClientSize = new System.Drawing.Size(624, 562);
			this.Controls.Add(this.Password);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.Login);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.ButtonLogin);
			this.Controls.Add(this.MainMenu);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "LoginForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "LoginForm";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.MainMenu.ResumeLayout(false);
			this.MainMenu.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button ButtonLogin;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label CloseButton;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.TextBox Login;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.TextBox Password;
		private System.Windows.Forms.Panel MainMenu;
		private System.Windows.Forms.Label Regist;
		private System.Windows.Forms.Label SvBtt;
		private System.Windows.Forms.PictureBox pictureBox3;
	}
}

