using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_Principal_Mascota
{
    class Perro
    {
        //Primero declaro los atributos y los inicializo
        public string Nombre = "";
        public Double Tamanho = 0;
        public int Peso = 0;

        //creo su constructor
        public Perro(string Nombre)
        {
            //asigno los valores que entran como parámetros a las variables reales
            this.Nombre = Nombre;
        }

        public Perro(Double Tamanho, int Peso)
        {
            //asigno los valores que entran como parámetros a las variables reales
            
            this.Tamanho = Tamanho;
            this.Peso = Peso;
        }

        //creo seis métodos
        public string Come(string alimento)
        {
            string[] frase = new string[] { " come un alimento ", "nutritivo", "dañino", "que no existe"};
            if (alimento.Length <= 5)
            {
                return frase[0] + frase[1];

            }else if (alimento.Length > 6)
            {
                return frase[0] + frase[2];
            }
            else
            {
                return frase[0] + frase[3];
            }
     
        }

        public Boolean Ladra(int si_no)
        {
            Boolean accion_respuesta;
            switch (si_no)
            {
                
                case 1:
                     accion_respuesta = true;
                    break;
                case 0:
                    accion_respuesta = false;
                    break;
                default:
                    accion_respuesta = false;
                    break;
            }
            return accion_respuesta;
        }

        public int Orina(string horina_si_no)
        {
            int tiempo_extra_vida = 0;

            if (horina_si_no == "si" || horina_si_no == "Si")
            {
                tiempo_extra_vida = 10;
            }
            else
            {
                tiempo_extra_vida = -1;
            }
            
            return tiempo_extra_vida;
        }

        public string Muerde(string r_sino)
        {
            string superpoder = " ";

            if (r_sino == "si" || r_sino == "Si")
            {
                superpoder = "algún día esa morida te dará un super poder";
            }
            else
            {
                superpoder = "algún tu lo morderás ";
            }

            return superpoder;

        }

        public float Corre(string r_correr)
        {
            Random rnd = new Random();

            float km = 0.0f;

            if (r_correr == "si" || r_correr == "Si")
            {
                km = rnd.Next(1, 10);
                if (km==2)
                {
                    km += 4;
                }
                else
                {
                    km -= 1;
                }
            }
            else
            {
                km = rnd.Next(1, 15);
            }

            return km;
        }

        public Boolean se_hace_el_muerto(string rr_sino)
        {
            Boolean salir = false;
            if (rr_sino == "si" || rr_sino == "Si")
            {
                Random rnnd = new Random();
                int salida = rnnd.Next(0, 1);
                if (salida == 0)
                {
                    salir = true;
                }else
                {
                    salir = false;
                }
                
            }
            return salir;

        }
    }
}
