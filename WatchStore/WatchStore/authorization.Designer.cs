namespace WatchStore
{
    partial class authorization
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(authorization));
            this.panelheader = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btclose = new System.Windows.Forms.Button();
            this.btmin = new System.Windows.Forms.Button();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bthide = new System.Windows.Forms.Button();
            this.btshow = new System.Windows.Forms.Button();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox_login = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btInfo = new System.Windows.Forms.Button();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.registrlb = new System.Windows.Forms.Label();
            this.btlogin = new System.Windows.Forms.Button();
            this.panelheader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelheader
            // 
            this.panelheader.BackColor = System.Drawing.Color.Crimson;
            this.panelheader.Controls.Add(this.pictureBox1);
            this.panelheader.Controls.Add(this.label2);
            this.panelheader.Controls.Add(this.btclose);
            this.panelheader.Controls.Add(this.btmin);
            this.panelheader.Cursor = System.Windows.Forms.Cursors.Default;
            this.panelheader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelheader.Location = new System.Drawing.Point(0, 0);
            this.panelheader.Name = "panelheader";
            this.panelheader.Size = new System.Drawing.Size(341, 30);
            this.panelheader.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WatchStore.Properties.Resources.icons8_часы___вид_спереди_24;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(122, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "WatchStore";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btclose
            // 
            this.btclose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btclose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btclose.FlatAppearance.BorderSize = 0;
            this.btclose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btclose.Image = global::WatchStore.Properties.Resources.icons8_закрыть_окно_24;
            this.btclose.Location = new System.Drawing.Point(316, 0);
            this.btclose.Name = "btclose";
            this.btclose.Size = new System.Drawing.Size(25, 30);
            this.btclose.TabIndex = 1;
            this.btclose.UseVisualStyleBackColor = true;
            this.btclose.Click += new System.EventHandler(this.btclose_Click);
            // 
            // btmin
            // 
            this.btmin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btmin.BackColor = System.Drawing.Color.Crimson;
            this.btmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btmin.FlatAppearance.BorderSize = 0;
            this.btmin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Salmon;
            this.btmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btmin.Image = global::WatchStore.Properties.Resources.icons8_свернуть_окно_24;
            this.btmin.Location = new System.Drawing.Point(289, 0);
            this.btmin.Name = "btmin";
            this.btmin.Size = new System.Drawing.Size(25, 30);
            this.btmin.TabIndex = 3;
            this.btmin.UseVisualStyleBackColor = false;
            this.btmin.Click += new System.EventHandler(this.btmin_Click);
            // 
            // textBox_password
            // 
            this.textBox_password.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox_password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_password.Location = new System.Drawing.Point(3, 12);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(143, 20);
            this.textBox_password.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(27, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 19);
            this.label5.TabIndex = 11;
            this.label5.Text = "Пароль:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(35, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 19);
            this.label4.TabIndex = 10;
            this.label4.Text = "Логин:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.bthide);
            this.panel2.Controls.Add(this.btshow);
            this.panel2.Location = new System.Drawing.Point(152, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(37, 36);
            this.panel2.TabIndex = 11;
            // 
            // bthide
            // 
            this.bthide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bthide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bthide.FlatAppearance.BorderSize = 0;
            this.bthide.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.bthide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bthide.Image = global::WatchStore.Properties.Resources.icons8_спрятать_24;
            this.bthide.Location = new System.Drawing.Point(0, 0);
            this.bthide.Name = "bthide";
            this.bthide.Size = new System.Drawing.Size(37, 36);
            this.bthide.TabIndex = 10;
            this.bthide.UseVisualStyleBackColor = true;
            this.bthide.Click += new System.EventHandler(this.bthide_Click);
            // 
            // btshow
            // 
            this.btshow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btshow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btshow.FlatAppearance.BorderSize = 0;
            this.btshow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btshow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btshow.Image = global::WatchStore.Properties.Resources.icons8_показать_24;
            this.btshow.Location = new System.Drawing.Point(0, 0);
            this.btshow.Name = "btshow";
            this.btshow.Size = new System.Drawing.Size(37, 36);
            this.btshow.TabIndex = 11;
            this.btshow.UseVisualStyleBackColor = true;
            this.btshow.Click += new System.EventHandler(this.btshow_Click);
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.2431F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.75691F));
            this.tableLayoutPanel6.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.textBox_password, 0, 0);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(108, 53);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(196, 44);
            this.tableLayoutPanel6.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.41558F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.58442F));
            this.tableLayoutPanel4.Controls.Add(this.label5, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel6, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.textBox_login, 1, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(16, 76);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(308, 100);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // textBox_login
            // 
            this.textBox_login.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox_login.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_login.Location = new System.Drawing.Point(108, 15);
            this.textBox_login.Name = "textBox_login";
            this.textBox_login.Size = new System.Drawing.Size(146, 20);
            this.textBox_login.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(55, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Авторизация";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(335, 45);
            this.panel1.TabIndex = 8;
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button3.Cursor = System.Windows.Forms.Cursors.Default;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = global::WatchStore.Properties.Resources.icons8_пользователь_40__2_;
            this.button3.Location = new System.Drawing.Point(7, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(40, 36);
            this.button3.TabIndex = 12;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel3, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 30);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 131F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 113F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(341, 305);
            this.tableLayoutPanel2.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btInfo);
            this.panel3.Controls.Add(this.tableLayoutPanel5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 195);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(335, 107);
            this.panel3.TabIndex = 9;
            // 
            // btInfo
            // 
            this.btInfo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btInfo.BackColor = System.Drawing.Color.White;
            this.btInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btInfo.FlatAppearance.BorderSize = 0;
            this.btInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btInfo.ForeColor = System.Drawing.Color.White;
            this.btInfo.Image = global::WatchStore.Properties.Resources.icons8_информация_40__1_;
            this.btInfo.Location = new System.Drawing.Point(3, 74);
            this.btInfo.Name = "btInfo";
            this.btInfo.Size = new System.Drawing.Size(31, 31);
            this.btInfo.TabIndex = 15;
            this.btInfo.UseVisualStyleBackColor = false;
            this.btInfo.Click += new System.EventHandler(this.btInfo_Click);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.Controls.Add(this.registrlb, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.btlogin, 0, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(80, 7);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(175, 93);
            this.tableLayoutPanel5.TabIndex = 6;
            // 
            // registrlb
            // 
            this.registrlb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.registrlb.AutoSize = true;
            this.registrlb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registrlb.Font = new System.Drawing.Font("Bookman Old Style", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registrlb.ForeColor = System.Drawing.Color.Gray;
            this.registrlb.Location = new System.Drawing.Point(16, 46);
            this.registrlb.Name = "registrlb";
            this.registrlb.Size = new System.Drawing.Size(142, 14);
            this.registrlb.TabIndex = 7;
            this.registrlb.Text = "зарегистрироваться";
            this.registrlb.Click += new System.EventHandler(this.registrlb_Click);
            // 
            // btlogin
            // 
            this.btlogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btlogin.BackColor = System.Drawing.Color.Crimson;
            this.btlogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btlogin.FlatAppearance.BorderSize = 0;
            this.btlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btlogin.ForeColor = System.Drawing.Color.White;
            this.btlogin.Location = new System.Drawing.Point(17, 3);
            this.btlogin.Name = "btlogin";
            this.btlogin.Size = new System.Drawing.Size(141, 40);
            this.btlogin.TabIndex = 1;
            this.btlogin.Text = "Войти";
            this.btlogin.UseVisualStyleBackColor = false;
            this.btlogin.Click += new System.EventHandler(this.btlogin_Click);
            // 
            // authorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(341, 335);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.panelheader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "authorization";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "authorization";
            this.Load += new System.EventHandler(this.authorization_Load);
            this.panelheader.ResumeLayout(false);
            this.panelheader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelheader;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btclose;
        private System.Windows.Forms.Button btmin;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Button bthide;
        private System.Windows.Forms.Button btshow;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TextBox textBox_login;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label registrlb;
        private System.Windows.Forms.Button btlogin;
        private System.Windows.Forms.Button btInfo;
    }
}

