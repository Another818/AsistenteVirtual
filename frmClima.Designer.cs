namespace Asistente_virtual
{
    partial class frmClima
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
            txtbCiudad = new TextBox();
            txtbPais = new TextBox();
            btnBuscar = new Button();
            lblCiudad = new Label();
            lblPais = new Label();
            lblMax = new Label();
            lblMin = new Label();
            lblTemp = new Label();
            lblSensacion = new Label();
            lblPresion = new Label();
            lblHumedad = new Label();
            lblDatos = new Label();
            lblHora = new Label();
            btnBusqueda = new Button();
            SuspendLayout();
            // 
            // txtbCiudad
            // 
            txtbCiudad.Location = new Point(74, 318);
            txtbCiudad.Name = "txtbCiudad";
            txtbCiudad.Size = new Size(100, 23);
            txtbCiudad.TabIndex = 1;
            // 
            // txtbPais
            // 
            txtbPais.Location = new Point(74, 282);
            txtbPais.Name = "txtbPais";
            txtbPais.Size = new Size(100, 23);
            txtbPais.TabIndex = 2;
            // 
            // btnBuscar
            // 
            btnBuscar.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnBuscar.Location = new Point(186, 283);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 53);
            btnBuscar.TabIndex = 3;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += button1_Click;
            // 
            // lblCiudad
            // 
            lblCiudad.AutoSize = true;
            lblCiudad.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblCiudad.Location = new Point(6, 319);
            lblCiudad.Name = "lblCiudad";
            lblCiudad.Size = new Size(59, 17);
            lblCiudad.TabIndex = 4;
            lblCiudad.Text = "Ciudad:";
            // 
            // lblPais
            // 
            lblPais.AutoSize = true;
            lblPais.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblPais.Location = new Point(16, 283);
            lblPais.Name = "lblPais";
            lblPais.Size = new Size(40, 17);
            lblPais.TabIndex = 5;
            lblPais.Text = "Pais:";
            // 
            // lblMax
            // 
            lblMax.AutoSize = true;
            lblMax.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblMax.ForeColor = Color.Snow;
            lblMax.Location = new Point(221, 51);
            lblMax.Name = "lblMax";
            lblMax.Size = new Size(43, 17);
            lblMax.TabIndex = 6;
            lblMax.Text = "Max:";
            // 
            // lblMin
            // 
            lblMin.AutoSize = true;
            lblMin.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblMin.ForeColor = Color.Snow;
            lblMin.Location = new Point(221, 80);
            lblMin.Name = "lblMin";
            lblMin.Size = new Size(40, 17);
            lblMin.TabIndex = 7;
            lblMin.Text = "Min:";
            // 
            // lblTemp
            // 
            lblTemp.AutoSize = true;
            lblTemp.Font = new Font("Times New Roman", 56.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblTemp.ForeColor = SystemColors.ControlLightLight;
            lblTemp.Location = new Point(20, 37);
            lblTemp.Name = "lblTemp";
            lblTemp.Size = new Size(154, 85);
            lblTemp.TabIndex = 8;
            lblTemp.Text = "0°C";
            // 
            // lblSensacion
            // 
            lblSensacion.AutoSize = true;
            lblSensacion.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblSensacion.ForeColor = Color.Snow;
            lblSensacion.Location = new Point(20, 138);
            lblSensacion.Name = "lblSensacion";
            lblSensacion.Size = new Size(131, 17);
            lblSensacion.TabIndex = 9;
            lblSensacion.Text = "Sensación térmica:";
            // 
            // lblPresion
            // 
            lblPresion.AutoSize = true;
            lblPresion.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblPresion.ForeColor = Color.Snow;
            lblPresion.Location = new Point(20, 199);
            lblPresion.Name = "lblPresion";
            lblPresion.Size = new Size(63, 17);
            lblPresion.TabIndex = 10;
            lblPresion.Text = "Presión:";
            // 
            // lblHumedad
            // 
            lblHumedad.AutoSize = true;
            lblHumedad.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblHumedad.ForeColor = Color.Snow;
            lblHumedad.Location = new Point(20, 232);
            lblHumedad.Name = "lblHumedad";
            lblHumedad.Size = new Size(76, 17);
            lblHumedad.TabIndex = 11;
            lblHumedad.Text = "Humedad:";
            // 
            // lblDatos
            // 
            lblDatos.AutoSize = true;
            lblDatos.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblDatos.ForeColor = Color.Snow;
            lblDatos.Location = new Point(20, 20);
            lblDatos.Name = "lblDatos";
            lblDatos.Size = new Size(54, 17);
            lblDatos.TabIndex = 12;
            lblDatos.Text = "Ciudad";
            // 
            // lblHora
            // 
            lblHora.AutoSize = true;
            lblHora.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblHora.ForeColor = Color.DimGray;
            lblHora.Location = new Point(6, 354);
            lblHora.Name = "lblHora";
            lblHora.Size = new Size(41, 17);
            lblHora.TabIndex = 13;
            lblHora.Text = "Hora";
            // 
            // btnBusqueda
            // 
            btnBusqueda.Location = new Point(313, 339);
            btnBusqueda.Name = "btnBusqueda";
            btnBusqueda.Size = new Size(75, 23);
            btnBusqueda.TabIndex = 14;
            btnBusqueda.Text = "Busqueda";
            btnBusqueda.UseVisualStyleBackColor = true;
            btnBusqueda.Click += btnBusqueda_Click;
            // 
            // frmClima
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CornflowerBlue;
            ClientSize = new Size(400, 374);
            Controls.Add(btnBusqueda);
            Controls.Add(lblHora);
            Controls.Add(lblDatos);
            Controls.Add(lblHumedad);
            Controls.Add(lblPresion);
            Controls.Add(lblSensacion);
            Controls.Add(lblTemp);
            Controls.Add(lblMin);
            Controls.Add(lblMax);
            Controls.Add(lblPais);
            Controls.Add(lblCiudad);
            Controls.Add(btnBuscar);
            Controls.Add(txtbPais);
            Controls.Add(txtbCiudad);
            MaximizeBox = false;
            Name = "frmClima";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Clima";
            Load += frmClima_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtbClima;
        private TextBox txtbCiudad;
        private TextBox txtbPais;
        private Button btnBuscar;
        private Label lblCiudad;
        private Label lblPais;
        private Label lblMax;
        private Label lblMin;
        private Label lblTemp;
        private Label lblSensacion;
        private Label lblPresion;
        private Label lblHumedad;
        private Label lblDatos;
        private Label lblHora;
        private Button btnBusqueda;
    }
}