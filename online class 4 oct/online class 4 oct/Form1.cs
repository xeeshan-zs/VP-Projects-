namespace online_class_4_oct;
using Microsoft.Data.SqlCLient;

public partial class Form1 : Form
{
    private string connectionStr = "server=localhost; Database=online_class; Trusted_Connection=True; Encrypt=False; ";
    public Form1()
    {
        InitializeComponent();
    }

    private void submitBtn_Click(object sender, EventArgs e)
    {
        int id = int.Parse(idTxt.Text);
        string name = nameTxt.Text;

        try
        {
            using (Sql)
            {
                
            }

        }
        catch (Exception exception)
        {
            throw exception;
        }
    }
}