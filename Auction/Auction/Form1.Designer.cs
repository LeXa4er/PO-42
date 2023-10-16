
namespace Auction
{
    partial class Avtorization
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Avtorization));
			this.buttonEnter = new System.Windows.Forms.Button();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ShowBtn = new System.Windows.Forms.Button();
			this.HideBtn = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.TextBoxPass = new System.Windows.Forms.TextBox();
			this.textBoxLogin = new System.Windows.Forms.TextBox();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// buttonEnter
			// 
			this.buttonEnter.BackColor = System.Drawing.Color.LightSteelBlue;
			this.buttonEnter.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonEnter.Location = new System.Drawing.Point(223, 287);
			this.buttonEnter.Name = "buttonEnter";
			this.buttonEnter.Size = new System.Drawing.Size(123, 40);
			this.buttonEnter.TabIndex = 65;
			this.buttonEnter.Text = "Войти";
			this.buttonEnter.UseVisualStyleBackColor = false;
			this.buttonEnter.Click += new System.EventHandler(this.vhodbtn_Click);
			// 
			// menuStrip1
			// 
			this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(142)))), ((int)(((byte)(189)))));
			this.menuStrip1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menuStrip1.BackgroundImage")));
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справкаToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
			this.menuStrip1.Size = new System.Drawing.Size(578, 24);
			this.menuStrip1.TabIndex = 64;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// справкаToolStripMenuItem
			// 
			this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem});
			this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
			this.справкаToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
			this.справкаToolStripMenuItem.Text = "Меню";
			// 
			// выходToolStripMenuItem
			// 
			this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
			this.выходToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
			this.выходToolStripMenuItem.Text = "Выход";
			// 
			// ShowBtn
			// 
			this.ShowBtn.BackColor = System.Drawing.Color.LightSteelBlue;
			this.ShowBtn.Image = ((System.Drawing.Image)(resources.GetObject("ShowBtn.Image")));
			this.ShowBtn.Location = new System.Drawing.Point(385, 222);
			this.ShowBtn.Name = "ShowBtn";
			this.ShowBtn.Size = new System.Drawing.Size(44, 39);
			this.ShowBtn.TabIndex = 62;
			this.ShowBtn.UseVisualStyleBackColor = false;
			// 
			// HideBtn
			// 
			this.HideBtn.Image = ((System.Drawing.Image)(resources.GetObject("HideBtn.Image")));
			this.HideBtn.Location = new System.Drawing.Point(385, 222);
			this.HideBtn.Name = "HideBtn";
			this.HideBtn.Size = new System.Drawing.Size(44, 39);
			this.HideBtn.TabIndex = 63;
			this.HideBtn.UseVisualStyleBackColor = true;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(185, 188);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(194, 31);
			this.label2.TabIndex = 61;
			this.label2.Text = "Введите пароль";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(185, 79);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(181, 31);
			this.label1.TabIndex = 60;
			this.label1.Text = "Введите логин";
			// 
			// TextBoxPass
			// 
			this.TextBoxPass.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.TextBoxPass.Location = new System.Drawing.Point(185, 222);
			this.TextBoxPass.Name = "TextBoxPass";
			this.TextBoxPass.Size = new System.Drawing.Size(194, 39);
			this.TextBoxPass.TabIndex = 59;
			this.toolTip1.SetToolTip(this.TextBoxPass, "Если вы забыли свой пароль, то обратитесь к администратору");
			this.TextBoxPass.UseSystemPasswordChar = true;
			// 
			// textBoxLogin
			// 
			this.textBoxLogin.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxLogin.Location = new System.Drawing.Point(185, 125);
			this.textBoxLogin.Name = "textBoxLogin";
			this.textBoxLogin.Size = new System.Drawing.Size(194, 39);
			this.textBoxLogin.TabIndex = 58;
			this.toolTip1.SetToolTip(this.textBoxLogin, "Если вы забыли свой логин, то обратитесь к администратору");
			// 
			// Avtorization
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(578, 397);
			this.Controls.Add(this.buttonEnter);
			this.Controls.Add(this.menuStrip1);
			this.Controls.Add(this.ShowBtn);
			this.Controls.Add(this.HideBtn);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.TextBoxPass);
			this.Controls.Add(this.textBoxLogin);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Avtorization";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Авторизация";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonEnter;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.Button ShowBtn;
        private System.Windows.Forms.Button HideBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBoxPass;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
	}
}

