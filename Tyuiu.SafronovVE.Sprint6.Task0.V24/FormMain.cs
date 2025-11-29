using Tyuiu.SafronovVE.Sprint6.Task0.V24.Lib;
namespace Tyuiu.SafronovVE.Sprint6.Task0.V24;

public partial class FormMain : Form
{
    public FormMain()
    {
        InitializeComponent();
    }

    private void buttonDone_Click(object sender, EventArgs e)
    {
        DataService ds = new DataService();
        try
        {
            textBoxResult.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxVarX.Text)));
        }
        catch
        {
            MessageBox.Show("¬ведены неверные данные!", "ќшибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void textBoxVarX_KeyPress(object sender, KeyPressEventArgs e)
    {
        if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8))
        {
            e.Handled = true;
        }
    }

    private void buttonHelp_Click(object sender, EventArgs e)
    {
        MessageBox.Show("Task 0 выполнил студент группы »Ѕ —б-25-1 —афронов ¬ладимир ≈вгеньевич", "—ообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void FormMain_Load(object sender, EventArgs e)
    {
        textBoxTask.SelectionStart = textBoxTask.Text.Length;
        textBoxTask.SelectionLength = 0;

    }
}
