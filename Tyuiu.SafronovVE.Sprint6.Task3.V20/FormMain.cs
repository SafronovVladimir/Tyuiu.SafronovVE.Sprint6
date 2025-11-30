using Tyuiu.SafronovVE.Sprint6.Task3.V20.Lib;
namespace Tyuiu.SafronovVE.Sprint6.Task3.V20
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        int[,] matrix = new int[5, 5]
        {
            {-14, 17, -19, 3, 2 },
            {-4, -14, -19, -9, -1 },
            {1, 0, 13, 14, 8 },
            {13, 7, 8, -3, -15 },
            {2, -20, 12, -14, 4 }
        };

        private void FormMain_Load(object sender, EventArgs e)
        {
            groupBoxTask.Select();

            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            dataGridViewMatrix.ColumnCount = cols;
            dataGridViewMatrix.RowCount = rows;

            for (int i = 0; i < cols; i++)
            {
                dataGridViewMatrix.Columns[i].Width = 50;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    dataGridViewMatrix.Rows[i].Cells[j].Value = Convert.ToString(matrix[i, j]);
                }
            }
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            matrix = ds.Calculate(matrix);

            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            dataGridViewResult.ColumnCount = cols;
            dataGridViewResult.RowCount = rows;

            for (int i = 0; i < cols; i++)
            {
                dataGridViewResult.Columns[i].Width = 50;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    dataGridViewResult.Rows[i].Cells[j].Value = Convert.ToString(matrix[i, j]);
                }
            }
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнил студент группы ИБКСб-25-1 Сафронов Владимир Евгеньевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
