namespace Debtor.Desktop.Forms;

partial class AccountGridForm
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
        dataGridView_Accounts = new DataGridView();
        ((System.ComponentModel.ISupportInitialize)dataGridView_Accounts).BeginInit();
        SuspendLayout();
        // 
        // dataGridView_Accounts
        // 
        dataGridView_Accounts.AllowUserToAddRows = false;
        dataGridView_Accounts.AllowUserToDeleteRows = false;
        dataGridView_Accounts.AllowUserToResizeColumns = false;
        dataGridView_Accounts.AllowUserToResizeRows = false;
        dataGridView_Accounts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        dataGridView_Accounts.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        dataGridView_Accounts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridView_Accounts.Location = new Point(12, 12);
        dataGridView_Accounts.Name = "dataGridView_Accounts";
        dataGridView_Accounts.ReadOnly = true;
        dataGridView_Accounts.Size = new Size(1310, 587);
        dataGridView_Accounts.TabIndex = 0;
        // 
        // AccountGridForm
        // 
        AutoScaleDimensions = new SizeF(11F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1334, 611);
        Controls.Add(dataGridView_Accounts);
        Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Margin = new Padding(5);
        MaximizeBox = false;
        Name = "AccountGridForm";
        StartPosition = FormStartPosition.CenterParent;
        Text = "Account Grid Form";
        ((System.ComponentModel.ISupportInitialize)dataGridView_Accounts).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private DataGridView dataGridView_Accounts;
}