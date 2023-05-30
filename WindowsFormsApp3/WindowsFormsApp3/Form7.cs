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
    public partial class Form7 : Form
    {
        public static string connectString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source = БД Портові термінали2.mdb"; //Рядок підключення БД без паролю

        private OleDbConnection myConnection;
        public Form7()
        {
            myConnection = new OleDbConnection(connectString);
            // відкрити з’єднання з БД
            myConnection.Open();

            InitializeComponent();


        }
        private void button1_Click(object sender, EventArgs e)
        {
           myConnection = new OleDbConnection(connectString);
             //   відкрити з’єднання з БД
          myConnection.Open();
           int kod1 = Convert.ToInt32(textBox2.Text);
            string query = "Select*FROM Перевантаження WHERE [Час простою] = " + kod1;
            OleDbDataAdapter command = new OleDbDataAdapter(query,  myConnection);
           DataTable dt = new DataTable();
            command.Fill(dt);
            dataGridView1.DataSource = dt;
            myConnection.Close();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бД_Портові_термінали2DataSet.Перевантаження". При необходимости она может быть перемещена или удалена.
            this.перевантаженняTableAdapter.Fill(this.бД_Портові_термінали2DataSet.Перевантаження);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

      //  private void button2_Click(object sender, EventArgs e)
       // {
         //   myConnection = new OleDbConnection(connectString);
            //   відкрити з’єднання з БД
           // myConnection.Open();
           // int kod2 = Convert.ToInt32(textBox1.Text);
           // string query  = "Select*FROM Перевантаження WHERE [Час перевантаження] = " + kod2;
           // OleDbDataAdapter command = new OleDbDataAdapter(query, myConnection);
           // DataTable dt = new DataTable();
           // command.Fill(dt);
           // dataGridView1.DataSource = dt;
          //  myConnection.Close();
        }
    }
