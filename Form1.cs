using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AS2122_3G_INF_RenziNicolo__Pizzeria
{
    public partial class Form1 : Form
    {
        int nMarghe = 0, nVeg = 0, n4Stag = 0;

        private void txtQuantita_TextChanged(object sender, EventArgs e)
        {

        }

        public Form1()
        {
            InitializeComponent();
        }
       
        private void btnCarica_Click(object sender, EventArgs e)
        {
            int quantitaSingole;
            quantitaSingole = Convert.ToInt32(txtQuantita.Text);
            switch(cmbTipoPizze.Text)
            {
            case "Margherita":
                if (quantitaSingole >= 0)
                 {
                    lstOrdini.Items.Add($"Margherite: {quantitaSingole}");
                    nMarghe += quantitaSingole;
                    lblNMarghe.Text = Convert.ToString(nMarghe);
                 }
                else
                        lstOrdini.Items.Add("Non hai inserito una quantità");
                break;
            case "Vegetariana":
                if (quantitaSingole >= 0)
                {
                    lstOrdini.Items.Add($"Vegetariana: {quantitaSingole}");
                    nVeg = nVeg + quantitaSingole;
                    lblVege.Text = Convert.ToString(nVeg);
                }
                else
                    lstOrdini.Items.Add("Non hai inserito una quantità");
                 break;
            case "4 Stagioni":
               if (quantitaSingole >= 0)
               {
                    lstOrdini.Items.Add($"4 Stagioni: {quantitaSingole}");
                    n4Stag += quantitaSingole;
                    lbl4Stag.Text = Convert.ToString(n4Stag);
               }
               else                   
                    lstOrdini.Items.Add("Non hai inserito una quantità");                                        
                 break;
            default:
                    lstOrdini.Items.Add("Non hai inserito il tipo di pizza");
                 break;
            }
        }
    }
}
