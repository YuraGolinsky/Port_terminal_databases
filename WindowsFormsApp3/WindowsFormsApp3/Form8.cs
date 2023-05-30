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

namespace WindowsFormsApp3
{
    public partial class Form8 : Form
    {

        public static string connectString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source = БД Портові термінали2.mdb"; //Рядок підключення БД без паролю

        private OleDbConnection myConnection;
        public Form8()
        {
            myConnection = new OleDbConnection(connectString);
            // відкрити з’єднання з БД
            myConnection.Open();

            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int kod = Convert.ToInt32(textBox1.Text);
            string name = textBox2.Text;
            string employees = textBox3.Text;
            string MooringPossession = textBox4.Text;
            string city = textBox6.Text;
            string country = textBox5.Text;

            string query = "INSERT INTO Термінали (Код, Назва, [Кількість працівників], [Кількість причального обладнання], Країна, Місто) VALUES (" + kod + ", '" + name + "', '" + employees + "', '" + MooringPossession + "', '" + city + "', '" + country + "')";

            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.ExecuteNonQuery();
            MessageBox.Show("Термінал успішно додано");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Owner = this;
            f1.Show();
        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
