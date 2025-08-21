namespace RandomEventsSimulation
{
    partial class UserControl_Lab8_3
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.splitContainer_Lab8_3 = new System.Windows.Forms.SplitContainer();
            this.chart_Statistics = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tableLayoutPanel_Main = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel_NumberOfTests = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel_Probabilities = new System.Windows.Forms.TableLayoutPanel();
            this.button_Start = new System.Windows.Forms.Button();
            this.label_NumberOfTests = new System.Windows.Forms.Label();
            this.textBox_NumberOfTests = new System.Windows.Forms.TextBox();
            this.label_Prob1 = new System.Windows.Forms.Label();
            this.label_Prob2 = new System.Windows.Forms.Label();
            this.label_Prob3 = new System.Windows.Forms.Label();
            this.label_Prob4 = new System.Windows.Forms.Label();
            this.label_Prob5 = new System.Windows.Forms.Label();
            this.comboBox_Prob1 = new System.Windows.Forms.ComboBox();
            this.comboBox_Prob2 = new System.Windows.Forms.ComboBox();
            this.comboBox_Prob3 = new System.Windows.Forms.ComboBox();
            this.comboBox_Prob4 = new System.Windows.Forms.ComboBox();
            this.comboBox_Prob5 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_Lab8_3)).BeginInit();
            this.splitContainer_Lab8_3.Panel1.SuspendLayout();
            this.splitContainer_Lab8_3.Panel2.SuspendLayout();
            this.splitContainer_Lab8_3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Statistics)).BeginInit();
            this.tableLayoutPanel_Main.SuspendLayout();
            this.tableLayoutPanel_NumberOfTests.SuspendLayout();
            this.tableLayoutPanel_Probabilities.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer_Lab8_3
            // 
            this.splitContainer_Lab8_3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer_Lab8_3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer_Lab8_3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer_Lab8_3.Name = "splitContainer_Lab8_3";
            // 
            // splitContainer_Lab8_3.Panel1
            // 
            this.splitContainer_Lab8_3.Panel1.Controls.Add(this.tableLayoutPanel_Main);
            // 
            // splitContainer_Lab8_3.Panel2
            // 
            this.splitContainer_Lab8_3.Panel2.Controls.Add(this.chart_Statistics);
            this.splitContainer_Lab8_3.Size = new System.Drawing.Size(960, 400);
            this.splitContainer_Lab8_3.SplitterDistance = 229;
            this.splitContainer_Lab8_3.TabIndex = 0;
            // 
            // chart_Statistics
            // 
            chartArea1.AxisX.Interval = 1D;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea1.AxisX.Title = "Событие";
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            chartArea1.AxisY.Interval = 0.05D;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea1.AxisY.Minimum = 0D;
            chartArea1.AxisY.Title = "pᵢ";
            chartArea1.AxisY.TitleFont = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            chartArea1.Name = "ChartArea";
            this.chart_Statistics.ChartAreas.Add(chartArea1);
            this.chart_Statistics.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend";
            legend1.TitleFont = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chart_Statistics.Legends.Add(legend1);
            this.chart_Statistics.Location = new System.Drawing.Point(0, 0);
            this.chart_Statistics.Name = "chart_Statistics";
            series1.ChartArea = "ChartArea";
            series1.Color = System.Drawing.Color.LightSkyBlue;
            series1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            series1.IsValueShownAsLabel = true;
            series1.LabelFormat = "0.000";
            series1.Legend = "Legend";
            series1.LegendText = "Эмпирическое распределение";
            series1.Name = "Series_Empirical";
            series2.ChartArea = "ChartArea";
            series2.Color = System.Drawing.Color.Coral;
            series2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            series2.IsValueShownAsLabel = true;
            series2.LabelFormat = "0.000";
            series2.Legend = "Legend";
            series2.LegendText = "Теоретическое распределение";
            series2.Name = "Series_Theoretical";
            this.chart_Statistics.Series.Add(series1);
            this.chart_Statistics.Series.Add(series2);
            this.chart_Statistics.Size = new System.Drawing.Size(725, 398);
            this.chart_Statistics.TabIndex = 0;
            this.chart_Statistics.Text = "chart1";
            // 
            // tableLayoutPanel_Main
            // 
            this.tableLayoutPanel_Main.ColumnCount = 1;
            this.tableLayoutPanel_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_Main.Controls.Add(this.tableLayoutPanel_NumberOfTests, 0, 1);
            this.tableLayoutPanel_Main.Controls.Add(this.tableLayoutPanel_Probabilities, 0, 0);
            this.tableLayoutPanel_Main.Controls.Add(this.button_Start, 0, 2);
            this.tableLayoutPanel_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_Main.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel_Main.Name = "tableLayoutPanel_Main";
            this.tableLayoutPanel_Main.RowCount = 3;
            this.tableLayoutPanel_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 78.90411F));
            this.tableLayoutPanel_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.09589F));
            this.tableLayoutPanel_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tableLayoutPanel_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_Main.Size = new System.Drawing.Size(227, 398);
            this.tableLayoutPanel_Main.TabIndex = 0;
            // 
            // tableLayoutPanel_NumberOfTests
            // 
            this.tableLayoutPanel_NumberOfTests.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel_NumberOfTests.ColumnCount = 2;
            this.tableLayoutPanel_NumberOfTests.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.5F));
            this.tableLayoutPanel_NumberOfTests.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.5F));
            this.tableLayoutPanel_NumberOfTests.Controls.Add(this.label_NumberOfTests, 0, 0);
            this.tableLayoutPanel_NumberOfTests.Controls.Add(this.textBox_NumberOfTests, 1, 0);
            this.tableLayoutPanel_NumberOfTests.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_NumberOfTests.Location = new System.Drawing.Point(3, 214);
            this.tableLayoutPanel_NumberOfTests.Name = "tableLayoutPanel_NumberOfTests";
            this.tableLayoutPanel_NumberOfTests.RowCount = 1;
            this.tableLayoutPanel_NumberOfTests.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_NumberOfTests.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_NumberOfTests.Size = new System.Drawing.Size(221, 50);
            this.tableLayoutPanel_NumberOfTests.TabIndex = 0;
            // 
            // tableLayoutPanel_Probabilities
            // 
            this.tableLayoutPanel_Probabilities.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel_Probabilities.ColumnCount = 2;
            this.tableLayoutPanel_Probabilities.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_Probabilities.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_Probabilities.Controls.Add(this.comboBox_Prob5, 1, 4);
            this.tableLayoutPanel_Probabilities.Controls.Add(this.comboBox_Prob4, 1, 3);
            this.tableLayoutPanel_Probabilities.Controls.Add(this.comboBox_Prob3, 1, 2);
            this.tableLayoutPanel_Probabilities.Controls.Add(this.comboBox_Prob2, 1, 1);
            this.tableLayoutPanel_Probabilities.Controls.Add(this.label_Prob2, 0, 1);
            this.tableLayoutPanel_Probabilities.Controls.Add(this.label_Prob1, 0, 0);
            this.tableLayoutPanel_Probabilities.Controls.Add(this.label_Prob3, 0, 2);
            this.tableLayoutPanel_Probabilities.Controls.Add(this.label_Prob4, 0, 3);
            this.tableLayoutPanel_Probabilities.Controls.Add(this.label_Prob5, 0, 4);
            this.tableLayoutPanel_Probabilities.Controls.Add(this.comboBox_Prob1, 1, 0);
            this.tableLayoutPanel_Probabilities.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_Probabilities.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel_Probabilities.Name = "tableLayoutPanel_Probabilities";
            this.tableLayoutPanel_Probabilities.RowCount = 5;
            this.tableLayoutPanel_Probabilities.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel_Probabilities.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel_Probabilities.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel_Probabilities.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel_Probabilities.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel_Probabilities.Size = new System.Drawing.Size(221, 205);
            this.tableLayoutPanel_Probabilities.TabIndex = 1;
            // 
            // button_Start
            // 
            this.button_Start.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_Start.AutoSize = true;
            this.button_Start.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Start.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Start.Location = new System.Drawing.Point(76, 315);
            this.button_Start.Name = "button_Start";
            this.button_Start.Size = new System.Drawing.Size(75, 34);
            this.button_Start.TabIndex = 2;
            this.button_Start.Text = "Старт";
            this.button_Start.UseVisualStyleBackColor = true;
            this.button_Start.Click += new System.EventHandler(this.button_Start_Click);
            // 
            // label_NumberOfTests
            // 
            this.label_NumberOfTests.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_NumberOfTests.AutoSize = true;
            this.label_NumberOfTests.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_NumberOfTests.Location = new System.Drawing.Point(4, 4);
            this.label_NumberOfTests.Name = "label_NumberOfTests";
            this.label_NumberOfTests.Size = new System.Drawing.Size(110, 42);
            this.label_NumberOfTests.TabIndex = 0;
            this.label_NumberOfTests.Text = "Количество испытаний";
            // 
            // textBox_NumberOfTests
            // 
            this.textBox_NumberOfTests.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_NumberOfTests.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_NumberOfTests.Location = new System.Drawing.Point(141, 12);
            this.textBox_NumberOfTests.Name = "textBox_NumberOfTests";
            this.textBox_NumberOfTests.Size = new System.Drawing.Size(76, 26);
            this.textBox_NumberOfTests.TabIndex = 1;
            this.textBox_NumberOfTests.Text = "10";
            // 
            // label_Prob1
            // 
            this.label_Prob1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_Prob1.AutoSize = true;
            this.label_Prob1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Prob1.Location = new System.Drawing.Point(40, 7);
            this.label_Prob1.Name = "label_Prob1";
            this.label_Prob1.Size = new System.Drawing.Size(31, 27);
            this.label_Prob1.TabIndex = 0;
            this.label_Prob1.Text = "p₁";
            // 
            // label_Prob2
            // 
            this.label_Prob2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_Prob2.AutoSize = true;
            this.label_Prob2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Prob2.Location = new System.Drawing.Point(40, 47);
            this.label_Prob2.Name = "label_Prob2";
            this.label_Prob2.Size = new System.Drawing.Size(31, 27);
            this.label_Prob2.TabIndex = 2;
            this.label_Prob2.Text = "p₂";
            // 
            // label_Prob3
            // 
            this.label_Prob3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_Prob3.AutoSize = true;
            this.label_Prob3.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Prob3.Location = new System.Drawing.Point(40, 87);
            this.label_Prob3.Name = "label_Prob3";
            this.label_Prob3.Size = new System.Drawing.Size(31, 27);
            this.label_Prob3.TabIndex = 3;
            this.label_Prob3.Text = "p₃";
            // 
            // label_Prob4
            // 
            this.label_Prob4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_Prob4.AutoSize = true;
            this.label_Prob4.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Prob4.Location = new System.Drawing.Point(40, 127);
            this.label_Prob4.Name = "label_Prob4";
            this.label_Prob4.Size = new System.Drawing.Size(31, 27);
            this.label_Prob4.TabIndex = 4;
            this.label_Prob4.Text = "p₄";
            // 
            // label_Prob5
            // 
            this.label_Prob5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_Prob5.AutoSize = true;
            this.label_Prob5.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Prob5.Location = new System.Drawing.Point(40, 169);
            this.label_Prob5.Name = "label_Prob5";
            this.label_Prob5.Size = new System.Drawing.Size(31, 27);
            this.label_Prob5.TabIndex = 5;
            this.label_Prob5.Text = "p₅";
            // 
            // comboBox_Prob1
            // 
            this.comboBox_Prob1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox_Prob1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_Prob1.FormattingEnabled = true;
            this.comboBox_Prob1.Items.AddRange(new object[] {
            "auto"});
            this.comboBox_Prob1.Location = new System.Drawing.Point(135, 7);
            this.comboBox_Prob1.Name = "comboBox_Prob1";
            this.comboBox_Prob1.Size = new System.Drawing.Size(60, 27);
            this.comboBox_Prob1.TabIndex = 6;
            this.comboBox_Prob1.Text = "auto";
            // 
            // comboBox_Prob2
            // 
            this.comboBox_Prob2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox_Prob2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_Prob2.FormattingEnabled = true;
            this.comboBox_Prob2.Items.AddRange(new object[] {
            "auto"});
            this.comboBox_Prob2.Location = new System.Drawing.Point(135, 47);
            this.comboBox_Prob2.Name = "comboBox_Prob2";
            this.comboBox_Prob2.Size = new System.Drawing.Size(60, 27);
            this.comboBox_Prob2.TabIndex = 7;
            this.comboBox_Prob2.Text = "auto";
            // 
            // comboBox_Prob3
            // 
            this.comboBox_Prob3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox_Prob3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_Prob3.FormattingEnabled = true;
            this.comboBox_Prob3.Items.AddRange(new object[] {
            "auto"});
            this.comboBox_Prob3.Location = new System.Drawing.Point(135, 87);
            this.comboBox_Prob3.Name = "comboBox_Prob3";
            this.comboBox_Prob3.Size = new System.Drawing.Size(60, 27);
            this.comboBox_Prob3.TabIndex = 8;
            this.comboBox_Prob3.Text = "auto";
            // 
            // comboBox_Prob4
            // 
            this.comboBox_Prob4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox_Prob4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_Prob4.FormattingEnabled = true;
            this.comboBox_Prob4.Items.AddRange(new object[] {
            "auto"});
            this.comboBox_Prob4.Location = new System.Drawing.Point(135, 127);
            this.comboBox_Prob4.Name = "comboBox_Prob4";
            this.comboBox_Prob4.Size = new System.Drawing.Size(60, 27);
            this.comboBox_Prob4.TabIndex = 9;
            this.comboBox_Prob4.Text = "auto";
            // 
            // comboBox_Prob5
            // 
            this.comboBox_Prob5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox_Prob5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_Prob5.FormattingEnabled = true;
            this.comboBox_Prob5.Items.AddRange(new object[] {
            "auto"});
            this.comboBox_Prob5.Location = new System.Drawing.Point(135, 169);
            this.comboBox_Prob5.Name = "comboBox_Prob5";
            this.comboBox_Prob5.Size = new System.Drawing.Size(60, 27);
            this.comboBox_Prob5.TabIndex = 10;
            this.comboBox_Prob5.Text = "auto";
            // 
            // UserControl_Lab8_3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer_Lab8_3);
            this.MaximumSize = new System.Drawing.Size(960, 400);
            this.MinimumSize = new System.Drawing.Size(960, 400);
            this.Name = "UserControl_Lab8_3";
            this.Size = new System.Drawing.Size(960, 400);
            this.splitContainer_Lab8_3.Panel1.ResumeLayout(false);
            this.splitContainer_Lab8_3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_Lab8_3)).EndInit();
            this.splitContainer_Lab8_3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart_Statistics)).EndInit();
            this.tableLayoutPanel_Main.ResumeLayout(false);
            this.tableLayoutPanel_Main.PerformLayout();
            this.tableLayoutPanel_NumberOfTests.ResumeLayout(false);
            this.tableLayoutPanel_NumberOfTests.PerformLayout();
            this.tableLayoutPanel_Probabilities.ResumeLayout(false);
            this.tableLayoutPanel_Probabilities.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer_Lab8_3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_Statistics;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Main;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_NumberOfTests;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Probabilities;
        private System.Windows.Forms.Button button_Start;
        private System.Windows.Forms.Label label_NumberOfTests;
        private System.Windows.Forms.TextBox textBox_NumberOfTests;
        private System.Windows.Forms.Label label_Prob1;
        private System.Windows.Forms.Label label_Prob2;
        private System.Windows.Forms.Label label_Prob3;
        private System.Windows.Forms.Label label_Prob4;
        private System.Windows.Forms.Label label_Prob5;
        private System.Windows.Forms.ComboBox comboBox_Prob1;
        private System.Windows.Forms.ComboBox comboBox_Prob5;
        private System.Windows.Forms.ComboBox comboBox_Prob4;
        private System.Windows.Forms.ComboBox comboBox_Prob3;
        private System.Windows.Forms.ComboBox comboBox_Prob2;
    }
}
