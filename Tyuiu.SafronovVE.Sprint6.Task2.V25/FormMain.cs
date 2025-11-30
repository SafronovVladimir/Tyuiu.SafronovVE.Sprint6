using System.Windows.Forms.DataVisualization.Charting;
using Tyuiu.SafronovVE.Sprint6.Task2.V25.Lib;
namespace Tyuiu.SafronovVE.Sprint6.Task2.V25
{
    public partial class FormMain_SVE : Form
    {
        public FormMain_SVE()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        private void buttonDone_SVE_MouseEnter(object sender, EventArgs e)
        {
            buttonDone_SVE.BackColor = Color.Red;
        }

        private void buttonDone_SVE_MouseLeave(object sender, EventArgs e)
        {
            buttonDone_SVE.BackColor = Color.Green;
        }

        private void buttonDone_SVE_MouseDown(object sender, MouseEventArgs e)
        {
            buttonDone_SVE.BackColor = Color.Blue;
        }

        private void buttonDone_SVE_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStartStep_SVE.Text);
                int stopStep = Convert.ToInt32(textBoxStopStep_SVE.Text);

                var mas = ds.GetMassFunction(startStep, stopStep);
                int len = ds.GetMassFunction(startStep, stopStep).Length;

                chartFunction_SVE.Titles.Add("График функции");

                chartFunction_SVE.ChartAreas[0].AxisX.Title = "Ось X";
                chartFunction_SVE.ChartAreas[0].AxisY.Title = "Ось Y";

                chartFunction_SVE.Series[0].ChartType = SeriesChartType.Spline;

                for (int i = 0; i < len; i++)
                {
                    dataGridViewFunction_SVE.Rows.Add(Convert.ToString(startStep), Convert.ToString(mas[i]));

                    chartFunction_SVE.Series[0].Points.AddXY(startStep, mas[i]);

                    startStep++;
                }
            }

            catch
            {
                MessageBox.Show("Введены неверные данные!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_SVE_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнил студент группы ИБКСб-25-1 Сафронов Владимир Евгеньевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FormMain_SVE_Load(object sender, EventArgs e)
        {
            groupBoxInput_SVE.Select();
        }
    }
}
