namespace calcu_with_my_own_class;
using CalcuLib;
public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void input1_TextChanged(object sender, EventArgs e)
    {
        
    }

    private void input2_TextChanged(object sender, EventArgs e)
    {
        
    }

    private void plus_Click(object sender, EventArgs e)
    {
        int a = int.Parse(input1.Text);
        int b = int.Parse(input2.Text);
        double result = new Class1().Add(a, b);
        Display(result);

    }

    private void minus_Click(object sender, EventArgs e)
    {
        int a = int.Parse(input1.Text);
        int b = int.Parse(input2.Text);
        double result = new Class1().Subtract(a, b);
        Display(result);
        
    }


    private void multi_Click(object sender, EventArgs e)
    {
        int a = int.Parse(input1.Text);
        int b = int.Parse(input2.Text);
        double result = new Class1().Multiply(a, b);
        Display(result);
        
    }


    private void div_Click(object sender, EventArgs e)
    {
        int a = int.Parse(input1.Text);
        int b = int.Parse(input2.Text);
        double result = new Class1().Divide(a, b);
        Display(result);
        
        
    }

    public void Display(double result)
    {
        MessageBox.Show("Answer: "+result.ToString());
    }

    private void plus_Click_1(object sender, EventArgs e)
    {
        int a = int.Parse(input1.Text);
        int b = int.Parse(input2.Text);
        double result = new Class1().Add(a, b);
        Display(result);
    }
}
