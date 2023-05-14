using System;
using System.Diagnostics;
using System.Speech.Recognition;
using System.Windows.Forms;

namespace Asistente_virtual
{
    public partial class frmAsistente : Form
    {
        private SpeechRecognitionEngine recognizer;
        public frmAsistente()
        {
            string path = @"C:\Proyectos C#\Asistente virtual\Comandos.txt";
            InitializeComponent();

            recognizer = new SpeechRecognitionEngine(new System.Globalization.CultureInfo("es-AR"));
            recognizer.SetInputToDefaultAudioDevice();

            // Crear una instancia de GrammarBuilder
            GrammarBuilder builder = new GrammarBuilder();

            // Leer el contenido del archivo de texto y agregarlo al GrammarBuilder
            string[] lines = File.ReadAllLines(path);
            builder.Append(new Choices(lines));

            // Crear una instancia de la gramática personalizada
            Grammar grammar = new Grammar(builder);

            // Agregar la gramática al reconocedor de voz
            recognizer.LoadGrammarAsync(grammar);
        }

        private void frmAsistente_Load(object sender, EventArgs e)
        {
            this.Focus();
            // Configura el temporizador para que se ejecute cada 5 segundos
            timer1.Interval = 5000;
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Start();
        }

        private async void btnAudio_Click(object sender, EventArgs e)
        {
            try
            {
                lblTexto.Visible = false;
                btnAudio.Enabled = false;
                pictureBox1.Visible = true;
                // Cargar la imagen animada en el PictureBox
                Image image = Properties.Resources.GrabandoSin2; // Reemplaza 'animation' con el nombre de tu imagen
                pictureBox1.Image = image;

                // Iniciar la animación
                ImageAnimator.Animate(image, OnFrameChanged);

                bool palabraDetectada = false;

                // Agregar el manejador de eventos de reconocimiento de voz
                recognizer.SpeechRecognized += (s, args) =>
                {
                    if (!palabraDetectada && args.Result != null && args.Result.Text != "")
                    {
                        palabraDetectada = true;
                        string input = args.Result.Text;

                        switch (input)
                        {
                            case "abrir youtube":
                                Process.Start("explorer.exe", "https://www.youtube.com/");
                                break;

                            case "abrir universidad":
                                Process.Start("explorer.exe", "https://www.frc.utn.edu.ar/");
                                break;

                            case "abrir google":
                                Process.Start("explorer.exe", "https://www.google.com");
                                break;

                            case "abrir chat":
                                Form form = new frmChatGpt();
                                form.Show();
                                break;

                            case "abrir instagram":
                                Process.Start("explorer.exe", "https://www.instagram.com/");
                                break;

                            case "clima":
                                Form form2 = new frmClima();
                                form2.Show();
                                break;

                            case "noticias":
                                Form form1 = new frmNoticias();
                                form1.Show();
                                break;
                        }
                        // Realizar la solicitud de chat a la API con el texto reconocido

                    }
                };


                // Iniciar el reconocimiento de voz
                recognizer.RecognizeAsync(RecognizeMode.Multiple);

                // Esperar 5 segundos antes de cancelar el reconocimiento
                await Task.Delay(TimeSpan.FromSeconds(5));
                recognizer.RecognizeAsyncCancel();
                pictureBox1.Visible = false;
                btnAudio.Enabled = true;
                lblTexto.Visible = true;

            }
            catch (Exception ex)
            {
                // Manejar la excepción aquí
                MessageBox.Show("Ha ocurrido un error: " + ex.Message);
            }
        }

        private void OnFrameChanged(object sender, EventArgs e)
        {
            // Redibujar el PictureBox en cada cambio de cuadro de la animación
            pictureBox1.Invalidate();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            // Dibujar el siguiente cuadro de la animación en el PictureBox
            ImageAnimator.UpdateFrames();
            e.Graphics.DrawImage(pictureBox1.Image, Point.Empty);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            List<string> opciones = new List<string>()
            {
                "'Abrir YouTube'",
                "'Abrir Universidad'",
                "'Abrir Google'",
                "'Abrir Chat'",
                "'Abrir Instagram'",
                "'Clima'",
                "'Noticias'"
            };
            //Genera un número aleatorio entre 0 y el número de opciones en la lista.
            Random random = new Random();
            int index = random.Next(opciones.Count);
            //Obtiene el texto aleatorio de la lista de opciones utilizando el índice generado en el paso anterior.
            string textoAleatorio = opciones[index];
            //Muestro el texto aleatorio en un label
            lblTexto.Text = textoAleatorio;
        }

        private void frmAsistente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.Alt && e.KeyCode == Keys.G)
            {
                // Aquí activas el evento Click del botón
                btnAudio.PerformClick();
            }
        }
        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStrip1.Show(Control.MousePosition);
            }
            else
            {
                this.Show();
            }
        }
        private void frmAsistente_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Oculta el formulario en lugar de cerrarlo
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;  // cancela el cierre del formulario
                this.Hide();  // oculta el formulario
            }
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Desea salir del programa?", "CONFIRMACION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
            
        }

        private void Grabar_Click(object sender, EventArgs e)
        {
            this.Show();
            btnAudio.PerformClick();
        }
    }
}