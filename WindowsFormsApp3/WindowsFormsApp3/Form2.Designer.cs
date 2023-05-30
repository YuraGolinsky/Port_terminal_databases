
namespace WindowsFormsApp3
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.кодDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодСуднаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.суднаBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.бД_Портові_терміналиDataSet = new WindowsFormsApp3.БД_Портові_терміналиDataSet();
            this.датаЗаходуDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.часПеревантаженняDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.часПростоюDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.швидкістьПеревантаженняDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кількістьПеревантаженогоВантажуDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодТерміналуDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.перевантаженняBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.суднаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.бД_Портові_термінали2DataSet = new WindowsFormsApp3.БД_Портові_термінали2DataSet();
            this.перевантаженняBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.терміналиBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.перевантаженняBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.терміналиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.терміналиTableAdapter = new WindowsFormsApp3.БД_Портові_термінали2DataSetTableAdapters.ТерміналиTableAdapter();
            this.перевантаженняTableAdapter = new WindowsFormsApp3.БД_Портові_термінали2DataSetTableAdapters.ПеревантаженняTableAdapter();
            this.перевантаженняBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.перевантаженняBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.перевантаженняTableAdapter1 = new WindowsFormsApp3.БД_Портові_терміналиDataSetTableAdapters.ПеревантаженняTableAdapter();
            this.суднаTableAdapter = new WindowsFormsApp3.БД_Портові_термінали2DataSetTableAdapters.СуднаTableAdapter();
            this.терміналиBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.суднаTableAdapter1 = new WindowsFormsApp3.БД_Портові_терміналиDataSetTableAdapters.СуднаTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.суднаBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.бД_Портові_терміналиDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.перевантаженняBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.суднаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.бД_Портові_термінали2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.перевантаженняBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.терміналиBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.перевантаженняBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.терміналиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.перевантаженняBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.перевантаженняBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.терміналиBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введіть дату заходу судна";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодDataGridViewTextBoxColumn,
            this.кодСуднаDataGridViewTextBoxColumn,
            this.датаЗаходуDataGridViewTextBoxColumn,
            this.часПеревантаженняDataGridViewTextBoxColumn,
            this.часПростоюDataGridViewTextBoxColumn,
            this.швидкістьПеревантаженняDataGridViewTextBoxColumn,
            this.кількістьПеревантаженогоВантажуDataGridViewTextBoxColumn,
            this.кодТерміналуDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.перевантаженняBindingSource4;
            this.dataGridView1.Location = new System.Drawing.Point(0, 204);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(788, 220);
            this.dataGridView1.TabIndex = 8;
            // 
            // кодDataGridViewTextBoxColumn
            // 
            this.кодDataGridViewTextBoxColumn.DataPropertyName = "Код";
            this.кодDataGridViewTextBoxColumn.HeaderText = "Код";
            this.кодDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.кодDataGridViewTextBoxColumn.Name = "кодDataGridViewTextBoxColumn";
            this.кодDataGridViewTextBoxColumn.Width = 125;
            // 
            // кодСуднаDataGridViewTextBoxColumn
            // 
            this.кодСуднаDataGridViewTextBoxColumn.DataPropertyName = "Код судна";
            this.кодСуднаDataGridViewTextBoxColumn.DataSource = this.суднаBindingSource1;
            this.кодСуднаDataGridViewTextBoxColumn.DisplayMember = "Назва";
            this.кодСуднаDataGridViewTextBoxColumn.HeaderText = "Код судна";
            this.кодСуднаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.кодСуднаDataGridViewTextBoxColumn.Name = "кодСуднаDataGridViewTextBoxColumn";
            this.кодСуднаDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.кодСуднаDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.кодСуднаDataGridViewTextBoxColumn.ValueMember = "Код";
            this.кодСуднаDataGridViewTextBoxColumn.Width = 125;
            // 
            // суднаBindingSource1
            // 
            this.суднаBindingSource1.DataMember = "Судна";
            this.суднаBindingSource1.DataSource = this.бД_Портові_терміналиDataSet;
            // 
            // бД_Портові_терміналиDataSet
            // 
            this.бД_Портові_терміналиDataSet.DataSetName = "БД_Портові_терміналиDataSet";
            this.бД_Портові_терміналиDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // датаЗаходуDataGridViewTextBoxColumn
            // 
            this.датаЗаходуDataGridViewTextBoxColumn.DataPropertyName = "Дата заходу";
            this.датаЗаходуDataGridViewTextBoxColumn.HeaderText = "Дата заходу";
            this.датаЗаходуDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.датаЗаходуDataGridViewTextBoxColumn.Name = "датаЗаходуDataGridViewTextBoxColumn";
            this.датаЗаходуDataGridViewTextBoxColumn.Width = 125;
            // 
            // часПеревантаженняDataGridViewTextBoxColumn
            // 
            this.часПеревантаженняDataGridViewTextBoxColumn.DataPropertyName = "Час перевантаження";
            this.часПеревантаженняDataGridViewTextBoxColumn.HeaderText = "Час перевантаження";
            this.часПеревантаженняDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.часПеревантаженняDataGridViewTextBoxColumn.Name = "часПеревантаженняDataGridViewTextBoxColumn";
            this.часПеревантаженняDataGridViewTextBoxColumn.Width = 125;
            // 
            // часПростоюDataGridViewTextBoxColumn
            // 
            this.часПростоюDataGridViewTextBoxColumn.DataPropertyName = "Час простою";
            this.часПростоюDataGridViewTextBoxColumn.HeaderText = "Час простою";
            this.часПростоюDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.часПростоюDataGridViewTextBoxColumn.Name = "часПростоюDataGridViewTextBoxColumn";
            this.часПростоюDataGridViewTextBoxColumn.Width = 125;
            // 
            // швидкістьПеревантаженняDataGridViewTextBoxColumn
            // 
            this.швидкістьПеревантаженняDataGridViewTextBoxColumn.DataPropertyName = "Швидкість перевантаження";
            this.швидкістьПеревантаженняDataGridViewTextBoxColumn.HeaderText = "Швидкість перевантаження";
            this.швидкістьПеревантаженняDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.швидкістьПеревантаженняDataGridViewTextBoxColumn.Name = "швидкістьПеревантаженняDataGridViewTextBoxColumn";
            this.швидкістьПеревантаженняDataGridViewTextBoxColumn.Width = 125;
            // 
            // кількістьПеревантаженогоВантажуDataGridViewTextBoxColumn
            // 
            this.кількістьПеревантаженогоВантажуDataGridViewTextBoxColumn.DataPropertyName = "Кількість перевантаженого вантажу";
            this.кількістьПеревантаженогоВантажуDataGridViewTextBoxColumn.HeaderText = "Кількість перевантаженого вантажу";
            this.кількістьПеревантаженогоВантажуDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.кількістьПеревантаженогоВантажуDataGridViewTextBoxColumn.Name = "кількістьПеревантаженогоВантажуDataGridViewTextBoxColumn";
            this.кількістьПеревантаженогоВантажуDataGridViewTextBoxColumn.Width = 125;
            // 
            // кодТерміналуDataGridViewTextBoxColumn
            // 
            this.кодТерміналуDataGridViewTextBoxColumn.DataPropertyName = "Код терміналу";
            this.кодТерміналуDataGridViewTextBoxColumn.HeaderText = "Код терміналу";
            this.кодТерміналуDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.кодТерміналуDataGridViewTextBoxColumn.Name = "кодТерміналуDataGridViewTextBoxColumn";
            this.кодТерміналуDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.кодТерміналуDataGridViewTextBoxColumn.Width = 125;
            // 
            // перевантаженняBindingSource4
            // 
            this.перевантаженняBindingSource4.DataMember = "Перевантаження";
            this.перевантаженняBindingSource4.DataSource = this.бД_Портові_терміналиDataSet;
            // 
            // суднаBindingSource
            // 
            this.суднаBindingSource.DataMember = "Судна";
            this.суднаBindingSource.DataSource = this.бД_Портові_термінали2DataSet;
            // 
            // бД_Портові_термінали2DataSet
            // 
            this.бД_Портові_термінали2DataSet.DataSetName = "БД_Портові_термінали2DataSet";
            this.бД_Портові_термінали2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // перевантаженняBindingSource3
            // 
            this.перевантаженняBindingSource3.DataMember = "Перевантаження";
            this.перевантаженняBindingSource3.DataSource = this.бД_Портові_терміналиDataSet;
            // 
            // терміналиBindingSource1
            // 
            this.терміналиBindingSource1.DataMember = "Термінали";
            this.терміналиBindingSource1.DataSource = this.бД_Портові_термінали2DataSet;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 111);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 40);
            this.button1.TabIndex = 10;
            this.button1.Text = "Виконати запит";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // перевантаженняBindingSource
            // 
            this.перевантаженняBindingSource.DataMember = "Перевантаження";
            this.перевантаженняBindingSource.DataSource = this.бД_Портові_термінали2DataSet;
            // 
            // терміналиBindingSource
            // 
            this.терміналиBindingSource.DataMember = "Термінали";
            this.терміналиBindingSource.DataSource = this.бД_Портові_термінали2DataSet;
            // 
            // терміналиTableAdapter
            // 
            this.терміналиTableAdapter.ClearBeforeFill = true;
            // 
            // перевантаженняTableAdapter
            // 
            this.перевантаженняTableAdapter.ClearBeforeFill = true;
            // 
            // перевантаженняBindingSource1
            // 
            this.перевантаженняBindingSource1.DataMember = "Перевантаження";
            this.перевантаженняBindingSource1.DataSource = this.бД_Портові_термінали2DataSet;
            // 
            // перевантаженняBindingSource2
            // 
            this.перевантаженняBindingSource2.DataMember = "Перевантаження";
            this.перевантаженняBindingSource2.DataSource = this.бД_Портові_термінали2DataSet;
            // 
            // перевантаженняTableAdapter1
            // 
            this.перевантаженняTableAdapter1.ClearBeforeFill = true;
            // 
            // суднаTableAdapter
            // 
            this.суднаTableAdapter.ClearBeforeFill = true;
            // 
            // терміналиBindingSource2
            // 
            this.терміналиBindingSource2.DataMember = "Термінали";
            this.терміналиBindingSource2.DataSource = this.бД_Портові_термінали2DataSet;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 68);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(199, 22);
            this.textBox1.TabIndex = 11;
            // 
            // суднаTableAdapter1
            // 
            this.суднаTableAdapter1.ClearBeforeFill = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Отримати всю інформацію про судна, що перевантажувались на терміналі ";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.суднаBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.бД_Портові_терміналиDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.перевантаженняBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.суднаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.бД_Портові_термінали2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.перевантаженняBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.терміналиBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.перевантаженняBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.терміналиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.перевантаженняBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.перевантаженняBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.терміналиBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private БД_Портові_термінали2DataSet бД_Портові_термінали2DataSet;
        private System.Windows.Forms.BindingSource терміналиBindingSource;
        private БД_Портові_термінали2DataSetTableAdapters.ТерміналиTableAdapter терміналиTableAdapter;
        private System.Windows.Forms.BindingSource перевантаженняBindingSource;
        private БД_Портові_термінали2DataSetTableAdapters.ПеревантаженняTableAdapter перевантаженняTableAdapter;
        private System.Windows.Forms.BindingSource перевантаженняBindingSource2;
        private System.Windows.Forms.BindingSource перевантаженняBindingSource1;
        private System.Windows.Forms.Button button1;
        private БД_Портові_терміналиDataSet бД_Портові_терміналиDataSet;
        private System.Windows.Forms.BindingSource перевантаженняBindingSource3;
        private БД_Портові_терміналиDataSetTableAdapters.ПеревантаженняTableAdapter перевантаженняTableAdapter1;
        private System.Windows.Forms.BindingSource суднаBindingSource;
        private БД_Портові_термінали2DataSetTableAdapters.СуднаTableAdapter суднаTableAdapter;
        private System.Windows.Forms.BindingSource терміналиBindingSource1;
        private System.Windows.Forms.BindingSource терміналиBindingSource2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.BindingSource перевантаженняBindingSource4;
        private System.Windows.Forms.BindingSource суднаBindingSource1;
        private БД_Портові_терміналиDataSetTableAdapters.СуднаTableAdapter суднаTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn кодСуднаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаЗаходуDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn часПеревантаженняDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn часПростоюDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn швидкістьПеревантаженняDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кількістьПеревантаженогоВантажуDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодТерміналуDataGridViewTextBoxColumn;
    }
}