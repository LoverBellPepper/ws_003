using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using проба.classes;
using проба.Properties;
using проба.windows;

namespace проба
{
    public partial class Login : Form
    {
        AppData bd = new AppData();
        SqlCommand command = new SqlCommand();
        DataTable table = new DataTable();
        SqlDataAdapter adapter = new SqlDataAdapter();
        public Login()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(118, 227, 131);
            Logo.Load("C:\\Users\\User\\source\\repos\\Example\\проба\\resources\\logo.png");
        }

        private void Close_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Вы уверенн, что хотите закрыть приложение?",
                "Закрытие приложения",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            if (UserLogin.Text == "" || Password.Text == "")
            {
                MessageBox.Show(
                   "Не введен логин или пароль",
                   "Ошибка входа",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                return;
            }

            string login = UserLogin.Text;
            string password = Password.Text;

            command = new SqlCommand("SELECT UserName FROM [User] WHERE UserLogin = @ul AND UserPassword = @up", bd.getConnection());
            command.Parameters.AddWithValue("@ul", login);
            command.Parameters.AddWithValue("@up", password);

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                Goods goods = new Goods();
                this.Hide();
                goods.Show();
            }
            else
            {

                MessageBox.Show(
                    "Такого пользователя нет",
                    "Ошибка входа",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }
            bd.CloseConnection();



        }

        private void ButtonGuest_Click(object sender, EventArgs e)
        {

            Goods goods = new Goods();

            goods.GoodBuy1.Enabled = false;
            goods.GoodBuy2.Enabled = false;
            goods.GoodBuy3.Enabled = false;

            this.Hide();
            goods.Show();
        }
    }
}
