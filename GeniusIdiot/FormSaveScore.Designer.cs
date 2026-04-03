namespace GeniusIdiot
{
    partial class FormSaveScore
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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSaveScore = new System.Windows.Forms.Button();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите имя для сохранения результатов";
            // 
            // buttonSaveScore
            // 
            this.buttonSaveScore.Location = new System.Drawing.Point(85, 122);
            this.buttonSaveScore.Name = "buttonSaveScore";
            this.buttonSaveScore.Size = new System.Drawing.Size(218, 23);
            this.buttonSaveScore.TabIndex = 1;
            this.buttonSaveScore.Text = "Сохранить результат";
            this.buttonSaveScore.UseVisualStyleBackColor = true;
            this.buttonSaveScore.Click += new System.EventHandler(this.buttonSaveScore_Click);
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Location = new System.Drawing.Point(85, 79);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(218, 20);
            this.textBoxUserName.TabIndex = 2;
            // 
            // FormSaveScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 214);
            this.Controls.Add(this.textBoxUserName);
            this.Controls.Add(this.buttonSaveScore);
            this.Controls.Add(this.label1);
            this.Name = "FormSaveScore";
            this.Text = "FormSaveScore";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSaveScore;
        private System.Windows.Forms.TextBox textBoxUserName;
    }
}