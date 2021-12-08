using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Windows.Forms;

namespace Loteria_Mexicana
{
    public partial class FormMenu : Form
    {
        const int cantidad_cartas = 54;
        private PictureBox[] tabla;

        public FormMenu()
        {
            InitializeComponent(); ;
            tabla = new PictureBox[25];
            InicializarTabla();
        }

        private void InicializarTabla()
        {
            int r = 0, c = 0;
            r = 0;
            c = 0;

            int[] cartas = new int[25];

            for (int i = 0; i < cartas.Length; i++)
            {
                cartas[i] = i + 1;
            }

            Random ra = new Random();

            int a, aux;

            for (int i = 0; i < cartas.Length; i++)
            {
                a = ra.Next(cartas.Length);
                aux = cartas[i];
                cartas[i] = cartas[a];
                cartas[a] = aux;
            }

            for (int i = 0; i < tabla.Length; i++)
            {
                tabla[i] = new PictureBox();
                tabla[i].Location = new System.Drawing.Point(100 + (c * 90), 25 + (r * 125));
                tabla[i].Name = "cartas" + i;
                tabla[i].Size = new System.Drawing.Size(85, 120);
                tabla[i].TabIndex = 0 + i;
                tabla[i].SizeMode = PictureBoxSizeMode.StretchImage;
                tabla[i].TabStop = false;
                tabla[i].Image = Image.FromFile(@"cartas\)" + (cartas[i]) + ".jpg");
                this.Controls.Add(tabla[i]);
                c++;
                if (c == 5)
                {
                    r++;
                    c = 0;
                }
            }
        }
        private PictureBox[] baraja;
        private void InicializarBaraja()
        {
             int[] cartas = new int[54];

            for (int i = 0; i < cartas.Length; i++)
            {
                cartas[i] = i + 1;
            }
            Random ra = new Random();
            int a, aux;
            for (int i = 0; i < cartas.Length; i++)
            {
                a = ra.Next(cartas.Length);
                aux = cartas[i];
                cartas[i] = cartas[a];
                cartas[a] = aux;
            }

            for (int i = 0; i < baraja.Length; i++)
            {
                baraja[i] = new PictureBox();
                baraja[i].Location = new System.Drawing.Point (825, 45);
                baraja[i].Name = "cartas" + i;
                baraja[i].Size = new System.Drawing.Size(85, 120);
                baraja[i].TabIndex = 0 + i;
                baraja[i].SizeMode = PictureBoxSizeMode.StretchImage;
                baraja[i].TabStop = false;
                baraja[i].Image = Image.FromFile(@"cartas\)" + (cartas[i]) + ".jpg");
                this.Controls.Add(baraja[i]);
                
               
            }


        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            InicializarTabla();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            InicializarBaraja();               
        }
    }
}
