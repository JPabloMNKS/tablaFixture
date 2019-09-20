using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Versus
{
    public partial class Form1 : Form
    {
        // Drag Window Panel
        private bool draggable;
        private int mouseX;
        private int mouseY;

        // variables 
        int aux12 = 0;
        int i = 0;
        Random r = new Random();
        int a;
        int[] aleatorio;

        private string[] archivo;
        private string[] rutaArchivos;
        OpenFileDialog imagenes;


        // Drag Window
        private void PanelTop_MouseDown(object sender, MouseEventArgs e)
        {
            draggable = true;
            mouseX = Cursor.Position.X - this.Left;
            mouseY = Cursor.Position.Y - this.Top;
        }
        private void PanelTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (draggable)
            {
                this.Left = Cursor.Position.X - mouseX;
                this.Top = Cursor.Position.Y - mouseY;
            }
        }
        private void PanelTop_MouseUp(object sender, MouseEventArgs e)
        {
            draggable = false;
        }
        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void FuncionAleatorio()
        {
            i = 0;
            aux12 = 0;
            aleatorio = new int[8];

            while (aux12 < 7)
            {
                a = r.Next(0, 8);

                if (!aleatorio.Contains(a))
                {
                    aleatorio[i] = a;
                    i++;
                    aux12++;
                }
            }
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            FuncionAleatorio();
        }

        private void BtnAgregarInformacion_Click(object sender, EventArgs e)
        {
            imagenes = new OpenFileDialog();
            

            imagenes.Multiselect = true;
            imagenes.Filter = "Image Files(*.PNG;*.JPG)|*.PNG;*.JPG";
            if(imagenes.ShowDialog() == DialogResult.OK)
            {
                archivo = imagenes.SafeFileNames;
                rutaArchivos = imagenes.FileNames;

            }
            insertarImagen();
        }

        private void insertarImagen()
        {
            team1.Load(rutaArchivos[aleatorio[0]]);
            team2.Load(rutaArchivos[aleatorio[1]]);
            team3.Load(rutaArchivos[aleatorio[2]]);
            team4.Load(rutaArchivos[aleatorio[3]]);
            team5.Load(rutaArchivos[aleatorio[4]]);
            team6.Load(rutaArchivos[aleatorio[5]]);
            team7.Load(rutaArchivos[aleatorio[6]]);
            team8.Load(rutaArchivos[aleatorio[7]]);

            txtTeam1.Text = archivo[aleatorio[0]];
            txtTeam2.Text = archivo[aleatorio[1]];
            txtTeam3.Text = archivo[aleatorio[2]];
            txtTeam4.Text = archivo[aleatorio[3]];
            txtTeam5.Text = archivo[aleatorio[4]];
            txtTeam6.Text = archivo[aleatorio[5]];
            txtTeam7.Text = archivo[aleatorio[6]];
            txtTeam8.Text = archivo[aleatorio[7]];


        }

        private void BtnVS1_Click(object sender, EventArgs e)
        {
            Prueba grupo1 = new Prueba(rutaArchivos[aleatorio[0]], rutaArchivos[aleatorio[1]],
                                        txtTeam1.Text,txtTeam2.Text);
            grupo1.Show();
        }
    }
}
