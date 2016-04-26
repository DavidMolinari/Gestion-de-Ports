using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Port_classes_console;

namespace Port_Classe
{
    public partial class FrmGestionPort : Form
    {
        public FrmGestionPort()
        {
            InitializeComponent();
        }
        private List<Stockage> Stockages;
        private List<Navire> Navires;

        private void btnCreerPort_Click(object sender, EventArgs e)
        {
            Port Toulon = new Port();
            Stockages = new List<Stockage>();
            lbNbStockage.Text = Convert.ToString(0);
            btnCreerPort.Enabled = false;
            grbStockage.Enabled = true;
        }

        private void btnAfficherStockage_Click(object sender, EventArgs e)
        {
            comboBoxAfficherStockage.Items.Clear();
            comboBoxAfficherStockage.BeginUpdate();
            for(int i = 0; i < Stockages.Count; i++)
            {
                comboBoxAfficherStockage.Items.Add(Convert.ToString(Stockages.ElementAt(i).obtenirCapaDispo()));
            }
            
            comboBoxAfficherStockage.EndUpdate();
            comboBoxAfficherStockage.Text = comboBoxAfficherStockage.Items[0].ToString();
        }

        private void btnCreerStockage_Click(object sender, EventArgs e)
        {
            if(CapaciteCreer.Value <= 0)
            {
                MessageBox.Show("Capacité invalide ");
            }
            Stockages.Add(new Stockage(Convert.ToInt16(CapaciteCreer.Value), Convert.ToInt16(CapaciteCreer.Value)));
            if (Stockages.Count >= 3)
            {
                grbNavire.Enabled = true;
            }
            int coucou = Convert.ToInt16(lbNbStockage.Text);
            lbNbStockage.Text = Convert.ToString(coucou+1);
        }

        private void btnCreerNavire_Click(object sender, EventArgs e)
        {
            Navires = new List<Navire>();
            Navires.Add(new Navire(txNumero.Text, txNom.Text, txFret.Text, Convert.ToInt16(txQte.Text)));
            grbAction.Enabled = true;
        }

        private void btnAfficherNomBateau_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txNom.Text);
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDecharger_Click(object sender, EventArgs e)
        {

        }
    }
}
