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
        int yC = 0;
        int xC = 0;
        int[,] LargeShip = new int[5, 5];
        int[,] MidShip = new int[5, 5];
        int[,] SmallShip = new int[5, 5];
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

            for(int i=0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    switch (Casillas[i,j])
                    {

                        case 1:
                            Equis(e.Graphics, 0, 0);
                            break;
                        case 2:
                            Equis(e.Graphics, 100, 0);
                            break;
                        case 3:
                            Equis(e.Graphics, 200, 0);
                            break;
                        case 4:
                            Equis(e.Graphics, 300, 0);
                            break;
                        case 5:
                            Equis(e.Graphics, 400, 0);
                            break;
                        case 6:
                            Equis(e.Graphics, 0, 100);
                            break;            
                        case 7:               
                            Equis(e.Graphics, 100, 100);
                            break;            
                        case 8:               
                            Equis(e.Graphics, 200, 100);
                            break;            
                        case 9:               
                            Equis(e.Graphics, 300, 100);
                            break;            
                        case 10:              
                            Equis(e.Graphics, 400, 100);
                            break;            
                        case 11:
                            Equis(e.Graphics, 0, 200);
                            break;
                        case 12:
                            Equis(e.Graphics, 100, 200);
                            break;
                        case 13:
                            Equis(e.Graphics, 200, 200);
                            break;
                        case 14:
                            Equis(e.Graphics, 300, 200);
                            break;
                        case 15:
                            Equis(e.Graphics, 400, 200);
                            break;
                        case 16:
                            Equis(e.Graphics, 0, 300);
                            break;
                        case 17:
                            Equis(e.Graphics, 100, 300);
                            break;
                        case 18:
                            Equis(e.Graphics, 200, 300);
                            break;
                        case 19:
                            Equis(e.Graphics, 300, 300);
                            break;
                        case 20:
                            Equis(e.Graphics, 400, 300);
                            break;
                        case 21:
                            Equis(e.Graphics, 0, 400);
                            break;
                        case 22:
                            Equis(e.Graphics, 100, 400);
                            break;
                        case 23:
                            Equis(e.Graphics, 200, 400);
                            break;
                        case 24:
                            Equis(e.Graphics, 300, 400);
                            break;
                        case 25:
                            Equis(e.Graphics, 400, 400);
                            break;
                        default:
                            break;
                    }

                }
            }
            
            //if (Casillas[0, 0] == 1)
            //{
            //    Equis(e.Graphics, 0, 0);
            //}
            //if (Casillas[0, 0] == 2)
            //{
            //    Cero(e.Graphics, 0, 0);
            //}

            //if (Casillas[0, 1] == 1)
            //{
            //    Equis(e.Graphics, 100, 0);
            //}
            //if (Casillas[0, 1] == 2)
            //{
            //    Cero(e.Graphics, 100, 0);
            //}
        }
        void Equis(Graphics G, int x, int y)
        {
            Pen Pluma = new Pen(Color.YellowGreen, 5.0f);
            G.DrawLine(Pluma, x + 10, y + 10, x + 90, y + 90);
            G.DrawLine(Pluma, x + 10, y + 90, x + 90, y + 10);
        }

        void Cero(Graphics G, int x, int y)
        {
            Pen Pluma = new Pen(Color.YellowGreen, 5.0f);
            G.DrawEllipse(Pluma, x + 10, y + 10, 80, 80);
        }

        private void btnAtaque_Click(object sender, EventArgs e)
        {
            try
            {
                Palabras = new Choices(new string[] { "A uno diparo", "A dos disparo" });
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
                if (elemento.Confidence > 0.5f)
                {
                    listBoxReco.Items.Add(elemento.Text + ", Confidencia: " + elemento.Confidence.ToString());
                }
                if (elemento.Text == "A uno disparo" || elemento.Text == "a uno disparo")
                {
                    if (Casillas[0, 0] == 0)
                        Casillas[0, 0] = 1;
                    else
                        MessageBox.Show("Intenta en otra casilla");
                    break;
                }
                if (elemento.Text == "A dos disparo" || elemento.Text == "a dos disparo")
                {
                    if (Casillas[0, 1] == 0)
                        Casillas[0, 1] = 2;
                    else
                        MessageBox.Show("Intenta en otra casilla");
                    break;
                }
                if (elemento.Text == "A tres disparo" || elemento.Text == "a tres disparo")
                {
                    if (Casillas[0, 2] == 0)
                        Casillas[0, 2] = 3;
                    else
                        MessageBox.Show("Intenta en otra casilla");
                    break;
                }
                if (elemento.Text == "A cuatro disparo" || elemento.Text == "a cuatro disparo")
                {
                    if (Casillas[0, 3] == 0)
                        Casillas[0, 3] = 4;
                    else
                        MessageBox.Show("Intenta en otra casilla");
                    break;
                }
                if (elemento.Text == "A cinco disparo" || elemento.Text == "a cinco disparo")
                {
                    if (Casillas[0, 4] == 0)
                        Casillas[0, 4] = 5;
                    else
                        MessageBox.Show("Intenta en otra casilla");
                    break;
                }
                //--------------------1
                if (elemento.Text == "B uno disparo" || elemento.Text == "b uno disparo" || elemento.Text == "B. uno disparo")
                {
                    if (Casillas[1, 0] == 0)
                        Casillas[1, 0] = 6;
                    else
                        MessageBox.Show("Intenta en otra casilla");
                    break;
                }
                if (elemento.Text == "B dos disparo" || elemento.Text == "b dos disparo" || elemento.Text == "B. dos disparo")
                {
                    if (Casillas[1, 1] == 0)
                        Casillas[1, 1] = 7;
                    else
                        MessageBox.Show("Intenta en otra casilla");
                    break;
                }
                if (elemento.Text == "B tres disparo" || elemento.Text == "b tres disparo" || elemento.Text == "B. tres disparo")
                {
                    if (Casillas[1, 2] == 0)
                        Casillas[1, 2] = 8;
                    else
                        MessageBox.Show("Intenta en otra casilla");
                    break;
                }
                if (elemento.Text == "B cuatro disparo" || elemento.Text == "b cuatro disparo" || elemento.Text == "B. cuatro disparo")
                {
                    if (Casillas[1, 3] == 0)
                        Casillas[1, 3] = 9;
                    else
                        MessageBox.Show("Intenta en otra casilla");
                    break;
                }
                if (elemento.Text == "B cinco disparo" || elemento.Text == "b cinco disparo" || elemento.Text == "B. cinco disparo")
                {
                    if (Casillas[1, 4] == 0)
                        Casillas[1, 4] = 10;
                    else
                        MessageBox.Show("Intenta en otra casilla");
                    break;
                }
                //--------------------2
                if (elemento.Text == "C uno disparo" || elemento.Text == "se uno disparo" || elemento.Text == "C. uno disparo")
                {
                    if (Casillas[2, 0] == 0)
                        Casillas[2, 0] = 11;
                    else
                        MessageBox.Show("Intenta en otra casilla");
                    break;
                }
                if (elemento.Text == "C dos disparo" || elemento.Text == "se dos disparo" || elemento.Text == "C. dos disparo")
                {
                    if (Casillas[2, 1] == 0)
                        Casillas[2, 1] = 12;
                    else
                        MessageBox.Show("Intenta en otra casilla");
                    break;
                }
                if (elemento.Text == "C tres disparo" || elemento.Text == "se tres disparo" || elemento.Text == "C. tres disparo")
                {
                    if (Casillas[2, 2] == 0)
                        Casillas[2, 2] = 13;
                    else
                        MessageBox.Show("Intenta en otra casilla");
                    break;
                }
                if (elemento.Text == "C cuatro disparo" || elemento.Text == "se cuatro disparo" || elemento.Text == "C. cuatro disparo")
                {
                    if (Casillas[2, 3] == 0)
                        Casillas[2, 3] = 14;
                    else
                        MessageBox.Show("Intenta en otra casilla");
                    break;
                }
                if (elemento.Text == "C cinco disparo" || elemento.Text == "se cinco disparo" || elemento.Text == "C. cinco disparo")
                {
                    if (Casillas[2, 4] == 0)
                        Casillas[2, 4] = 15;
                    else
                        MessageBox.Show("Intenta en otra casilla");
                    break;
                }
                //--------------------3
                if (elemento.Text == "D uno disparo" || elemento.Text == "d uno disparo" || elemento.Text == "D. uno disparo")
                {
                    if (Casillas[3, 0] == 0)
                        Casillas[3, 0] = 16;
                    else
                        MessageBox.Show("Intenta en otra casilla");
                    break;
                }
                if (elemento.Text == "D dos disparo" || elemento.Text == "d dos disparo" || elemento.Text == "D. dos disparo")
                {
                    if (Casillas[3, 1] == 0)
                        Casillas[3, 1] = 17;
                    else
                        MessageBox.Show("Intenta en otra casilla");
                    break;
                }
                if (elemento.Text == "D tres disparo" || elemento.Text == "d tres disparo" || elemento.Text == "D. tres disparo")
                {
                    if (Casillas[3, 2] == 0)
                        Casillas[3, 2] = 18;
                    else
                        MessageBox.Show("Intenta en otra casilla");
                    break;
                }
                if (elemento.Text == "D cuatro disparo" || elemento.Text == "d cuatro disparo" || elemento.Text == "D. cuatro disparo")
                {
                    if (Casillas[3, 3] == 0)
                        Casillas[3, 3] = 19;
                    else
                        MessageBox.Show("Intenta en otra casilla");
                    break;
                }
                if (elemento.Text == "D cinco disparo" || elemento.Text == "d cinco disparo" || elemento.Text == "D. cinco disparo")
                {
                    if (Casillas[3, 4] == 0)
                        Casillas[3, 4] = 20;
                    else
                        MessageBox.Show("Intenta en otra casilla");
                    break;
                }
                //--------------------4
                if (elemento.Text == "E uno disparo" || elemento.Text == "e uno disparo" || elemento.Text == "E. uno disparo")
                {
                    if (Casillas[4, 0] == 0)
                        Casillas[4, 0] = 21;
                    else
                        MessageBox.Show("Intenta en otra casilla");
                    break;
                }
                if (elemento.Text == "E dos disparo" || elemento.Text == "e dos disparo" || elemento.Text == "E. dos disparo")
                {
                    if (Casillas[4, 1] == 0)
                        Casillas[4, 1] = 22;
                    else
                        MessageBox.Show("Intenta en otra casilla");
                    break;
                }
                if (elemento.Text == "E tres disparo" || elemento.Text == "e tres disparo" || elemento.Text == "E. tres disparo")
                {
                    if (Casillas[4, 2] == 0)
                        Casillas[4, 2] = 23;
                    else
                        MessageBox.Show("Intenta en otra casilla");
                    break;
                }
                if (elemento.Text == "E cuatro disparo" || elemento.Text == "e cuatro disparo" || elemento.Text == "E. cuatro disparo")
                {
                    if (Casillas[4, 3] == 0)
                        Casillas[4, 3] = 24;
                    else
                        MessageBox.Show("Intenta en otra casilla");
                    break;
                }
                if (elemento.Text == "E cinco disparo" || elemento.Text == "e cinco disparo" || elemento.Text == "E. cinco disparo")
                {
                    if (Casillas[4, 4] == 0)
                        Casillas[4, 4] = 25;
                    else
                        MessageBox.Show("Intenta en otra casilla");
                    break;
                }
                //--------------------5
            }
            pictureBox1.Invalidate();
        }

        void L_ShipLocation()
        {
            Random rand = new Random();
            int dir = rand.Next(0, 2);
            //Va para la derecha
            if (dir == 0)
            {
                int x = rand.Next(0, 3);
                int y = rand.Next(0, 5);
                for (int i = x; i < x + 3; i++)
                {
                    LargeShip[i, y] = 1;
                }
            }
            //Va para abajo
            else
            {
                int y = rand.Next(0, 3);
                int x = rand.Next(0, 5);
                for (int i = y; i < y + 3; i++)
                {
                    LargeShip[x, i] = 1;
                }
            }
        }

        void M_ShipLocation()
        {
            Random rand = new Random();
            int dir = rand.Next(0, 2);
            //int dir = 0;
            if (dir == 0)
            {
                int x;
                int y;
                bool C = false;
                while (C == false)
                {
                    y = rand.Next(0, 4);
                    x = rand.Next(2, 4);
                    if (LargeShip[x, y] != 1 && LargeShip[x + 1, y] != 1)
                    {
                        MidShip[x, y] = 1; ;
                        MidShip[x + 1, y] = 1; ;
                        C = true;
                    }
                }
            }
            //Va para abajo
            else
            {
                int x;
                int y;
                bool C = false;
                while (C == false)
                {
                    y = rand.Next(1, 5);
                    x = rand.Next(1, 3);
                    if (LargeShip[x, y] != 1 && LargeShip[x, y + 1] != 1)
                    {
                        MidShip[x, y] = 1; ;
                        MidShip[x, y + 1] = 1; ;
                        C = true;
                    }
                }
            }
        }

        void S_ShipLocation()
        {
            Random rand = new Random();
            int x = rand.Next(0, 5);
            int y = rand.Next(0, 5);
            int x2 = rand.Next(3, 4);
            int y2 = rand.Next(0, 5);
            bool C = false;
            while (C == false)
            {
                y = rand.Next(0, 5);
                x = rand.Next(0, 5);
                if (LargeShip[x, y] != 1 && MidShip[x, y] != 1)
                {
                    SmallShip[x, y] = 1;
                    C = true;
                }
            }
            bool C2 = false;
            while (C2 == false)
            {
                y2 = rand.Next(0, 5);
                x2 = rand.Next(3, 4);
                if (LargeShip[x2, y2] != 1 && MidShip[x2, y2] != 1)
                {
                    SmallShip[x2, y2] = 1;
                    C2 = true;
                }
            }
        }

        private void listBoxReco_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            S_ShipLocation();
            M_ShipLocation();
            L_ShipLocation();
        }
    }
}
