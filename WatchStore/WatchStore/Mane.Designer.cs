namespace WatchStore
{
    partial class Mane
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mane));
            this.panelHeader = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btAdmins = new Guna.UI2.WinForms.Guna2Button();
            this.btClients = new Guna.UI2.WinForms.Guna2Button();
            this.btSales = new Guna.UI2.WinForms.Guna2Button();
            this.btKatalog = new Guna.UI2.WinForms.Guna2Button();
            this.panelMane = new System.Windows.Forms.Panel();
            this.exitbt = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btclose = new System.Windows.Forms.Button();
            this.btmaxed = new System.Windows.Forms.Button();
            this.btmin = new System.Windows.Forms.Button();
            this.btmax = new System.Windows.Forms.Button();
            this.btWatch = new Guna.UI2.WinForms.Guna2Button();
            this.panelHeader.SuspendLayout();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.Crimson;
            this.panelHeader.Controls.Add(this.pictureBox1);
            this.panelHeader.Controls.Add(this.label2);
            this.panelHeader.Controls.Add(this.btclose);
            this.panelHeader.Controls.Add(this.btmaxed);
            this.panelHeader.Controls.Add(this.btmin);
            this.panelHeader.Controls.Add(this.btmax);
            this.panelHeader.Cursor = System.Windows.Forms.Cursors.Default;
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1000, 30);
            this.panelHeader.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(457, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "WatchStore";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.btAdmins);
            this.panelMenu.Controls.Add(this.btWatch);
            this.panelMenu.Controls.Add(this.btClients);
            this.panelMenu.Controls.Add(this.btSales);
            this.panelMenu.Controls.Add(this.btKatalog);
            this.panelMenu.Controls.Add(this.exitbt);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenu.Location = new System.Drawing.Point(0, 30);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(1000, 45);
            this.panelMenu.TabIndex = 12;
            // 
            // btAdmins
            // 
            this.btAdmins.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btAdmins.CheckedState.BorderColor = System.Drawing.Color.White;
            this.btAdmins.CheckedState.CustomBorderColor = System.Drawing.Color.Crimson;
            this.btAdmins.CheckedState.FillColor = System.Drawing.Color.White;
            this.btAdmins.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAdmins.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.btAdmins.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btAdmins.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btAdmins.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btAdmins.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btAdmins.FillColor = System.Drawing.Color.White;
            this.btAdmins.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdmins.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btAdmins.HoverState.CustomBorderColor = System.Drawing.Color.Crimson;
            this.btAdmins.HoverState.FillColor = System.Drawing.Color.White;
            this.btAdmins.Location = new System.Drawing.Point(468, 3);
            this.btAdmins.Name = "btAdmins";
            this.btAdmins.Size = new System.Drawing.Size(186, 40);
            this.btAdmins.TabIndex = 18;
            this.btAdmins.Text = "Администраторы";
            this.btAdmins.Click += new System.EventHandler(this.btAdmins_Click);
            // 
            // btClients
            // 
            this.btClients.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btClients.CheckedState.BorderColor = System.Drawing.Color.White;
            this.btClients.CheckedState.CustomBorderColor = System.Drawing.Color.Crimson;
            this.btClients.CheckedState.FillColor = System.Drawing.Color.White;
            this.btClients.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btClients.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.btClients.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btClients.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btClients.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btClients.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btClients.FillColor = System.Drawing.Color.White;
            this.btClients.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClients.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btClients.HoverState.CustomBorderColor = System.Drawing.Color.Crimson;
            this.btClients.HoverState.FillColor = System.Drawing.Color.White;
            this.btClients.Location = new System.Drawing.Point(312, 3);
            this.btClients.Name = "btClients";
            this.btClients.Size = new System.Drawing.Size(150, 40);
            this.btClients.TabIndex = 17;
            this.btClients.Text = "Клиенты";
            this.btClients.Click += new System.EventHandler(this.btClients_Click);
            // 
            // btSales
            // 
            this.btSales.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btSales.CheckedState.BorderColor = System.Drawing.Color.White;
            this.btSales.CheckedState.CustomBorderColor = System.Drawing.Color.Crimson;
            this.btSales.CheckedState.FillColor = System.Drawing.Color.White;
            this.btSales.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSales.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.btSales.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btSales.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btSales.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btSales.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btSales.FillColor = System.Drawing.Color.White;
            this.btSales.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSales.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btSales.HoverState.CustomBorderColor = System.Drawing.Color.Crimson;
            this.btSales.HoverState.FillColor = System.Drawing.Color.White;
            this.btSales.Location = new System.Drawing.Point(156, 3);
            this.btSales.Name = "btSales";
            this.btSales.Size = new System.Drawing.Size(150, 40);
            this.btSales.TabIndex = 16;
            this.btSales.Text = "Покупки";
            this.btSales.Click += new System.EventHandler(this.btSales_Click);
            // 
            // btKatalog
            // 
            this.btKatalog.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btKatalog.Checked = true;
            this.btKatalog.CheckedState.BorderColor = System.Drawing.Color.White;
            this.btKatalog.CheckedState.CustomBorderColor = System.Drawing.Color.Crimson;
            this.btKatalog.CheckedState.FillColor = System.Drawing.Color.White;
            this.btKatalog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btKatalog.CustomBorderColor = System.Drawing.Color.White;
            this.btKatalog.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.btKatalog.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btKatalog.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btKatalog.DisabledState.FillColor = System.Drawing.Color.White;
            this.btKatalog.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btKatalog.FillColor = System.Drawing.Color.White;
            this.btKatalog.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btKatalog.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btKatalog.HoverState.CustomBorderColor = System.Drawing.Color.Crimson;
            this.btKatalog.HoverState.FillColor = System.Drawing.Color.White;
            this.btKatalog.Location = new System.Drawing.Point(0, 3);
            this.btKatalog.Name = "btKatalog";
            this.btKatalog.Size = new System.Drawing.Size(150, 40);
            this.btKatalog.TabIndex = 15;
            this.btKatalog.Text = "Каталог";
            this.btKatalog.Click += new System.EventHandler(this.btKatalog_Click);
            // 
            // panelMane
            // 
            this.panelMane.BackColor = System.Drawing.Color.White;
            this.panelMane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMane.Location = new System.Drawing.Point(0, 75);
            this.panelMane.Name = "panelMane";
            this.panelMane.Size = new System.Drawing.Size(1000, 675);
            this.panelMane.TabIndex = 14;
            // 
            // exitbt
            // 
            this.exitbt.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.exitbt.BackColor = System.Drawing.Color.White;
            this.exitbt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitbt.FlatAppearance.BorderSize = 0;
            this.exitbt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitbt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitbt.ForeColor = System.Drawing.Color.White;
            this.exitbt.Image = global::WatchStore.Properties.Resources.icons8_выход_30;
            this.exitbt.Location = new System.Drawing.Point(953, 3);
            this.exitbt.Name = "exitbt";
            this.exitbt.Size = new System.Drawing.Size(44, 40);
            this.exitbt.TabIndex = 14;
            this.exitbt.UseVisualStyleBackColor = false;
            this.exitbt.Click += new System.EventHandler(this.exitbt_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WatchStore.Properties.Resources.icons8_часы___вид_спереди_24;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // btclose
            // 
            this.btclose.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btclose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btclose.FlatAppearance.BorderSize = 0;
            this.btclose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btclose.Image = global::WatchStore.Properties.Resources.icons8_закрыть_окно_24;
            this.btclose.Location = new System.Drawing.Point(972, 0);
            this.btclose.Name = "btclose";
            this.btclose.Size = new System.Drawing.Size(25, 30);
            this.btclose.TabIndex = 1;
            this.btclose.UseVisualStyleBackColor = true;
            this.btclose.Click += new System.EventHandler(this.btclose_Click);
            // 
            // btmaxed
            // 
            this.btmaxed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btmaxed.FlatAppearance.BorderSize = 0;
            this.btmaxed.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tomato;
            this.btmaxed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btmaxed.Image = global::WatchStore.Properties.Resources.icons8_демонстрация_экрана_24;
            this.btmaxed.Location = new System.Drawing.Point(861, 0);
            this.btmaxed.Name = "btmaxed";
            this.btmaxed.Size = new System.Drawing.Size(25, 30);
            this.btmaxed.TabIndex = 4;
            this.btmaxed.UseVisualStyleBackColor = true;
            this.btmaxed.Visible = false;
            this.btmaxed.Click += new System.EventHandler(this.btmaxed_Click);
            // 
            // btmin
            // 
            this.btmin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btmin.FlatAppearance.BorderSize = 0;
            this.btmin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tomato;
            this.btmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btmin.Image = global::WatchStore.Properties.Resources.icons8_свернуть_окно_24;
            this.btmin.Location = new System.Drawing.Point(911, 0);
            this.btmin.Name = "btmin";
            this.btmin.Size = new System.Drawing.Size(25, 30);
            this.btmin.TabIndex = 3;
            this.btmin.UseVisualStyleBackColor = true;
            this.btmin.Click += new System.EventHandler(this.btmin_Click);
            // 
            // btmax
            // 
            this.btmax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btmax.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btmax.FlatAppearance.BorderSize = 0;
            this.btmax.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tomato;
            this.btmax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btmax.Image = global::WatchStore.Properties.Resources.icons8_скругленный_квадрат_24;
            this.btmax.Location = new System.Drawing.Point(942, 0);
            this.btmax.Name = "btmax";
            this.btmax.Size = new System.Drawing.Size(25, 30);
            this.btmax.TabIndex = 2;
            this.btmax.UseVisualStyleBackColor = true;
            this.btmax.Click += new System.EventHandler(this.btmax_Click);
            // 
            // btWatch
            // 
            this.btWatch.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btWatch.CheckedState.BorderColor = System.Drawing.Color.White;
            this.btWatch.CheckedState.CustomBorderColor = System.Drawing.Color.Crimson;
            this.btWatch.CheckedState.FillColor = System.Drawing.Color.White;
            this.btWatch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btWatch.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.btWatch.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btWatch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btWatch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btWatch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btWatch.FillColor = System.Drawing.Color.White;
            this.btWatch.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btWatch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btWatch.HoverState.CustomBorderColor = System.Drawing.Color.Crimson;
            this.btWatch.HoverState.FillColor = System.Drawing.Color.White;
            this.btWatch.Location = new System.Drawing.Point(660, 2);
            this.btWatch.Name = "btWatch";
            this.btWatch.Size = new System.Drawing.Size(150, 40);
            this.btWatch.TabIndex = 17;
            this.btWatch.Text = "Часы";
            this.btWatch.Click += new System.EventHandler(this.btWatch_Click);
            // 
            // Mane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 750);
            this.Controls.Add(this.panelMane);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Mane";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mane";
            this.Load += new System.EventHandler(this.Mane_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btclose;
        private System.Windows.Forms.Button btmaxed;
        private System.Windows.Forms.Button btmin;
        private System.Windows.Forms.Button btmax;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelMane;
        private System.Windows.Forms.Button exitbt;
        private Guna.UI2.WinForms.Guna2Button btKatalog;
        private Guna.UI2.WinForms.Guna2Button btSales;
        private Guna.UI2.WinForms.Guna2Button btClients;
        private Guna.UI2.WinForms.Guna2Button btAdmins;
        private Guna.UI2.WinForms.Guna2Button btWatch;
    }
}