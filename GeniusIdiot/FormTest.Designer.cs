namespace GeniusIdiot
{
    partial class FormTest
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
            this.textBoxUserAnswer = new System.Windows.Forms.TextBox();
            this.buttonCheckUserAnswer = new System.Windows.Forms.Button();
            this.labelNumberQuestion = new System.Windows.Forms.Label();
            this.labelQuestion = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxUserAnswer
            // 
            this.textBoxUserAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxUserAnswer.Location = new System.Drawing.Point(36, 163);
            this.textBoxUserAnswer.Name = "textBoxUserAnswer";
            this.textBoxUserAnswer.Size = new System.Drawing.Size(262, 38);
            this.textBoxUserAnswer.TabIndex = 1;
            // 
            // buttonCheckUserAnswer
            // 
            this.buttonCheckUserAnswer.Location = new System.Drawing.Point(36, 220);
            this.buttonCheckUserAnswer.Name = "buttonCheckUserAnswer";
            this.buttonCheckUserAnswer.Size = new System.Drawing.Size(262, 23);
            this.buttonCheckUserAnswer.TabIndex = 2;
            this.buttonCheckUserAnswer.Text = "Проверить";
            this.buttonCheckUserAnswer.UseVisualStyleBackColor = true;
            this.buttonCheckUserAnswer.Click += new System.EventHandler(this.buttonCheckUserAnswer_Click);
            // 
            // labelNumberQuestion
            // 
            this.labelNumberQuestion.AutoSize = true;
            this.labelNumberQuestion.Location = new System.Drawing.Point(33, 35);
            this.labelNumberQuestion.Name = "labelNumberQuestion";
            this.labelNumberQuestion.Size = new System.Drawing.Size(35, 13);
            this.labelNumberQuestion.TabIndex = 3;
            this.labelNumberQuestion.Text = "label2";
            // 
            // labelQuestion
            // 
            this.labelQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelQuestion.Location = new System.Drawing.Point(36, 62);
            this.labelQuestion.Multiline = true;
            this.labelQuestion.Name = "labelQuestion";
            this.labelQuestion.ReadOnly = true;
            this.labelQuestion.Size = new System.Drawing.Size(423, 77);
            this.labelQuestion.TabIndex = 4;
            // 
            // FormTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 275);
            this.Controls.Add(this.labelQuestion);
            this.Controls.Add(this.labelNumberQuestion);
            this.Controls.Add(this.buttonCheckUserAnswer);
            this.Controls.Add(this.textBoxUserAnswer);
            this.Name = "FormTest";
            this.Text = "Тест ГЕНИЙ - ИДИОТ";
            this.Load += new System.EventHandler(this.FormTest_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxUserAnswer;
        private System.Windows.Forms.Button buttonCheckUserAnswer;
        private System.Windows.Forms.Label labelNumberQuestion;
        private System.Windows.Forms.TextBox labelQuestion;
    }
}

