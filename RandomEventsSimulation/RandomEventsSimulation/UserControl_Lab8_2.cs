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
    public partial class UserControl_Lab8_2 : UserControl
    {
        private readonly string[] responses =
        {
        // "Традиционно шар имеет 20 ответов, которые можно разделить на четыре группы." - взято с https://ru.wikipedia.org/wiki/Magic_8_ball

        // Положительные
        "Бесспорно", "Предрешено", "Никаких сомнений", "Определённо да", "Можешь быть уверен в этом",
        // Нерешительно положительные
        "Мне кажется — «да»", "Вероятнее всего", "Хорошие перспективы", "Знаки говорят — «да»", "Да",
        // Нейтральные
        "Пока не ясно, попробуй снова", "Спроси позже", "Лучше не рассказывать", "Сейчас нельзя предсказать", "Сконцентрируйся и спроси опять",
        // Отрицательные
        "Даже не думай", "Мой ответ — «нет»", "По моим данным — «нет»", "Перспективы не очень хорошие", "Весьма сомнительно"
        };

        private readonly double[] probabilities;
        private readonly Random random = new Random();

        public UserControl_Lab8_2()
        {
            InitializeComponent();

            // Все события равновероятны
            probabilities = Enumerable.Repeat(1.0 / 20, 20).ToArray();
        }

        private void label_Answer_Click(object sender, EventArgs e)
        {
            double alpha = random.NextDouble();
            double A = alpha;

            int k = 0; // первое событие A0 а не A1
            while (k < probabilities.Length)
            {
                A -= probabilities[k];
                if (A <= 0)
                    break;
                k++;
            }

            if (k >= responses.Length) k = responses.Length - 1;

            label_Answer.Text = responses[k];
        }
    }
}
