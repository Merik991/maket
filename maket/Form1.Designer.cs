
namespace maket
{
    partial class Form1
    {

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
        public void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.busBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.busTable = new maket.BusTable();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.routeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.route2 = new maket.route2();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.passengersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.passengersTable1 = new maket.PassengersTable1();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.driverBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.driverTable = new maket.DriverTable();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.routDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullNameOfThePassengerDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullNameOfTheDriverDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seatDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departureBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.departureTable = new maket.DepartureTable();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.busTableAdapter = new maket.BusTableTableAdapters.BusTableAdapter();
            this.departureTableAdapter = new maket.DepartureTableTableAdapters.DepartureTableAdapter();
            this.driverTableAdapter = new maket.DriverTableTableAdapters.DriverTableAdapter();
            this.passengersTableAdapter = new maket.PassengersTable1TableAdapters.PassengersTableAdapter();
            this.routeTableAdapter = new maket.route2TableAdapters.RouteTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.aDGDataSet = new maket.ADGDataSet();
            this.autoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.autoTableAdapter = new maket.ADGDataSetTableAdapters.autoTableAdapter();
            this.markaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kuzDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colourDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aDGDataSet1 = new maket.ADGDataSet1();
            this.postBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.postTableAdapter = new maket.ADGDataSet1TableAdapters.postTableAdapter();
            this.idPostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.markaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipKuzDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colourDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aDGDataSet2 = new maket.ADGDataSet2();
            this.сотрудникBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.сотрудникTableAdapter = new maket.ADGDataSet2TableAdapters.сотрудникTableAdapter();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aDGDataSet3 = new maket.ADGDataSet3();
            this.партнёрыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.партнёрыTableAdapter = new maket.ADGDataSet3TableAdapters.партнёрыTableAdapter();
            this.idFirmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.markaDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.busBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.busTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.routeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.route2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passengersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passengersTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.driverBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.driverTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departureBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departureTable)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aDGDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aDGDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aDGDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aDGDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.партнёрыBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.markaDataGridViewTextBoxColumn,
            this.modelDataGridViewTextBoxColumn,
            this.kuzDataGridViewTextBoxColumn,
            this.kolDataGridViewTextBoxColumn,
            this.colourDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.autoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(645, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // busBindingSource
            // 
            this.busBindingSource.DataMember = "Bus";
            this.busBindingSource.DataSource = this.busTable;
            // 
            // busTable
            // 
            this.busTable.DataSetName = "BusTable";
            this.busTable.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPostDataGridViewTextBoxColumn,
            this.markaDataGridViewTextBoxColumn1,
            this.modelDataGridViewTextBoxColumn1,
            this.tipKuzDataGridViewTextBoxColumn,
            this.colourDataGridViewTextBoxColumn1,
            this.kolDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.postBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(12, 221);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(645, 150);
            this.dataGridView2.TabIndex = 1;
            // 
            // routeBindingSource
            // 
            this.routeBindingSource.DataMember = "Route";
            this.routeBindingSource.DataSource = this.route2;
            // 
            // route2
            // 
            this.route2.DataSetName = "route2";
            this.route2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.telDataGridViewTextBoxColumn,
            this.adressDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.сотрудникBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(12, 395);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(645, 150);
            this.dataGridView3.TabIndex = 2;
            // 
            // passengersBindingSource
            // 
            this.passengersBindingSource.DataMember = "Passengers";
            this.passengersBindingSource.DataSource = this.passengersTable1;
            // 
            // passengersTable1
            // 
            this.passengersTable1.DataSetName = "PassengersTable1";
            this.passengersTable1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(666, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(666, 221);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Добавить\r\n";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(666, 395);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Добавить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView4
            // 
            this.dataGridView4.AutoGenerateColumns = false;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idFirmDataGridViewTextBoxColumn,
            this.firmDataGridViewTextBoxColumn,
            this.markaDataGridViewTextBoxColumn2,
            this.countryDataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn});
            this.dataGridView4.DataSource = this.партнёрыBindingSource;
            this.dataGridView4.Location = new System.Drawing.Point(12, 569);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(645, 150);
            this.dataGridView4.TabIndex = 6;
            // 
            // driverBindingSource
            // 
            this.driverBindingSource.DataMember = "Driver";
            this.driverBindingSource.DataSource = this.driverTable;
            // 
            // driverTable
            // 
            this.driverTable.DataSetName = "DriverTable";
            this.driverTable.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView5
            // 
            this.dataGridView5.AutoGenerateColumns = false;
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.routDataGridViewTextBoxColumn1,
            this.fullNameOfThePassengerDataGridViewTextBoxColumn2,
            this.fullNameOfTheDriverDataGridViewTextBoxColumn2,
            this.seatDataGridViewTextBoxColumn1,
            this.dateDataGridViewTextBoxColumn1});
            this.dataGridView5.DataSource = this.departureBindingSource;
            this.dataGridView5.Location = new System.Drawing.Point(12, 743);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.Size = new System.Drawing.Size(645, 150);
            this.dataGridView5.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "№ bus";
            this.dataGridViewTextBoxColumn5.HeaderText = "№ bus";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // routDataGridViewTextBoxColumn1
            // 
            this.routDataGridViewTextBoxColumn1.DataPropertyName = "Rout";
            this.routDataGridViewTextBoxColumn1.HeaderText = "Rout";
            this.routDataGridViewTextBoxColumn1.Name = "routDataGridViewTextBoxColumn1";
            // 
            // fullNameOfThePassengerDataGridViewTextBoxColumn2
            // 
            this.fullNameOfThePassengerDataGridViewTextBoxColumn2.DataPropertyName = "Full name of the passenger";
            this.fullNameOfThePassengerDataGridViewTextBoxColumn2.HeaderText = "Full name of the passenger";
            this.fullNameOfThePassengerDataGridViewTextBoxColumn2.Name = "fullNameOfThePassengerDataGridViewTextBoxColumn2";
            // 
            // fullNameOfTheDriverDataGridViewTextBoxColumn2
            // 
            this.fullNameOfTheDriverDataGridViewTextBoxColumn2.DataPropertyName = "Full name of the driver";
            this.fullNameOfTheDriverDataGridViewTextBoxColumn2.HeaderText = "Full name of the driver";
            this.fullNameOfTheDriverDataGridViewTextBoxColumn2.Name = "fullNameOfTheDriverDataGridViewTextBoxColumn2";
            // 
            // seatDataGridViewTextBoxColumn1
            // 
            this.seatDataGridViewTextBoxColumn1.DataPropertyName = "№ seat";
            this.seatDataGridViewTextBoxColumn1.HeaderText = "№ seat";
            this.seatDataGridViewTextBoxColumn1.Name = "seatDataGridViewTextBoxColumn1";
            // 
            // dateDataGridViewTextBoxColumn1
            // 
            this.dateDataGridViewTextBoxColumn1.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn1.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn1.Name = "dateDataGridViewTextBoxColumn1";
            // 
            // departureBindingSource
            // 
            this.departureBindingSource.DataMember = "Departure";
            this.departureBindingSource.DataSource = this.departureTable;
            // 
            // departureTable
            // 
            this.departureTable.DataSetName = "DepartureTable";
            this.departureTable.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(666, 569);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 8;
            this.button4.Text = "Добавить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "auto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "сотрудник";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 379);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "поставка";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 553);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "партнёры";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 727);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Отправление";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(3, 3);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(78, 17);
            this.radioButton1.TabIndex = 16;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Старше 18";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(3, 26);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(81, 17);
            this.radioButton2.TabIndex = 17;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Младше 18";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(670, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Поиск";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(670, 247);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Фильтрация";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.ForeColor = System.Drawing.Color.Black;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Все",
            "Peugeot",
            "Mercedes-Benz",
            "Volkswagen",
            "MAN",
            "Hyundai",
            "Scania"});
            this.comboBox1.Location = new System.Drawing.Point(668, 98);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(237, 32);
            this.comboBox1.TabIndex = 20;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(670, 595);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Фильтрация";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(3, 3);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(98, 17);
            this.radioButton3.TabIndex = 23;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Стаж от 1 до 9";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(3, 26);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(122, 17);
            this.radioButton4.TabIndex = 24;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Стаж от 10 и более";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(673, 263);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(101, 17);
            this.checkBox1.TabIndex = 25;
            this.checkBox1.Text = "Расстояние ↓";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(673, 286);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(67, 17);
            this.checkBox2.TabIndex = 26;
            this.checkBox2.Text = "Цена ↓";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(666, 309);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(157, 20);
            this.textBox1.TabIndex = 31;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(666, 335);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(157, 23);
            this.button5.TabIndex = 32;
            this.button5.Text = "Найти";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(666, 695);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(157, 23);
            this.button6.TabIndex = 34;
            this.button6.Text = "Найти";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(666, 669);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(157, 20);
            this.textBox2.TabIndex = 33;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(670, 421);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 13);
            this.label9.TabIndex = 35;
            this.label9.Text = "Фильтрация";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(747, 47);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 36;
            this.button7.Text = "Удалить";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(748, 221);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 37;
            this.button8.Text = "Удалить";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(748, 395);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 38;
            this.button9.Text = "Удалить";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(748, 569);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 23);
            this.button10.TabIndex = 39;
            this.button10.Text = "Удалить";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(829, 569);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(75, 23);
            this.button11.TabIndex = 43;
            this.button11.Text = "Изменить";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(829, 395);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(75, 23);
            this.button12.TabIndex = 42;
            this.button12.Text = "Изменить";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(829, 221);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(75, 23);
            this.button13.TabIndex = 41;
            this.button13.Text = "Изменить";
            this.button13.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(828, 47);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(75, 23);
            this.button14.TabIndex = 40;
            this.button14.Text = "Изменить";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // busTableAdapter
            // 
            this.busTableAdapter.ClearBeforeFill = true;
            // 
            // departureTableAdapter
            // 
            this.departureTableAdapter.ClearBeforeFill = true;
            // 
            // driverTableAdapter
            // 
            this.driverTableAdapter.ClearBeforeFill = true;
            // 
            // passengersTableAdapter
            // 
            this.passengersTableAdapter.ClearBeforeFill = true;
            // 
            // routeTableAdapter
            // 
            this.routeTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Location = new System.Drawing.Point(673, 437);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(91, 52);
            this.panel1.TabIndex = 44;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.radioButton3);
            this.panel2.Controls.Add(this.radioButton4);
            this.panel2.Location = new System.Drawing.Point(673, 611);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(150, 52);
            this.panel2.TabIndex = 45;
            // 
            // aDGDataSet
            // 
            this.aDGDataSet.DataSetName = "ADGDataSet";
            this.aDGDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // autoBindingSource
            // 
            this.autoBindingSource.DataMember = "auto";
            this.autoBindingSource.DataSource = this.aDGDataSet;
            // 
            // autoTableAdapter
            // 
            this.autoTableAdapter.ClearBeforeFill = true;
            // 
            // markaDataGridViewTextBoxColumn
            // 
            this.markaDataGridViewTextBoxColumn.DataPropertyName = "marka";
            this.markaDataGridViewTextBoxColumn.HeaderText = "marka";
            this.markaDataGridViewTextBoxColumn.Name = "markaDataGridViewTextBoxColumn";
            // 
            // modelDataGridViewTextBoxColumn
            // 
            this.modelDataGridViewTextBoxColumn.DataPropertyName = "model";
            this.modelDataGridViewTextBoxColumn.HeaderText = "model";
            this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            // 
            // kuzDataGridViewTextBoxColumn
            // 
            this.kuzDataGridViewTextBoxColumn.DataPropertyName = "kuz";
            this.kuzDataGridViewTextBoxColumn.HeaderText = "kuz";
            this.kuzDataGridViewTextBoxColumn.Name = "kuzDataGridViewTextBoxColumn";
            // 
            // kolDataGridViewTextBoxColumn
            // 
            this.kolDataGridViewTextBoxColumn.DataPropertyName = "kol";
            this.kolDataGridViewTextBoxColumn.HeaderText = "kol";
            this.kolDataGridViewTextBoxColumn.Name = "kolDataGridViewTextBoxColumn";
            // 
            // colourDataGridViewTextBoxColumn
            // 
            this.colourDataGridViewTextBoxColumn.DataPropertyName = "colour";
            this.colourDataGridViewTextBoxColumn.HeaderText = "colour";
            this.colourDataGridViewTextBoxColumn.Name = "colourDataGridViewTextBoxColumn";
            // 
            // aDGDataSet1
            // 
            this.aDGDataSet1.DataSetName = "ADGDataSet1";
            this.aDGDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // postBindingSource
            // 
            this.postBindingSource.DataMember = "post";
            this.postBindingSource.DataSource = this.aDGDataSet1;
            // 
            // postTableAdapter
            // 
            this.postTableAdapter.ClearBeforeFill = true;
            // 
            // idPostDataGridViewTextBoxColumn
            // 
            this.idPostDataGridViewTextBoxColumn.DataPropertyName = "id post";
            this.idPostDataGridViewTextBoxColumn.HeaderText = "id post";
            this.idPostDataGridViewTextBoxColumn.Name = "idPostDataGridViewTextBoxColumn";
            // 
            // markaDataGridViewTextBoxColumn1
            // 
            this.markaDataGridViewTextBoxColumn1.DataPropertyName = "marka";
            this.markaDataGridViewTextBoxColumn1.HeaderText = "marka";
            this.markaDataGridViewTextBoxColumn1.Name = "markaDataGridViewTextBoxColumn1";
            // 
            // modelDataGridViewTextBoxColumn1
            // 
            this.modelDataGridViewTextBoxColumn1.DataPropertyName = "model";
            this.modelDataGridViewTextBoxColumn1.HeaderText = "model";
            this.modelDataGridViewTextBoxColumn1.Name = "modelDataGridViewTextBoxColumn1";
            // 
            // tipKuzDataGridViewTextBoxColumn
            // 
            this.tipKuzDataGridViewTextBoxColumn.DataPropertyName = "tip kuz";
            this.tipKuzDataGridViewTextBoxColumn.HeaderText = "tip kuz";
            this.tipKuzDataGridViewTextBoxColumn.Name = "tipKuzDataGridViewTextBoxColumn";
            // 
            // colourDataGridViewTextBoxColumn1
            // 
            this.colourDataGridViewTextBoxColumn1.DataPropertyName = "colour";
            this.colourDataGridViewTextBoxColumn1.HeaderText = "colour";
            this.colourDataGridViewTextBoxColumn1.Name = "colourDataGridViewTextBoxColumn1";
            // 
            // kolDataGridViewTextBoxColumn1
            // 
            this.kolDataGridViewTextBoxColumn1.DataPropertyName = "kol";
            this.kolDataGridViewTextBoxColumn1.HeaderText = "kol";
            this.kolDataGridViewTextBoxColumn1.Name = "kolDataGridViewTextBoxColumn1";
            // 
            // aDGDataSet2
            // 
            this.aDGDataSet2.DataSetName = "ADGDataSet2";
            this.aDGDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // сотрудникBindingSource
            // 
            this.сотрудникBindingSource.DataMember = "сотрудник";
            this.сотрудникBindingSource.DataSource = this.aDGDataSet2;
            // 
            // сотрудникTableAdapter
            // 
            this.сотрудникTableAdapter.ClearBeforeFill = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "e-mail";
            this.emailDataGridViewTextBoxColumn.HeaderText = "e-mail";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // telDataGridViewTextBoxColumn
            // 
            this.telDataGridViewTextBoxColumn.DataPropertyName = "tel";
            this.telDataGridViewTextBoxColumn.HeaderText = "tel";
            this.telDataGridViewTextBoxColumn.Name = "telDataGridViewTextBoxColumn";
            // 
            // adressDataGridViewTextBoxColumn
            // 
            this.adressDataGridViewTextBoxColumn.DataPropertyName = "adress";
            this.adressDataGridViewTextBoxColumn.HeaderText = "adress";
            this.adressDataGridViewTextBoxColumn.Name = "adressDataGridViewTextBoxColumn";
            // 
            // aDGDataSet3
            // 
            this.aDGDataSet3.DataSetName = "ADGDataSet3";
            this.aDGDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // партнёрыBindingSource
            // 
            this.партнёрыBindingSource.DataMember = "партнёры";
            this.партнёрыBindingSource.DataSource = this.aDGDataSet3;
            // 
            // партнёрыTableAdapter
            // 
            this.партнёрыTableAdapter.ClearBeforeFill = true;
            // 
            // idFirmDataGridViewTextBoxColumn
            // 
            this.idFirmDataGridViewTextBoxColumn.DataPropertyName = "id firm";
            this.idFirmDataGridViewTextBoxColumn.HeaderText = "id firm";
            this.idFirmDataGridViewTextBoxColumn.Name = "idFirmDataGridViewTextBoxColumn";
            // 
            // firmDataGridViewTextBoxColumn
            // 
            this.firmDataGridViewTextBoxColumn.DataPropertyName = "firm";
            this.firmDataGridViewTextBoxColumn.HeaderText = "firm";
            this.firmDataGridViewTextBoxColumn.Name = "firmDataGridViewTextBoxColumn";
            // 
            // markaDataGridViewTextBoxColumn2
            // 
            this.markaDataGridViewTextBoxColumn2.DataPropertyName = "marka";
            this.markaDataGridViewTextBoxColumn2.HeaderText = "marka";
            this.markaDataGridViewTextBoxColumn2.Name = "markaDataGridViewTextBoxColumn2";
            // 
            // countryDataGridViewTextBoxColumn
            // 
            this.countryDataGridViewTextBoxColumn.DataPropertyName = "country";
            this.countryDataGridViewTextBoxColumn.HeaderText = "country";
            this.countryDataGridViewTextBoxColumn.Name = "countryDataGridViewTextBoxColumn";
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "city";
            this.cityDataGridViewTextBoxColumn.HeaderText = "city";
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 909);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.dataGridView5);
            this.Controls.Add(this.dataGridView4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "-+";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.busBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.busTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.routeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.route2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passengersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passengersTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.driverBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.driverTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departureBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departureTable)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aDGDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aDGDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aDGDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aDGDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.партнёрыBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.DataGridView dataGridView2;
        public System.Windows.Forms.DataGridView dataGridView3;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.Button button3;
        public System.Windows.Forms.DataGridView dataGridView4;
        public System.Windows.Forms.DataGridView dataGridView5;
        public System.Windows.Forms.Button button4;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.RadioButton radioButton1;
        public System.Windows.Forms.RadioButton radioButton2;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.ComboBox comboBox1;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.RadioButton radioButton3;
        public System.Windows.Forms.RadioButton radioButton4;
        public System.Windows.Forms.CheckBox checkBox1;
        public System.Windows.Forms.CheckBox checkBox2;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.Button button5;
        public System.Windows.Forms.Button button6;
        public System.Windows.Forms.TextBox textBox2;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.Button button7;
        public System.Windows.Forms.Button button8;
        public System.Windows.Forms.Button button9;
        public System.Windows.Forms.Button button10;
        public System.Windows.Forms.DataGridViewTextBoxColumn busDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridViewTextBoxColumn brandDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridViewTextBoxColumn colorDataGridViewTextBoxColumn;
        private System.ComponentModel.IContainer components;
        public System.Windows.Forms.Button button11;
        public System.Windows.Forms.Button button12;
        public System.Windows.Forms.Button button13;
        public System.Windows.Forms.Button button14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn routDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameOfThePassengerDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameOfTheDriverDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn seatDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn1;
        public BusTable busTable;
        public System.Windows.Forms.BindingSource busBindingSource;
        public BusTableTableAdapters.BusTableAdapter busTableAdapter;
        public DepartureTable departureTable;
        public System.Windows.Forms.BindingSource departureBindingSource;
        public DepartureTableTableAdapters.DepartureTableAdapter departureTableAdapter;
        public DriverTable driverTable;
        public System.Windows.Forms.BindingSource driverBindingSource;
        public DriverTableTableAdapters.DriverTableAdapter driverTableAdapter;
        public PassengersTable1 passengersTable1;
        public System.Windows.Forms.BindingSource passengersBindingSource;
        public PassengersTable1TableAdapters.PassengersTableAdapter passengersTableAdapter;
        public route2 route2;
        public System.Windows.Forms.BindingSource routeBindingSource;
        public route2TableAdapters.RouteTableAdapter routeTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private ADGDataSet aDGDataSet;
        private System.Windows.Forms.BindingSource autoBindingSource;
        private ADGDataSetTableAdapters.autoTableAdapter autoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn markaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kuzDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colourDataGridViewTextBoxColumn;
        private ADGDataSet1 aDGDataSet1;
        private System.Windows.Forms.BindingSource postBindingSource;
        private ADGDataSet1TableAdapters.postTableAdapter postTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn markaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipKuzDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colourDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolDataGridViewTextBoxColumn1;
        private ADGDataSet2 aDGDataSet2;
        private System.Windows.Forms.BindingSource сотрудникBindingSource;
        private ADGDataSet2TableAdapters.сотрудникTableAdapter сотрудникTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adressDataGridViewTextBoxColumn;
        private ADGDataSet3 aDGDataSet3;
        private System.Windows.Forms.BindingSource партнёрыBindingSource;
        private ADGDataSet3TableAdapters.партнёрыTableAdapter партнёрыTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idFirmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn markaDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn countryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
    }
}

