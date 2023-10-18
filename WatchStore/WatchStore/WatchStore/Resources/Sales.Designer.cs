namespace WatchStore.Resources
{
    partial class Sales
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btdelete = new System.Windows.Forms.Button();
            this.savebt = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btAdd = new System.Windows.Forms.Button();
            this.staffTb = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.clientCB = new System.Windows.Forms.ComboBox();
            this.salesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.watchStoreDataSet = new WatchStore.WatchStoreDataSet();
            this.watchCB = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDSalesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDwatchDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDclientsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datesaleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salesTableAdapter = new WatchStore.WatchStoreDataSetTableAdapters.SalesTableAdapter();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.watchStoreDataSet)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btdelete
            // 
            this.btdelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btdelete.BackColor = System.Drawing.Color.Crimson;
            this.btdelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btdelete.FlatAppearance.BorderSize = 0;
            this.btdelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btdelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btdelete.ForeColor = System.Drawing.Color.White;
            this.btdelete.Location = new System.Drawing.Point(77, 264);
            this.btdelete.Margin = new System.Windows.Forms.Padding(4);
            this.btdelete.Name = "btdelete";
            this.btdelete.Size = new System.Drawing.Size(200, 74);
            this.btdelete.TabIndex = 12;
            this.btdelete.Text = "Удалить";
            this.btdelete.UseVisualStyleBackColor = false;
            this.btdelete.Click += new System.EventHandler(this.btdelete_Click);
            // 
            // savebt
            // 
            this.savebt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.savebt.BackColor = System.Drawing.Color.Crimson;
            this.savebt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.savebt.FlatAppearance.BorderSize = 0;
            this.savebt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.savebt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.savebt.ForeColor = System.Drawing.Color.White;
            this.savebt.Location = new System.Drawing.Point(77, 143);
            this.savebt.Margin = new System.Windows.Forms.Padding(4);
            this.savebt.Name = "savebt";
            this.savebt.Size = new System.Drawing.Size(200, 74);
            this.savebt.TabIndex = 11;
            this.savebt.Text = "Сохранить";
            this.savebt.UseVisualStyleBackColor = false;
            this.savebt.Click += new System.EventHandler(this.savebt_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.btdelete, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.btAdd, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.savebt, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(966, 4);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(355, 362);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // btAdd
            // 
            this.btAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btAdd.BackColor = System.Drawing.Color.Crimson;
            this.btAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAdd.FlatAppearance.BorderSize = 0;
            this.btAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btAdd.ForeColor = System.Drawing.Color.White;
            this.btAdd.Location = new System.Drawing.Point(77, 23);
            this.btAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(200, 74);
            this.btAdd.TabIndex = 10;
            this.btAdd.Text = "Добавить";
            this.btAdd.UseVisualStyleBackColor = false;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // staffTb
            // 
            this.staffTb.AutoSize = true;
            this.staffTb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.staffTb.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.staffTb.ForeColor = System.Drawing.Color.Crimson;
            this.staffTb.Location = new System.Drawing.Point(4, 181);
            this.staffTb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.staffTb.Name = "staffTb";
            this.staffTb.Size = new System.Drawing.Size(230, 181);
            this.staffTb.TabIndex = 19;
            this.staffTb.Text = "Часы";
            this.staffTb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.staffTb, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.clientCB, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.watchCB, 1, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(954, 362);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(4, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 181);
            this.label1.TabIndex = 19;
            this.label1.Text = "Клиент";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // clientCB
            // 
            this.clientCB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.clientCB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clientCB.DataSource = this.salesBindingSource;
            this.clientCB.DisplayMember = "ID_clients";
            this.clientCB.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clientCB.FormattingEnabled = true;
            this.clientCB.IntegralHeight = false;
            this.clientCB.Location = new System.Drawing.Point(242, 72);
            this.clientCB.Margin = new System.Windows.Forms.Padding(4);
            this.clientCB.Name = "clientCB";
            this.clientCB.Size = new System.Drawing.Size(428, 36);
            this.clientCB.TabIndex = 20;
            this.clientCB.Tag = "";
            this.clientCB.ValueMember = "ID_clients";
            // 
            // salesBindingSource
            // 
            this.salesBindingSource.DataMember = "Sales";
            this.salesBindingSource.DataSource = this.watchStoreDataSet;
            // 
            // watchStoreDataSet
            // 
            this.watchStoreDataSet.DataSetName = "WatchStoreDataSet";
            this.watchStoreDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // watchCB
            // 
            this.watchCB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.watchCB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.watchCB.DataSource = this.salesBindingSource;
            this.watchCB.DisplayMember = "ID_watch";
            this.watchCB.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.watchCB.FormattingEnabled = true;
            this.watchCB.Location = new System.Drawing.Point(242, 253);
            this.watchCB.Margin = new System.Windows.Forms.Padding(4);
            this.watchCB.Name = "watchCB";
            this.watchCB.Size = new System.Drawing.Size(428, 36);
            this.watchCB.TabIndex = 20;
            this.watchCB.Tag = "";
            this.watchCB.ValueMember = "ID_watch";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.83333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.16667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1333, 738);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.63582F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.36419F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 364);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1325, 370);
            this.tableLayoutPanel2.TabIndex = 16;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDSalesDataGridViewTextBoxColumn,
            this.iDwatchDataGridViewTextBoxColumn,
            this.iDclientsDataGridViewTextBoxColumn,
            this.datesaleDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.salesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1327, 354);
            this.dataGridView1.TabIndex = 17;
            // 
            // iDSalesDataGridViewTextBoxColumn
            // 
            this.iDSalesDataGridViewTextBoxColumn.DataPropertyName = "ID_Sales";
            this.iDSalesDataGridViewTextBoxColumn.HeaderText = "ID_Sales";
            this.iDSalesDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDSalesDataGridViewTextBoxColumn.Name = "iDSalesDataGridViewTextBoxColumn";
            this.iDSalesDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDSalesDataGridViewTextBoxColumn.Width = 125;
            // 
            // iDwatchDataGridViewTextBoxColumn
            // 
            this.iDwatchDataGridViewTextBoxColumn.DataPropertyName = "ID_watch";
            this.iDwatchDataGridViewTextBoxColumn.HeaderText = "ID_watch";
            this.iDwatchDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDwatchDataGridViewTextBoxColumn.Name = "iDwatchDataGridViewTextBoxColumn";
            this.iDwatchDataGridViewTextBoxColumn.Width = 125;
            // 
            // iDclientsDataGridViewTextBoxColumn
            // 
            this.iDclientsDataGridViewTextBoxColumn.DataPropertyName = "ID_clients";
            this.iDclientsDataGridViewTextBoxColumn.HeaderText = "ID_clients";
            this.iDclientsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDclientsDataGridViewTextBoxColumn.Name = "iDclientsDataGridViewTextBoxColumn";
            this.iDclientsDataGridViewTextBoxColumn.Width = 125;
            // 
            // datesaleDataGridViewTextBoxColumn
            // 
            this.datesaleDataGridViewTextBoxColumn.DataPropertyName = "Date_sale";
            this.datesaleDataGridViewTextBoxColumn.HeaderText = "Date_sale";
            this.datesaleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.datesaleDataGridViewTextBoxColumn.Name = "datesaleDataGridViewTextBoxColumn";
            this.datesaleDataGridViewTextBoxColumn.Width = 125;
            // 
            // salesTableAdapter
            // 
            this.salesTableAdapter.ClearBeforeFill = true;
            // 
            // Sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Sales";
            this.Size = new System.Drawing.Size(1333, 738);
            this.Load += new System.EventHandler(this.Sales_Load);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.watchStoreDataSet)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btdelete;
        private System.Windows.Forms.Button savebt;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Label staffTb;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ComboBox watchCB;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDSalesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDwatchDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDclientsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datesaleDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource salesBindingSource;
        private WatchStoreDataSet watchStoreDataSet;
        private WatchStoreDataSetTableAdapters.SalesTableAdapter salesTableAdapter;
        private System.Windows.Forms.ComboBox clientCB;
    }
}
