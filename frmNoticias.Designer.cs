namespace Asistente_virtual
{
    partial class frmNoticias
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
            btnActualizar = new Button();
            txtbNoticias = new RichTextBox();
            cbxSortBy = new ComboBox();
            nudPages = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)nudPages).BeginInit();
            SuspendLayout();
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(782, 515);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(75, 23);
            btnActualizar.TabIndex = 1;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // txtbNoticias
            // 
            txtbNoticias.BackColor = Color.Beige;
            txtbNoticias.Font = new Font("High Tower Text", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtbNoticias.Location = new Point(12, 12);
            txtbNoticias.Name = "txtbNoticias";
            txtbNoticias.ReadOnly = true;
            txtbNoticias.ScrollBars = RichTextBoxScrollBars.Vertical;
            txtbNoticias.Size = new Size(845, 456);
            txtbNoticias.TabIndex = 3;
            txtbNoticias.Text = "";
            // 
            // cbxSortBy
            // 
            cbxSortBy.AutoCompleteMode = AutoCompleteMode.Append;
            cbxSortBy.FormattingEnabled = true;
            cbxSortBy.Items.AddRange(new object[] { "Popularity", "Relevancy", "PublishedAt" });
            cbxSortBy.Location = new Point(597, 514);
            cbxSortBy.Name = "cbxSortBy";
            cbxSortBy.Size = new Size(121, 23);
            cbxSortBy.TabIndex = 4;
            // 
            // nudPages
            // 
            nudPages.Location = new Point(724, 515);
            nudPages.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudPages.Name = "nudPages";
            nudPages.Size = new Size(39, 23);
            nudPages.TabIndex = 6;
            nudPages.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // frmNoticias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.NavajoWhite;
            ClientSize = new Size(869, 550);
            Controls.Add(nudPages);
            Controls.Add(cbxSortBy);
            Controls.Add(txtbNoticias);
            Controls.Add(btnActualizar);
            Name = "frmNoticias";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Noticias";
            Load += frmNoticias_Load;
            ((System.ComponentModel.ISupportInitialize)nudPages).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnActualizar;
        private RichTextBox txtbNoticias;
        private ComboBox cbxSortBy;
        private NumericUpDown nudPages;
    }
}