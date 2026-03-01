namespace Debtor.Desktop.Forms;

partial class UserGridForm
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
        menuStrip_Menu = new MenuStrip();
        fileToolStripMenuItem = new ToolStripMenuItem();
        exitToolStripMenuItem = new ToolStripMenuItem();
        aboutDebtorToolStripMenuItem = new ToolStripMenuItem();
        githubToolStripMenuItem = new ToolStripMenuItem();
        statusStrip_Status = new StatusStrip();
        toolStripStatusLabel_Copyright = new ToolStripStatusLabel();
        dataGridView_Users = new DataGridView();
        menuStrip_Menu.SuspendLayout();
        statusStrip_Status.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dataGridView_Users).BeginInit();
        SuspendLayout();
        // 
        // menuStrip_Menu
        // 
        menuStrip_Menu.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, aboutDebtorToolStripMenuItem });
        menuStrip_Menu.Location = new Point(0, 0);
        menuStrip_Menu.Name = "menuStrip_Menu";
        menuStrip_Menu.Size = new Size(1334, 24);
        menuStrip_Menu.TabIndex = 0;
        menuStrip_Menu.Text = "menuStrip1";
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
        githubToolStripMenuItem.Size = new Size(110, 22);
        githubToolStripMenuItem.Text = "&Github";
        githubToolStripMenuItem.Click += GithubToolStripMenuItem_Click;
        // 
        // statusStrip_Status
        // 
        statusStrip_Status.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel_Copyright });
        statusStrip_Status.Location = new Point(0, 629);
        statusStrip_Status.Name = "statusStrip_Status";
        statusStrip_Status.Size = new Size(1334, 22);
        statusStrip_Status.TabIndex = 1;
        statusStrip_Status.Text = "statusStrip1";
        // 
        // toolStripStatusLabel_Copyright
        // 
        toolStripStatusLabel_Copyright.Name = "toolStripStatusLabel_Copyright";
        toolStripStatusLabel_Copyright.Size = new Size(1319, 17);
        toolStripStatusLabel_Copyright.Spring = true;
        toolStripStatusLabel_Copyright.Text = "©Vojtěch Novotný 2026";
        // 
        // dataGridView_Users
        // 
        dataGridView_Users.AllowUserToAddRows = false;
        dataGridView_Users.AllowUserToDeleteRows = false;
        dataGridView_Users.AllowUserToResizeColumns = false;
        dataGridView_Users.AllowUserToResizeRows = false;
        dataGridView_Users.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        dataGridView_Users.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        dataGridView_Users.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridView_Users.Location = new Point(12, 27);
        dataGridView_Users.MultiSelect = false;
        dataGridView_Users.Name = "dataGridView_Users";
        dataGridView_Users.ReadOnly = true;
        dataGridView_Users.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dataGridView_Users.Size = new Size(1310, 599);
        dataGridView_Users.TabIndex = 2;
        // 
        // UserGridForm
        // 
        AutoScaleDimensions = new SizeF(11F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1334, 651);
        Controls.Add(dataGridView_Users);
        Controls.Add(statusStrip_Status);
        Controls.Add(menuStrip_Menu);
        Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MainMenuStrip = menuStrip_Menu;
        Margin = new Padding(5);
        MaximizeBox = false;
        Name = "UserGridForm";
        StartPosition = FormStartPosition.CenterParent;
        Text = "User Grid Form";
        menuStrip_Menu.ResumeLayout(false);
        menuStrip_Menu.PerformLayout();
        statusStrip_Status.ResumeLayout(false);
        statusStrip_Status.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dataGridView_Users).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private MenuStrip menuStrip_Menu;
    private StatusStrip statusStrip_Status;
    private ToolStripStatusLabel toolStripStatusLabel_Copyright;
    private ToolStripMenuItem fileToolStripMenuItem;
    private ToolStripMenuItem exitToolStripMenuItem;
    private ToolStripMenuItem aboutDebtorToolStripMenuItem;
    private ToolStripMenuItem githubToolStripMenuItem;
    private DataGridView dataGridView_Users;
}