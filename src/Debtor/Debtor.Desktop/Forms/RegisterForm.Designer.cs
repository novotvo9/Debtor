namespace Debtor.Desktop.Forms;

partial class RegisterForm
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
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
        label_Email = new Label();
        label_Password = new Label();
        label_PasswordAgain = new Label();
        textBox_Email = new TextBox();
        textBox_Password = new TextBox();
        textBox_PasswordAgain = new TextBox();
        button_Register = new Button();
        button_Cancel = new Button();
        SuspendLayout();
        // 
        // label_Email
        // 
        label_Email.AutoSize = true;
        label_Email.Location = new Point(74, 65);
        label_Email.Name = "label_Email";
        label_Email.Size = new Size(62, 25);
        label_Email.TabIndex = 0;
        label_Email.Text = "Email:";
        // 
        // label_Password
        // 
        label_Password.AutoSize = true;
        label_Password.Location = new Point(63, 121);
        label_Password.Name = "label_Password";
        label_Password.Size = new Size(95, 25);
        label_Password.TabIndex = 1;
        label_Password.Text = "Password:";
        // 
        // label_PasswordAgain
        // 
        label_PasswordAgain.AutoSize = true;
        label_PasswordAgain.Location = new Point(25, 164);
        label_PasswordAgain.Name = "label_PasswordAgain";
        label_PasswordAgain.Size = new Size(149, 25);
        label_PasswordAgain.TabIndex = 1;
        label_PasswordAgain.Text = "Password Again:";
        // 
        // textBox_Email
        // 
        textBox_Email.Location = new Point(156, 62);
        textBox_Email.Name = "textBox_Email";
        textBox_Email.Size = new Size(186, 33);
        textBox_Email.TabIndex = 2;
        // 
        // textBox_Password
        // 
        textBox_Password.Location = new Point(164, 118);
        textBox_Password.Name = "textBox_Password";
        textBox_Password.PasswordChar = '*';
        textBox_Password.Size = new Size(178, 33);
        textBox_Password.TabIndex = 3;
        // 
        // textBox_PasswordAgain
        // 
        textBox_PasswordAgain.Location = new Point(164, 161);
        textBox_PasswordAgain.Name = "textBox_PasswordAgain";
        textBox_PasswordAgain.PasswordChar = '*';
        textBox_PasswordAgain.Size = new Size(178, 33);
        textBox_PasswordAgain.TabIndex = 3;
        // 
        // button_Register
        // 
        button_Register.Location = new Point(38, 228);
        button_Register.Name = "button_Register";
        button_Register.Size = new Size(120, 83);
        button_Register.TabIndex = 4;
        button_Register.Text = "Register";
        button_Register.UseVisualStyleBackColor = true;
        button_Register.Click += Button_Register_Click;
        // 
        // button_Cancel
        // 
        button_Cancel.Location = new Point(164, 228);
        button_Cancel.Name = "button_Cancel";
        button_Cancel.Size = new Size(120, 83);
        button_Cancel.TabIndex = 4;
        button_Cancel.Text = "Cancel";
        button_Cancel.UseVisualStyleBackColor = true;
        button_Cancel.Click += Button_Cancel_Click;
        // 
        // RegisterForm
        // 
        AutoScaleDimensions = new SizeF(11F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(365, 347);
        Controls.Add(button_Cancel);
        Controls.Add(button_Register);
        Controls.Add(textBox_PasswordAgain);
        Controls.Add(textBox_Password);
        Controls.Add(textBox_Email);
        Controls.Add(label_PasswordAgain);
        Controls.Add(label_Password);
        Controls.Add(label_Email);
        Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Margin = new Padding(5);
        MaximizeBox = false;
        Name = "RegisterForm";
        StartPosition = FormStartPosition.CenterParent;
        Text = "Register Form";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label label_Email;
    private Label label_Password;
    private Label label_PasswordAgain;
    private TextBox textBox_Email;
    private TextBox textBox_Password;
    private TextBox textBox_PasswordAgain;
    private Button button_Register;
    private Button button_Cancel;
}