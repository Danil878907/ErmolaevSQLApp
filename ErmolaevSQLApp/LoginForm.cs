using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ErmolaevSQLApp
{
	public partial class LoginForm : Form
	{
		[DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
		private static extern IntPtr CreateRoundRectRgn
		(
			int nLeftRect,     // x-coordinate of upper-left corner
			int nTopRect,      // y-coordinate of upper-left corner
			int nRightRect,    // x-coordinate of lower-right corner
			int nBottomRect,   // y-coordinate of lower-right corner
			int nWidthEllipse, // width of ellipse
			int nHeightEllipse // height of ellipse
		);
		public LoginForm()
		{
			InitializeComponent();
			this.FormBorderStyle = FormBorderStyle.None;
			Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
			Login.Text = "Введите логин";
			Login.ForeColor = Color.Gray;
			Password.UseSystemPasswordChar = false;
			Password.Text = "Введите пароль";
			Password.ForeColor = Color.Gray;
			this.Password.AutoSize = false;
			this.Password.Size = new Size(this.Password.Size.Width, 64);
		}

		private void CloseButton_Click_1(object sender, EventArgs e)
		{
			DialogResult dialogResult = MessageBox.Show("Уверены, что хотите выйти?", "Сообщение", MessageBoxButtons.YesNo);
			if (dialogResult == DialogResult.Yes)
			{
				Application.Exit();
			}
		}

		private void CloseButton_MouseEnter(object sender, EventArgs e)
		{
			CloseButton.ForeColor = Color.Red;
		}

		private void CloseButton_MouseLeave(object sender, EventArgs e)
		{
			CloseButton.ForeColor = Color.Black;
		}
		Point lastPoint;
		private void MainMenu_MouseMove(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				this.Left += e.X - lastPoint.X;
				this.Top += e.Y - lastPoint.Y;
			}
		}

		private void MainMenu_MouseDown(object sender, MouseEventArgs e)
		{
			lastPoint = new Point(e.X, e.Y);
		}

		private void panel1_MouseMove(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				this.Left += e.X - lastPoint.X;
				this.Top += e.Y - lastPoint.Y;
			}
		}

		private void panel1_MouseDown(object sender, MouseEventArgs e)
		{
			lastPoint = new Point(e.X, e.Y);
		}

		private void label1_MouseMove(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				this.Left += e.X - lastPoint.X;
				this.Top += e.Y - lastPoint.Y;
			}
		}

		private void label1_MouseDown(object sender, MouseEventArgs e)
		{
			lastPoint = new Point(e.X, e.Y);
		}

		private void ButtonLogin_Click(object sender, EventArgs e)
		{
			String loginUsers = Login.Text;
			String passUsers = Password.Text;
			
			if (Login.Text == "Введите логин")
			{
				MessageBox.Show("Нужно ввести логин");
				return;
			}
			if (Password.Text == "Введите пароль")
			{
				MessageBox.Show("Нужно ввести пароль");
				return;
			}

			DataBase db = new DataBase();
			DataTable dtable = new DataTable();
			MySqlDataAdapter adapter = new MySqlDataAdapter();

			MySqlCommand SqlCommand = new MySqlCommand("SELECT * FROM `users` WHERE `Login` = @uL AND `Password` = @uP", db.GetConnection());
			SqlCommand.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUsers;
			SqlCommand.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passUsers;
			adapter.SelectCommand = SqlCommand;
			adapter.Fill(dtable);

			if (dtable.Rows.Count > 0)
			{
				this.Hide();
				MainForm1 loginform = new MainForm1();
				loginform.Show();
			}
			else
			{
				MessageBox.Show("Неправильно введен логин или пароль");
			}
		}

		private void Login_Enter(object sender, EventArgs e)
		{
			if (Login.Text == "Введите логин")
				Login.Text = "";
			Login.ForeColor = Color.Black;
		}

		private void Login_Leave(object sender, EventArgs e)
		{
			if (Login.Text == "")
			{
				Login.Text = "Введите логин";
				Login.ForeColor = Color.Gray;
			}
		}

		private void Password_Enter(object sender, EventArgs e)
		{
			if (Password.Text == "Введите пароль")
			{
				Password.Text = "";
				Password.ForeColor = Color.Black;
				Password.UseSystemPasswordChar = true;

			}
		}

		private void Password_Leave(object sender, EventArgs e)
		{
			if (Password.Text == "")
			{
				Password.UseSystemPasswordChar = false;
				Password.Text = "Введите пароль";
				Password.ForeColor = Color.Gray;
			}
		}
		private void Regist_MouseEnter(object sender, EventArgs e)
		{
			Regist.ForeColor = Color.SkyBlue;
		}

		private void Regist_MouseLeave(object sender, EventArgs e)
		{
			Regist.ForeColor = Color.Black;
		}

		private void Regist_Click(object sender, EventArgs e)
		{
			this.Hide();
			RegistrFrom loginform = new RegistrFrom();
			loginform.Show();
		}

		private void SvBtt_MouseLeave(object sender, EventArgs e)
		{
			SvBtt.ForeColor = Color.Black;
		}

		private void SvBtt_MouseEnter(object sender, EventArgs e)
		{
			SvBtt.ForeColor = Color.SkyBlue;
		}

		private void SvBtt_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}

		private void pictureBox3_Click(object sender, EventArgs e)
		{
			Password.UseSystemPasswordChar = false;
			pictureBox3.Image = Image.FromFile("D:/8530610_eye_icon.png");
		}

		private void pictureBox3_MouseLeave(object sender, EventArgs e)
		{
			Password.UseSystemPasswordChar = true;
			pictureBox3.Image = Image.FromFile("D:/z.png");
			if (Password.Text == "Введите пароль")
			{
				Password.UseSystemPasswordChar = false;
				Password.ForeColor = Color.Gray;
			}
		}
	}
}
