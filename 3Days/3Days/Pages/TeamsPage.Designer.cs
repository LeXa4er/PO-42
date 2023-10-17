namespace _3Days
{
    partial class TeamsPage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TeamsPanel = new System.Windows.Forms.TableLayoutPanel();
            this.TeamLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CoachTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.MatchesGrid = new System.Windows.Forms.DataGridView();
            this.DateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeamsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ResultColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.MatchesGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // TeamsPanel
            // 
            this.TeamsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.TeamsPanel.AutoScroll = true;
            this.TeamsPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TeamsPanel.ColumnCount = 1;
            this.TeamsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TeamsPanel.Location = new System.Drawing.Point(3, 30);
            this.TeamsPanel.Name = "TeamsPanel";
            this.TeamsPanel.Size = new System.Drawing.Size(230, 392);
            this.TeamsPanel.TabIndex = 1;
            // 
            // TeamLabel
            // 
            this.TeamLabel.AutoSize = true;
            this.TeamLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TeamLabel.Location = new System.Drawing.Point(47, 4);
            this.TeamLabel.Margin = new System.Windows.Forms.Padding(3);
            this.TeamLabel.Name = "TeamLabel";
            this.TeamLabel.Size = new System.Drawing.Size(109, 20);
            this.TeamLabel.TabIndex = 2;
            this.TeamLabel.Text = "Все команды";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(288, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Тренер:";
            // 
            // CoachTextBox
            // 
            this.CoachTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CoachTextBox.Location = new System.Drawing.Point(370, 63);
            this.CoachTextBox.Name = "CoachTextBox";
            this.CoachTextBox.ReadOnly = true;
            this.CoachTextBox.Size = new System.Drawing.Size(390, 26);
            this.CoachTextBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(323, 120);
            this.label2.Margin = new System.Windows.Forms.Padding(3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Последние встречи";
            // 
            // MatchesGrid
            // 
            this.MatchesGrid.AllowUserToAddRows = false;
            this.MatchesGrid.AllowUserToDeleteRows = false;
            this.MatchesGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MatchesGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.MatchesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MatchesGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DateColumn,
            this.TeamsColumn,
            this.ResultColumn});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.MatchesGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.MatchesGrid.Location = new System.Drawing.Point(292, 146);
            this.MatchesGrid.Name = "MatchesGrid";
            this.MatchesGrid.ReadOnly = true;
            this.MatchesGrid.Size = new System.Drawing.Size(500, 276);
            this.MatchesGrid.TabIndex = 8;
            // 
            // DateColumn
            // 
            this.DateColumn.HeaderText = "Дата";
            this.DateColumn.Name = "DateColumn";
            this.DateColumn.ReadOnly = true;
            this.DateColumn.Width = 150;
            // 
            // TeamsColumn
            // 
            this.TeamsColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TeamsColumn.HeaderText = "Команды";
            this.TeamsColumn.MinimumWidth = 200;
            this.TeamsColumn.Name = "TeamsColumn";
            this.TeamsColumn.ReadOnly = true;
            this.TeamsColumn.Width = 200;
            // 
            // ResultColumn
            // 
            this.ResultColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ResultColumn.HeaderText = "Результат";
            this.ResultColumn.Name = "ResultColumn";
            this.ResultColumn.ReadOnly = true;
            // 
            // TeamsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MatchesGrid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CoachTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TeamLabel);
            this.Controls.Add(this.TeamsPanel);
            this.Name = "TeamsPage";
            this.Size = new System.Drawing.Size(795, 425);
            ((System.ComponentModel.ISupportInitialize)(this.MatchesGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TeamsPanel;
        private System.Windows.Forms.Label TeamLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CoachTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView MatchesGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeamsColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ResultColumn;
    }
}
