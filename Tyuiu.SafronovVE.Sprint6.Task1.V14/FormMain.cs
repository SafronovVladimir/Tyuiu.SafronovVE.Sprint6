using Tyuiu.SafronovVE.Sprint6.Task1.V14.Lib;

namespace Tyuiu.SafronovVE.Sprint6.Task1.V14
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            groupBoxTask.Select();
        }

        DataService ds = new DataService();

        private void buttonDone_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStartStep.Text);
                int stopStep = Convert.ToInt32(textBoxStopStep.Text);

                string strLine;

                var mas = ds.GetMassFunction(startStep, stopStep);

                int len = mas.Length;

                textBoxResult.Text = "";
                textBoxResult.AppendText("+---------+----------+" + Environment.NewLine);
                textBoxResult.AppendText("|    X    |   f(x)   |" + Environment.NewLine);
                textBoxResult.AppendText("+---------+----------+" + Environment.NewLine);

                for (int i = 0; i != len; i++)
                {
                    strLine = String.Format("|{0,5:d}    | {1,6:f2}   |", startStep, mas[i]);
                    textBoxResult.AppendText(strLine + Environment.NewLine);
                    startStep++;
                }

                textBoxResult.AppendText("+---------+----------+" + Environment.NewLine);
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
