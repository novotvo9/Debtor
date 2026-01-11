namespace Debtor.Desktop;

partial class MainForm
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        button_Accounts = new Button();
        button_AccountTransactions = new Button();
        SuspendLayout();
        // 
        // button_Accounts
        // 
        button_Accounts.Location = new Point(12, 12);
        button_Accounts.Name = "button_Accounts";
        button_Accounts.Size = new Size(280, 295);
        button_Accounts.TabIndex = 0;
        button_Accounts.Text = "Accounts";
        button_Accounts.UseVisualStyleBackColor = true;
        button_Accounts.Click += Button_Accounts_Click;
        // 
        // button_AccountTransactions
        // 
        button_AccountTransactions.Location = new Point(304, 12);
        button_AccountTransactions.Name = "button_AccountTransactions";
        button_AccountTransactions.Size = new Size(280, 295);
        button_AccountTransactions.TabIndex = 0;
        button_AccountTransactions.Text = "Account Transactions";
        button_AccountTransactions.UseVisualStyleBackColor = true;
        button_AccountTransactions.Click += Button_AccountTransactions_Click;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(11F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(596, 319);
        Controls.Add(button_AccountTransactions);
        Controls.Add(button_Accounts);
        Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Margin = new Padding(5);
        MaximizeBox = false;
        Name = "MainForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Main Form";
        ResumeLayout(false);
    }

    #endregion

    private Button button_Accounts;
    private Button button_AccountTransactions;
}
