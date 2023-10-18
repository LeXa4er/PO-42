namespace _3Days
{
    partial class CoachesPage
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
            this.PagePanel = new System.Windows.Forms.TableLayoutPanel();
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.CoachesPanel = new System.Windows.Forms.TableLayoutPanel();
            this.TeamLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.BiographyBox = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.TeamsPanel = new System.Windows.Forms.TableLayoutPanel();
            this.CoachPhotoBox = new System.Windows.Forms.PictureBox();
            this.PagePanel.SuspendLayout();
            this.LeftPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CoachPhotoBox)).BeginInit();
            this.SuspendLayout();
            // 
            // PagePanel
            // 
            this.PagePanel.ColumnCount = 2;
            this.PagePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 235F));
            this.PagePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PagePanel.Controls.Add(this.LeftPanel, 0, 0);
            this.PagePanel.Controls.Add(this.tableLayoutPanel1, 1, 0);
            this.PagePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PagePanel.Location = new System.Drawing.Point(0, 0);
            this.PagePanel.Margin = new System.Windows.Forms.Padding(0);
            this.PagePanel.Name = "PagePanel";
            this.PagePanel.RowCount = 1;
            this.PagePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PagePanel.Size = new System.Drawing.Size(795, 425);
            this.PagePanel.TabIndex = 0;
            // 
            // LeftPanel
            // 
            this.LeftPanel.Controls.Add(this.CoachesPanel);
            this.LeftPanel.Controls.Add(this.TeamLabel);
            this.LeftPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LeftPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftPanel.Margin = new System.Windows.Forms.Padding(0);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(235, 425);
            this.LeftPanel.TabIndex = 0;
            // 
            // CoachesPanel
            // 
            this.CoachesPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.CoachesPanel.AutoScroll = true;
            this.CoachesPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.CoachesPanel.ColumnCount = 1;
            this.CoachesPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.CoachesPanel.Location = new System.Drawing.Point(3, 26);
            this.CoachesPanel.Name = "CoachesPanel";
            this.CoachesPanel.Size = new System.Drawing.Size(230, 392);
            this.CoachesPanel.TabIndex = 4;
            // 
            // TeamLabel
            // 
            this.TeamLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TeamLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TeamLabel.Location = new System.Drawing.Point(0, 0);
            this.TeamLabel.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.TeamLabel.Name = "TeamLabel";
            this.TeamLabel.Size = new System.Drawing.Size(235, 20);
            this.TeamLabel.TabIndex = 3;
            this.TeamLabel.Text = "Все тренеры";
            this.TeamLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(238, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.44869F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.55131F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(554, 419);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.BiographyBox);
            this.panel2.Location = new System.Drawing.Point(3, 206);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(548, 210);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(0, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(598, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Краткая биография";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // BiographyBox
            // 
            this.BiographyBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BiographyBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BiographyBox.Location = new System.Drawing.Point(0, 33);
            this.BiographyBox.Name = "BiographyBox";
            this.BiographyBox.Size = new System.Drawing.Size(545, 184);
            this.BiographyBox.TabIndex = 5;
            this.BiographyBox.Text = "";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.TeamsPanel);
            this.panel1.Controls.Add(this.CoachPhotoBox);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(548, 197);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(201, 3);
            this.label2.Margin = new System.Windows.Forms.Padding(3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(350, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "Список команд:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TeamsPanel
            // 
            this.TeamsPanel.ColumnCount = 1;
            this.TeamsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TeamsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TeamsPanel.Location = new System.Drawing.Point(201, 32);
            this.TeamsPanel.Name = "TeamsPanel";
            this.TeamsPanel.Size = new System.Drawing.Size(347, 165);
            this.TeamsPanel.TabIndex = 7;
            // 
            // CoachPhotoBox
            // 
            this.CoachPhotoBox.Location = new System.Drawing.Point(0, 3);
            this.CoachPhotoBox.Name = "CoachPhotoBox";
            this.CoachPhotoBox.Size = new System.Drawing.Size(195, 195);
            this.CoachPhotoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CoachPhotoBox.TabIndex = 6;
            this.CoachPhotoBox.TabStop = false;
            this.CoachPhotoBox.Click += new System.EventHandler(this.CoachPhotoBox_Click);
            // 
            // CoachesPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PagePanel);
            this.Name = "CoachesPage";
            this.Size = new System.Drawing.Size(795, 425);
            this.PagePanel.ResumeLayout(false);
            this.LeftPanel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CoachPhotoBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel PagePanel;
        private System.Windows.Forms.Panel LeftPanel;
        private System.Windows.Forms.Label TeamLabel;
        private System.Windows.Forms.TableLayoutPanel CoachesPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox BiographyBox;
        private System.Windows.Forms.PictureBox CoachPhotoBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel TeamsPanel;
        private System.Windows.Forms.Label label2;
    }
}
