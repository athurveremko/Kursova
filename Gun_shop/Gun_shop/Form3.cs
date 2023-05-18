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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Gun_shop
{
    public partial class Form3 : Form
    {
        public string CmdText = "SELECT * FROM [Orders]";
        public string ConnString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Study\\Gun_store.accdb";
        public Form3()
        {
            InitializeComponent();
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(CmdText, ConnString);
            // створення об'єкту типу DataSet
            DataSet ds = new DataSet();
            // заповнення таблиці "Orders"
            dataAdapter.Fill(ds, "[Orders]");
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
        }

    
        private void button7_Click(object sender, EventArgs e)
        {
            // Створюємо з'єднання з базою даних
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Study\\Gun_store.accdb";
            OleDbConnection connection = new OleDbConnection(connectionString);
            connection.Open();

            // Виконуємо запит INSERT
            string query = "INSERT INTO Orders (Клієнт, Товар, Кількість, [Дата замовлення]) VALUES (@Клієнт, @Товар, @Кількість, @Дата_замовлення)";
            OleDbCommand command = new OleDbCommand(query, connection);
            command.Parameters.AddWithValue("@Клієнт", textBox6.Text);
            command.Parameters.AddWithValue("@Товар", textBox7.Text);
            command.Parameters.AddWithValue("@Кількість", textBox8.Text);
            command.Parameters.AddWithValue("@Дата_замовлення", dateTimePicker1.Value);

            command.ExecuteNonQuery();

            MessageBox.Show("Рядок додано");
            dataGridView1.DataSource = null;

            // обробка результатів запиту
            DataTable dt = new DataTable();
            OleDbDataAdapter adapter = new OleDbDataAdapter("SELECT * FROM Orders", connection);
            adapter.Fill(dt);
            DataView dv = new DataView(dt);

            // конвертувати дані з DataView у DataTable та прив'язати джерело даних до DataGridView
            DataTable newDt = dv.ToTable();
            dataGridView1.DataSource = newDt;
            connection.Close();
                           
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Study\\Gun_store.accdb";
            OleDbConnection connection = new OleDbConnection(connectionString);
            connection.Open();

            string query = "DELETE FROM Orders WHERE ID = ?";
            OleDbCommand command = new OleDbCommand(query, connection);
            command.Parameters.AddWithValue("@ID", textBox5.Text);

            command.ExecuteNonQuery();
            MessageBox.Show("Рядок видалено");
            dataGridView1.DataSource = null;

            // обробка результатів запиту
            DataTable dt = new DataTable();
            OleDbDataAdapter adapter = new OleDbDataAdapter("SELECT * FROM Orders", connection);
            adapter.Fill(dt);
            DataView dv = new DataView(dt);

            // конвертувати дані з DataView у DataTable та прив'язати джерело даних до DataGridView
            DataTable newDt = dv.ToTable();
            dataGridView1.DataSource = newDt;

            connection.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void зброяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();               

        }

        private void button11_Click(object sender, EventArgs e)
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Study\\Gun_store.accdb";
            OleDbConnection connection = new OleDbConnection(connectionString);
            connection.Open();

            string query = "UPDATE Orders SET Клієнт = ?, Товар = ?, Кількість = ?, [Дата замовлення] = ? WHERE ID = ?";
            OleDbCommand command = new OleDbCommand(query, connection);
            command.Parameters.AddWithValue("?", textBox6.Text);
            command.Parameters.AddWithValue("?", textBox7.Text);
            command.Parameters.AddWithValue("?", textBox8.Text);
            command.Parameters.AddWithValue("?", dateTimePicker1.Value);
            command.Parameters.AddWithValue("?", textBox5.Text);

            command.ExecuteNonQuery();
            MessageBox.Show("Рядок змінено");
            dataGridView1.DataSource = null;

            // обробка результатів запиту
            DataTable dt = new DataTable();
            OleDbDataAdapter adapter = new OleDbDataAdapter("SELECT * FROM Orders", connection);
            adapter.Fill(dt);
            DataView dv = new DataView(dt);

            // конвертувати дані з DataView у DataTable та прив'язати джерело даних до DataGridView
            DataTable newDt = dv.ToTable();
            dataGridView1.DataSource = newDt;

            connection.Close();
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

        
    }
}
