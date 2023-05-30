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
    public partial class Form1 : Form
    {
        public static string connectString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source = БД Портові термінали2.mdb"; //Рядок підключення БД без паролю

        private OleDbConnection myConnection;


        public Form1()
        {

            myConnection = new OleDbConnection(connectString);
            // відкрити з’єднання з БД
            myConnection.Open();

            InitializeComponent();



        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бД_Портові_терміналиDataSet.Термінали". При необходимости она может быть перемещена или удалена.
            this.терміналиTableAdapter1.Fill(this.бД_Портові_терміналиDataSet.Термінали);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бД_Портові_термінали2DataSet.Термінали". При необходимости она может быть перемещена или удалена.
            this.терміналиTableAdapter.Fill(this.бД_Портові_термінали2DataSet.Термінали);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бД_Портові_термінали2DataSet.Судна". При необходимости она может быть перемещена или удалена.
            this.суднаTableAdapter.Fill(this.бД_Портові_термінали2DataSet.Судна);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бД_Портові_термінали2DataSet.Перевантаження". При необходимости она может быть перемещена или удалена.
            this.перевантаженняTableAdapter.Fill(this.бД_Портові_термінали2DataSet.Перевантаження);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бД_Портові_термінали2DataSet.Типи_вантажу". При необходимости она может быть перемещена или удалена.
            this.типи_вантажуTableAdapter.Fill(this.бД_Портові_термінали2DataSet.Типи_вантажу);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бД_Портові_термінали2DataSet.Вантаж". При необходимости она может быть перемещена или удалена.
            this.вантажTableAdapter.Fill(this.бД_Портові_термінали2DataSet.Вантаж);

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void код_суднаLabel_Click(object sender, EventArgs e)
        {

        }

        private void код_суднаTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void швидкість_перевантаженняTextBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void кількість_перевантаженого_вантажуTextBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void час_перевантаженняTextBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void перевантаженняDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.перевантаженняTableAdapter.FillBy(this.бД_Портові_термінали2DataSet.Перевантаження);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int kod = Convert.ToInt32(textBox1.Text);
            string query = "DELETE FROM Термінали WHERE [Код] =" + kod;
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.ExecuteNonQuery();
            MessageBox.Show("Дані про термінал видалені");
            this.терміналиTableAdapter.Fill(this.бД_Портові_термінали2DataSet.Термінали);

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            myConnection.Close();

        }

        private void отриматиХарактеристикиТерміналуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Owner = this;
            f3.Show();
        }

        private void отриматиВсюІнформаціюПроСуднаЩоПеревантажувалисьНаТерміналіToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Owner = this;
            f2.Show();
        }

        private void отриматиПерелікШвидкопсувнихВантажівВідсортуватиЗаНазвоюУАлфавітномуПорядкуToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form5 f5 = new Form5();
            f5.Owner = this;
            f5.Show();
        }

        private void отриматиПерелікСуденТоннажемБільше30ТоннToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Owner = this;
            f4.Show();
        }

        private void отриматиПерелікВітчизнянихВантажівВідсортуватиЗаТипоммаєБутиВказаноНазвуТипуВантажуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            f6.Owner = this;
            f6.Show();
        }

        private void отриматиПерелікСуденЧасПростоюЯкихБільше2ДібАЧасПеревантаженняБільше5ДібToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 f7 = new Form7();
            f7.Owner = this;
            f7.Show();
        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connectionString =
            "provider=Microsoft.Jet.OLEDB.4.0;data source=" + System.IO.Path.Combine(Application.StartupPath, "БД Портові термінали2.mdb");
            OleDbConnection con = new OleDbConnection(connectionString);
            OleDbCommand com = con.CreateCommand();
            com.CommandText = "SELECT DISTINCTROW Avg([Перевантаження].[Час перевантаження]) AS[Avg - Час перевантаження] FROM Перевантаження";

            con.Open();

            textBox3.Text = Convert.ToString(com.ExecuteScalar());

            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {

            string connectionString =
           "provider=Microsoft.Jet.OLEDB.4.0;data source=" + System.IO.Path.Combine(Application.StartupPath, "БД Портові термінали2.mdb");
            OleDbConnection con = new OleDbConnection(connectionString);
            OleDbCommand com = con.CreateCommand();
            com.CommandText = "SELECT count(*)" +
                "FROM Термінали";
            con.Open();

            textBox2.Text = Convert.ToString(com.ExecuteScalar());

            con.Close();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string connectionString =
           "provider=Microsoft.Jet.OLEDB.4.0;data source=" + System.IO.Path.Combine(Application.StartupPath, "БД Портові термінали2.mdb");
            OleDbConnection con = new OleDbConnection(connectionString);
            OleDbCommand com = con.CreateCommand();
            com.CommandText = "SELECT DISTINCTROW Avg([Перевантаження].[Час простою]) AS[Avg - Час простою] FROM Перевантаження";

            con.Open();

            textBox4.Text = Convert.ToString(com.ExecuteScalar());

            con.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string connectionString =
          "provider=Microsoft.Jet.OLEDB.4.0;data source=" + System.IO.Path.Combine(Application.StartupPath, "БД Портові термінали2.mdb");
            OleDbConnection con = new OleDbConnection(connectionString);
            OleDbCommand com = con.CreateCommand();
            com.CommandText = "SELECT DISTINCTROW Sum([Термінали].[Кількість працівників]) AS [Sum - Кількість працівників] FROM Термінали";

            con.Open();

            textBox5.Text = Convert.ToString(com.ExecuteScalar());

            con.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string connectionString =
         "provider=Microsoft.Jet.OLEDB.4.0;data source=" + System.IO.Path.Combine(Application.StartupPath, "БД Портові термінали2.mdb");
            OleDbConnection con = new OleDbConnection(connectionString);
            OleDbCommand com = con.CreateCommand();
            com.CommandText = "SELECT DISTINCTROW Sum([Термінали].[Кількість причального обладнання]) AS [Sum - Кількість причального обладнання] FROM Термінали";

            con.Open();

            textBox6.Text = Convert.ToString(com.ExecuteScalar());

            con.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string query = "SELECT First(Вантаж.[Код типу вантажу]) AS [Код типу вантажу поле], Count(Вантаж.[Код типу вантажу]) AS Повторы, Вантаж.Назва FROM Вантаж GROUP BY Вантаж.[Код типу вантажу], Вантаж.Назва HAVING(((Count(Вантаж.[Код типу вантажу])) <> False))";

            OleDbDataAdapter dA = new OleDbDataAdapter(query, myConnection);
            DataSet ds = new DataSet();
            dA.Fill(ds, "[C]");
            DataView source = ds.Tables[0].DefaultView; //Данні з запиту
            this.вантажDataGridView.Columns.Clear(); //Прибираємо стовпці, мабуть варто їх зберігти, щоб потім відновити
            foreach (DataColumn item in source.Table.Columns)
            {
                int index = this.вантажDataGridView.Columns.Add(item.ColumnName, item.Caption);
                this.вантажDataGridView.Columns[index].DataPropertyName = item.ColumnName; //Без цього дані не будуть відображені
            }
            this.вантажDataGridView.DataSource = source;
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

            string query = "SELECT DISTINCTROW Format$([Перевантаження].[Дата заходу],'mmmm yyyy') AS [Дата заходу по месяцам], Перевантаження.[Кількість перевантаженого вантажу], Count(*) AS [Count - Перевантаження] FROM Перевантаження GROUP BY Format$([Перевантаження].[Дата заходу], 'mmmm yyyy'), Перевантаження.[Кількість перевантаженого вантажу], Year([Перевантаження].[Дата заходу])*12 + DatePart('m',[Перевантаження].[Дата заходу]) - 1";

            OleDbDataAdapter dA = new OleDbDataAdapter(query, myConnection);
            DataSet ds = new DataSet();
            dA.Fill(ds, "[C]");
            DataView source = ds.Tables[0].DefaultView; //Данні з запиту
            this.перевантаженняDataGridView.Columns.Clear(); //Прибираємо стовпці, мабуть варто їх зберігти, щоб потім відновити
            foreach (DataColumn item in source.Table.Columns)
            {
                int index = this.перевантаженняDataGridView.Columns.Add(item.ColumnName, item.Caption);
                this.перевантаженняDataGridView.Columns[index].DataPropertyName = item.ColumnName; //Без цього дані не будуть відображені
            }
            this.перевантаженняDataGridView.DataSource = source;

        }

        private void button9_Click(object sender, EventArgs e)
        {
            string query = "SELECT DISTINCTROW Format$([Перевантаження].[Дата заходу],'yyyy') AS [Дата заходу по годам], Перевантаження.[Кількість перевантаженого вантажу], Count(*) AS [Count - Перевантаження] FROM Перевантаження GROUP BY Format$([Перевантаження].[Дата заходу], 'yyyy'), Перевантаження.[Кількість перевантаженого вантажу], Year([Перевантаження].[Дата заходу])";

            OleDbDataAdapter dA = new OleDbDataAdapter(query, myConnection);
            DataSet ds = new DataSet();
            dA.Fill(ds, "[C]");
            DataView source = ds.Tables[0].DefaultView; //Данні з запиту
            this.перевантаженняDataGridView.Columns.Clear(); //Прибираємо стовпці, мабуть варто їх зберігти, щоб потім відновити
            foreach (DataColumn item in source.Table.Columns)
            {
                int index = this.перевантаженняDataGridView.Columns.Add(item.ColumnName, item.Caption);
                this.перевантаженняDataGridView.Columns[index].DataPropertyName = item.ColumnName; //Без цього дані не будуть відображені
            }
            this.перевантаженняDataGridView.DataSource = source;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string query = "SELECT DISTINCTROW Format$([Перевантаження].[Дата заходу],'Long Date') AS [Дата заходу по дням], Перевантаження.[Кількість перевантаженого вантажу], Count(*) AS [Count - Перевантаження] FROM Перевантаження GROUP BY Format$([Перевантаження].[Дата заходу], 'Long Date'), Перевантаження.[Кількість перевантаженого вантажу]";

            OleDbDataAdapter dA = new OleDbDataAdapter(query, myConnection);
            DataSet ds = new DataSet();
            dA.Fill(ds, "[C]");
            DataView source = ds.Tables[0].DefaultView; //Данні з запиту
            this.перевантаженняDataGridView.Columns.Clear(); //Прибираємо стовпці, мабуть варто їх зберігти, щоб потім відновити
            foreach (DataColumn item in source.Table.Columns)
            {
                int index = this.перевантаженняDataGridView.Columns.Add(item.ColumnName, item.Caption);
                this.перевантаженняDataGridView.Columns[index].DataPropertyName = item.ColumnName; //Без цього дані не будуть відображені
            }
            this.перевантаженняDataGridView.DataSource = source;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string query = "SELECT Судна.Назва, Перевантаження.[Час перевантаження], Перевантаження.[Час простою] FROM Судна INNER JOIN Перевантаження ON Судна.[Код] = Перевантаження.[Код судна];  ";

            OleDbDataAdapter dA = new OleDbDataAdapter(query, myConnection);
            DataSet ds = new DataSet();
            dA.Fill(ds, "[C]");
            DataView source = ds.Tables[0].DefaultView; //Данні з запиту
            this.перевантаженняDataGridView.Columns.Clear(); //Прибираємо стовпці, мабуть варто їх зберігти, щоб потім відновити
            foreach (DataColumn item in source.Table.Columns)
            {
                int index = this.перевантаженняDataGridView.Columns.Add(item.ColumnName, item.Caption);
                this.перевантаженняDataGridView.Columns[index].DataPropertyName = item.ColumnName; //Без цього дані не будуть відображені
            }
            this.перевантаженняDataGridView.DataSource = source;
        }

        private void tabPage6_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

            this.вантажTableAdapter.Fill(this.бД_Портові_термінали2DataSet.Вантаж);

            // string query = "ALTER  TABLE Вантаж DROP COLUMN Країна";
            string query = "SELECT Вантаж.[Код вантажу], Вантаж.[Код типу вантажу], Вантаж.[Назва], Вантаж.[Термін придатності (в місяцях)], Вантаж.[Дата виготовлення], Вантаж.[Код судна], Вантаж.[Кількість вантажу в тоннах] FROM Вантаж;  ";

            OleDbDataAdapter dA = new OleDbDataAdapter(query, myConnection);
            DataSet ds = new DataSet();
            dA.Fill(ds, "[C]");
            DataView source = ds.Tables[0].DefaultView; //Данні з запиту
            this.вантажDataGridView.Columns.Clear(); //Прибираємо стовпці, мабуть варто їх зберігти, щоб потім відновити
            foreach (DataColumn item in source.Table.Columns)
            {
                int index = this.вантажDataGridView.Columns.Add(item.ColumnName, item.Caption);
                this.вантажDataGridView.Columns[index].DataPropertyName = item.ColumnName; //Без цього дані не будуть відображені
            }
            this.вантажDataGridView.DataSource = source;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            string query = "DELETE Перевантаження.[Дата заходу] FROM Перевантаження WHERE(((Перевантаження.[Дата заходу]) =#9/15/2022#))";
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.ExecuteNonQuery();
            MessageBox.Show("Дані про дату видалено");
            this.перевантаженняTableAdapter.Fill(this.бД_Портові_термінали2DataSet.Перевантаження);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            string query = "UPDATE Термінали SET [Кількість причального обладнання] = 1.-10 WHERE Код = 101 ";

            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.ExecuteNonQuery();
            this.терміналиTableAdapter.Fill(this.бД_Портові_термінали2DataSet.Термінали);

        }

        private void button15_Click(object sender, EventArgs e)
        {
            string query = "UPDATE Термінали SET [Кількість працівників] = 25.+5";

            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.ExecuteNonQuery();
            this.терміналиTableAdapter.Fill(this.бД_Портові_термінали2DataSet.Термінали);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Form8 f8 = new Form8();
            f8.Owner = this;
            f8.Show();
        }

        private void button17_Click(object sender, EventArgs e)
        {


            string query = "SELECT Назва,Тоннаж FROM Судна WHERE Тоннаж  = (SELECT Max(Тоннаж) FROM Судна)";
            OleDbDataAdapter dA = new OleDbDataAdapter(query, myConnection);
            DataSet ds = new DataSet();
            dA.Fill(ds, "[C]");
            DataView source = ds.Tables[0].DefaultView; //Данні з запиту
            this.суднаDataGridView.Columns.Clear(); //Прибираємо стовпці, мабуть варто їх зберігти, щоб потім відновити
            foreach (DataColumn item in source.Table.Columns)
            {
                int index = this.суднаDataGridView.Columns.Add(item.ColumnName, item.Caption);
                this.суднаDataGridView.Columns[index].DataPropertyName = item.ColumnName; //Без цього дані не будуть відображені
            }
            this.суднаDataGridView.DataSource = source;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            string query = "UPDATE Термінали SET [Кількість працівників] = [Кількість працівників]*1.1 WHERE Код in (SELECT [Код терміналу] from Перевантаження where [Швидкість перевантаження]<12);";
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.ExecuteNonQuery();
            this.терміналиTableAdapter.Fill(this.бД_Портові_термінали2DataSet.Термінали);
            //  this.перевантаженняTableAdapter.Fill(this.бД_Портові_термінали2DataSet.Перевантаження);

        }
    }
}

    


