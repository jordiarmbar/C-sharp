using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Recognition; 
using System.Globalization;      
using System.Diagnostics;        

namespace WinMicro
{
    public partial class Form1 : Form
    {
        
        SpeechRecognitionEngine rec;
        CultureInfo culture = new CultureInfo("es-ES"); 

        public Form1()
        {
            InitializeComponent();

            
            this.Shown += Form1_Shown;                
            btnStart.Click += btnStart_Click;         
            btnStop.Click += btnStop_Click;          
        }


        private void Form1_Shown(object sender, EventArgs e)
        {
            try
            {

                rec = new SpeechRecognitionEngine(culture);
                rec.SetInputToDefaultAudioDevice(); 

                Choices comandos = new Choices();
                comandos.Add(new string[] {
                    "hola",
                    "limpiar",
                    "salir",
                    "color rojo",
                    "color verde",
                    "color azul",
                    "abrir bloc de notas",
                    "abrir navegador",
                    "quien ganara la champions este año"
                });

                
                GrammarBuilder gb = new GrammarBuilder();
                gb.Culture = culture;
                gb.Append(comandos);
                Grammar g = new Grammar(gb);
                rec.LoadGrammar(g);

                
                rec.SpeechRecognized += Rec_SpeechRecognized;

                
                btnStart.Enabled = true;
                btnStop.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al iniciar voz: " + ex.Message);
            }
        }

        
        private void btnStart_Click(object sender, EventArgs e)
        {
            
            rec.RecognizeAsync(RecognizeMode.Multiple);
            btnStart.Enabled = false;
            btnStop.Enabled = true;
            Log("Sistema escuchando...");
        }

        
        private void btnStop_Click(object sender, EventArgs e)
        {
            // Detiene la escucha
            rec.RecognizeAsyncStop();
            btnStart.Enabled = true;
            btnStop.Enabled = false;
            Log("Sistema pausado.");
        }

        
        private void Rec_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            string texto = e.Result.Text;
            float confianza = e.Result.Confidence;


           
            Log($"Escuché: '{texto}' (Confianza: {confianza:0.00})");

           
            if (confianza < 0.5)
            {
                Log("Ignorado por baja confianza."); 
                return;
            }

            
            switch (texto)
            {
                case "hola":
                    MessageBox.Show("¡Hola!");
                    break;

                case "quien ganara la champions este año":
                    MessageBox.Show("El Barça 💙❤️");
                    break;

                case "limpiar":
                    txtLog.Clear(); // Limpia el cuadro de texto 
                    break;

                case "salir":
                    Application.Exit(); // Cierra la app 
                    break;

                case "color rojo":
                    panel1.BackColor = Color.Red; // Cambia color panel 
                    break;

                case "color verde":
                    panel1.BackColor = Color.Green;
                    break;

                case "color azul":
                    panel1.BackColor = Color.Blue;
                    break;

                case "abrir bloc de notas":
                    Process.Start("notepad.exe"); // Abre Notepad 
                    break;
                

                case "abrir navegador":
                    Process.Start("https://google.com"); // Abre Google
                    break;
            }

            
            label1.Text = "Último: " + texto;
        }

        
        private void Log(string msg)
        {
            // Añade hora y mensaje al TextBox
            txtLog.AppendText($"[{DateTime.Now:HH:mm:ss}] {msg}\r\n");
        }
    }
}
