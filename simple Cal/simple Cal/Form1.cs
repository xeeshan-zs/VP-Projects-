using System.Data;

namespace simple_Cal;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {
        
    }

    private void textBox2_TextChanged(object sender, EventArgs e)
    {
        
    }

    private void zero_Click(object sender, EventArgs e)
    {
        textBox1.Text += "0";
    }

    private void one_Click(object sender, EventArgs e)
    {
        textBox1.Text += "1";
    }

    private void plus_Click(object sender, EventArgs e)
    {
        textBox1.Text += "+";
    }

    private void equal_Click(object sender, EventArgs e)
    {
        String ans = textBox1.Text;
        var result = new DataTable().Compute(ans, null);
        textBox2.Text = result.ToString();
    }
}