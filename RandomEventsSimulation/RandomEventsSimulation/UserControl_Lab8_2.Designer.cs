namespace RandomEventsSimulation
{
    partial class UserControl_Lab8_2
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
            this.tableLayoutPanel_Lab8_2 = new System.Windows.Forms.TableLayoutPanel();
            this.label_NoName = new System.Windows.Forms.Label();
            this.panel_Lab8_2 = new System.Windows.Forms.Panel();
            this.label_Answer = new System.Windows.Forms.Label();
            this.tableLayoutPanel_Lab8_2.SuspendLayout();
            this.panel_Lab8_2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel_Lab8_2
            // 
            this.tableLayoutPanel_Lab8_2.ColumnCount = 1;
            this.tableLayoutPanel_Lab8_2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_Lab8_2.Controls.Add(this.label_NoName, 0, 0);
            this.tableLayoutPanel_Lab8_2.Controls.Add(this.panel_Lab8_2, 0, 1);
            this.tableLayoutPanel_Lab8_2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_Lab8_2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel_Lab8_2.Name = "tableLayoutPanel_Lab8_2";
            this.tableLayoutPanel_Lab8_2.RowCount = 2;
            this.tableLayoutPanel_Lab8_2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.74074F));
            this.tableLayoutPanel_Lab8_2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.25926F));
            this.tableLayoutPanel_Lab8_2.Size = new System.Drawing.Size(960, 540);
            this.tableLayoutPanel_Lab8_2.TabIndex = 0;
            // 
            // label_NoName
            // 
            this.label_NoName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_NoName.AutoSize = true;
            this.label_NoName.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_NoName.Location = new System.Drawing.Point(312, 7);
            this.label_NoName.Name = "label_NoName";
            this.label_NoName.Size = new System.Drawing.Size(336, 43);
            this.label_NoName.TabIndex = 1;
            this.label_NoName.Text = "Задай свой вопрос...";
            // 
            // panel_Lab8_2
            // 
            this.panel_Lab8_2.BackgroundImage = global::RandomEventsSimulation.Properties.Resources.magic_ball_8;
            this.panel_Lab8_2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel_Lab8_2.Controls.Add(this.label_Answer);
            this.panel_Lab8_2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Lab8_2.Location = new System.Drawing.Point(3, 60);
            this.panel_Lab8_2.Name = "panel_Lab8_2";
            this.panel_Lab8_2.Size = new System.Drawing.Size(954, 477);
            this.panel_Lab8_2.TabIndex = 2;
            // 
            // label_Answer
            // 
            this.label_Answer.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Answer.ForeColor = System.Drawing.Color.White;
            this.label_Answer.Location = new System.Drawing.Point(287, 210);
            this.label_Answer.MaximumSize = new System.Drawing.Size(80, 0);
            this.label_Answer.MinimumSize = new System.Drawing.Size(10, 40);
            this.label_Answer.Name = "label_Answer";
            this.label_Answer.Size = new System.Drawing.Size(70, 40);
            this.label_Answer.TabIndex = 0;
            this.label_Answer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_Answer.Click += new System.EventHandler(this.label_Answer_Click);
            // 
            // UserControl_Lab8_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel_Lab8_2);
            this.MinimumSize = new System.Drawing.Size(960, 540);
            this.Name = "UserControl_Lab8_2";
            this.Size = new System.Drawing.Size(960, 540);
            this.tableLayoutPanel_Lab8_2.ResumeLayout(false);
            this.tableLayoutPanel_Lab8_2.PerformLayout();
            this.panel_Lab8_2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Lab8_2;
        private System.Windows.Forms.Label label_NoName;
        private System.Windows.Forms.Panel panel_Lab8_2;
        private System.Windows.Forms.Label label_Answer;
    }
}
