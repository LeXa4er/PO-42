namespace WatchStore
{
    partial class Admin
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.adminBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.watchStoreDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.watchStoreDataSet1 = new WatchStore.WatchStoreDataSet1();
            this.watchStoreDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.watchStoreDataSet = new WatchStore.WatchStoreDataSet();
            this.adminBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.adminTableAdapter = new WatchStore.WatchStoreDataSetTableAdapters.AdminTableAdapter();
            this.adminTableAdapter1 = new WatchStore.WatchStoreDataSet1TableAdapters.AdminTableAdapter();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.savebt = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.btdelete = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.passwordtb = new System.Windows.Forms.TextBox();
            this.logintb = new System.Windows.Forms.TextBox();
            this.staffTb = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.iDadminDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.watchStoreDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.watchStoreDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.watchStoreDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.watchStoreDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminBindingSource)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.83333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.16667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1333, 738);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDadminDataGridViewTextBoxColumn,
            this.loginDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.adminBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(1327, 354);
            this.dataGridView2.TabIndex = 17;
            // 
            // adminBindingSource1
            // 
            this.adminBindingSource1.DataMember = "Admin";
            this.adminBindingSource1.DataSource = this.watchStoreDataSet1BindingSource;
            // 
            // watchStoreDataSet1BindingSource
            // 
            this.watchStoreDataSet1BindingSource.DataSource = this.watchStoreDataSet1;
            this.watchStoreDataSet1BindingSource.Position = 0;
            // 
            // watchStoreDataSet1
            // 
            this.watchStoreDataSet1.DataSetName = "WatchStoreDataSet1";
            this.watchStoreDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // watchStoreDataSetBindingSource
            // 
            this.watchStoreDataSetBindingSource.DataSource = this.watchStoreDataSet;
            this.watchStoreDataSetBindingSource.Position = 0;
            // 
            // watchStoreDataSet
            // 
            this.watchStoreDataSet.DataSetName = "WatchStoreDataSet";
            this.watchStoreDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // adminBindingSource
            // 
            this.adminBindingSource.DataMember = "Admin";
            this.adminBindingSource.DataSource = this.watchStoreDataSetBindingSource;
            // 
            // adminTableAdapter
            // 
            this.adminTableAdapter.ClearBeforeFill = true;
            // 
            // adminTableAdapter1
            // 
            this.adminTableAdapter1.ClearBeforeFill = true;
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
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.staffTb, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.logintb, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.passwordtb, 1, 1);
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
            // passwordtb
            // 
            this.passwordtb.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.passwordtb.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordtb.Location = new System.Drawing.Point(242, 254);
            this.passwordtb.Margin = new System.Windows.Forms.Padding(4);
            this.passwordtb.Name = "passwordtb";
            this.passwordtb.Size = new System.Drawing.Size(283, 35);
            this.passwordtb.TabIndex = 22;
            // 
            // logintb
            // 
            this.logintb.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.logintb.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logintb.Location = new System.Drawing.Point(242, 73);
            this.logintb.Margin = new System.Windows.Forms.Padding(4);
            this.logintb.Name = "logintb";
            this.logintb.Size = new System.Drawing.Size(285, 35);
            this.logintb.TabIndex = 21;
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
            this.staffTb.Text = "Пароль";
            this.staffTb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.label1.Text = "Логин";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // iDadminDataGridViewTextBoxColumn
            // 
            this.iDadminDataGridViewTextBoxColumn.DataPropertyName = "ID_admin";
            this.iDadminDataGridViewTextBoxColumn.HeaderText = "ID_admin";
            this.iDadminDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDadminDataGridViewTextBoxColumn.Name = "iDadminDataGridViewTextBoxColumn";
            this.iDadminDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDadminDataGridViewTextBoxColumn.Width = 125;
            // 
            // loginDataGridViewTextBoxColumn
            // 
            this.loginDataGridViewTextBoxColumn.DataPropertyName = "Login";
            this.loginDataGridViewTextBoxColumn.HeaderText = "Login";
            this.loginDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.loginDataGridViewTextBoxColumn.Name = "loginDataGridViewTextBoxColumn";
            this.loginDataGridViewTextBoxColumn.Width = 125;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.Width = 125;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Admin";
            this.Size = new System.Drawing.Size(1333, 738);
            this.Load += new System.EventHandler(this.Admin_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.watchStoreDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.watchStoreDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.watchStoreDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.watchStoreDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminBindingSource)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.BindingSource watchStoreDataSetBindingSource;
        private WatchStoreDataSet watchStoreDataSet;
        private System.Windows.Forms.BindingSource adminBindingSource;
        private WatchStoreDataSetTableAdapters.AdminTableAdapter adminTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource adminBindingSource1;
        private System.Windows.Forms.BindingSource watchStoreDataSet1BindingSource;
        private WatchStoreDataSet1 watchStoreDataSet1;
        private WatchStoreDataSet1TableAdapters.AdminTableAdapter adminTableAdapter1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label staffTb;
        private System.Windows.Forms.TextBox logintb;
        private System.Windows.Forms.TextBox passwordtb;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button btdelete;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button savebt;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDadminDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
    }
}
