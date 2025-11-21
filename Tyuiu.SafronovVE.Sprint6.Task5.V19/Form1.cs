using Tyuiu.SafronovVE.Sprint6.Task5.V19.Lib;
namespace Tyuiu.SafronovVE.Sprint6.Task5.V19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        string path = Path.Combine($@"{Directory.GetCurrentDirectory()}", "InPutDataFileTask5V19.txt");

        private void doneButton_Click(object sender, EventArgs e)
        {
            chartDiag.ChartAreas[0].AxisX.Title = "Ось X";
            chartDiag.ChartAreas[0].AxisX.Title = "Ось Y";

            chartDiag.Series[0].Points.Clear();

            dataGridView.Rows.Clear();

            var numsMass = ds.LoadFromDataFile(path);

            for (int i = 0; i < numsMass.Length; i++)
            {
                dataGridView.Rows.Add(Convert.ToString(i), Convert.ToString(numsMass[i]));
                chartDiag.Series[0].Points.AddXY(i, numsMass[i]);
            }
        }

        private void openFileButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void infoButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Выполнил студент группы ИБКСб-25-1 Сафронов В.Е.", "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
