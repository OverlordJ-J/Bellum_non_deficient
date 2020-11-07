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

namespace Bellum_non_deficient
{
    public partial class Form1 : Form
    {
        CultureInfo Cultura = new CultureInfo("es-ES");
        SpeechRecognitionEngine Reconocedor;
        Choices Palabras;
        Grammar Gramatica;
        int[,] Casillas = new int[5, 5];
        public Form1()
        {
            InitializeComponent();
            for (int i=0;i<5;i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Casillas[i , j] = 0;
                }
            }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawLine(Pens.White, 100, 0, 100, 500);
            e.Graphics.DrawLine(Pens.White, 200, 0, 200, 500);
            e.Graphics.DrawLine(Pens.White, 300, 0, 300, 500);
            e.Graphics.DrawLine(Pens.White, 400, 0, 400, 500);
            e.Graphics.DrawLine(Pens.White, 0, 100, 500, 100);
            e.Graphics.DrawLine(Pens.White, 0, 200, 500, 200);
            e.Graphics.DrawLine(Pens.White, 0, 300, 500, 300);
            e.Graphics.DrawLine(Pens.White, 0, 400, 500, 400);

            if (Casillas[0, 0] == 1)
            {
                Equis(e.Graphics, 0, 0);
            }
            if (Casillas[0, 0] == 2)
            {
                Cero(e.Graphics, 0, 0);
            }

            if (Casillas[0, 1] == 1)
            {
                Equis(e.Graphics, 200, 0);
            }
            if (Casillas[0, 1] == 2)
            {
                Cero(e.Graphics, 200, 0);
            }
        }
        void Equis(Graphics G, int x, int y)
        {
            Pen Pluma = new Pen(Color.YellowGreen, 5.0f);
            G.DrawLine(Pluma, x + 20, y + 20, x + 180, y + 180);
            G.DrawLine(Pluma, x + 20, y + 180, x + 180, y + 20);
        }

        void Cero(Graphics G, int x, int y)
        {
            Pen Pluma = new Pen(Color.YellowGreen, 5.0f);
            G.DrawEllipse(Pluma, x + 20, y + 20, 160, 160);
        }

        private void btnAtaque_Click(object sender, EventArgs e)
        {
            try
            {
                Palabras = new Choices(new string[] { "Uno uno", "uno dos" });
                GrammarBuilder ConstructorGramatica = new GrammarBuilder(Palabras);
                ConstructorGramatica.Culture = Cultura;
                Gramatica = new Grammar(ConstructorGramatica);

                Reconocedor = new SpeechRecognitionEngine(Cultura);
                //Reconocedor.LoadGrammar(Gramatica);
                Reconocedor.LoadGrammar(new DictationGrammar());
                Reconocedor.SetInputToDefaultAudioDevice();

                Reconocedor.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(ReconocimientoVoz);
                Reconocedor.RecognizeAsync(RecognizeMode.Multiple);
                listBoxReco.Items.Add("Iniciando...");
                listBoxReco.Update();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void ReconocimientoVoz(object sender, SpeechRecognizedEventArgs e)
        {
            listBoxReco.Items.Clear();
            foreach (var elemento in e.Result.Alternates)
            {
                listBoxReco.Items.Add(elemento.Text + ", Confidencia: " + elemento.Confidence.ToString());
                if (elemento.Text == "Uno uno equis")
                {
                    if (Casillas[0, 0] == 0)
                        Casillas[0, 0] = 1;
                    else
                        MessageBox.Show("Intenta en otra casilla");
                    break;
                }
                if (elemento.Text == "uno uno cero")
                {
                    if (Casillas[0, 0] == 0)
                        Casillas[0, 0] = 2;
                    else
                        MessageBox.Show("Intenta en otra casilla");
                    break;
                }
                if (elemento.Text == "uno dos equis")
                {
                    if (Casillas[0, 1] == 0)
                        Casillas[0, 1] = 1;
                    else
                        MessageBox.Show("Intenta en otra casilla");
                    break;
                }
                if (elemento.Text == "uno dos cero")
                {
                    if (Casillas[0, 1] == 0)
                        Casillas[0, 1] = 2;
                    else
                        MessageBox.Show("Intenta en otra casilla");
                    break;
                }
            }
            pictureBox1.Invalidate();
        }

        private void listBoxReco_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
