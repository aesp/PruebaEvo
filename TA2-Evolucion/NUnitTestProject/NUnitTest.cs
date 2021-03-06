﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TA2_Evolucion;
using NUnit.Framework;

namespace NUnitTestProject
{
    [TestFixture]
    public class NUnitTest
    {
        [Test]
        public void TestSumar()
        {
            TestClass objeto = new TestClass();
            Assert.AreEqual(7, objeto.Sumar(3, 4));
        }

        [Test]
        public void TestMayorA10()
        {
            TestClass objeto = new TestClass();
            Assert.AreEqual("Mayor", objeto.MayorA10(15));
        }

        [Test]
        public void TestRestar()
        {
            TestClass objeto = new TestClass();
            Assert.AreNotEqual(7, objeto.Restar(8, 2));
        }

        [Test]
        public void TestGetLetra()
        {
            TestClass objeto = new TestClass();
            Assert.AreNotEqual("ro", objeto.SepararCadena("Perro", 2));
        }

        [Test]
        public void TestGetDato()
        {
            TestClass objeto = new TestClass();
            Assert.IsNull(objeto.BuscarDato("huron"));
        }

        [Test]
        public void TestNumeroEncontrado()
        {
            TestClass objeto = new TestClass();
            Assert.IsTrue(objeto.NumeroEncontrado(8));
        }

        [Test]
        public void TestGetLista()
        {
            TestClass objeto = new TestClass();
            List<double> lista = new List<double>();
            lista.Add(15.5);
            lista.Add(20.3);
            lista.Add(30.3);

            CollectionAssert.AreEqual(lista, objeto.GetLista());
        }

        [Test]
        public void GetListaNombres()
        {
            TestClass objeto = new TestClass();
            List<string> lista = new List<string>();
            lista.Add("lapicero");
            lista.Add("borrador");
            lista.Add("tinta");

            List<string> actual = objeto.GetListaNombres();

            CollectionAssert.AreEqual(lista, actual);
        }

        [Test]
        public void BuscarProductoPorCodigo()
        {
            TestClass objeto = new TestClass();
            Producto esperado = new Producto();
            esperado.Codigo = 1; esperado.Nombre = "Lapicero"; esperado.Descripcion = "Pilot"; esperado.Precio = 3.5;

            Producto actual = objeto.BuscarProductoPorCodigo(1);

            Assert.AreEqual(esperado.Codigo, actual.Codigo);
            Assert.AreEqual(esperado.Nombre, actual.Nombre);
            Assert.AreEqual(esperado.Descripcion, actual.Descripcion);
            Assert.AreEqual(esperado.Precio, actual.Precio);
        }

        [Test]
        public void BuscarProductoPorNombre()
        {
            TestClass objeto = new TestClass();
            Producto esperado = new Producto();
            esperado.Codigo = 1; esperado.Nombre = "Lapicero"; esperado.Descripcion = "Pilot"; esperado.Precio = 3.5;

            Producto actual = objeto.BuscarProductoPorNombre("Lapicero");

            Assert.AreEqual(esperado.Codigo, actual.Codigo);
            Assert.AreEqual(esperado.Nombre, actual.Nombre);
            Assert.AreEqual(esperado.Descripcion, actual.Descripcion);
            Assert.AreEqual(esperado.Precio, actual.Precio);
        }

        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void TestIngresoDato()
        {
            TestClass objeto = new TestClass();
            Producto producto = new Producto();
            producto.Codigo = 2;
            producto.Nombre = null;
            producto.Descripcion = "prueba";
            try
            {
                objeto.IngresoDatos(producto);
            }
            catch (Exception ex)
            {
                Assert.AreEqual("Nombre no existe", ex.Message);
                throw;
            }
        }

        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void TestDivision()
        {
            try
            {
                TestClass objeto = new TestClass();
                double resultado = objeto.Division(5, 0);
            }
            catch (Exception ex)
            {
                Assert.AreEqual("No se puede dividir entre cero", ex.Message);
                throw;
            }
        }
    }
}
