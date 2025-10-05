namespace online_class_4_oct;

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
        idTxt = new System.Windows.Forms.TextBox();
        nameTxt = new System.Windows.Forms.TextBox();
        submitBtn = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // idTxt
        // 
        idTxt.Location = new System.Drawing.Point(33, 76);
        idTxt.Name = "idTxt";
        idTxt.PlaceholderText = "Enter ID";
        idTxt.Size = new System.Drawing.Size(202, 27);
        idTxt.TabIndex = 0;
        // 
        // nameTxt
        // 
        nameTxt.Location = new System.Drawing.Point(33, 109);
        nameTxt.Name = "nameTxt";
        nameTxt.PlaceholderText = "Enter Name";
        nameTxt.Size = new System.Drawing.Size(202, 27);
        nameTxt.TabIndex = 1;
        // 
        // submitBtn
        // 
        submitBtn.Location = new System.Drawing.Point(35, 148);
        submitBtn.Name = "submitBtn";
        submitBtn.Size = new System.Drawing.Size(87, 29);
        submitBtn.TabIndex = 2;
        submitBtn.Text = "Submit";
        submitBtn.UseVisualStyleBackColor = true;
        submitBtn.Click += submitBtn_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(366, 290);
        Controls.Add(submitBtn);
        Controls.Add(nameTxt);
        Controls.Add(idTxt);
        Text = "Form1";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.TextBox idTxt;
    private System.Windows.Forms.TextBox nameTxt;
    private System.Windows.Forms.Button submitBtn;

    #endregion
}