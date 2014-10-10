using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPersona
{
    class persona
    {
        //declarar atributos
        string nombre;
        int edad;

        //construtor es una funcion
        public persona()
        {
        }
        //construtor con parametros
        public persona(string nombre, int edad)
        {
            this.nombre = nombre;
            this.edad = edad;
        }
        //metodos get y set
        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre=value;
            }
        }
         public int Edad
        {
            get
            {
                return edad;
            }
            set
            {
                edad=value;
            }
        }
        //metodos transacionales
    }
}
