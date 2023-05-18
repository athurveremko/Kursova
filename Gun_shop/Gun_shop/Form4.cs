using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Gun_shop
{
    public partial class Form4 : Form
    {
        public string CmdText = "SELECT * FROM [Clients]";
        public string ConnString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Study\\Gun_store.accdb";
        public Form4()
        {
            InitializeComponent();
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(CmdText, ConnString);
            // створення об'єкту типу DataSet
            DataSet ds = new DataSet();
            // заповнення таблиці "Orders"
            dataAdapter.Fill(ds, "[Clients]");
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
        }

        private void зброяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();               

        }

        private void замовленняToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();               

        }

        private void button16_Click_1(object sender, EventArgs e)
        {
            Application.Exit();

        }


        private void button12_Click(object sender, EventArgs e)
        {
            // Створюємо з'єднання з базою даних
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Study\\Gun_store.accdb";
            OleDbConnection connection = new OleDbConnection(connectionString);
            connection.Open();

            // Виконуємо запит INSERT
            string query = "INSERT INTO Clients (Прізвище, [Ім'я], Адреса, [Номер телефону]) VALUES (?, ?, ?, ?)";
            OleDbCommand command = new OleDbCommand(query, connection);
            command.Parameters.AddWithValue("?", textBox10.Text);
            command.Parameters.AddWithValue("?", textBox11.Text);
            command.Parameters.AddWithValue("?", textBox12.Text);
            command.Parameters.AddWithValue("?", maskedTextBox1.Text);
            command.ExecuteNonQuery();

            MessageBox.Show("Рядок додано");
            dataGridView1.DataSource = null;

            // обробка результатів запиту
            DataTable dt = new DataTable();
            OleDbDataAdapter adapter = new OleDbDataAdapter("SELECT * FROM Clients", connection);
            adapter.Fill(dt);
            DataView dv = new DataView(dt);

            // конвертувати дані з DataView у DataTable та прив'язати джерело даних до DataGridView
            DataTable newDt = dv.ToTable();
            dataGridView1.DataSource = newDt;
            connection.Close();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Study\\Gun_store.accdb";
            OleDbConnection connection = new OleDbConnection(connectionString);
            connection.Open();

            string query = "DELETE FROM Clients WHERE ID = ?";
            OleDbCommand command = new OleDbCommand(query, connection);
            command.Parameters.AddWithValue("@ID", textBox9.Text);

            command.ExecuteNonQuery();
            MessageBox.Show("Рядок видалено");
            dataGridView1.DataSource = null;

            // обробка результатів запиту
            DataTable dt = new DataTable();
            OleDbDataAdapter adapter = new OleDbDataAdapter("SELECT * FROM Clients", connection);
            adapter.Fill(dt);
            DataView dv = new DataView(dt);

            // конвертувати дані з DataView у DataTable та прив'язати джерело даних до DataGridView
            DataTable newDt = dv.ToTable();
            dataGridView1.DataSource = newDt;

            connection.Close();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Study\\Gun_store.accdb";
            OleDbConnection connection = new OleDbConnection(connectionString);
            connection.Open();

            string query = "UPDATE Clients SET Прізвище = ?, [Ім'я] = ?, Адреса = ?, [Номер телефону] = ? WHERE ID = ?";
            OleDbCommand command = new OleDbCommand(query, connection);
            command.Parameters.AddWithValue("?", textBox10.Text);
            command.Parameters.AddWithValue("?", textBox11.Text);
            command.Parameters.AddWithValue("?", textBox12.Text);
            command.Parameters.AddWithValue("?", maskedTextBox1.Text);
            command.Parameters.AddWithValue("?", textBox9.Text);

            command.ExecuteNonQuery();
            MessageBox.Show("Рядок змінено");
            dataGridView1.DataSource = null;

            // обробка результатів запиту
            DataTable dt = new DataTable();
            OleDbDataAdapter adapter = new OleDbDataAdapter("SELECT * FROM Clients", connection);
            adapter.Fill(dt);
            DataView dv = new DataView(dt);

            // конвертувати дані з DataView у DataTable та прив'язати джерело даних до DataGridView
            DataTable newDt = dv.ToTable();
            dataGridView1.DataSource = newDt;

            connection.Close();
        }

        private void постачальникиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
            this.Hide();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Study\\Gun_store.accdb";
            OleDbConnection connection = new OleDbConnection(connectionString);
            connection.Open();

            string query = "SELECT * FROM Clients WHERE [Ім'я] = ?";
            OleDbCommand command = new OleDbCommand(query, connection);
            command.Parameters.AddWithValue("?", textBox11.Text);

            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(command);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds, "Clients");
            dataGridView1.DataSource = ds.Tables[0].DefaultView;

            connection.Close();
        }

       
    }
    }

