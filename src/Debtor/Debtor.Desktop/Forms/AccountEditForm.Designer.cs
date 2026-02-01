namespace Debtor.Desktop.Forms;

partial class AccountEditForm
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
        label_FullName = new Label();
        label_AccountType = new Label();
        label_Email = new Label();
        label_Phone = new Label();
        textBox_Name = new TextBox();
        comboBox_AccountTypes = new ComboBox();
        textBox_Email = new TextBox();
        textBox_Phone = new TextBox();
        button_Update = new Button();
        button_Cancel = new Button();
        SuspendLayout();
        // 
        // label_FullName
        // 
        label_FullName.AutoSize = true;
        label_FullName.Location = new Point(59, 21);
        label_FullName.Name = "label_FullName";
        label_FullName.Size = new Size(101, 25);
        label_FullName.TabIndex = 0;
        label_FullName.Text = "Full Name:";
        // 
        // label_AccountType
        // 
        label_AccountType.AutoSize = true;
        label_AccountType.Location = new Point(31, 55);
        label_AccountType.Name = "label_AccountType";
        label_AccountType.Size = new Size(129, 25);
        label_AccountType.TabIndex = 0;
        label_AccountType.Text = "Account Type:";
        // 
        // label_Email
        // 
        label_Email.AutoSize = true;
        label_Email.Location = new Point(98, 94);
        label_Email.Name = "label_Email";
        label_Email.Size = new Size(62, 25);
        label_Email.TabIndex = 0;
        label_Email.Text = "Email:";
        // 
        // label_Phone
        // 
        label_Phone.AutoSize = true;
        label_Phone.Location = new Point(90, 143);
        label_Phone.Name = "label_Phone";
        label_Phone.Size = new Size(70, 25);
        label_Phone.TabIndex = 0;
        label_Phone.Text = "Phone:";
        // 
        // textBox_Name
        // 
        textBox_Name.Location = new Point(166, 13);
        textBox_Name.MaxLength = 120;
        textBox_Name.Name = "textBox_Name";
        textBox_Name.Size = new Size(331, 33);
        textBox_Name.TabIndex = 1;
        // 
        // comboBox_AccountTypes
        // 
        comboBox_AccountTypes.DropDownStyle = ComboBoxStyle.DropDownList;
        comboBox_AccountTypes.FormattingEnabled = true;
        comboBox_AccountTypes.Location = new Point(166, 52);
        comboBox_AccountTypes.Name = "comboBox_AccountTypes";
        comboBox_AccountTypes.Size = new Size(331, 33);
        comboBox_AccountTypes.TabIndex = 2;
        // 
        // textBox_Email
        // 
        textBox_Email.Location = new Point(166, 91);
        textBox_Email.MaxLength = 254;
        textBox_Email.Name = "textBox_Email";
        textBox_Email.Size = new Size(331, 33);
        textBox_Email.TabIndex = 3;
        // 
        // textBox_Phone
        // 
        textBox_Phone.Location = new Point(166, 135);
        textBox_Phone.MaxLength = 32;
        textBox_Phone.Name = "textBox_Phone";
        textBox_Phone.Size = new Size(331, 33);
        textBox_Phone.TabIndex = 4;
        // 
        // button_Update
        // 
        button_Update.Location = new Point(267, 176);
        button_Update.Name = "button_Update";
        button_Update.Size = new Size(130, 37);
        button_Update.TabIndex = 5;
        button_Update.Text = "Edit / Create";
        button_Update.UseVisualStyleBackColor = true;
        button_Update.Click += Button_Update_Click;
        // 
        // button_Cancel
        // 
        button_Cancel.Location = new Point(403, 176);
        button_Cancel.Name = "button_Cancel";
        button_Cancel.Size = new Size(94, 37);
        button_Cancel.TabIndex = 5;
        button_Cancel.Text = "Cancel";
        button_Cancel.UseVisualStyleBackColor = true;
        // 
        // AccountEditForm
        // 
        AutoScaleDimensions = new SizeF(11F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(509, 225);
        Controls.Add(button_Cancel);
        Controls.Add(button_Update);
        Controls.Add(textBox_Phone);
        Controls.Add(textBox_Email);
        Controls.Add(comboBox_AccountTypes);
        Controls.Add(textBox_Name);
        Controls.Add(label_Phone);
        Controls.Add(label_Email);
        Controls.Add(label_AccountType);
        Controls.Add(label_FullName);
        Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Margin = new Padding(5);
        MaximizeBox = false;
        Name = "AccountEditForm";
        StartPosition = FormStartPosition.CenterParent;
        Text = "Account Edit";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label label_FullName;
    private Label label_AccountType;
    private Label label_Email;
    private Label label_Phone;
    private TextBox textBox_Name;
    private ComboBox comboBox_AccountTypes;
    private TextBox textBox_Email;
    private TextBox textBox_Phone;
    private Button button_Update;
    private Button button_Cancel;
}