using Tyuiu.SafronovVE.Sprint6.Task1.V14.Lib;
namespace Tyuiu.SafronovVE.Sprint6.Task1.V14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        private void completeButton_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(startValue.Text);
                int stopStep = Convert.ToInt32(stopValue.Text);

                var mas = ds.GetMassFunction(startStep, stopStep);

                string strLine;

                int len = mas.Length;

                resultsTextBox.Text = "";
                resultsTextBox.AppendText("+------------+------------+" + Environment.NewLine);
                resultsTextBox.AppendText(" |       X          |        f(x)      |" + Environment.NewLine);
                resultsTextBox.AppendText("+------------+------------+" + Environment.NewLine);

                for (int i = 0; i < len; i++)
                {
                    strLine = string.Format(" |{0, 5:d}           |  {1, 8:f2}          |", startStep, mas[i]);
                    resultsTextBox.AppendText(strLine + Environment.NewLine);
                    startStep++;
                }

                resultsTextBox.AppendText("+------------+------------+" + Environment.NewLine);
            }

            catch
            {
                MessageBox.Show("Неверные данные!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void infoButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sprint 6 Task 1 выполнил студент группы ИБКСб-25-1 Сафронов Владимир Евгеньевич.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
