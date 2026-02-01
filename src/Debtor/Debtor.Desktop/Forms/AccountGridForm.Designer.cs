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
        button_ExportCSV = new Button();
        saveFileDialog_ExportCSV = new SaveFileDialog();
        button_Delete = new Button();
        button_Create = new Button();
        button_Update = new Button();
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
        dataGridView_Accounts.MultiSelect = false;
        dataGridView_Accounts.Name = "dataGridView_Accounts";
        dataGridView_Accounts.ReadOnly = true;
        dataGridView_Accounts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dataGridView_Accounts.Size = new Size(1310, 587);
        dataGridView_Accounts.TabIndex = 0;
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
        // button_Create
        // 
        button_Create.Location = new Point(296, 605);
        button_Create.Name = "button_Create";
        button_Create.Size = new Size(136, 34);
        button_Create.TabIndex = 1;
        button_Create.Text = "Create";
        button_Create.UseVisualStyleBackColor = true;
        button_Create.Click += Button_Create_Click;
        // 
        // button_Update
        // 
        button_Update.Location = new Point(438, 605);
        button_Update.Name = "button_Update";
        button_Update.Size = new Size(136, 34);
        button_Update.TabIndex = 1;
        button_Update.Text = "Update";
        button_Update.UseVisualStyleBackColor = true;
        button_Update.Click += Button_Update_Click;
        // 
        // AccountGridForm
        // 
        AutoScaleDimensions = new SizeF(11F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1334, 651);
        Controls.Add(button_Update);
        Controls.Add(button_Create);
        Controls.Add(button_Delete);
        Controls.Add(button_ExportCSV);
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
    private Button button_ExportCSV;
    private SaveFileDialog saveFileDialog_ExportCSV;
    private Button button_Delete;
    private Button button_Create;
    private Button button_Update;
}