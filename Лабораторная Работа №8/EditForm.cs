using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Лабораторная_Работа__8
{
    public partial class EditForm : System.Windows.Forms.Form
    {
        public EditForm()
        {
            InitializeComponent();
        }

        public EditForm(AverageTemp averageTemp)
        {
            InitializeComponent();
            txtDayNumber.Text = averageTemp.NumDay.ToString();
            txtTemperature.Text = averageTemp.Temperature.ToString();

        }

        public AverageTemp AverageTemp
        {
            get
            {
                return new AverageTemp(int.Parse(txtDayNumber.Text), double.Parse(txtTemperature.Text));
            }

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int dayNumber = 0;
            double temperature = 0;

            if (!int.TryParse(txtDayNumber.Text, out dayNumber))
            {
                MessageBox.Show("Номер дня должен быть целым числом. Повторите ввод.", "Некорректный ввод", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (!double.TryParse(txtTemperature.Text, out temperature))
            {
                MessageBox.Show("Температура должена быть вещественным числом. Повторите ввод.", "Некорректный ввод", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
