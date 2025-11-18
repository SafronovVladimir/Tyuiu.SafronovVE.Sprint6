using System.Windows.Forms.DataVisualization.Charting;
using Tyuiu.SafronovVE.Sprint6.Task4.V6.Lib;
namespace Tyuiu.SafronovVE.Sprint6.Task4.V6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        private void startStep_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void doneButton_Click(object sender, EventArgs e)
        {
            int startValue = Convert.ToInt32(startStep.Text);
            int stopValue = Convert.ToInt32(stopStep.Text);

            int len = stopValue - startValue + 1;
            var array = ds.GetMassFunction(startValue, stopValue);

            chartFunction.ChartAreas[0].AxisX.Title = "Ось X";
            chartFunction.ChartAreas[0].AxisY.Title = "Ось Y";

            chartFunction.Series[0].Points.Clear();

            chartFunction.Series[0].ChartType = SeriesChartType.Spline; ;

            for (int i = 0; i < len; i++)
            {
                outputTextBox.AppendText(array[i] + Environment.NewLine);
                chartFunction.Series[0].Points.AddXY(startValue, array[i]);
                startValue++;
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask4.txt";
                File.WriteAllText(path, outputTextBox.Text);
                DialogResult dialogResult = MessageBox.Show("Файл " + path + "сохранён успешно!\n Открыть его в блокноте?", "Сохранение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
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
                MessageBox.Show("Сбой при сохранении файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void infoButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Выполнил студент группы ИБКСб-25-1 Сафронов В.Е.", "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
