namespace MyBooks.WinForm
{
    partial class MyBooks
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            listViewBooks = new ListView();
            Título = new ColumnHeader();
            Publicación = new ColumnHeader();
            Páginas = new ColumnHeader();
            Autor = new ColumnHeader();
            Género = new ColumnHeader();
            menuStrip1 = new MenuStrip();
            nuevoToolStripMenuItem = new ToolStripMenuItem();
            géneroToolStripMenuItem = new ToolStripMenuItem();
            autorToolStripMenuItem = new ToolStripMenuItem();
            libroToolStripMenuItem = new ToolStripMenuItem();
            itemContextMenuStrip = new ContextMenuStrip(components);
            detalleToolStripMenuItem = new ToolStripMenuItem();
            actualizarToolStripMenuItem = new ToolStripMenuItem();
            eliminarToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            itemContextMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // listViewBooks
            // 
            listViewBooks.Columns.AddRange(new ColumnHeader[] { Título, Publicación, Páginas, Autor, Género });
            listViewBooks.Dock = DockStyle.Fill;
            listViewBooks.FullRowSelect = true;
            listViewBooks.Location = new Point(0, 24);
            listViewBooks.MultiSelect = false;
            listViewBooks.Name = "listViewBooks";
            listViewBooks.Size = new Size(800, 426);
            listViewBooks.TabIndex = 0;
            listViewBooks.UseCompatibleStateImageBehavior = false;
            listViewBooks.DoubleClick += ListViewBooks_DoubleClick;
            listViewBooks.MouseClick += ListViewBooks_MouseClick;
            // 
            // Título
            // 
            Título.Text = "Título";
            // 
            // Publicación
            // 
            Publicación.Text = "Publicación";
            // 
            // Páginas
            // 
            Páginas.Text = "Páginas";
            // 
            // Autor
            // 
            Autor.Text = "Autor";
            // 
            // Género
            // 
            Género.Text = "Género";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { nuevoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // nuevoToolStripMenuItem
            // 
            nuevoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { géneroToolStripMenuItem, autorToolStripMenuItem, libroToolStripMenuItem });
            nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            nuevoToolStripMenuItem.Size = new Size(63, 20);
            nuevoToolStripMenuItem.Text = "Nuevo...";
            // 
            // géneroToolStripMenuItem
            // 
            géneroToolStripMenuItem.Name = "géneroToolStripMenuItem";
            géneroToolStripMenuItem.Size = new Size(112, 22);
            géneroToolStripMenuItem.Text = "Género";
            géneroToolStripMenuItem.Click += NewGenreToolStripMenuItem_Click;
            // 
            // autorToolStripMenuItem
            // 
            autorToolStripMenuItem.Name = "autorToolStripMenuItem";
            autorToolStripMenuItem.Size = new Size(112, 22);
            autorToolStripMenuItem.Text = "Autor";
            autorToolStripMenuItem.Click += NewAuthorToolStripMenuItem_Click;
            // 
            // libroToolStripMenuItem
            // 
            libroToolStripMenuItem.Name = "libroToolStripMenuItem";
            libroToolStripMenuItem.Size = new Size(112, 22);
            libroToolStripMenuItem.Text = "Libro";
            libroToolStripMenuItem.Click += NewBookToolStripMenuItem_Click;
            // 
            // itemContextMenuStrip
            // 
            itemContextMenuStrip.Items.AddRange(new ToolStripItem[] { detalleToolStripMenuItem, actualizarToolStripMenuItem, eliminarToolStripMenuItem });
            itemContextMenuStrip.Name = "itemContextMenuStrip";
            itemContextMenuStrip.Size = new Size(127, 70);
            // 
            // detalleToolStripMenuItem
            // 
            detalleToolStripMenuItem.Name = "detalleToolStripMenuItem";
            detalleToolStripMenuItem.Size = new Size(126, 22);
            detalleToolStripMenuItem.Text = "Detalle";
            detalleToolStripMenuItem.Click += DetailToolStripMenuItem_Click;
            // 
            // actualizarToolStripMenuItem
            // 
            actualizarToolStripMenuItem.Name = "actualizarToolStripMenuItem";
            actualizarToolStripMenuItem.Size = new Size(126, 22);
            actualizarToolStripMenuItem.Text = "Actualizar";
            actualizarToolStripMenuItem.Click += UpdateToolStripMenuItem_Click;
            // 
            // eliminarToolStripMenuItem
            // 
            eliminarToolStripMenuItem.Image = Properties.Resources.cancel_480px;
            eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            eliminarToolStripMenuItem.Size = new Size(126, 22);
            eliminarToolStripMenuItem.Text = "Eliminar";
            eliminarToolStripMenuItem.Click += DeleteToolStripMenuItem_Click;
            // 
            // MyBooks
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listViewBooks);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MyBooks";
            Text = "Mis Libros";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            itemContextMenuStrip.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listViewBooks;
        private ColumnHeader Título;
        private ColumnHeader Publicación;
        private ColumnHeader Páginas;
        private ColumnHeader Autor;
        private ColumnHeader Género;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem nuevoToolStripMenuItem;
        private ToolStripMenuItem géneroToolStripMenuItem;
        private ToolStripMenuItem autorToolStripMenuItem;
        private ToolStripMenuItem libroToolStripMenuItem;
        private ContextMenuStrip itemContextMenuStrip;
        private ToolStripMenuItem actualizarToolStripMenuItem;
        private ToolStripMenuItem eliminarToolStripMenuItem;
        private ToolStripMenuItem detalleToolStripMenuItem;
    }
}