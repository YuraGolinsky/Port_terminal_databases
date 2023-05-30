
namespace WindowsFormsApp3
{
    partial class Form6
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.типиВантажуBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.бД_Портові_термінали2DataSet = new WindowsFormsApp3.БД_Портові_термінали2DataSet();
            this.суднаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.перевантаженняBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.перевантаженняTableAdapter = new WindowsFormsApp3.БД_Портові_термінали2DataSetTableAdapters.ПеревантаженняTableAdapter();
            this.суднаTableAdapter = new WindowsFormsApp3.БД_Портові_термінали2DataSetTableAdapters.СуднаTableAdapter();
            this.вантажBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.вантажTableAdapter = new WindowsFormsApp3.БД_Портові_термінали2DataSetTableAdapters.ВантажTableAdapter();
            this.типи_вантажуTableAdapter = new WindowsFormsApp3.БД_Портові_термінали2DataSetTableAdapters.Типи_вантажуTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.кодВантажуDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодТипуВантажуDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.назваDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.термінПридатностівМісяцяхDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.країнаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаВиготовленняDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодСуднаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кількістьВантажуВТоннахDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.типиВантажуBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.бД_Портові_термінали2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.суднаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.перевантаженняBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.вантажBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодВантажуDataGridViewTextBoxColumn,
            this.кодТипуВантажуDataGridViewTextBoxColumn,
            this.назваDataGridViewTextBoxColumn,
            this.термінПридатностівМісяцяхDataGridViewTextBoxColumn,
            this.країнаDataGridViewTextBoxColumn,
            this.датаВиготовленняDataGridViewTextBoxColumn,
            this.кодСуднаDataGridViewTextBoxColumn,
            this.кількістьВантажуВТоннахDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.вантажBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(8, 180);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(795, 258);
            this.dataGridView1.TabIndex = 0;
            // 
            // типиВантажуBindingSource
            // 
            this.типиВантажуBindingSource.DataMember = "Типи вантажу";
            this.типиВантажуBindingSource.DataSource = this.бД_Портові_термінали2DataSet;
            // 
            // бД_Портові_термінали2DataSet
            // 
            this.бД_Портові_термінали2DataSet.DataSetName = "БД_Портові_термінали2DataSet";
            this.бД_Портові_термінали2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // суднаBindingSource
            // 
            this.суднаBindingSource.DataMember = "Судна";
            this.суднаBindingSource.DataSource = this.бД_Портові_термінали2DataSet;
            // 
            // перевантаженняBindingSource
            // 
            this.перевантаженняBindingSource.DataMember = "Перевантаження";
            this.перевантаженняBindingSource.DataSource = this.бД_Портові_термінали2DataSet;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(8, 90);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(210, 41);
            this.button1.TabIndex = 1;
            this.button1.Text = "Отримати  запит";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // перевантаженняTableAdapter
            // 
            this.перевантаженняTableAdapter.ClearBeforeFill = true;
            // 
            // суднаTableAdapter
            // 
            this.суднаTableAdapter.ClearBeforeFill = true;
            // 
            // вантажBindingSource
            // 
            this.вантажBindingSource.DataMember = "Вантаж";
            this.вантажBindingSource.DataSource = this.бД_Портові_термінали2DataSet;
            // 
            // вантажTableAdapter
            // 
            this.вантажTableAdapter.ClearBeforeFill = true;
            // 
            // типи_вантажуTableAdapter
            // 
            this.типи_вантажуTableAdapter.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(23, 49);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(199, 22);
            this.textBox1.TabIndex = 2;
            // 
            // кодВантажуDataGridViewTextBoxColumn
            // 
            this.кодВантажуDataGridViewTextBoxColumn.DataPropertyName = "Код вантажу";
            this.кодВантажуDataGridViewTextBoxColumn.HeaderText = "Код вантажу";
            this.кодВантажуDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.кодВантажуDataGridViewTextBoxColumn.Name = "кодВантажуDataGridViewTextBoxColumn";
            this.кодВантажуDataGridViewTextBoxColumn.Width = 125;
            // 
            // кодТипуВантажуDataGridViewTextBoxColumn
            // 
            this.кодТипуВантажуDataGridViewTextBoxColumn.DataPropertyName = "Код типу вантажу";
            this.кодТипуВантажуDataGridViewTextBoxColumn.HeaderText = "Код типу вантажу";
            this.кодТипуВантажуDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.кодТипуВантажуDataGridViewTextBoxColumn.Name = "кодТипуВантажуDataGridViewTextBoxColumn";
            this.кодТипуВантажуDataGridViewTextBoxColumn.Width = 125;
            // 
            // назваDataGridViewTextBoxColumn
            // 
            this.назваDataGridViewTextBoxColumn.DataPropertyName = "Назва";
            this.назваDataGridViewTextBoxColumn.HeaderText = "Назва";
            this.назваDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.назваDataGridViewTextBoxColumn.Name = "назваDataGridViewTextBoxColumn";
            this.назваDataGridViewTextBoxColumn.Width = 125;
            // 
            // термінПридатностівМісяцяхDataGridViewTextBoxColumn
            // 
            this.термінПридатностівМісяцяхDataGridViewTextBoxColumn.DataPropertyName = "Термін придатності (в місяцях)";
            this.термінПридатностівМісяцяхDataGridViewTextBoxColumn.HeaderText = "Термін придатності (в місяцях)";
            this.термінПридатностівМісяцяхDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.термінПридатностівМісяцяхDataGridViewTextBoxColumn.Name = "термінПридатностівМісяцяхDataGridViewTextBoxColumn";
            this.термінПридатностівМісяцяхDataGridViewTextBoxColumn.Width = 125;
            // 
            // країнаDataGridViewTextBoxColumn
            // 
            this.країнаDataGridViewTextBoxColumn.DataPropertyName = "Країна";
            this.країнаDataGridViewTextBoxColumn.HeaderText = "Країна";
            this.країнаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.країнаDataGridViewTextBoxColumn.Name = "країнаDataGridViewTextBoxColumn";
            this.країнаDataGridViewTextBoxColumn.Width = 125;
            // 
            // датаВиготовленняDataGridViewTextBoxColumn
            // 
            this.датаВиготовленняDataGridViewTextBoxColumn.DataPropertyName = "Дата виготовлення";
            this.датаВиготовленняDataGridViewTextBoxColumn.HeaderText = "Дата виготовлення";
            this.датаВиготовленняDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.датаВиготовленняDataGridViewTextBoxColumn.Name = "датаВиготовленняDataGridViewTextBoxColumn";
            this.датаВиготовленняDataGridViewTextBoxColumn.Width = 125;
            // 
            // кодСуднаDataGridViewTextBoxColumn
            // 
            this.кодСуднаDataGridViewTextBoxColumn.DataPropertyName = "Код судна";
            this.кодСуднаDataGridViewTextBoxColumn.HeaderText = "Код судна";
            this.кодСуднаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.кодСуднаDataGridViewTextBoxColumn.Name = "кодСуднаDataGridViewTextBoxColumn";
            this.кодСуднаDataGridViewTextBoxColumn.Width = 125;
            // 
            // кількістьВантажуВТоннахDataGridViewTextBoxColumn
            // 
            this.кількістьВантажуВТоннахDataGridViewTextBoxColumn.DataPropertyName = "Кількість вантажу в тоннах";
            this.кількістьВантажуВТоннахDataGridViewTextBoxColumn.HeaderText = "Кількість вантажу в тоннах";
            this.кількістьВантажуВТоннахDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.кількістьВантажуВТоннахDataGridViewTextBoxColumn.Name = "кількістьВантажуВТоннахDataGridViewTextBoxColumn";
            this.кількістьВантажуВТоннахDataGridViewTextBoxColumn.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Вкажіть країну";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form6";
            this.Text = "Отримати інформацію про поле Країна, Якщо країна Україна вивести";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.типиВантажуBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.бД_Портові_термінали2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.суднаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.перевантаженняBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.вантажBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private БД_Портові_термінали2DataSet бД_Портові_термінали2DataSet;
        private System.Windows.Forms.BindingSource перевантаженняBindingSource;
        private БД_Портові_термінали2DataSetTableAdapters.ПеревантаженняTableAdapter перевантаженняTableAdapter;
        private System.Windows.Forms.BindingSource суднаBindingSource;
        private БД_Портові_термінали2DataSetTableAdapters.СуднаTableAdapter суднаTableAdapter;
        private System.Windows.Forms.BindingSource вантажBindingSource;
        private БД_Портові_термінали2DataSetTableAdapters.ВантажTableAdapter вантажTableAdapter;
        private System.Windows.Forms.BindingSource типиВантажуBindingSource;
        private БД_Портові_термінали2DataSetTableAdapters.Типи_вантажуTableAdapter типи_вантажуTableAdapter;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодВантажуDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодТипуВантажуDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn назваDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn термінПридатностівМісяцяхDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn країнаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаВиготовленняDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодСуднаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кількістьВантажуВТоннахDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
    }
}