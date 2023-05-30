
namespace WindowsFormsApp3
{
    partial class Form5
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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.суднаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.бД_Портові_термінали2DataSet = new WindowsFormsApp3.БД_Портові_термінали2DataSet();
            this.перевантаженняBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.перевантаженняTableAdapter = new WindowsFormsApp3.БД_Портові_термінали2DataSetTableAdapters.ПеревантаженняTableAdapter();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.суднаTableAdapter = new WindowsFormsApp3.БД_Портові_термінали2DataSetTableAdapters.СуднаTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.вантажBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.вантажTableAdapter = new WindowsFormsApp3.БД_Портові_термінали2DataSetTableAdapters.ВантажTableAdapter();
            this.вантажBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.вантажBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.кодВантажуDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодТипуВантажуDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.назваDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.термінПридатностівМісяцяхDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.країнаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаВиготовленняDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодСуднаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кількістьВантажуВТоннахDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.суднаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.бД_Портові_термінали2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.перевантаженняBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.вантажBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.вантажBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.вантажBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(190, 51);
            this.button1.TabIndex = 0;
            this.button1.Text = "Отримати запит ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.dataGridView1.Location = new System.Drawing.Point(2, 176);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(801, 262);
            this.dataGridView1.TabIndex = 1;
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
            // перевантаженняBindingSource
            // 
            this.перевантаженняBindingSource.DataMember = "Перевантаження";
            this.перевантаженняBindingSource.DataSource = this.бД_Портові_термінали2DataSet;
            // 
            // перевантаженняTableAdapter
            // 
            this.перевантаженняTableAdapter.ClearBeforeFill = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(236, 114);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(221, 22);
            this.textBox2.TabIndex = 7;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // суднаTableAdapter
            // 
            this.суднаTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(233, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Вкажіть термін придатності (у місяцях)";
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
            // вантажBindingSource1
            // 
            this.вантажBindingSource1.DataMember = "Вантаж";
            this.вантажBindingSource1.DataSource = this.бД_Портові_термінали2DataSet;
            // 
            // вантажBindingSource2
            // 
            this.вантажBindingSource2.DataMember = "Вантаж";
            this.вантажBindingSource2.DataSource = this.бД_Портові_термінали2DataSet;
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
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "Form5";
            this.Text = "Отримати інформацію про термін зберігання наприклад № місяця, то вивести.";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.суднаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.бД_Портові_термінали2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.перевантаженняBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.вантажBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.вантажBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.вантажBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private БД_Портові_термінали2DataSet бД_Портові_термінали2DataSet;
        private System.Windows.Forms.BindingSource перевантаженняBindingSource;
        private БД_Портові_термінали2DataSetTableAdapters.ПеревантаженняTableAdapter перевантаженняTableAdapter;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.BindingSource суднаBindingSource;
        private БД_Портові_термінали2DataSetTableAdapters.СуднаTableAdapter суднаTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource вантажBindingSource;
        private БД_Портові_термінали2DataSetTableAdapters.ВантажTableAdapter вантажTableAdapter;
        private System.Windows.Forms.BindingSource вантажBindingSource2;
        private System.Windows.Forms.BindingSource вантажBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодВантажуDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодТипуВантажуDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn назваDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn термінПридатностівМісяцяхDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn країнаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаВиготовленняDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодСуднаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кількістьВантажуВТоннахDataGridViewTextBoxColumn;
    }
}