namespace Asistente_virtual
{
    partial class frmAsistente
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAsistente));
            btnAudio = new Button();
            pictureBox1 = new PictureBox();
            lblTexto = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            notifyIcon1 = new NotifyIcon(components);
            contextMenuStrip1 = new ContextMenuStrip(components);
            Grabar = new ToolStripMenuItem();
            Salir = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btnAudio
            // 
            btnAudio.Font = new Font("Impact", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnAudio.Location = new Point(188, 360);
            btnAudio.Name = "btnAudio";
            btnAudio.Size = new Size(114, 63);
            btnAudio.TabIndex = 1;
            btnAudio.Text = "Grabar";
            btnAudio.UseVisualStyleBackColor = true;
            btnAudio.Click += btnAudio_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(135, 242);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(220, 112);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // lblTexto
            // 
            lblTexto.AutoEllipsis = true;
            lblTexto.BackColor = Color.Transparent;
            lblTexto.BorderStyle = BorderStyle.FixedSingle;
            lblTexto.Font = new Font("Sylfaen", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTexto.ForeColor = Color.DarkRed;
            lblTexto.Location = new Point(95, 272);
            lblTexto.Name = "lblTexto";
            lblTexto.Size = new Size(305, 46);
            lblTexto.TabIndex = 3;
            lblTexto.Text = "Abrir Universidad";
            lblTexto.TextAlign = ContentAlignment.TopCenter;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // notifyIcon1
            // 
            notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
            notifyIcon1.ContextMenuStrip = contextMenuStrip1;
            notifyIcon1.Icon = (Icon)resources.GetObject("notifyIcon1.Icon");
            notifyIcon1.Text = "Asistente";
            notifyIcon1.Visible = true;
            notifyIcon1.MouseClick += notifyIcon1_MouseClick;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { Grabar, Salir });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(110, 48);
            // 
            // Grabar
            // 
            Grabar.Name = "Grabar";
            Grabar.Size = new Size(109, 22);
            Grabar.Text = "Grabar";
            Grabar.Click += Grabar_Click;
            // 
            // Salir
            // 
            Salir.Name = "Salir";
            Salir.Size = new Size(109, 22);
            Salir.Text = "Salir";
            Salir.Click += Salir_Click;
            // 
            // frmAsistente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(491, 491);
            Controls.Add(lblTexto);
            Controls.Add(pictureBox1);
            Controls.Add(btnAudio);
            KeyPreview = true;
            MaximizeBox = false;
            Name = "frmAsistente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Asistente";
            FormClosing += frmAsistente_FormClosing;
            Load += frmAsistente_Load;
            KeyDown += frmAsistente_KeyDown;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button btnAudio;
        private PictureBox pictureBox1;
        private Label lblTexto;
        private System.Windows.Forms.Timer timer1;
        private NotifyIcon notifyIcon1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem Grabar;
        private ToolStripMenuItem Salir;
    }
}