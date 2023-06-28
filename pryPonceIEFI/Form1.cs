using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;

namespace pryPonceIEFI
{
    public partial class pryPonceIEFI : Form
    {
        public pryPonceIEFI()
        {
            InitializeComponent();
        }

        private void btnAgregarPais_Click(object sender, EventArgs e)
        {
            if (txtPais.Text == "")
            {
                MessageBox.Show("ingrese dato");
                return;
            }
            else
            {
                Club objConn = new Club();
                objConn.cargarPais(txtPais.Text);
                objConn.cargarCombo(cmbpais);
            }
            txtPais.Text = "";
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {

           
            string nombre = txtnombre.Text;
            string apellido = txtapellido.Text;
            string pais = cmbpais.SelectedItem.ToString();
            int edad = (int)umEdad.Value;
            bool esMasculino = rbnmasculino.Checked;
            decimal importe = decimal.Parse(txtingreso.Text);
            int puntaje = int.Parse(txtpuntaje.Text);

            if (umEdad.Value > 49 || importe > 1000 || puntaje > 130)
            {
                MessageBox.Show("RECUERDE: Edad mayor a 49, Importe mayor a $1000, Puntaje mayor a 130",
                "Mensaje de Alerta",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);

                return;
            }
            else
            {
               
                Club objConn = new Club();
                objConn.agregarSocio(nombre, apellido, pais, edad, esMasculino, importe, puntaje);

                MessageBox.Show("socio nuevo del club.");

                
                txtnombre.Text = "";
                txtapellido.Text = "";
                cmbpais.SelectedIndex = -1;
                umEdad.Value = 0;
                rbnfemenino.Checked = false;
                rbnmasculino.Checked = false;
                txtingreso.Text = "";
                txtpuntaje.Text = "";
            }
        }

        private void btnregistrar_Click_1(object sender, EventArgs e)
        {
           
            string nombre = txtnombre.Text;
            string apellido = txtapellido.Text;
            string pais = cmbpais.SelectedItem.ToString();
            int edad = (int)umEdad.Value;
            bool esMasculino = rbnmasculino.Checked;
            decimal importe = decimal.Parse(txtingreso.Text);
            int puntaje = int.Parse(txtpuntaje.Text);

            if (umEdad.Value > 49 || importe > 1000 || puntaje > 130)
            {
                MessageBox.Show("RECUERDE: Edad mayor a 49, Importe mayor a $1000, Puntaje mayor a 130",
                "Mensaje de Alerta",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);

                return;
            }
            else
            {
               
                Club objConn = new Club();
                objConn.agregarSocio(nombre, apellido, pais, edad, esMasculino, importe, puntaje);

                MessageBox.Show("Socio agregado con éxito.");

               
                txtnombre.Text = "";
                txtapellido.Text = "";
                cmbpais.SelectedIndex = -1;
                umEdad.Value = 0;
                rbnfemenino.Checked = false;
                rbnmasculino.Checked = false;
                txtingreso.Text = "";
                txtpuntaje.Text = "";
            }
        }

        private void txtnombre_TextChanged(object sender, EventArgs e)
        {
            if (txtnombre.Text != "")
            {
                txtapellido.Enabled = true;
            }
            else
            {
                txtapellido.Enabled = false;
            }

       
        }

        private void txtapellido_TextChanged(object sender, EventArgs e)
        {
            if (txtapellido.Text != "")
            {
                cmbpais.Enabled = true;
            }
            else
            {
                cmbpais.Enabled = false;
            }
        }

        private void cmbpais_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbpais.SelectedIndex != -1)
            {
                umEdad.Enabled = true;
            }
            else
            {
                umEdad.Enabled = false;
            }
        }

        private void umEdad_ValueChanged(object sender, EventArgs e)
        {
            if (umEdad.Value != 0)
            {
                lbltipodesexo.Enabled = true;
            }
            else
            {
                lbltipodesexo.Enabled = false;
            }
        }

        private void rbnmasculino_CheckedChanged(object sender, EventArgs e)
        {
            if (rbnmasculino.Checked == true)
            {
                txtingreso.Enabled = true;
            }
            else
            {
                txtingreso.Enabled = false;
            }
        }

        private void txtpuntaje_TextChanged(object sender, EventArgs e)
        {
            if (txtpuntaje.Text != "")
            {
                btnregistrar.Enabled = true;
            }
            else
            {
                btnregistrar.Enabled = false;
            }
        }

        private void txtingreso_TextChanged(object sender, EventArgs e)
        {
            if (txtingreso.Text != "")
            {
                txtpuntaje.Enabled = true;
            }
            else
            {
                txtpuntaje.Enabled = false;
            }
        }
    }
    }
