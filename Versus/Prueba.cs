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
    public partial class Prueba : Form
    {
        string img1="", img2="", txt1="", txt2="";


        public Prueba()
        {
            InitializeComponent();
        }

        public Prueba(string img1, string img2, string txt1, string txt2)
        {
            InitializeComponent();
            this.img1 = img1;
            this.img2 = img2;
            this.txt1 = txt1;
            this.txt2 = txt2;
            teamPrueba1.Load(img1);
            teamPrueba2.Load(img2);
            txtTeamPrueba1.Text = txt1;
            txtTeamPrueba2.Text = txt2;

        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Team1_Click(object sender, EventArgs e)
        {

        }
    }
}
