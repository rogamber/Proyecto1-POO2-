using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto1_POO2_UNED_RonnyGamboa
{
    public partial class Frmllamada : Form
    {
        public Frmllamada()
        {
            InitializeComponent();
          
        }

        private void Frmllamada_Load(object sender, EventArgs e)
        {
            //se asigna al lbl el numero a llamar
            lblnumero.Text = FrmPrincipal.NumTel;
        }

       private void btncancelar_Click(object sender, EventArgs e)
        {
            //se cierra el form simulando finalizacion de la llamada
            this.Close();
            String msg = "Se a cancelado la llamada";
            MessageBox.Show(msg);

        }
    }
}
