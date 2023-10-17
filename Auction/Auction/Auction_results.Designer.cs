
namespace Auction
{
    partial class Auction_results
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Auction_results));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.назадToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.авторизацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBoxLots = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.numericUpDownPrice = new System.Windows.Forms.NumericUpDown();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.panelSelectBuy = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.panelAddBuy = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textboxFio = new System.Windows.Forms.TextBox();
            this.textboxPhone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.dataSetAuction = new Auction.DataSetAuction();
            this.selectAllAuctionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.selectAllAuctionTableAdapter = new Auction.DataSetAuctionTableAdapters.SelectAllAuctionTableAdapter();
            this.idAuctionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameProductDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.originalPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sellPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateAuctionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fioBuyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneBuyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productTableAdapter = new Auction.DataSetAuctionTableAdapters.productTableAdapter();
            this.buyerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buyerTableAdapter = new Auction.DataSetAuctionTableAdapters.buyerTableAdapter();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrice)).BeginInit();
            this.panelSelectBuy.SuspendLayout();
            this.panelAddBuy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetAuction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectAllAuctionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buyerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1608, 25);
            this.menuStrip1.TabIndex = 67;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.назадToolStripMenuItem,
            this.авторизацияToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(53, 19);
            this.справкаToolStripMenuItem.Text = "Меню";
            // 
            // назадToolStripMenuItem
            // 
            this.назадToolStripMenuItem.Name = "назадToolStripMenuItem";
            this.назадToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.назадToolStripMenuItem.Text = "Назад";
            // 
            // авторизацияToolStripMenuItem
            // 
            this.авторизацияToolStripMenuItem.Name = "авторизацияToolStripMenuItem";
            this.авторизацияToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.авторизацияToolStripMenuItem.Text = "Авторизация";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idAuctionDataGridViewTextBoxColumn,
            this.nameProductDataGridViewTextBoxColumn,
            this.originalPriceDataGridViewTextBoxColumn,
            this.sellPriceDataGridViewTextBoxColumn,
            this.dateAuctionDataGridViewTextBoxColumn,
            this.fioBuyDataGridViewTextBoxColumn,
            this.phoneBuyDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.selectAllAuctionBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(62, 72);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1486, 288);
            this.dataGridView1.TabIndex = 68;
            // 
            // comboBoxLots
            // 
            this.comboBoxLots.DataSource = this.productBindingSource;
            this.comboBoxLots.DisplayMember = "NameProduct";
            this.comboBoxLots.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxLots.FormattingEnabled = true;
            this.comboBoxLots.Location = new System.Drawing.Point(62, 426);
            this.comboBoxLots.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxLots.Name = "comboBoxLots";
            this.comboBoxLots.Size = new System.Drawing.Size(571, 29);
            this.comboBoxLots.TabIndex = 75;
            this.comboBoxLots.ValueMember = "idProduct";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(52, 374);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 31);
            this.label4.TabIndex = 80;
            this.label4.Text = "Лоты:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(712, 517);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 31);
            this.label3.TabIndex = 88;
            this.label3.Text = "Покупатель:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(656, 374);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 31);
            this.label7.TabIndex = 90;
            this.label7.Text = "Цена:";
            // 
            // numericUpDownPrice
            // 
            this.numericUpDownPrice.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownPrice.Location = new System.Drawing.Point(664, 428);
            this.numericUpDownPrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numericUpDownPrice.Name = "numericUpDownPrice";
            this.numericUpDownPrice.Size = new System.Drawing.Size(483, 29);
            this.numericUpDownPrice.TabIndex = 89;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker1.Location = new System.Drawing.Point(1179, 428);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(367, 29);
            this.dateTimePicker1.TabIndex = 91;
            this.dateTimePicker1.Value = new System.DateTime(2023, 10, 16, 8, 46, 7, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(1170, 374);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 31);
            this.label5.TabIndex = 92;
            this.label5.Text = "Дата:";
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonAdd.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.Location = new System.Drawing.Point(1364, 715);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(184, 91);
            this.buttonAdd.TabIndex = 93;
            this.buttonAdd.Text = "Добавить аукцион";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // panelSelectBuy
            // 
            this.panelSelectBuy.AutoSize = true;
            this.panelSelectBuy.BackColor = System.Drawing.Color.Transparent;
            this.panelSelectBuy.Controls.Add(this.label8);
            this.panelSelectBuy.Controls.Add(this.comboBox2);
            this.panelSelectBuy.Enabled = false;
            this.panelSelectBuy.Location = new System.Drawing.Point(846, 585);
            this.panelSelectBuy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelSelectBuy.Name = "panelSelectBuy";
            this.panelSelectBuy.Size = new System.Drawing.Size(434, 122);
            this.panelSelectBuy.TabIndex = 97;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(4, 0);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 31);
            this.label8.TabIndex = 85;
            this.label8.Text = "ФИО:";
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.buyerBindingSource;
            this.comboBox2.DisplayMember = "fioBuy";
            this.comboBox2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(14, 52);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(414, 29);
            this.comboBox2.TabIndex = 74;
            this.comboBox2.ValueMember = "idBuyer";
            // 
            // panelAddBuy
            // 
            this.panelAddBuy.AutoSize = true;
            this.panelAddBuy.BackColor = System.Drawing.Color.Transparent;
            this.panelAddBuy.Controls.Add(this.label1);
            this.panelAddBuy.Controls.Add(this.textboxFio);
            this.panelAddBuy.Controls.Add(this.textboxPhone);
            this.panelAddBuy.Controls.Add(this.label2);
            this.panelAddBuy.Location = new System.Drawing.Point(82, 585);
            this.panelAddBuy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelAddBuy.Name = "panelAddBuy";
            this.panelAddBuy.Size = new System.Drawing.Size(507, 229);
            this.panelAddBuy.TabIndex = 96;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(4, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 31);
            this.label1.TabIndex = 69;
            this.label1.Text = "ФИО:";
            // 
            // textboxFio
            // 
            this.textboxFio.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textboxFio.Location = new System.Drawing.Point(14, 52);
            this.textboxFio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textboxFio.Name = "textboxFio";
            this.textboxFio.Size = new System.Drawing.Size(487, 29);
            this.textboxFio.TabIndex = 67;
            // 
            // textboxPhone
            // 
            this.textboxPhone.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textboxPhone.Location = new System.Drawing.Point(14, 180);
            this.textboxPhone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textboxPhone.Name = "textboxPhone";
            this.textboxPhone.Size = new System.Drawing.Size(487, 29);
            this.textboxPhone.TabIndex = 68;
            this.textboxPhone.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(4, 128);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 31);
            this.label2.TabIndex = 70;
            this.label2.Text = "Номер телефона:";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.BackColor = System.Drawing.Color.Transparent;
            this.radioButton2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton2.Location = new System.Drawing.Point(594, 715);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(154, 25);
            this.radioButton2.TabIndex = 95;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Существующий";
            this.radioButton2.UseVisualStyleBackColor = false;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.BackColor = System.Drawing.Color.Transparent;
            this.radioButton1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton1.Location = new System.Drawing.Point(594, 668);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(162, 25);
            this.radioButton1.TabIndex = 94;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Новый продавец";
            this.radioButton1.UseVisualStyleBackColor = false;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // dataSetAuction
            // 
            this.dataSetAuction.DataSetName = "DataSetAuction";
            this.dataSetAuction.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // selectAllAuctionBindingSource
            // 
            this.selectAllAuctionBindingSource.DataMember = "SelectAllAuction";
            this.selectAllAuctionBindingSource.DataSource = this.dataSetAuction;
            // 
            // selectAllAuctionTableAdapter
            // 
            this.selectAllAuctionTableAdapter.ClearBeforeFill = true;
            // 
            // idAuctionDataGridViewTextBoxColumn
            // 
            this.idAuctionDataGridViewTextBoxColumn.DataPropertyName = "idAuction";
            this.idAuctionDataGridViewTextBoxColumn.HeaderText = "Код аукциона";
            this.idAuctionDataGridViewTextBoxColumn.Name = "idAuctionDataGridViewTextBoxColumn";
            this.idAuctionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameProductDataGridViewTextBoxColumn
            // 
            this.nameProductDataGridViewTextBoxColumn.DataPropertyName = "NameProduct";
            this.nameProductDataGridViewTextBoxColumn.HeaderText = "Название лота";
            this.nameProductDataGridViewTextBoxColumn.Name = "nameProductDataGridViewTextBoxColumn";
            this.nameProductDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // originalPriceDataGridViewTextBoxColumn
            // 
            this.originalPriceDataGridViewTextBoxColumn.DataPropertyName = "OriginalPrice";
            this.originalPriceDataGridViewTextBoxColumn.HeaderText = "Начальная цена";
            this.originalPriceDataGridViewTextBoxColumn.Name = "originalPriceDataGridViewTextBoxColumn";
            this.originalPriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sellPriceDataGridViewTextBoxColumn
            // 
            this.sellPriceDataGridViewTextBoxColumn.DataPropertyName = "sellPrice";
            this.sellPriceDataGridViewTextBoxColumn.HeaderText = "Цена покупки";
            this.sellPriceDataGridViewTextBoxColumn.Name = "sellPriceDataGridViewTextBoxColumn";
            this.sellPriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateAuctionDataGridViewTextBoxColumn
            // 
            this.dateAuctionDataGridViewTextBoxColumn.DataPropertyName = "dateAuction";
            this.dateAuctionDataGridViewTextBoxColumn.HeaderText = "Дата аукциона";
            this.dateAuctionDataGridViewTextBoxColumn.Name = "dateAuctionDataGridViewTextBoxColumn";
            this.dateAuctionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fioBuyDataGridViewTextBoxColumn
            // 
            this.fioBuyDataGridViewTextBoxColumn.DataPropertyName = "fioBuy";
            this.fioBuyDataGridViewTextBoxColumn.HeaderText = "ФИО покупателя";
            this.fioBuyDataGridViewTextBoxColumn.Name = "fioBuyDataGridViewTextBoxColumn";
            this.fioBuyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phoneBuyDataGridViewTextBoxColumn
            // 
            this.phoneBuyDataGridViewTextBoxColumn.DataPropertyName = "phoneBuy";
            this.phoneBuyDataGridViewTextBoxColumn.HeaderText = "Телефон покупателя";
            this.phoneBuyDataGridViewTextBoxColumn.Name = "phoneBuyDataGridViewTextBoxColumn";
            this.phoneBuyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "product";
            this.productBindingSource.DataSource = this.dataSetAuction;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // buyerBindingSource
            // 
            this.buyerBindingSource.DataMember = "buyer";
            this.buyerBindingSource.DataSource = this.dataSetAuction;
            // 
            // buyerTableAdapter
            // 
            this.buyerTableAdapter.ClearBeforeFill = true;
            // 
            // Auction_results
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1608, 832);
            this.Controls.Add(this.panelSelectBuy);
            this.Controls.Add(this.panelAddBuy);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.numericUpDownPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxLots);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Auction_results";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Аукцион";
            this.Load += new System.EventHandler(this.Auction_results_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrice)).EndInit();
            this.panelSelectBuy.ResumeLayout(false);
            this.panelSelectBuy.PerformLayout();
            this.panelAddBuy.ResumeLayout(false);
            this.panelAddBuy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetAuction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectAllAuctionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buyerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem назадToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem авторизацияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBoxLots;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericUpDownPrice;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonAdd;
		private System.Windows.Forms.Panel panelSelectBuy;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.ComboBox comboBox2;
		private System.Windows.Forms.Panel panelAddBuy;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textboxFio;
		private System.Windows.Forms.TextBox textboxPhone;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.RadioButton radioButton1;
        private DataSetAuction dataSetAuction;
        private System.Windows.Forms.BindingSource selectAllAuctionBindingSource;
        private DataSetAuctionTableAdapters.SelectAllAuctionTableAdapter selectAllAuctionTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAuctionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameProductDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn originalPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sellPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateAuctionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fioBuyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneBuyDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource productBindingSource;
        private DataSetAuctionTableAdapters.productTableAdapter productTableAdapter;
        private System.Windows.Forms.BindingSource buyerBindingSource;
        private DataSetAuctionTableAdapters.buyerTableAdapter buyerTableAdapter;
    }
}