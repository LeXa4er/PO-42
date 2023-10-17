namespace _3Days.Forms
{
    partial class LoginForm
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
            this.SelectedPageCaption = new System.Windows.Forms.Label();
            this.LoginTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.PassCheckBox = new System.Windows.Forms.CheckBox();
            this.TeamsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SelectedPageCaption
            // 
            this.SelectedPageCaption.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SelectedPageCaption.AutoSize = true;
            this.SelectedPageCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SelectedPageCaption.Location = new System.Drawing.Point(104, 9);
            this.SelectedPageCaption.Name = "SelectedPageCaption";
            this.SelectedPageCaption.Size = new System.Drawing.Size(141, 25);
            this.SelectedPageCaption.TabIndex = 6;
            this.SelectedPageCaption.Text = "Авторизация";
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginTextBox.Location = new System.Drawing.Point(37, 102);
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.Size = new System.Drawing.Size(277, 26);
            this.LoginTextBox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(33, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Логин";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(33, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "Пароль";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordTextBox.Location = new System.Drawing.Point(37, 203);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(277, 26);
            this.PasswordTextBox.TabIndex = 9;
            // 
            // PassCheckBox
            // 
            this.PassCheckBox.AutoSize = true;
            this.PassCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PassCheckBox.Location = new System.Drawing.Point(109, 250);
            this.PassCheckBox.Name = "PassCheckBox";
            this.PassCheckBox.Size = new System.Drawing.Size(134, 22);
            this.PassCheckBox.TabIndex = 3;
            this.PassCheckBox.Text = "Скрыть пароль";
            this.PassCheckBox.UseVisualStyleBackColor = true;
            this.PassCheckBox.CheckedChanged += new System.EventHandler(this.PassCheckBox_CheckedChanged);
            // 
            // TeamsButton
            // 
            this.TeamsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TeamsButton.Location = new System.Drawing.Point(109, 305);
            this.TeamsButton.Name = "TeamsButton";
            this.TeamsButton.Size = new System.Drawing.Size(130, 37);
            this.TeamsButton.TabIndex = 11;
            this.TeamsButton.Text = "Войти";
            this.TeamsButton.UseVisualStyleBackColor = true;
            this.TeamsButton.Click += new System.EventHandler(this.TeamsButton_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 363);
            this.Controls.Add(this.TeamsButton);
            this.Controls.Add(this.PassCheckBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LoginTextBox);
            this.Controls.Add(this.SelectedPageCaption);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SelectedPageCaption;
        private System.Windows.Forms.TextBox LoginTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.CheckBox PassCheckBox;
        private System.Windows.Forms.Button TeamsButton;
    }
}