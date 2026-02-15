namespace Debtor.Desktop.Forms;

partial class WelcomeForm
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
        button_Login = new Button();
        button_Register = new Button();
        button_Exit = new Button();
        SuspendLayout();
        // 
        // button_Login
        // 
        button_Login.Location = new Point(49, 95);
        button_Login.Name = "button_Login";
        button_Login.Size = new Size(303, 261);
        button_Login.TabIndex = 0;
        button_Login.Text = "Login";
        button_Login.UseVisualStyleBackColor = true;
        button_Login.Click += Button_Login_Click;
        // 
        // button_Register
        // 
        button_Register.Location = new Point(358, 95);
        button_Register.Name = "button_Register";
        button_Register.Size = new Size(303, 261);
        button_Register.TabIndex = 0;
        button_Register.Text = "Register";
        button_Register.UseVisualStyleBackColor = true;
        button_Register.Click += Button_Register_Click;
        // 
        // button_Exit
        // 
        button_Exit.Location = new Point(49, 362);
        button_Exit.Name = "button_Exit";
        button_Exit.Size = new Size(612, 72);
        button_Exit.TabIndex = 1;
        button_Exit.Text = "Exit";
        button_Exit.UseVisualStyleBackColor = true;
        button_Exit.Click += Button_Exit_Click;
        // 
        // WelcomeForm
        // 
        AutoScaleDimensions = new SizeF(11F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(905, 532);
        Controls.Add(button_Exit);
        Controls.Add(button_Register);
        Controls.Add(button_Login);
        Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Margin = new Padding(5);
        MaximizeBox = false;
        Name = "WelcomeForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "WelcomeForm";
        ResumeLayout(false);
    }

    #endregion

    private Button button_Login;
    private Button button_Register;
    private Button button_Exit;
}