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
    public partial class FrmEnviarCorreo : Form
    {
        public FrmEnviarCorreo()
        {
            InitializeComponent();
        }

        private void FrmEnviarCorreo_Load(object sender, EventArgs e)
        {
            txtdireccion.Text = FrmPrincipal.Email;
            txtAsunto.Text = "Señor: " + FrmPrincipal.contacto;
        }
        
        private void btnEnviar_Click(object sender, EventArgs e)
        {
            this.Close();
            string mensaje = "Correo enviado";
            MessageBox.Show(mensaje);

        }
    }
}
