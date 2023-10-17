namespace ClassicMusic
{
    partial class Editor3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Editor3));
            this.FormStyle1 = new yt_DesignUI.Components.FormStyles(this.components);
            this.tab1BindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.buttonClose = new yt_DesignUI.ButtonStyle();
            this.buttonUpdate = new yt_DesignUI.ButtonStyle();
            this.buttonBack = new yt_DesignUI.ButtonStyle();
            this.labelTable = new System.Windows.Forms.Label();
            this.tab1DataGridView = new System.Windows.Forms.DataGridView();
            this.buttonFurther = new yt_DesignUI.ButtonStyle();
            this.buttonStyle1 = new yt_DesignUI.ButtonStyle();
            ((System.ComponentModel.ISupportInitialize)(this.tab1BindingNavigator)).BeginInit();
            this.tab1BindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tab1DataGridView)).BeginInit();
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
            // tab1BindingNavigator
            // 
            this.tab1BindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tab1BindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tab1BindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tab1BindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.tab1BindingNavigator.ImageScalingSize = new System.Drawing.Size(25, 25);
            this.tab1BindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.tab1BindingNavigator.Location = new System.Drawing.Point(254, 305);
            this.tab1BindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tab1BindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tab1BindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tab1BindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tab1BindingNavigator.Name = "tab1BindingNavigator";
            this.tab1BindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tab1BindingNavigator.Size = new System.Drawing.Size(299, 32);
            this.tab1BindingNavigator.TabIndex = 69;
            this.tab1BindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 29);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 29);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 29);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 29);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 29);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 32);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 32);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 29);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 29);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 32);
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
            this.buttonClose.Location = new System.Drawing.Point(15, 12);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonClose.MaximumSize = new System.Drawing.Size(155, 51);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.RippleColor = System.Drawing.Color.Black;
            this.buttonClose.RoundingEnable = true;
            this.buttonClose.Size = new System.Drawing.Size(95, 40);
            this.buttonClose.TabIndex = 75;
            this.buttonClose.Text = "Назад";
            this.buttonClose.TextHover = null;
            this.buttonClose.UseDownPressEffectOnClick = true;
            this.buttonClose.UseRippleEffect = true;
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.UseZoomEffectOnHover = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonStyle1_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.Magenta;
            this.buttonUpdate.BackColorAdditional = System.Drawing.Color.Cyan;
            this.buttonUpdate.BackColorGradientEnabled = true;
            this.buttonUpdate.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.buttonUpdate.BorderColor = System.Drawing.Color.Black;
            this.buttonUpdate.BorderColorEnabled = false;
            this.buttonUpdate.BorderColorOnHover = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonUpdate.BorderColorOnHoverEnabled = true;
            this.buttonUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonUpdate.Font = new System.Drawing.Font("Magnolia Script", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.ForeColor = System.Drawing.Color.Black;
            this.buttonUpdate.Location = new System.Drawing.Point(336, 368);
            this.buttonUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonUpdate.MaximumSize = new System.Drawing.Size(155, 51);
            this.buttonUpdate.MinimumSize = new System.Drawing.Size(117, 50);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.RippleColor = System.Drawing.Color.Black;
            this.buttonUpdate.RoundingEnable = true;
            this.buttonUpdate.Size = new System.Drawing.Size(138, 50);
            this.buttonUpdate.TabIndex = 73;
            this.buttonUpdate.Text = "Обновить";
            this.buttonUpdate.TextHover = null;
            this.buttonUpdate.UseDownPressEffectOnClick = true;
            this.buttonUpdate.UseRippleEffect = true;
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.UseZoomEffectOnHover = false;
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
            this.buttonBack.Location = new System.Drawing.Point(264, 368);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonBack.MaximumSize = new System.Drawing.Size(155, 51);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.RippleColor = System.Drawing.Color.Black;
            this.buttonBack.RoundingEnable = true;
            this.buttonBack.Size = new System.Drawing.Size(57, 50);
            this.buttonBack.TabIndex = 72;
            this.buttonBack.Text = "←";
            this.buttonBack.TextHover = null;
            this.buttonBack.UseDownPressEffectOnClick = true;
            this.buttonBack.UseRippleEffect = true;
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.UseZoomEffectOnHover = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // labelTable
            // 
            this.labelTable.AutoSize = true;
            this.labelTable.BackColor = System.Drawing.Color.Transparent;
            this.labelTable.Font = new System.Drawing.Font("Magnolia Script", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTable.Location = new System.Drawing.Point(314, 22);
            this.labelTable.Name = "labelTable";
            this.labelTable.Size = new System.Drawing.Size(145, 38);
            this.labelTable.TabIndex = 71;
            this.labelTable.Text = "Таблица 3";
            // 
            // tab1DataGridView
            // 
            this.tab1DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tab1DataGridView.Location = new System.Drawing.Point(64, 63);
            this.tab1DataGridView.Name = "tab1DataGridView";
            this.tab1DataGridView.Size = new System.Drawing.Size(676, 226);
            this.tab1DataGridView.TabIndex = 70;
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
            this.buttonFurther.Location = new System.Drawing.Point(490, 368);
            this.buttonFurther.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonFurther.MaximumSize = new System.Drawing.Size(155, 51);
            this.buttonFurther.Name = "buttonFurther";
            this.buttonFurther.RippleColor = System.Drawing.Color.Black;
            this.buttonFurther.RoundingEnable = true;
            this.buttonFurther.Size = new System.Drawing.Size(57, 50);
            this.buttonFurther.TabIndex = 74;
            this.buttonFurther.Text = "→";
            this.buttonFurther.TextHover = null;
            this.buttonFurther.UseDownPressEffectOnClick = true;
            this.buttonFurther.UseRippleEffect = true;
            this.buttonFurther.UseVisualStyleBackColor = false;
            this.buttonFurther.UseZoomEffectOnHover = false;
            this.buttonFurther.Click += new System.EventHandler(this.buttonFurther_Click);
            // 
            // buttonStyle1
            // 
            this.buttonStyle1.BackColor = System.Drawing.Color.Magenta;
            this.buttonStyle1.BackColorAdditional = System.Drawing.Color.Cyan;
            this.buttonStyle1.BackColorGradientEnabled = true;
            this.buttonStyle1.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.buttonStyle1.BorderColor = System.Drawing.Color.Black;
            this.buttonStyle1.BorderColorEnabled = false;
            this.buttonStyle1.BorderColorOnHover = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonStyle1.BorderColorOnHoverEnabled = true;
            this.buttonStyle1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonStyle1.Font = new System.Drawing.Font("Magnolia Script", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStyle1.ForeColor = System.Drawing.Color.Black;
            this.buttonStyle1.Location = new System.Drawing.Point(693, 12);
            this.buttonStyle1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonStyle1.MaximumSize = new System.Drawing.Size(155, 51);
            this.buttonStyle1.Name = "buttonStyle1";
            this.buttonStyle1.RippleColor = System.Drawing.Color.Black;
            this.buttonStyle1.RoundingEnable = true;
            this.buttonStyle1.Size = new System.Drawing.Size(95, 40);
            this.buttonStyle1.TabIndex = 76;
            this.buttonStyle1.Text = "Запись";
            this.buttonStyle1.TextHover = null;
            this.buttonStyle1.UseDownPressEffectOnClick = true;
            this.buttonStyle1.UseRippleEffect = true;
            this.buttonStyle1.UseVisualStyleBackColor = false;
            this.buttonStyle1.UseZoomEffectOnHover = false;
            this.buttonStyle1.Click += new System.EventHandler(this.buttonStyle1_Click_1);
            // 
            // Editor3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(800, 456);
            this.Controls.Add(this.buttonStyle1);
            this.Controls.Add(this.tab1BindingNavigator);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.labelTable);
            this.Controls.Add(this.tab1DataGridView);
            this.Controls.Add(this.buttonFurther);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(816, 495);
            this.MinimumSize = new System.Drawing.Size(816, 495);
            this.Name = "Editor3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редактор";
            ((System.ComponentModel.ISupportInitialize)(this.tab1BindingNavigator)).EndInit();
            this.tab1BindingNavigator.ResumeLayout(false);
            this.tab1BindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tab1DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private yt_DesignUI.Components.FormStyles FormStyle1;
        private System.Windows.Forms.BindingNavigator tab1BindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private yt_DesignUI.ButtonStyle buttonClose;
        private yt_DesignUI.ButtonStyle buttonUpdate;
        private yt_DesignUI.ButtonStyle buttonBack;
        private System.Windows.Forms.Label labelTable;
        private System.Windows.Forms.DataGridView tab1DataGridView;
        private yt_DesignUI.ButtonStyle buttonFurther;
        private yt_DesignUI.ButtonStyle buttonStyle1;
    }
}