using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Security_System_México
{
    public partial class InterfazGrafica : Form
    {
        Clase_Iris ObjetoIris = new Clase_Iris();
        Clase_Voz ObjetoVoz = new Clase_Voz();
        Clase_Dactilar ObjetoDactilar = new Clase_Dactilar();
        internal Boolean Atributo_Iris = false;
        internal Boolean Atributo_Voz = false;
        internal Boolean Atributo_Dactilar = false;

        /*
         * Variables para mover la interfaz
         */

        int posY = 0;
        int posX = 0;

        public InterfazGrafica()
        {
            InitializeComponent();
            //cboUsuario.DropDownStyle = ComboBoxStyle.DropDownList;
            //cboSensor.DropDownStyle = ComboBoxStyle.DropDownList;
                
        }

        /*
         * Método para poder mover la interfaz
         */

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button != MouseButtons.Left)
            {
                posX = e.X;
                posY = e.Y;

            }
            else
            {
                Left = Left + (e.X - posX);
                Top = Top + (e.Y - posY);
            }
        }

        /*
         * Método para cerrar la interfaz
         */

        private void pboClose_Click(object sender, EventArgs e)
        {
            //this.Close();
            //this.Dispose();
            Application.Exit();
        }

        /*
         * *Método para cerrar la minimizar
         */
        private void pboMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            //MessageBox.Show("Regresa pronto");
        }

        /*
         *Método que regresa el ID
         */
        private void input_ID(object sender, EventArgs e)
        {
            //TodosLosSensores.ID_Atributo = txtboID.Text;

        }

        /*
         * Método para leer el usuario 
         */

        private void Tipo_Usuario(object sender, EventArgs e)
        {
            //TodosLosSensores.TipoUsuario_Atributo = cboUsuario.SelectedItem.ToString();
        }

        /*
        * Método para leer el usuario 
        */
        public void Tipo_Sensor(object sender, EventArgs e)
        {
            try
            {
                if ("Iris" == this.cboSensor.SelectedItem.ToString())
                {
                    ObjetoIris.SetTipoUsuario_Atributo(this.cboSensor.SelectedItem.ToString()); 
                    ObjetoIris.SetTipoUsuario_Atributo(this.cboUsuario.SelectedItem.ToString());//cboUsuario
                    Atributo_Iris = true;
                   
                }
                else if ("Voz" == this.cboSensor.SelectedItem.ToString())
                {
                    ObjetoVoz.SetTipoUsuario_Atributo(this.cboSensor.SelectedItem.ToString());
                    ObjetoVoz.SetTipoUsuario_Atributo(this.cboUsuario.SelectedItem.ToString());
                    Atributo_Voz = true;
                    //ObjetoVoz.GetID();
                }
                else if("Dactilar" == this.cboSensor.SelectedItem.ToString() )
                {
                    ObjetoDactilar.SetTipoUsuario_Atributo(this.cboSensor.SelectedItem.ToString());
                    ObjetoDactilar.SetTipoUsuario_Atributo(this.cboUsuario.SelectedItem.ToString());
                    Atributo_Dactilar = true;
                    //ObjetoDactilar.GetID();
                }
            }
            catch (Exception )
            {
                
            }
        }

        public void Btn_Acceder(object sender, EventArgs e)
        {
            
            string Mensaje_ID = null;
            //string Mensaje_Alarma = null;
            
            
            bool Mensaje_Identificar_Usuario = false;

            if (Atributo_Iris)
            {
                Mensaje_ID = ObjetoIris.GetID();
                //Mensaje_Alarma = ObjetoIris.ActivarAlarma();
                Mensaje_Identificar_Usuario = ObjetoIris.IdentificarUsuario();
                

            }  else if (Atributo_Voz)
            {
                  Mensaje_ID = ObjetoVoz.GetID();
                 // Mensaje_Alarma = ObjetoVoz.ActivarAlarma();
                Mensaje_Identificar_Usuario = ObjetoVoz.IdentificarUsuario();
            }
            else if (Atributo_Dactilar) //Atributo_Dactilar
            {
                  Mensaje_ID = ObjetoDactilar.GetID();
                  //Mensaje_Alarma = ObjetoDactilar.ActivarAlarma();
                Mensaje_Identificar_Usuario = ObjetoDactilar.IdentificarUsuario();

            }
            

            this.txtboID.Text = Mensaje_ID;
            this.MostrarValidacion.Text = "Acceso: " + Mensaje_Identificar_Usuario.ToString() + Environment.NewLine;
            this.MostrarValidacion.Text += "Usuario: " + Mensaje_ID + Environment.NewLine;
            //this.MostrarValidacion.Text += Mensaje_Alarma;


        Atributo_Iris = false;
        Atributo_Voz = false;
        Atributo_Dactilar = false;
    }
    }
}
