using OpenAI_API;
using OpenAI_API.Completions;
using OpenAI_API.Models;
using System.Speech.Recognition;
using System.Speech.Synthesis;



namespace Asistente_virtual
{
    public partial class frmChatGpt : Form
    {
        private SpeechSynthesizer synthesizer;
        private SpeechRecognitionEngine recognizer;
#pragma warning disable CS0169 // El campo 'frmChatGpt.recognitionCancellation' nunca se usa
        private CancellationTokenSource recognitionCancellation;
#pragma warning restore CS0169 // El campo 'frmChatGpt.recognitionCancellation' nunca se usa
#pragma warning disable CS8618 // Un campo que no acepta valores NULL debe contener un valor distinto de NULL al salir del constructor. Considere la posibilidad de declararlo como que admite un valor NULL.
        public frmChatGpt()
#pragma warning restore CS8618 // Un campo que no acepta valores NULL debe contener un valor distinto de NULL al salir del constructor. Considere la posibilidad de declararlo como que admite un valor NULL.
        {

            InitializeComponent();
            // Crear instancias del SpeechSynthesizer y SpeechRecognitionEngine
            synthesizer = new SpeechSynthesizer();
            // Establecer la voz y la velocidad del habla
            synthesizer.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult);
            synthesizer.Rate = 0;
            recognizer = new SpeechRecognitionEngine(new System.Globalization.CultureInfo("es-AR"));
            recognizer.SetInputToDefaultAudioDevice();


            // Agregar la gramática al reconocedor de voz
            recognizer.LoadGrammar(new DictationGrammar());
        }

        public void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void btnEnter_Click(object sender, EventArgs e)
        {
            try
            {
                textbRespuesta.Clear();

                // Crear una instancia de la API
                OpenAIAPI api = new OpenAIAPI(new APIAuthentication("TuApiKey"));
                // Llamar al método CreateChatCompletionAsync con una solicitud de chat
                string mensaje = txtbPregunta.Text;

                if (mensaje.Length >= 4)
                {
                    txtbPregunta.Clear();
                    await api.Completions.StreamCompletionAsync(
                        new CompletionRequest(mensaje, Model.DavinciText, temperature: 0.5, max_tokens: 4000),
                        res =>
                        {
                            textbRespuesta.Text += res.ToString();
                            textbRespuesta.ScrollToCaret();

                        });
                }
                else
                {
                    MessageBox.Show("Debe ingresar más de 4 cáracteres!");
                }


                // Convertir el texto en voz y reproducirlo
                synthesizer.SpeakAsync(textbRespuesta.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: " + ex.Message);
            }
        }


        private void btnStopA_Click(object sender, EventArgs e)
        {
            // Detener el sintetizador de voz
            synthesizer.SpeakAsyncCancelAll();
        }
    }
}