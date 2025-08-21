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
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();

            var lab8_1 = new UserControl_Lab8_1();
            lab8_1.Dock = DockStyle.Fill;
            tabPage_Lab8_1.Controls.Add(lab8_1);
            this.Size = tabControl_Lab8.SelectedTab.Controls[0].Size + new Size(40, 80);

            var lab8_2 = new UserControl_Lab8_2();
            lab8_2.Dock = DockStyle.Fill;
            tabPage_Lab8_2.Controls.Add(lab8_2);

            var lab8_3 = new UserControl_Lab8_3();
            lab8_3.Dock = DockStyle.Fill;
            tabPage_Lab8_3.Controls.Add(lab8_3);

            this.tabControl_Lab8.SelectedIndexChanged += tabControl_Lab8_SelectedIndexChanged;
        }

        private void tabControl_Lab8_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Получить текущую выбранную вкладку
            TabPage selected = tabControl_Lab8.SelectedTab;

            if (selected == tabPage_Lab8_1)
            {
                this.Size = this.Size = tabControl_Lab8.SelectedTab.Controls[0].Size + new Size(40, 80);    // нужный размер для 8.1
            }
            else if (selected == tabPage_Lab8_2)
            {
                this.Size = this.Size = tabControl_Lab8.SelectedTab.Controls[0].Size + new Size(40, 80); // нужный размер для 8.2
            }
            else if (selected == tabPage_Lab8_3)
            {
                this.Size = this.Size = tabControl_Lab8.SelectedTab.Controls[0].Size + new Size(40, 80); // нужный размер для 8.3
            }
        }

    }
}
