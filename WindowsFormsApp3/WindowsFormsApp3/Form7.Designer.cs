
namespace WindowsFormsApp3
{
    partial class Form7
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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.кодDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодСуднаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаЗаходуDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.часПеревантаженняDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.часПростоюDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.швидкістьПеревантаженняDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кількістьПеревантаженогоВантажуDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодТерміналуDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.перевантаженняBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.бД_Портові_термінали2DataSet = new WindowsFormsApp3.БД_Портові_термінали2DataSet();
            this.перевантаженняTableAdapter = new WindowsFormsApp3.БД_Портові_термінали2DataSetTableAdapters.ПеревантаженняTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.перевантаженняBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.бД_Портові_термінали2DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(26, 88);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(221, 22);
            this.textBox2.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(18, 126);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(196, 35);
            this.button1.TabIndex = 8;
            this.button1.Text = "Виконати запит ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
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
            this.dataGridView1.DataSource = this.перевантаженняBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 183);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(788, 220);
            this.dataGridView1.TabIndex = 7;
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
            this.кодСуднаDataGridViewTextBoxColumn.HeaderText = "Код судна";
            this.кодСуднаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.кодСуднаDataGridViewTextBoxColumn.Name = "кодСуднаDataGridViewTextBoxColumn";
            this.кодСуднаDataGridViewTextBoxColumn.Width = 125;
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
            this.кодТерміналуDataGridViewTextBoxColumn.Width = 125;
            // 
            // перевантаженняBindingSource
            // 
            this.перевантаженняBindingSource.DataMember = "Перевантаження";
            this.перевантаженняBindingSource.DataSource = this.бД_Портові_термінали2DataSet;
            // 
            // бД_Портові_термінали2DataSet
            // 
            this.бД_Портові_термінали2DataSet.DataSetName = "БД_Портові_термінали2DataSet";
            this.бД_Портові_термінали2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // перевантаженняTableAdapter
            // 
            this.перевантаженняTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Час простою";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form7";
            this.Text = "Час простою";
            this.Load += new System.EventHandler(this.Form7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.перевантаженняBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.бД_Портові_термінали2DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private БД_Портові_термінали2DataSet бД_Портові_термінали2DataSet;
        private System.Windows.Forms.BindingSource перевантаженняBindingSource;
        private БД_Портові_термінали2DataSetTableAdapters.ПеревантаженняTableAdapter перевантаженняTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодСуднаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаЗаходуDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn часПеревантаженняDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn часПростоюDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn швидкістьПеревантаженняDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кількістьПеревантаженогоВантажуDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодТерміналуDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
    }
}