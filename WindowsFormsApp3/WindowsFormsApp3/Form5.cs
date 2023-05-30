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


namespace WindowsFormsApp3
{
    public partial class Form5 : Form
    {
        public static string connectString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source = БД Портові термінали2.mdb"; //Рядок підключення БД без паролю

        private OleDbConnection myConnection;

        public Form5()
        {
            myConnection = new OleDbConnection(connectString);
            // відкрити з’єднання з БД
            myConnection.Open();

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            myConnection = new OleDbConnection(connectString);
            //    відкрити з’єднання з БД
            myConnection.Open();
            int expiration_date = Convert.ToInt32(textBox2.Text);
            string query = "Select*FROM Вантаж WHERE [Термін придатності (в місяцях)] =" + expiration_date;
            OleDbDataAdapter command = new OleDbDataAdapter(query, myConnection);
            DataTable dt = new DataTable();
            command.Fill(dt);
            dataGridView1.DataSource = dt;
            myConnection.Close();


        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бД_Портові_термінали2DataSet.Вантаж". При необходимости она может быть перемещена или удалена.
            this.вантажTableAdapter.Fill(this.бД_Портові_термінали2DataSet.Вантаж);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бД_Портові_термінали2DataSet.Судна". При необходимости она может быть перемещена или удалена.
            this.суднаTableAdapter.Fill(this.бД_Портові_термінали2DataSet.Судна);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бД_Портові_термінали2DataSet.Перевантаження". При необходимости она может быть перемещена или удалена.
            this.перевантаженняTableAdapter.Fill(this.бД_Портові_термінали2DataSet.Перевантаження);


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
