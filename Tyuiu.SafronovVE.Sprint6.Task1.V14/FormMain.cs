using Tyuiu.SafronovVE.Sprint6.Task1.V14.Lib;

namespace Tyuiu.SafronovVE.Sprint6.Task1.V14
{
    public partial class FormMain_SVE : Form
    {
        public FormMain_SVE()
        {
            InitializeComponent();
        }

        private void FormMain_SVE_Load(object sender, EventArgs e)
        {
            groupBoxTask_SVE.Select();
        }

        DataService ds = new DataService();

        private void buttonDone_SVE_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStartStep_SVE.Text);
                int stopStep = Convert.ToInt32(textBoxStopStep_SVE.Text);

                string strLine;

                var mas = ds.GetMassFunction(startStep, stopStep);

                int len = mas.Length;

                textBoxResult_SVE.Text = "";
                textBoxResult_SVE.AppendText("+---------+----------+" + Environment.NewLine);
                textBoxResult_SVE.AppendText("|    X    |   f(x)   |" + Environment.NewLine);
                textBoxResult_SVE.AppendText("+---------+----------+" + Environment.NewLine);

                for (int i = 0; i != len; i++)
                {
                    strLine = String.Format("|{0,5:d}    | {1,6:f2}   |", startStep, mas[i]);
                    textBoxResult_SVE.AppendText(strLine + Environment.NewLine);
                    startStep++;
                }

                textBoxResult_SVE.AppendText("+---------+----------+" + Environment.NewLine);
            }

            catch
            {
                MessageBox.Show("Введены неверные данные!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_SVE_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнил студент группы ИБКСб-25-1 Сафронов Владимир Евгеньевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
