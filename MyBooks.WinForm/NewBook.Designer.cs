namespace MyBooks.WinForm
{
    partial class NewBook
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
            genreComboBox = new ComboBox();
            addBtn = new Button();
            titleLabel = new Label();
            publicationDateLabel = new Label();
            numberOfPagesLabel = new Label();
            authorLabel = new Label();
            genreLabel = new Label();
            descriptionLabel = new Label();
            titleTextBox = new TextBox();
            descriptionTextBox = new TextBox();
            numberOfPagesNumericUpDown = new NumericUpDown();
            publicationDateTimePicker = new DateTimePicker();
            authorComboBox = new ComboBox();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numberOfPagesNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanel1.Controls.Add(genreComboBox, 1, 4);
            tableLayoutPanel1.Controls.Add(addBtn, 0, 6);
            tableLayoutPanel1.Controls.Add(titleLabel, 0, 0);
            tableLayoutPanel1.Controls.Add(publicationDateLabel, 0, 1);
            tableLayoutPanel1.Controls.Add(numberOfPagesLabel, 0, 2);
            tableLayoutPanel1.Controls.Add(authorLabel, 0, 3);
            tableLayoutPanel1.Controls.Add(genreLabel, 0, 4);
            tableLayoutPanel1.Controls.Add(descriptionLabel, 0, 5);
            tableLayoutPanel1.Controls.Add(titleTextBox, 1, 0);
            tableLayoutPanel1.Controls.Add(descriptionTextBox, 1, 5);
            tableLayoutPanel1.Controls.Add(numberOfPagesNumericUpDown, 1, 2);
            tableLayoutPanel1.Controls.Add(publicationDateTimePicker, 1, 1);
            tableLayoutPanel1.Controls.Add(authorComboBox, 1, 3);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(334, 411);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // genreComboBox
            // 
            genreComboBox.Anchor = AnchorStyles.None;
            genreComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            genreComboBox.FormattingEnabled = true;
            genreComboBox.Location = new Point(142, 249);
            genreComboBox.Name = "genreComboBox";
            genreComboBox.Size = new Size(150, 23);
            genreComboBox.TabIndex = 12;
            // 
            // addBtn
            // 
            addBtn.Anchor = AnchorStyles.None;
            tableLayoutPanel1.SetColumnSpan(addBtn, 2);
            addBtn.Location = new Point(129, 368);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(75, 23);
            addBtn.TabIndex = 0;
            addBtn.Text = "Añadir";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += AddBtn_Click;
            // 
            // titleLabel
            // 
            titleLabel.Anchor = AnchorStyles.None;
            titleLabel.AutoSize = true;
            titleLabel.Location = new Point(31, 21);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(37, 15);
            titleLabel.TabIndex = 1;
            titleLabel.Text = "Título";
            // 
            // publicationDateLabel
            // 
            publicationDateLabel.Anchor = AnchorStyles.None;
            publicationDateLabel.AutoSize = true;
            publicationDateLabel.Location = new Point(15, 72);
            publicationDateLabel.Name = "publicationDateLabel";
            publicationDateLabel.Size = new Size(69, 30);
            publicationDateLabel.TabIndex = 2;
            publicationDateLabel.Text = "Fecha de publicación";
            publicationDateLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // numberOfPagesLabel
            // 
            numberOfPagesLabel.Anchor = AnchorStyles.None;
            numberOfPagesLabel.AutoSize = true;
            numberOfPagesLabel.Location = new Point(16, 130);
            numberOfPagesLabel.Name = "numberOfPagesLabel";
            numberOfPagesLabel.Size = new Size(67, 30);
            numberOfPagesLabel.TabIndex = 3;
            numberOfPagesLabel.Text = "Número de páginas";
            numberOfPagesLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // authorLabel
            // 
            authorLabel.Anchor = AnchorStyles.None;
            authorLabel.AutoSize = true;
            authorLabel.Location = new Point(31, 195);
            authorLabel.Name = "authorLabel";
            authorLabel.Size = new Size(37, 15);
            authorLabel.TabIndex = 4;
            authorLabel.Text = "Autor";
            // 
            // genreLabel
            // 
            genreLabel.Anchor = AnchorStyles.None;
            genreLabel.AutoSize = true;
            genreLabel.Location = new Point(27, 253);
            genreLabel.Name = "genreLabel";
            genreLabel.Size = new Size(45, 15);
            genreLabel.TabIndex = 5;
            genreLabel.Text = "Género";
            // 
            // descriptionLabel
            // 
            descriptionLabel.Anchor = AnchorStyles.None;
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new Point(15, 311);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(69, 15);
            descriptionLabel.TabIndex = 6;
            descriptionLabel.Text = "Descripción";
            // 
            // titleTextBox
            // 
            titleTextBox.Anchor = AnchorStyles.None;
            titleTextBox.Location = new Point(142, 17);
            titleTextBox.Name = "titleTextBox";
            titleTextBox.Size = new Size(150, 23);
            titleTextBox.TabIndex = 7;
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Anchor = AnchorStyles.None;
            descriptionTextBox.Location = new Point(142, 307);
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.Size = new Size(150, 23);
            descriptionTextBox.TabIndex = 8;
            // 
            // numberOfPagesNumericUpDown
            // 
            numberOfPagesNumericUpDown.Anchor = AnchorStyles.None;
            numberOfPagesNumericUpDown.Location = new Point(157, 133);
            numberOfPagesNumericUpDown.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numberOfPagesNumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numberOfPagesNumericUpDown.Name = "numberOfPagesNumericUpDown";
            numberOfPagesNumericUpDown.Size = new Size(120, 23);
            numberOfPagesNumericUpDown.TabIndex = 9;
            numberOfPagesNumericUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numberOfPagesNumericUpDown.ValueChanged += NumberOfPagesNumericUpDown_ValueChanged;
            // 
            // publicationDateTimePicker
            // 
            publicationDateTimePicker.Anchor = AnchorStyles.None;
            publicationDateTimePicker.Checked = false;
            publicationDateTimePicker.Format = DateTimePickerFormat.Short;
            publicationDateTimePicker.Location = new Point(167, 75);
            publicationDateTimePicker.Name = "publicationDateTimePicker";
            publicationDateTimePicker.Size = new Size(100, 23);
            publicationDateTimePicker.TabIndex = 10;
            // 
            // authorComboBox
            // 
            authorComboBox.Anchor = AnchorStyles.None;
            authorComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            authorComboBox.FormattingEnabled = true;
            authorComboBox.Location = new Point(142, 191);
            authorComboBox.Name = "authorComboBox";
            authorComboBox.Size = new Size(150, 23);
            authorComboBox.TabIndex = 11;
            // 
            // NewBook
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(334, 411);
            Controls.Add(tableLayoutPanel1);
            Name = "NewBook";
            Tag = "false";
            Text = "Nuevo libro";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numberOfPagesNumericUpDown).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button addBtn;
        private Label titleLabel;
        private Label publicationDateLabel;
        private Label numberOfPagesLabel;
        private Label authorLabel;
        private Label genreLabel;
        private Label descriptionLabel;
        private TextBox titleTextBox;
        private TextBox descriptionTextBox;
        private NumericUpDown numberOfPagesNumericUpDown;
        private DateTimePicker publicationDateTimePicker;
        private ComboBox genreComboBox;
        private ComboBox authorComboBox;
    }
}