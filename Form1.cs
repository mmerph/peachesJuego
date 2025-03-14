using System;
using System.Drawing;
using System.Windows.Forms;

namespace PeachesGame
{
    public partial class Form1 : Form
    {
        //Velocidad de caída de los duraznos
        int peachVelocidad = 5;
        //puntuación
        int score = 0;

        Random rdm = new Random(); 


        public Form1()
        {
            InitializeComponent();
        }

        private void restartGame(object sender, EventArgs e)
        {
            ResetGame();
        }

        private void ResetGame() 
        {
            //oculta la imagen de fin de juego
            award.Visible = false;

            //reinicia puntuación e imagen
            score = 0;
            award.Image = Properties.Resources.lost;
            //reinicia velocidad del durazno
            peachVelocidad = 5;
            //posiciona los duraznos aleatoriamente en x
            Resetpeach1();
            Resetpeach2();
            Resetpeach3();
            Resetpodrido();
            ResetCanasta();

            //inicia el temporizador del juego
            gameTimer.Enabled = true;
            gameTimer.Start();
        }

        private void Resetpeach1()
        {
            peach.Top = rdm.Next(-70, 0);
            peach.Left = rdm.Next(0, 345);
        }

        private void Resetpeach2()
        {
            peach2.Top = rdm.Next(-70, 15);
            peach2.Left = rdm.Next(0, 345);
        }
        private void Resetpeach3()
        {
            peach3.Top = rdm.Next(-70, 15);
            peach3.Left = rdm.Next(0, 345);
        }
        private void Resetpodrido()
        {
            podrido.Top = rdm.Next(-70, 15);
            podrido.Left = rdm.Next(0, 345);
        }

        private void ResetCanasta()
        {
            basket.Top = 476;
            basket.Left = rdm.Next(0, 280);
        }
        private void gameTimerEvent(object sender, EventArgs e)
        {
            //mueve los duraznos hacia abajo
            peach.Top += peachVelocidad;
            peach2.Top += peachVelocidad;
            peach3.Top += peachVelocidad;
            podrido.Top += peachVelocidad;

            //veifica si el durazno fue atrapado
            if (peach.Bounds.IntersectsWith(basket.Bounds))
            {
                //aumenta los puntos
                score++;
                //actualiza la etiqueta de puntos
                labelPuntos.Text = "Puntos: " + score;
                //Resposiciona los duraznos en la parte superior
                Resetpeach1();
            } 
            else if (peach2.Bounds.IntersectsWith(basket.Bounds))
            {
                score++;
                labelPuntos.Text = "Puntos: " + score;
                Resetpeach2();
            } 
            else if (peach3.Bounds.IntersectsWith(basket.Bounds))
            {
                score++;
                labelPuntos.Text = "Puntos: " + score;
                Resetpeach3();
            } 

            //Verifica si los duranos han llegado al suelo
            if (peach.Top >= 470)
            {
                //Resposiciona los duraznos en la parte superior
                Resetpeach1();
            }
            if (peach2.Top >= 470)
            {
                Resetpeach2();
            }
            if (peach3.Top >= 470)
            {
                Resetpeach3();
            }
            if (podrido.Top >= 470)
            {
                Resetpodrido();
            }

            //Verifica si agarró un durazno podrido, if true => pierde
            if (podrido.Bounds.IntersectsWith(basket.Bounds))
            {
                GameOver();
            }
            //Cambia la imagen al perder dependiendo de la puntuación
            if (score <= 10)
            {
                peachVelocidad = 10;
                award.Image = Properties.Resources.lost;
            }
            if (score > 10 && score <= 25)
            {
                peachVelocidad = 15; 
                award.Image = Properties.Resources.wonBronce;
            }
            if (score > 25 && score <= 40)
            {
                peachVelocidad = 20; 
                award.Image = Properties.Resources.wonPlata;
            }
            if (score > 40)
            {
                peachVelocidad = 25; 
                award.Image = Properties.Resources.wonOro;
            }
        }

        private void GameOver()
        {
            //Hace la imagen de premio visible
            award.Visible = true;
            //Detiene el temporizador
            gameTimer.Stop(); 
        }

        private void keyisDown(object sender, KeyEventArgs e)
        {
            // Mueve la canasta a la izquierda
            if (e.KeyCode == Keys.Left && basket.Left > 0)
            {
                basket.Left -= 10;
            }
            // Mueve la canasta a la derecha
            if (e.KeyCode == Keys.Right && basket.Right < 400)
            {
                basket.Left += 10;
            }
        }
    }
}
