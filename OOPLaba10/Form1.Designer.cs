namespace OOPLaba10
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
            this.TextRadius = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.regPent = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextRadius
            // 
            this.TextRadius.Location = new System.Drawing.Point(306, 24);
            this.TextRadius.Name = "TextRadius";
            this.TextRadius.Size = new System.Drawing.Size(128, 22);
            this.TextRadius.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(210, 60);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "XML Серіалізація";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.XMLSerialization_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(210, 102);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "XML Десеріалізація";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.XMLDESerialization_Click);
            // 
            // regPent
            // 
            this.regPent.Location = new System.Drawing.Point(306, 143);
            this.regPent.Name = "regPent";
            this.regPent.Size = new System.Drawing.Size(128, 65);
            this.regPent.TabIndex = 4;
            this.regPent.Text = "Створити правильний п\'ятикутник";
            this.regPent.UseVisualStyleBackColor = true;
            this.regPent.Click += new System.EventHandler(this.regPent_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(366, 60);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = ".dat Серіалізація";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.DatSerialization_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(366, 102);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(150, 23);
            this.button4.TabIndex = 6;
            this.button4.Text = ".dat Десеріалізація";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.DatDeSerialization_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.regPent);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TextRadius);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Правильний п\'ятикутник";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextRadius;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button regPent;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

