namespace BaseProject
{
    partial class Paint
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Clear_button = new System.Windows.Forms.Button();
            this.button_Draw = new System.Windows.Forms.Button();
            this.button_clear_list = new System.Windows.Forms.Button();
            this.FiguresList = new System.Windows.Forms.ListBox();
            this.button_Delete = new System.Windows.Forms.Button();
            this.LB_Contol_gp = new System.Windows.Forms.GroupBox();
            this.button_Reload = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pluginsList = new System.Windows.Forms.ListView();
            this.PluginName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Verificated = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button_serialize = new System.Windows.Forms.Button();
            this.button_deserialize = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_adapter = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.LB_Contol_gp.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(499, 531);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Clear_button
            // 
            this.Clear_button.Location = new System.Drawing.Point(6, 48);
            this.Clear_button.Name = "Clear_button";
            this.Clear_button.Size = new System.Drawing.Size(85, 23);
            this.Clear_button.TabIndex = 7;
            this.Clear_button.Text = "Очистить всё";
            this.Clear_button.UseVisualStyleBackColor = true;
            this.Clear_button.Click += new System.EventHandler(this.Clear_button_Click);
            // 
            // button_Draw
            // 
            this.button_Draw.Location = new System.Drawing.Point(6, 19);
            this.button_Draw.Name = "button_Draw";
            this.button_Draw.Size = new System.Drawing.Size(85, 23);
            this.button_Draw.TabIndex = 11;
            this.button_Draw.Text = "Нарисовать";
            this.button_Draw.UseVisualStyleBackColor = true;
            this.button_Draw.Click += new System.EventHandler(this.button_Draw_Click);
            // 
            // button_clear_list
            // 
            this.button_clear_list.Location = new System.Drawing.Point(6, 48);
            this.button_clear_list.Name = "button_clear_list";
            this.button_clear_list.Size = new System.Drawing.Size(108, 23);
            this.button_clear_list.TabIndex = 12;
            this.button_clear_list.Text = "Очистить список объектов";
            this.button_clear_list.UseVisualStyleBackColor = true;
            this.button_clear_list.Click += new System.EventHandler(this.button_clear_list_Click);
            // 
            // FiguresList
            // 
            this.FiguresList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FiguresList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FiguresList.FormattingEnabled = true;
            this.FiguresList.Location = new System.Drawing.Point(520, 367);
            this.FiguresList.Name = "FiguresList";
            this.FiguresList.Size = new System.Drawing.Size(231, 93);
            this.FiguresList.TabIndex = 13;
            this.FiguresList.DoubleClick += new System.EventHandler(this.FiguresList_DoubleClick);
            // 
            // button_Delete
            // 
            this.button_Delete.Location = new System.Drawing.Point(6, 19);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(108, 23);
            this.button_Delete.TabIndex = 14;
            this.button_Delete.Text = "Удалить объект";
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // LB_Contol_gp
            // 
            this.LB_Contol_gp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LB_Contol_gp.Controls.Add(this.button_clear_list);
            this.LB_Contol_gp.Controls.Add(this.button_Delete);
            this.LB_Contol_gp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LB_Contol_gp.Location = new System.Drawing.Point(632, 466);
            this.LB_Contol_gp.Name = "LB_Contol_gp";
            this.LB_Contol_gp.Size = new System.Drawing.Size(119, 76);
            this.LB_Contol_gp.TabIndex = 16;
            this.LB_Contol_gp.TabStop = false;
            this.LB_Contol_gp.Text = "Фигуры";
            // 
            // button_Reload
            // 
            this.button_Reload.Location = new System.Drawing.Point(6, 19);
            this.button_Reload.Name = "button_Reload";
            this.button_Reload.Size = new System.Drawing.Size(94, 23);
            this.button_Reload.TabIndex = 19;
            this.button_Reload.Text = "Перезагрузить";
            this.button_Reload.UseVisualStyleBackColor = true;
            this.button_Reload.Click += new System.EventHandler(this.button_Reload_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.button_Draw);
            this.groupBox1.Controls.Add(this.Clear_button);
            this.groupBox1.Location = new System.Drawing.Point(521, 466);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(98, 76);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Рисование";
            // 
            // pluginsList
            // 
            this.pluginsList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pluginsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.PluginName,
            this.Verificated});
            this.pluginsList.HideSelection = false;
            this.pluginsList.Location = new System.Drawing.Point(520, 12);
            this.pluginsList.Name = "pluginsList";
            this.pluginsList.Size = new System.Drawing.Size(231, 233);
            this.pluginsList.TabIndex = 22;
            this.pluginsList.UseCompatibleStateImageBehavior = false;
            this.pluginsList.View = System.Windows.Forms.View.Details;
            this.pluginsList.DoubleClick += new System.EventHandler(this.pluginsList_DoubleClick_1);
            // 
            // PluginName
            // 
            this.PluginName.Text = "Имя плагина";
            this.PluginName.Width = 105;
            // 
            // Verificated
            // 
            this.Verificated.Text = "Успешная проверка";
            this.Verificated.Width = 120;
            // 
            // button_serialize
            // 
            this.button_serialize.Location = new System.Drawing.Point(6, 19);
            this.button_serialize.Name = "button_serialize";
            this.button_serialize.Size = new System.Drawing.Size(107, 23);
            this.button_serialize.TabIndex = 24;
            this.button_serialize.Text = "Сериализовать";
            this.button_serialize.UseVisualStyleBackColor = true;
            this.button_serialize.Click += new System.EventHandler(this.button_serialize_Click);
            // 
            // button_deserialize
            // 
            this.button_deserialize.Location = new System.Drawing.Point(6, 48);
            this.button_deserialize.Name = "button_deserialize";
            this.button_deserialize.Size = new System.Drawing.Size(107, 23);
            this.button_deserialize.TabIndex = 25;
            this.button_deserialize.Text = "Десериализовать";
            this.button_deserialize.UseVisualStyleBackColor = true;
            this.button_deserialize.Click += new System.EventHandler(this.button_deserialize_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.button_deserialize);
            this.groupBox2.Controls.Add(this.button_serialize);
            this.groupBox2.Location = new System.Drawing.Point(632, 251);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(119, 78);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Сериализация";
            // 
            // button_adapter
            // 
            this.button_adapter.Location = new System.Drawing.Point(6, 48);
            this.button_adapter.Name = "button_adapter";
            this.button_adapter.Size = new System.Drawing.Size(94, 23);
            this.button_adapter.TabIndex = 27;
            this.button_adapter.Text = "Адаптер";
            this.button_adapter.UseVisualStyleBackColor = true;
            this.button_adapter.Click += new System.EventHandler(this.button_adapter_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.button_Reload);
            this.groupBox3.Controls.Add(this.button_adapter);
            this.groupBox3.Location = new System.Drawing.Point(520, 251);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(106, 110);
            this.groupBox3.TabIndex = 27;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Плагины";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 77);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 23);
            this.button1.TabIndex = 28;
            this.button1.Text = "Архиватор";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button_archive_Click);
            // 
            // Paint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 561);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pluginsList);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.FiguresList);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LB_Contol_gp);
            this.MinimumSize = new System.Drawing.Size(776, 600);
            this.Name = "Paint";
            this.Text = "Графический редактор";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.LB_Contol_gp.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Clear_button;
        private System.Windows.Forms.Button button_Draw;
        private System.Windows.Forms.Button button_clear_list;
        private System.Windows.Forms.ListBox FiguresList;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.GroupBox LB_Contol_gp;
        private System.Windows.Forms.Button button_Reload;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView pluginsList;
        private System.Windows.Forms.ColumnHeader PluginName;
        private System.Windows.Forms.ColumnHeader Verificated;
        private System.Windows.Forms.Button button_serialize;
        private System.Windows.Forms.Button button_deserialize;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button_adapter;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button1;
    }
}

