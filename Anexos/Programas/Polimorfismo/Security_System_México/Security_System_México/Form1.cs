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
        Clase_Sensores TodosLosSensores = new Clase_Sensores();

        public InterfazGrafica()
        {
            InitializeComponent();
            //richTextBox1.Text = tipoUsuario;
            MostrarValidacion.Text = "Acceso Denegado";
            MostrarValidacion.Text = "Acceso Permitido";

            cboUsuario.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSensor.DropDownStyle = ComboBoxStyle.DropDownList;
                
        }

        int posY = 0;
        int posX = 0;
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

        private void pboClose_Click(object sender, EventArgs e)
        {
            //this.Close();
            //this.Dispose();
            Application.Exit();
        }

        private void pboMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            //MessageBox.Show("Regresa pronto");
        }

        private void input_ID(object sender, EventArgs e)
        {
            TodosLosSensores.ID_Atributo = txtboID.Text;

        }

        private void Tipo_Usuario(object sender, EventArgs e)
        {
            TodosLosSensores.TipoUsuario_Atributo = cboUsuario.SelectedItem.ToString();
        }

        private void Tipo_Sensor(object sender, EventArgs e)
        {
            TodosLosSensores.TipoSensor_Atributo = cboUsuario.SelectedItem.ToString();
        }

        private void btn_Acceder(object sender, EventArgs e)
        {
            if ((cboUsuario.SelectedItem.ToString() == "Directivo") && (cboUsuario.SelectedItem.ToString() == "Iris") && (txtboID.Text == "Directivo"))
            {
                
                    TodosLosSensores.TipoUsuario_Atributo = cboUsuario.SelectedItem.ToString();
                    TodosLosSensores.TipoSensor_Atributo = cboUsuario.SelectedItem.ToString();
                    TodosLosSensores.ID_Atributo  = txtboID.Text;

            }
            else if ((cboUsuario.SelectedItem.ToString() == "Académico") && ((cboUsuario.SelectedItem.ToString() == "Voz") || ((cboUsuario.SelectedItem.ToString() == "Dactilar"))) && (txtboID.Text == "Académico"))
            {
                TodosLosSensores.TipoUsuario_Atributo = cboUsuario.SelectedItem.ToString();
                TodosLosSensores.TipoSensor_Atributo = cboUsuario.SelectedItem.ToString();
                TodosLosSensores.ID_Atributo = txtboID.Text;
            }
            else if ((cboUsuario.SelectedItem.ToString() == "Estudiante") && (cboUsuario.SelectedItem.ToString() == "Dactilar") && (txtboID.Text == "Estudiante"))
            {
                TodosLosSensores.TipoUsuario_Atributo = cboUsuario.SelectedItem.ToString();
                TodosLosSensores.TipoSensor_Atributo = cboUsuario.SelectedItem.ToString();
                TodosLosSensores.ID_Atributo = txtboID.Text;
            }
            else
            {
                //metodo bloquear accedert a reachbox
            }

            

        }



    }
}
