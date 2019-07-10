namespace Calculator
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
            this.Input1 = new System.Windows.Forms.TextBox();
            this.Input2 = new System.Windows.Forms.TextBox();
            this.Addition = new System.Windows.Forms.Button();
            this.Subtraction = new System.Windows.Forms.Button();
            this.Multiplication = new System.Windows.Forms.Button();
            this.Division = new System.Windows.Forms.Button();
            this.Result = new System.Windows.Forms.TextBox();
            this.Square_root = new System.Windows.Forms.Button();
            this.Root_extraction = new System.Windows.Forms.Button();
            this.Logarithms = new System.Windows.Forms.Button();
            this.RemainderOfTheDivision = new System.Windows.Forms.Button();
            this.Max = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Input1
            // 
            this.Input1.Location = new System.Drawing.Point(12, 12);
            this.Input1.Name = "Input1";
            this.Input1.Size = new System.Drawing.Size(100, 20);
            this.Input1.TabIndex = 0;
            this.Input1.TextChanged += new System.EventHandler(this.Input1_TextChanged);
            // 
            // Input2
            // 
            this.Input2.Location = new System.Drawing.Point(123, 12);
            this.Input2.Name = "Input2";
            this.Input2.Size = new System.Drawing.Size(100, 20);
            this.Input2.TabIndex = 1;
            // 
            // Addition
            // 
            this.Addition.Location = new System.Drawing.Point(12, 57);
            this.Addition.Name = "Addition";
            this.Addition.Size = new System.Drawing.Size(75, 23);
            this.Addition.TabIndex = 3;
            this.Addition.Text = "Сложение";
            this.Addition.UseVisualStyleBackColor = true;
            this.Addition.Click += new System.EventHandler(this.Calculate);
            // 
            // Subtraction
            // 
            this.Subtraction.Location = new System.Drawing.Point(93, 57);
            this.Subtraction.Name = "Subtraction";
            this.Subtraction.Size = new System.Drawing.Size(75, 23);
            this.Subtraction.TabIndex = 4;
            this.Subtraction.Text = "Вычитание";
            this.Subtraction.UseVisualStyleBackColor = true;
            this.Subtraction.Click += new System.EventHandler(this.Calculate);
            // 
            // Multiplication
            // 
            this.Multiplication.Location = new System.Drawing.Point(12, 86);
            this.Multiplication.Name = "Multiplication";
            this.Multiplication.Size = new System.Drawing.Size(75, 23);
            this.Multiplication.TabIndex = 6;
            this.Multiplication.Text = "Умножение";
            this.Multiplication.UseVisualStyleBackColor = true;
            this.Multiplication.Click += new System.EventHandler(this.Calculate);
            // 
            // Division
            // 
            this.Division.Location = new System.Drawing.Point(93, 86);
            this.Division.Name = "Division";
            this.Division.Size = new System.Drawing.Size(75, 23);
            this.Division.TabIndex = 8;
            this.Division.Text = "Деление";
            this.Division.UseVisualStyleBackColor = true;
            this.Division.Click += new System.EventHandler(this.Calculate);
            // 
            // Result
            // 
            this.Result.Location = new System.Drawing.Point(306, 12);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(100, 20);
            this.Result.TabIndex = 9;
            // 
            // Square_root
            // 
            this.Square_root.Location = new System.Drawing.Point(206, 57);
            this.Square_root.Name = "Square_root";
            this.Square_root.Size = new System.Drawing.Size(127, 23);
            this.Square_root.TabIndex = 10;
            this.Square_root.Text = "Корень квадратный ";
            this.Square_root.UseVisualStyleBackColor = true;
            this.Square_root.Click += new System.EventHandler(this.Calculate_Two);
            // 
            // Root_extraction
            // 
            this.Root_extraction.Location = new System.Drawing.Point(206, 86);
            this.Root_extraction.Name = "Root_extraction";
            this.Root_extraction.Size = new System.Drawing.Size(127, 23);
            this.Root_extraction.TabIndex = 11;
            this.Root_extraction.Text = "Извлечение корня";
            this.Root_extraction.UseVisualStyleBackColor = true;
            this.Root_extraction.Click += new System.EventHandler(this.Calculate_Two);
            // 
            // Logarithms
            // 
            this.Logarithms.Location = new System.Drawing.Point(12, 115);
            this.Logarithms.Name = "Logarithms";
            this.Logarithms.Size = new System.Drawing.Size(75, 23);
            this.Logarithms.TabIndex = 12;
            this.Logarithms.Text = "log";
            this.Logarithms.UseVisualStyleBackColor = true;
            this.Logarithms.Click += new System.EventHandler(this.Calculate);
            // 
            // RemainderOfTheDivision
            // 
            this.RemainderOfTheDivision.Location = new System.Drawing.Point(206, 115);
            this.RemainderOfTheDivision.Name = "RemainderOfTheDivision";
            this.RemainderOfTheDivision.Size = new System.Drawing.Size(127, 23);
            this.RemainderOfTheDivision.TabIndex = 13;
            this.RemainderOfTheDivision.Text = "Остаток от деления";
            this.RemainderOfTheDivision.UseVisualStyleBackColor = true;
            this.RemainderOfTheDivision.Click += new System.EventHandler(this.Calculate);
            // 
            // Max
            // 
            this.Max.Location = new System.Drawing.Point(350, 57);
            this.Max.Name = "Max";
            this.Max.Size = new System.Drawing.Size(97, 23);
            this.Max.TabIndex = 14;
            this.Max.Text = "Максимальное";
            this.Max.UseVisualStyleBackColor = true;
            this.Max.Click += new System.EventHandler(this.Calculate);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 225);
            this.Controls.Add(this.Max);
            this.Controls.Add(this.RemainderOfTheDivision);
            this.Controls.Add(this.Logarithms);
            this.Controls.Add(this.Root_extraction);
            this.Controls.Add(this.Square_root);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.Division);
            this.Controls.Add(this.Multiplication);
            this.Controls.Add(this.Subtraction);
            this.Controls.Add(this.Addition);
            this.Controls.Add(this.Input2);
            this.Controls.Add(this.Input1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Input1;
        private System.Windows.Forms.TextBox Input2;
        private System.Windows.Forms.Button Addition;
        private System.Windows.Forms.Button Subtraction;
        private System.Windows.Forms.Button Multiplication;
        private System.Windows.Forms.Button Division;
        private System.Windows.Forms.TextBox Result;
        private System.Windows.Forms.Button Square_root;
        private System.Windows.Forms.Button Root_extraction;
        private System.Windows.Forms.Button Logarithms;
        private System.Windows.Forms.Button RemainderOfTheDivision;
        private System.Windows.Forms.Button Max;
    }
}

