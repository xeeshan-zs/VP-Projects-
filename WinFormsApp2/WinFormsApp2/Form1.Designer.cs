namespace WinFormsApp2;

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
        input1 = new System.Windows.Forms.TextBox();
        input2 = new System.Windows.Forms.TextBox();
        plusBtn = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // input1
        // 
        input1.Location = new System.Drawing.Point(63, 93);
        input1.Name = "input1";
        input1.PlaceholderText = "Enter First Number";
        input1.Size = new System.Drawing.Size(128, 27);
        input1.TabIndex = 0;
        input1.TextChanged += input1_TextChanged;
        // 
        // input2
        // 
        input2.Location = new System.Drawing.Point(219, 93);
        input2.Name = "input2";
        input2.PlaceholderText = "Enter Second Number";
        input2.Size = new System.Drawing.Size(128, 27);
        input2.TabIndex = 1;
        input2.TextChanged += input2_TextChanged;
        // 
        // plusBtn
        // 
        plusBtn.Location = new System.Drawing.Point(133, 175);
        plusBtn.Name = "plusBtn";
        plusBtn.Size = new System.Drawing.Size(127, 26);
        plusBtn.TabIndex = 2;
        plusBtn.Text = "plus";
        plusBtn.UseVisualStyleBackColor = true;
        plusBtn.Click += plusBtn_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(391, 396);
        Controls.Add(plusBtn);
        Controls.Add(input2);
        Controls.Add(input1);
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text = "Form1";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.TextBox input1;
    private System.Windows.Forms.TextBox input2;
    private System.Windows.Forms.Button plusBtn;

    #endregion
}