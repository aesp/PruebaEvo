using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TA2_Evolucion
{
    public class TestClass
    {
        //1.- Valores Iguales

        public int Sumar(int num1, int num2)
        {
            return num1 + num2;
        }

        public string MayorA10(int num)
        {
            if (num > 10)
                return "Mayor";
            else
                return "Menor";
        }

        //2.- Valores Diferentes

        public int Restar(int num1, int num2)
        {
            return num1 - num2;
        }

        public string SepararCadena(string palabra, int pos)
        {
            return palabra.Substring(pos, palabra.Length-pos);
        }

        //3.- Valores Nulos

        public string BuscarDato(string palabra)
        {
            List<string> lista = new List<string>();
            lista.Add("perro"); lista.Add("gato");

            foreach (string item in lista)
            {
                if (item == palabra)
                    return item;
            }
            return null;
        }

        //4.- Valores boolean

        public bool NumeroEncontrado(int num)
        {
            List<int> lista = new List<int>();
            lista.Add(8);
            lista.Add(7);
            lista.Add(10);

            foreach (int val in lista)
            {
                if (val == num)
                    return true;
            }
            return false;
        }

        //5.- Arreglos

        public List<double> GetLista()
        {
            List<double> listaReal = new List<double>();
            listaReal.Add(15.5);
            listaReal.Add(20.3);
            listaReal.Add(30.3);

            return listaReal;
        }

        public List<string> GetListaNombres()
        {
            List<string> lista = new List<string>();
            lista.Add("lapicero");
            lista.Add("borrador");
            lista.Add("tinta");
            return lista;
        }

        //6.- Objetos

        public Producto BuscarProductoPorNombre(string nombre)
        {
            List<Producto> lista = new List<Producto>();
            Producto p = new Producto();
            p.Codigo = 1; p.Nombre = "Lapicero"; p.Descripcion = "Pilot"; p.Precio = 3.5;
            Producto p1 = new Producto();
            p1.Codigo = 2; p1.Nombre = "Borrador"; p1.Descripcion = "Staedler"; p.Precio = 2.5;
            lista.Add(p); lista.Add(p1);

            foreach (Producto prod in lista)
            {
                if (prod.Nombre == nombre)
                    return prod;
            }
            return null;
        }

        public Producto BuscarProductoPorCodigo(int codigo)
        {
            List<Producto> lista = new List<Producto>();
            Producto p = new Producto();
            p.Codigo = 1; p.Nombre = "Lapicero"; p.Descripcion = "Pilot";p.Precio=3.5;
            Producto p1 = new Producto();
            p1.Codigo = 2; p1.Nombre = "Borrador"; p1.Descripcion = "Staedler";p.Precio=2.5;
            lista.Add(p); lista.Add(p1);

            foreach (Producto prod in lista)
            {
                if (prod.Codigo == codigo)
                    return prod;
            }
            return null;
        }

        //7.- Excepciones
        public void IngresoDatos(Producto producto)
        {
            if (producto.Codigo < 0) throw new Exception("Código debe ser mayor a cero");
            else if (String.IsNullOrEmpty(producto.Nombre)) throw new ArgumentException("Nombre no existe");
            else if (String.IsNullOrEmpty(producto.Descripcion)) throw new ArgumentException("Descripción del producto no existe");
            else if (producto.Precio<0) throw new ArgumentException("Precio debe ser mayor a 0");
        }

        public double Division(double num1, double num2)
        {
            if (num2 == 0) throw new ArgumentException("No se puede dividir entre cero");

            return num1 / num2;
        }

    }
}

