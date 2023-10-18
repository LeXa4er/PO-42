namespace _3Days
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AddUsersButton = new System.Windows.Forms.Button();
            this.OpenAdminPanel1 = new System.Windows.Forms.Button();
            this.OpenAdminPanel2 = new System.Windows.Forms.Button();
            this.CoachesButton = new System.Windows.Forms.Button();
            this.TeamsButton = new System.Windows.Forms.Button();
            this.CompletedMatchesButton = new System.Windows.Forms.Button();
            this.UpcomingMathesButto = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.SelectedPageCaption = new System.Windows.Forms.Label();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.MenuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuPanel
            // 
            this.MenuPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.MenuPanel.Controls.Add(this.button1);
            this.MenuPanel.Controls.Add(this.button4);
            this.MenuPanel.Controls.Add(this.label1);
            this.MenuPanel.Controls.Add(this.pictureBox1);
            this.MenuPanel.Location = new System.Drawing.Point(2, 0);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(200, 536);
            this.MenuPanel.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(35, 505);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 28);
            this.button1.TabIndex = 9;
            this.button1.Text = "Справка";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(35, 474);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(129, 28);
            this.button4.TabIndex = 3;
            this.button4.Text = "О программе";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(71, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Футболеры";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.AddUsersButton);
            this.panel1.Controls.Add(this.OpenAdminPanel1);
            this.panel1.Controls.Add(this.OpenAdminPanel2);
            this.panel1.Controls.Add(this.CoachesButton);
            this.panel1.Controls.Add(this.TeamsButton);
            this.panel1.Controls.Add(this.CompletedMatchesButton);
            this.panel1.Controls.Add(this.UpcomingMathesButto);
            this.panel1.Location = new System.Drawing.Point(2, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 410);
            this.panel1.TabIndex = 1;
            // 
            // AddUsersButton
            // 
            this.AddUsersButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddUsersButton.Location = new System.Drawing.Point(0, 343);
            this.AddUsersButton.Name = "AddUsersButton";
            this.AddUsersButton.Size = new System.Drawing.Size(200, 55);
            this.AddUsersButton.TabIndex = 9;
            this.AddUsersButton.Text = "Добавление пользователей";
            this.AddUsersButton.UseVisualStyleBackColor = true;
            this.AddUsersButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // OpenAdminPanel1
            // 
            this.OpenAdminPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OpenAdminPanel1.Location = new System.Drawing.Point(0, 282);
            this.OpenAdminPanel1.Name = "OpenAdminPanel1";
            this.OpenAdminPanel1.Size = new System.Drawing.Size(200, 55);
            this.OpenAdminPanel1.TabIndex = 8;
            this.OpenAdminPanel1.Text = "Редактирование списка матчей";
            this.OpenAdminPanel1.UseVisualStyleBackColor = true;
            this.OpenAdminPanel1.Click += new System.EventHandler(this.OnOpenAdminPanel2Click);
            // 
            // OpenAdminPanel2
            // 
            this.OpenAdminPanel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OpenAdminPanel2.Location = new System.Drawing.Point(0, 221);
            this.OpenAdminPanel2.Name = "OpenAdminPanel2";
            this.OpenAdminPanel2.Size = new System.Drawing.Size(200, 55);
            this.OpenAdminPanel2.TabIndex = 7;
            this.OpenAdminPanel2.Text = "Редактирование информации";
            this.OpenAdminPanel2.UseVisualStyleBackColor = true;
            this.OpenAdminPanel2.Click += new System.EventHandler(this.OnOpenAdminPanel1Click);
            // 
            // CoachesButton
            // 
            this.CoachesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CoachesButton.Location = new System.Drawing.Point(0, 116);
            this.CoachesButton.Name = "CoachesButton";
            this.CoachesButton.Size = new System.Drawing.Size(200, 37);
            this.CoachesButton.TabIndex = 6;
            this.CoachesButton.Text = "Тренеры";
            this.CoachesButton.UseVisualStyleBackColor = true;
            this.CoachesButton.Click += new System.EventHandler(this.OnCoachesButtonClick);
            // 
            // TeamsButton
            // 
            this.TeamsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TeamsButton.Location = new System.Drawing.Point(0, 79);
            this.TeamsButton.Name = "TeamsButton";
            this.TeamsButton.Size = new System.Drawing.Size(200, 37);
            this.TeamsButton.TabIndex = 5;
            this.TeamsButton.Text = "Команды";
            this.TeamsButton.UseVisualStyleBackColor = true;
            this.TeamsButton.Click += new System.EventHandler(this.OnTeamsButtonClick);
            // 
            // CompletedMatchesButton
            // 
            this.CompletedMatchesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CompletedMatchesButton.Location = new System.Drawing.Point(0, 42);
            this.CompletedMatchesButton.Name = "CompletedMatchesButton";
            this.CompletedMatchesButton.Size = new System.Drawing.Size(200, 37);
            this.CompletedMatchesButton.TabIndex = 4;
            this.CompletedMatchesButton.Text = "Завершенные матчи";
            this.CompletedMatchesButton.UseVisualStyleBackColor = true;
            this.CompletedMatchesButton.Click += new System.EventHandler(this.OnCompletedMatchesButtonClick);
            // 
            // UpcomingMathesButto
            // 
            this.UpcomingMathesButto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UpcomingMathesButto.Location = new System.Drawing.Point(0, 5);
            this.UpcomingMathesButto.Name = "UpcomingMathesButto";
            this.UpcomingMathesButto.Size = new System.Drawing.Size(200, 37);
            this.UpcomingMathesButto.TabIndex = 3;
            this.UpcomingMathesButto.Text = "Предстоящие матчи";
            this.UpcomingMathesButto.UseVisualStyleBackColor = true;
            this.UpcomingMathesButto.Click += new System.EventHandler(this.OnUpcomingMatchesClick);
            // 
            // ExitButton
            // 
            this.ExitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitButton.Location = new System.Drawing.Point(928, 495);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 33);
            this.ExitButton.TabIndex = 3;
            this.ExitButton.Text = "Выход";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackButton.Location = new System.Drawing.Point(842, 495);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 33);
            this.BackButton.TabIndex = 4;
            this.BackButton.Text = "Назад";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // SelectedPageCaption
            // 
            this.SelectedPageCaption.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SelectedPageCaption.AutoSize = true;
            this.SelectedPageCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SelectedPageCaption.Location = new System.Drawing.Point(457, 12);
            this.SelectedPageCaption.Name = "SelectedPageCaption";
            this.SelectedPageCaption.Size = new System.Drawing.Size(211, 25);
            this.SelectedPageCaption.TabIndex = 5;
            this.SelectedPageCaption.Text = "Название страницы";
            // 
            // MainPanel
            // 
            this.MainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.MainPanel.Location = new System.Drawing.Point(214, 55);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(791, 425);
            this.MainPanel.TabIndex = 6;
            this.MainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.MainPanel_Paint);
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UsernameLabel.Location = new System.Drawing.Point(877, 12);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.UsernameLabel.Size = new System.Drawing.Size(129, 16);
            this.UsernameLabel.TabIndex = 7;
            this.UsernameLabel.Text = "Имя пользователя";
            this.UsernameLabel.Click += new System.EventHandler(this.UsernameLabel_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 536);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.SelectedPageCaption);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.MenuPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1035, 575);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Футболеры";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.OnManeFormLoad);
            this.MenuPanel.ResumeLayout(false);
            this.MenuPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button TeamsButton;
        private System.Windows.Forms.Button CompletedMatchesButton;
        private System.Windows.Forms.Button UpcomingMathesButto;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Label SelectedPageCaption;
        public System.Windows.Forms.Button CoachesButton;
        public System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Button OpenAdminPanel1;
        private System.Windows.Forms.Button OpenAdminPanel2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button AddUsersButton;
    }
}

