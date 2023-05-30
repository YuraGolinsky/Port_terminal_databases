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
    public partial class Form2 : Form
    {
        public static string connectString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source = БД Портові термінали.mdb"; //Рядок підключення БД без паролю

        private OleDbConnection myConnection;

        public Form2()

        {
            myConnection = new OleDbConnection(connectString);
            // відкрити з’єднання з БД
            myConnection.Open();

            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бД_Портові_терміналиDataSet.Судна". При необходимости она может быть перемещена или удалена.
            this.суднаTableAdapter1.Fill(this.бД_Портові_терміналиDataSet.Судна);

            // TODO: данная строка кода позволяет загрузить данные в таблицу "бД_Портові_терміналиDataSet.Перевантаження". При необходимости она может быть перемещена или удалена.
            this.перевантаженняTableAdapter1.Fill(this.бД_Портові_терміналиDataSet.Перевантаження);
          
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            myConnection = new OleDbConnection(connectString);
            //    відкрити з’єднання з БД
            myConnection.Open();
            string dolzhnost = textBox1.Text;
            string query = "Select*FROM Перевантаження WHERE [Дата заходу] = '" + dolzhnost + " ' ";
            OleDbDataAdapter command = new OleDbDataAdapter(query, myConnection);
            DataTable dt = new DataTable();
            command.Fill(dt);
            dataGridView1.DataSource = dt;
            myConnection.Close();


           
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
