namespace Lab1_WindowsFormsIntro
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
            this.CalculateBTN = new System.Windows.Forms.Button();
            this.CalcIn = new System.Windows.Forms.TextBox();
            this.CalcOut = new System.Windows.Forms.Label();
            this.MouseOverLeft = new System.Windows.Forms.Button();
            this.MouseOverRight = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CalculateBTN
            // 
            this.CalculateBTN.Location = new System.Drawing.Point(74, 40);
            this.CalculateBTN.Name = "CalculateBTN";
            this.CalculateBTN.Size = new System.Drawing.Size(75, 23);
            this.CalculateBTN.TabIndex = 0;
            this.CalculateBTN.Text = "Calculate";
            this.CalculateBTN.UseVisualStyleBackColor = true;
            this.CalculateBTN.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CalculateBTN_MouseClick);
            // 
            // CalcIn
            // 
            this.CalcIn.Location = new System.Drawing.Point(156, 42);
            this.CalcIn.Name = "CalcIn";
            this.CalcIn.Size = new System.Drawing.Size(100, 20);
            this.CalcIn.TabIndex = 1;
            this.CalcIn.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // CalcOut
            // 
            this.CalcOut.AutoSize = true;
            this.CalcOut.Location = new System.Drawing.Point(263, 49);
            this.CalcOut.Name = "CalcOut";
            this.CalcOut.Size = new System.Drawing.Size(13, 13);
            this.CalcOut.TabIndex = 2;
            this.CalcOut.Text = "  ";
            // 
            // MouseOverLeft
            // 
            this.MouseOverLeft.Location = new System.Drawing.Point(156, 104);
            this.MouseOverLeft.Name = "MouseOverLeft";
            this.MouseOverLeft.Size = new System.Drawing.Size(75, 23);
            this.MouseOverLeft.TabIndex = 3;
            this.MouseOverLeft.UseVisualStyleBackColor = true;
            this.MouseOverLeft.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MouseOverLeft_MouseMove);
            // 
            // MouseOverRight
            // 
            this.MouseOverRight.Location = new System.Drawing.Point(266, 103);
            this.MouseOverRight.Name = "MouseOverRight";
            this.MouseOverRight.Size = new System.Drawing.Size(75, 23);
            this.MouseOverRight.TabIndex = 4;
            this.MouseOverRight.UseVisualStyleBackColor = true;
            this.MouseOverRight.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MouseOverRight_MouseMove);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 232);
            this.Controls.Add(this.MouseOverRight);
            this.Controls.Add(this.MouseOverLeft);
            this.Controls.Add(this.CalcOut);
            this.Controls.Add(this.CalcIn);
            this.Controls.Add(this.CalculateBTN);
            this.Name = "Form1";
            this.Text = "Form1";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CalculateBTN;
        private System.Windows.Forms.TextBox CalcIn;
        private System.Windows.Forms.Label CalcOut;
        private System.Windows.Forms.Button MouseOverLeft;
        private System.Windows.Forms.Button MouseOverRight;
    }
}

