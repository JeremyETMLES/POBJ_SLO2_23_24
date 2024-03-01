using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex1
{
    public partial class Form1 : Form
    {
        double TauxChange = 1.05;
        public Form1()
        {
            InitializeComponent();
        }

        private void picDevises_Click(object sender, EventArgs e)
        {
            double Resultat;
            double Montant;
            try
            {
                // Posibilité d'utiliser tryParse
                Montant = double.Parse(txtMontant.Text);
            }
            catch
            {
                MessageBox.Show("Le montant Connard");
                txtMontant.Text = "Le montant connard";
                Montant = 0;
            }
            Resultat = Montant * TauxChange;
            txtResultat.Text = Resultat.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            picDevises.Image = Properties.Resources.DrapeauSuisse;
        }

        private void rbnGBP_CheckedChanged(object sender, EventArgs e)
        {
            picDevises.Image = imageList1.Images[0];
            TauxChange = 1.17;
        }

        private void rbnYen_CheckedChanged(object sender, EventArgs e)
        {
            picDevises.Image = imageList1.Images[1];
            TauxChange = 0.0061;
        }

        private void rbnSFR_CheckedChanged(object sender, EventArgs e)
        {
            picDevises.Image = imageList1.Images[2];
            TauxChange = 1.05;
        }

        private void rbnUSD_CheckedChanged(object sender, EventArgs e)
        {
            picDevises.Image = imageList1.Images[3];
            TauxChange = 0.92;
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            double Resultat;
            double Montant;
            try
            {
                
                Montant = double.Parse(txtMontant.Text);
               
            }
            catch
            {
                txtMontant.Text = "0";
                Montant = 0;
            }
            Resultat = Montant * TauxChange;
            txtResultat.Text = Resultat.ToString();
        }

    }
}
