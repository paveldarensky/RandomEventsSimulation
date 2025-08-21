namespace RandomEventsSimulation
{
    partial class UserControl_Lab8_1
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_Prediction = new System.Windows.Forms.Button();
            this.label_Question = new System.Windows.Forms.Label();
            this.label_Answer = new System.Windows.Forms.Label();
            this.tableLayoutPanel_Lab8_1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel_Lab8_1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_Prediction
            // 
            this.button_Prediction.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_Prediction.AutoSize = true;
            this.button_Prediction.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Prediction.Location = new System.Drawing.Point(236, 97);
            this.button_Prediction.Name = "button_Prediction";
            this.button_Prediction.Size = new System.Drawing.Size(127, 46);
            this.button_Prediction.TabIndex = 1;
            this.button_Prediction.Text = "ОТВЕТ";
            this.button_Prediction.UseVisualStyleBackColor = true;
            this.button_Prediction.Click += new System.EventHandler(this.button_Prediction_Click);
            // 
            // label_Question
            // 
            this.label_Question.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_Question.AutoSize = true;
            this.label_Question.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Question.Location = new System.Drawing.Point(55, 20);
            this.label_Question.Name = "label_Question";
            this.label_Question.Size = new System.Drawing.Size(490, 42);
            this.label_Question.TabIndex = 0;
            this.label_Question.Text = "Пойти сегодня в университет?";
            // 
            // label_Answer
            // 
            this.label_Answer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_Answer.AutoSize = true;
            this.label_Answer.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label_Answer.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Answer.Location = new System.Drawing.Point(225, 208);
            this.label_Answer.MinimumSize = new System.Drawing.Size(150, 40);
            this.label_Answer.Name = "label_Answer";
            this.label_Answer.Size = new System.Drawing.Size(150, 42);
            this.label_Answer.TabIndex = 2;
            this.label_Answer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel_Lab8_1
            // 
            this.tableLayoutPanel_Lab8_1.ColumnCount = 1;
            this.tableLayoutPanel_Lab8_1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_Lab8_1.Controls.Add(this.label_Answer, 0, 2);
            this.tableLayoutPanel_Lab8_1.Controls.Add(this.label_Question, 0, 0);
            this.tableLayoutPanel_Lab8_1.Controls.Add(this.button_Prediction, 0, 1);
            this.tableLayoutPanel_Lab8_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_Lab8_1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel_Lab8_1.Name = "tableLayoutPanel_Lab8_1";
            this.tableLayoutPanel_Lab8_1.RowCount = 3;
            this.tableLayoutPanel_Lab8_1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.58964F));
            this.tableLayoutPanel_Lab8_1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.41036F));
            this.tableLayoutPanel_Lab8_1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 141F));
            this.tableLayoutPanel_Lab8_1.Size = new System.Drawing.Size(600, 300);
            this.tableLayoutPanel_Lab8_1.TabIndex = 3;
            // 
            // UserControl_Lab8_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel_Lab8_1);
            this.MaximumSize = new System.Drawing.Size(600, 300);
            this.MinimumSize = new System.Drawing.Size(600, 300);
            this.Name = "UserControl_Lab8_1";
            this.Size = new System.Drawing.Size(600, 300);
            this.tableLayoutPanel_Lab8_1.ResumeLayout(false);
            this.tableLayoutPanel_Lab8_1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Prediction;
        private System.Windows.Forms.Label label_Question;
        private System.Windows.Forms.Label label_Answer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Lab8_1;
    }
}
