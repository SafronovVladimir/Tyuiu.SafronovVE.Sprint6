using System.Diagnostics.Eventing.Reader;
using Tyuiu.SafronovVE.Sprint6.Task7.V28.Lib;
namespace Tyuiu.SafronovVE.Sprint6.Task7.V28
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        static string openFilePath;
        static int rows;
        static int cols;

        DataService ds = new DataService();

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
            openFilePath = openFileDialog.FileName;

            var matrix = ds.GetMatrix(openFilePath);

            rows = matrix.GetUpperBound(0) + 1;
            cols = matrix.GetUpperBound(1) + 1;

            dataGridViewIn.ColumnCount = cols;
            dataGridViewIn.RowCount = rows;
            dataGridViewOut.ColumnCount = cols;
            dataGridViewOut.RowCount = rows;

            for (int i = 0; i < cols; i++)
            {
                dataGridViewIn.Columns[i].Width = 50;
                dataGridViewOut.Columns[i].Width = 50;
            }

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    dataGridViewIn.Rows[r].Cells[c].Value = matrix[r, c];
                }
            }

            buttonDone.Enabled = true;
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            var matrix = ds.GetMatrix(openFilePath);
            var valueArray = ds.TransformMatrix(matrix);

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    dataGridViewOut.Rows[r].Cells[c].Value = valueArray[r, c];
                }
            }
        }

        private void buttonSaveFile_Click(object sender, EventArgs e)
        {
            saveFileDialog.FileName = "OutfFileTask7.csv";
            saveFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialog.ShowDialog();

            string path = saveFileDialog.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExist = fileInfo.Exists;

            if (fileExist)
            {
                File.Delete(path);
            }

            int rows = dataGridViewOut.RowCount;
            int cols = dataGridViewOut.ColumnCount;

            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (j != cols - 1)
                    {
                        str += dataGridViewOut.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str += dataGridViewOut.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
    }
}
