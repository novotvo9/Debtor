namespace Debtor.Desktop.Forms;

partial class LoginForm
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
        textBox_Email = new TextBox();
        textBox_Password = new TextBox();
        button_Login = new Button();
        button_Cancel = new Button();
        SuspendLayout();
        // 
        // label_Email
        // 
        label_Email.AutoSize = true;
        label_Email.Location = new Point(61, 37);
        label_Email.Name = "label_Email";
        label_Email.Size = new Size(62, 25);
        label_Email.TabIndex = 0;
        label_Email.Text = "Email:";
        // 
        // label_Password
        // 
        label_Password.AutoSize = true;
        label_Password.Location = new Point(28, 95);
        label_Password.Name = "label_Password";
        label_Password.Size = new Size(95, 25);
        label_Password.TabIndex = 1;
        label_Password.Text = "Password:";
        // 
        // textBox_Email
        // 
        textBox_Email.Location = new Point(129, 34);
        textBox_Email.Name = "textBox_Email";
        textBox_Email.Size = new Size(289, 33);
        textBox_Email.TabIndex = 2;
        // 
        // textBox_Password
        // 
        textBox_Password.Location = new Point(129, 92);
        textBox_Password.Name = "textBox_Password";
        textBox_Password.PasswordChar = '*';
        textBox_Password.Size = new Size(289, 33);
        textBox_Password.TabIndex = 3;
        // 
        // button_Login
        // 
        button_Login.Location = new Point(28, 151);
        button_Login.Name = "button_Login";
        button_Login.Size = new Size(105, 58);
        button_Login.TabIndex = 4;
        button_Login.Text = "Login";
        button_Login.UseVisualStyleBackColor = true;
        button_Login.Click += Button_Login_Click;
        // 
        // button_Cancel
        // 
        button_Cancel.Location = new Point(139, 151);
        button_Cancel.Name = "button_Cancel";
        button_Cancel.Size = new Size(105, 58);
        button_Cancel.TabIndex = 4;
        button_Cancel.Text = "Cancel";
        button_Cancel.UseVisualStyleBackColor = true;
        button_Cancel.Click += Button_Cancel_Click;
        // 
        // LoginForm
        // 
        AutoScaleDimensions = new SizeF(11F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(495, 221);
        Controls.Add(button_Cancel);
        Controls.Add(button_Login);
        Controls.Add(textBox_Password);
        Controls.Add(textBox_Email);
        Controls.Add(label_Password);
        Controls.Add(label_Email);
        Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Margin = new Padding(5);
        MaximizeBox = false;
        Name = "LoginForm";
        StartPosition = FormStartPosition.CenterParent;
        Text = "Login Form";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label label_Email;
    private Label label_Password;
    private TextBox textBox_Email;
    private TextBox textBox_Password;
    private Button button_Login;
    private Button button_Cancel;
}