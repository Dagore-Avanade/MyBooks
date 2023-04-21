namespace MyBooks.WinForm
{
    partial class NewAuthor
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
            tableLayoutPanel1 = new TableLayoutPanel();
            dateTimePickerDeath = new DateTimePicker();
            countryTextBox = new TextBox();
            lastNameTextBox = new TextBox();
            firstNameLabel = new Label();
            lastNameLabel = new Label();
            countryLabel = new Label();
            dateOfBirthLabel = new Label();
            dateOfDeathLabel = new Label();
            firstNameTextBox = new TextBox();
            dateTimePickerBirth = new DateTimePicker();
            label6 = new Label();
            addBtn = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanel1.Controls.Add(dateTimePickerDeath, 1, 4);
            tableLayoutPanel1.Controls.Add(countryTextBox, 1, 2);
            tableLayoutPanel1.Controls.Add(lastNameTextBox, 1, 1);
            tableLayoutPanel1.Controls.Add(firstNameLabel, 0, 0);
            tableLayoutPanel1.Controls.Add(lastNameLabel, 0, 1);
            tableLayoutPanel1.Controls.Add(countryLabel, 0, 2);
            tableLayoutPanel1.Controls.Add(dateOfBirthLabel, 0, 3);
            tableLayoutPanel1.Controls.Add(dateOfDeathLabel, 0, 4);
            tableLayoutPanel1.Controls.Add(firstNameTextBox, 1, 0);
            tableLayoutPanel1.Controls.Add(dateTimePickerBirth, 1, 3);
            tableLayoutPanel1.Controls.Add(label6, 1, 5);
            tableLayoutPanel1.Controls.Add(addBtn, 0, 5);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(334, 411);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // dateTimePickerDeath
            // 
            dateTimePickerDeath.Anchor = AnchorStyles.None;
            dateTimePickerDeath.Checked = false;
            dateTimePickerDeath.Format = DateTimePickerFormat.Short;
            dateTimePickerDeath.Location = new Point(167, 281);
            dateTimePickerDeath.Name = "dateTimePickerDeath";
            dateTimePickerDeath.Size = new Size(100, 23);
            dateTimePickerDeath.TabIndex = 10;
            // 
            // countryTextBox
            // 
            countryTextBox.Anchor = AnchorStyles.None;
            countryTextBox.Location = new Point(142, 151);
            countryTextBox.Name = "countryTextBox";
            countryTextBox.Size = new Size(150, 23);
            countryTextBox.TabIndex = 8;
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Anchor = AnchorStyles.None;
            lastNameTextBox.Location = new Point(142, 86);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(150, 23);
            lastNameTextBox.TabIndex = 7;
            // 
            // firstNameLabel
            // 
            firstNameLabel.Anchor = AnchorStyles.None;
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new Point(24, 25);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(51, 15);
            firstNameLabel.TabIndex = 0;
            firstNameLabel.Text = "Nombre";
            // 
            // lastNameLabel
            // 
            lastNameLabel.Anchor = AnchorStyles.None;
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new Point(18, 90);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(64, 15);
            lastNameLabel.TabIndex = 1;
            lastNameLabel.Text = "Apellido(s)";
            // 
            // countryLabel
            // 
            countryLabel.Anchor = AnchorStyles.None;
            countryLabel.AutoSize = true;
            countryLabel.Location = new Point(36, 155);
            countryLabel.Name = "countryLabel";
            countryLabel.Size = new Size(28, 15);
            countryLabel.TabIndex = 2;
            countryLabel.Text = "País";
            // 
            // dateOfBirthLabel
            // 
            dateOfBirthLabel.Anchor = AnchorStyles.None;
            dateOfBirthLabel.AutoSize = true;
            dateOfBirthLabel.Location = new Point(15, 220);
            dateOfBirthLabel.Name = "dateOfBirthLabel";
            dateOfBirthLabel.Size = new Size(69, 15);
            dateOfBirthLabel.TabIndex = 3;
            dateOfBirthLabel.Text = "Nacimiento";
            // 
            // dateOfDeathLabel
            // 
            dateOfDeathLabel.Anchor = AnchorStyles.None;
            dateOfDeathLabel.AutoSize = true;
            dateOfDeathLabel.Location = new Point(11, 285);
            dateOfDeathLabel.Name = "dateOfDeathLabel";
            dateOfDeathLabel.Size = new Size(78, 15);
            dateOfDeathLabel.TabIndex = 4;
            dateOfDeathLabel.Text = "Fallecimiento";
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Anchor = AnchorStyles.None;
            firstNameTextBox.Location = new Point(142, 21);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(150, 23);
            firstNameTextBox.TabIndex = 6;
            // 
            // dateTimePickerBirth
            // 
            dateTimePickerBirth.Anchor = AnchorStyles.None;
            dateTimePickerBirth.Checked = false;
            dateTimePickerBirth.Format = DateTimePickerFormat.Short;
            dateTimePickerBirth.Location = new Point(167, 216);
            dateTimePickerBirth.Name = "dateTimePickerBirth";
            dateTimePickerBirth.Size = new Size(100, 23);
            dateTimePickerBirth.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 390);
            label6.Name = "label6";
            label6.Size = new Size(0, 15);
            label6.TabIndex = 5;
            // 
            // addBtn
            // 
            addBtn.Anchor = AnchorStyles.None;
            tableLayoutPanel1.SetColumnSpan(addBtn, 2);
            addBtn.Location = new Point(129, 346);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(75, 23);
            addBtn.TabIndex = 11;
            addBtn.Text = "Añadir";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += AddBtn_Click;
            // 
            // NewAuthor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(334, 411);
            Controls.Add(tableLayoutPanel1);
            Name = "NewAuthor";
            Text = "Nuevo autor";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TextBox lastNameTextBox;
        private Label firstNameLabel;
        private Label lastNameLabel;
        private Label countryLabel;
        private Label dateOfBirthLabel;
        private Label dateOfDeathLabel;
        private Label label6;
        private TextBox firstNameTextBox;
        private TextBox countryTextBox;
        private DateTimePicker dateTimePickerDeath;
        private DateTimePicker dateTimePickerBirth;
        private Button addBtn;
    }
}