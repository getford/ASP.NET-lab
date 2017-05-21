namespace WFClient
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
            this.numericUpDownSum1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownSum2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownSub1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownSub2 = new System.Windows.Forms.NumericUpDown();
            this.textBoxSum = new System.Windows.Forms.TextBox();
            this.textBoxSub = new System.Windows.Forms.TextBox();
            this.textBoxConcat1 = new System.Windows.Forms.TextBox();
            this.textBoxConcat2 = new System.Windows.Forms.TextBox();
            this.textBoxConcat = new System.Windows.Forms.TextBox();
            this.buttonSum = new System.Windows.Forms.Button();
            this.buttonSub = new System.Windows.Forms.Button();
            this.buttonConcat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSum1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSum2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSub1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSub2)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDownSum1
            // 
            this.numericUpDownSum1.Location = new System.Drawing.Point(12, 12);
            this.numericUpDownSum1.Name = "numericUpDownSum1";
            this.numericUpDownSum1.Size = new System.Drawing.Size(56, 20);
            this.numericUpDownSum1.TabIndex = 0;
            // 
            // numericUpDownSum2
            // 
            this.numericUpDownSum2.Location = new System.Drawing.Point(74, 12);
            this.numericUpDownSum2.Name = "numericUpDownSum2";
            this.numericUpDownSum2.Size = new System.Drawing.Size(56, 20);
            this.numericUpDownSum2.TabIndex = 1;
            // 
            // numericUpDownSub1
            // 
            this.numericUpDownSub1.Location = new System.Drawing.Point(10, 38);
            this.numericUpDownSub1.Name = "numericUpDownSub1";
            this.numericUpDownSub1.Size = new System.Drawing.Size(58, 20);
            this.numericUpDownSub1.TabIndex = 2;
            // 
            // numericUpDownSub2
            // 
            this.numericUpDownSub2.Location = new System.Drawing.Point(74, 38);
            this.numericUpDownSub2.Name = "numericUpDownSub2";
            this.numericUpDownSub2.Size = new System.Drawing.Size(56, 20);
            this.numericUpDownSub2.TabIndex = 3;
            // 
            // textBoxSum
            // 
            this.textBoxSum.Location = new System.Drawing.Point(136, 12);
            this.textBoxSum.Name = "textBoxSum";
            this.textBoxSum.Size = new System.Drawing.Size(100, 20);
            this.textBoxSum.TabIndex = 4;
            // 
            // textBoxSub
            // 
            this.textBoxSub.Location = new System.Drawing.Point(136, 37);
            this.textBoxSub.Name = "textBoxSub";
            this.textBoxSub.Size = new System.Drawing.Size(100, 20);
            this.textBoxSub.TabIndex = 4;
            // 
            // textBoxConcat1
            // 
            this.textBoxConcat1.Location = new System.Drawing.Point(10, 64);
            this.textBoxConcat1.Name = "textBoxConcat1";
            this.textBoxConcat1.Size = new System.Drawing.Size(304, 20);
            this.textBoxConcat1.TabIndex = 4;
            // 
            // textBoxConcat2
            // 
            this.textBoxConcat2.Location = new System.Drawing.Point(10, 90);
            this.textBoxConcat2.Name = "textBoxConcat2";
            this.textBoxConcat2.Size = new System.Drawing.Size(304, 20);
            this.textBoxConcat2.TabIndex = 4;
            // 
            // textBoxConcat
            // 
            this.textBoxConcat.Location = new System.Drawing.Point(10, 116);
            this.textBoxConcat.Name = "textBoxConcat";
            this.textBoxConcat.Size = new System.Drawing.Size(304, 20);
            this.textBoxConcat.TabIndex = 4;
            // 
            // buttonSum
            // 
            this.buttonSum.Location = new System.Drawing.Point(242, 12);
            this.buttonSum.Name = "buttonSum";
            this.buttonSum.Size = new System.Drawing.Size(75, 23);
            this.buttonSum.TabIndex = 5;
            this.buttonSum.Text = "Sum";
            this.buttonSum.UseVisualStyleBackColor = true;
            this.buttonSum.Click += new System.EventHandler(this.buttonSum_Click);
            // 
            // buttonSub
            // 
            this.buttonSub.Location = new System.Drawing.Point(242, 38);
            this.buttonSub.Name = "buttonSub";
            this.buttonSub.Size = new System.Drawing.Size(75, 23);
            this.buttonSub.TabIndex = 5;
            this.buttonSub.Text = "Sub";
            this.buttonSub.UseVisualStyleBackColor = true;
            this.buttonSub.Click += new System.EventHandler(this.buttonSub_Click);
            // 
            // buttonConcat
            // 
            this.buttonConcat.Location = new System.Drawing.Point(10, 142);
            this.buttonConcat.Name = "buttonConcat";
            this.buttonConcat.Size = new System.Drawing.Size(75, 23);
            this.buttonConcat.TabIndex = 5;
            this.buttonConcat.Text = "Concat";
            this.buttonConcat.UseVisualStyleBackColor = true;
            this.buttonConcat.Click += new System.EventHandler(this.buttonConcat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 171);
            this.Controls.Add(this.buttonConcat);
            this.Controls.Add(this.buttonSub);
            this.Controls.Add(this.buttonSum);
            this.Controls.Add(this.textBoxConcat);
            this.Controls.Add(this.textBoxConcat2);
            this.Controls.Add(this.textBoxConcat1);
            this.Controls.Add(this.textBoxSub);
            this.Controls.Add(this.textBoxSum);
            this.Controls.Add(this.numericUpDownSub2);
            this.Controls.Add(this.numericUpDownSub1);
            this.Controls.Add(this.numericUpDownSum2);
            this.Controls.Add(this.numericUpDownSum1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSum1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSum2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSub1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSub2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDownSum1;
        private System.Windows.Forms.NumericUpDown numericUpDownSum2;
        private System.Windows.Forms.NumericUpDown numericUpDownSub1;
        private System.Windows.Forms.NumericUpDown numericUpDownSub2;
        private System.Windows.Forms.TextBox textBoxSum;
        private System.Windows.Forms.TextBox textBoxSub;
        private System.Windows.Forms.TextBox textBoxConcat1;
        private System.Windows.Forms.TextBox textBoxConcat2;
        private System.Windows.Forms.TextBox textBoxConcat;
        private System.Windows.Forms.Button buttonSum;
        private System.Windows.Forms.Button buttonSub;
        private System.Windows.Forms.Button buttonConcat;
    }
}

