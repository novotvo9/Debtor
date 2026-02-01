namespace Debtor.Desktop.Forms;

partial class AccountTransactionEditForm
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
        button_Cancel = new Button();
        button_Update = new Button();
        label_Account = new Label();
        comboBox_Accounts = new ComboBox();
        label_TransactionType = new Label();
        comboBox_TransactionTypes = new ComboBox();
        label_Amount = new Label();
        numericUpDown_Amount = new NumericUpDown();
        label_Currency = new Label();
        textBox_Currency = new TextBox();
        mySqlDataAdapter1 = new MySql.Data.MySqlClient.MySqlDataAdapter();
        groupBox1 = new GroupBox();
        radioButton_Cash = new RadioButton();
        radioButton_Bank = new RadioButton();
        ((System.ComponentModel.ISupportInitialize)numericUpDown_Amount).BeginInit();
        groupBox1.SuspendLayout();
        SuspendLayout();
        // 
        // button_Cancel
        // 
        button_Cancel.Location = new Point(403, 202);
        button_Cancel.Name = "button_Cancel";
        button_Cancel.Size = new Size(94, 37);
        button_Cancel.TabIndex = 0;
        button_Cancel.Text = "Cancel";
        button_Cancel.UseVisualStyleBackColor = true;
        button_Cancel.Click += Button_Cancel_Click;
        // 
        // button_Update
        // 
        button_Update.Location = new Point(246, 202);
        button_Update.Name = "button_Update";
        button_Update.Size = new Size(151, 37);
        button_Update.TabIndex = 0;
        button_Update.Text = "Edit / Create";
        button_Update.UseVisualStyleBackColor = true;
        button_Update.Click += Button_Update_Click;
        // 
        // label_Account
        // 
        label_Account.AutoSize = true;
        label_Account.Location = new Point(91, 15);
        label_Account.Name = "label_Account";
        label_Account.Size = new Size(85, 25);
        label_Account.TabIndex = 1;
        label_Account.Text = "Account:";
        // 
        // comboBox_Accounts
        // 
        comboBox_Accounts.FormattingEnabled = true;
        comboBox_Accounts.Location = new Point(182, 12);
        comboBox_Accounts.Name = "comboBox_Accounts";
        comboBox_Accounts.Size = new Size(315, 33);
        comboBox_Accounts.TabIndex = 2;
        // 
        // label_TransactionType
        // 
        label_TransactionType.AutoSize = true;
        label_TransactionType.Location = new Point(20, 54);
        label_TransactionType.Name = "label_TransactionType";
        label_TransactionType.Size = new Size(156, 25);
        label_TransactionType.TabIndex = 1;
        label_TransactionType.Text = "Transaction Type:";
        // 
        // comboBox_TransactionTypes
        // 
        comboBox_TransactionTypes.FormattingEnabled = true;
        comboBox_TransactionTypes.Location = new Point(182, 51);
        comboBox_TransactionTypes.Name = "comboBox_TransactionTypes";
        comboBox_TransactionTypes.Size = new Size(315, 33);
        comboBox_TransactionTypes.TabIndex = 2;
        // 
        // label_Amount
        // 
        label_Amount.AutoSize = true;
        label_Amount.Location = new Point(91, 92);
        label_Amount.Name = "label_Amount";
        label_Amount.Size = new Size(83, 25);
        label_Amount.TabIndex = 1;
        label_Amount.Text = "Amount:";
        // 
        // numericUpDown_Amount
        // 
        numericUpDown_Amount.DecimalPlaces = 2;
        numericUpDown_Amount.Location = new Point(182, 90);
        numericUpDown_Amount.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
        numericUpDown_Amount.Name = "numericUpDown_Amount";
        numericUpDown_Amount.Size = new Size(315, 33);
        numericUpDown_Amount.TabIndex = 3;
        // 
        // label_Currency
        // 
        label_Currency.AutoSize = true;
        label_Currency.Location = new Point(84, 132);
        label_Currency.Name = "label_Currency";
        label_Currency.Size = new Size(92, 25);
        label_Currency.TabIndex = 1;
        label_Currency.Text = "Currency:";
        // 
        // textBox_Currency
        // 
        textBox_Currency.Location = new Point(182, 129);
        textBox_Currency.MaxLength = 3;
        textBox_Currency.Name = "textBox_Currency";
        textBox_Currency.Size = new Size(315, 33);
        textBox_Currency.TabIndex = 4;
        // 
        // mySqlDataAdapter1
        // 
        mySqlDataAdapter1.DeleteCommand = null;
        mySqlDataAdapter1.InsertCommand = null;
        mySqlDataAdapter1.SelectCommand = null;
        mySqlDataAdapter1.UpdateCommand = null;
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(radioButton_Cash);
        groupBox1.Controls.Add(radioButton_Bank);
        groupBox1.Location = new Point(12, 168);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new Size(213, 71);
        groupBox1.TabIndex = 5;
        groupBox1.TabStop = false;
        groupBox1.Text = "Payment Method:";
        // 
        // radioButton_Cash
        // 
        radioButton_Cash.AutoSize = true;
        radioButton_Cash.Location = new Point(118, 34);
        radioButton_Cash.Name = "radioButton_Cash";
        radioButton_Cash.Size = new Size(71, 29);
        radioButton_Cash.TabIndex = 1;
        radioButton_Cash.Text = "Cash";
        radioButton_Cash.UseVisualStyleBackColor = true;
        // 
        // radioButton_Bank
        // 
        radioButton_Bank.AutoSize = true;
        radioButton_Bank.Checked = true;
        radioButton_Bank.Location = new Point(26, 34);
        radioButton_Bank.Name = "radioButton_Bank";
        radioButton_Bank.Size = new Size(71, 29);
        radioButton_Bank.TabIndex = 0;
        radioButton_Bank.TabStop = true;
        radioButton_Bank.Text = "Bank";
        radioButton_Bank.UseVisualStyleBackColor = true;
        // 
        // AccountTransactionEditForm
        // 
        AutoScaleDimensions = new SizeF(11F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(509, 255);
        Controls.Add(groupBox1);
        Controls.Add(textBox_Currency);
        Controls.Add(numericUpDown_Amount);
        Controls.Add(comboBox_TransactionTypes);
        Controls.Add(comboBox_Accounts);
        Controls.Add(label_Currency);
        Controls.Add(label_Amount);
        Controls.Add(label_TransactionType);
        Controls.Add(label_Account);
        Controls.Add(button_Update);
        Controls.Add(button_Cancel);
        Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Margin = new Padding(5);
        MaximizeBox = false;
        Name = "AccountTransactionEditForm";
        StartPosition = FormStartPosition.CenterParent;
        Text = "Transaction Edit";
        ((System.ComponentModel.ISupportInitialize)numericUpDown_Amount).EndInit();
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button button_Cancel;
    private Button button_Update;
    private Label label_Account;
    private ComboBox comboBox_Accounts;
    private Label label_TransactionType;
    private ComboBox comboBox_TransactionTypes;
    private Label label_Amount;
    private NumericUpDown numericUpDown_Amount;
    private Label label_Currency;
    private TextBox textBox_Currency;
    private MySql.Data.MySqlClient.MySqlDataAdapter mySqlDataAdapter1;
    private GroupBox groupBox1;
    private RadioButton radioButton_Cash;
    private RadioButton radioButton_Bank;
}