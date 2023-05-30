
namespace WindowsFormsApp3
{
    partial class Form4
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.бД_Портові_термінали2DataSet = new WindowsFormsApp3.БД_Портові_термінали2DataSet();
            this.суднаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.суднаTableAdapter = new WindowsFormsApp3.БД_Портові_термінали2DataSetTableAdapters.СуднаTableAdapter();
            this.назваDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кількістьВантажнихЛюківDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.тоннажDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.бД_Портові_термінали2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.суднаBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.назваDataGridViewTextBoxColumn,
            this.кількістьВантажнихЛюківDataGridViewTextBoxColumn,
            this.тоннажDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.суднаBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(16, 182);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(548, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введіть кількість тонн";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(16, 85);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(41, 113);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(262, 37);
            this.button1.TabIndex = 3;
            this.button1.Text = "Отримати інформацію";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            // суднаTableAdapter
            // 
            this.суднаTableAdapter.ClearBeforeFill = true;
            // 
            // назваDataGridViewTextBoxColumn
            // 
            this.назваDataGridViewTextBoxColumn.DataPropertyName = "Назва";
            this.назваDataGridViewTextBoxColumn.HeaderText = "Назва";
            this.назваDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.назваDataGridViewTextBoxColumn.Name = "назваDataGridViewTextBoxColumn";
            this.назваDataGridViewTextBoxColumn.Width = 125;
            // 
            // кількістьВантажнихЛюківDataGridViewTextBoxColumn
            // 
            this.кількістьВантажнихЛюківDataGridViewTextBoxColumn.DataPropertyName = "Кількість вантажних люків";
            this.кількістьВантажнихЛюківDataGridViewTextBoxColumn.HeaderText = "Кількість вантажних люків";
            this.кількістьВантажнихЛюківDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.кількістьВантажнихЛюківDataGridViewTextBoxColumn.Name = "кількістьВантажнихЛюківDataGridViewTextBoxColumn";
            this.кількістьВантажнихЛюківDataGridViewTextBoxColumn.Width = 125;
            // 
            // тоннажDataGridViewTextBoxColumn
            // 
            this.тоннажDataGridViewTextBoxColumn.DataPropertyName = "Тоннаж";
            this.тоннажDataGridViewTextBoxColumn.HeaderText = "Тоннаж";
            this.тоннажDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.тоннажDataGridViewTextBoxColumn.Name = "тоннажDataGridViewTextBoxColumn";
            this.тоннажDataGridViewTextBoxColumn.Width = 125;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form4";
            this.Text = "Отримати перелік суден тоннажем більше 30 000 т ";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.бД_Портові_термінали2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.суднаBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private БД_Портові_термінали2DataSet бД_Портові_термінали2DataSet;
        private System.Windows.Forms.BindingSource суднаBindingSource;
        private БД_Портові_термінали2DataSetTableAdapters.СуднаTableAdapter суднаTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn назваDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кількістьВантажнихЛюківDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn тоннажDataGridViewTextBoxColumn;
    }
}