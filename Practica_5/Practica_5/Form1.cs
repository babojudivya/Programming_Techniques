using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_5
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Operacion_M calculo = new Operacion_M();
        CountException contarl = new CountException();
        Limpiar limpiarcito = new Limpiar();

        private void AddProduct(object sender, EventArgs e)
        {
            try
            {
                Double Cuenta = 0, CapitalTotal = 0;
                Double Precio = 0;
                String Producto = null;

                CapitalTotal = Convert.ToDouble(this.txt_AvailableCapital.Text);
                Precio = Convert.ToDouble(txtboxCost.Text);
                Producto = this.txtboxProductName.Text;

                contarl.ContarLetras(Producto);


                Listado.Items.Add(Producto + "\t$" + Precio);

                this.txtboxProductName.Focus();
                this.txtboxProductName.Clear();
                this.txtboxCost.Focus();
                this.txtboxCost.Clear();

                Cuenta = calculo.Suma_M(Precio);

                richCuenta.Text = "$" + Convert.ToString(Cuenta);
                Double ko = calculo.DienroRestante(CapitalTotal);
                txt_Remaining_Capital.Text = Convert.ToString(ko);
                //}



            }
            catch (System.FormatException)
            {
                if (string.IsNullOrEmpty(txt_AvailableCapital.Text) && string.IsNullOrEmpty(txtboxProductName.Text) && string.IsNullOrEmpty(txtboxCost.Text))
                {
                    MessageBox.Show("System.FormatException \n PLease, enter the correct character in all boxes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if (string.IsNullOrEmpty(txt_AvailableCapital.Text))
                {

                    MessageBox.Show("System.FormatException \n PLease, enter a number in the Capital box", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (string.IsNullOrEmpty(txtboxProductName.Text))
                {
                    MessageBox.Show("System.FormatException \n PLease, enter a number in the Product box", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (string.IsNullOrEmpty(txtboxCost.Text))
                {

                }
                else
                {
                    MessageBox.Show("System.FormatException \n PLease, Next time check that your data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }
            catch (Operacion_M)
            {
                MessageBox.Show("WithoutMoneyException \n PLease, Tell the cashier to cancel your purchase", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (CountException)
            {
                MessageBox.Show("CountException \n PLease, the product must have a maximum of 15 characters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                MessageBox.Show("Enjoy your purchase");
            }


        }

        private void Only(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Only Words", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void LimpiarAcciones(object sender, EventArgs e)
        {
            limpiarcito.BorrarCampos(this);
        }

        private void adios(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Bye");
        }
    }
}
