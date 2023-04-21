namespace MyBooks.WinForm
{
    partial class NewGenre
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
            addGenreBtn = new Button();
            genreLabel = new Label();
            genreTextBox = new TextBox();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 28.7425156F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.8982048F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Controls.Add(addGenreBtn, 2, 0);
            tableLayoutPanel1.Controls.Add(genreLabel, 0, 0);
            tableLayoutPanel1.Controls.Add(genreTextBox, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(334, 211);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // addGenreBtn
            // 
            addGenreBtn.Anchor = AnchorStyles.None;
            addGenreBtn.Location = new Point(269, 94);
            addGenreBtn.Name = "addGenreBtn";
            addGenreBtn.Size = new Size(62, 23);
            addGenreBtn.TabIndex = 1;
            addGenreBtn.Text = "Añadir";
            addGenreBtn.UseVisualStyleBackColor = true;
            addGenreBtn.Click += AddGenreBtn_Click;
            // 
            // genreLabel
            // 
            genreLabel.Anchor = AnchorStyles.None;
            genreLabel.AutoSize = true;
            genreLabel.Location = new Point(21, 98);
            genreLabel.Name = "genreLabel";
            genreLabel.Size = new Size(54, 15);
            genreLabel.TabIndex = 2;
            genreLabel.Text = "Nombre:";
            // 
            // genreTextBox
            // 
            genreTextBox.Anchor = AnchorStyles.None;
            genreTextBox.Location = new Point(106, 94);
            genreTextBox.Name = "genreTextBox";
            genreTextBox.Size = new Size(150, 23);
            genreTextBox.TabIndex = 3;
            // 
            // NewGenre
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(334, 211);
            Controls.Add(tableLayoutPanel1);
            Name = "NewGenre";
            Text = "Nuevo género";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button addGenreBtn;
        private Label genreLabel;
        private TextBox genreTextBox;
    }
}