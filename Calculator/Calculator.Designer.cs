namespace Calculator
{
    partial class Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonResult = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.TextBox();
            this.buttonPlus = new System.Windows.Forms.Button();
            this.buttonDivide = new System.Windows.Forms.Button();
            this.buttonMultiply = new System.Windows.Forms.Button();
            this.buttonMinus = new System.Windows.Forms.Button();
            this.history = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.SystemColors.Control;
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClear.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.buttonClear.Location = new System.Drawing.Point(23, 326);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(79, 44);
            this.buttonClear.TabIndex = 10;
            this.buttonClear.TabStop = false;
            this.buttonClear.Text = "СЕ";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // buttonResult
            // 
            this.buttonResult.BackColor = System.Drawing.SystemColors.Control;
            this.buttonResult.Enabled = false;
            this.buttonResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonResult.ForeColor = System.Drawing.Color.Maroon;
            this.buttonResult.Location = new System.Drawing.Point(215, 326);
            this.buttonResult.Name = "buttonResult";
            this.buttonResult.Size = new System.Drawing.Size(79, 44);
            this.buttonResult.TabIndex = 11;
            this.buttonResult.TabStop = false;
            this.buttonResult.Text = "=";
            this.buttonResult.UseVisualStyleBackColor = false;
            this.buttonResult.Click += new System.EventHandler(this.ButtonResult_Click);
            // 
            // result
            // 
            this.result.BackColor = System.Drawing.SystemColors.Control;
            this.result.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.result.ForeColor = System.Drawing.Color.Black;
            this.result.Location = new System.Drawing.Point(27, 82);
            this.result.Name = "result";
            this.result.ReadOnly = true;
            this.result.Size = new System.Drawing.Size(363, 31);
            this.result.TabIndex = 12;
            this.result.TabStop = false;
            this.result.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // buttonPlus
            // 
            this.buttonPlus.BackColor = System.Drawing.SystemColors.Control;
            this.buttonPlus.Enabled = false;
            this.buttonPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPlus.ForeColor = System.Drawing.Color.Maroon;
            this.buttonPlus.Location = new System.Drawing.Point(311, 326);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Size = new System.Drawing.Size(79, 44);
            this.buttonPlus.TabIndex = 17;
            this.buttonPlus.TabStop = false;
            this.buttonPlus.Text = "+";
            this.buttonPlus.UseVisualStyleBackColor = false;
            this.buttonPlus.Click += new System.EventHandler(this.Button_operator);
            // 
            // buttonDivide
            // 
            this.buttonDivide.BackColor = System.Drawing.SystemColors.Control;
            this.buttonDivide.Enabled = false;
            this.buttonDivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDivide.ForeColor = System.Drawing.Color.Maroon;
            this.buttonDivide.Location = new System.Drawing.Point(311, 134);
            this.buttonDivide.Name = "buttonDivide";
            this.buttonDivide.Size = new System.Drawing.Size(79, 44);
            this.buttonDivide.TabIndex = 16;
            this.buttonDivide.TabStop = false;
            this.buttonDivide.Text = "/";
            this.buttonDivide.UseVisualStyleBackColor = false;
            this.buttonDivide.Click += new System.EventHandler(this.Button_operator);
            // 
            // buttonMultiply
            // 
            this.buttonMultiply.BackColor = System.Drawing.SystemColors.Control;
            this.buttonMultiply.Enabled = false;
            this.buttonMultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMultiply.ForeColor = System.Drawing.Color.Maroon;
            this.buttonMultiply.Location = new System.Drawing.Point(311, 198);
            this.buttonMultiply.Name = "buttonMultiply";
            this.buttonMultiply.Size = new System.Drawing.Size(79, 44);
            this.buttonMultiply.TabIndex = 15;
            this.buttonMultiply.TabStop = false;
            this.buttonMultiply.Text = "*";
            this.buttonMultiply.UseVisualStyleBackColor = false;
            this.buttonMultiply.Click += new System.EventHandler(this.Button_operator);
            // 
            // buttonMinus
            // 
            this.buttonMinus.BackColor = System.Drawing.SystemColors.Control;
            this.buttonMinus.Enabled = false;
            this.buttonMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMinus.ForeColor = System.Drawing.Color.Maroon;
            this.buttonMinus.Location = new System.Drawing.Point(311, 262);
            this.buttonMinus.Name = "buttonMinus";
            this.buttonMinus.Size = new System.Drawing.Size(79, 44);
            this.buttonMinus.TabIndex = 14;
            this.buttonMinus.TabStop = false;
            this.buttonMinus.Text = "-";
            this.buttonMinus.UseVisualStyleBackColor = false;
            this.buttonMinus.Click += new System.EventHandler(this.Button_operator);
            // 
            // history
            // 
            this.history.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.history.AutoSize = true;
            this.history.BackColor = System.Drawing.SystemColors.Control;
            this.history.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.history.ForeColor = System.Drawing.Color.Black;
            this.history.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.history.Location = new System.Drawing.Point(334, 45);
            this.history.Name = "history";
            this.history.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.history.Size = new System.Drawing.Size(0, 24);
            this.history.TabIndex = 18;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(27, 262);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 44);
            this.button1.TabIndex = 19;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(121, 262);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 44);
            this.button2.TabIndex = 20;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(215, 262);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 44);
            this.button3.TabIndex = 21;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(27, 198);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 44);
            this.button4.TabIndex = 24;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(121, 198);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 44);
            this.button5.TabIndex = 23;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Button_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(215, 198);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 44);
            this.button6.TabIndex = 22;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Button_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(27, 134);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 44);
            this.button7.TabIndex = 27;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.Button_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(121, 134);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 44);
            this.button8.TabIndex = 26;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.Button_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(215, 134);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 44);
            this.button9.TabIndex = 25;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.Button_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(121, 326);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 44);
            this.button10.TabIndex = 28;
            this.button10.Text = "0";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.Button_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(423, 421);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.history);
            this.Controls.Add(this.buttonPlus);
            this.Controls.Add(this.buttonDivide);
            this.Controls.Add(this.buttonMultiply);
            this.Controls.Add(this.buttonMinus);
            this.Controls.Add(this.result);
            this.Controls.Add(this.buttonResult);
            this.Controls.Add(this.buttonClear);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Calculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonResult;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.Button buttonPlus;
        private System.Windows.Forms.Button buttonDivide;
        private System.Windows.Forms.Button buttonMultiply;
        private System.Windows.Forms.Button buttonMinus;
        private System.Windows.Forms.Label history;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
    }
}