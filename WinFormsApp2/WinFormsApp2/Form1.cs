namespace WinFormsApp2;

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

    private void plusBtn_Click(object sender, EventArgs e)
    {
        int a = int.Parse(input1.Text);
        int b = int.Parse(input2.Text);
        int ans = a + b;

        MessageBox.Show("Answer: " + ans);
    }
}