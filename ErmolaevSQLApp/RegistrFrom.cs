using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ErmolaevSQLApp
{
	public partial class RegistrFrom : Form
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
		public RegistrFrom()
		{
			InitializeComponent();
			this.FormBorderStyle = FormBorderStyle.None;
			Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
			UserName.Text = "Введите имя";
			UserName.ForeColor = Color.Gray;
			UserSurname.Text = "Введите фамилию";
			UserSurname.ForeColor = Color.Gray;
			Login.Text = "Введите логин";
			Login.ForeColor = Color.Gray;
			Password.UseSystemPasswordChar = false;
			Password.Text = "Введите пароль";
			Password.ForeColor = Color.Gray;
			this.Password.AutoSize = false;
			this.Password.Size = new Size(this.Password.Size.Width, 64);
		}

		private void CloseButton_Click(object sender, EventArgs e)
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

		private void ButtonRegister_Click(object sender, EventArgs e)
		{
			if (UserName.Text == "Введите имя")
			{
				MessageBox.Show("Нужно ввести имя");
				return;
			}
			if (UserSurname.Text == "Введите фамилию")
			{
				MessageBox.Show("Нужно ввести фамилию");
				return;
			}
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
			if (CheckUsers())
				return;

			DataBase db = new DataBase();
			MySqlCommand SqlCommand = new MySqlCommand("INSERT INTO `users` ( `Login`, `Password`, `Name`, `Surname`) VALUES (@login, @password, @name, @surname)", db.GetConnection());
			SqlCommand.Parameters.Add("@login", MySqlDbType.VarChar).Value = Login.Text;
			SqlCommand.Parameters.Add("@password", MySqlDbType.VarChar).Value = Password.Text;
			SqlCommand.Parameters.Add("@name", MySqlDbType.VarChar).Value = UserName.Text;
			SqlCommand.Parameters.Add("@surname", MySqlDbType.VarChar).Value = UserSurname.Text;

			db.openConnect();

			if (SqlCommand.ExecuteNonQuery() == 1)
				MessageBox.Show("Аккаунт был создан");
			else
				MessageBox.Show("Аккаунт не был создан");

			db.closeConnect();
		}
		public Boolean CheckUsers()
		{
			DataBase db = new DataBase();
			DataTable dtable = new DataTable();
			MySqlDataAdapter adapter = new MySqlDataAdapter();

			MySqlCommand SqlCommand = new MySqlCommand("SELECT * FROM `users` WHERE `Login` = @uL", db.GetConnection());
			SqlCommand.Parameters.Add("@uL", MySqlDbType.VarChar).Value = Login.Text;
			adapter.SelectCommand = SqlCommand;
			adapter.Fill(dtable);

			if (dtable.Rows.Count > 0)
			{
				MessageBox.Show("Такой логин уже существует. Введите другой");
				return true;
			}
			else
			{
				return false;	
			}
		}
		private void UserName_Enter(object sender, EventArgs e)
		{
			if (UserName.Text == "Введите имя")
			UserName.Text = "";
			UserName.ForeColor = Color.Black;
		}

		private void UserName_Leave(object sender, EventArgs e)
		{
			if (UserName.Text == "")
			{
				UserName.Text = "Введите имя";
				UserName.ForeColor = Color.Gray;
			}
		}

		private void UserSurname_Enter(object sender, EventArgs e)
		{
			if (UserSurname.Text == "Введите фамилию")
				UserSurname.Text = "";
			UserSurname.ForeColor = Color.Black;
		}

		private void UserSurname_Leave(object sender, EventArgs e)
		{
			if (UserSurname.Text == "")
			{
				UserSurname.Text = "Введите фамилию";
				UserSurname.ForeColor = Color.Gray;
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
		private void Avto_MouseEnter(object sender, EventArgs e)
		{
			Avto.ForeColor = Color.SkyBlue;
		}

		private void Avto_MouseLeave(object sender, EventArgs e)
		{
			Avto.ForeColor = Color.Black;
		}

		private void Avto_Click(object sender, EventArgs e)
		{
			this.Hide();
			LoginForm loginform = new LoginForm();
			loginform.Show();
		}

		private void SvBtt_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}

		private void SvBtt_MouseLeave(object sender, EventArgs e)
		{
			SvBtt.ForeColor = Color.Black;
		}

		private void SvBtt_MouseEnter(object sender, EventArgs e)
		{
			SvBtt.ForeColor = Color.SkyBlue;
		}

		private void pictureBox4_Click(object sender, EventArgs e)
		{
			Password.UseSystemPasswordChar = false;
			pictureBox4.Image = Image.FromFile("D:/8530610_eye_icon.png");
		}

		private void pictureBox4_MouseLeave(object sender, EventArgs e)
		{
			Password.UseSystemPasswordChar = true;
			pictureBox4.Image = Image.FromFile("D:/z.png");
			if (Password.Text == "Введите пароль")
			{
				Password.UseSystemPasswordChar = false;
				Password.ForeColor = Color.Gray;
			}
		}
	}
}
