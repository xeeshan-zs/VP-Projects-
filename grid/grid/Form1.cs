using System.Data;

namespace grid;
using Microsoft.Data.SqlClient;

public partial class Form1 : Form
{   
    public string connectionString =
        "Server=localhost;Database=uni;Trusted_Connection=True;Encrypt=False;";
    public Form1()
    {
        InitializeComponent();
        
    }
    
    private void Form1_Load(object sender, EventArgs e)
    {
        SqlConnection com = new SqlConnection(connectionString);
        com.Open();
        SqlDataAdapter adp = new SqlDataAdapter("select * from employee",com);
        //DataTable for 1 table
        //Dataset for multiple tables
        DataTable dt = new DataTable();
        //DataAdapter has 2 functions Fill() & update()
        adp.Fill(dt);
        gdView.DataSource = dt;

    }

    private void gdView_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
        // load data from employee table
        SqlConnection com = new SqlConnection(connectionString);
        com.Open();
        SqlDataAdapter adp = new SqlDataAdapter("select * from employee",com);
        DataTable dt = new DataTable();
        adp.Fill(dt);
        gdView.DataSource = dt;

    }
}

