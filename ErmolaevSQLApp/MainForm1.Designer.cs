namespace ErmolaevSQLApp
{
	partial class MainForm1
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
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.SvBtt = new System.Windows.Forms.Label();
			this.CloseButton = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.MainMenu = new System.Windows.Forms.Panel();
			this.button4 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.ButtonLogin = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.DTgredd = new System.Windows.Forms.DataGridView();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.MainMenu.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.DTgredd)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Controls.Add(this.SvBtt);
			this.panel1.Controls.Add(this.CloseButton);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1252, 138);
			this.panel1.TabIndex = 2;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::ErmolaevSQLApp.Properties.Resources.Project1_Icon;
			this.pictureBox1.Location = new System.Drawing.Point(12, 4);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(124, 134);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 8;
			this.pictureBox1.TabStop = false;
			// 
			// SvBtt
			// 
			this.SvBtt.AutoSize = true;
			this.SvBtt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.SvBtt.Location = new System.Drawing.Point(1195, 0);
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
			this.CloseButton.Location = new System.Drawing.Point(1220, 4);
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
			this.label1.Size = new System.Drawing.Size(1252, 138);
			this.label1.TabIndex = 0;
			this.label1.Text = " База данных фотомастерской";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
			this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label1_MouseMove);
			// 
			// MainMenu
			// 
			this.MainMenu.Controls.Add(this.button4);
			this.MainMenu.Controls.Add(this.button3);
			this.MainMenu.Controls.Add(this.button2);
			this.MainMenu.Controls.Add(this.ButtonLogin);
			this.MainMenu.Controls.Add(this.label2);
			this.MainMenu.Controls.Add(this.DTgredd);
			this.MainMenu.Dock = System.Windows.Forms.DockStyle.Fill;
			this.MainMenu.Location = new System.Drawing.Point(0, 138);
			this.MainMenu.Name = "MainMenu";
			this.MainMenu.Size = new System.Drawing.Size(1252, 458);
			this.MainMenu.TabIndex = 3;
			this.MainMenu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainMenu_MouseDown);
			this.MainMenu.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainMenu_MouseMove);
			// 
			// button4
			// 
			this.button4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.button4.FlatAppearance.BorderSize = 3;
			this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button4.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button4.Location = new System.Drawing.Point(12, 170);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(272, 70);
			this.button4.TabIndex = 6;
			this.button4.Text = "Таблица \"Заказчики\"";
			this.button4.UseVisualStyleBackColor = false;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.button3.FlatAppearance.BorderSize = 3;
			this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button3.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button3.Location = new System.Drawing.Point(12, 359);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(272, 70);
			this.button3.TabIndex = 5;
			this.button3.Text = "Таблица \"Прайс-лист работ\"";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.button2.FlatAppearance.BorderSize = 3;
			this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button2.Location = new System.Drawing.Point(12, 266);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(272, 70);
			this.button2.TabIndex = 4;
			this.button2.Text = "Таблица \"Исполнители\"";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.button2_Click);
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
			this.ButtonLogin.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.ButtonLogin.Location = new System.Drawing.Point(12, 75);
			this.ButtonLogin.Name = "ButtonLogin";
			this.ButtonLogin.Size = new System.Drawing.Size(272, 70);
			this.ButtonLogin.TabIndex = 2;
			this.ButtonLogin.Text = "Таблица \"Журнал заказазов\"";
			this.ButtonLogin.UseVisualStyleBackColor = false;
			this.ButtonLogin.Click += new System.EventHandler(this.ButtonLogin_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(2, 15);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(282, 33);
			this.label2.TabIndex = 1;
			this.label2.Text = "Вернуться к авторизации";
			this.label2.Click += new System.EventHandler(this.label2_Click);
			this.label2.MouseEnter += new System.EventHandler(this.label2_MouseEnter);
			this.label2.MouseLeave += new System.EventHandler(this.label2_MouseLeave);
			// 
			// DTgredd
			// 
			this.DTgredd.AllowUserToAddRows = false;
			this.DTgredd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.DTgredd.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
			this.DTgredd.BackgroundColor = System.Drawing.SystemColors.Info;
			this.DTgredd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DTgredd.Location = new System.Drawing.Point(290, 0);
			this.DTgredd.Name = "DTgredd";
			this.DTgredd.Size = new System.Drawing.Size(959, 469);
			this.DTgredd.TabIndex = 0;
			// 
			// MainForm1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Info;
			this.ClientSize = new System.Drawing.Size(1252, 596);
			this.Controls.Add(this.MainMenu);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "MainForm1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "MainForm1";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.MainMenu.ResumeLayout(false);
			this.MainMenu.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.DTgredd)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label SvBtt;
		private System.Windows.Forms.Label CloseButton;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel MainMenu;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.DataGridView DTgredd;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button ButtonLogin;
	}
}