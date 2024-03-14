namespace Product
{
    partial class ListItem
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox_product = new System.Windows.Forms.PictureBox();
            this.label_article = new System.Windows.Forms.Label();
            this.label_name_product = new System.Windows.Forms.Label();
            this.label_coust = new System.Windows.Forms.Label();
            this.label_coust_number = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_product)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_product
            // 
            this.pictureBox_product.Image = global::Product.Properties.Resources.no_image_copy;
            this.pictureBox_product.Location = new System.Drawing.Point(15, 12);
            this.pictureBox_product.Name = "pictureBox_product";
            this.pictureBox_product.Size = new System.Drawing.Size(100, 83);
            this.pictureBox_product.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_product.TabIndex = 0;
            this.pictureBox_product.TabStop = false;
            // 
            // label_article
            // 
            this.label_article.AutoSize = true;
            this.label_article.Location = new System.Drawing.Point(169, 41);
            this.label_article.Name = "label_article";
            this.label_article.Size = new System.Drawing.Size(48, 13);
            this.label_article.TabIndex = 1;
            this.label_article.Text = "Артикул";
            // 
            // label_name_product
            // 
            this.label_name_product.AutoSize = true;
            this.label_name_product.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_name_product.Location = new System.Drawing.Point(320, 33);
            this.label_name_product.Name = "label_name_product";
            this.label_name_product.Size = new System.Drawing.Size(232, 24);
            this.label_name_product.TabIndex = 2;
            this.label_name_product.Text = "Наименование продукта";
            // 
            // label_coust
            // 
            this.label_coust.AutoSize = true;
            this.label_coust.Location = new System.Drawing.Point(646, 33);
            this.label_coust.Name = "label_coust";
            this.label_coust.Size = new System.Drawing.Size(62, 13);
            this.label_coust.TabIndex = 3;
            this.label_coust.Text = "Стоимость";
            // 
            // label_coust_number
            // 
            this.label_coust_number.AutoSize = true;
            this.label_coust_number.Location = new System.Drawing.Point(667, 55);
            this.label_coust_number.Name = "label_coust_number";
            this.label_coust_number.Size = new System.Drawing.Size(13, 13);
            this.label_coust_number.TabIndex = 4;
            this.label_coust_number.Text = "0";
            // 
            // ListItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Controls.Add(this.label_coust_number);
            this.Controls.Add(this.label_coust);
            this.Controls.Add(this.label_name_product);
            this.Controls.Add(this.label_article);
            this.Controls.Add(this.pictureBox_product);
            this.Name = "ListItem";
            this.Size = new System.Drawing.Size(725, 108);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_product)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_product;
        private System.Windows.Forms.Label label_article;
        private System.Windows.Forms.Label label_name_product;
        private System.Windows.Forms.Label label_coust;
        private System.Windows.Forms.Label label_coust_number;
    }
}
