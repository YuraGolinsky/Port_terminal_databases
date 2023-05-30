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
    public partial class Form4 : Form
    {

        public static string connectString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source = БД Портові термінали2.mdb"; //Рядок підключення БД без паролю

        private OleDbConnection myConnection;

        public Form4()
        {
            myConnection = new OleDbConnection(connectString);
            // відкрити з’єднання з БД
            myConnection.Open();

            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бД_Портові_термінали2DataSet.Судна". При необходимости она может быть перемещена или удалена.
            this.суднаTableAdapter.Fill(this.бД_Портові_термінали2DataSet.Судна);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            myConnection = new OleDbConnection(connectString);
            //    відкрити з’єднання з БД
            myConnection.Open();
            int kod = Convert.ToInt32(textBox1.Text);
            string query = "Select*FROM Судна WHERE [Тоннаж] =" + kod;
            OleDbDataAdapter command = new OleDbDataAdapter(query, myConnection);
            DataTable dt = new DataTable();
            command.Fill(dt);
            dataGridView1.DataSource = dt;
            myConnection.Close();
        }
    }
}
