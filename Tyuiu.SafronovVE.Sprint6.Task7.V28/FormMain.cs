using System.Windows.Forms;
using Tyuiu.SafronovVE.Sprint6.Task7.V28.Lib;
namespace Tyuiu.SafronovVE.Sprint6.Task7.V28
{
    public partial class FormMain_SVE : Form
    {
        public FormMain_SVE()
        {
            InitializeComponent();

            openFileDialog_SVE.Filter = "Значения, разделённые запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialog_SVE.Filter = "Значения, разделённые запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
        }

        static string openFilePath;
        static int rows;
        static int cols;

        DataService ds = new DataService();

        int[,] GetMass(string filePath)
        {
            string[] strings = File.ReadAllLines(filePath);

            int rows = strings.GetUpperBound(0) + 1;
            int cols = strings[0].Split(';').GetUpperBound(0) + 1;

            int[,] result = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    result[i, j] = Int32.Parse(strings[i].Split(";")[j]);
                }
            }

            return result;
        }

        private void buttonOpen_SVE_Click(object sender, EventArgs e)
        {
            openFileDialog_SVE.ShowDialog();
            openFilePath = openFileDialog_SVE.FileName;

            var matrix = GetMass(openFilePath);

            rows = matrix.GetUpperBound(0) + 1;
            cols = matrix.GetUpperBound(1) + 1;

            dataGridViewIn_SVE.ColumnCount = cols;
            dataGridViewIn_SVE.RowCount = rows;
            dataGridViewOut_SVE.ColumnCount = cols;
            dataGridViewOut_SVE.RowCount = rows;

            for (int i = 0; i < cols; i++)
            {
                dataGridViewIn_SVE.Columns[i].Width = 50;
                dataGridViewOut_SVE.Columns[i].Width = 50;
            }

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    dataGridViewIn_SVE.Rows[r].Cells[c].Value = matrix[r, c];
                }
            }

            buttonDone_SVE.Enabled = true;
        }

        private void buttonDone_SVE_Click(object sender, EventArgs e)
        {
            var valueArray = ds.GetMatrix(openFilePath);

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    dataGridViewOut_SVE.Rows[r].Cells[c].Value = valueArray[r, c];
                }
            }
        }

        private void buttonSave_SVE_Click(object sender, EventArgs e)
        {
            saveFileDialog_SVE.FileName = "OutfFileTask7.csv";
            saveFileDialog_SVE.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialog_SVE.ShowDialog();

            string path = saveFileDialog_SVE.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExist = fileInfo.Exists;

            if (fileExist)
            {
                File.Delete(path);
            }

            int rows = dataGridViewOut_SVE.RowCount;
            int cols = dataGridViewOut_SVE.ColumnCount;

            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (j != cols - 1)
                    {
                        str += dataGridViewOut_SVE.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str += dataGridViewOut_SVE.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void buttonHelp_SVE_Click(object sender, EventArgs e)
        {
            FormAbout_SVE formAbout = new FormAbout_SVE();
            formAbout.ShowDialog();
        }

        private void FormMain_SVE_Load(object sender, EventArgs e)
        {
            dataGridViewIn_SVE.ColumnCount = 50;
            dataGridViewOut_SVE.ColumnCount = 50;

            dataGridViewIn_SVE.RowCount = 50;
            dataGridViewOut_SVE.RowCount = 50;

            for (int i = 0; i < 50; i++)
            {
                dataGridViewIn_SVE.Columns[i].Width = 25;
                dataGridViewOut_SVE.Columns[i].Width = 25;
            }

            panelLeft_SVE.Width = this.Width / 2;
            panelRight_SVE.Width = this.Width / 2;
        }

        private void buttonOpen_SVE_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void buttonOpen_SVE_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }
    }
}
