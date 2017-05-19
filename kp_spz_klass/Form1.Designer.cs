namespace kp_spz_klass
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
            this.GenerateLicenceFile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.EndDate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // GenerateLicenceFile
            // 
            this.GenerateLicenceFile.Location = new System.Drawing.Point(53, 64);
            this.GenerateLicenceFile.Name = "GenerateLicenceFile";
            this.GenerateLicenceFile.Size = new System.Drawing.Size(234, 23);
            this.GenerateLicenceFile.TabIndex = 0;
            this.GenerateLicenceFile.Text = "Сгенирировать файл лицензии";
            this.GenerateLicenceFile.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Дата действия лицензии";
            // 
            // EndDate
            // 
            this.EndDate.Location = new System.Drawing.Point(53, 38);
            this.EndDate.Name = "EndDate";
            this.EndDate.Size = new System.Drawing.Size(200, 20);
            this.EndDate.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 111);
            this.Controls.Add(this.EndDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GenerateLicenceFile);
            this.Name = "Form1";
            this.Text = "d";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GenerateLicenceFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker EndDate;
    }
}

