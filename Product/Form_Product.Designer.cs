namespace Product
{
    partial class Form_Product
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
            this.textBox_search = new System.Windows.Forms.TextBox();
            this.comboBox_Sorting = new System.Windows.Forms.ComboBox();
            this.comboBox_filtration = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel_Product = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel_Pagination = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_search
            // 
            this.textBox_search.Location = new System.Drawing.Point(22, 26);
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(380, 20);
            this.textBox_search.TabIndex = 0;
            this.textBox_search.TextChanged += new System.EventHandler(this.textBox_search_TextChanged);
            // 
            // comboBox_Sorting
            // 
            this.comboBox_Sorting.FormattingEnabled = true;
            this.comboBox_Sorting.Items.AddRange(new object[] {
            "Без сортировки",
            "По возрастанию цены",
            "По убыванию цены",
            "По названию от а до я",
            "По названию от я до а"});
            this.comboBox_Sorting.Location = new System.Drawing.Point(408, 25);
            this.comboBox_Sorting.Name = "comboBox_Sorting";
            this.comboBox_Sorting.Size = new System.Drawing.Size(175, 21);
            this.comboBox_Sorting.TabIndex = 1;
            this.comboBox_Sorting.Text = "Сортировка";
            this.comboBox_Sorting.SelectedIndexChanged += new System.EventHandler(this.comboBox_Sorting_SelectedIndexChanged);
            // 
            // comboBox_filtration
            // 
            this.comboBox_filtration.FormattingEnabled = true;
            this.comboBox_filtration.Items.AddRange(new object[] {
            "Все типы",
            "Кружки",
            "Тарелки",
            "Столовые приборы"});
            this.comboBox_filtration.Location = new System.Drawing.Point(589, 25);
            this.comboBox_filtration.Name = "comboBox_filtration";
            this.comboBox_filtration.Size = new System.Drawing.Size(157, 21);
            this.comboBox_filtration.TabIndex = 2;
            this.comboBox_filtration.Text = "Фильтрация";
            this.comboBox_filtration.SelectedIndexChanged += new System.EventHandler(this.comboBox_filtration_SelectedIndexChanged);
            // 
            // flowLayoutPanel_Product
            // 
            this.flowLayoutPanel_Product.AutoScroll = true;
            this.flowLayoutPanel_Product.Location = new System.Drawing.Point(22, 52);
            this.flowLayoutPanel_Product.Name = "flowLayoutPanel_Product";
            this.flowLayoutPanel_Product.Size = new System.Drawing.Size(766, 394);
            this.flowLayoutPanel_Product.TabIndex = 5;
            // 
            // flowLayoutPanel_Pagination
            // 
            this.flowLayoutPanel_Pagination.Location = new System.Drawing.Point(630, 452);
            this.flowLayoutPanel_Pagination.Name = "flowLayoutPanel_Pagination";
            this.flowLayoutPanel_Pagination.Size = new System.Drawing.Size(158, 31);
            this.flowLayoutPanel_Pagination.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Введите для поиска:";
            // 
            // Form_Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 495);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLayoutPanel_Pagination);
            this.Controls.Add(this.flowLayoutPanel_Product);
            this.Controls.Add(this.comboBox_filtration);
            this.Controls.Add(this.comboBox_Sorting);
            this.Controls.Add(this.textBox_search);
            this.Name = "Form_Product";
            this.Text = "Товары";
            this.Load += new System.EventHandler(this.Form_Product_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_search;
        private System.Windows.Forms.ComboBox comboBox_Sorting;
        private System.Windows.Forms.ComboBox comboBox_filtration;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_Product;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_Pagination;
        private System.Windows.Forms.Label label1;
    }
}

