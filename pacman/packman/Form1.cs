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

namespace packman
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //LIBRERIA
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int IParam);

        //VARIABLE
        public bool direccion_fantasma = true;
        System.Media.SoundPlayer inicio;
        //ARRANCA EL FORMULARIO
        private void Form1_Load(object sender, EventArgs e)
        {
            MOVIMIENTO.Start();
            inicio = new System.Media.SoundPlayer(Properties.Resources.defondoenjuego);
            inicio.Play();
        }
        //CERRAR LA APLIACACION
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //INICIAR EL JUEGO
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 juego = new Form2();
            juego.Show();
            inicio.Stop();
            this.Hide();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
