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
    public partial class FrmPrincipal : Form
    {
        private int n = 0;
        public static string NumCel;
        public static string NumTel;
        public static string Email;
        public static string contacto;
        public static int total_contactos;

        public FrmPrincipal()
        {
            InitializeComponent();
            this.Cursor = Cursors.Arrow;
            this.btnEliminar.Enabled = false;
        } 
        
        //evento al dar click al Boton de Agregar contacto
        private void btnAgregar_Click(object sender, EventArgs e)
        {
           
            if (txtNombre.Text != "")
            {
                //Se agregran filas al DataGridView y se asigana a la variable row el valor de la fila selecionada actual
                int row = dtgAgenda.Rows.Add();
                //se asigna a la varable n el valor de la fila seleccionada actual
                n = row;

                //Se agrega cada valor ingresado al DataGridView
                dtgAgenda.Rows[row].Cells[0].Value = txtNombre.Text;
                dtgAgenda.Rows[row].Cells[1].Value = txtTel.Text;
                dtgAgenda.Rows[row].Cells[2].Value = txtCel.Text;
                dtgAgenda.Rows[row].Cells[3].Value = txtEmail.Text;

                //Se limpian los textbox
                txtCel.Text = "";
                txtNombre.Text = "";
                txtEmail.Text = "";
                txtTel.Text = "";
            }
            else
            {
                string mensaje = "ERROR: No se a agregado ningun valor en la casilla Nombre";
                MessageBox.Show(mensaje);
            }

            total_contactos = dtgAgenda.Rows.Count;
            total_contactos--;
            lblinfo.Text = "Total de Contactos " + total_contactos.ToString();

        }

        
        //evento al dar click al boton Eliminar
        private void btnEliminar_Click(object sender, EventArgs e)
        {
           
            {
                try
                {
                    //se crea formulario para consultar si desea borrar el contacto                 
                    DialogResult result;
                   result = MessageBox.Show("Realmente desea eliminar este contacto?", "Eliminando registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                   
                    if (result == DialogResult.OK)
                    {
                      dtgAgenda.Rows.RemoveAt(n);
                      total_contactos = dtgAgenda.Rows.Count;
                      total_contactos--;
                      lblinfo.Text = "Total de Contactos " + total_contactos.ToString();
                      //Se limpian los textbox
                      txtCel.Text = "";
                      txtNombre.Text = "";
                      txtEmail.Text = "";
                      txtTel.Text = "";
                      string mensaje = "El contacto fue ELIMINADO";
                      MessageBox.Show(mensaje);
                    }
                    else
                    {
                        //en caso de algun error se presenta este mensaje
                        string mensaje = "Se CANCELO la eliminacion del contacto";
                        MessageBox.Show(mensaje);
                    }

                }
                catch (Exception) //bloque catch para captura de error
                {
                    string mensaje = "ATENCION : Este registro no se puede borrar";
                    MessageBox.Show(mensaje);
                }

                total_contactos = dtgAgenda.Rows.Count;
                total_contactos--;
                lblinfo.Text = "Total de Contactos " + total_contactos.ToString();
            }

           
        }
        
        //evento generado al dar Click en alguna celda
        private void dtgAgenda_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          
            //se asigna valores a las variables
            int fila = e.RowIndex;
            int columna = e.ColumnIndex;
            n = fila;
            //se cambian valores de los objetos que sea necesario
            btnAgregar.Enabled = false;
            this.btnEliminar.Enabled = true;
            txtCel.Text = (string)dtgAgenda.Rows[fila].Cells[2].Value;
            txtNombre.Text = (string)dtgAgenda.Rows[fila].Cells[0].Value; ;
            txtEmail.Text = (string)dtgAgenda.Rows[fila].Cells[3].Value; ;
            txtTel.Text = (string)dtgAgenda.Rows[fila].Cells[1].Value; ;


            //se verifica si se dio click sobre algun numero de telefono Fijo
            if (e.ColumnIndex == this.dtgAgenda.Columns[1].Index)

            {
                //se asigna a variable info el # de telefono a llamar
                NumTel = (string)dtgAgenda.Rows[fila].Cells[columna].Value;

                if (NumTel != null)
                {
                    if (NumTel != "")
                    {
                        //se crea el objeto Frmllamar 
                        Frmllamada Frmllamar = new Frmllamada();
                        Frmllamar.Show();
                    }
                    else
                    {
                        string msg = "No hay numero anotado para poder llamar";
                        MessageBox.Show(msg);
                    }
                }


            }

            //se verifica si se dio click sobre algun numer de telefono celular
            if (e.ColumnIndex == this.dtgAgenda.Columns[2].Index)

            {
                //se asigna a variable info el # de celular a llamar
                NumTel = (string)dtgAgenda.Rows[fila].Cells[columna].Value;

                if (NumTel != null)
                {
                    if (NumTel != "")
                    {
                        //se crea el objeto Frmllamar 
                        Frmllamada Frmllamar = new Frmllamada();
                        Frmllamar.Show();
                    }
                    else
                    {
                        string msg = "No hay numero anotado para poder llamar";
                        MessageBox.Show(msg);
                    }
                }

            }

            //se verifica si se dio click sobre una direccion de email
            if (e.ColumnIndex == this.dtgAgenda.Columns[3].Index)
            {
                //se asigna a variable info el # de celular a llamar
                Email = (string)dtgAgenda.Rows[fila].Cells[columna].Value;
                contacto = (string)dtgAgenda.Rows[fila].Cells[0].Value;

                if (Email != null)
                {
                    if (Email != "")
                    {
                        //se crea el objeto FrmEmail
                        FrmEnviarCorreo FrmEmail = new FrmEnviarCorreo();
                        FrmEmail.Show();
                    }
                    else
                    {
                        string msg = "No hay direccion Email , Favor agregue una";
                        MessageBox.Show(msg);
                    }
                }
                

            }
        }


        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            //se establecen los anchos de las columnas
            dtgAgenda.Columns[0].Width = 300;
            dtgAgenda.Columns[1].Width = 100;
            dtgAgenda.Columns[2].Width = 100;
            dtgAgenda.Columns[3].Width = 200;

            total_contactos = dtgAgenda.Rows.Count;
            total_contactos--;
            lblinfo.Text = "Total de Contactos " + total_contactos.ToString();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.btnAgregar.Enabled = true;
            this.btnEliminar.Enabled = false;
            //Se limpian los textbox
            txtCel.Text = "";
            txtNombre.Text = "";
            txtEmail.Text = "";
            txtTel.Text = "";
        }

        //No se utilizo
        private void dtgAgenda_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            //string msg = "Prueba";
           // MessageBox.Show(msg);
        }
    }
}
