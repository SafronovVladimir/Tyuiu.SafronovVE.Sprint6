using Tyuiu.SafronovVE.Sprint6.Task6.V16.Lib;
using System.Windows.Forms;
using System.Linq.Expressions;

namespace Tyuiu.SafronovVE.Sprint6.Task6.V16
{
    public partial class FormMain_SVE : Form
    {
        public FormMain_SVE()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        string openFilePath;

        private void buttonOpen_SVE_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog_SVE.ShowDialog();
                openFilePath = openFileDialog_SVE.FileName;
                textBoxInput_SVE.Text = File.ReadAllText(openFilePath);
                groupBoxInput_SVE.Text = groupBoxInput_SVE.Text + " " + openFileDialog_SVE.FileName;
                buttonDone_SVE.Enabled = true;
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Файл не выбран или не существует!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonDone_SVE_Click(object sender, EventArgs e)
        {
            textBoxOutput_SVE.Text = ds.CollectTextFromFile(openFilePath);
        }

        private void buttonAbout_SVE_Click(object sender, EventArgs e)
        {
            FormAbout_SVE formAbout = new FormAbout_SVE();
            formAbout.ShowDialog();
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
