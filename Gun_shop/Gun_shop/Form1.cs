using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Net.NetworkInformation;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;




namespace Gun_shop
{
    public partial class Form1 : Form
    {
        public string CmdText = "SELECT * FROM [Products]";
        public string ConnString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Study\\Gun_store.accdb";

        public Form1()
        {
            InitializeComponent();
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(CmdText, ConnString);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds, "[Products]");
            dataGridView1.DataSource = ds.Tables[0].DefaultView;

        }


        private void button1_Click(object sender, EventArgs e)
        {// Створюємо з'єднання з базою даних
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Study\\Gun_store.accdb";
            OleDbConnection connection = new OleDbConnection(connectionString);
            connection.Open();

            // Виконуємо запит INSERT
            string query = "INSERT INTO Products (Назва, Опис, Ціна, [Вид зброї]) VALUES (?, ?, ?, ?)";
            OleDbCommand command = new OleDbCommand(query, connection);
            command.Parameters.AddWithValue("?", textBox1.Text);
            command.Parameters.AddWithValue("?", textBox2.Text);
            command.Parameters.AddWithValue("?", textBox3.Text);
            command.Parameters.AddWithValue("?", textBox5.Text);
            command.ExecuteNonQuery();

            // Перевіряємо, чи всі поля заповнені
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox5.Text != "")
            {
                // Виконуємо дію, яку потрібно зробити при натисканні кнопки             
                MessageBox.Show("Дія виконана успішно!");
            }
            else
            {
                // Виводимо повідомлення про незаповнені поля
                MessageBox.Show("Будь ласка, заповніть всі поля!");

            }
            dataGridView1.DataSource = null;

            // обробка результатів запиту
            DataTable dt = new DataTable();
            OleDbDataAdapter adapter = new OleDbDataAdapter("SELECT * FROM Products", connection);
            adapter.Fill(dt);
            DataView dv = new DataView(dt);

            // конвертувати дані з DataView у DataTable та прив'язати джерело даних до DataGridView
            DataTable newDt = dv.ToTable();
            dataGridView1.DataSource = newDt;
            connection.Close();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Study\\Gun_store.accdb";
            OleDbConnection connection = new OleDbConnection(connectionString);
            connection.Open();

            string query = "DELETE FROM Products WHERE ID = ?";
            OleDbCommand command = new OleDbCommand(query, connection);
            command.Parameters.AddWithValue("@ID", textBox4.Text);

            command.ExecuteNonQuery();
            MessageBox.Show("Рядок видалено");
            dataGridView1.DataSource = null;

            // обробка результатів запиту
            DataTable dt = new DataTable();
            OleDbDataAdapter adapter = new OleDbDataAdapter("SELECT * FROM Products", connection);
            adapter.Fill(dt);
            DataView dv = new DataView(dt);

            // конвертувати дані з DataView у DataTable та прив'язати джерело даних до DataGridView
            DataTable newDt = dv.ToTable();
            dataGridView1.DataSource = newDt;

            connection.Close();

        }

        private void замовленняToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();               

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Study\\Gun_store.accdb";
            OleDbConnection connection = new OleDbConnection(connectionString);
            connection.Open();

            string query = "UPDATE Products SET Назва = ?, Опис = ?, Ціна = ?, [Вид зброї] = ? WHERE ID = ?";
            OleDbCommand command = new OleDbCommand(query, connection);
            command.Parameters.AddWithValue("?", textBox1.Text);
            command.Parameters.AddWithValue("?", textBox2.Text);
            command.Parameters.AddWithValue("?", textBox3.Text);
            command.Parameters.AddWithValue("?", textBox5.Text);
            command.Parameters.AddWithValue("?", textBox4.Text);
            command.ExecuteNonQuery();

            MessageBox.Show("Рядок змінено");

            // очистити дані з таблиці
            dataGridView1.DataSource = null;

            // обробка результатів запиту
            DataTable dt = new DataTable();
            OleDbDataAdapter adapter = new OleDbDataAdapter("SELECT * FROM Products", connection);
            adapter.Fill(dt);
            DataView dv = new DataView(dt);

            // конвертувати дані з DataView у DataTable та прив'язати джерело даних до DataGridView
            DataTable newDt = dv.ToTable();
            dataGridView1.DataSource = newDt;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";


            // закрити з'єднання з базою даних
            connection.Close();
        }


        private void button10_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void клієнтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            this.Hide();               
        }

        private void постачальникиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
            this.Hide();
        }

        private void btnSearch2_Click(object sender, EventArgs e)
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Study\\Gun_store.accdb";
            OleDbConnection connection = new OleDbConnection(connectionString);
            connection.Open();

            string query = "SELECT * FROM Products WHERE [Назва] = ?";
            OleDbCommand command = new OleDbCommand(query, connection);
            command.Parameters.AddWithValue("?", textBox1.Text);

            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(command);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds, "Products");
            dataGridView1.DataSource = ds.Tables[0].DefaultView;

            connection.Close();
        }
    }
}
