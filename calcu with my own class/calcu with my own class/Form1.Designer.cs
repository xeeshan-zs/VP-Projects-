namespace calcu_with_my_own_class;

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
        panel1 = new System.Windows.Forms.Panel();
        div = new System.Windows.Forms.Button();
        multi = new System.Windows.Forms.Button();
        minus = new System.Windows.Forms.Button();
        plus = new System.Windows.Forms.Button();
        input2 = new System.Windows.Forms.TextBox();
        input1 = new System.Windows.Forms.TextBox();
        panel1.SuspendLayout();
        SuspendLayout();
        // 
        // panel1
        // 
        panel1.BackColor = System.Drawing.SystemColors.ControlDark;
        panel1.Controls.Add(div);
        panel1.Controls.Add(multi);
        panel1.Controls.Add(minus);
        panel1.Controls.Add(plus);
        panel1.Controls.Add(input2);
        panel1.Controls.Add(input1);
        panel1.Location = new System.Drawing.Point(66, 52);
        panel1.Name = "panel1";
        panel1.Size = new System.Drawing.Size(225, 236);
        panel1.TabIndex = 0;
        // 
        // div
        // 
        div.Location = new System.Drawing.Point(114, 169);
        div.Name = "div";
        div.Size = new System.Drawing.Size(62, 33);
        div.TabIndex = 5;
        div.Text = "/";
        div.UseVisualStyleBackColor = true;
        div.Click += div_Click;
        // 
        // multi
        // 
        multi.Location = new System.Drawing.Point(48, 169);
        multi.Name = "multi";
        multi.Size = new System.Drawing.Size(62, 33);
        multi.TabIndex = 4;
        multi.Text = "x";
        multi.UseVisualStyleBackColor = true;
        multi.Click += multi_Click;
        // 
        // minus
        // 
        minus.Location = new System.Drawing.Point(114, 130);
        minus.Name = "minus";
        minus.Size = new System.Drawing.Size(62, 33);
        minus.TabIndex = 3;
        minus.Text = "-";
        minus.UseVisualStyleBackColor = true;
        minus.Click += minus_Click;
        // 
        // plus
        // 
        plus.Location = new System.Drawing.Point(48, 130);
        plus.Name = "plus";
        plus.Size = new System.Drawing.Size(62, 33);
        plus.TabIndex = 2;
        plus.Text = "+";
        plus.UseVisualStyleBackColor = true;
        plus.Click += plus_Click_1;
        // 
        // input2
        // 
        input2.Location = new System.Drawing.Point(48, 85);
        input2.Name = "input2";
        input2.PlaceholderText = "Second Number";
        input2.Size = new System.Drawing.Size(128, 31);
        input2.TabIndex = 1;
        input2.TextChanged += input2_TextChanged;
        // 
        // input1
        // 
        input1.BackColor = System.Drawing.SystemColors.Window;
        input1.Location = new System.Drawing.Point(48, 48);
        input1.Name = "input1";
        input1.PlaceholderText = "First Number";
        input1.Size = new System.Drawing.Size(128, 31);
        input1.TabIndex = 0;
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(333, 332);
        Controls.Add(panel1);
        Text = "Form1";
        panel1.ResumeLayout(false);
        panel1.PerformLayout();
        ResumeLayout(false);
    }

    private System.Windows.Forms.Button plus;
    private System.Windows.Forms.Button minus;
    private System.Windows.Forms.Button div;
    private System.Windows.Forms.Button multi;

    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.TextBox input1;
    private System.Windows.Forms.TextBox input2;

    #endregion
}