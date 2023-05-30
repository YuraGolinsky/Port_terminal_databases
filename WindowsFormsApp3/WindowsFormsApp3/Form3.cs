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
    public partial class Form3 : Form
    {
        public static string connectString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source = БД Портові термінали2.mdb"; //Рядок підключення БД без паролю

        private OleDbConnection myConnection;

        public Form3()
        {
            myConnection = new OleDbConnection(connectString);
            // відкрити з’єднання з БД
            myConnection.Open();

            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бД_Портові_термінали2DataSet.Термінали". При необходимости она может быть перемещена или удалена.
            this.терміналиTableAdapter.Fill(this.бД_Портові_термінали2DataSet.Термінали);

        }

        private void button1_Click(object sender, EventArgs e)
        {
         myConnection = new OleDbConnection(connectString);
         //    відкрити з’єднання з БД
           myConnection.Open();
        int kod = Convert.ToInt32(textBox2.Text);
          string query = "Select*FROM Термінали WHERE [Код] =" + kod;
           OleDbDataAdapter command = new OleDbDataAdapter(query, myConnection);
DataTable dt = new DataTable();
            command.Fill(dt);
           dataGridView1.DataSource = dt;
           myConnection.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
