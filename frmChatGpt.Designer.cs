namespace Asistente_virtual
{
    partial class frmChatGpt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChatGpt));
            groupBox1 = new GroupBox();
            btnStopA = new Button();
            btnEnter = new Button();
            txtbPregunta = new TextBox();
            textbRespuesta = new RichTextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(btnStopA);
            groupBox1.Controls.Add(btnEnter);
            groupBox1.Controls.Add(txtbPregunta);
            groupBox1.Location = new Point(12, 300);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(674, 138);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Asistente:";
            // 
            // btnStopA
            // 
            btnStopA.Image = (Image)resources.GetObject("btnStopA.Image");
            btnStopA.Location = new Point(532, 50);
            btnStopA.Name = "btnStopA";
            btnStopA.Size = new Size(51, 55);
            btnStopA.TabIndex = 2;
            btnStopA.UseVisualStyleBackColor = true;
            btnStopA.Click += btnStopA_Click;
            // 
            // btnEnter
            // 
            btnEnter.BackColor = Color.Transparent;
            btnEnter.Image = (Image)resources.GetObject("btnEnter.Image");
            btnEnter.Location = new Point(451, 44);
            btnEnter.Name = "btnEnter";
            btnEnter.Size = new Size(75, 67);
            btnEnter.TabIndex = 1;
            btnEnter.UseVisualStyleBackColor = false;
            btnEnter.Click += btnEnter_Click;
            // 
            // txtbPregunta
            // 
            txtbPregunta.BackColor = Color.Lavender;
            txtbPregunta.Location = new Point(6, 22);
            txtbPregunta.Multiline = true;
            txtbPregunta.Name = "txtbPregunta";
            txtbPregunta.Size = new Size(406, 110);
            txtbPregunta.TabIndex = 0;
            // 
            // textbRespuesta
            // 
            textbRespuesta.BackColor = Color.LightGreen;
            textbRespuesta.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textbRespuesta.Location = new Point(12, 12);
            textbRespuesta.Name = "textbRespuesta";
            textbRespuesta.ReadOnly = true;
            textbRespuesta.ScrollBars = RichTextBoxScrollBars.Horizontal;
            textbRespuesta.Size = new Size(674, 273);
            textbRespuesta.TabIndex = 2;
            textbRespuesta.Text = "";
            // 
            // frmChatGpt
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(698, 450);
            Controls.Add(textbRespuesta);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmChatGpt";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ChatGPT";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox1;
        private Button btnEnter;
        private TextBox txtbPregunta;
        private Button btnStopA;
        private RichTextBox textbRespuesta;
    }
}