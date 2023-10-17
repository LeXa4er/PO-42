namespace ClassicMusic
{
    partial class RecordAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecordAdmin));
            this.FormStyle1 = new yt_DesignUI.Components.FormStyles(this.components);
            this.buttonClose = new yt_DesignUI.ButtonStyle();
            this.textBoxLogin = new yt_DesignUI.TextBoxStyle();
            this.textBoxPassword = new yt_DesignUI.TextBoxStyle();
            this.buttonAdd = new yt_DesignUI.ButtonStyle();
            this.labelTable = new System.Windows.Forms.Label();
            this.buttonFurther = new yt_DesignUI.ButtonStyle();
            this.buttonBack = new yt_DesignUI.ButtonStyle();
            this.SuspendLayout();
            // 
            // FormStyle1
            // 
            this.FormStyle1.AllowUserResize = true;
            this.FormStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.FormStyle1.ContextMenuForm = null;
            this.FormStyle1.ControlBoxButtonsWidth = 60;
            this.FormStyle1.EnableControlBoxIconsLight = true;
            this.FormStyle1.EnableControlBoxMouseLight = true;
            this.FormStyle1.Form = this;
            this.FormStyle1.FormStyle = yt_DesignUI.Components.FormStyles.fStyle.UserStyle;
            this.FormStyle1.HeaderColor = System.Drawing.Color.BlueViolet;
            this.FormStyle1.HeaderColorAdditional = System.Drawing.Color.OrangeRed;
            this.FormStyle1.HeaderColorGradientEnable = true;
            this.FormStyle1.HeaderColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.FormStyle1.HeaderHeight = 48;
            this.FormStyle1.HeaderImage = null;
            this.FormStyle1.HeaderTextColor = System.Drawing.Color.White;
            this.FormStyle1.HeaderTextFont = new System.Drawing.Font("Segoe Print", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.Magenta;
            this.buttonClose.BackColorAdditional = System.Drawing.Color.Cyan;
            this.buttonClose.BackColorGradientEnabled = true;
            this.buttonClose.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.buttonClose.BorderColor = System.Drawing.Color.Black;
            this.buttonClose.BorderColorEnabled = false;
            this.buttonClose.BorderColorOnHover = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonClose.BorderColorOnHoverEnabled = true;
            this.buttonClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClose.Font = new System.Drawing.Font("Magnolia Script", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.ForeColor = System.Drawing.Color.Black;
            this.buttonClose.Location = new System.Drawing.Point(6, 10);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonClose.MaximumSize = new System.Drawing.Size(155, 51);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.RippleColor = System.Drawing.Color.Black;
            this.buttonClose.RoundingEnable = true;
            this.buttonClose.Size = new System.Drawing.Size(95, 40);
            this.buttonClose.TabIndex = 62;
            this.buttonClose.Text = "Назад";
            this.buttonClose.TextHover = null;
            this.buttonClose.UseDownPressEffectOnClick = true;
            this.buttonClose.UseRippleEffect = true;
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.UseZoomEffectOnHover = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.BackColor = System.Drawing.Color.White;
            this.textBoxLogin.BorderColor = System.Drawing.Color.Black;
            this.textBoxLogin.BorderColorNotActive = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.textBoxLogin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxLogin.Font = new System.Drawing.Font("Segoe UI", 12.75F);
            this.textBoxLogin.FontTextPreview = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxLogin.ForeColor = System.Drawing.Color.Black;
            this.textBoxLogin.Location = new System.Drawing.Point(129, 85);
            this.textBoxLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxLogin.MaximumSize = new System.Drawing.Size(298, 40);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.SelectionStart = 0;
            this.textBoxLogin.Size = new System.Drawing.Size(247, 40);
            this.textBoxLogin.TabIndex = 63;
            this.textBoxLogin.TextInput = "";
            this.textBoxLogin.TextPreview = "Логин";
            this.textBoxLogin.UseSystemPasswordChar = false;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BackColor = System.Drawing.Color.White;
            this.textBoxPassword.BorderColor = System.Drawing.Color.Black;
            this.textBoxPassword.BorderColorNotActive = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.textBoxPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxPassword.Font = new System.Drawing.Font("Segoe UI", 12.75F);
            this.textBoxPassword.FontTextPreview = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPassword.ForeColor = System.Drawing.Color.Black;
            this.textBoxPassword.Location = new System.Drawing.Point(129, 133);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxPassword.MaximumSize = new System.Drawing.Size(298, 40);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.SelectionStart = 0;
            this.textBoxPassword.Size = new System.Drawing.Size(247, 40);
            this.textBoxPassword.TabIndex = 64;
            this.textBoxPassword.TextInput = "";
            this.textBoxPassword.TextPreview = "Пароль";
            this.textBoxPassword.UseSystemPasswordChar = false;
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.Magenta;
            this.buttonAdd.BackColorAdditional = System.Drawing.Color.Cyan;
            this.buttonAdd.BackColorGradientEnabled = true;
            this.buttonAdd.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.buttonAdd.BorderColor = System.Drawing.Color.Black;
            this.buttonAdd.BorderColorEnabled = false;
            this.buttonAdd.BorderColorOnHover = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonAdd.BorderColorOnHoverEnabled = true;
            this.buttonAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAdd.Font = new System.Drawing.Font("Magnolia Script", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.ForeColor = System.Drawing.Color.Black;
            this.buttonAdd.Location = new System.Drawing.Point(189, 190);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonAdd.MaximumSize = new System.Drawing.Size(155, 51);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.RippleColor = System.Drawing.Color.Black;
            this.buttonAdd.RoundingEnable = true;
            this.buttonAdd.Size = new System.Drawing.Size(152, 44);
            this.buttonAdd.TabIndex = 65;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.TextHover = null;
            this.buttonAdd.UseDownPressEffectOnClick = true;
            this.buttonAdd.UseRippleEffect = true;
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.UseZoomEffectOnHover = false;
            // 
            // labelTable
            // 
            this.labelTable.AutoSize = true;
            this.labelTable.BackColor = System.Drawing.Color.Transparent;
            this.labelTable.Font = new System.Drawing.Font("Magnolia Script", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTable.Location = new System.Drawing.Point(157, 29);
            this.labelTable.Name = "labelTable";
            this.labelTable.Size = new System.Drawing.Size(184, 38);
            this.labelTable.TabIndex = 66;
            this.labelTable.Text = "Регистрация";
            // 
            // buttonFurther
            // 
            this.buttonFurther.BackColor = System.Drawing.Color.Magenta;
            this.buttonFurther.BackColorAdditional = System.Drawing.Color.Cyan;
            this.buttonFurther.BackColorGradientEnabled = true;
            this.buttonFurther.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.buttonFurther.BorderColor = System.Drawing.Color.Black;
            this.buttonFurther.BorderColorEnabled = false;
            this.buttonFurther.BorderColorOnHover = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonFurther.BorderColorOnHoverEnabled = true;
            this.buttonFurther.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFurther.Font = new System.Drawing.Font("Magnolia Script", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFurther.ForeColor = System.Drawing.Color.Black;
            this.buttonFurther.Location = new System.Drawing.Point(467, 190);
            this.buttonFurther.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonFurther.MaximumSize = new System.Drawing.Size(155, 51);
            this.buttonFurther.Name = "buttonFurther";
            this.buttonFurther.RippleColor = System.Drawing.Color.Black;
            this.buttonFurther.RoundingEnable = true;
            this.buttonFurther.Size = new System.Drawing.Size(52, 46);
            this.buttonFurther.TabIndex = 68;
            this.buttonFurther.Text = "→";
            this.buttonFurther.TextHover = null;
            this.buttonFurther.UseDownPressEffectOnClick = true;
            this.buttonFurther.UseRippleEffect = true;
            this.buttonFurther.UseVisualStyleBackColor = false;
            this.buttonFurther.UseZoomEffectOnHover = false;
            this.buttonFurther.Click += new System.EventHandler(this.buttonFurther_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.Magenta;
            this.buttonBack.BackColorAdditional = System.Drawing.Color.Cyan;
            this.buttonBack.BackColorGradientEnabled = true;
            this.buttonBack.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.buttonBack.BorderColor = System.Drawing.Color.Black;
            this.buttonBack.BorderColorEnabled = false;
            this.buttonBack.BorderColorOnHover = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonBack.BorderColorOnHoverEnabled = true;
            this.buttonBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBack.Font = new System.Drawing.Font("Magnolia Script", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.ForeColor = System.Drawing.Color.Black;
            this.buttonBack.Location = new System.Drawing.Point(12, 190);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonBack.MaximumSize = new System.Drawing.Size(155, 51);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.RippleColor = System.Drawing.Color.Black;
            this.buttonBack.RoundingEnable = true;
            this.buttonBack.Size = new System.Drawing.Size(52, 46);
            this.buttonBack.TabIndex = 67;
            this.buttonBack.Text = "←";
            this.buttonBack.TextHover = null;
            this.buttonBack.UseDownPressEffectOnClick = true;
            this.buttonBack.UseRippleEffect = true;
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.UseZoomEffectOnHover = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // RecordAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(531, 249);
            this.Controls.Add(this.buttonFurther);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.labelTable);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.buttonClose);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(547, 288);
            this.MinimumSize = new System.Drawing.Size(547, 288);
            this.Name = "RecordAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Запись";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private yt_DesignUI.Components.FormStyles FormStyle1;
        private yt_DesignUI.ButtonStyle buttonClose;
        private yt_DesignUI.ButtonStyle buttonAdd;
        private yt_DesignUI.TextBoxStyle textBoxPassword;
        private yt_DesignUI.TextBoxStyle textBoxLogin;
        private System.Windows.Forms.Label labelTable;
        private yt_DesignUI.ButtonStyle buttonFurther;
        private yt_DesignUI.ButtonStyle buttonBack;
    }
}