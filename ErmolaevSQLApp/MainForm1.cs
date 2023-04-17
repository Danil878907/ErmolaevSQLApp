using Microsoft.Win32;
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
	public partial class MainForm1 : Form
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
		public MainForm1()
		{
			InitializeComponent();
			this.FormBorderStyle = FormBorderStyle.None;
			Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
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

		private void SvBtt_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}

		private void SvBtt_MouseEnter(object sender, EventArgs e)
		{
			SvBtt.ForeColor = Color.SkyBlue;
		}

		private void SvBtt_MouseLeave(object sender, EventArgs e)
		{
			SvBtt.ForeColor = Color.Black;
		}

		private void label2_Click(object sender, EventArgs e)
		{
			this.Hide();
			LoginForm loginform = new LoginForm();
			loginform.Show();
		}

		private void label2_MouseLeave(object sender, EventArgs e)
		{
			label2.ForeColor = Color.Black;
		}

		private void label2_MouseEnter(object sender, EventArgs e)
		{
			label2.ForeColor = Color.SkyBlue;
		}
		private void LoadData()
		{
			DataBase db = new DataBase();
			DataTable dtable = new DataTable();
			MySqlDataAdapter adapter = new MySqlDataAdapter();

			MySqlCommand mySqlCommand = new MySqlCommand("SELECT * FROM `order_log` ", db.GetConnection());
			adapter.SelectCommand = mySqlCommand;
			adapter.Fill(dtable);
			DTgredd.DataSource = dtable;


			DTgredd.Columns[0].HeaderText = "Код заказа";
			DTgredd.Columns[1].HeaderText = "Код заказчика";
			DTgredd.Columns[2].HeaderText = "Код исполнителя";
			DTgredd.Columns[3].HeaderText = "Код работы";
			DTgredd.Columns[4].HeaderText = "Дата съемки";
			DTgredd.Columns[5].HeaderText = "Итоговая стоимость";


			DTgredd.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
			DTgredd.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
			DTgredd.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
			DTgredd.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
			DTgredd.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
			DTgredd.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

			DTgredd.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
			DTgredd.ColumnHeadersDefaultCellStyle.Font = new Font(DTgredd.ColumnHeadersDefaultCellStyle.Font, FontStyle.Bold);
		}

		private void ButtonLogin_Click(object sender, EventArgs e)
		{
			LoadData();
		}
		private void LoadData1()
		{
			DataBase db = new DataBase();
			DataTable dtable = new DataTable();
			MySqlDataAdapter adapter = new MySqlDataAdapter();

			MySqlCommand mySqlCommand = new MySqlCommand("SELECT * FROM `work_customers` ", db.GetConnection());
			adapter.SelectCommand = mySqlCommand;
			adapter.Fill(dtable);
			DTgredd.DataSource = dtable;


			DTgredd.Columns[0].HeaderText = "Код заказчика";
			DTgredd.Columns[1].HeaderText = "Фамилия";
			DTgredd.Columns[2].HeaderText = "Имя";
			DTgredd.Columns[3].HeaderText = "Отчество";
			DTgredd.Columns[4].HeaderText = "Номер телефона";
			DTgredd.Columns[5].HeaderText = "Электронная почта";


			DTgredd.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
			DTgredd.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


			DTgredd.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
			DTgredd.ColumnHeadersDefaultCellStyle.Font = new Font(DTgredd.ColumnHeadersDefaultCellStyle.Font, FontStyle.Bold);
		}
		private void button4_Click(object sender, EventArgs e)
		{
			LoadData1();
		}
		private void LoadData2()
		{
			DataBase db = new DataBase();
			DataTable dtable = new DataTable();
			MySqlDataAdapter adapter = new MySqlDataAdapter();

			MySqlCommand mySqlCommand = new MySqlCommand("SELECT * FROM `performers` ", db.GetConnection());
			adapter.SelectCommand = mySqlCommand;
			adapter.Fill(dtable);
			DTgredd.DataSource = dtable;


			DTgredd.Columns[0].HeaderText = "Код исполнителя";
			DTgredd.Columns[1].HeaderText = "Фамилия";
			DTgredd.Columns[2].HeaderText = "Имя";
			DTgredd.Columns[3].HeaderText = "Отчество";
			DTgredd.Columns[4].HeaderText = "Рабочий стаж";
			DTgredd.Columns[5].HeaderText = "Специализация";
			DTgredd.Columns[6].HeaderText = "Номер телефона";
			DTgredd.Columns[7].HeaderText = "Электронная почта";


			DTgredd.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
			DTgredd.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
			DTgredd.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

			DTgredd.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
			DTgredd.ColumnHeadersDefaultCellStyle.Font = new Font(DTgredd.ColumnHeadersDefaultCellStyle.Font, FontStyle.Bold);
		}
		private void button2_Click(object sender, EventArgs e)
		{
			LoadData2();
		}

		private void LoadData3()
		{
			DataBase db = new DataBase();
			DataTable dtable = new DataTable();
			MySqlDataAdapter adapter = new MySqlDataAdapter();

			MySqlCommand mySqlCommand = new MySqlCommand("SELECT * FROM `price_list_of_works` ", db.GetConnection());
			adapter.SelectCommand = mySqlCommand;
			adapter.Fill(dtable);
			DTgredd.DataSource = dtable;


			DTgredd.Columns[0].HeaderText = "Код работы";
			DTgredd.Columns[1].HeaderText = "Название работы";
			DTgredd.Columns[2].HeaderText = "Описание работы";
			DTgredd.Columns[3].HeaderText = "Цена работы";


			DTgredd.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
			DTgredd.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


			DTgredd.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
			DTgredd.ColumnHeadersDefaultCellStyle.Font = new Font(DTgredd.ColumnHeadersDefaultCellStyle.Font, FontStyle.Bold);
		}
		private void button3_Click(object sender, EventArgs e)
		{
			LoadData3();
		}
	}
}
