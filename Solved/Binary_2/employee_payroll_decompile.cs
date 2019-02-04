// Decompiled with JetBrains decompiler
// Type: Employee_Payroll.employee_payroll
// Assembly: Employee_Payroll, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 436284E8-B80D-406A-93C5-7DE7662EB4F2
// Assembly location: C:\Users\zst\Desktop\Employee_Payroll.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Employee_Payroll
{
  public class employee_payroll : Form
  {
    private int loginAttemptCount = 1;
    private int r1 = 102;
    private int r2 = 108;
    private int r3 = 97;
    private int r4 = 103;
    private int r5 = 123;
    private int r6 = 83;
    private int r7 = 84;
    private int r8 = 48;
    private int r9 = 82;
    private int r10 = 73;
    private int r11 = 78;
    private int r12 = 71;
    private int r13 = 95;
    private int r14 = 83;
    private int r15 = 84;
    private int r16 = 65;
    private int r17 = 84;
    private int r18 = 49;
    private int r19 = 67;
    private int r20 = 95;
    private int r21 = 80;
    private int r22 = 65;
    private int r23 = 53;
    private int r24 = 53;
    private int r25 = 87;
    private int r26 = 79;
    private int r27 = 82;
    private int r28 = 68;
    private int r29 = 83;
    private int r30 = 95;
    private int r31 = 49;
    private int r32 = 78;
    private int r33 = 95;
    private int r34 = 70;
    private int r35 = 73;
    private int r36 = 76;
    private int r37 = 51;
    private int r38 = 83;
    private int r39 = 95;
    private int r40 = 49;
    private int r41 = 83;
    private int r42 = 95;
    private int r43 = 78;
    private int r44 = 48;
    private int r45 = 84;
    private int r46 = 95;
    private int r47 = 83;
    private int r48 = 51;
    private int r49 = 67;
    private int r50 = 85;
    private int r51 = 82;
    private int r52 = 51;
    private int r53 = 125;
    private IContainer components;
    private Button btnLogin;
    private Label lblUsername;
    private TextBox txtUsername;
    private Button btnCancel;
    private GroupBox groupBox1;
    private Label lblPassword;
    private TextBox txtPassword;

    public employee_payroll()
    {
      this.InitializeComponent();
    }

    private void btnCancel_Click(object sender, EventArgs e)
    {
      Application.Exit();
    }

    private void btnLogin_Click(object sender, EventArgs e)
    {
      if (this.checkUsername() && this.checkPassword())
      {
        StringBuilder stringBuilder = new StringBuilder();
        char ch = Convert.ToChar(this.r1);
        stringBuilder.Append(ch.ToString());
        ch = Convert.ToChar(this.r2);
        stringBuilder.Append(ch.ToString());
        ch = Convert.ToChar(this.r3);
        stringBuilder.Append(ch.ToString());
        ch = Convert.ToChar(this.r4);
        stringBuilder.Append(ch.ToString());
        ch = Convert.ToChar(this.r5);
        stringBuilder.Append(ch.ToString());
        ch = Convert.ToChar(this.r6);
        stringBuilder.Append(ch.ToString());
        ch = Convert.ToChar(this.r7);
        stringBuilder.Append(ch.ToString());
        ch = Convert.ToChar(this.r8);
        stringBuilder.Append(ch.ToString());
        ch = Convert.ToChar(this.r9);
        stringBuilder.Append(ch.ToString());
        ch = Convert.ToChar(this.r10);
        stringBuilder.Append(ch.ToString());
        ch = Convert.ToChar(this.r11);
        stringBuilder.Append(ch.ToString());
        ch = Convert.ToChar(this.r12);
        stringBuilder.Append(ch.ToString());
        ch = Convert.ToChar(this.r13);
        stringBuilder.Append(ch.ToString());
        ch = Convert.ToChar(this.r14);
        stringBuilder.Append(ch.ToString());
        ch = Convert.ToChar(this.r15);
        stringBuilder.Append(ch.ToString());
        ch = Convert.ToChar(this.r16);
        stringBuilder.Append(ch.ToString());
        ch = Convert.ToChar(this.r17);
        stringBuilder.Append(ch.ToString());
        ch = Convert.ToChar(this.r18);
        stringBuilder.Append(ch.ToString());
        ch = Convert.ToChar(this.r19);
        stringBuilder.Append(ch.ToString());
        ch = Convert.ToChar(this.r20);
        stringBuilder.Append(ch.ToString());
        ch = Convert.ToChar(this.r21);
        stringBuilder.Append(ch.ToString());
        ch = Convert.ToChar(this.r22);
        stringBuilder.Append(ch.ToString());
        ch = Convert.ToChar(this.r23);
        stringBuilder.Append(ch.ToString());
        ch = Convert.ToChar(this.r24);
        stringBuilder.Append(ch.ToString());
        ch = Convert.ToChar(this.r25);
        stringBuilder.Append(ch.ToString());
        ch = Convert.ToChar(this.r26);
        stringBuilder.Append(ch.ToString());
        ch = Convert.ToChar(this.r27);
        stringBuilder.Append(ch.ToString());
        ch = Convert.ToChar(this.r28);
        stringBuilder.Append(ch.ToString());
        ch = Convert.ToChar(this.r29);
        stringBuilder.Append(ch.ToString());
        ch = Convert.ToChar(this.r30);
        stringBuilder.Append(ch.ToString());
        ch = Convert.ToChar(this.r31);
        stringBuilder.Append(ch.ToString());
        ch = Convert.ToChar(this.r32);
        stringBuilder.Append(ch.ToString());
        ch = Convert.ToChar(this.r33);
        stringBuilder.Append(ch.ToString());
        ch = Convert.ToChar(this.r34);
        stringBuilder.Append(ch.ToString());
        ch = Convert.ToChar(this.r35);
        stringBuilder.Append(ch.ToString());
        ch = Convert.ToChar(this.r36);
        stringBuilder.Append(ch.ToString());
        ch = Convert.ToChar(this.r37);
        stringBuilder.Append(ch.ToString());
        ch = Convert.ToChar(this.r38);
        stringBuilder.Append(ch.ToString());
        ch = Convert.ToChar(this.r39);
        stringBuilder.Append(ch.ToString());
        ch = Convert.ToChar(this.r40);
        stringBuilder.Append(ch.ToString());
        ch = Convert.ToChar(this.r41);
        stringBuilder.Append(ch.ToString());
        ch = Convert.ToChar(this.r42);
        stringBuilder.Append(ch.ToString());
        ch = Convert.ToChar(this.r43);
        stringBuilder.Append(ch.ToString());
        ch = Convert.ToChar(this.r44);
        stringBuilder.Append(ch.ToString());
        ch = Convert.ToChar(this.r45);
        stringBuilder.Append(ch.ToString());
        ch = Convert.ToChar(this.r46);
        stringBuilder.Append(ch.ToString());
        ch = Convert.ToChar(this.r47);
        stringBuilder.Append(ch.ToString());
        ch = Convert.ToChar(this.r48);
        stringBuilder.Append(ch.ToString());
        ch = Convert.ToChar(this.r49);
        stringBuilder.Append(ch.ToString());
        ch = Convert.ToChar(this.r50);
        stringBuilder.Append(ch.ToString());
        ch = Convert.ToChar(this.r51);
        stringBuilder.Append(ch.ToString());
        ch = Convert.ToChar(this.r52);
        stringBuilder.Append(ch.ToString());
        ch = Convert.ToChar(this.r53);
        stringBuilder.Append(ch.ToString());
        int num = (int) MessageBox.Show(stringBuilder.ToString());
        Application.Exit();
      }
      if (this.loginAttemptCount > 2)
      {
        this.showLoginCountExceeded();
        Application.Exit();
      }
      if (this.checkUsername() && this.checkPassword())
        return;
      this.showError();
      ++this.loginAttemptCount;
    }

    private void showError()
    {
      int num = (int) MessageBox.Show("Username or Password is incorrect, please try again", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
    }

    private void showLoginCountExceeded()
    {
      int num = (int) MessageBox.Show("Too many login attempts", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
    }

    private bool checkUsername()
    {
      return this.txtUsername.Text == "admin";
    }

    private bool checkPassword()
    {
      return this.txtPassword.Text == "dGhpc19pc19ub3RfdGhlX2ZsYWdfeW91X3NlZWtfa2VlcF9sb29raW5n";
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.btnLogin = new Button();
      this.lblUsername = new Label();
      this.txtUsername = new TextBox();
      this.btnCancel = new Button();
      this.groupBox1 = new GroupBox();
      this.lblPassword = new Label();
      this.txtPassword = new TextBox();
      this.groupBox1.SuspendLayout();
      this.SuspendLayout();
      this.btnLogin.Location = new Point(190, 120);
      this.btnLogin.Name = "btnLogin";
      this.btnLogin.Size = new Size(75, 23);
      this.btnLogin.TabIndex = 0;
      this.btnLogin.Text = "&OK";
      this.btnLogin.UseVisualStyleBackColor = true;
      this.btnLogin.Click += new EventHandler(this.btnLogin_Click);
      this.lblUsername.AutoSize = true;
      this.lblUsername.Location = new Point(6, 32);
      this.lblUsername.Name = "lblUsername";
      this.lblUsername.Size = new Size(58, 13);
      this.lblUsername.TabIndex = 1;
      this.lblUsername.Text = "Username:";
      this.lblUsername.TextAlign = ContentAlignment.TopRight;
      this.txtUsername.Location = new Point(70, 29);
      this.txtUsername.Name = "txtUsername";
      this.txtUsername.Size = new Size(154, 20);
      this.txtUsername.TabIndex = 2;
      this.btnCancel.Location = new Point(109, 120);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new Size(75, 23);
      this.btnCancel.TabIndex = 3;
      this.btnCancel.Text = "&Cancel";
      this.btnCancel.UseVisualStyleBackColor = true;
      this.btnCancel.Click += new EventHandler(this.btnCancel_Click);
      this.groupBox1.Controls.Add((Control) this.lblPassword);
      this.groupBox1.Controls.Add((Control) this.txtPassword);
      this.groupBox1.Controls.Add((Control) this.lblUsername);
      this.groupBox1.Controls.Add((Control) this.txtUsername);
      this.groupBox1.Location = new Point(12, 12);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new Size(253, 102);
      this.groupBox1.TabIndex = 4;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Login";
      this.lblPassword.AutoSize = true;
      this.lblPassword.Location = new Point(6, 58);
      this.lblPassword.Name = "lblPassword";
      this.lblPassword.Size = new Size(56, 13);
      this.lblPassword.TabIndex = 3;
      this.lblPassword.Text = "Password:";
      this.lblPassword.TextAlign = ContentAlignment.TopRight;
      this.txtPassword.Location = new Point(70, 55);
      this.txtPassword.Name = "txtPassword";
      this.txtPassword.PasswordChar = '*';
      this.txtPassword.Size = new Size(154, 20);
      this.txtPassword.TabIndex = 4;
      this.AcceptButton = (IButtonControl) this.btnLogin;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.CancelButton = (IButtonControl) this.btnCancel;
      this.ClientSize = new Size(290, 154);
      this.ControlBox = false;
      this.Controls.Add((Control) this.groupBox1);
      this.Controls.Add((Control) this.btnCancel);
      this.Controls.Add((Control) this.btnLogin);
      this.Name = nameof (employee_payroll);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Employee Payroll";
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.ResumeLayout(false);
    }
  }
}
