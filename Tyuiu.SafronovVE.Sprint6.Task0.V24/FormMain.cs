using Tyuiu.SafronovVE.Sprint6.Task0.V24.Lib;
namespace Tyuiu.SafronovVE.Sprint6.Task0.V24;

public partial class FormMain_SVE : Form
{
    public FormMain_SVE()
    {
        InitializeComponent();
    }

    private void buttonDone_SVE_Click(object sender, EventArgs e)
    {
        DataService ds = new DataService();
        try
        {
            textBoxResult_SVE.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxVarX_SVE.Text)));
        }
        catch
        {
            MessageBox.Show("¬ведены неверные данные!", "ќшибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void textBoxVarX_SVE_KeyPress(object sender, KeyPressEventArgs e)
    {
        if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8))
        {
            e.Handled = true;
        }
    }

    private void buttonHelp_SVE_Click(object sender, EventArgs e)
    {
        MessageBox.Show("Task 0 выполнил студент группы »Ѕ —б-25-1 —афронов ¬ладимир ≈вгеньевич", "—ообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void FormMain_Load(object sender, EventArgs e)
    {
        groupBoxInput_SVE.Select();
    }
}
