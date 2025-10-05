namespace Lab_3;
using DataBase;
using System.Data.SqlClient;
public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void idFd_TextChanged(object sender, EventArgs e)
    {
    }

    private void nameFd_TextChanged(object sender, EventArgs e)
    {
        
    }

    private void textBox2_TextChanged(object sender, EventArgs e)
    {
        
    }

    private void empFd_TextChanged(object sender, EventArgs e)
    {
        
    }

    private void maleBtn_CheckedChanged(object sender, EventArgs e)
    {
        
    }

    private void femaleBtn_CheckedChanged(object sender, EventArgs e)
    {
        
    }

    private void groupBox1_Enter(object sender, EventArgs e)
    {
        
    }

    private void insertBtn_Click(object sender, EventArgs e)
    {
        string id = idFd.Text;
        string name = nameFd.Text;
        string address = textBox2.Text;
        string gender = maleBtn.Checked ? "Male" : "Female";

        bool done = new sql().insert(id, name, address, gender);

        if (done)
        {
            MessageBox.Show("Data inserted successfully");
        }
        else
        {
            MessageBox.Show("Error inserting data");
        }
    }

    private void updateBtn_Click(object sender, EventArgs e)
    {
        string id = idFd.Text;
        string name = nameFd.Text;
        string address = textBox2.Text;
        string gender = maleBtn.Checked ? "Male" : "Female";

        bool done = new sql().update(id, name, address, gender);

        if (done)
        {
            MessageBox.Show("Data updated successfully");
        }
        else
        {
            MessageBox.Show("Error updating data");
        }

    }

    private void deleteBtn_Click(object sender, EventArgs e)
    {
        string id = idFd.Text;

        bool done = new sql().delete(id);

        if (done)
        {
            MessageBox.Show("Data deleted successfully");
        }
        else
        {
            MessageBox.Show("Error deleting data");
        }

    }

    private void searchBtn_Click(object sender, EventArgs e)
    {
        string id = idFd.Text;

        string[] dt = new sql().search_a(id);
        
        if (dt[0] != null)
        {
            nameFd.Text = dt[1];
            textBox2.Text = dt[2];
            if (dt[3] == "True")
            {
                maleBtn.Checked = true;
            }
            else
            {
                femaleBtn.Checked = true;
            }
        }
        else
        {
            MessageBox.Show("No data found for this ID");
        }
        
        
    }
}