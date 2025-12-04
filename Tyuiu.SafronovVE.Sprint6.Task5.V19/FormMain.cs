using System.IO;
using System.Windows.Forms;
using Tyuiu.SafronovVE.Sprint6.Task5.V19.Lib;
namespace Tyuiu.SafronovVE.Sprint6.Task5.V19
{
    public partial class FormMain_SVE : Form
    {
        public FormMain_SVE()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        string path = Path.Combine($@"{Directory.GetCurrentDirectory()}", "InPutDataFileTask5V19.txt");

        private void FormMain_SVE_Load(object sender, EventArgs e)
        {
            groupBoxOutputData_SVE.Select();
        }

        private void buttonDone_SVE_Click(object sender, EventArgs e)
        {
            dataGridViewNums_SVE.ColumnCount = 2;
            dataGridViewNums_SVE.Columns[0].Width = 20;
            dataGridViewNums_SVE.Columns[1].Width = 50;

            chartDiag_SVE.ChartAreas[0].AxisX.Title = "Ось X";
            chartDiag_SVE.ChartAreas[0].AxisX.Title = "Ось Y";

            chartDiag_SVE.Series[0].Points.Clear();

            dataGridViewNums_SVE.Rows.Clear();

            var numsMass = ds.LoadFromDataFile(path);

            for (int i = 0; i < numsMass.Length; i++)
            {
                dataGridViewNums_SVE.Rows.Add(Convert.ToString(i), Convert.ToString(numsMass[i]));
                chartDiag_SVE.Series[0].Points.AddXY(i, numsMass[i]);
            }
        }

        private void buttonSave_SVE_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void buttonHelp_SVE_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнил студент группы ИБКСб-25-1 Сафронов Владимир Евгеньевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
