using System.Windows.Forms.DataVisualization.Charting;
using Tyuiu.SafronovVE.Sprint6.Task2.V25.Lib;
namespace Tyuiu.SafronovVE.Sprint6.Task2.V25
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        private void buttonDone_MouseEnter(object sender, EventArgs e)
        {
            buttonDone.BackColor = Color.Red;
        }

        private void buttonDone_MouseLeave(object sender, EventArgs e)
        {
            buttonDone.BackColor = Color.Green;
        }

        private void buttonDone_MouseDown(object sender, MouseEventArgs e)
        {
            buttonDone.BackColor = Color.Blue;
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStartStep.Text);
                int stopStep = Convert.ToInt32(textBoxStopStep.Text);

                var mas = ds.GetMassFunction(startStep, stopStep);

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                chartFunction.Titles.Add("График функции");

                chartFunction.ChartAreas[0].AxisX.Title = "Ось X";
                chartFunction.ChartAreas[0].AxisY.Title = "Ось Y";

                chartFunction.Series[0].ChartType = SeriesChartType.Spline;

                for (int i = 0; i < len; i++)
                {
                    dataGridViewFunction.Rows.Add(Convert.ToString(startStep), Convert.ToString(mas[i]));

                    chartFunction.Series[0].Points.AddXY(startStep, mas[i]);

                    startStep++;
                }
            }

            catch
            {
                MessageBox.Show("Введены неверные данные!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнил студент группы ИБКСб-25-1 Сафронов Владимир Евгеньевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
