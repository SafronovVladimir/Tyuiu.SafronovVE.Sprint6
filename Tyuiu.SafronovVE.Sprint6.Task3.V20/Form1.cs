using System.Drawing.Drawing2D;
using Tyuiu.SafronovVE.Sprint6.Task3.V20.Lib;
namespace Tyuiu.SafronovVE.Sprint6.Task3.V20
{
    public partial class Form1 : Form
    {
        public Form1()
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

        private void conditionLabel_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int cols = matrix.GetUpperBound(1) + 1;

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

        private void doneButton_Click(object sender, EventArgs e)
        {
            var resMatrix = ds.Calculate(matrix);
            int rows = matrix.GetUpperBound(0) + 1;
            int cols = matrix.GetUpperBound(1) + 1;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    dataGridViewMatrix.Rows[i].Cells[j].Value = Convert.ToString(resMatrix[i, j]);
                }
            }
            MessageBox.Show("Операция выполнена успешно!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Выполнил студент группы ИБКСб-25-1 Сафронов В.Е.", "Сведения", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
