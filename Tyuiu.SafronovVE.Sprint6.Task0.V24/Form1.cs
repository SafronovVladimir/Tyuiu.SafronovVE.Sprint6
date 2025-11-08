using Tyuiu.SafronovVE.Sprint6.Task0.V24.Lib;
namespace Tyuiu.SafronovVE.Sprint6.Task0.V24
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void completeOperation_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                result.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(varX.Text)));
            }
            catch
            {
                MessageBox.Show("Неверный формат ввода!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
