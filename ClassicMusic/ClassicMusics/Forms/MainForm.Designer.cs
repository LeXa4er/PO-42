namespace yt_DesignUI
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.textBoxName1 = new yt_DesignUI.TextBoxStyle();
            this.FormStyle1 = new yt_DesignUI.Components.FormStyles(this.components);
            this.cmbStyle = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.roundingButtonsComponent1 = new yt_DesignUI.Components.RoundingBut(this.components);
            this.cardQuote1 = new yt_DesignUI.Card();
            this.toggleAvailability = new yt_DesignUI.ToggleSwitchStyle();
            this.buttonEditor = new yt_DesignUI.ButtonStyle();
            this.labelFilter = new System.Windows.Forms.Label();
            this.pictureBoxInfo = new System.Windows.Forms.PictureBox();
            this.listBoxInformation1 = new System.Windows.Forms.ListBox();
            this.textBoxSearch = new yt_DesignUI.TextBoxStyle();
            this.cardQuote2 = new yt_DesignUI.Card();
            this.cardQuote3 = new yt_DesignUI.Card();
            this.buttonInfo = new yt_DesignUI.ButtonStyle();
            this.labelAvailability = new System.Windows.Forms.Label();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.buttonReference = new yt_DesignUI.ButtonStyle();
            this.textBoxComposer1 = new yt_DesignUI.TextBoxStyle();
            this.textBoxYear1 = new yt_DesignUI.TextBoxStyle();
            this.labelType1 = new System.Windows.Forms.Label();
            this.textBoxName2 = new System.Windows.Forms.TextBox();
            this.textBoxComposer2 = new System.Windows.Forms.TextBox();
            this.textBoxYear2 = new System.Windows.Forms.TextBox();
            this.textBoxDuration = new System.Windows.Forms.TextBox();
            this.textBoxType = new System.Windows.Forms.TextBox();
            this.textBoxMaterial = new System.Windows.Forms.TextBox();
            this.labelComposer = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelYear = new System.Windows.Forms.Label();
            this.labelDuration = new System.Windows.Forms.Label();
            this.labelType2 = new System.Windows.Forms.Label();
            this.labelMaterial = new System.Windows.Forms.Label();
            this.toggleMusic = new yt_DesignUI.ToggleSwitchStyle();
            this.labelMusic = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxName1
            // 
            this.textBoxName1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxName1.BackColor = System.Drawing.Color.White;
            this.textBoxName1.BorderColor = System.Drawing.Color.Black;
            this.textBoxName1.BorderColorNotActive = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.textBoxName1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxName1.Font = new System.Drawing.Font("Segoe UI", 12.75F);
            this.textBoxName1.FontTextPreview = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxName1.ForeColor = System.Drawing.Color.Black;
            this.textBoxName1.Location = new System.Drawing.Point(36, 124);
            this.textBoxName1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxName1.MaximumSize = new System.Drawing.Size(298, 40);
            this.textBoxName1.MinimumSize = new System.Drawing.Size(298, 40);
            this.textBoxName1.Name = "textBoxName1";
            this.textBoxName1.SelectionStart = 0;
            this.textBoxName1.Size = new System.Drawing.Size(298, 40);
            this.textBoxName1.TabIndex = 8;
            this.textBoxName1.TextInput = "";
            this.textBoxName1.TextPreview = "Название";
            this.textBoxName1.UseSystemPasswordChar = false;
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
            // cmbStyle
            // 
            this.cmbStyle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStyle.Enabled = false;
            this.cmbStyle.FormattingEnabled = true;
            this.cmbStyle.Location = new System.Drawing.Point(1618, 425);
            this.cmbStyle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbStyle.Name = "cmbStyle";
            this.cmbStyle.Size = new System.Drawing.Size(10, 21);
            this.cmbStyle.TabIndex = 14;
            this.cmbStyle.Visible = false;
            this.cmbStyle.SelectedIndexChanged += new System.EventHandler(this.cmbStyle_SelectedIndexChanged);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 50;
            // 
            // roundingButtonsComponent1
            // 
            this.roundingButtonsComponent1.RoundingEnable = false;
            this.roundingButtonsComponent1.TargetForm = null;
            // 
            // cardQuote1
            // 
            this.cardQuote1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cardQuote1.BackColor = System.Drawing.Color.LightGray;
            this.cardQuote1.BackColorCurtain = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cardQuote1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cardQuote1.Font = new System.Drawing.Font("Lucida Fax", 11.25F, System.Drawing.FontStyle.Bold);
            this.cardQuote1.FontDescrition = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cardQuote1.FontHeader = new System.Drawing.Font("Magnolia Script", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cardQuote1.ForeColorDescrition = System.Drawing.Color.Black;
            this.cardQuote1.ForeColorHeader = System.Drawing.Color.White;
            this.cardQuote1.Location = new System.Drawing.Point(1016, 19);
            this.cardQuote1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cardQuote1.MaximumSize = new System.Drawing.Size(226, 190);
            this.cardQuote1.MinimumSize = new System.Drawing.Size(226, 190);
            this.cardQuote1.Name = "cardQuote1";
            this.cardQuote1.Size = new System.Drawing.Size(226, 190);
            this.cardQuote1.TabIndex = 29;
            this.cardQuote1.Text = "Цитата #1";
            this.cardQuote1.TextDescrition = "Музыка не в нотах, но в тишине между ними. ";
            this.cardQuote1.TextHeader = "В. А. Моцарт";
            // 
            // toggleAvailability
            // 
            this.toggleAvailability.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.toggleAvailability.BackColor = System.Drawing.Color.White;
            this.toggleAvailability.BackColorOFF = System.Drawing.Color.Gray;
            this.toggleAvailability.BackColorON = System.Drawing.Color.SpringGreen;
            this.toggleAvailability.Checked = false;
            this.toggleAvailability.Cursor = System.Windows.Forms.Cursors.Hand;
            this.toggleAvailability.Font = new System.Drawing.Font("Magnolia Script", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toggleAvailability.Location = new System.Drawing.Point(216, 373);
            this.toggleAvailability.MaximumSize = new System.Drawing.Size(90, 19);
            this.toggleAvailability.MinimumSize = new System.Drawing.Size(90, 19);
            this.toggleAvailability.Name = "toggleAvailability";
            this.toggleAvailability.Size = new System.Drawing.Size(90, 19);
            this.toggleAvailability.TabIndex = 30;
            this.toggleAvailability.Text = "Нет";
            this.toggleAvailability.TextOnChecked = "Есть";
            // 
            // buttonEditor
            // 
            this.buttonEditor.BackColor = System.Drawing.Color.Cyan;
            this.buttonEditor.BackColorAdditional = System.Drawing.Color.Magenta;
            this.buttonEditor.BackColorGradientEnabled = true;
            this.buttonEditor.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.buttonEditor.BorderColor = System.Drawing.Color.Black;
            this.buttonEditor.BorderColorEnabled = false;
            this.buttonEditor.BorderColorOnHover = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonEditor.BorderColorOnHoverEnabled = true;
            this.buttonEditor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEditor.Font = new System.Drawing.Font("Magnolia Script", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditor.ForeColor = System.Drawing.Color.Black;
            this.buttonEditor.Location = new System.Drawing.Point(136, 13);
            this.buttonEditor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonEditor.MaximumSize = new System.Drawing.Size(155, 51);
            this.buttonEditor.MinimumSize = new System.Drawing.Size(155, 51);
            this.buttonEditor.Name = "buttonEditor";
            this.buttonEditor.RippleColor = System.Drawing.Color.Black;
            this.buttonEditor.RoundingEnable = true;
            this.buttonEditor.Size = new System.Drawing.Size(155, 51);
            this.buttonEditor.TabIndex = 28;
            this.buttonEditor.Text = "Редактор";
            this.buttonEditor.TextHover = null;
            this.buttonEditor.UseDownPressEffectOnClick = true;
            this.buttonEditor.UseRippleEffect = true;
            this.buttonEditor.UseVisualStyleBackColor = false;
            this.buttonEditor.UseZoomEffectOnHover = false;
            this.buttonEditor.Click += new System.EventHandler(this.yt_Button4_Click_1);
            // 
            // labelFilter
            // 
            this.labelFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelFilter.AutoSize = true;
            this.labelFilter.Font = new System.Drawing.Font("Magnolia Script", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFilter.Location = new System.Drawing.Point(76, 86);
            this.labelFilter.MaximumSize = new System.Drawing.Size(215, 34);
            this.labelFilter.MinimumSize = new System.Drawing.Size(215, 34);
            this.labelFilter.Name = "labelFilter";
            this.labelFilter.Size = new System.Drawing.Size(215, 34);
            this.labelFilter.TabIndex = 32;
            this.labelFilter.Text = "Фильтры поиска";
            // 
            // pictureBoxInfo
            // 
            this.pictureBoxInfo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxInfo.BackgroundImage")));
            this.pictureBoxInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxInfo.Cursor = System.Windows.Forms.Cursors.Help;
            this.pictureBoxInfo.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxInfo.ErrorImage")));
            this.pictureBoxInfo.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxInfo.InitialImage")));
            this.pictureBoxInfo.Location = new System.Drawing.Point(82, 411);
            this.pictureBoxInfo.MaximumSize = new System.Drawing.Size(200, 200);
            this.pictureBoxInfo.MinimumSize = new System.Drawing.Size(200, 200);
            this.pictureBoxInfo.Name = "pictureBoxInfo";
            this.pictureBoxInfo.Size = new System.Drawing.Size(200, 200);
            this.pictureBoxInfo.TabIndex = 33;
            this.pictureBoxInfo.TabStop = false;
            // 
            // listBoxInformation1
            // 
            this.listBoxInformation1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxInformation1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.listBoxInformation1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBoxInformation1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listBoxInformation1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxInformation1.FormattingEnabled = true;
            this.listBoxInformation1.ItemHeight = 23;
            this.listBoxInformation1.Location = new System.Drawing.Point(369, 86);
            this.listBoxInformation1.MinimumSize = new System.Drawing.Size(623, 301);
            this.listBoxInformation1.Name = "listBoxInformation1";
            this.listBoxInformation1.Size = new System.Drawing.Size(623, 301);
            this.listBoxInformation1.TabIndex = 34;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSearch.BackColor = System.Drawing.Color.White;
            this.textBoxSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.textBoxSearch.BorderColorNotActive = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.textBoxSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxSearch.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSearch.FontTextPreview = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSearch.ForeColor = System.Drawing.Color.Black;
            this.textBoxSearch.Location = new System.Drawing.Point(449, 27);
            this.textBoxSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxSearch.MinimumSize = new System.Drawing.Size(443, 40);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.SelectionStart = 0;
            this.textBoxSearch.Size = new System.Drawing.Size(443, 40);
            this.textBoxSearch.TabIndex = 35;
            this.textBoxSearch.TextInput = "";
            this.textBoxSearch.TextPreview = "Поиск";
            this.textBoxSearch.UseSystemPasswordChar = false;
            // 
            // cardQuote2
            // 
            this.cardQuote2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cardQuote2.BackColor = System.Drawing.Color.SaddleBrown;
            this.cardQuote2.BackColorCurtain = System.Drawing.Color.Coral;
            this.cardQuote2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cardQuote2.Font = new System.Drawing.Font("Lucida Fax", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cardQuote2.FontDescrition = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cardQuote2.FontHeader = new System.Drawing.Font("Magnolia Script", 12F, System.Drawing.FontStyle.Italic);
            this.cardQuote2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.cardQuote2.ForeColorDescrition = System.Drawing.Color.White;
            this.cardQuote2.ForeColorHeader = System.Drawing.Color.White;
            this.cardQuote2.Location = new System.Drawing.Point(1016, 240);
            this.cardQuote2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cardQuote2.MaximumSize = new System.Drawing.Size(226, 190);
            this.cardQuote2.MinimumSize = new System.Drawing.Size(226, 190);
            this.cardQuote2.Name = "cardQuote2";
            this.cardQuote2.Size = new System.Drawing.Size(226, 190);
            this.cardQuote2.TabIndex = 36;
            this.cardQuote2.Text = "Цитата #2";
            this.cardQuote2.TextDescrition = "Музыка не может мыслить, но она может воплощать мысль.";
            this.cardQuote2.TextHeader = "В.Р. Багнер";
            // 
            // cardQuote3
            // 
            this.cardQuote3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cardQuote3.BackColor = System.Drawing.Color.CornflowerBlue;
            this.cardQuote3.BackColorCurtain = System.Drawing.Color.DarkKhaki;
            this.cardQuote3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cardQuote3.Font = new System.Drawing.Font("Lucida Fax", 11.25F, System.Drawing.FontStyle.Bold);
            this.cardQuote3.FontDescrition = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cardQuote3.FontHeader = new System.Drawing.Font("Magnolia Script", 12F, System.Drawing.FontStyle.Italic);
            this.cardQuote3.ForeColor = System.Drawing.Color.White;
            this.cardQuote3.ForeColorDescrition = System.Drawing.Color.White;
            this.cardQuote3.ForeColorHeader = System.Drawing.Color.White;
            this.cardQuote3.Location = new System.Drawing.Point(1016, 460);
            this.cardQuote3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cardQuote3.MaximumSize = new System.Drawing.Size(226, 190);
            this.cardQuote3.MinimumSize = new System.Drawing.Size(226, 190);
            this.cardQuote3.Name = "cardQuote3";
            this.cardQuote3.Size = new System.Drawing.Size(226, 190);
            this.cardQuote3.TabIndex = 37;
            this.cardQuote3.Text = "Цитата #3";
            this.cardQuote3.TextDescrition = "Слова иногда нуждаются в музыке, но музыка не нуждается ни в чем!";
            this.cardQuote3.TextHeader = "Э.Х. Григ";
            // 
            // buttonInfo
            // 
            this.buttonInfo.BackColor = System.Drawing.Color.Cyan;
            this.buttonInfo.BackColorAdditional = System.Drawing.Color.Magenta;
            this.buttonInfo.BackColorGradientEnabled = true;
            this.buttonInfo.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.buttonInfo.BorderColor = System.Drawing.Color.Black;
            this.buttonInfo.BorderColorEnabled = false;
            this.buttonInfo.BorderColorOnHover = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonInfo.BorderColorOnHoverEnabled = true;
            this.buttonInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonInfo.Font = new System.Drawing.Font("Magnolia Script", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInfo.ForeColor = System.Drawing.Color.Black;
            this.buttonInfo.Location = new System.Drawing.Point(22, 13);
            this.buttonInfo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonInfo.MaximumSize = new System.Drawing.Size(108, 51);
            this.buttonInfo.MinimumSize = new System.Drawing.Size(108, 51);
            this.buttonInfo.Name = "buttonInfo";
            this.buttonInfo.RippleColor = System.Drawing.Color.Black;
            this.buttonInfo.RoundingEnable = true;
            this.buttonInfo.Size = new System.Drawing.Size(108, 51);
            this.buttonInfo.TabIndex = 38;
            this.buttonInfo.Text = "О нас";
            this.buttonInfo.TextHover = null;
            this.buttonInfo.UseDownPressEffectOnClick = true;
            this.buttonInfo.UseRippleEffect = true;
            this.buttonInfo.UseVisualStyleBackColor = false;
            this.buttonInfo.UseZoomEffectOnHover = false;
            this.buttonInfo.Click += new System.EventHandler(this.buttonInfo_Click);
            // 
            // labelAvailability
            // 
            this.labelAvailability.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelAvailability.AutoSize = true;
            this.labelAvailability.Font = new System.Drawing.Font("Magnolia Script", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAvailability.Location = new System.Drawing.Point(58, 362);
            this.labelAvailability.MaximumSize = new System.Drawing.Size(143, 34);
            this.labelAvailability.MinimumSize = new System.Drawing.Size(143, 34);
            this.labelAvailability.Name = "labelAvailability";
            this.labelAvailability.Size = new System.Drawing.Size(143, 34);
            this.labelAvailability.TabIndex = 39;
            this.labelAvailability.Text = "В наличии:";
            // 
            // comboBoxType
            // 
            this.comboBoxType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBoxType.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "Граммофонные пластинки",
            "Компакт-диск ",
            "Дуал-диск",
            "Флеш накопитель"});
            this.comboBoxType.Location = new System.Drawing.Point(36, 320);
            this.comboBoxType.MaximumSize = new System.Drawing.Size(298, 0);
            this.comboBoxType.MinimumSize = new System.Drawing.Size(298, 0);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(298, 31);
            this.comboBoxType.TabIndex = 40;
            // 
            // buttonReference
            // 
            this.buttonReference.BackColor = System.Drawing.Color.Cyan;
            this.buttonReference.BackColorAdditional = System.Drawing.Color.Magenta;
            this.buttonReference.BackColorGradientEnabled = true;
            this.buttonReference.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.buttonReference.BorderColor = System.Drawing.Color.Black;
            this.buttonReference.BorderColorEnabled = false;
            this.buttonReference.BorderColorOnHover = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonReference.BorderColorOnHoverEnabled = true;
            this.buttonReference.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonReference.Font = new System.Drawing.Font("Magnolia Script", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReference.ForeColor = System.Drawing.Color.Black;
            this.buttonReference.Location = new System.Drawing.Point(297, 13);
            this.buttonReference.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonReference.MaximumSize = new System.Drawing.Size(57, 51);
            this.buttonReference.MinimumSize = new System.Drawing.Size(57, 51);
            this.buttonReference.Name = "buttonReference";
            this.buttonReference.RippleColor = System.Drawing.Color.Black;
            this.buttonReference.RoundingEnable = true;
            this.buttonReference.Size = new System.Drawing.Size(57, 51);
            this.buttonReference.TabIndex = 42;
            this.buttonReference.Text = "?";
            this.buttonReference.TextHover = null;
            this.buttonReference.UseDownPressEffectOnClick = true;
            this.buttonReference.UseRippleEffect = true;
            this.buttonReference.UseVisualStyleBackColor = false;
            this.buttonReference.UseZoomEffectOnHover = false;
            this.buttonReference.Click += new System.EventHandler(this.buttonReference_Click);
            // 
            // textBoxComposer1
            // 
            this.textBoxComposer1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxComposer1.BackColor = System.Drawing.Color.White;
            this.textBoxComposer1.BorderColor = System.Drawing.Color.Black;
            this.textBoxComposer1.BorderColorNotActive = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.textBoxComposer1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxComposer1.Font = new System.Drawing.Font("Segoe UI", 12.75F);
            this.textBoxComposer1.FontTextPreview = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxComposer1.ForeColor = System.Drawing.Color.Black;
            this.textBoxComposer1.Location = new System.Drawing.Point(36, 177);
            this.textBoxComposer1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxComposer1.MaximumSize = new System.Drawing.Size(298, 40);
            this.textBoxComposer1.MinimumSize = new System.Drawing.Size(298, 40);
            this.textBoxComposer1.Name = "textBoxComposer1";
            this.textBoxComposer1.SelectionStart = 0;
            this.textBoxComposer1.Size = new System.Drawing.Size(298, 40);
            this.textBoxComposer1.TabIndex = 43;
            this.textBoxComposer1.TextInput = "";
            this.textBoxComposer1.TextPreview = "Композитор";
            this.textBoxComposer1.UseSystemPasswordChar = false;
            // 
            // textBoxYear1
            // 
            this.textBoxYear1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxYear1.BackColor = System.Drawing.Color.White;
            this.textBoxYear1.BorderColor = System.Drawing.Color.Black;
            this.textBoxYear1.BorderColorNotActive = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.textBoxYear1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxYear1.Font = new System.Drawing.Font("Segoe UI", 12.75F);
            this.textBoxYear1.FontTextPreview = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxYear1.ForeColor = System.Drawing.Color.Black;
            this.textBoxYear1.Location = new System.Drawing.Point(36, 232);
            this.textBoxYear1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxYear1.MaximumSize = new System.Drawing.Size(298, 40);
            this.textBoxYear1.MinimumSize = new System.Drawing.Size(298, 40);
            this.textBoxYear1.Name = "textBoxYear1";
            this.textBoxYear1.SelectionStart = 0;
            this.textBoxYear1.Size = new System.Drawing.Size(298, 40);
            this.textBoxYear1.TabIndex = 44;
            this.textBoxYear1.TextInput = "";
            this.textBoxYear1.TextPreview = "Год публикации";
            this.textBoxYear1.UseSystemPasswordChar = false;
            // 
            // labelType1
            // 
            this.labelType1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelType1.AutoSize = true;
            this.labelType1.BackColor = System.Drawing.Color.Transparent;
            this.labelType1.Font = new System.Drawing.Font("Magnolia Script", 18F, System.Drawing.FontStyle.Bold);
            this.labelType1.ForeColor = System.Drawing.Color.Black;
            this.labelType1.Location = new System.Drawing.Point(89, 283);
            this.labelType1.MaximumSize = new System.Drawing.Size(175, 34);
            this.labelType1.MinimumSize = new System.Drawing.Size(175, 34);
            this.labelType1.Name = "labelType1";
            this.labelType1.Size = new System.Drawing.Size(175, 34);
            this.labelType1.TabIndex = 41;
            this.labelType1.Text = "Тип носителя";
            // 
            // textBoxName2
            // 
            this.textBoxName2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBoxName2.Font = new System.Drawing.Font("Segoe UI", 12.75F);
            this.textBoxName2.Location = new System.Drawing.Point(369, 443);
            this.textBoxName2.MaximumSize = new System.Drawing.Size(299, 28);
            this.textBoxName2.MinimumSize = new System.Drawing.Size(299, 28);
            this.textBoxName2.Multiline = true;
            this.textBoxName2.Name = "textBoxName2";
            this.textBoxName2.ReadOnly = true;
            this.textBoxName2.Size = new System.Drawing.Size(299, 28);
            this.textBoxName2.TabIndex = 45;
            // 
            // textBoxComposer2
            // 
            this.textBoxComposer2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBoxComposer2.Font = new System.Drawing.Font("Segoe UI", 12.75F);
            this.textBoxComposer2.Location = new System.Drawing.Point(693, 443);
            this.textBoxComposer2.MaximumSize = new System.Drawing.Size(299, 28);
            this.textBoxComposer2.MinimumSize = new System.Drawing.Size(299, 28);
            this.textBoxComposer2.Multiline = true;
            this.textBoxComposer2.Name = "textBoxComposer2";
            this.textBoxComposer2.ReadOnly = true;
            this.textBoxComposer2.Size = new System.Drawing.Size(299, 28);
            this.textBoxComposer2.TabIndex = 46;
            // 
            // textBoxYear2
            // 
            this.textBoxYear2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBoxYear2.Location = new System.Drawing.Point(369, 538);
            this.textBoxYear2.MaximumSize = new System.Drawing.Size(299, 28);
            this.textBoxYear2.MinimumSize = new System.Drawing.Size(299, 28);
            this.textBoxYear2.Multiline = true;
            this.textBoxYear2.Name = "textBoxYear2";
            this.textBoxYear2.ReadOnly = true;
            this.textBoxYear2.Size = new System.Drawing.Size(299, 28);
            this.textBoxYear2.TabIndex = 47;
            // 
            // textBoxDuration
            // 
            this.textBoxDuration.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBoxDuration.Font = new System.Drawing.Font("Segoe UI", 12.75F);
            this.textBoxDuration.Location = new System.Drawing.Point(693, 538);
            this.textBoxDuration.MaximumSize = new System.Drawing.Size(299, 28);
            this.textBoxDuration.MinimumSize = new System.Drawing.Size(299, 28);
            this.textBoxDuration.Multiline = true;
            this.textBoxDuration.Name = "textBoxDuration";
            this.textBoxDuration.ReadOnly = true;
            this.textBoxDuration.Size = new System.Drawing.Size(299, 28);
            this.textBoxDuration.TabIndex = 48;
            // 
            // textBoxType
            // 
            this.textBoxType.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBoxType.Font = new System.Drawing.Font("Segoe UI", 12.75F);
            this.textBoxType.Location = new System.Drawing.Point(368, 622);
            this.textBoxType.MaximumSize = new System.Drawing.Size(299, 28);
            this.textBoxType.MinimumSize = new System.Drawing.Size(299, 28);
            this.textBoxType.Multiline = true;
            this.textBoxType.Name = "textBoxType";
            this.textBoxType.ReadOnly = true;
            this.textBoxType.Size = new System.Drawing.Size(299, 28);
            this.textBoxType.TabIndex = 49;
            // 
            // textBoxMaterial
            // 
            this.textBoxMaterial.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBoxMaterial.Font = new System.Drawing.Font("Segoe UI", 12.75F);
            this.textBoxMaterial.Location = new System.Drawing.Point(693, 622);
            this.textBoxMaterial.MaximumSize = new System.Drawing.Size(299, 28);
            this.textBoxMaterial.MinimumSize = new System.Drawing.Size(299, 28);
            this.textBoxMaterial.Multiline = true;
            this.textBoxMaterial.Name = "textBoxMaterial";
            this.textBoxMaterial.ReadOnly = true;
            this.textBoxMaterial.Size = new System.Drawing.Size(299, 28);
            this.textBoxMaterial.TabIndex = 50;
            // 
            // labelComposer
            // 
            this.labelComposer.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelComposer.AutoSize = true;
            this.labelComposer.Font = new System.Drawing.Font("Magnolia Script", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelComposer.Location = new System.Drawing.Point(753, 402);
            this.labelComposer.MaximumSize = new System.Drawing.Size(204, 34);
            this.labelComposer.MinimumSize = new System.Drawing.Size(204, 27);
            this.labelComposer.Name = "labelComposer";
            this.labelComposer.Size = new System.Drawing.Size(204, 34);
            this.labelComposer.TabIndex = 53;
            this.labelComposer.Text = "Композитор";
            // 
            // labelName
            // 
            this.labelName.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Magnolia Script", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(454, 402);
            this.labelName.MaximumSize = new System.Drawing.Size(175, 34);
            this.labelName.MinimumSize = new System.Drawing.Size(175, 34);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(175, 34);
            this.labelName.TabIndex = 54;
            this.labelName.Text = "Название";
            // 
            // labelYear
            // 
            this.labelYear.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelYear.AutoSize = true;
            this.labelYear.Font = new System.Drawing.Font("Magnolia Script", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelYear.Location = new System.Drawing.Point(428, 495);
            this.labelYear.MaximumSize = new System.Drawing.Size(204, 34);
            this.labelYear.MinimumSize = new System.Drawing.Size(175, 34);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(201, 34);
            this.labelYear.TabIndex = 55;
            this.labelYear.Text = "Год публикации";
            // 
            // labelDuration
            // 
            this.labelDuration.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelDuration.AutoSize = true;
            this.labelDuration.Font = new System.Drawing.Font("Magnolia Script", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDuration.Location = new System.Drawing.Point(743, 495);
            this.labelDuration.MaximumSize = new System.Drawing.Size(204, 34);
            this.labelDuration.MinimumSize = new System.Drawing.Size(204, 27);
            this.labelDuration.Name = "labelDuration";
            this.labelDuration.Size = new System.Drawing.Size(204, 34);
            this.labelDuration.TabIndex = 56;
            this.labelDuration.Text = "Длительность";
            // 
            // labelType2
            // 
            this.labelType2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelType2.AutoSize = true;
            this.labelType2.Font = new System.Drawing.Font("Magnolia Script", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelType2.Location = new System.Drawing.Point(428, 580);
            this.labelType2.MaximumSize = new System.Drawing.Size(204, 34);
            this.labelType2.MinimumSize = new System.Drawing.Size(204, 27);
            this.labelType2.Name = "labelType2";
            this.labelType2.Size = new System.Drawing.Size(204, 34);
            this.labelType2.TabIndex = 57;
            this.labelType2.Text = "Тип носителя";
            // 
            // labelMaterial
            // 
            this.labelMaterial.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelMaterial.AutoSize = true;
            this.labelMaterial.Font = new System.Drawing.Font("Magnolia Script", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaterial.Location = new System.Drawing.Point(771, 580);
            this.labelMaterial.MaximumSize = new System.Drawing.Size(204, 34);
            this.labelMaterial.MinimumSize = new System.Drawing.Size(204, 27);
            this.labelMaterial.Name = "labelMaterial";
            this.labelMaterial.Size = new System.Drawing.Size(204, 34);
            this.labelMaterial.TabIndex = 58;
            this.labelMaterial.Text = "Материал носителя";
            // 
            // toggleMusic
            // 
            this.toggleMusic.BackColor = System.Drawing.Color.White;
            this.toggleMusic.BackColorOFF = System.Drawing.Color.SpringGreen;
            this.toggleMusic.BackColorON = System.Drawing.Color.DarkGray;
            this.toggleMusic.Checked = false;
            this.toggleMusic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.toggleMusic.Font = new System.Drawing.Font("Magnolia Script", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toggleMusic.Location = new System.Drawing.Point(196, 632);
            this.toggleMusic.MaximumSize = new System.Drawing.Size(93, 19);
            this.toggleMusic.Name = "toggleMusic";
            this.toggleMusic.Size = new System.Drawing.Size(83, 19);
            this.toggleMusic.TabIndex = 59;
            this.toggleMusic.Text = "Вкл";
            this.toggleMusic.TextOnChecked = "Выкл";
            this.toggleMusic.CheckedChanged += new yt_DesignUI.ToggleSwitchStyle.OnCheckedChangedHandler(this.toggleSwitchStyle1_CheckedChanged);
            // 
            // labelMusic
            // 
            this.labelMusic.AutoSize = true;
            this.labelMusic.Font = new System.Drawing.Font("Magnolia Script", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMusic.Location = new System.Drawing.Point(80, 623);
            this.labelMusic.MaximumSize = new System.Drawing.Size(115, 34);
            this.labelMusic.MinimumSize = new System.Drawing.Size(115, 34);
            this.labelMusic.Name = "labelMusic";
            this.labelMusic.Size = new System.Drawing.Size(115, 34);
            this.labelMusic.TabIndex = 60;
            this.labelMusic.Text = "Музыка:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 689);
            this.Controls.Add(this.labelMusic);
            this.Controls.Add(this.toggleMusic);
            this.Controls.Add(this.labelMaterial);
            this.Controls.Add(this.labelType2);
            this.Controls.Add(this.labelDuration);
            this.Controls.Add(this.labelYear);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelComposer);
            this.Controls.Add(this.textBoxMaterial);
            this.Controls.Add(this.textBoxType);
            this.Controls.Add(this.textBoxDuration);
            this.Controls.Add(this.textBoxYear2);
            this.Controls.Add(this.textBoxComposer2);
            this.Controls.Add(this.textBoxName2);
            this.Controls.Add(this.textBoxYear1);
            this.Controls.Add(this.textBoxComposer1);
            this.Controls.Add(this.buttonReference);
            this.Controls.Add(this.labelType1);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.labelAvailability);
            this.Controls.Add(this.buttonInfo);
            this.Controls.Add(this.cardQuote3);
            this.Controls.Add(this.cardQuote2);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.listBoxInformation1);
            this.Controls.Add(this.pictureBoxInfo);
            this.Controls.Add(this.labelFilter);
            this.Controls.Add(this.cardQuote1);
            this.Controls.Add(this.toggleAvailability);
            this.Controls.Add(this.textBoxName1);
            this.Controls.Add(this.buttonEditor);
            this.Controls.Add(this.cmbStyle);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Classic ♫ Music";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        
        private TextBoxStyle textBoxName1;
        private Components.FormStyles FormStyle1;
        private System.Windows.Forms.ComboBox cmbStyle;
        private System.Windows.Forms.Timer timer1;
        private Components.RoundingBut roundingButtonsComponent1;
        private Card cardQuote1;
        private ToggleSwitchStyle toggleAvailability;
        private ButtonStyle buttonEditor;
        private TextBoxStyle textBoxSearch;
        private System.Windows.Forms.ListBox listBoxInformation1;
        private System.Windows.Forms.PictureBox pictureBoxInfo;
        private System.Windows.Forms.Label labelFilter;
        private Card cardQuote3;
        private Card cardQuote2;
        private ButtonStyle buttonInfo;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.Label labelAvailability;
        private TextBoxStyle textBoxYear1;
        private TextBoxStyle textBoxComposer1;
        private ButtonStyle buttonReference;
        private System.Windows.Forms.Label labelType1;
        private System.Windows.Forms.Label labelMaterial;
        private System.Windows.Forms.Label labelType2;
        private System.Windows.Forms.Label labelDuration;
        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelComposer;
        private System.Windows.Forms.TextBox textBoxMaterial;
        private System.Windows.Forms.TextBox textBoxType;
        private System.Windows.Forms.TextBox textBoxDuration;
        private System.Windows.Forms.TextBox textBoxYear2;
        private System.Windows.Forms.TextBox textBoxComposer2;
        private System.Windows.Forms.TextBox textBoxName2;
        private System.Windows.Forms.Label labelMusic;
        private ToggleSwitchStyle toggleMusic;
    }
}

