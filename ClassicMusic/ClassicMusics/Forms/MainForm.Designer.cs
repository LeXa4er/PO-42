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
            this.textBoxArticleS = new yt_DesignUI.TextBoxStyle();
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
            this.textBoxGenreS = new yt_DesignUI.TextBoxStyle();
            this.textBoxYearPubS = new yt_DesignUI.TextBoxStyle();
            this.labelType1 = new System.Windows.Forms.Label();
            this.textBoxArticle = new System.Windows.Forms.TextBox();
            this.textBoxPerformers = new System.Windows.Forms.TextBox();
            this.textBoxGenre = new System.Windows.Forms.TextBox();
            this.textBoxPublisher = new System.Windows.Forms.TextBox();
            this.textBoxPackaging = new System.Windows.Forms.TextBox();
            this.textBoxCost = new System.Windows.Forms.TextBox();
            this.labelPerformers = new System.Windows.Forms.Label();
            this.labelArticle = new System.Windows.Forms.Label();
            this.labelGenre = new System.Windows.Forms.Label();
            this.labelPublisher = new System.Windows.Forms.Label();
            this.labelPackaging = new System.Windows.Forms.Label();
            this.labelCost = new System.Windows.Forms.Label();
            this.toggleMusic = new yt_DesignUI.ToggleSwitchStyle();
            this.labelMusic = new System.Windows.Forms.Label();
            this.buttonClear = new yt_DesignUI.ButtonStyle();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxArticleS
            // 
            this.textBoxArticleS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxArticleS.BackColor = System.Drawing.Color.White;
            this.textBoxArticleS.BorderColor = System.Drawing.Color.Black;
            this.textBoxArticleS.BorderColorNotActive = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.textBoxArticleS.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxArticleS.Font = new System.Drawing.Font("Segoe UI", 12.75F);
            this.textBoxArticleS.FontTextPreview = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxArticleS.ForeColor = System.Drawing.Color.Black;
            this.textBoxArticleS.Location = new System.Drawing.Point(36, 124);
            this.textBoxArticleS.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxArticleS.MaximumSize = new System.Drawing.Size(298, 40);
            this.textBoxArticleS.MinimumSize = new System.Drawing.Size(298, 40);
            this.textBoxArticleS.Name = "textBoxArticleS";
            this.textBoxArticleS.SelectionStart = 0;
            this.textBoxArticleS.Size = new System.Drawing.Size(298, 40);
            this.textBoxArticleS.TabIndex = 8;
            this.textBoxArticleS.TextInput = "";
            this.textBoxArticleS.TextPreview = "Артикул";
            this.textBoxArticleS.UseSystemPasswordChar = false;
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
            this.toggleAvailability.BackColorOFF = System.Drawing.Color.SpringGreen;
            this.toggleAvailability.BackColorON = System.Drawing.Color.DarkGray;
            this.toggleAvailability.Checked = false;
            this.toggleAvailability.Cursor = System.Windows.Forms.Cursors.Hand;
            this.toggleAvailability.Font = new System.Drawing.Font("Magnolia Script", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toggleAvailability.Location = new System.Drawing.Point(216, 373);
            this.toggleAvailability.MaximumSize = new System.Drawing.Size(90, 19);
            this.toggleAvailability.MinimumSize = new System.Drawing.Size(90, 19);
            this.toggleAvailability.Name = "toggleAvailability";
            this.toggleAvailability.Size = new System.Drawing.Size(90, 19);
            this.toggleAvailability.TabIndex = 30;
            this.toggleAvailability.Text = "Есть";
            this.toggleAvailability.TextOnChecked = "Нет";
            this.toggleAvailability.CheckedChanged += new yt_DesignUI.ToggleSwitchStyle.OnCheckedChangedHandler(this.toggleAvailability_CheckedChanged);
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
            this.pictureBoxInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
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
            this.listBoxInformation1.SelectedIndexChanged += new System.EventHandler(this.listBoxInformation1_SelectedIndexChanged);
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
            this.textBoxSearch.Location = new System.Drawing.Point(369, 24);
            this.textBoxSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxSearch.MinimumSize = new System.Drawing.Size(443, 40);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.SelectionStart = 0;
            this.textBoxSearch.Size = new System.Drawing.Size(443, 40);
            this.textBoxSearch.TabIndex = 35;
            this.textBoxSearch.TextInput = "";
            this.textBoxSearch.TextPreview = "Поиск по наименованию товара";
            this.textBoxSearch.UseSystemPasswordChar = false;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
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
            this.comboBoxType.DisplayMember = "0";
            this.comboBoxType.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "Виниловые пластинки",
            "CD-диски"});
            this.comboBoxType.Location = new System.Drawing.Point(36, 320);
            this.comboBoxType.MaximumSize = new System.Drawing.Size(298, 0);
            this.comboBoxType.MinimumSize = new System.Drawing.Size(298, 0);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(298, 31);
            this.comboBoxType.TabIndex = 40;
            this.comboBoxType.SelectedIndexChanged += new System.EventHandler(this.comboBoxType_SelectedIndexChanged);
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
            // textBoxGenreS
            // 
            this.textBoxGenreS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxGenreS.BackColor = System.Drawing.Color.White;
            this.textBoxGenreS.BorderColor = System.Drawing.Color.Black;
            this.textBoxGenreS.BorderColorNotActive = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.textBoxGenreS.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxGenreS.Font = new System.Drawing.Font("Segoe UI", 12.75F);
            this.textBoxGenreS.FontTextPreview = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxGenreS.ForeColor = System.Drawing.Color.Black;
            this.textBoxGenreS.Location = new System.Drawing.Point(36, 177);
            this.textBoxGenreS.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxGenreS.MaximumSize = new System.Drawing.Size(298, 40);
            this.textBoxGenreS.MinimumSize = new System.Drawing.Size(298, 40);
            this.textBoxGenreS.Name = "textBoxGenreS";
            this.textBoxGenreS.SelectionStart = 0;
            this.textBoxGenreS.Size = new System.Drawing.Size(298, 40);
            this.textBoxGenreS.TabIndex = 43;
            this.textBoxGenreS.TextInput = "";
            this.textBoxGenreS.TextPreview = "Жанр";
            this.textBoxGenreS.UseSystemPasswordChar = false;
            // 
            // textBoxYearPubS
            // 
            this.textBoxYearPubS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxYearPubS.BackColor = System.Drawing.Color.White;
            this.textBoxYearPubS.BorderColor = System.Drawing.Color.Black;
            this.textBoxYearPubS.BorderColorNotActive = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.textBoxYearPubS.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxYearPubS.Font = new System.Drawing.Font("Segoe UI", 12.75F);
            this.textBoxYearPubS.FontTextPreview = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxYearPubS.ForeColor = System.Drawing.Color.Black;
            this.textBoxYearPubS.Location = new System.Drawing.Point(36, 232);
            this.textBoxYearPubS.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxYearPubS.MaximumSize = new System.Drawing.Size(298, 40);
            this.textBoxYearPubS.MinimumSize = new System.Drawing.Size(298, 40);
            this.textBoxYearPubS.Name = "textBoxYearPubS";
            this.textBoxYearPubS.SelectionStart = 0;
            this.textBoxYearPubS.Size = new System.Drawing.Size(298, 40);
            this.textBoxYearPubS.TabIndex = 44;
            this.textBoxYearPubS.TextInput = "";
            this.textBoxYearPubS.TextPreview = "Год издания";
            this.textBoxYearPubS.UseSystemPasswordChar = false;
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
            // textBoxArticle
            // 
            this.textBoxArticle.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBoxArticle.Font = new System.Drawing.Font("Segoe UI", 12.75F);
            this.textBoxArticle.Location = new System.Drawing.Point(369, 443);
            this.textBoxArticle.MaximumSize = new System.Drawing.Size(299, 28);
            this.textBoxArticle.MinimumSize = new System.Drawing.Size(299, 28);
            this.textBoxArticle.Multiline = true;
            this.textBoxArticle.Name = "textBoxArticle";
            this.textBoxArticle.ReadOnly = true;
            this.textBoxArticle.Size = new System.Drawing.Size(299, 28);
            this.textBoxArticle.TabIndex = 45;
            // 
            // textBoxPerformers
            // 
            this.textBoxPerformers.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBoxPerformers.Font = new System.Drawing.Font("Segoe UI", 12.75F);
            this.textBoxPerformers.Location = new System.Drawing.Point(693, 443);
            this.textBoxPerformers.MaximumSize = new System.Drawing.Size(299, 28);
            this.textBoxPerformers.MinimumSize = new System.Drawing.Size(299, 28);
            this.textBoxPerformers.Multiline = true;
            this.textBoxPerformers.Name = "textBoxPerformers";
            this.textBoxPerformers.ReadOnly = true;
            this.textBoxPerformers.Size = new System.Drawing.Size(299, 28);
            this.textBoxPerformers.TabIndex = 46;
            // 
            // textBoxGenre
            // 
            this.textBoxGenre.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBoxGenre.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxGenre.Location = new System.Drawing.Point(369, 538);
            this.textBoxGenre.MaximumSize = new System.Drawing.Size(299, 28);
            this.textBoxGenre.MinimumSize = new System.Drawing.Size(299, 28);
            this.textBoxGenre.Multiline = true;
            this.textBoxGenre.Name = "textBoxGenre";
            this.textBoxGenre.ReadOnly = true;
            this.textBoxGenre.Size = new System.Drawing.Size(299, 28);
            this.textBoxGenre.TabIndex = 47;
            // 
            // textBoxPublisher
            // 
            this.textBoxPublisher.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBoxPublisher.Font = new System.Drawing.Font("Segoe UI", 12.75F);
            this.textBoxPublisher.Location = new System.Drawing.Point(693, 538);
            this.textBoxPublisher.MaximumSize = new System.Drawing.Size(299, 28);
            this.textBoxPublisher.MinimumSize = new System.Drawing.Size(299, 28);
            this.textBoxPublisher.Multiline = true;
            this.textBoxPublisher.Name = "textBoxPublisher";
            this.textBoxPublisher.ReadOnly = true;
            this.textBoxPublisher.Size = new System.Drawing.Size(299, 28);
            this.textBoxPublisher.TabIndex = 48;
            // 
            // textBoxPackaging
            // 
            this.textBoxPackaging.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBoxPackaging.Font = new System.Drawing.Font("Segoe UI", 12.75F);
            this.textBoxPackaging.Location = new System.Drawing.Point(368, 622);
            this.textBoxPackaging.MaximumSize = new System.Drawing.Size(299, 28);
            this.textBoxPackaging.MinimumSize = new System.Drawing.Size(299, 28);
            this.textBoxPackaging.Multiline = true;
            this.textBoxPackaging.Name = "textBoxPackaging";
            this.textBoxPackaging.ReadOnly = true;
            this.textBoxPackaging.Size = new System.Drawing.Size(299, 28);
            this.textBoxPackaging.TabIndex = 49;
            // 
            // textBoxCost
            // 
            this.textBoxCost.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBoxCost.Font = new System.Drawing.Font("Segoe UI", 12.75F);
            this.textBoxCost.Location = new System.Drawing.Point(693, 622);
            this.textBoxCost.MaximumSize = new System.Drawing.Size(299, 28);
            this.textBoxCost.MinimumSize = new System.Drawing.Size(299, 28);
            this.textBoxCost.Multiline = true;
            this.textBoxCost.Name = "textBoxCost";
            this.textBoxCost.ReadOnly = true;
            this.textBoxCost.Size = new System.Drawing.Size(299, 28);
            this.textBoxCost.TabIndex = 50;
            // 
            // labelPerformers
            // 
            this.labelPerformers.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelPerformers.AutoSize = true;
            this.labelPerformers.Font = new System.Drawing.Font("Magnolia Script", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPerformers.Location = new System.Drawing.Point(753, 402);
            this.labelPerformers.MaximumSize = new System.Drawing.Size(204, 34);
            this.labelPerformers.MinimumSize = new System.Drawing.Size(204, 27);
            this.labelPerformers.Name = "labelPerformers";
            this.labelPerformers.Size = new System.Drawing.Size(204, 34);
            this.labelPerformers.TabIndex = 53;
            this.labelPerformers.Text = "Исполнители";
            // 
            // labelArticle
            // 
            this.labelArticle.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelArticle.AutoSize = true;
            this.labelArticle.Font = new System.Drawing.Font("Magnolia Script", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelArticle.Location = new System.Drawing.Point(454, 402);
            this.labelArticle.MaximumSize = new System.Drawing.Size(175, 34);
            this.labelArticle.MinimumSize = new System.Drawing.Size(175, 34);
            this.labelArticle.Name = "labelArticle";
            this.labelArticle.Size = new System.Drawing.Size(175, 34);
            this.labelArticle.TabIndex = 54;
            this.labelArticle.Text = "Артикул";
            // 
            // labelGenre
            // 
            this.labelGenre.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelGenre.AutoSize = true;
            this.labelGenre.Font = new System.Drawing.Font("Magnolia Script", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGenre.Location = new System.Drawing.Point(477, 495);
            this.labelGenre.MaximumSize = new System.Drawing.Size(204, 34);
            this.labelGenre.MinimumSize = new System.Drawing.Size(175, 34);
            this.labelGenre.Name = "labelGenre";
            this.labelGenre.Size = new System.Drawing.Size(175, 34);
            this.labelGenre.TabIndex = 55;
            this.labelGenre.Text = "Жанр";
            // 
            // labelPublisher
            // 
            this.labelPublisher.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelPublisher.AutoSize = true;
            this.labelPublisher.Font = new System.Drawing.Font("Magnolia Script", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPublisher.Location = new System.Drawing.Point(771, 495);
            this.labelPublisher.MaximumSize = new System.Drawing.Size(204, 34);
            this.labelPublisher.MinimumSize = new System.Drawing.Size(204, 27);
            this.labelPublisher.Name = "labelPublisher";
            this.labelPublisher.Size = new System.Drawing.Size(204, 34);
            this.labelPublisher.TabIndex = 56;
            this.labelPublisher.Text = "Издатель";
            // 
            // labelPackaging
            // 
            this.labelPackaging.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelPackaging.AutoSize = true;
            this.labelPackaging.Font = new System.Drawing.Font("Magnolia Script", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPackaging.Location = new System.Drawing.Point(454, 580);
            this.labelPackaging.MaximumSize = new System.Drawing.Size(204, 34);
            this.labelPackaging.MinimumSize = new System.Drawing.Size(204, 27);
            this.labelPackaging.Name = "labelPackaging";
            this.labelPackaging.Size = new System.Drawing.Size(204, 34);
            this.labelPackaging.TabIndex = 57;
            this.labelPackaging.Text = "Упаковка";
            // 
            // labelCost
            // 
            this.labelCost.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelCost.AutoSize = true;
            this.labelCost.Font = new System.Drawing.Font("Magnolia Script", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCost.Location = new System.Drawing.Point(771, 580);
            this.labelCost.MaximumSize = new System.Drawing.Size(204, 34);
            this.labelCost.MinimumSize = new System.Drawing.Size(204, 27);
            this.labelCost.Name = "labelCost";
            this.labelCost.Size = new System.Drawing.Size(204, 34);
            this.labelCost.TabIndex = 58;
            this.labelCost.Text = "Стоимость";
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
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.Cyan;
            this.buttonClear.BackColorAdditional = System.Drawing.Color.Magenta;
            this.buttonClear.BackColorGradientEnabled = true;
            this.buttonClear.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.buttonClear.BorderColor = System.Drawing.Color.Black;
            this.buttonClear.BorderColorEnabled = false;
            this.buttonClear.BorderColorOnHover = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonClear.BorderColorOnHoverEnabled = true;
            this.buttonClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClear.Font = new System.Drawing.Font("Magnolia Script", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.ForeColor = System.Drawing.Color.Black;
            this.buttonClear.Location = new System.Drawing.Point(837, 24);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonClear.MaximumSize = new System.Drawing.Size(155, 51);
            this.buttonClear.MinimumSize = new System.Drawing.Size(155, 51);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.RippleColor = System.Drawing.Color.Black;
            this.buttonClear.RoundingEnable = true;
            this.buttonClear.Size = new System.Drawing.Size(155, 51);
            this.buttonClear.TabIndex = 61;
            this.buttonClear.Text = "Сбросить";
            this.buttonClear.TextHover = null;
            this.buttonClear.UseDownPressEffectOnClick = true;
            this.buttonClear.UseRippleEffect = true;
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.UseZoomEffectOnHover = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 689);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.labelMusic);
            this.Controls.Add(this.toggleMusic);
            this.Controls.Add(this.labelCost);
            this.Controls.Add(this.labelPackaging);
            this.Controls.Add(this.labelPublisher);
            this.Controls.Add(this.labelGenre);
            this.Controls.Add(this.labelArticle);
            this.Controls.Add(this.labelPerformers);
            this.Controls.Add(this.textBoxCost);
            this.Controls.Add(this.textBoxPackaging);
            this.Controls.Add(this.textBoxPublisher);
            this.Controls.Add(this.textBoxGenre);
            this.Controls.Add(this.textBoxPerformers);
            this.Controls.Add(this.textBoxArticle);
            this.Controls.Add(this.textBoxYearPubS);
            this.Controls.Add(this.textBoxGenreS);
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
            this.Controls.Add(this.textBoxArticleS);
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
        
        private TextBoxStyle textBoxArticleS;
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
        private TextBoxStyle textBoxYearPubS;
        private TextBoxStyle textBoxGenreS;
        private ButtonStyle buttonReference;
        private System.Windows.Forms.Label labelType1;
        private System.Windows.Forms.Label labelCost;
        private System.Windows.Forms.Label labelPackaging;
        private System.Windows.Forms.Label labelPublisher;
        private System.Windows.Forms.Label labelGenre;
        private System.Windows.Forms.Label labelArticle;
        private System.Windows.Forms.Label labelPerformers;
        private System.Windows.Forms.TextBox textBoxCost;
        private System.Windows.Forms.TextBox textBoxPackaging;
        private System.Windows.Forms.TextBox textBoxPublisher;
        private System.Windows.Forms.TextBox textBoxGenre;
        private System.Windows.Forms.TextBox textBoxPerformers;
        private System.Windows.Forms.TextBox textBoxArticle;
        private System.Windows.Forms.Label labelMusic;
        private ToggleSwitchStyle toggleMusic;
        private ButtonStyle buttonClear;
    }
}

