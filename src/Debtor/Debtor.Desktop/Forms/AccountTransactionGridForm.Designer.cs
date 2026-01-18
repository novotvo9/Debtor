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
        button_ExportCSV = new Button();
        saveFileDialog_ExportCSV = new SaveFileDialog();
        button_Delete = new Button();
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
        // button_ExportCSV
        // 
        button_ExportCSV.Location = new Point(12, 605);
        button_ExportCSV.Name = "button_ExportCSV";
        button_ExportCSV.Size = new Size(136, 34);
        button_ExportCSV.TabIndex = 1;
        button_ExportCSV.Text = "Export - CSV";
        button_ExportCSV.UseVisualStyleBackColor = true;
        button_ExportCSV.Click += Button_ExportCSV_Click;
        // 
        // saveFileDialog_ExportCSV
        // 
        saveFileDialog_ExportCSV.DefaultExt = "csv";
        saveFileDialog_ExportCSV.FileName = "Placeholder";
        saveFileDialog_ExportCSV.Filter = "CSV files|*.csv";
        // 
        // button_Delete
        // 
        button_Delete.Location = new Point(154, 605);
        button_Delete.Name = "button_Delete";
        button_Delete.Size = new Size(136, 34);
        button_Delete.TabIndex = 1;
        button_Delete.Text = "Delete";
        button_Delete.UseVisualStyleBackColor = true;
        button_Delete.Click += Button_Delete_Click;
        // 
        // AccountTransactionGridForm
        // 
        AutoScaleDimensions = new SizeF(11F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1334, 651);
        Controls.Add(button_Delete);
        Controls.Add(button_ExportCSV);
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
    private Button button_ExportCSV;
    private SaveFileDialog saveFileDialog_ExportCSV;
    private Button button_Delete;
}