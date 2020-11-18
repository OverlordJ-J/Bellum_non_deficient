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
        int[,] LargeShip = new int[5, 5];
        int[,] MidShip = new int[5, 5];
        int[,] SmallShip = new int[5, 5];
        int counterNaves;
        int killNave = 0;
        int[] hit = new int[25];
        int[] balas = new int[25];
        public Form1()
        {
            InitializeComponent();
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Casillas[i, j] = 0;

                }
            }
            for (int a = 0; a < 25; a++)
            {
                hit[a] = 0;
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

            Pen Hit = new Pen(Color.Red, 5.0f);
            Pen Fail = new Pen(Color.White, 5.0f);


            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    #region Casos
                    switch (Casillas[i, j])
                    {
                        case 1:
                            if (LargeShip[i, j] == 1 || MidShip[i, j] == 1 || SmallShip[i, j] == 1)
                            {
                                Equis(e.Graphics, 0, 0, Hit);
                                hit[0] = 1;



                            }
                            else
                            {
                                Equis(e.Graphics, 0, 0, Fail);
                            }

                            break;
                        case 2:
                            if (LargeShip[i, j] == 1 || MidShip[i, j] == 1 || SmallShip[i, j] == 1)
                            {
                                Equis(e.Graphics, 100, 0, Hit);
                                hit[1] = 1;


                            }
                            else
                            {
                                Equis(e.Graphics, 100, 0, Fail);
                            }

                            break;
                        case 3:
                            if (LargeShip[i, j] == 1 || MidShip[i, j] == 1 || SmallShip[i, j] == 1)
                            {
                                Equis(e.Graphics, 200, 0, Hit);
                                hit[2] = 1;


                            }
                            else
                            {
                                Equis(e.Graphics, 200, 0, Fail);
                            }

                            break;
                        case 4:
                            if (LargeShip[i, j] == 1 || MidShip[i, j] == 1 || SmallShip[i, j] == 1)
                            {
                                Equis(e.Graphics, 300, 0, Hit);
                                hit[3] = 1;


                            }
                            else
                            {
                                Equis(e.Graphics, 300, 0, Fail);
                            }

                            break;
                        case 5:
                            if (LargeShip[i, j] == 1 || MidShip[i, j] == 1 || SmallShip[i, j] == 1)
                            {
                                Equis(e.Graphics, 400, 0, Hit);
                                hit[4] = 1;


                            }
                            else
                            {
                                Equis(e.Graphics, 400, 0, Fail);
                            }

                            break;
                        case 6:
                            if (LargeShip[i, j] == 1 || MidShip[i, j] == 1 || SmallShip[i, j] == 1)
                            {
                                Equis(e.Graphics, 0, 100, Hit);
                                hit[5] = 1;


                            }
                            else
                            {
                                Equis(e.Graphics, 0, 100, Fail);
                            }

                            break;
                        case 7:
                            if (LargeShip[i, j] == 1 || MidShip[i, j] == 1 || SmallShip[i, j] == 1)
                            {
                                Equis(e.Graphics, 100, 100, Hit);
                                hit[6] = 1;


                            }
                            else
                            {
                                Equis(e.Graphics, 100, 100, Fail);
                            }

                            break;
                        case 8:
                            if (LargeShip[i, j] == 1 || MidShip[i, j] == 1 || SmallShip[i, j] == 1)
                            {
                                Equis(e.Graphics, 200, 100, Hit);
                                hit[7] = 1;


                            }
                            else
                            {
                                Equis(e.Graphics, 200, 100, Fail);
                            }

                            break;
                        case 9:
                            if (LargeShip[i, j] == 1 || MidShip[i, j] == 1 || SmallShip[i, j] == 1)
                            {
                                Equis(e.Graphics, 300, 100, Hit);
                                hit[8] = 1;


                            }
                            else
                            {
                                Equis(e.Graphics, 300, 100, Fail);
                            }

                            break;
                        case 10:
                            if (LargeShip[i, j] == 1 || MidShip[i, j] == 1 || SmallShip[i, j] == 1)
                            {
                                Equis(e.Graphics, 400, 100, Hit);
                                hit[9] = 1;


                            }
                            else
                            {
                                Equis(e.Graphics, 400, 100, Fail);
                            }

                            break;
                        case 11:
                            if (LargeShip[i, j] == 1 || MidShip[i, j] == 1 || SmallShip[i, j] == 1)
                            {
                                Equis(e.Graphics, 0, 200, Hit);
                                hit[10] = 1;


                            }
                            else
                            {
                                Equis(e.Graphics, 0, 200, Fail);
                            }

                            break;
                        case 12:
                            if (LargeShip[i, j] == 1 || MidShip[i, j] == 1 || SmallShip[i, j] == 1)
                            {
                                Equis(e.Graphics, 100, 200, Hit);
                                hit[11] = 1;


                            }
                            else
                            {
                                Equis(e.Graphics, 100, 200, Fail);
                            }

                            break;
                        case 13:
                            if (LargeShip[i, j] == 1 || MidShip[i, j] == 1 || SmallShip[i, j] == 1)
                            {
                                Equis(e.Graphics, 200, 200, Hit);
                                hit[12] = 1;


                            }
                            else
                            {
                                Equis(e.Graphics, 200, 200, Fail);
                            }

                            break;
                        case 14:
                            if (LargeShip[i, j] == 1 || MidShip[i, j] == 1 || SmallShip[i, j] == 1)
                            {
                                Equis(e.Graphics, 300, 200, Hit);
                                hit[13] = 1;


                            }
                            else
                            {
                                Equis(e.Graphics, 300, 200, Fail);
                            }

                            break;
                        case 15:
                            if (LargeShip[i, j] == 1 || MidShip[i, j] == 1 || SmallShip[i, j] == 1)
                            {
                                hit[14] = 1;
                                Equis(e.Graphics, 400, 200, Hit);


                            }
                            else
                            {
                                Equis(e.Graphics, 400, 200, Fail);
                            }

                            break;
                        case 16:
                            if (LargeShip[i, j] == 1 || MidShip[i, j] == 1 || SmallShip[i, j] == 1)
                            {
                                hit[15] = 1;
                                Equis(e.Graphics, 0, 300, Hit);


                            }
                            else
                            {
                                Equis(e.Graphics, 0, 300, Fail);
                            }

                            break;
                        case 17:
                            if (LargeShip[i, j] == 1 || MidShip[i, j] == 1 || SmallShip[i, j] == 1)
                            {
                                hit[16] = 1;
                                Equis(e.Graphics, 100, 300, Hit);


                            }
                            else
                            {
                                Equis(e.Graphics, 100, 300, Fail);
                            }

                            break;
                        case 18:
                            if (LargeShip[i, j] == 1 || MidShip[i, j] == 1 || SmallShip[i, j] == 1)
                            {
                                hit[17] = 1;
                                Equis(e.Graphics, 200, 300, Hit);


                            }
                            else
                            {
                                Equis(e.Graphics, 200, 300, Fail);
                            }

                            break;
                        case 19:
                            if (LargeShip[i, j] == 1 || MidShip[i, j] == 1 || SmallShip[i, j] == 1)
                            {
                                hit[18] = 1;
                                Equis(e.Graphics, 300, 300, Hit);


                            }
                            else
                            {
                                Equis(e.Graphics, 300, 300, Fail);
                            }

                            break;
                        case 20:
                            if (LargeShip[i, j] == 1 || MidShip[i, j] == 1 || SmallShip[i, j] == 1)
                            {
                                hit[19] = 1;
                                Equis(e.Graphics, 400, 300, Hit);


                            }
                            else
                            {
                                Equis(e.Graphics, 400, 300, Fail);
                            }

                            break;
                        case 21:
                            if (LargeShip[i, j] == 1 || MidShip[i, j] == 1 || SmallShip[i, j] == 1)
                            {
                                hit[20] = 1;
                                Equis(e.Graphics, 0, 400, Hit);


                            }
                            else
                            {
                                Equis(e.Graphics, 0, 400, Fail);
                            }

                            break;
                        case 22:
                            if (LargeShip[i, j] == 1 || MidShip[i, j] == 1 || SmallShip[i, j] == 1)
                            {
                                hit[21] = 1;
                                Equis(e.Graphics, 100, 400, Hit);


                            }
                            else
                            {
                                Equis(e.Graphics, 100, 400, Fail);
                            }

                            break;
                        case 23:
                            if (LargeShip[i, j] == 1 || MidShip[i, j] == 1 || SmallShip[i, j] == 1)
                            {
                                hit[22] = 1;
                                Equis(e.Graphics, 200, 400, Hit);


                            }
                            else
                            {
                                Equis(e.Graphics, 200, 400, Fail);
                            }

                            break;
                        case 24:
                            if (LargeShip[i, j] == 1 || MidShip[i, j] == 1 || SmallShip[i, j] == 1)
                            {
                                hit[23] = 1;
                                Equis(e.Graphics, 300, 400, Hit);


                            }
                            else
                            {
                                Equis(e.Graphics, 300, 400, Fail);
                            }

                            break;
                        case 25:
                            if (LargeShip[i, j] == 1 || MidShip[i, j] == 1 || SmallShip[i, j] == 1)
                            {
                                hit[24] = 1;
                                Equis(e.Graphics, 400, 400, Hit);
                                counterNaves = -1;

                            }
                            else
                            {
                                Equis(e.Graphics, 400, 400, Fail);
                            }

                            break;
                        default:
                            break;
                    }
                    #endregion
                }
            }
        }

        void Equis(Graphics G, int x, int y, Pen ColorHit)
        {
            //Pen Pluma = new Pen(Color.YellowGreen, 5.0f);
            G.DrawLine(ColorHit, x + 10, y + 10, x + 90, y + 90);
            G.DrawLine(ColorHit, x + 10, y + 90, x + 90, y + 10);
        }
        int win()
        {
            labelAFLOTE.Text = counterNaves.ToString();
            labelDESTRUIDAS.Text = killNave.ToString();
            int si = 0;
            int tembala = 0;
            int temnave = 0;
            for (int e = 0; e < 25; e++)
            {
                if (hit[e] == 1)
                {
                    temnave++;
                    
                }
                killNave = temnave;
                if (balas[e] == 1)
                {
                    tembala++;
                }
                counterNaves = tembala;
            }
            if (killNave == 7)
            {
                si = 1;
                MessageBox.Show("¡Gano!, el dulce sabor de la victoria es ahora, pero esto no hizo nada más que comenzar.\n Continuara...");
            }
            if (counterNaves == 15)
            {
                si = 2;
                MessageBox.Show("¡Perdio!, La municion se termino, estamos acorralados, fue un placer servir con usted, hasta la otra vida...\n Continuara...");
                Form1.ActiveForm.Close();
            }
            

            return si;
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
                    Reconocedor.RecognizeAsync(RecognizeMode.Single);
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
                #region Comandos
                listBoxReco.Items.Clear();
                foreach (var elemento in e.Result.Alternates)
                {

                    //Filas     // Rojo Azul Verde Blanco Amarillo
                    //Columnas  // UNO DOS TRES CUATRO CINCO
                    if (elemento.Confidence > 0.5f)
                    {
                        listBoxReco.Items.Add(elemento.Text + ", Confidencia: " + elemento.Confidence.ToString());
                    }
                    if (elemento.Text == "Rojo uno disparo" || elemento.Text == "rojo uno disparo" || elemento.Text == "Rojo uno disparos" || elemento.Text == "rojo uno disparos")
                    {
                        if (Casillas[0, 0] == 0)
                        {
                            Casillas[0, 0] = 1;
                            balas[0] = 1;
                            win();
                        }
                        else
                            MessageBox.Show("Intenta en otra casilla");
                        break;
                    }
                    if (elemento.Text == "Rojo dos disparo" || elemento.Text == "rojo dos disparo" || elemento.Text == "Rojo dos disparos" || elemento.Text == "rojo dos disparos")
                    {
                        if (Casillas[0, 1] == 0)
                        {
                            Casillas[0, 1] = 2;
                            balas[1] = 1;
                            win();
                        }
                        else
                            MessageBox.Show("Intenta en otra casilla");
                        break;
                    }
                    if (elemento.Text == "Rojo tres disparo" || elemento.Text == "rojo tres disparo" || elemento.Text == "Rojo tres disparos" || elemento.Text == "rojo tres disparos")
                    {
                        if (Casillas[0, 2] == 0)
                        {
                            Casillas[0, 2] = 3;
                            balas[2] = 1;
                            win();
                        }
                        else
                            MessageBox.Show("Intenta en otra casilla");
                        break;
                    }
                    if (elemento.Text == "Rojo cuatro disparo" || elemento.Text == "rojo cuatro disparo" || elemento.Text == "Rojo cuatro disparos" || elemento.Text == "rojo cuatro disparos")
                    {
                        if (Casillas[0, 3] == 0)
                        {
                            Casillas[0, 3] = 4;
                            balas[3] = 1;
                            win();
                        }
                        else
                            MessageBox.Show("Intenta en otra casilla");
                        break;
                    }
                    if (elemento.Text == "Rojo cinco disparo" || elemento.Text == "rojo cinco disparo" || elemento.Text == "Rojo cinco disparos" || elemento.Text == "rojo cinco disparos")
                    {
                        if (Casillas[0, 4] == 0)
                        {
                            Casillas[0, 4] = 5;
                            balas[4] = 1;
                            win();
                        }
                        else
                            MessageBox.Show("Intenta en otra casilla");
                        break;
                    }
                    //--------------------1
                    if (elemento.Text == "Azul uno disparo" || elemento.Text == "azul uno disparo" || elemento.Text == "Azul uno disparos" || elemento.Text == "azul uno disparos")
                    {
                        if (Casillas[1, 0] == 0)
                        {
                            Casillas[1, 0] = 6;
                            balas[5] = 1;
                            win();
                        }
                        else
                            MessageBox.Show("Intenta en otra casilla");
                        break;
                    }
                    if (elemento.Text == "Azul dos disparo" || elemento.Text == "azul dos disparo" || elemento.Text == "Azul dos disparos" || elemento.Text == "azul dos disparos")
                    {
                        if (Casillas[1, 1] == 0)
                        {
                            Casillas[1, 1] = 7;
                            balas[6] = 1;
                            win();
                        }
                        else
                            MessageBox.Show("Intenta en otra casilla");
                        break;
                    }
                    if (elemento.Text == "Azul tres disparo" || elemento.Text == "azul tres disparo" || elemento.Text == "Azul tres disparos" || elemento.Text == "azul tres disparos")
                    {
                        if (Casillas[1, 2] == 0)
                        {
                            Casillas[1, 2] = 8;
                            balas[7] = 1;
                            win();
                        }
                        else
                            MessageBox.Show("Intenta en otra casilla");
                        break;
                    }
                    if (elemento.Text == "Azul cuatro disparo" || elemento.Text == "azul cuatro disparo" || elemento.Text == "Azul cuatro disparos" || elemento.Text == "azul cuatro disparos")
                    {
                        if (Casillas[1, 3] == 0)
                        {
                            Casillas[1, 3] = 9;
                            balas[8] = 1;
                            win();
                        }
                        else
                            MessageBox.Show("Intenta en otra casilla");
                        break;
                    }
                    if (elemento.Text == "Azul cinco disparo" || elemento.Text == "azul cinco disparo" || elemento.Text == "Azul cinco disparos" || elemento.Text == "azul cinco disparos")
                    {
                        if (Casillas[1, 4] == 0)
                        {
                            Casillas[1, 4] = 10;
                            balas[9] = 1;
                            win();
                        }
                        else
                            MessageBox.Show("Intenta en otra casilla");
                        break;
                    }
                    //--------------------2
                    if (elemento.Text == "Verde uno disparo" || elemento.Text == "verde uno disparo" || elemento.Text == "Verde uno disparos" || elemento.Text == "verde uno disparos")
                    {
                        if (Casillas[2, 0] == 0)
                        {
                            Casillas[2, 0] = 11;
                            balas[10] = 1;
                            win();
                        }
                        else
                            MessageBox.Show("Intenta en otra casilla");
                        break;
                    }
                    if (elemento.Text == "Verde dos disparo" || elemento.Text == "verde dos disparo" || elemento.Text == "Verde dos disparos" || elemento.Text == "verde dos disparos")
                    {
                        if (Casillas[2, 1] == 0)
                        {
                            Casillas[2, 1] = 12;
                            balas[11] = 1;
                            win();
                        }
                        else
                            MessageBox.Show("Intenta en otra casilla");
                        break;
                    }
                    if (elemento.Text == "Verde tres disparo" || elemento.Text == "verde tres disparo" || elemento.Text == "Verde tres disparos" || elemento.Text == "verde tres disparos")
                    {
                        if (Casillas[2, 2] == 0)
                        {
                            Casillas[2, 2] = 13;
                            balas[12] = 1;
                            win();
                        }
                        else
                            MessageBox.Show("Intenta en otra casilla");
                        break;
                    }
                    if (elemento.Text == "Verde cuatro disparo" || elemento.Text == "verde cuatro disparo" || elemento.Text == "Verde cuatro disparos" || elemento.Text == "verde cuatro disparos")
                    {
                        if (Casillas[2, 3] == 0)
                        {
                            Casillas[2, 3] = 14;
                            balas[13] = 1;
                            win();
                        }
                        else
                            MessageBox.Show("Intenta en otra casilla");
                        break;
                    }
                    if (elemento.Text == "Verde cinco disparo" || elemento.Text == "verde cinco disparo" || elemento.Text == "Verde cinco disparos" || elemento.Text == "verde cinco disparos")
                    {
                        if (Casillas[2, 4] == 0)
                        {
                            Casillas[2, 4] = 15;
                            balas[14] = 1;
                            win();
                        }
                        else
                            MessageBox.Show("Intenta en otra casilla");
                        break;
                    }
                    //--------------------3
                    if (elemento.Text == "Blanco uno disparo" || elemento.Text == "blanco uno disparo" || elemento.Text == "Blanco uno disparos" || elemento.Text == "blanco uno disparos")
                    {
                        if (Casillas[3, 0] == 0)
                        {
                            Casillas[3, 0] = 16;
                            balas[15] = 1;
                            win();
                        }
                        else
                            MessageBox.Show("Intenta en otra casilla");
                        break;
                    }
                    if (elemento.Text == "Blanco dos disparo" || elemento.Text == "blanco dos disparo" || elemento.Text == "Blanco dos disparos" || elemento.Text == "blanco dos disparos")
                    {
                        if (Casillas[3, 1] == 0)
                        {
                            Casillas[3, 1] = 17;
                            balas[16] = 1;
                            win();
                        }
                        else
                            MessageBox.Show("Intenta en otra casilla");
                        break;
                    }
                    if (elemento.Text == "Blanco tres disparo" || elemento.Text == "blanco tres disparo" || elemento.Text == "Blanco tres disparos" || elemento.Text == "blanco tres disparos")
                    {
                        if (Casillas[3, 2] == 0)
                        {
                            Casillas[3, 2] = 18;
                            balas[17] = 1;
                            win();
                        }
                        else
                            MessageBox.Show("Intenta en otra casilla");
                        break;
                    }
                    if (elemento.Text == "Blanco cuatro disparo" || elemento.Text == "blanco cuatro disparo" || elemento.Text == "Blanco cuatro disparos" || elemento.Text == "blanco cuatro disparos")
                    {
                        if (Casillas[3, 3] == 0)
                        {
                            Casillas[3, 3] = 19;
                            balas[18] = 1;
                            win();
                        }
                        else
                            MessageBox.Show("Intenta en otra casilla");
                        break;
                    }
                    if (elemento.Text == "Blanco cinco disparo" || elemento.Text == "blanco cinco disparo" || elemento.Text == "Blanco cinco disparos" || elemento.Text == "blanco cinco disparos")
                    {
                        if (Casillas[3, 4] == 0)
                        {
                            Casillas[3, 4] = 20;
                            balas[19] = 1;
                            win();
                        }
                        else
                            MessageBox.Show("Intenta en otra casilla");
                        break;
                    }
                    //--------------------4
                    if (elemento.Text == "Amarillo uno disparo" || elemento.Text == "amarillo uno disparo" || elemento.Text == "Amarillo uno disparos" || elemento.Text == "amarillo uno disparos")
                    {
                        if (Casillas[4, 0] == 0)
                        {
                            Casillas[4, 0] = 21;
                            balas[20] = 1;
                            win();
                        }
                        else
                            MessageBox.Show("Intenta en otra casilla");
                        break;
                    }
                    if (elemento.Text == "Amarillo dos disparo" || elemento.Text == "amarillo dos disparo" || elemento.Text == "Amarillo dos disparos" || elemento.Text == "amarillo dos disparos")
                    {
                        if (Casillas[4, 1] == 0)
                        {
                            Casillas[4, 1] = 22;
                            balas[21] = 1;
                            win();
                        }
                        else
                            MessageBox.Show("Intenta en otra casilla");
                        break;
                    }
                    if (elemento.Text == "Amarillo tres disparo" || elemento.Text == "amarillo tres disparo" || elemento.Text == "Amarillo tres disparos" || elemento.Text == "amarillo tres disparos")
                    {
                        if (Casillas[4, 2] == 0)
                        {
                            Casillas[4, 2] = 23;
                            balas[22] = 1;
                            win();
                        }
                        else
                            MessageBox.Show("Intenta en otra casilla");
                        break;
                    }
                    if (elemento.Text == "Amarillo cuatro disparo" || elemento.Text == "amarillo cuatro disparo" || elemento.Text == "Amarillo cuatro disparos" || elemento.Text == "amarillo cuatro disparos")
                    {
                        if (Casillas[4, 3] == 0)
                        {
                            Casillas[4, 3] = 24;
                            balas[23] = 1;
                            win();
                        }
                        else
                            MessageBox.Show("Intenta en otra casilla");
                        break;
                    }
                    if (elemento.Text == "Amarillo cinco disparo" || elemento.Text == "amarillo cinco disparo" || elemento.Text == "Amarillo cinco disparos" || elemento.Text == "amarillo cinco disparos")
                    {
                        if (Casillas[4, 4] == 0)
                        {
                            Casillas[4, 4] = 25;
                            balas[24] = 1;
                            win();
                        }
                        else
                            MessageBox.Show("Intenta en otra casilla");
                        break;
                    }
                    //--------------------5
                }
                pictureBox1.Invalidate();
                #endregion
            }
            private void btnIniciar_Click(object sender, EventArgs e)
            {
                S_ShipLocation();
                M_ShipLocation();
                L_ShipLocation();

                btnAtaque.Enabled = true;
                btnIniciar.Enabled = false;
                counterNaves = 6;
                const string caption = "La guerra a comenzado, hijo.";
                MessageBox.Show("El juego comenzo las naves fueron desplegadas, acabé con todas soldado. \nPara atacar presione el boton ATAQUE e ingrese el comando de voz como \n::-COLOR- -NUMERO- Disparo::\n de acuerdo a su plan", caption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            #region Creación de naves
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
                        y = rand.Next(1, 3);
                        x = rand.Next(1, 5);
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
                int x;
                int y;
                int x2;
                int y2;
                bool C = false;
                while (C == false)
                {
                    y = rand.Next(0, 5);
                    x = rand.Next(0, 5);
                    //x = 0;
                    //y = 0;
                    if (LargeShip[y, x] != 1 || MidShip[y, x] != 1)
                    {
                        SmallShip[y, x] = 1;
                        C = true;

                    }
                }
                bool C2 = false;
                while (C2 == false)
                {
                    y2 = rand.Next(0, 5);
                    x2 = rand.Next(3, 4);
                    //x2 = 0;
                    //y2 = 1;
                    if (LargeShip[y2, x2] != 1 || MidShip[y2, x2] != 1)
                    {
                        SmallShip[y2, x2] = 1;

                        C2 = true;
                    }
                }
            }

            #endregion

            private void listBoxReco_SelectedIndexChanged(object sender, EventArgs e)
            {

            }

            private void Form1_Load(object sender, EventArgs e)
            {

            }

            private void label2_Click(object sender, EventArgs e)
            {

            }

        }
    }

