using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNumeros
{
    class Numero
    {
        //atributos
        int numeromayor;
        int numeromenor;

        //construtor con parametros

        public Numero(int numeromayor, int numeromenor)
        {
            this.numeromayor = numeromayor;
            this.numeromenor = numeromenor;
        }
        //metosdos get y set
        public int Numeromayor
        {
            get
            {
                return Numeromayor;
            }
            set
            {
                Numeromayor = value;
            }
        }
        public int Numeromenor
        {
            get
            {
                return numeromenor;
            }
            set
            {
                numeromenor = value;
            }
        }
        //metodo transacional =operaciones

        public List<int> MostrarRango()
        {
            List<int> rango = new List<int>();
            for (int contador = numeromenor; contador <= numeromayor; contador++)
            {
                rango.Add(contador);
            }
            return rango;
        }

    }
}
