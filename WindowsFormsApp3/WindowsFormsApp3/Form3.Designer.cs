
namespace WindowsFormsApp3
{
    partial class Form3
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
            this.терміналиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.бД_Портові_термінали2DataSet = new WindowsFormsApp3.БД_Портові_термінали2DataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.терміналиTableAdapter = new WindowsFormsApp3.БД_Портові_термінали2DataSetTableAdapters.ТерміналиTableAdapter();
            this.кодDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.назваDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кількістьПрацівниківDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кількістьПричальногоОбладнанняDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.країнаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.містоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.терміналиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.бД_Портові_термінали2DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодDataGridViewTextBoxColumn,
            this.назваDataGridViewTextBoxColumn,
            this.кількістьПрацівниківDataGridViewTextBoxColumn,
            this.кількістьПричальногоОбладнанняDataGridViewTextBoxColumn,
            this.країнаDataGridViewTextBoxColumn,
            this.містоDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.терміналиBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 166);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(788, 220);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // терміналиBindingSource
            // 
            this.терміналиBindingSource.DataMember = "Термінали";
            this.терміналиBindingSource.DataSource = this.бД_Портові_термінали2DataSet;
            // 
            // бД_Портові_термінали2DataSet
            // 
            this.бД_Портові_термінали2DataSet.DataSetName = "БД_Портові_термінали2DataSet";
            this.бД_Портові_термінали2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 115);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(196, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = "Виконати запит пошуку";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Код терміналу для пошуку";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(20, 77);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(221, 22);
            this.textBox2.TabIndex = 6;
            // 
            // терміналиTableAdapter
            // 
            this.терміналиTableAdapter.ClearBeforeFill = true;
            // 
            // кодDataGridViewTextBoxColumn
            // 
            this.кодDataGridViewTextBoxColumn.DataPropertyName = "Код";
            this.кодDataGridViewTextBoxColumn.HeaderText = "Код";
            this.кодDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.кодDataGridViewTextBoxColumn.Name = "кодDataGridViewTextBoxColumn";
            this.кодDataGridViewTextBoxColumn.Width = 125;
            // 
            // назваDataGridViewTextBoxColumn
            // 
            this.назваDataGridViewTextBoxColumn.DataPropertyName = "Назва";
            this.назваDataGridViewTextBoxColumn.HeaderText = "Назва";
            this.назваDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.назваDataGridViewTextBoxColumn.Name = "назваDataGridViewTextBoxColumn";
            this.назваDataGridViewTextBoxColumn.Width = 125;
            // 
            // кількістьПрацівниківDataGridViewTextBoxColumn
            // 
            this.кількістьПрацівниківDataGridViewTextBoxColumn.DataPropertyName = "Кількість працівників";
            this.кількістьПрацівниківDataGridViewTextBoxColumn.HeaderText = "Кількість працівників";
            this.кількістьПрацівниківDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.кількістьПрацівниківDataGridViewTextBoxColumn.Name = "кількістьПрацівниківDataGridViewTextBoxColumn";
            this.кількістьПрацівниківDataGridViewTextBoxColumn.Width = 125;
            // 
            // кількістьПричальногоОбладнанняDataGridViewTextBoxColumn
            // 
            this.кількістьПричальногоОбладнанняDataGridViewTextBoxColumn.DataPropertyName = "Кількість причального обладнання";
            this.кількістьПричальногоОбладнанняDataGridViewTextBoxColumn.HeaderText = "Кількість причального обладнання";
            this.кількістьПричальногоОбладнанняDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.кількістьПричальногоОбладнанняDataGridViewTextBoxColumn.Name = "кількістьПричальногоОбладнанняDataGridViewTextBoxColumn";
            this.кількістьПричальногоОбладнанняDataGridViewTextBoxColumn.Width = 125;
            // 
            // країнаDataGridViewTextBoxColumn
            // 
            this.країнаDataGridViewTextBoxColumn.DataPropertyName = "Країна";
            this.країнаDataGridViewTextBoxColumn.HeaderText = "Країна";
            this.країнаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.країнаDataGridViewTextBoxColumn.Name = "країнаDataGridViewTextBoxColumn";
            this.країнаDataGridViewTextBoxColumn.Width = 125;
            // 
            // містоDataGridViewTextBoxColumn
            // 
            this.містоDataGridViewTextBoxColumn.DataPropertyName = "Місто";
            this.містоDataGridViewTextBoxColumn.HeaderText = "Місто";
            this.містоDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.містоDataGridViewTextBoxColumn.Name = "містоDataGridViewTextBoxColumn";
            this.містоDataGridViewTextBoxColumn.Width = 125;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form3";
            this.Text = "Отримати характеристики  терміналу";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.терміналиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.бД_Портові_термінали2DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private БД_Портові_термінали2DataSet бД_Портові_термінали2DataSet;
        private System.Windows.Forms.BindingSource терміналиBindingSource;
        private БД_Портові_термінали2DataSetTableAdapters.ТерміналиTableAdapter терміналиTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn назваDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кількістьПрацівниківDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кількістьПричальногоОбладнанняDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn країнаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn містоDataGridViewTextBoxColumn;
    }
}