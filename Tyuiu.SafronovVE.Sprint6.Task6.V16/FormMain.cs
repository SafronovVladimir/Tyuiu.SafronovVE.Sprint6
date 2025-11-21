using Tyuiu.SafronovVE.Sprint6.Task6.V16.Lib;
namespace Tyuiu.SafronovVE.Sprint6.Task6.V16
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        string openFilePath;

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
            openFilePath = openFileDialog.FileName;
            textBoxInput.Text = File.ReadAllText(openFilePath);
            inputLabel.Text = inputLabel.Text + " " + openFileDialog.FileName;
            buttonDone.Enabled = true;

        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            textBoxOut.Text = ds.CollectTextFromFile(openFilePath);
        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonAbout_Click_1(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
    }
}
