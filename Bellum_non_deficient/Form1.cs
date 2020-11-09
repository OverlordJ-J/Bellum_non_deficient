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
        int yC = 0;
        int xC = 0;
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
            pictureBox1.Controls.Add(pb_Fog);
            pb_Fog.Location = new Point(0, 0);
            pb_Fog.BackColor = Color.Transparent;
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
                if (elemento.Text == "Hola")
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

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Controls.Add(pb_Fog);
            pb_Fog.Location = new Point(0, 0);
            pb_Fog.BackColor = Color.Transparent;
        }

        private void pb_Fog_Paint(object sender, PaintEventArgs e)
        {
            SolidBrush blueBrush = new SolidBrush(Color.Blue);
            SolidBrush Si = new SolidBrush(Color.Red);
            SolidBrush Nada = new SolidBrush(Color.Transparent);
            Rectangle[,] Fog = new Rectangle[5,5];
            //Llenado de la cuadricula
            for(int i = 0; i < 5; i++)
            {
                for(int j = 0; j < 5; j++)
                {
                    Fog[i,j] = new Rectangle(xC + 1, yC + 1, 98, 98);
                    e.Graphics.FillRectangle(blueBrush, Fog[i,j]);
                    xC += 100;
                }
                yC += 100;
                xC = 0;
            }
            if (Casillas[0, 0] == 1)
            {
                MessageBox.Show("Asies");
                e.Graphics.FillRectangle(Si, Fog[0,4]); 
            }
        }

    }
}
