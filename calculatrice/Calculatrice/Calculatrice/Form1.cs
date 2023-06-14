using Calculatrice.Metier;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculatrice
{
    public partial class Form1 : Form
    {
        Expression exp = new Expression();

        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Chiffre_Click(object sender, 
            EventArgs e)
        {
            ecran.Text += (sender as Button).Text;

        }
        private void Operation_Click(object sender,
    EventArgs e)
        {
            exp.A = ecran.Text;
            exp.Op = (sender as Button).Text;
            Effacer();
        }

        private void Effacer()
        {
            ecran.Text = "";
        }

        private void effacer_Click(object sender, EventArgs e)
        {
            Effacer();
        }

        private void egal_Click(object sender, EventArgs e)
        {
            exp.B = ecran.Text;
            ecran.Text = exp.Evaluer();
        }
    }
}
