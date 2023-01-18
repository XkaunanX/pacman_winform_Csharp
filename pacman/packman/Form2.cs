using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Media;

namespace packman
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            this.KeyPreview = true;
            
        }

        //MOVIMIENTO BARRA POR LIBRERIA

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int IParam);

       

        //VARIABLES------------------VARIABLES------------------------------------
        public int scores;
        public bool spray_pacman = true;
        public bool b_rojo = true;
        public int pos_rojo = 1;
        public int b_azul1 = 1;
        public int num_tp = 1;
        public int vidas = 3;
        public int randomNumber;
        public int randomNaranja;
        public int tipo_intermedia;
        Random random = new Random();
        
        System.Media.SoundPlayer packman_sound;
        System.Media.SoundPlayer fantasma_teleport;
        System.Media.SoundPlayer tp;
        System.Media.SoundPlayer dano;
        System.Media.SoundPlayer powerup;


        //---------------TECLADOS----------------------------TECLADOS-------------
        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.S)
            {
                packman_sound.PlayLooping();
                timer1.Enabled = true;
                timer1.Start();
                timer2.Stop();
                timer3.Stop();
                timer4.Stop();
            }
            else if (e.KeyCode == Keys.W)
            {
                packman_sound.PlayLooping();
                timer2.Enabled = true;
                timer2.Start();
                timer1.Stop();
                timer3.Stop();
                timer4.Stop();
            }
            else if (e.KeyCode == Keys.A)
            {
                packman_sound.PlayLooping();
                timer3.Enabled = true;
                timer3.Start();
                timer2.Stop();
                timer1.Stop();
                timer4.Stop();
            }
            else if (e.KeyCode == Keys.D)
            {
                packman_sound.PlayLooping();
                timer4.Enabled = true;
                timer4.Start();
                timer2.Stop();
                timer3.Stop();
                timer1.Stop();
            }
        }
        

        //---------------MOVIMIENTOS------------------------------MOVIMIENTOS-------------741
        private void timer1_Tick(object sender, EventArgs e)
        {
         //COORDENADA MAXIMA ABAJO  
            button1.Location = new Point(button1.Location.X + 0, button1.Location.Y + 10);

            if (button1.Top > 708)
            {
                button1.Top = 708;
            }

            foreach (Control x in this.Controls)
            {
                if (x is Label)
                {
                    if ((string)x.Tag == "comida_simple" && x.Visible == true)
                    {
                        if (button1.Bounds.IntersectsWith(x.Bounds))
                        {
                            x.Visible = false;                            
                            scores += 1;
                            var s = System.Convert.ToString(scores);
                            score.Text = "SCORE: " + s;
                        }
                    }
                   

                }
            }

            foreach (Control k in this.Controls)
            {
                if (k is Label)
                {
                    if ((string)k.Tag == "comida_grande" && k.Visible == true)
                    {
                        if (button1.Bounds.IntersectsWith(k.Bounds))
                        {
                            k.Visible = false;
                            scores += 5;
                            var s = System.Convert.ToString(scores);
                            score.Text = "SCORE: " + s;
                        }
                    }


                }
            }

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox)
                {
                    if ((string)x.Tag == "contacto")
                    {
                        if (button1.Bounds.IntersectsWith(x.Bounds))
                        {
                            button1.Location = new Point(button1.Location.X + 0, button1.Location.Y - 10);
                            packman_sound.Stop();
                        }
                    }

                }
            }

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            //CORDENADA MAXIMA ARRIBA
            button1.Location = new Point(button1.Location.X + 0, button1.Location.Y - 10);
            if (button1.Top < 44)
            {
                button1.Top = 44;
            }

            foreach (Control x in this.Controls)
            {
                if (x is Label)
                {
                    if ((string)x.Tag == "comida_simple" && x.Visible == true)
                    {
                        if (button1.Bounds.IntersectsWith(x.Bounds))
                        {
                            x.Visible = false;
                            ;
                            scores += 1;
                            var s = System.Convert.ToString(scores);
                            score.Text = "SCORE: " + s;
                        }
                    }
                    

                }
            }

            foreach (Control k in this.Controls)
            {
                if (k is Label)
                {
                    if ((string)k.Tag == "comida_grande" && k.Visible == true)
                    {
                        if (button1.Bounds.IntersectsWith(k.Bounds))
                        {
                            k.Visible = false;
                            
                            scores += 5;
                            var s = System.Convert.ToString(scores);
                            score.Text = "SCORE: " + s;
                        }
                    }


                }
            }

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox)
                {
                    if ((string)x.Tag == "contacto")
                    {
                        if (button1.Bounds.IntersectsWith(x.Bounds))
                        {
                            button1.Location = new Point(button1.Location.X + 0, button1.Location.Y + 10);
                            packman_sound.Stop();
                        }
                    }

                }
            }

          
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            //CORDENADA MAXIMA IZQUIERDA
            button1.Location = new Point(button1.Location.X - 10, button1.Location.Y - 0);
        
            if (button1.Left < 39)
            {
                button1.Left = 39;
            }

            foreach (Control x in this.Controls)
            {
                if (x is Label)
                {
                    if ((string)x.Tag == "comida_simple" && x.Visible == true)
                    {
                        if (button1.Bounds.IntersectsWith(x.Bounds))
                        {
                            x.Visible = false;
                           
                            scores += 1;
                            var s = System.Convert.ToString(scores);
                            score.Text = "SCORE: " + s;
                        }
                    }
                    

                }
            }

            foreach (Control k in this.Controls)
            {
                if (k is Label)
                {
                    if ((string)k.Tag == "comida_grande" && k.Visible == true)
                    {
                        if (button1.Bounds.IntersectsWith(k.Bounds))
                        {
                            k.Visible = false;
                            scores += 5;
                            var s = System.Convert.ToString(scores);
                            score.Text = "SCORE: " + s;
                        }
                    }


                }
            }

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox)
                {
                    if ((string)x.Tag == "contacto")
                    {
                        if (button1.Bounds.IntersectsWith(x.Bounds))
                        {
                            button1.Location = new Point(button1.Location.X + 10, button1.Location.Y - 0);
                            packman_sound.Stop();
                        }
                    }

                }
            }
            
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            //CORDENADA MAXIMA DERECHA
            button1.Location = new Point(button1.Location.X + 10, button1.Location.Y - 0);
            if (button1.Left > 720)
            {
                button1.Left = 720;
            }

            foreach (Control x in this.Controls)
            {
                if (x is Label)
                {
                    if ((string)x.Tag == "comida_simple" && x.Visible == true)
                    {
                        if (button1.Bounds.IntersectsWith(x.Bounds))
                        {
                            x.Visible = false;                           
                            scores += 1;
                            var s = System.Convert.ToString(scores);
                            score.Text = "SCORE: " + s;
                        }
                    }              
                    

                }
            }

            foreach (Control k in this.Controls)
            {
                if (k is Label)
                {
                    if ((string)k.Tag == "comida_grande" && k.Visible == true)
                    {
                        if (button1.Bounds.IntersectsWith(k.Bounds))
                        {
                            k.Visible = false;
                            scores += 5;
                            var s = System.Convert.ToString(scores);
                            score.Text = "SCORE: " + s;
                        }
                    }


                }
            }

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox)
                {
                    if ((string)x.Tag == "contacto")
                    {
                        if (button1.Bounds.IntersectsWith(x.Bounds))
                        {
                            button1.Location = new Point(button1.Location.X - 10, button1.Location.Y - 0);
                            packman_sound.Stop();
                        }
                    }

                }
            }

            

        }
        //----------------------------FANTASMAS___________________________________FANTASMAS----------------ROJO
        private void fantama_rojo_Tick(object sender, EventArgs e)
        {
            if (fan_rojo.Left > 700)
            {                             
                b_rojo = false;
            }
            else if (fan_rojo.Left < 45)
            {
                b_rojo = true;                
            }

            if (b_rojo == true)
            {
                de_ro();
            }
            else
            {
                iz_ro();
            }

        }

        private void de_ro()
        {
            fan_rojo.Location = new Point(fan_rojo.Location.X + 10, fan_rojo.Location.Y - 0);
        }

        private void iz_ro()
        {
            fan_rojo.Location = new Point(fan_rojo.Location.X - 10, fan_rojo.Location.Y - 0);

        }
        //----------------------------FANTASMAS-----------------------------------------------FANTASMAS----------------azul
        private void fantasma_celeste_Tick(object sender, EventArgs e)//1
        {
            if (fan_cian.Top > 635)
            {                
                b_azul1 = 2;
            }
            else if (fan_cian.Top > 45)
            {
                b_azul1 = 1;               
            }

            if (fan_cian.Left > 640)
            {
                fantasma_celeste.Stop();//CAMBIO DE MOVIMIENTO fin primera parte
                fantasma_celeste2.Start();//CAMBIO DE MOVIMIENTO inicio segunda parte
            }

            if (b_azul1 == 1)
            {
                iz1_azul();
            }
            else if(b_azul1 == 2)
            {
                de1_azul();
            }
            
        }

        private void iz1_azul()
        {
            fan_cian.Location = new Point(fan_cian.Location.X + 0, fan_cian.Location.Y + 10);
        }

        private void de1_azul()
        {
            fan_cian.Location = new Point(fan_cian.Location.X + 10, fan_cian.Location.Y - 0);
        }

        //MOVIMIENTO FANTASMA PARTE 2
        private void fantasma_celeste2_Tick(object sender, EventArgs e)//2
        {
            if (fan_cian.Top > 570)
            {
                b_azul1 = 4;
            }
            else if (fan_cian.Top > 45)
            {
                b_azul1 = 5;
            }

            if (fan_cian.Left > 705)
            {
                fantasma_celeste2.Stop();//CAMBIO DE MOVIMIENTO fin segunda parte
                fantasma_celeste3.Start();
            }

            if (b_azul1 == 4)
            {
                ar1_azul();
            }
            else if (b_azul1 == 5)
            {
               de2_azul();
            }
            
        }

        private void ar1_azul()
        {
            fan_cian.Location = new Point(fan_cian.Location.X + 0, fan_cian.Location.Y - 10);
        }

        private void de2_azul()
        {
            fan_cian.Location = new Point(fan_cian.Location.X + 10, fan_cian.Location.Y - 0);
        }

        private void fantasma_celeste3_Tick(object sender, EventArgs e)//3
        {
            if (fan_cian.Top > 500)
            {
                b_azul1 = 6;
            }
            else if (fan_cian.Top > 45)
            {
                b_azul1 = 7;
            }

            if (fan_cian.Left < 595)
            {
                fantasma_celeste3.Stop();//CAMBIO DE MOVIMIENTO fin tercera parte
                fantasma_celeste.Start();///CAMBIO DE MOVIMIENTO incio 4 parte
            }

            if (b_azul1 == 6)
            {
                ar1_azul();
            }
            else if (b_azul1 == 7)
            {
                iz2_azul();
            }
        }

        private void ar2_azul()
        {
            fan_cian.Location = new Point(fan_cian.Location.X + 0, fan_cian.Location.Y - 10);
        }

        private void iz2_azul()
        {
            fan_cian.Location = new Point(fan_cian.Location.X - 10, fan_cian.Location.Y - 0);
        }

        //____________________________CARGA DEL FORM EVENTO________________________________________________cordenadas de azul de inicio 563¡
        private void Form2_Load(object sender, EventArgs e)
        {   //SONIDO DE FONDO
            
            //TIMERS
            iniciar_musica();
            intermitencia.Start();
            fantama_rojo.Start();
            fantasma_celeste.Start();           
            timer_fantasmas.Start();
            acercamiento_fantama.Start();
            timer_de_naraja.Start();
            //DIRECCION
            randomNaranja = 2;
        }
        //MUSICA
        private void iniciar_musica()
        {
            packman_sound = new System.Media.SoundPlayer(Properties.Resources.packmansound);
            fantasma_teleport = new System.Media.SoundPlayer(Properties.Resources.tp_fanf);
            tp = new System.Media.SoundPlayer(Properties.Resources.tps);
            dano = new System.Media.SoundPlayer(Properties.Resources.danoo);

        }

        //CERRAR APLICACION
        private void pictureBox58_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //EFECTO DE INTERMITENCIA
        private void intermitencia_Tick(object sender, EventArgs e)
        {
                     
            if (spray_pacman == true)
            {
                spray_pacman = false;
                button1.BackgroundImage = packman.Properties.Resources.efb2bb4f6c33eed_unscreen1;
            }
            else if(spray_pacman == false)
            {
                spray_pacman = true;
                button1.BackgroundImage = packman.Properties.Resources.frame_2;
            }

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox)
                {
                    if ((string)x.Tag == "portal")
                    {
                        if (button1.Bounds.IntersectsWith(x.Bounds))
                        {
                            teleport();
                            timer1.Stop();
                            timer2.Stop();
                            timer3.Stop();
                            timer4.Stop();
                        }
                    }

                }
            }

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox)
                {
                    if ((string)x.Tag == "fan")
                    {
                        if (button1.Bounds.IntersectsWith(x.Bounds))
                        {
                            timer1.Stop();
                            timer2.Stop();
                            timer3.Stop();
                            timer4.Stop();
                            muerte();
                        }
                    }

                }
            }
            //GANAR---------------------------------------------------220
            if (scores > 220)
            {
                tipo_intermedia = 2;
                Form3 pantalla_intermedia = new Form3(tipo_intermedia);
                pantalla_intermedia.Show();
                this.Dispose();
            }

        }
        //TELEPORT------------------------TELEPORT----------------------
        private void teleport()
        {   
            button1.Location = new Point(380, 352);
            por.Visible = true;
            timer1.Enabled = false;
            timer2.Enabled = false;
            timer3.Enabled = false;
            timer4.Enabled = false;
            tp.Play();
            anim_portal.Start();
        }
        //MUERTE---------------------------MUERTE----------------------
        private void muerte()
        {
            
            vidas = vidas - 1;
            if (vidas == 2)
            {
                dano.Play();
                vida3.Visible = false;
                restart();
            }
            else if (vidas == 1)
            {
                dano.Play();
                vida2.Visible = false;
                restart();
            }
            else if (vidas == 0)
            {
                dano.Play();
                vida1.Visible = false;
                fin_del_juego();
            }
        }
        //0 VIDAS---------------- 0 VIDAS
        private void fin_del_juego()
        {
            tipo_intermedia = 1;
            Form3 pantalla_intermedia = new Form3(tipo_intermedia);
            pantalla_intermedia.Show();
            this.Dispose();
        }

        //RESTART PARTIDA--------------------------RESTART PARTIDA
        private void restart()
        {
            button1.Location = new Point(380, 352);
            fan_cian.Location = new Point(577, 498);
            fan_rojo.Location = new Point(181, 704);
            fan_naranja.Location = new Point(181, 177);
            fan_rosa.Location = new Point(580, 143);

        }
        //TELEPORT FANTASMA ROJO
        private void fantasma_rojo_tp_Tick(object sender, EventArgs e)
        {
            if (pos_rojo == 1)
            {
                fan_rojo.Location = new Point(183, 142);
                pos_rojo = 2;
            }else if (pos_rojo == 2)
            {
                fan_rojo.Location = new Point(181, 704);
                pos_rojo = 1;
            }
        }
        //TELEPORT FANTASMAS 580; 143  | 179; 140 | 181; 633 | 503; 633
        private void timer_fantasmas_Tick(object sender, EventArgs e)
        {
            fantasma_teleport.Play();
            randomNumber = random.Next(1, 5);
            Console.WriteLine(randomNumber);

           if(randomNumber == 1)
            {
                fan_rosa.Location = new Point(580, 143);
                
            }
            else if(randomNumber == 2)
            {
                fan_rosa.Location = new Point(179, 140);
                

            }
            else if(randomNumber == 3)
            {
                fan_rosa.Location = new Point(503, 633);
                
            }
            else if(randomNumber == 4)
            {
                fan_rosa.Location = new Point(181, 633);
                
            }
        }
        //SEGUIMIENTO FANTASMA --------------------
        private void acercamiento_fantama_Tick(object sender, EventArgs e)
        {
            var loc_x_pacman = button1.Location.X;
            var loc_y_pacman = button1.Location.Y;

            var loc_x_fantasma = fan_rosa.Location.X;
            var loc_y_fantasma = fan_rosa.Location.Y;

            if (loc_x_pacman > loc_x_fantasma)
            {
                fan_rosa.Location = new Point(fan_rosa.Location.X + 20, fan_rosa.Location.Y - 0);
            }
            else if(loc_x_pacman < loc_x_fantasma)
            {
                fan_rosa.Location = new Point(fan_rosa.Location.X - 20, fan_rosa.Location.Y - 0);
            }

            if (loc_y_pacman > loc_y_fantasma)
            {
                fan_rosa.Location = new Point(fan_rosa.Location.X + 0, fan_rosa.Location.Y + 20);
            }
            else if(loc_y_pacman < loc_y_fantasma)
            {
                fan_rosa.Location = new Point(fan_rosa.Location.X + 0, fan_rosa.Location.Y - 20);
            }
        }
        //ANIMACION PORTAL
        private void anim_portal_Tick(object sender, EventArgs e)
        {
            por.Visible = false;
            timer1.Enabled = true;
            timer2.Enabled = true;
            timer3.Enabled = true;
            timer4.Enabled = true;
            anim_portal.Stop();
        }
        //MOVIMIENTO -------------------- FORMULARIO
        private void Form2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }



        //TIMER DEL EVENTO
        private void timer_de_naraja_Tick(object sender, EventArgs e)
        {
            movimiento_naranja();
        }
        //DIRECCION MOVIMIENTOS
        private void movimiento_naranja()
        {           
                       
            if(randomNaranja == 2)//MOVIMIENTO 1
            {
                fan_naranja.Location = new Point(fan_naranja.Location.X + 10, fan_naranja.Location.Y - 0);

                foreach (Control l in this.Controls)
                {
                    if (l is PictureBox)
                    {
                        if ((string)l.Tag == "contacto")
                        {
                            if (fan_naranja.Bounds.IntersectsWith(l.Bounds))
                            {
                                fan_naranja.Location = new Point(fan_naranja.Location.X - 10, fan_naranja.Location.Y - 0);
                                generar_random();
                            }
                        }

                    }
                }
                
            }
            else if(randomNaranja == 3)//MOVIMIENTO 2
            {
                
                fan_naranja.Location = new Point(fan_naranja.Location.X - 10, fan_naranja.Location.Y - 0);

                foreach (Control l in this.Controls)
                {
                    if (l is PictureBox)
                    {
                        if ((string)l.Tag == "contacto")
                        {
                            if (fan_naranja.Bounds.IntersectsWith(l.Bounds))
                            {
                                fan_naranja.Location = new Point(fan_naranja.Location.X + 10, fan_naranja.Location.Y - 0);
                                generar_random();
                                
                            }
                        }

                    }
                }
            }
            else if(randomNaranja == 4)//MOVIMIENTO 3
            {
                
                fan_naranja.Location = new Point(fan_naranja.Location.X + 0, fan_naranja.Location.Y - 10);

                foreach (Control l in this.Controls)
                {
                    if (l is PictureBox)
                    {
                        if ((string)l.Tag == "contacto")
                        {
                            if (fan_naranja.Bounds.IntersectsWith(l.Bounds))
                            {
                                fan_naranja.Location = new Point(fan_naranja.Location.X - 0, fan_naranja.Location.Y + 10);
                                generar_random();
                            }
                        }

                    }
                }
            }
            else if(randomNaranja == 1)//MOVIMIENTO 4
            {
                
                fan_naranja.Location = new Point(fan_naranja.Location.X + 0, fan_naranja.Location.Y + 10);

                foreach (Control l in this.Controls)
                {
                    if (l is PictureBox)
                    {
                        if ((string)l.Tag == "contacto")
                        {
                            if (fan_naranja.Bounds.IntersectsWith(l.Bounds))
                            {
                                fan_naranja.Location = new Point(fan_naranja.Location.X - 0, fan_naranja.Location.Y - 10);
                                generar_random();
                            }
                        }

                    }
                }
            }
        }
        //GENERAR RANDOM
        private void generar_random()
        {   
            
            var seed = Environment.TickCount;
            var random_naranja = new Random(seed);

            for (int i = 0; i <= 1; i++)
            {
                var value = random_naranja.Next(1, 5);
                Console.WriteLine($"Iteración {i} - semilla {seed} - valor {value}");
                randomNaranja = value;
            }

        }

    }
}
