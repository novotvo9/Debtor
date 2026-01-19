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
        menuStrip_Toolbar = new MenuStrip();
        fileToolStripMenuItem = new ToolStripMenuItem();
        exitToolStripMenuItem = new ToolStripMenuItem();
        aboutDebtorToolStripMenuItem = new ToolStripMenuItem();
        githubToolStripMenuItem = new ToolStripMenuItem();
        statusStrip_Status = new StatusStrip();
        toolStripStatusLabel_Copyright = new ToolStripStatusLabel();
        menuStrip_Toolbar.SuspendLayout();
        statusStrip_Status.SuspendLayout();
        SuspendLayout();
        // 
        // button_Accounts
        // 
        button_Accounts.Location = new Point(12, 27);
        button_Accounts.Name = "button_Accounts";
        button_Accounts.Size = new Size(280, 294);
        button_Accounts.TabIndex = 0;
        button_Accounts.Text = "Accounts";
        button_Accounts.UseVisualStyleBackColor = true;
        button_Accounts.Click += Button_Accounts_Click;
        // 
        // button_AccountTransactions
        // 
        button_AccountTransactions.Location = new Point(304, 27);
        button_AccountTransactions.Name = "button_AccountTransactions";
        button_AccountTransactions.Size = new Size(280, 294);
        button_AccountTransactions.TabIndex = 0;
        button_AccountTransactions.Text = "Account Transactions";
        button_AccountTransactions.UseVisualStyleBackColor = true;
        button_AccountTransactions.Click += Button_AccountTransactions_Click;
        // 
        // menuStrip_Toolbar
        // 
        menuStrip_Toolbar.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, aboutDebtorToolStripMenuItem });
        menuStrip_Toolbar.Location = new Point(0, 0);
        menuStrip_Toolbar.Name = "menuStrip_Toolbar";
        menuStrip_Toolbar.RenderMode = ToolStripRenderMode.Professional;
        menuStrip_Toolbar.Size = new Size(596, 24);
        menuStrip_Toolbar.TabIndex = 1;
        menuStrip_Toolbar.Text = "Toolbar";
        // 
        // fileToolStripMenuItem
        // 
        fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exitToolStripMenuItem });
        fileToolStripMenuItem.Name = "fileToolStripMenuItem";
        fileToolStripMenuItem.Size = new Size(37, 20);
        fileToolStripMenuItem.Text = "&File";
        // 
        // exitToolStripMenuItem
        // 
        exitToolStripMenuItem.Name = "exitToolStripMenuItem";
        exitToolStripMenuItem.Size = new Size(92, 22);
        exitToolStripMenuItem.Text = "E&xit";
        exitToolStripMenuItem.Click += ExitToolStripMenuItem_Click;
        // 
        // aboutDebtorToolStripMenuItem
        // 
        aboutDebtorToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { githubToolStripMenuItem });
        aboutDebtorToolStripMenuItem.Name = "aboutDebtorToolStripMenuItem";
        aboutDebtorToolStripMenuItem.Size = new Size(91, 20);
        aboutDebtorToolStripMenuItem.Text = "&About Debtor";
        // 
        // githubToolStripMenuItem
        // 
        githubToolStripMenuItem.Name = "githubToolStripMenuItem";
        githubToolStripMenuItem.Size = new Size(180, 22);
        githubToolStripMenuItem.Text = "&Github";
        githubToolStripMenuItem.Click += GithubToolStripMenuItem_Click;
        // 
        // statusStrip_Status
        // 
        statusStrip_Status.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel_Copyright });
        statusStrip_Status.Location = new Point(0, 324);
        statusStrip_Status.Name = "statusStrip_Status";
        statusStrip_Status.RenderMode = ToolStripRenderMode.Professional;
        statusStrip_Status.Size = new Size(596, 22);
        statusStrip_Status.TabIndex = 2;
        statusStrip_Status.Text = "statusStrip1";
        // 
        // toolStripStatusLabel_Copyright
        // 
        toolStripStatusLabel_Copyright.Name = "toolStripStatusLabel_Copyright";
        toolStripStatusLabel_Copyright.Size = new Size(581, 17);
        toolStripStatusLabel_Copyright.Spring = true;
        toolStripStatusLabel_Copyright.Text = "@Vojtěch Novotný 2026";
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(11F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(596, 346);
        Controls.Add(statusStrip_Status);
        Controls.Add(button_AccountTransactions);
        Controls.Add(button_Accounts);
        Controls.Add(menuStrip_Toolbar);
        Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MainMenuStrip = menuStrip_Toolbar;
        Margin = new Padding(5);
        MaximizeBox = false;
        Name = "MainForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Debtor";
        menuStrip_Toolbar.ResumeLayout(false);
        menuStrip_Toolbar.PerformLayout();
        statusStrip_Status.ResumeLayout(false);
        statusStrip_Status.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button button_Accounts;
    private Button button_AccountTransactions;
    private MenuStrip menuStrip_Toolbar;
    private ToolStripMenuItem fileToolStripMenuItem;
    private ToolStripMenuItem exitToolStripMenuItem;
    private ToolStripMenuItem aboutDebtorToolStripMenuItem;
    private ToolStripMenuItem githubToolStripMenuItem;
    private StatusStrip statusStrip_Status;
    private ToolStripStatusLabel toolStripStatusLabel_Copyright;
}
