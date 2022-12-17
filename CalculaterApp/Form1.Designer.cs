namespace CalculaterApp
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxnum2 = new System.Windows.Forms.TextBox();
            this.textBoxnum1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.labelresulte = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelresultinfo = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonrest = new System.Windows.Forms.Button();
            this.buttonmult = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(285, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "calculateApp V 1.0";
            // 
            // textBoxnum2
            // 
            this.textBoxnum2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxnum2.Location = new System.Drawing.Point(74, 188);
            this.textBoxnum2.Name = "textBoxnum2";
            this.textBoxnum2.Size = new System.Drawing.Size(200, 26);
            this.textBoxnum2.TabIndex = 1;
            // 
            // textBoxnum1
            // 
            this.textBoxnum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxnum1.Location = new System.Drawing.Point(74, 133);
            this.textBoxnum1.Name = "textBoxnum1";
            this.textBoxnum1.Size = new System.Drawing.Size(200, 26);
            this.textBoxnum1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "number1:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "number2:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(317, 133);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 47);
            this.button1.TabIndex = 5;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.buttonSum_Click);
            // 
            // labelresulte
            // 
            this.labelresulte.AutoSize = true;
            this.labelresulte.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelresulte.Location = new System.Drawing.Point(130, 262);
            this.labelresulte.Name = "labelresulte";
            this.labelresulte.Size = new System.Drawing.Size(36, 25);
            this.labelresulte.TabIndex = 6;
            this.labelresulte.Text = "23";
            this.labelresulte.Click += new System.EventHandler(this.labelresulte_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(10, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "результат: ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // labelresultinfo
            // 
            this.labelresultinfo.AutoSize = true;
            this.labelresultinfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelresultinfo.Location = new System.Drawing.Point(130, 306);
            this.labelresultinfo.Name = "labelresultinfo";
            this.labelresultinfo.Size = new System.Drawing.Size(96, 25);
            this.labelresultinfo.TabIndex = 8;
            this.labelresultinfo.Text = "1 + 1 = 2";
            this.labelresultinfo.Click += new System.EventHandler(this.labelresultinfo_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(391, 135);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(47, 45);
            this.button2.TabIndex = 9;
            this.button2.Text = "-";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonrest
            // 
            this.buttonrest.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonrest.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonrest.Location = new System.Drawing.Point(468, 135);
            this.buttonrest.Name = "buttonrest";
            this.buttonrest.Size = new System.Drawing.Size(47, 45);
            this.buttonrest.TabIndex = 10;
            this.buttonrest.Text = "/";
            this.buttonrest.UseVisualStyleBackColor = false;
            this.buttonrest.Click += new System.EventHandler(this.buttonrest_Click);
            // 
            // buttonmult
            // 
            this.buttonmult.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonmult.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonmult.Location = new System.Drawing.Point(542, 135);
            this.buttonmult.Name = "buttonmult";
            this.buttonmult.Size = new System.Drawing.Size(47, 45);
            this.buttonmult.TabIndex = 11;
            this.buttonmult.Text = "*";
            this.buttonmult.UseVisualStyleBackColor = false;
            this.buttonmult.Click += new System.EventHandler(this.buttonmult_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonmult);
            this.Controls.Add(this.buttonrest);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.labelresultinfo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelresulte);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxnum1);
            this.Controls.Add(this.textBoxnum2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxnum2;
        private System.Windows.Forms.TextBox textBoxnum1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelresulte;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelresultinfo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonrest;
        private System.Windows.Forms.Button buttonmult;
    }
}

