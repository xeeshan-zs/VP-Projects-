namespace grid;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        gdView = new System.Windows.Forms.DataGridView();
        ((System.ComponentModel.ISupportInitialize)gdView).BeginInit();
        SuspendLayout();
        // 
        // gdView
        // 
        gdView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        gdView.Location = new System.Drawing.Point(109, 85);
        gdView.Name = "gdView";
        gdView.RowHeadersWidth = 51;
        gdView.Size = new System.Drawing.Size(352, 311);
        gdView.TabIndex = 0;
        gdView.Text = "dataGridView1";
        gdView.CellContentClick += gdView_CellContentClick;
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(591, 450);
        Controls.Add(gdView);
        Text = "Form1";
        ((System.ComponentModel.ISupportInitialize)gdView).EndInit();
        ResumeLayout(false);
    }

    private System.Windows.Forms.DataGridView gdView;

    #endregion
}