using Tyuiu.SafronovVE.Sprint6.Task2.V25.Lib;
namespace Tyuiu.SafronovVE.Sprint6.Task2.V25
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        private void stopValueLabel_Click(object sender, EventArgs e)
        {

        }

        private void completeButton_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(startValueText.Text);
                int stopStep = Convert.ToInt32(stopValueText.Text);

                var mas = ds.GetMassFunction(startStep, stopStep);
                int len = ds.GetMassFunction(startStep, stopStep).Length;

                chartFunction.Titles.Add("График функции");

                chartFunction.ChartAreas[0].AxisX.Title = "Ось X";
                chartFunction.ChartAreas[0].AxisY.Title = "Ось Y";

                for (int i = 0; i < len; i++)
                {
                    resultDataGridView.Rows.Add(Convert.ToString(startStep), Convert.ToString(mas[i]));

                    chartFunction.Series[0].Points.AddXY(startStep, mas[i]);

                    startStep++;
                }
            }

            catch
            {
                MessageBox.Show("Ошибка!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void infoButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Выполнил студент группы ИБКСб-25-1 Сафронов В.Е.", "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
