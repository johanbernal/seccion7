using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppNumeros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //instanciar objeto numero
            Numero numero1=new Numero(int.Parse (txtNumeroMayor.Text),int.Parse(txtNumeroMenor.Text));

            List<int> rangonumero=new List<int>();
            rangonumero = numero1.MostrarRango();//llenar vector
            foreach (int contador2 in rangonumero)
            {
                rtbMostrarRango.Text = rtbMostrarRango.Text + " " + contador2.ToString();
            }
        }
    }
}
