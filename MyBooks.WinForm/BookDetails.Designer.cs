namespace MyBooks.WinForm
{
    partial class BookDetails
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
            titleLabel = new Label();
            publicationDateLabel = new Label();
            numberOfPagesLabel = new Label();
            authorLabel = new Label();
            genreLabel = new Label();
            descriptionLabel = new Label();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(descriptionLabel, 0, 5);
            tableLayoutPanel1.Controls.Add(genreLabel, 0, 4);
            tableLayoutPanel1.Controls.Add(authorLabel, 0, 3);
            tableLayoutPanel1.Controls.Add(numberOfPagesLabel, 0, 2);
            tableLayoutPanel1.Controls.Add(publicationDateLabel, 0, 1);
            tableLayoutPanel1.Controls.Add(titleLabel, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 13.63636F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 13.6363649F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 13.6363649F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 13.6363649F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 13.6363649F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 31.818182F));
            tableLayoutPanel1.Size = new Size(284, 311);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Dock = DockStyle.Fill;
            titleLabel.Location = new Point(3, 0);
            titleLabel.Name = "titleLabel";
            titleLabel.Padding = new Padding(12, 0, 0, 0);
            titleLabel.Size = new Size(278, 42);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "titleLabel";
            titleLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // publicationDateLabel
            // 
            publicationDateLabel.AutoSize = true;
            publicationDateLabel.Dock = DockStyle.Fill;
            publicationDateLabel.Location = new Point(3, 42);
            publicationDateLabel.Name = "publicationDateLabel";
            publicationDateLabel.Padding = new Padding(12, 0, 0, 0);
            publicationDateLabel.Size = new Size(278, 42);
            publicationDateLabel.TabIndex = 1;
            publicationDateLabel.Text = "publicationDateLabel";
            publicationDateLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // numberOfPagesLabel
            // 
            numberOfPagesLabel.AutoSize = true;
            numberOfPagesLabel.Dock = DockStyle.Fill;
            numberOfPagesLabel.Location = new Point(3, 84);
            numberOfPagesLabel.Name = "numberOfPagesLabel";
            numberOfPagesLabel.Padding = new Padding(12, 0, 0, 0);
            numberOfPagesLabel.Size = new Size(278, 42);
            numberOfPagesLabel.TabIndex = 2;
            numberOfPagesLabel.Text = "numberOfPagesLabel";
            numberOfPagesLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // authorLabel
            // 
            authorLabel.AutoSize = true;
            authorLabel.Dock = DockStyle.Fill;
            authorLabel.Location = new Point(3, 126);
            authorLabel.Name = "authorLabel";
            authorLabel.Padding = new Padding(12, 0, 0, 0);
            authorLabel.Size = new Size(278, 42);
            authorLabel.TabIndex = 3;
            authorLabel.Text = "authorLabel";
            authorLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // genreLabel
            // 
            genreLabel.AutoSize = true;
            genreLabel.Dock = DockStyle.Fill;
            genreLabel.Location = new Point(3, 168);
            genreLabel.Name = "genreLabel";
            genreLabel.Padding = new Padding(12, 0, 0, 0);
            genreLabel.Size = new Size(278, 42);
            genreLabel.TabIndex = 4;
            genreLabel.Text = "genreLabel";
            genreLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Dock = DockStyle.Fill;
            descriptionLabel.Location = new Point(3, 210);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Padding = new Padding(12, 0, 0, 0);
            descriptionLabel.Size = new Size(278, 101);
            descriptionLabel.TabIndex = 5;
            descriptionLabel.Text = "descriptionLabel";
            descriptionLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // BookDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 311);
            Controls.Add(tableLayoutPanel1);
            Name = "BookDetails";
            Text = "Detalle";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label descriptionLabel;
        private Label genreLabel;
        private Label authorLabel;
        private Label numberOfPagesLabel;
        private Label publicationDateLabel;
        private Label titleLabel;
    }
}