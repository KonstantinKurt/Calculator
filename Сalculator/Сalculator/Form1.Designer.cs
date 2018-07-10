namespace Сalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button_plus = new System.Windows.Forms.Button();
            this.button_division = new System.Windows.Forms.Button();
            this.button_mult = new System.Windows.Forms.Button();
            this.button_diff = new System.Windows.Forms.Button();
            this.button_res = new System.Windows.Forms.Button();
            this.button_Clear = new System.Windows.Forms.Button();
            this.button_clear_last = new System.Windows.Forms.Button();
            this.button_memory_wright = new System.Windows.Forms.Button();
            this.button_memory_use = new System.Windows.Forms.Button();
            this.button_memory_clear = new System.Windows.Forms.Button();
            this.label_Memory = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Font = new System.Drawing.Font("Modern No. 20", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(89, 23);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(473, 50);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "0";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(45, 379);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 54);
            this.button1.TabIndex = 1;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(249, 225);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 54);
            this.button2.TabIndex = 2;
            this.button2.Text = "9";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(149, 225);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 54);
            this.button3.TabIndex = 3;
            this.button3.Text = "8";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Black;
            this.button4.Location = new System.Drawing.Point(45, 225);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 54);
            this.button4.TabIndex = 4;
            this.button4.Text = "7";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button1_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Black;
            this.button8.Location = new System.Drawing.Point(249, 301);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 54);
            this.button8.TabIndex = 8;
            this.button8.Text = "6";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button1_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Black;
            this.button9.Location = new System.Drawing.Point(149, 301);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 54);
            this.button9.TabIndex = 9;
            this.button9.Text = "5";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button1_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.Black;
            this.button10.Location = new System.Drawing.Point(45, 301);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 54);
            this.button10.TabIndex = 10;
            this.button10.Text = "4";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button1_Click);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.Black;
            this.button11.Location = new System.Drawing.Point(249, 377);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(75, 54);
            this.button11.TabIndex = 11;
            this.button11.Text = "3";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button1_Click);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.Black;
            this.button12.Location = new System.Drawing.Point(149, 379);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(75, 54);
            this.button12.TabIndex = 12;
            this.button12.Text = "2";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.button1_Click);
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.Black;
            this.button13.Location = new System.Drawing.Point(149, 448);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(75, 54);
            this.button13.TabIndex = 13;
            this.button13.Text = "0";
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.button1_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(249, 448);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 54);
            this.button5.TabIndex = 14;
            this.button5.Text = ",";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button_plus
            // 
            this.button_plus.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button_plus.Font = new System.Drawing.Font("Arial Narrow", 39F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_plus.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_plus.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_plus.Location = new System.Drawing.Point(349, 225);
            this.button_plus.Name = "button_plus";
            this.button_plus.Size = new System.Drawing.Size(105, 95);
            this.button_plus.TabIndex = 15;
            this.button_plus.Text = "+";
            this.button_plus.UseVisualStyleBackColor = false;
            this.button_plus.Click += new System.EventHandler(this.button_plus_Click);
            // 
            // button_division
            // 
            this.button_division.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button_division.Font = new System.Drawing.Font("Arial Narrow", 39F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_division.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_division.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_division.Location = new System.Drawing.Point(473, 326);
            this.button_division.Name = "button_division";
            this.button_division.Size = new System.Drawing.Size(105, 95);
            this.button_division.TabIndex = 16;
            this.button_division.Text = "/";
            this.button_division.UseVisualStyleBackColor = false;
            this.button_division.Click += new System.EventHandler(this.button_division_Click);
            // 
            // button_mult
            // 
            this.button_mult.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button_mult.Font = new System.Drawing.Font("Arial Narrow", 39F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_mult.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_mult.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_mult.Location = new System.Drawing.Point(349, 326);
            this.button_mult.Name = "button_mult";
            this.button_mult.Size = new System.Drawing.Size(105, 95);
            this.button_mult.TabIndex = 17;
            this.button_mult.Text = "*";
            this.button_mult.UseVisualStyleBackColor = false;
            this.button_mult.Click += new System.EventHandler(this.button_mult_Click);
            // 
            // button_diff
            // 
            this.button_diff.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button_diff.Font = new System.Drawing.Font("Arial Narrow", 39F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_diff.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_diff.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_diff.Location = new System.Drawing.Point(473, 225);
            this.button_diff.Name = "button_diff";
            this.button_diff.Size = new System.Drawing.Size(105, 95);
            this.button_diff.TabIndex = 18;
            this.button_diff.Text = "-";
            this.button_diff.UseVisualStyleBackColor = false;
            this.button_diff.Click += new System.EventHandler(this.button_diff_Click);
            // 
            // button_res
            // 
            this.button_res.Font = new System.Drawing.Font("Arial Narrow", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_res.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button_res.Location = new System.Drawing.Point(349, 448);
            this.button_res.Name = "button_res";
            this.button_res.Size = new System.Drawing.Size(229, 76);
            this.button_res.TabIndex = 19;
            this.button_res.Text = "=";
            this.button_res.UseVisualStyleBackColor = true;
            this.button_res.Click += new System.EventHandler(this.button_res_Click);
            // 
            // button_Clear
            // 
            this.button_Clear.BackColor = System.Drawing.Color.DarkRed;
            this.button_Clear.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.button_Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Clear.Location = new System.Drawing.Point(447, 139);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(131, 55);
            this.button_Clear.TabIndex = 20;
            this.button_Clear.Text = "Clear";
            this.button_Clear.UseVisualStyleBackColor = false;
            this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // button_clear_last
            // 
            this.button_clear_last.BackColor = System.Drawing.Color.DarkRed;
            this.button_clear_last.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_clear_last.ForeColor = System.Drawing.Color.White;
            this.button_clear_last.Location = new System.Drawing.Point(349, 139);
            this.button_clear_last.Name = "button_clear_last";
            this.button_clear_last.Size = new System.Drawing.Size(75, 55);
            this.button_clear_last.TabIndex = 21;
            this.button_clear_last.Text = "<--";
            this.button_clear_last.UseVisualStyleBackColor = false;
            this.button_clear_last.Click += new System.EventHandler(this.button_clear_last_Click);
            // 
            // button_memory_wright
            // 
            this.button_memory_wright.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button_memory_wright.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_memory_wright.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_memory_wright.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_memory_wright.Location = new System.Drawing.Point(45, 116);
            this.button_memory_wright.Name = "button_memory_wright";
            this.button_memory_wright.Size = new System.Drawing.Size(81, 78);
            this.button_memory_wright.TabIndex = 23;
            this.button_memory_wright.Text = "MR";
            this.button_memory_wright.UseVisualStyleBackColor = false;
            this.button_memory_wright.Click += new System.EventHandler(this.button_memory_wright_Click);
            // 
            // button_memory_use
            // 
            this.button_memory_use.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button_memory_use.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_memory_use.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_memory_use.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_memory_use.Location = new System.Drawing.Point(243, 116);
            this.button_memory_use.Name = "button_memory_use";
            this.button_memory_use.Size = new System.Drawing.Size(81, 78);
            this.button_memory_use.TabIndex = 24;
            this.button_memory_use.Text = "M+";
            this.button_memory_use.UseVisualStyleBackColor = false;
            this.button_memory_use.Click += new System.EventHandler(this.button_memory_use_Click);
            // 
            // button_memory_clear
            // 
            this.button_memory_clear.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button_memory_clear.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_memory_clear.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_memory_clear.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_memory_clear.Location = new System.Drawing.Point(143, 116);
            this.button_memory_clear.Name = "button_memory_clear";
            this.button_memory_clear.Size = new System.Drawing.Size(81, 78);
            this.button_memory_clear.TabIndex = 25;
            this.button_memory_clear.Text = "MC";
            this.button_memory_clear.UseVisualStyleBackColor = false;
            this.button_memory_clear.Click += new System.EventHandler(this.button_memory_clear_Click);
            // 
            // label_Memory
            // 
            this.label_Memory.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_Memory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Memory.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_Memory.Location = new System.Drawing.Point(97, 34);
            this.label_Memory.Name = "label_Memory";
            this.label_Memory.Size = new System.Drawing.Size(29, 30);
            this.label_Memory.TabIndex = 26;
            this.label_Memory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(590, 536);
            this.Controls.Add(this.label_Memory);
            this.Controls.Add(this.button_memory_clear);
            this.Controls.Add(this.button_memory_use);
            this.Controls.Add(this.button_memory_wright);
            this.Controls.Add(this.button_clear_last);
            this.Controls.Add(this.button_Clear);
            this.Controls.Add(this.button_res);
            this.Controls.Add(this.button_diff);
            this.Controls.Add(this.button_mult);
            this.Controls.Add(this.button_division);
            this.Controls.Add(this.button_plus);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Калькулятор";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button_plus;
        private System.Windows.Forms.Button button_division;
        private System.Windows.Forms.Button button_mult;
        private System.Windows.Forms.Button button_diff;
        private System.Windows.Forms.Button button_res;
        private System.Windows.Forms.Button button_Clear;
        private System.Windows.Forms.Button button_clear_last;
        private System.Windows.Forms.Button button_memory_wright;
        private System.Windows.Forms.Button button_memory_use;
        private System.Windows.Forms.Button button_memory_clear;
        private System.Windows.Forms.Label label_Memory;
    }
}

