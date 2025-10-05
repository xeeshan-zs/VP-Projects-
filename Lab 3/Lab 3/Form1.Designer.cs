namespace Lab_3;

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
        label1 = new System.Windows.Forms.Label();
        label2 = new System.Windows.Forms.Label();
        label3 = new System.Windows.Forms.Label();
        label4 = new System.Windows.Forms.Label();
        idFd = new System.Windows.Forms.TextBox();
        textBox2 = new System.Windows.Forms.TextBox();
        nameFd = new System.Windows.Forms.TextBox();
        label5 = new System.Windows.Forms.Label();
        empFd = new System.Windows.Forms.RichTextBox();
        groupBox1 = new System.Windows.Forms.GroupBox();
        femaleBtn = new System.Windows.Forms.RadioButton();
        maleBtn = new System.Windows.Forms.RadioButton();
        insertBtn = new System.Windows.Forms.Button();
        updateBtn = new System.Windows.Forms.Button();
        deleteBtn = new System.Windows.Forms.Button();
        searchBtn = new System.Windows.Forms.Button();
        groupBox1.SuspendLayout();
        SuspendLayout();
        // 
        // label1
        // 
        label1.BackColor = System.Drawing.SystemColors.ActiveBorder;
        label1.Location = new System.Drawing.Point(44, 74);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(33, 24);
        label1.TabIndex = 0;
        label1.Text = "ID: ";
        // 
        // label2
        // 
        label2.BackColor = System.Drawing.SystemColors.ActiveBorder;
        label2.Location = new System.Drawing.Point(44, 170);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(68, 24);
        label2.TabIndex = 1;
        label2.Text = "Address:";
        // 
        // label3
        // 
        label3.BackColor = System.Drawing.SystemColors.ActiveBorder;
        label3.Location = new System.Drawing.Point(44, 123);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(54, 24);
        label3.TabIndex = 2;
        label3.Text = "Name: ";
        // 
        // label4
        // 
        label4.BackColor = System.Drawing.SystemColors.ActiveBorder;
        label4.Location = new System.Drawing.Point(44, 217);
        label4.Name = "label4";
        label4.Size = new System.Drawing.Size(68, 24);
        label4.TabIndex = 3;
        label4.Text = "Gender: ";
        // 
        // idFd
        // 
        idFd.Location = new System.Drawing.Point(157, 71);
        idFd.Name = "idFd";
        idFd.Size = new System.Drawing.Size(200, 27);
        idFd.TabIndex = 4;
        idFd.TextChanged += idFd_TextChanged;
        // 
        // textBox2
        // 
        textBox2.Location = new System.Drawing.Point(157, 170);
        textBox2.Name = "textBox2";
        textBox2.Size = new System.Drawing.Size(200, 27);
        textBox2.TabIndex = 5;
        textBox2.TextChanged += textBox2_TextChanged;
        // 
        // nameFd
        // 
        nameFd.Location = new System.Drawing.Point(157, 120);
        nameFd.Name = "nameFd";
        nameFd.Size = new System.Drawing.Size(200, 27);
        nameFd.TabIndex = 6;
        nameFd.TextChanged += nameFd_TextChanged;
        // 
        // label5
        // 
        label5.BackColor = System.Drawing.SystemColors.ActiveBorder;
        label5.Location = new System.Drawing.Point(402, 71);
        label5.Name = "label5";
        label5.Size = new System.Drawing.Size(128, 24);
        label5.TabIndex = 7;
        label5.Text = "Employee Data:";
        // 
        // empFd
        // 
        empFd.Location = new System.Drawing.Point(402, 101);
        empFd.Name = "empFd";
        empFd.Size = new System.Drawing.Size(298, 169);
        empFd.TabIndex = 8;
        empFd.Text = "";
        empFd.TextChanged += empFd_TextChanged;
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(femaleBtn);
        groupBox1.Controls.Add(maleBtn);
        groupBox1.Location = new System.Drawing.Point(157, 211);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new System.Drawing.Size(199, 59);
        groupBox1.TabIndex = 9;
        groupBox1.TabStop = false;
        groupBox1.Text = "Gender: ";
        groupBox1.Enter += groupBox1_Enter;
        // 
        // femaleBtn
        // 
        femaleBtn.Location = new System.Drawing.Point(117, 26);
        femaleBtn.Name = "femaleBtn";
        femaleBtn.Size = new System.Drawing.Size(83, 31);
        femaleBtn.TabIndex = 1;
        femaleBtn.TabStop = true;
        femaleBtn.Text = "Female";
        femaleBtn.UseVisualStyleBackColor = true;
        femaleBtn.CheckedChanged += femaleBtn_CheckedChanged;
        // 
        // maleBtn
        // 
        maleBtn.Location = new System.Drawing.Point(17, 26);
        maleBtn.Name = "maleBtn";
        maleBtn.Size = new System.Drawing.Size(76, 31);
        maleBtn.TabIndex = 0;
        maleBtn.TabStop = true;
        maleBtn.Text = "Male";
        maleBtn.UseVisualStyleBackColor = true;
        maleBtn.CheckedChanged += maleBtn_CheckedChanged;
        // 
        // insertBtn
        // 
        insertBtn.Location = new System.Drawing.Point(24, 305);
        insertBtn.Name = "insertBtn";
        insertBtn.Size = new System.Drawing.Size(166, 42);
        insertBtn.TabIndex = 10;
        insertBtn.Text = "Insert";
        insertBtn.UseVisualStyleBackColor = true;
        insertBtn.Click += insertBtn_Click;
        // 
        // updateBtn
        // 
        updateBtn.Location = new System.Drawing.Point(196, 305);
        updateBtn.Name = "updateBtn";
        updateBtn.Size = new System.Drawing.Size(164, 42);
        updateBtn.TabIndex = 11;
        updateBtn.Text = "Update";
        updateBtn.UseVisualStyleBackColor = true;
        updateBtn.Click += updateBtn_Click;
        // 
        // deleteBtn
        // 
        deleteBtn.Location = new System.Drawing.Point(366, 305);
        deleteBtn.Name = "deleteBtn";
        deleteBtn.Size = new System.Drawing.Size(164, 42);
        deleteBtn.TabIndex = 12;
        deleteBtn.Text = "Delete";
        deleteBtn.UseVisualStyleBackColor = true;
        deleteBtn.Click += deleteBtn_Click;
        // 
        // searchBtn
        // 
        searchBtn.Location = new System.Drawing.Point(536, 305);
        searchBtn.Name = "searchBtn";
        searchBtn.Size = new System.Drawing.Size(164, 42);
        searchBtn.TabIndex = 13;
        searchBtn.Text = "Search";
        searchBtn.UseVisualStyleBackColor = true;
        searchBtn.Click += searchBtn_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.SystemColors.ButtonFace;
        ClientSize = new System.Drawing.Size(723, 379);
        Controls.Add(searchBtn);
        Controls.Add(deleteBtn);
        Controls.Add(updateBtn);
        Controls.Add(insertBtn);
        Controls.Add(groupBox1);
        Controls.Add(empFd);
        Controls.Add(label5);
        Controls.Add(nameFd);
        Controls.Add(textBox2);
        Controls.Add(idFd);
        Controls.Add(label4);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(label1);
        Text = "Form1";
        groupBox1.ResumeLayout(false);
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Button searchBtn;

    private System.Windows.Forms.Button insertBtn;
    private System.Windows.Forms.Button updateBtn;
    private System.Windows.Forms.Button deleteBtn;

    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.RadioButton maleBtn;
    private System.Windows.Forms.RadioButton femaleBtn;

    private System.Windows.Forms.RichTextBox empFd;

    private System.Windows.Forms.Label label5;

    private System.Windows.Forms.TextBox idFd;
    private System.Windows.Forms.TextBox textBox2;
    private System.Windows.Forms.TextBox nameFd;

    private System.Windows.Forms.Label label4;

    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;

    private System.Windows.Forms.Label label1;

    #endregion
}