
namespace WindowsFormsApp3
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label назваLabel1;
            System.Windows.Forms.Label термін_придатності__в_місяцях_Label;
            System.Windows.Forms.Label країнаLabel;
            System.Windows.Forms.Label дата_виготовленняLabel;
            System.Windows.Forms.Label кількість_вантажу_в_тоннахLabel;
            System.Windows.Forms.Label код_суднаLabel;
            System.Windows.Forms.Label код_вантажуLabel;
            System.Windows.Forms.Label код_типу_вантажуLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.бД_Портові_термінали2DataSet = new WindowsFormsApp3.БД_Портові_термінали2DataSet();
            this.бДПортовітермінали2DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.вантажBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.вантажTableAdapter = new WindowsFormsApp3.БД_Портові_термінали2DataSetTableAdapters.ВантажTableAdapter();
            this.вантажBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.суднаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.типи_вантажуBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.суднаBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.терміналиBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.перевантаженняBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.терміналиBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager = new WindowsFormsApp3.БД_Портові_термінали2DataSetTableAdapters.TableAdapterManager();
            this.перевантаженняTableAdapter = new WindowsFormsApp3.БД_Портові_термінали2DataSetTableAdapters.ПеревантаженняTableAdapter();
            this.суднаTableAdapter = new WindowsFormsApp3.БД_Портові_термінали2DataSetTableAdapters.СуднаTableAdapter();
            this.терміналиTableAdapter = new WindowsFormsApp3.БД_Портові_термінали2DataSetTableAdapters.ТерміналиTableAdapter();
            this.типи_вантажуTableAdapter = new WindowsFormsApp3.БД_Портові_термінали2DataSetTableAdapters.Типи_вантажуTableAdapter();
            this.терміналиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.типиВантажуBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.терміналиBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.вантажBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.суднаBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.перевантаженняBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.перевантаженняBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.отриматиИнформаціюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отриматиВсюІнформаціюПроСуднаЩоПеревантажувалисьНаТерміналіToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отриматиХарактеристикиТерміналуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отриматиПерелікСуденТоннажемБільше30ТоннToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отриматиПерелікШвидкопсувнихВантажівВідсортуватиЗаНазвоюУАлфавітномуПорядкуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отриматиПерелікВітчизнянихВантажівВідсортуватиЗаТипоммаєБутиВказаноНазвуТипуВантажуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отриматиПерелікСуденЧасПростоюЯкихБільше2ДібАЧасПеревантаженняБільше5ДібToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.кодDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.назваDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кількістьПрацівниківDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кількістьПричальногоОбладнанняDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.країнаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.містоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.button18 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.терміналиDataGridView = new System.Windows.Forms.DataGridView();
            this.кодDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.назваDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кількістьПрацівниківDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кількістьПричальногоОбладнанняDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.країнаDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.містоDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.терміналиBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.button13 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.перевантаженняDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button17 = new System.Windows.Forms.Button();
            this.суднаDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.типи_вантажуDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.код_типу_вантажуTextBox = new System.Windows.Forms.TextBox();
            this.код_вантажуTextBox = new System.Windows.Forms.TextBox();
            this.кількість_вантажу_в_тоннахTextBox = new System.Windows.Forms.TextBox();
            this.країнаTextBox = new System.Windows.Forms.TextBox();
            this.термін_придатності__в_місяцях_TextBox = new System.Windows.Forms.TextBox();
            this.назваTextBox = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.bindingNavigator2 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem1 = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem1 = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.дата_виготовленняDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.button12 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.вантажDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn27 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn28 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn29 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.бД_Портові_терміналиDataSet = new WindowsFormsApp3.БД_Портові_терміналиDataSet();
            this.бДПортовітерміналиDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.терміналиBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.терміналиTableAdapter1 = new WindowsFormsApp3.БД_Портові_терміналиDataSetTableAdapters.ТерміналиTableAdapter();
            назваLabel1 = new System.Windows.Forms.Label();
            термін_придатності__в_місяцях_Label = new System.Windows.Forms.Label();
            країнаLabel = new System.Windows.Forms.Label();
            дата_виготовленняLabel = new System.Windows.Forms.Label();
            кількість_вантажу_в_тоннахLabel = new System.Windows.Forms.Label();
            код_суднаLabel = new System.Windows.Forms.Label();
            код_вантажуLabel = new System.Windows.Forms.Label();
            код_типу_вантажуLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.бД_Портові_термінали2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.бДПортовітермінали2DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.вантажBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.вантажBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.суднаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.типи_вантажуBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.суднаBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.терміналиBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.перевантаженняBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.терміналиBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.терміналиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.типиВантажуBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.терміналиBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.вантажBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.суднаBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.перевантаженняBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.перевантаженняBindingSource2)).BeginInit();
            this.menuStrip2.SuspendLayout();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.терміналиDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.терміналиBindingSource5)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.перевантаженняDataGridView)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.суднаDataGridView)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.типи_вантажуDataGridView)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator2)).BeginInit();
            this.bindingNavigator2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.вантажDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.бД_Портові_терміналиDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.бДПортовітерміналиDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.терміналиBindingSource4)).BeginInit();
            this.SuspendLayout();
            // 
            // назваLabel1
            // 
            назваLabel1.AutoSize = true;
            назваLabel1.Location = new System.Drawing.Point(394, 92);
            назваLabel1.Name = "назваLabel1";
            назваLabel1.Size = new System.Drawing.Size(52, 17);
            назваLabel1.TabIndex = 4;
            назваLabel1.Text = "Назва:";
            // 
            // термін_придатності__в_місяцях_Label
            // 
            термін_придатності__в_місяцях_Label.AutoSize = true;
            термін_придатності__в_місяцях_Label.Location = new System.Drawing.Point(378, 135);
            термін_придатності__в_місяцях_Label.Name = "термін_придатності__в_місяцях_Label";
            термін_придатності__в_місяцях_Label.Size = new System.Drawing.Size(215, 17);
            термін_придатності__в_місяцях_Label.TabIndex = 6;
            термін_придатності__в_місяцях_Label.Text = "Термін придатності (в місяцях):";
            // 
            // країнаLabel
            // 
            країнаLabel.AutoSize = true;
            країнаLabel.Location = new System.Drawing.Point(390, 172);
            країнаLabel.Name = "країнаLabel";
            країнаLabel.Size = new System.Drawing.Size(56, 17);
            країнаLabel.TabIndex = 8;
            країнаLabel.Text = "Країна:";
            // 
            // дата_виготовленняLabel
            // 
            дата_виготовленняLabel.AutoSize = true;
            дата_виготовленняLabel.Location = new System.Drawing.Point(630, 44);
            дата_виготовленняLabel.Name = "дата_виготовленняLabel";
            дата_виготовленняLabel.Size = new System.Drawing.Size(140, 17);
            дата_виготовленняLabel.TabIndex = 10;
            дата_виготовленняLabel.Text = "Дата виготовлення:";
            // 
            // кількість_вантажу_в_тоннахLabel
            // 
            кількість_вантажу_в_тоннахLabel.AutoSize = true;
            кількість_вантажу_в_тоннахLabel.Location = new System.Drawing.Point(304, 44);
            кількість_вантажу_в_тоннахLabel.Name = "кількість_вантажу_в_тоннахLabel";
            кількість_вантажу_в_тоннахLabel.Size = new System.Drawing.Size(188, 17);
            кількість_вантажу_в_тоннахLabel.TabIndex = 14;
            кількість_вантажу_в_тоннахLabel.Text = "Кількість вантажу в тоннах:";
            // 
            // код_суднаLabel
            // 
            код_суднаLabel.AutoSize = true;
            код_суднаLabel.Location = new System.Drawing.Point(14, 148);
            код_суднаLabel.Name = "код_суднаLabel";
            код_суднаLabel.Size = new System.Drawing.Size(79, 17);
            код_суднаLabel.TabIndex = 18;
            код_суднаLabel.Text = "Код судна:";
            // 
            // код_вантажуLabel
            // 
            код_вантажуLabel.AutoSize = true;
            код_вантажуLabel.Location = new System.Drawing.Point(14, 36);
            код_вантажуLabel.Name = "код_вантажуLabel";
            код_вантажуLabel.Size = new System.Drawing.Size(95, 17);
            код_вантажуLabel.TabIndex = 18;
            код_вантажуLabel.Text = "Код вантажу:";
            // 
            // код_типу_вантажуLabel
            // 
            код_типу_вантажуLabel.AutoSize = true;
            код_типу_вантажуLabel.Location = new System.Drawing.Point(6, 89);
            код_типу_вантажуLabel.Name = "код_типу_вантажуLabel";
            код_типу_вантажуLabel.Size = new System.Drawing.Size(129, 17);
            код_типу_вантажуLabel.TabIndex = 19;
            код_типу_вантажуLabel.Text = "Код типу вантажу:";
            // 
            // бД_Портові_термінали2DataSet
            // 
            this.бД_Портові_термінали2DataSet.DataSetName = "БД_Портові_термінали2DataSet";
            this.бД_Портові_термінали2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // бДПортовітермінали2DataSetBindingSource
            // 
            this.бДПортовітермінали2DataSetBindingSource.DataSource = this.бД_Портові_термінали2DataSet;
            this.бДПортовітермінали2DataSetBindingSource.Position = 0;
            // 
            // вантажBindingSource
            // 
            this.вантажBindingSource.DataMember = "Вантаж";
            this.вантажBindingSource.DataSource = this.бДПортовітермінали2DataSetBindingSource;
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
            // суднаBindingSource
            // 
            this.суднаBindingSource.DataMember = "Судна";
            this.суднаBindingSource.DataSource = this.бДПортовітермінали2DataSetBindingSource;
            // 
            // типи_вантажуBindingSource
            // 
            this.типи_вантажуBindingSource.DataMember = "Типи вантажу";
            this.типи_вантажуBindingSource.DataSource = this.бД_Портові_термінали2DataSet;
            // 
            // суднаBindingSource1
            // 
            this.суднаBindingSource1.DataMember = "Судна";
            this.суднаBindingSource1.DataSource = this.бД_Портові_термінали2DataSet;
            // 
            // терміналиBindingSource2
            // 
            this.терміналиBindingSource2.DataMember = "Термінали";
            this.терміналиBindingSource2.DataSource = this.бДПортовітермінали2DataSetBindingSource;
            // 
            // перевантаженняBindingSource
            // 
            this.перевантаженняBindingSource.DataMember = "Перевантаження";
            this.перевантаженняBindingSource.DataSource = this.бД_Портові_термінали2DataSet;
            // 
            // терміналиBindingSource1
            // 
            this.терміналиBindingSource1.DataMember = "Термінали";
            this.терміналиBindingSource1.DataSource = this.бД_Портові_термінали2DataSet;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp3.БД_Портові_термінали2DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ВантажTableAdapter = this.вантажTableAdapter;
            this.tableAdapterManager.ПеревантаженняTableAdapter = this.перевантаженняTableAdapter;
            this.tableAdapterManager.СуднаTableAdapter = this.суднаTableAdapter;
            this.tableAdapterManager.ТерміналиTableAdapter = this.терміналиTableAdapter;
            this.tableAdapterManager.Типи_вантажуTableAdapter = this.типи_вантажуTableAdapter;
            // 
            // перевантаженняTableAdapter
            // 
            this.перевантаженняTableAdapter.ClearBeforeFill = true;
            // 
            // суднаTableAdapter
            // 
            this.суднаTableAdapter.ClearBeforeFill = true;
            // 
            // терміналиTableAdapter
            // 
            this.терміналиTableAdapter.ClearBeforeFill = true;
            // 
            // типи_вантажуTableAdapter
            // 
            this.типи_вантажуTableAdapter.ClearBeforeFill = true;
            // 
            // терміналиBindingSource
            // 
            this.терміналиBindingSource.DataMember = "Термінали";
            this.терміналиBindingSource.DataSource = this.бДПортовітермінали2DataSetBindingSource;
            // 
            // типиВантажуBindingSource
            // 
            this.типиВантажуBindingSource.DataMember = "Типи вантажу";
            this.типиВантажуBindingSource.DataSource = this.бДПортовітермінали2DataSetBindingSource;
            // 
            // терміналиBindingSource3
            // 
            this.терміналиBindingSource3.DataMember = "Термінали";
            this.терміналиBindingSource3.DataSource = this.бДПортовітермінали2DataSetBindingSource;
            // 
            // вантажBindingSource2
            // 
            this.вантажBindingSource2.DataMember = "Вантаж";
            this.вантажBindingSource2.DataSource = this.бДПортовітермінали2DataSetBindingSource;
            // 
            // суднаBindingSource2
            // 
            this.суднаBindingSource2.DataMember = "Судна";
            this.суднаBindingSource2.DataSource = this.бДПортовітермінали2DataSetBindingSource;
            // 
            // перевантаженняBindingSource1
            // 
            this.перевантаженняBindingSource1.DataMember = "Перевантаження";
            this.перевантаженняBindingSource1.DataSource = this.бДПортовітермінали2DataSetBindingSource;
            // 
            // перевантаженняBindingSource2
            // 
            this.перевантаженняBindingSource2.DataMember = "Перевантаження";
            this.перевантаженняBindingSource2.DataSource = this.бДПортовітермінали2DataSetBindingSource;
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.отриматиИнформаціюToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1295, 28);
            this.menuStrip2.TabIndex = 3;
            this.menuStrip2.Text = "menuStrip2";
            this.menuStrip2.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip2_ItemClicked);
            // 
            // отриматиИнформаціюToolStripMenuItem
            // 
            this.отриматиИнформаціюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.отриматиВсюІнформаціюПроСуднаЩоПеревантажувалисьНаТерміналіToolStripMenuItem,
            this.отриматиХарактеристикиТерміналуToolStripMenuItem,
            this.отриматиПерелікСуденТоннажемБільше30ТоннToolStripMenuItem,
            this.отриматиПерелікШвидкопсувнихВантажівВідсортуватиЗаНазвоюУАлфавітномуПорядкуToolStripMenuItem,
            this.отриматиПерелікВітчизнянихВантажівВідсортуватиЗаТипоммаєБутиВказаноНазвуТипуВантажуToolStripMenuItem,
            this.отриматиПерелікСуденЧасПростоюЯкихБільше2ДібАЧасПеревантаженняБільше5ДібToolStripMenuItem});
            this.отриматиИнформаціюToolStripMenuItem.Name = "отриматиИнформаціюToolStripMenuItem";
            this.отриматиИнформаціюToolStripMenuItem.Size = new System.Drawing.Size(181, 24);
            this.отриматиИнформаціюToolStripMenuItem.Text = "Отримати інформацію";
            // 
            // отриматиВсюІнформаціюПроСуднаЩоПеревантажувалисьНаТерміналіToolStripMenuItem
            // 
            this.отриматиВсюІнформаціюПроСуднаЩоПеревантажувалисьНаТерміналіToolStripMenuItem.Name = "отриматиВсюІнформаціюПроСуднаЩоПеревантажувалисьНаТерміналіToolStripMenuItem";
            this.отриматиВсюІнформаціюПроСуднаЩоПеревантажувалисьНаТерміналіToolStripMenuItem.Size = new System.Drawing.Size(648, 26);
            this.отриматиВсюІнформаціюПроСуднаЩоПеревантажувалисьНаТерміналіToolStripMenuItem.Text = "Отримати всю інформацію про судна, що перевантажувались на терміналі ";
            this.отриматиВсюІнформаціюПроСуднаЩоПеревантажувалисьНаТерміналіToolStripMenuItem.Click += new System.EventHandler(this.отриматиВсюІнформаціюПроСуднаЩоПеревантажувалисьНаТерміналіToolStripMenuItem_Click);
            // 
            // отриматиХарактеристикиТерміналуToolStripMenuItem
            // 
            this.отриматиХарактеристикиТерміналуToolStripMenuItem.Name = "отриматиХарактеристикиТерміналуToolStripMenuItem";
            this.отриматиХарактеристикиТерміналуToolStripMenuItem.Size = new System.Drawing.Size(648, 26);
            this.отриматиХарактеристикиТерміналуToolStripMenuItem.Text = "Отримати характеристики  терміналу";
            this.отриматиХарактеристикиТерміналуToolStripMenuItem.Click += new System.EventHandler(this.отриматиХарактеристикиТерміналуToolStripMenuItem_Click);
            // 
            // отриматиПерелікСуденТоннажемБільше30ТоннToolStripMenuItem
            // 
            this.отриматиПерелікСуденТоннажемБільше30ТоннToolStripMenuItem.Name = "отриматиПерелікСуденТоннажемБільше30ТоннToolStripMenuItem";
            this.отриматиПерелікСуденТоннажемБільше30ТоннToolStripMenuItem.Size = new System.Drawing.Size(648, 26);
            this.отриматиПерелікСуденТоннажемБільше30ТоннToolStripMenuItem.Text = "Отримати перелік суден тоннажем більше 30 тонн";
            this.отриматиПерелікСуденТоннажемБільше30ТоннToolStripMenuItem.Click += new System.EventHandler(this.отриматиПерелікСуденТоннажемБільше30ТоннToolStripMenuItem_Click);
            // 
            // отриматиПерелікШвидкопсувнихВантажівВідсортуватиЗаНазвоюУАлфавітномуПорядкуToolStripMenuItem
            // 
            this.отриматиПерелікШвидкопсувнихВантажівВідсортуватиЗаНазвоюУАлфавітномуПорядкуToolStripMenuItem.Name = "отриматиПерелікШвидкопсувнихВантажівВідсортуватиЗаНазвоюУАлфавітномуПорядкуToolSt" +
    "ripMenuItem";
            this.отриматиПерелікШвидкопсувнихВантажівВідсортуватиЗаНазвоюУАлфавітномуПорядкуToolStripMenuItem.Size = new System.Drawing.Size(648, 26);
            this.отриматиПерелікШвидкопсувнихВантажівВідсортуватиЗаНазвоюУАлфавітномуПорядкуToolStripMenuItem.Text = "Отримати інформацію про термін зберігання наприклад № місяца, то вивести.";
            this.отриматиПерелікШвидкопсувнихВантажівВідсортуватиЗаНазвоюУАлфавітномуПорядкуToolStripMenuItem.Click += new System.EventHandler(this.отриматиПерелікШвидкопсувнихВантажівВідсортуватиЗаНазвоюУАлфавітномуПорядкуToolStripMenuItem_Click);
            // 
            // отриматиПерелікВітчизнянихВантажівВідсортуватиЗаТипоммаєБутиВказаноНазвуТипуВантажуToolStripMenuItem
            // 
            this.отриматиПерелікВітчизнянихВантажівВідсортуватиЗаТипоммаєБутиВказаноНазвуТипуВантажуToolStripMenuItem.Name = "отриматиПерелікВітчизнянихВантажівВідсортуватиЗаТипоммаєБутиВказаноНазвуТипуВанта" +
    "жуToolStripMenuItem";
            this.отриматиПерелікВітчизнянихВантажівВідсортуватиЗаТипоммаєБутиВказаноНазвуТипуВантажуToolStripMenuItem.Size = new System.Drawing.Size(648, 26);
            this.отриматиПерелікВітчизнянихВантажівВідсортуватиЗаТипоммаєБутиВказаноНазвуТипуВантажуToolStripMenuItem.Text = "Отримати інформацію про поле Країна, Якщо країна Україна вивести";
            this.отриматиПерелікВітчизнянихВантажівВідсортуватиЗаТипоммаєБутиВказаноНазвуТипуВантажуToolStripMenuItem.Click += new System.EventHandler(this.отриматиПерелікВітчизнянихВантажівВідсортуватиЗаТипоммаєБутиВказаноНазвуТипуВантажуToolStripMenuItem_Click);
            // 
            // отриматиПерелікСуденЧасПростоюЯкихБільше2ДібАЧасПеревантаженняБільше5ДібToolStripMenuItem
            // 
            this.отриматиПерелікСуденЧасПростоюЯкихБільше2ДібАЧасПеревантаженняБільше5ДібToolStripMenuItem.Name = "отриматиПерелікСуденЧасПростоюЯкихБільше2ДібАЧасПеревантаженняБільше5ДібToolStrip" +
    "MenuItem";
            this.отриматиПерелікСуденЧасПростоюЯкихБільше2ДібАЧасПеревантаженняБільше5ДібToolStripMenuItem.Size = new System.Drawing.Size(648, 26);
            this.отриматиПерелікСуденЧасПростоюЯкихБільше2ДібАЧасПеревантаженняБільше5ДібToolStripMenuItem.Text = "Час простою";
            this.отриматиПерелікСуденЧасПростоюЯкихБільше2ДібАЧасПеревантаженняБільше5ДібToolStripMenuItem.Click += new System.EventHandler(this.отриматиПерелікСуденЧасПростоюЯкихБільше2ДібАЧасПеревантаженняБільше5ДібToolStripMenuItem_Click);
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.textBox2);
            this.tabPage6.Controls.Add(this.button3);
            this.tabPage6.Controls.Add(this.label1);
            this.tabPage6.Controls.Add(this.textBox1);
            this.tabPage6.Controls.Add(this.button1);
            this.tabPage6.Controls.Add(this.dataGridView1);
            this.tabPage6.Controls.Add(this.menuStrip1);
            this.tabPage6.Location = new System.Drawing.Point(4, 25);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(1056, 366);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Запит 7";
            this.tabPage6.UseVisualStyleBackColor = true;
            this.tabPage6.Click += new System.EventHandler(this.tabPage6_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(596, 236);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(227, 22);
            this.textBox2.TabIndex = 7;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(596, 261);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(328, 35);
            this.button3.TabIndex = 6;
            this.button3.Text = "Порахувати кількість терміналів";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(371, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Введіть код терміналу для запиту на видалення";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 261);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(0, 289);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(217, 35);
            this.button1.TabIndex = 2;
            this.button1.Text = "Видалити термінал";
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
            this.назваDataGridViewTextBoxColumn,
            this.кількістьПрацівниківDataGridViewTextBoxColumn,
            this.кількістьПричальногоОбладнанняDataGridViewTextBoxColumn,
            this.країнаDataGridViewTextBoxColumn,
            this.містоDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.терміналиBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(3, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(878, 224);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(3, 3);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1050, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.button18);
            this.tabPage5.Controls.Add(this.button16);
            this.tabPage5.Controls.Add(this.button15);
            this.tabPage5.Controls.Add(this.button14);
            this.tabPage5.Controls.Add(this.textBox6);
            this.tabPage5.Controls.Add(this.button6);
            this.tabPage5.Controls.Add(this.textBox5);
            this.tabPage5.Controls.Add(this.button5);
            this.tabPage5.Controls.Add(this.терміналиDataGridView);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1056, 366);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Термінали";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // button18
            // 
            this.button18.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button18.Location = new System.Drawing.Point(799, 6);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(232, 96);
            this.button18.TabIndex = 8;
            this.button18.Text = "\tПідвищити на 10% кількість працівників на терміналах, де швидкість перевантаженн" +
    "я судна  менше вказаного числа";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.button18_Click);
            // 
            // button16
            // 
            this.button16.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button16.Location = new System.Drawing.Point(608, 241);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(399, 39);
            this.button16.TabIndex = 7;
            this.button16.Text = "Додати інформацію про новий термінал";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // button15
            // 
            this.button15.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button15.Location = new System.Drawing.Point(519, 292);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(455, 39);
            this.button15.TabIndex = 6;
            this.button15.Text = "Збільшити на 5 кількість працівників всіх терміналів. ";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // button14
            // 
            this.button14.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button14.Location = new System.Drawing.Point(42, 292);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(455, 39);
            this.button14.TabIndex = 5;
            this.button14.Text = "Зменшити на 10% кількість обладнання 2 терміналу";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(289, 219);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(155, 22);
            this.textBox6.TabIndex = 4;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.Location = new System.Drawing.Point(289, 243);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(294, 35);
            this.button6.TabIndex = 3;
            this.button6.Text = "Кількість причального обладнання";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(23, 219);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(155, 22);
            this.textBox5.TabIndex = 2;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(23, 247);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(221, 31);
            this.button5.TabIndex = 1;
            this.button5.Text = "Кількість працівників";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // терміналиDataGridView
            // 
            this.терміналиDataGridView.AutoGenerateColumns = false;
            this.терміналиDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.терміналиDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодDataGridViewTextBoxColumn1,
            this.назваDataGridViewTextBoxColumn1,
            this.кількістьПрацівниківDataGridViewTextBoxColumn1,
            this.кількістьПричальногоОбладнанняDataGridViewTextBoxColumn1,
            this.країнаDataGridViewTextBoxColumn1,
            this.містоDataGridViewTextBoxColumn1});
            this.терміналиDataGridView.DataSource = this.терміналиBindingSource5;
            this.терміналиDataGridView.Location = new System.Drawing.Point(6, 3);
            this.терміналиDataGridView.Name = "терміналиDataGridView";
            this.терміналиDataGridView.RowHeadersWidth = 51;
            this.терміналиDataGridView.RowTemplate.Height = 24;
            this.терміналиDataGridView.Size = new System.Drawing.Size(778, 210);
            this.терміналиDataGridView.TabIndex = 0;
            // 
            // кодDataGridViewTextBoxColumn1
            // 
            this.кодDataGridViewTextBoxColumn1.DataPropertyName = "Код";
            this.кодDataGridViewTextBoxColumn1.HeaderText = "Код";
            this.кодDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.кодDataGridViewTextBoxColumn1.Name = "кодDataGridViewTextBoxColumn1";
            this.кодDataGridViewTextBoxColumn1.Width = 125;
            // 
            // назваDataGridViewTextBoxColumn1
            // 
            this.назваDataGridViewTextBoxColumn1.DataPropertyName = "Назва";
            this.назваDataGridViewTextBoxColumn1.HeaderText = "Назва";
            this.назваDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.назваDataGridViewTextBoxColumn1.Name = "назваDataGridViewTextBoxColumn1";
            this.назваDataGridViewTextBoxColumn1.Width = 125;
            // 
            // кількістьПрацівниківDataGridViewTextBoxColumn1
            // 
            this.кількістьПрацівниківDataGridViewTextBoxColumn1.DataPropertyName = "Кількість працівників";
            this.кількістьПрацівниківDataGridViewTextBoxColumn1.HeaderText = "Кількість працівників";
            this.кількістьПрацівниківDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.кількістьПрацівниківDataGridViewTextBoxColumn1.Name = "кількістьПрацівниківDataGridViewTextBoxColumn1";
            this.кількістьПрацівниківDataGridViewTextBoxColumn1.Width = 125;
            // 
            // кількістьПричальногоОбладнанняDataGridViewTextBoxColumn1
            // 
            this.кількістьПричальногоОбладнанняDataGridViewTextBoxColumn1.DataPropertyName = "Кількість причального обладнання";
            this.кількістьПричальногоОбладнанняDataGridViewTextBoxColumn1.HeaderText = "Кількість причального обладнання";
            this.кількістьПричальногоОбладнанняDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.кількістьПричальногоОбладнанняDataGridViewTextBoxColumn1.Name = "кількістьПричальногоОбладнанняDataGridViewTextBoxColumn1";
            this.кількістьПричальногоОбладнанняDataGridViewTextBoxColumn1.Width = 125;
            // 
            // країнаDataGridViewTextBoxColumn1
            // 
            this.країнаDataGridViewTextBoxColumn1.DataPropertyName = "Країна";
            this.країнаDataGridViewTextBoxColumn1.HeaderText = "Країна";
            this.країнаDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.країнаDataGridViewTextBoxColumn1.Name = "країнаDataGridViewTextBoxColumn1";
            this.країнаDataGridViewTextBoxColumn1.Width = 125;
            // 
            // містоDataGridViewTextBoxColumn1
            // 
            this.містоDataGridViewTextBoxColumn1.DataPropertyName = "Місто";
            this.містоDataGridViewTextBoxColumn1.HeaderText = "Місто";
            this.містоDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.містоDataGridViewTextBoxColumn1.Name = "містоDataGridViewTextBoxColumn1";
            this.містоDataGridViewTextBoxColumn1.Width = 125;
            // 
            // терміналиBindingSource5
            // 
            this.терміналиBindingSource5.DataMember = "Термінали";
            this.терміналиBindingSource5.DataSource = this.бД_Портові_термінали2DataSet;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.button13);
            this.tabPage4.Controls.Add(this.button11);
            this.tabPage4.Controls.Add(this.button10);
            this.tabPage4.Controls.Add(this.button9);
            this.tabPage4.Controls.Add(this.button8);
            this.tabPage4.Controls.Add(this.textBox4);
            this.tabPage4.Controls.Add(this.button4);
            this.tabPage4.Controls.Add(this.textBox3);
            this.tabPage4.Controls.Add(this.button2);
            this.tabPage4.Controls.Add(this.перевантаженняDataGridView);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1056, 366);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Переватаження";
            this.tabPage4.UseVisualStyleBackColor = true;
            this.tabPage4.Click += new System.EventHandler(this.tabPage4_Click);
            // 
            // button13
            // 
            this.button13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button13.Location = new System.Drawing.Point(351, 274);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(230, 48);
            this.button13.TabIndex = 23;
            this.button13.Text = "Видалити інформацію про перевантаження за датою";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button11
            // 
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button11.Location = new System.Drawing.Point(51, 271);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(245, 55);
            this.button11.TabIndex = 22;
            this.button11.Text = "Отримати годину простий плюс годину перевантаження судна і назву судна за кодом с" +
    "удна";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button10.Location = new System.Drawing.Point(569, 227);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(478, 32);
            this.button10.TabIndex = 21;
            this.button10.Text = "Отримати кількість вантажу перевантаженого днями";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button9.Location = new System.Drawing.Point(665, 302);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(385, 35);
            this.button9.TabIndex = 20;
            this.button9.Text = "Отримати кількість перевантажень за 2022 рік";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button8.Location = new System.Drawing.Point(604, 265);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(446, 31);
            this.button8.TabIndex = 14;
            this.button8.Text = "Отримати кількість суден перевантажених по місяцях";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(6, 333);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(142, 22);
            this.textBox4.TabIndex = 4;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(162, 326);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(357, 34);
            this.button4.TabIndex = 3;
            this.button4.Text = "Середня година простою судна";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(3, 237);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(142, 22);
            this.textBox3.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(151, 233);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(357, 34);
            this.button2.TabIndex = 1;
            this.button2.Text = "Середня година перевантаження";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // перевантаженняDataGridView
            // 
            this.перевантаженняDataGridView.AutoGenerateColumns = false;
            this.перевантаженняDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.перевантаженняDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewTextBoxColumn19,
            this.dataGridViewTextBoxColumn20});
            this.перевантаженняDataGridView.DataSource = this.перевантаженняBindingSource;
            this.перевантаженняDataGridView.Location = new System.Drawing.Point(-4, 3);
            this.перевантаженняDataGridView.Name = "перевантаженняDataGridView";
            this.перевантаженняDataGridView.RowHeadersWidth = 51;
            this.перевантаженняDataGridView.RowTemplate.Height = 24;
            this.перевантаженняDataGridView.Size = new System.Drawing.Size(1057, 219);
            this.перевантаженняDataGridView.TabIndex = 0;
            this.перевантаженняDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.перевантаженняDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Код";
            this.dataGridViewTextBoxColumn13.HeaderText = "Код";
            this.dataGridViewTextBoxColumn13.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.Width = 125;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "Код судна";
            this.dataGridViewTextBoxColumn14.DataSource = this.суднаBindingSource;
            this.dataGridViewTextBoxColumn14.DisplayMember = "Назва";
            this.dataGridViewTextBoxColumn14.HeaderText = "Код судна";
            this.dataGridViewTextBoxColumn14.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn14.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn14.ValueMember = "Код";
            this.dataGridViewTextBoxColumn14.Width = 125;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "Дата заходу";
            this.dataGridViewTextBoxColumn15.HeaderText = "Дата заходу";
            this.dataGridViewTextBoxColumn15.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.Width = 125;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "Час перевантаження";
            this.dataGridViewTextBoxColumn16.HeaderText = "Час перевантаження";
            this.dataGridViewTextBoxColumn16.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.Width = 125;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "Час простою";
            this.dataGridViewTextBoxColumn17.HeaderText = "Час простою";
            this.dataGridViewTextBoxColumn17.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.Width = 125;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "Швидкість перевантаження";
            this.dataGridViewTextBoxColumn18.HeaderText = "Швидкість перевантаження";
            this.dataGridViewTextBoxColumn18.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.Width = 125;
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "Кількість перевантаженого вантажу";
            this.dataGridViewTextBoxColumn19.HeaderText = "Кількість перевантаженого вантажу";
            this.dataGridViewTextBoxColumn19.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            this.dataGridViewTextBoxColumn19.Width = 125;
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.DataPropertyName = "Код терміналу";
            this.dataGridViewTextBoxColumn20.DataSource = this.терміналиBindingSource2;
            this.dataGridViewTextBoxColumn20.DisplayMember = "Назва";
            this.dataGridViewTextBoxColumn20.HeaderText = "Код терміналу";
            this.dataGridViewTextBoxColumn20.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            this.dataGridViewTextBoxColumn20.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn20.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn20.ValueMember = "Код";
            this.dataGridViewTextBoxColumn20.Width = 125;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button17);
            this.tabPage3.Controls.Add(this.суднаDataGridView);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1056, 366);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Судна";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button17
            // 
            this.button17.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button17.Location = new System.Drawing.Point(674, 109);
            this.button17.Name = "button17";
            this.button17.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button17.Size = new System.Drawing.Size(345, 44);
            this.button17.TabIndex = 1;
            this.button17.Text = "Отримати назву найважчого судна";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // суднаDataGridView
            // 
            this.суднаDataGridView.AutoGenerateColumns = false;
            this.суднаDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.суднаDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
            this.суднаDataGridView.DataSource = this.суднаBindingSource1;
            this.суднаDataGridView.Location = new System.Drawing.Point(0, 6);
            this.суднаDataGridView.Name = "суднаDataGridView";
            this.суднаDataGridView.RowHeadersWidth = 51;
            this.суднаDataGridView.RowTemplate.Height = 24;
            this.суднаDataGridView.Size = new System.Drawing.Size(653, 364);
            this.суднаDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Код";
            this.dataGridViewTextBoxColumn9.HeaderText = "Код";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 125;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Назва";
            this.dataGridViewTextBoxColumn10.HeaderText = "Назва";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 125;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Кількість вантажних люків";
            this.dataGridViewTextBoxColumn11.HeaderText = "Кількість вантажних люків";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Width = 125;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Тоннаж";
            this.dataGridViewTextBoxColumn12.HeaderText = "Тоннаж";
            this.dataGridViewTextBoxColumn12.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.Width = 125;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.типи_вантажуDataGridView);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1056, 366);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Тип вантажу";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // типи_вантажуDataGridView
            // 
            this.типи_вантажуDataGridView.AutoGenerateColumns = false;
            this.типи_вантажуDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.типи_вантажуDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.типи_вантажуDataGridView.DataSource = this.типи_вантажуBindingSource;
            this.типи_вантажуDataGridView.Location = new System.Drawing.Point(6, 3);
            this.типи_вантажуDataGridView.Name = "типи_вантажуDataGridView";
            this.типи_вантажуDataGridView.RowHeadersWidth = 51;
            this.типи_вантажуDataGridView.RowTemplate.Height = 24;
            this.типи_вантажуDataGridView.Size = new System.Drawing.Size(513, 357);
            this.типи_вантажуDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Код типу";
            this.dataGridViewTextBoxColumn1.HeaderText = "Код типу";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Назва";
            this.dataGridViewTextBoxColumn2.HeaderText = "Назва";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Температура збереження";
            this.dataGridViewTextBoxColumn3.HeaderText = "Температура збереження";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(код_типу_вантажуLabel);
            this.tabPage1.Controls.Add(this.код_типу_вантажуTextBox);
            this.tabPage1.Controls.Add(this.код_вантажуTextBox);
            this.tabPage1.Controls.Add(this.кількість_вантажу_в_тоннахTextBox);
            this.tabPage1.Controls.Add(this.країнаTextBox);
            this.tabPage1.Controls.Add(this.термін_придатності__в_місяцях_TextBox);
            this.tabPage1.Controls.Add(this.назваTextBox);
            this.tabPage1.Controls.Add(код_вантажуLabel);
            this.tabPage1.Controls.Add(код_суднаLabel);
            this.tabPage1.Controls.Add(this.comboBox2);
            this.tabPage1.Controls.Add(this.bindingNavigator2);
            this.tabPage1.Controls.Add(кількість_вантажу_в_тоннахLabel);
            this.tabPage1.Controls.Add(дата_виготовленняLabel);
            this.tabPage1.Controls.Add(this.дата_виготовленняDateTimePicker);
            this.tabPage1.Controls.Add(країнаLabel);
            this.tabPage1.Controls.Add(термін_придатності__в_місяцях_Label);
            this.tabPage1.Controls.Add(назваLabel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1056, 366);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Вантаж";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // код_типу_вантажуTextBox
            // 
            this.код_типу_вантажуTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.вантажBindingSource1, "Код типу вантажу", true));
            this.код_типу_вантажуTextBox.Location = new System.Drawing.Point(141, 86);
            this.код_типу_вантажуTextBox.Name = "код_типу_вантажуTextBox";
            this.код_типу_вантажуTextBox.Size = new System.Drawing.Size(100, 22);
            this.код_типу_вантажуTextBox.TabIndex = 20;
            // 
            // код_вантажуTextBox
            // 
            this.код_вантажуTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.вантажBindingSource1, "Код вантажу", true));
            this.код_вантажуTextBox.Location = new System.Drawing.Point(115, 33);
            this.код_вантажуTextBox.Name = "код_вантажуTextBox";
            this.код_вантажуTextBox.Size = new System.Drawing.Size(100, 22);
            this.код_вантажуTextBox.TabIndex = 19;
            // 
            // кількість_вантажу_в_тоннахTextBox
            // 
            this.кількість_вантажу_в_тоннахTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.вантажBindingSource1, "Кількість вантажу в тоннах", true));
            this.кількість_вантажу_в_тоннахTextBox.Location = new System.Drawing.Point(511, 44);
            this.кількість_вантажу_в_тоннахTextBox.Name = "кількість_вантажу_в_тоннахTextBox";
            this.кількість_вантажу_в_тоннахTextBox.Size = new System.Drawing.Size(100, 22);
            this.кількість_вантажу_в_тоннахTextBox.TabIndex = 15;
            // 
            // країнаTextBox
            // 
            this.країнаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.вантажBindingSource1, "Країна", true));
            this.країнаTextBox.Location = new System.Drawing.Point(452, 172);
            this.країнаTextBox.Name = "країнаTextBox";
            this.країнаTextBox.Size = new System.Drawing.Size(100, 22);
            this.країнаTextBox.TabIndex = 9;
            // 
            // термін_придатності__в_місяцях_TextBox
            // 
            this.термін_придатності__в_місяцях_TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.вантажBindingSource1, "Термін придатності (в місяцях)", true));
            this.термін_придатності__в_місяцях_TextBox.Location = new System.Drawing.Point(599, 135);
            this.термін_придатності__в_місяцях_TextBox.Name = "термін_придатності__в_місяцях_TextBox";
            this.термін_придатності__в_місяцях_TextBox.Size = new System.Drawing.Size(100, 22);
            this.термін_придатності__в_місяцях_TextBox.TabIndex = 7;
            // 
            // назваTextBox
            // 
            this.назваTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.вантажBindingSource1, "Назва", true));
            this.назваTextBox.Location = new System.Drawing.Point(462, 89);
            this.назваTextBox.Name = "назваTextBox";
            this.назваTextBox.Size = new System.Drawing.Size(338, 22);
            this.назваTextBox.TabIndex = 5;
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.вантажBindingSource1, "Код судна", true));
            this.comboBox2.DataSource = this.суднаBindingSource;
            this.comboBox2.DisplayMember = "Назва";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(91, 148);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(281, 24);
            this.comboBox2.TabIndex = 17;
            this.comboBox2.ValueMember = "Код";
            // 
            // bindingNavigator2
            // 
            this.bindingNavigator2.AddNewItem = this.bindingNavigatorAddNewItem1;
            this.bindingNavigator2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bindingNavigator2.BindingSource = this.вантажBindingSource1;
            this.bindingNavigator2.CountItem = this.bindingNavigatorCountItem1;
            this.bindingNavigator2.DeleteItem = this.bindingNavigatorDeleteItem1;
            this.bindingNavigator2.Dock = System.Windows.Forms.DockStyle.None;
            this.bindingNavigator2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bindingNavigator2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem1,
            this.bindingNavigatorMovePreviousItem1,
            this.bindingNavigatorSeparator3,
            this.bindingNavigatorPositionItem1,
            this.bindingNavigatorCountItem1,
            this.bindingNavigatorSeparator4,
            this.bindingNavigatorMoveNextItem1,
            this.bindingNavigatorMoveLastItem1,
            this.bindingNavigatorSeparator5,
            this.bindingNavigatorAddNewItem1,
            this.bindingNavigatorDeleteItem1});
            this.bindingNavigator2.Location = new System.Drawing.Point(144, 294);
            this.bindingNavigator2.MoveFirstItem = this.bindingNavigatorMoveFirstItem1;
            this.bindingNavigator2.MoveLastItem = this.bindingNavigatorMoveLastItem1;
            this.bindingNavigator2.MoveNextItem = this.bindingNavigatorMoveNextItem1;
            this.bindingNavigator2.MovePreviousItem = this.bindingNavigatorMovePreviousItem1;
            this.bindingNavigator2.Name = "bindingNavigator2";
            this.bindingNavigator2.PositionItem = this.bindingNavigatorPositionItem1;
            this.bindingNavigator2.Size = new System.Drawing.Size(312, 27);
            this.bindingNavigator2.TabIndex = 16;
            this.bindingNavigator2.Text = "bindingNavigator2";
            // 
            // bindingNavigatorAddNewItem1
            // 
            this.bindingNavigatorAddNewItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem1.Image")));
            this.bindingNavigatorAddNewItem1.Name = "bindingNavigatorAddNewItem1";
            this.bindingNavigatorAddNewItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem1.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem1.Text = "Добавить";
            // 
            // bindingNavigatorCountItem1
            // 
            this.bindingNavigatorCountItem1.Name = "bindingNavigatorCountItem1";
            this.bindingNavigatorCountItem1.Size = new System.Drawing.Size(55, 24);
            this.bindingNavigatorCountItem1.Text = "для {0}";
            this.bindingNavigatorCountItem1.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem1
            // 
            this.bindingNavigatorDeleteItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem1.Image")));
            this.bindingNavigatorDeleteItem1.Name = "bindingNavigatorDeleteItem1";
            this.bindingNavigatorDeleteItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem1.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem1.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem1
            // 
            this.bindingNavigatorMoveFirstItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem1.Image")));
            this.bindingNavigatorMoveFirstItem1.Name = "bindingNavigatorMoveFirstItem1";
            this.bindingNavigatorMoveFirstItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem1.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem1.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem1
            // 
            this.bindingNavigatorMovePreviousItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem1.Image")));
            this.bindingNavigatorMovePreviousItem1.Name = "bindingNavigatorMovePreviousItem1";
            this.bindingNavigatorMovePreviousItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem1.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem1.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator3
            // 
            this.bindingNavigatorSeparator3.Name = "bindingNavigatorSeparator3";
            this.bindingNavigatorSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem1
            // 
            this.bindingNavigatorPositionItem1.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem1.AutoSize = false;
            this.bindingNavigatorPositionItem1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem1.Name = "bindingNavigatorPositionItem1";
            this.bindingNavigatorPositionItem1.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem1.Text = "0";
            this.bindingNavigatorPositionItem1.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator4
            // 
            this.bindingNavigatorSeparator4.Name = "bindingNavigatorSeparator4";
            this.bindingNavigatorSeparator4.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem1
            // 
            this.bindingNavigatorMoveNextItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem1.Image")));
            this.bindingNavigatorMoveNextItem1.Name = "bindingNavigatorMoveNextItem1";
            this.bindingNavigatorMoveNextItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem1.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem1.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem1
            // 
            this.bindingNavigatorMoveLastItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem1.Image")));
            this.bindingNavigatorMoveLastItem1.Name = "bindingNavigatorMoveLastItem1";
            this.bindingNavigatorMoveLastItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem1.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem1.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator5
            // 
            this.bindingNavigatorSeparator5.Name = "bindingNavigatorSeparator5";
            this.bindingNavigatorSeparator5.Size = new System.Drawing.Size(6, 27);
            // 
            // дата_виготовленняDateTimePicker
            // 
            this.дата_виготовленняDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.вантажBindingSource1, "Дата виготовлення", true));
            this.дата_виготовленняDateTimePicker.Location = new System.Drawing.Point(806, 39);
            this.дата_виготовленняDateTimePicker.Name = "дата_виготовленняDateTimePicker";
            this.дата_виготовленняDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.дата_виготовленняDateTimePicker.TabIndex = 11;
            // 
            // tabControl1
            // 
            this.tabControl1.AccessibleDescription = "";
            this.tabControl1.AccessibleName = "";
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Controls.Add(this.tabPage7);
            this.tabControl1.Location = new System.Drawing.Point(12, 43);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1064, 395);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.button12);
            this.tabPage7.Controls.Add(this.button7);
            this.tabPage7.Controls.Add(this.вантажDataGridView);
            this.tabPage7.Location = new System.Drawing.Point(4, 25);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(1056, 366);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "Вантаж 2";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button12.Location = new System.Drawing.Point(542, 233);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(441, 40);
            this.button12.TabIndex = 2;
            this.button12.Text = "Видалити поле Країна з таблиці Вантаж";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button7.Location = new System.Drawing.Point(21, 233);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(441, 40);
            this.button7.TabIndex = 1;
            this.button7.Text = ". Отримати кількість вантажів кожного типу";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // вантажDataGridView
            // 
            this.вантажDataGridView.AutoGenerateColumns = false;
            this.вантажDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.вантажDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn27,
            this.dataGridViewTextBoxColumn28,
            this.dataGridViewTextBoxColumn29});
            this.вантажDataGridView.DataSource = this.вантажBindingSource1;
            this.вантажDataGridView.Location = new System.Drawing.Point(6, 6);
            this.вантажDataGridView.Name = "вантажDataGridView";
            this.вантажDataGridView.RowHeadersWidth = 51;
            this.вантажDataGridView.RowTemplate.Height = 24;
            this.вантажDataGridView.Size = new System.Drawing.Size(895, 208);
            this.вантажDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Код вантажу";
            this.dataGridViewTextBoxColumn4.HeaderText = "Код вантажу";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Код типу вантажу";
            this.dataGridViewTextBoxColumn5.HeaderText = "Код типу вантажу";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Назва";
            this.dataGridViewTextBoxColumn6.HeaderText = "Назва";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Термін придатності (в місяцях)";
            this.dataGridViewTextBoxColumn7.HeaderText = "Термін придатності (в місяцях)";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Країна";
            this.dataGridViewTextBoxColumn8.HeaderText = "Країна";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // dataGridViewTextBoxColumn27
            // 
            this.dataGridViewTextBoxColumn27.DataPropertyName = "Дата виготовлення";
            this.dataGridViewTextBoxColumn27.HeaderText = "Дата виготовлення";
            this.dataGridViewTextBoxColumn27.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn27.Name = "dataGridViewTextBoxColumn27";
            this.dataGridViewTextBoxColumn27.Width = 125;
            // 
            // dataGridViewTextBoxColumn28
            // 
            this.dataGridViewTextBoxColumn28.DataPropertyName = "Код судна";
            this.dataGridViewTextBoxColumn28.HeaderText = "Код судна";
            this.dataGridViewTextBoxColumn28.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn28.Name = "dataGridViewTextBoxColumn28";
            this.dataGridViewTextBoxColumn28.Width = 125;
            // 
            // dataGridViewTextBoxColumn29
            // 
            this.dataGridViewTextBoxColumn29.DataPropertyName = "Кількість вантажу в тоннах";
            this.dataGridViewTextBoxColumn29.HeaderText = "Кількість вантажу в тоннах";
            this.dataGridViewTextBoxColumn29.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn29.Name = "dataGridViewTextBoxColumn29";
            this.dataGridViewTextBoxColumn29.Width = 125;
            // 
            // бД_Портові_терміналиDataSet
            // 
            this.бД_Портові_терміналиDataSet.DataSetName = "БД_Портові_терміналиDataSet";
            this.бД_Портові_терміналиDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // бДПортовітерміналиDataSetBindingSource
            // 
            this.бДПортовітерміналиDataSetBindingSource.DataSource = this.бД_Портові_терміналиDataSet;
            this.бДПортовітерміналиDataSetBindingSource.Position = 0;
            // 
            // терміналиBindingSource4
            // 
            this.терміналиBindingSource4.DataMember = "Термінали";
            this.терміналиBindingSource4.DataSource = this.бД_Портові_терміналиDataSet;
            // 
            // терміналиTableAdapter1
            // 
            this.терміналиTableAdapter1.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1295, 505);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.tabControl1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "База Даних Портові термінали";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.бД_Портові_термінали2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.бДПортовітермінали2DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.вантажBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.вантажBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.суднаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.типи_вантажуBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.суднаBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.терміналиBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.перевантаженняBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.терміналиBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.терміналиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.типиВантажуBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.терміналиBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.вантажBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.суднаBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.перевантаженняBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.перевантаженняBindingSource2)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.терміналиDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.терміналиBindingSource5)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.перевантаженняDataGridView)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.суднаDataGridView)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.типи_вантажуDataGridView)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator2)).EndInit();
            this.bindingNavigator2.ResumeLayout(false);
            this.bindingNavigator2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.вантажDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.бД_Портові_терміналиDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.бДПортовітерміналиDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.терміналиBindingSource4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private БД_Портові_термінали2DataSet бД_Портові_термінали2DataSet;
        private System.Windows.Forms.BindingSource бДПортовітермінали2DataSetBindingSource;
        private System.Windows.Forms.BindingSource вантажBindingSource;
        private БД_Портові_термінали2DataSetTableAdapters.ВантажTableAdapter вантажTableAdapter;
        private System.Windows.Forms.BindingSource вантажBindingSource1;
        private БД_Портові_термінали2DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private БД_Портові_термінали2DataSetTableAdapters.Типи_вантажуTableAdapter типи_вантажуTableAdapter;
        private System.Windows.Forms.BindingSource типи_вантажуBindingSource;
        private БД_Портові_термінали2DataSetTableAdapters.ПеревантаженняTableAdapter перевантаженняTableAdapter;
        private System.Windows.Forms.BindingSource перевантаженняBindingSource;
        private БД_Портові_термінали2DataSetTableAdapters.СуднаTableAdapter суднаTableAdapter;
        private System.Windows.Forms.BindingSource суднаBindingSource;
        private БД_Портові_термінали2DataSetTableAdapters.ТерміналиTableAdapter терміналиTableAdapter;
        private System.Windows.Forms.BindingSource терміналиBindingSource;
        private System.Windows.Forms.BindingSource суднаBindingSource1;
        private System.Windows.Forms.BindingSource терміналиBindingSource2;
        private System.Windows.Forms.BindingSource терміналиBindingSource1;
        private System.Windows.Forms.BindingSource типиВантажуBindingSource;
        private System.Windows.Forms.BindingSource терміналиBindingSource3;
        private System.Windows.Forms.BindingSource вантажBindingSource2;
        private System.Windows.Forms.BindingSource перевантаженняBindingSource2;
        private System.Windows.Forms.BindingSource суднаBindingSource2;
        private System.Windows.Forms.BindingSource перевантаженняBindingSource1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem отриматиИнформаціюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отриматиВсюІнформаціюПроСуднаЩоПеревантажувалисьНаТерміналіToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отриматиХарактеристикиТерміналуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отриматиПерелікСуденТоннажемБільше30ТоннToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отриматиПерелікШвидкопсувнихВантажівВідсортуватиЗаНазвоюУАлфавітномуПорядкуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отриматиПерелікВітчизнянихВантажівВідсортуватиЗаТипоммаєБутиВказаноНазвуТипуВантажуToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn назваDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кількістьПрацівниківDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кількістьПричальногоОбладнанняDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn країнаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn містоDataGridViewTextBoxColumn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.DataGridView терміналиDataGridView;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView перевантаженняDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView суднаDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView типи_вантажуDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox код_типу_вантажуTextBox;
        private System.Windows.Forms.TextBox код_вантажуTextBox;
        private System.Windows.Forms.TextBox кількість_вантажу_в_тоннахTextBox;
        private System.Windows.Forms.TextBox країнаTextBox;
        private System.Windows.Forms.TextBox термін_придатності__в_місяцях_TextBox;
        private System.Windows.Forms.TextBox назваTextBox;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.BindingNavigator bindingNavigator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem1;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator3;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator4;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator5;
        private System.Windows.Forms.DateTimePicker дата_виготовленняDateTimePicker;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.ToolStripMenuItem отриматиПерелікСуденЧасПростоюЯкихБільше2ДібАЧасПеревантаженняБільше5ДібToolStripMenuItem;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.DataGridView вантажDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn27;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn28;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn29;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.BindingSource бДПортовітерміналиDataSetBindingSource;
        private БД_Портові_терміналиDataSet бД_Портові_терміналиDataSet;
        private System.Windows.Forms.BindingSource терміналиBindingSource4;
        private БД_Портові_терміналиDataSetTableAdapters.ТерміналиTableAdapter терміналиTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn назваDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn кількістьПрацівниківDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn кількістьПричальногоОбладнанняDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn країнаDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn містоDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource терміналиBindingSource5;
    }
}

