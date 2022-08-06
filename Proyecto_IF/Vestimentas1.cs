using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto_IF
{
    public class Vestimentas1
    {
        public List<Vestimenta1> Vestimentas = new List<Vestimenta1>();
        public Vestimentas1()
        {
            Vestimentas = new List<Vestimenta1>();
        }
        
        //Listamos los datos
        public void Agregar(Vestimentas vestimentas)
        {
            Vestimentas.Add(vestimentas);
        }
        //Nombre del comprador que contenga alguna cadena
        public List<Vestimenta1> Cadena(string cadena)
        {
            List<Vestimenta1> aux = new List<Vestimenta>();
            foreach (Vestimenta vestimenta in Vestimentas1)
            {
                if (vestimenta.Nombre.Contains(cadena))
                {
                    aux.Add(vestimenta);
                }
            }
            return aux;
        }
        public List<Vestimenta> PreciodeVestimenta()
        {
            List<Vestimenta> aux = new List<Vestimenta>();
            foreach (Vestimenta vestimenta in Vestimentas1)
            {
                if (vestimenta.PreciodeVestimenta > 50)
                {
                    aux.Add(vestimenta);
                }
            }
            return aux;
        }
    }
}
