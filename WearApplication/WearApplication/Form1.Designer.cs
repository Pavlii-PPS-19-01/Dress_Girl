namespace WearApplication
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonWork = new System.Windows.Forms.Button();
            this.buttonStudy = new System.Windows.Forms.Button();
            this.buttonDisco = new System.Windows.Forms.Button();
            this.buttonSleep = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonWork
            // 
            this.buttonWork.Location = new System.Drawing.Point(471, 35);
            this.buttonWork.Name = "buttonWork";
            this.buttonWork.Size = new System.Drawing.Size(75, 65);
            this.buttonWork.TabIndex = 0;
            this.buttonWork.Text = "Work";
            this.buttonWork.UseVisualStyleBackColor = true;
            this.buttonWork.Click += new System.EventHandler(this.buttonWork_Click);
            // 
            // buttonStudy
            // 
            this.buttonStudy.Location = new System.Drawing.Point(471, 104);
            this.buttonStudy.Name = "buttonStudy";
            this.buttonStudy.Size = new System.Drawing.Size(75, 65);
            this.buttonStudy.TabIndex = 1;
            this.buttonStudy.Text = "Study";
            this.buttonStudy.UseVisualStyleBackColor = true;
            this.buttonStudy.Click += new System.EventHandler(this.buttonStudy_Click);
            // 
            // buttonDisco
            // 
            this.buttonDisco.Location = new System.Drawing.Point(471, 173);
            this.buttonDisco.Name = "buttonDisco";
            this.buttonDisco.Size = new System.Drawing.Size(75, 65);
            this.buttonDisco.TabIndex = 2;
            this.buttonDisco.Text = "Disco";
            this.buttonDisco.UseVisualStyleBackColor = true;
            this.buttonDisco.Click += new System.EventHandler(this.buttonDisco_Click);
            // 
            // buttonSleep
            // 
            this.buttonSleep.Location = new System.Drawing.Point(471, 242);
            this.buttonSleep.Name = "buttonSleep";
            this.buttonSleep.Size = new System.Drawing.Size(75, 65);
            this.buttonSleep.TabIndex = 3;
            this.buttonSleep.Text = "Sleep";
            this.buttonSleep.UseVisualStyleBackColor = true;
            this.buttonSleep.Click += new System.EventHandler(this.buttonSleep_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(554, 467);
            this.Controls.Add(this.buttonSleep);
            this.Controls.Add(this.buttonDisco);
            this.Controls.Add(this.buttonStudy);
            this.Controls.Add(this.buttonWork);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonWork;
        private System.Windows.Forms.Button buttonStudy;
        private System.Windows.Forms.Button buttonDisco;
        private System.Windows.Forms.Button buttonSleep;
    }
}

