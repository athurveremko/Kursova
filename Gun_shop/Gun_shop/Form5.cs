using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Gun_shop
{
    public partial class Form5 : Form
    {
        public string CmdText = "SELECT * FROM [Supliers]";
        public string ConnString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Study\\Gun_store.accdb";
        public Form5()
        {
            InitializeComponent();
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(CmdText, ConnString);
            // створення об'єкту типу DataSet
            DataSet ds = new DataSet();
            // заповнення таблиці "Orders"
            dataAdapter.Fill(ds, "[Supliers]");
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
        }

        

        private void button17_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    

        private void зброяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void клієнтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            this.Hide();
        }

        private void замовленняToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();

        }

        private void button18_Click(object sender, EventArgs e)
        {
            // Створюємо з'єднання з базою даних
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Study\\Gun_store.accdb";
            OleDbConnection connection = new OleDbConnection(connectionString);
            connection.Open();

            // Виконуємо запит INSERT
            string query = "INSERT INTO Supliers (Прізвище, [Номер телефону], Адреса, [Вид зброї]) VALUES (?, ?, ?, ?)";
            OleDbCommand command = new OleDbCommand(query, connection);
            command.Parameters.AddWithValue("?", textBox15.Text);
            command.Parameters.AddWithValue("?", maskedTextBox1.Text);
            command.Parameters.AddWithValue("?", textBox17.Text);
            command.Parameters.AddWithValue("?", textBox18.Text);
            command.ExecuteNonQuery();

            // Перевіряємо, чи всі поля заповнені
            if (textBox15.Text != "" && maskedTextBox1.Text != "" && textBox17.Text != "" && textBox18.Text != "")
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
            OleDbDataAdapter adapter = new OleDbDataAdapter("SELECT * FROM Supliers", connection);
            adapter.Fill(dt);
            DataView dv = new DataView(dt);

            // конвертувати дані з DataView у DataTable та прив'язати джерело даних до DataGridView
            DataTable newDt = dv.ToTable();
            dataGridView1.DataSource = newDt;
            connection.Close();
        }


        private void button20_Click(object sender, EventArgs e)
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Study\\Gun_store.accdb";
            OleDbConnection connection = new OleDbConnection(connectionString);
            connection.Open();

            string query = "UPDATE Supliers SET Прізвище = ?, [Номер телефону] = ?, Адреса = ?, [Вид зброї] = ? WHERE ID = ?";
            OleDbCommand command = new OleDbCommand(query, connection);
            command.Parameters.AddWithValue("?", textBox15.Text);
            command.Parameters.AddWithValue("?", maskedTextBox1.Text);
            command.Parameters.AddWithValue("?", textBox17.Text);
            command.Parameters.AddWithValue("?", textBox18.Text);
            command.Parameters.AddWithValue("?", textBox14.Text);

            command.ExecuteNonQuery();
            MessageBox.Show("Рядок змінено");
            dataGridView1.DataSource = null;

            // обробка результатів запиту
            DataTable dt = new DataTable();
            OleDbDataAdapter adapter = new OleDbDataAdapter("SELECT * FROM Supliers", connection);
            adapter.Fill(dt);
            DataView dv = new DataView(dt);

            // конвертувати дані з DataView у DataTable та прив'язати джерело даних до DataGridView
            DataTable newDt = dv.ToTable();
            dataGridView1.DataSource = newDt;

            connection.Close();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Study\\Gun_store.accdb";
            OleDbConnection connection = new OleDbConnection(connectionString);
            connection.Open();

            string query = "DELETE FROM Supliers WHERE ID = ?";
            OleDbCommand command = new OleDbCommand(query, connection);
            command.Parameters.AddWithValue("@ID", textBox14.Text);

            command.ExecuteNonQuery();
            MessageBox.Show("Рядок видалено");
            dataGridView1.DataSource = null;

            // обробка результатів запиту
            DataTable dt = new DataTable();
            OleDbDataAdapter adapter = new OleDbDataAdapter("SELECT * FROM Supliers", connection);
            adapter.Fill(dt);
            DataView dv = new DataView(dt);

            // конвертувати дані з DataView у DataTable та прив'язати джерело даних до DataGridView
            DataTable newDt = dv.ToTable();
            dataGridView1.DataSource = newDt;

            connection.Close();
        }

        private void btnSearch3_Click(object sender, EventArgs e)
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Study\\Gun_store.accdb";
            OleDbConnection connection = new OleDbConnection(connectionString);
            connection.Open();

            string query = "SELECT * FROM Supliers WHERE [Вид зброї] = ?";
            OleDbCommand command = new OleDbCommand(query, connection);
            command.Parameters.AddWithValue("?", textBox18.Text);

            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(command);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds, "Supliers");
            dataGridView1.DataSource = ds.Tables[0].DefaultView;

            connection.Close();
        }
    }
}
