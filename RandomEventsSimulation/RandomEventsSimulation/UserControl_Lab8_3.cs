using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace RandomEventsSimulation
{
    public partial class UserControl_Lab8_3 : UserControl
    {
        public UserControl_Lab8_3()
        {
            InitializeComponent();
        }

        private void button_Start_Click(object sender, EventArgs e)
        {
            if (!Validation(out double[] probabilities, out int N))
                return;

            int m = probabilities.Length;
            int[] statistics = new int[m];
            Random rnd = new Random();

            for (int i = 0; i < N; i++)
            {
                double alpha = rnd.NextDouble();
                double a = alpha;
                int k = 0;

                while (a >= probabilities[k])
                {
                    a -= probabilities[k];
                    k++;
                }

                statistics[k]++;
            }

            double[] frequencies = statistics.Select(s => (double)s / N).ToArray();

            DrawChart(probabilities, frequencies);
        }

        private bool Validation(out double[] probabilities, out int numTests)
        {
            probabilities = new double[5];
            numTests = 0;

            // Массив ComboBox’ов
            ComboBox[] comboBoxes = new ComboBox[]
            {
        comboBox_Prob1,
        comboBox_Prob2,
        comboBox_Prob3,
        comboBox_Prob4,
        comboBox_Prob5
            };

            int autoCount = 0;
            double manualSum = 0;

            // Сначала обрабатываем все значения
            for (int i = 0; i < comboBoxes.Length; i++)
            {
                string text = comboBoxes[i].Text.Trim().ToLower();

                if (text == "auto")
                {
                    autoCount++;
                }
                else if (double.TryParse(text.Replace(',', '.'), System.Globalization.NumberStyles.Any,
                         System.Globalization.CultureInfo.InvariantCulture, out double value)
                         && value >= 0 && value <= 1)
                {
                    probabilities[i] = value;
                    manualSum += value;
                }
                else
                {
                    MessageBox.Show($"Некорректное значение в поле A{i + 1}.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            if (manualSum > 1)
            {
                MessageBox.Show("Сумма заданных вероятностей превышает 1.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (autoCount > 0)
            {
                double autoValue = (1.0 - manualSum) / autoCount;
                if (autoValue < 0)
                {
                    MessageBox.Show("Недостаточно вероятности для распределения между 'auto' полями.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                for (int i = 0; i < probabilities.Length; i++)
                {
                    if (comboBoxes[i].Text.Trim().ToLower() == "auto")
                        probabilities[i] = autoValue;
                }
            }
            else
            {
                if (Math.Abs(manualSum - 1.0) > 0.001)
                {
                    MessageBox.Show("Сумма вероятностей должна быть равна 1.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            if (!int.TryParse(textBox_NumberOfTests.Text, out numTests) || numTests <= 0)
            {
                MessageBox.Show("Введите корректное число испытаний.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }


        private void DrawChart(double[] theoretical, double[] empirical)
        {
            chart_Statistics.Series[0].Points.Clear();
            chart_Statistics.Series[1].Points.Clear();

            for (int i = 0; i < theoretical.Length; i++)
            {
                chart_Statistics.Series[1].Points.AddXY($"A{i + 1}", theoretical[i]);
                chart_Statistics.Series[0].Points.AddXY($"A{i + 1}", empirical[i]);
            }
        }

    }
}
