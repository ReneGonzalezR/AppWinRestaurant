using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppWinRestaurant
{
    public partial class Form1 : Form
    {
        Restaurant restaurant = new(0,0);
        public Form1()
        {
            InitializeComponent();
            rbHamburgesa.Checked = true;
            lblIngredientes.Visible = false;
            lblChampiñon.Visible = false;
            lbltomate.Visible = false;
            lbllechuga.Visible = false;
            lblPapas.Visible = false;
            lblPepinillo.Visible = false;
            lblSoda.Visible = false;
            txtIngrediente.Visible = false;
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (rbHamburgesa.Checked)
            {
                restaurant.Agregar(1, 0);
                dtvIngredientes.Rows.Add(3);
                dtvIngredientes.Rows[restaurant.Contador - 3].Cells[0].Value = "Hamburgesa";
                dtvIngredientes.Rows[restaurant.Contador - 3].Cells[1].Value = "50";
                dtvIngredientes.Rows[restaurant.Contador - 2].Cells[0].Value = "Papas";
                dtvIngredientes.Rows[restaurant.Contador - 2].Cells[1].Value = "15";
                dtvIngredientes.Rows[restaurant.Contador - 1].Cells[0].Value = "Refresco";
                dtvIngredientes.Rows[restaurant.Contador - 1].Cells[1].Value = "15";
            }
            if (rbHotDog.Checked)
            {
                restaurant.Agregar(2, 0);
                dtvIngredientes.Rows.Add(3);
                dtvIngredientes.Rows[restaurant.Contador - 3].Cells[0].Value = "HotDog";
                dtvIngredientes.Rows[restaurant.Contador - 3].Cells[1].Value = "30";
                dtvIngredientes.Rows[restaurant.Contador - 2].Cells[0].Value = "Papas";
                dtvIngredientes.Rows[restaurant.Contador - 2].Cells[1].Value = "15";
                dtvIngredientes.Rows[restaurant.Contador - 1].Cells[0].Value = "Refresco";
                dtvIngredientes.Rows[restaurant.Contador - 1].Cells[1].Value = "15";
            }
            if (rbOtro.Checked)
            {
                dtvIngredientes.Rows.Add(1);
                switch (txtIngrediente.Text.ToUpper())
                {
                    case "TOMATE":
                        restaurant.Agregar(3, 2);
                        dtvIngredientes.Rows[restaurant.Contador - 1].Cells[0].Value = "Tomate";
                        dtvIngredientes.Rows[restaurant.Contador - 1].Cells[1].Value = "2";
                        break;
                    case "LECHUGA":
                        restaurant.Agregar(3, 1);
                        dtvIngredientes.Rows[restaurant.Contador - 1].Cells[0].Value = "Lechuga";
                        dtvIngredientes.Rows[restaurant.Contador - 1].Cells[1].Value = "1";

                        break;
                    case "CHAMPIÑONES":
                        restaurant.Agregar(3, 3);
                        dtvIngredientes.Rows[restaurant.Contador - 1].Cells[0].Value = "Champiñones";
                        dtvIngredientes.Rows[restaurant.Contador - 1].Cells[1].Value = "3";
                        break;
                    case "PAPA CRUNSH":
                        restaurant.Agregar(3, 10);
                        dtvIngredientes.Rows[restaurant.Contador - 1].Cells[0].Value = "Papas Crush";
                        dtvIngredientes.Rows[restaurant.Contador - 1].Cells[1].Value = "10";
                        break;
                    case "PEPINILLO":
                        restaurant.Agregar(3, 2.5);
                        dtvIngredientes.Rows[restaurant.Contador - 1].Cells[0].Value = "Pepinillo";
                        dtvIngredientes.Rows[restaurant.Contador - 1].Cells[1].Value = "2.5";
                        break;
                    case "SODA":
                        restaurant.Agregar(3, 15);
                        dtvIngredientes.Rows[restaurant.Contador - 1].Cells[0].Value = "Soda";
                        dtvIngredientes.Rows[restaurant.Contador - 1].Cells[1].Value = "15";
                        break;
                }
            }
            lblPedido.Text = restaurant.Total.ToString();
            double iva = restaurant.Total * 0.16;
            lblIva.Text = iva.ToString();
            lblTotal.Text = (restaurant.Total + iva).ToString();
        }
        private void btnQuitar_Click(object sender, EventArgs e)
        {
            double cantidad = Convert.ToDouble(dtvIngredientes.Rows[restaurant.Contador - 1].Cells[1].Value);
            dtvIngredientes.Rows.RemoveAt(restaurant.Contador - 1);
            restaurant.Quitar(1, cantidad);
            
            lblPedido.Text = restaurant.Total.ToString();
            double iva = restaurant.Total * 0.16;
            lblIva.Text = iva.ToString();
            lblTotal.Text = (restaurant.Total + iva).ToString();
        }

        private void rbHamburgesa_CheckedChanged(object sender, EventArgs e)
        {
            lblIngredientes.Visible = false;
            lblChampiñon.Visible = false;
            lbltomate.Visible = false;
            lbllechuga.Visible = false;
            lblPapas.Visible = false;
            lblPepinillo.Visible = false;
            lblSoda.Visible = false;
            txtIngrediente.Visible = false;
        }

        private void rbHotDog_CheckedChanged(object sender, EventArgs e)
        {
            lblIngredientes.Visible = false;
            lblChampiñon.Visible = false;
            lbltomate.Visible = false;
            lbllechuga.Visible = false;
            lblPapas.Visible = false;
            lblPepinillo.Visible = false;
            lblSoda.Visible = false;
            txtIngrediente.Visible = false;
        }

        private void rbOtro_CheckedChanged(object sender, EventArgs e)
        {
            lblIngredientes.Visible = true;
            lblChampiñon.Visible = true;
            lbltomate.Visible = true;
            lbllechuga.Visible = true;
            lblPapas.Visible = true;
            lblPepinillo.Visible = true;
            lblSoda.Visible = true;
            txtIngrediente.Visible = true;
            txtIngrediente.Text = string.Empty;
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPago.Text))
            {
                MessageBox.Show("Debe ingresar un valor", "Advertencia");
                txtPago.Focus();
            }
            else
            {
                double cantidad = Convert.ToDouble(lblTotal.Text) - Convert.ToDouble(txtPago.Text);
                cantidad = cantidad * -1;
                string cambio = string.Format("$ {0}", cantidad.ToString());
                MessageBox.Show(cambio, "Su Cambio");
            }
        }
    }
}
