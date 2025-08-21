using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomEventsSimulation
{
    public partial class UserControl_Lab8_1 : UserControl
    {
        public UserControl_Lab8_1()
        {
            InitializeComponent();
        }

        private Random random = new Random(); // seed

        private void button_Prediction_Click(object sender, EventArgs e)
        {
            double prob_A = 0.5;
            double alpha = random.NextDouble();

            if (alpha < prob_A)
            {
                label_Answer.Text = "ДА :(";
                label_Answer.BackColor = Color.IndianRed;
            }
            else
            {
                label_Answer.Text = "НЕТ!";
                label_Answer.BackColor = Color.PaleGreen;
            }
        }
    }
}
