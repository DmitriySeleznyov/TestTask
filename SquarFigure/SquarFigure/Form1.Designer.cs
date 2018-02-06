namespace SquarFigure
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxAX1 = new System.Windows.Forms.TextBox();
            this.textBoxBX2 = new System.Windows.Forms.TextBox();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.textBoxDelta = new System.Windows.Forms.TextBox();
            this.comboBoxFunc = new System.Windows.Forms.ComboBox();
            this.labelAx1 = new System.Windows.Forms.Label();
            this.labelBx2 = new System.Windows.Forms.Label();
            this.labelFunc = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxByPart = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(118, 76);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxAX1
            // 
            this.textBoxAX1.Location = new System.Drawing.Point(12, 28);
            this.textBoxAX1.Name = "textBoxAX1";
            this.textBoxAX1.Size = new System.Drawing.Size(100, 20);
            this.textBoxAX1.TabIndex = 1;
            this.textBoxAX1.Text = "5";
            // 
            // textBoxBX2
            // 
            this.textBoxBX2.Location = new System.Drawing.Point(118, 28);
            this.textBoxBX2.Name = "textBoxBX2";
            this.textBoxBX2.Size = new System.Drawing.Size(100, 20);
            this.textBoxBX2.TabIndex = 2;
            this.textBoxBX2.Text = "25";
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(266, 130);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(100, 20);
            this.textBoxResult.TabIndex = 3;
            // 
            // textBoxDelta
            // 
            this.textBoxDelta.Location = new System.Drawing.Point(12, 76);
            this.textBoxDelta.Name = "textBoxDelta";
            this.textBoxDelta.Size = new System.Drawing.Size(100, 20);
            this.textBoxDelta.TabIndex = 4;
            this.textBoxDelta.Text = "0,001";
            // 
            // comboBoxFunc
            // 
            this.comboBoxFunc.Cursor = System.Windows.Forms.Cursors.Default;
            this.comboBoxFunc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFunc.Items.AddRange(new object[] {
            "sin(x+5)",
            "cos(2*x)",
            "sqrt(6-x)"});
            this.comboBoxFunc.Location = new System.Drawing.Point(224, 28);
            this.comboBoxFunc.Name = "comboBoxFunc";
            this.comboBoxFunc.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFunc.TabIndex = 5;
            // 
            // labelAx1
            // 
            this.labelAx1.AutoSize = true;
            this.labelAx1.Location = new System.Drawing.Point(13, 9);
            this.labelAx1.Name = "labelAx1";
            this.labelAx1.Size = new System.Drawing.Size(36, 13);
            this.labelAx1.TabIndex = 6;
            this.labelAx1.Text = "a (x1):";
            // 
            // labelBx2
            // 
            this.labelBx2.AutoSize = true;
            this.labelBx2.Location = new System.Drawing.Point(115, 12);
            this.labelBx2.Name = "labelBx2";
            this.labelBx2.Size = new System.Drawing.Size(36, 13);
            this.labelBx2.TabIndex = 7;
            this.labelBx2.Text = "b (x2):";
            // 
            // labelFunc
            // 
            this.labelFunc.AutoSize = true;
            this.labelFunc.Location = new System.Drawing.Point(221, 9);
            this.labelFunc.Name = "labelFunc";
            this.labelFunc.Size = new System.Drawing.Size(51, 13);
            this.labelFunc.TabIndex = 8;
            this.labelFunc.Text = "Function:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Delta:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(263, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Result:";
            // 
            // textBoxByPart
            // 
            this.textBoxByPart.Location = new System.Drawing.Point(351, 28);
            this.textBoxByPart.Name = "textBoxByPart";
            this.textBoxByPart.Size = new System.Drawing.Size(36, 20);
            this.textBoxByPart.TabIndex = 11;
            this.textBoxByPart.Text = "5";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(360, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "n:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 248);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxByPart);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelFunc);
            this.Controls.Add(this.labelBx2);
            this.Controls.Add(this.labelAx1);
            this.Controls.Add(this.comboBoxFunc);
            this.Controls.Add(this.textBoxDelta);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.textBoxBX2);
            this.Controls.Add(this.textBoxAX1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox textBoxAX1;
        public System.Windows.Forms.TextBox textBoxBX2;
        public System.Windows.Forms.TextBox textBoxResult;
        public System.Windows.Forms.TextBox textBoxDelta;
        private System.Windows.Forms.ComboBox comboBoxFunc;
        private System.Windows.Forms.Label labelAx1;
        private System.Windows.Forms.Label labelBx2;
        private System.Windows.Forms.Label labelFunc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox textBoxByPart;
        private System.Windows.Forms.Label label1;
    }
}

