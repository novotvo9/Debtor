namespace Debtor.Desktop.Forms;

partial class AccountTransactionGridForm
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
        dataGridView_AccountTransactions = new DataGridView();
        ((System.ComponentModel.ISupportInitialize)dataGridView_AccountTransactions).BeginInit();
        SuspendLayout();
        // 
        // dataGridView_AccountTransactions
        // 
        dataGridView_AccountTransactions.AllowUserToAddRows = false;
        dataGridView_AccountTransactions.AllowUserToDeleteRows = false;
        dataGridView_AccountTransactions.AllowUserToResizeColumns = false;
        dataGridView_AccountTransactions.AllowUserToResizeRows = false;
        dataGridView_AccountTransactions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        dataGridView_AccountTransactions.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        dataGridView_AccountTransactions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridView_AccountTransactions.Location = new Point(12, 12);
        dataGridView_AccountTransactions.Name = "dataGridView_AccountTransactions";
        dataGridView_AccountTransactions.ReadOnly = true;
        dataGridView_AccountTransactions.Size = new Size(1310, 587);
        dataGridView_AccountTransactions.TabIndex = 0;
        // 
        // AccountTransactionGridForm
        // 
        AutoScaleDimensions = new SizeF(11F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1334, 611);
        Controls.Add(dataGridView_AccountTransactions);
        Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Margin = new Padding(5);
        MaximizeBox = false;
        Name = "AccountTransactionGridForm";
        StartPosition = FormStartPosition.CenterParent;
        Text = "Account Transaction Grid Form";
        ((System.ComponentModel.ISupportInitialize)dataGridView_AccountTransactions).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private DataGridView dataGridView_AccountTransactions;
}