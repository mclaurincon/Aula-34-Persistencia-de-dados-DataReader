using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection();

            conn.ConnectionString = "Server=localhost;Database=Cliente;Uid=root;Pwd=senha@123;";
            conn.Open();

            MessageBox.Show("Abrir conexao com o MySql");
            conn.Close();
        }
        private void BtnConnectionSqlServer_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();

            conn.ConnectionString = "Server=localhost;Database=Cliente;User Id=sa;Password=senha@123;";
            conn.Open();

            MessageBox.Show("Abrir conexao com o SqlServer");
            conn.Close();

        }

        private void btnListarMysql_Click(object sender, EventArgs e)
        {

        }

        private void btnListarsqlServer_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();

            string connection = @"Data Source=localhost; User ID=sa; Password=senha@123; Connect Timeout=30; Encrypt=False; TrustServerCertificate=False; ApplicationIntent=ReadWrite; MultiSubnetFailover=False; Initial Catalog= Cliente";

            conn.ConnectionString = connection;
            conn.Open();

            SqlCommand comm = new SqlCommand();
            comm.CommandType = System.Data.CommandType.Text;
            comm.CommandText = "select * from Produtos";
            comm.Connection = conn;

            SqlDataReader reader = comm.ExecuteReader();

            while (reader.Read())
            {
                string nome = reader.GetString(1);
                string cor = reader.IsDBNull(2) ? string.Empty : reader.GetString(2);
                listBox2.Items.Add($"{reader.GetInt32(0)}, {nome}, {cor}");
            }
          
            conn.Close();
        }
    }
}