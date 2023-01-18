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
    public partial class Form3 : Form
    {
        //LIBRERIA
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int IParam);

        //VARIABLE--------------------
        public int el_tipo;
        SoundPlayer sonido_de_fondo = new SoundPlayer();


        //INICIO FORMULARIO------------
        public Form3(int tipo)
        {
            InitializeComponent();
            el_tipo = tipo;
        }

        //VOLVER A JUGAR------------------------------------------
        private void jugar_Click(object sender, EventArgs e)
        {
            Form2 juego = new Form2();
            juego.Show();
            this.Dispose();            
        }
      

        private void no_jugar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        //MOVER EL FORMULARIO
        private void Form3_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Form3_Load(object sender, EventArgs e)
        {                      
            tuki();
        }

        public void tuki()
        {
            System.Media.SoundPlayer logout = new System.Media.SoundPlayer(Properties.Resources.gameover);
            System.Media.SoundPlayer win = new System.Media.SoundPlayer(Properties.Resources.defondoenjuego);
            if (el_tipo == 2)
            {
                titulo.Text = "YOU WIN";
                cartel.Image = packman.Properties.Resources.efb2bb4f6c33eed_unscreen1;
                
                win.PlayLooping();

            }
            else
            {
                
                logout.PlayLooping();
            }
        }

    }
}
