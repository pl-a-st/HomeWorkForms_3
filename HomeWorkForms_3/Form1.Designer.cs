namespace HomeWorkForms_3
{
    partial class Form1
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
            this.countriesCB = new System.Windows.Forms.ComboBox();
            this.regionsCB = new System.Windows.Forms.ComboBox();
            this.citiesCB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // countriesCB
            // 
            this.countriesCB.FormattingEnabled = true;
            this.countriesCB.Location = new System.Drawing.Point(12, 27);
            this.countriesCB.Name = "countriesCB";
            this.countriesCB.Size = new System.Drawing.Size(163, 21);
            this.countriesCB.TabIndex = 0;
            this.countriesCB.Text = "Выберите страну";
            this.countriesCB.SelectedIndexChanged += new System.EventHandler(this.countriesCB_SelectedIndexChanged);
            // 
            // regionsCB
            // 
            this.regionsCB.FormattingEnabled = true;
            this.regionsCB.Location = new System.Drawing.Point(12, 74);
            this.regionsCB.Name = "regionsCB";
            this.regionsCB.Size = new System.Drawing.Size(163, 21);
            this.regionsCB.TabIndex = 1;
            this.regionsCB.Text = "-";
            this.regionsCB.SelectedIndexChanged += new System.EventHandler(this.regionsCB_SelectedIndexChanged);
            // 
            // citiesCB
            // 
            this.citiesCB.FormattingEnabled = true;
            this.citiesCB.Location = new System.Drawing.Point(12, 123);
            this.citiesCB.Name = "citiesCB";
            this.citiesCB.Size = new System.Drawing.Size(163, 21);
            this.citiesCB.TabIndex = 2;
            this.citiesCB.Text = "-";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Страна";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Регион";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Город";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(204, 172);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.citiesCB);
            this.Controls.Add(this.regionsCB);
            this.Controls.Add(this.countriesCB);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomeWorkForms_3";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox countriesCB;
        private System.Windows.Forms.ComboBox regionsCB;
        private System.Windows.Forms.ComboBox citiesCB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

