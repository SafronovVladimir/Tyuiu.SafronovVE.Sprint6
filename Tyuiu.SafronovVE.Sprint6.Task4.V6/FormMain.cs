using System.Windows.Forms.DataVisualization.Charting;
using Tyuiu.SafronovVE.Sprint6.Task4.V6.Lib;
namespace Tyuiu.SafronovVE.Sprint6.Task4.V6
{
    public partial class FormMain_SVE : Form
    {
        public FormMain_SVE()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        private void buttonDone_SVE_Click(object sender, EventArgs e)
        {
            try
            {
                int startValue = Convert.ToInt32(textBoxStartStep_SVE.Text);
                int stopValue = Convert.ToInt32(textBoxStopStep_SVE.Text);

                int len = stopValue - startValue + 1;
                var array = ds.GetMassFunction(startValue, stopValue);

                chartFunction_SVE.ChartAreas[0].AxisX.Title = "Ось X";
                chartFunction_SVE.ChartAreas[0].AxisY.Title = "Ось Y";

                chartFunction_SVE.Series[0].Points.Clear();

                chartFunction_SVE.Series[0].ChartType = SeriesChartType.Spline; ;

                for (int i = 0; i < len; i++)
                {
                    textBoxResult_SVE.AppendText(array[i] + Environment.NewLine);
                    chartFunction_SVE.Series[0].Points.AddXY(startValue, array[i]);
                    startValue++;
                }
            }

            catch
            {
                MessageBox.Show("Введенны неверные данные!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSave_SVE_Click(object sender, EventArgs e)
        {
            try
            {
                string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask4.txt";
                File.WriteAllText(path, textBoxResult_SVE.Text);
                DialogResult dialogResult = MessageBox.Show("Файл " + path + "Сохранен успешно!\n", "Открыть его в блокноте?", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("Сбой при сохранении файла!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_SVE_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 выполнил студент группы ИБКСб-25-1 Сафронов Владимир Евгеньевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonDone_SVE_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void buttonDone_SVE_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }
    }
}
