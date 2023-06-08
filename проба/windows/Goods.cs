using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using проба.classes;

namespace проба.windows
{
    public partial class Goods : Form
    {

        AppData bd = new AppData();
        SqlCommand command = new SqlCommand();
        DataTable table = new DataTable();
        SqlDataAdapter adapter = new SqlDataAdapter();
        public Goods()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(118, 227, 131);
           
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

        private void Exit_Click(object sender, EventArgs e)
        {
           Login login = new Login();
           this.Close();
           login.Show();
        }

        private void Goods_Load(object sender, EventArgs e)
        {
            LoadGoods();
        }

        private void LoadGoods()
        {
            int x =1;
            bd.OpenConnection();
            command = new SqlCommand($"SELECT count(ProductID) FROM [Product] WHERE ProductID = {x}", bd.getConnection());
            int proverka = Convert.ToInt32(command.ExecuteScalar().ToString());
            if (proverka != 0)
            {
                command = new SqlCommand("SELECT ProductName FROM [Product] WHERE ProductID = 1", bd.getConnection());
                NameGoods1.Text = command.ExecuteScalar().ToString();

                command = new SqlCommand("SELECT ProductPhoto FROM [Product] WHERE ProductID = 1", bd.getConnection());
                string path = command.ExecuteScalar().ToString();
                PictureGoods1.Load($"{path}");


            }
           
        }
    }
}
